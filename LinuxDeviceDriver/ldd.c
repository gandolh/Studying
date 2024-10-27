#include <linux/init.h>
#include <linux/module.h>
#include <linux/proc_fs.h>

MODULE_LICENSE("GPL");
MODULE_AUTHOR("Gandolh");
MODULE_DESCRIPTION("First dynamically loadable kernel module");

static struct proc_dir_entry *custom_proc_node;


static ssize_t pyjama_read(struct file* file_pointer, char __user* user_space_buffer, size_t count, loff_t* offset)
{
    char msg[] = "YESSIR!\n";
    size_t len = strlen(msg);
    int res = copy_to_user(user_space_buffer, msg, len);
    *offset+=len;
    if(*offset >= len) return 0;
    return len;
}

struct proc_ops driver_proc_ops = {
    .proc_read= pyjama_read
};

static int pyjama_module_init(void)
{
    printk("pyjama_module_init: entry\n");
    custom_proc_node = proc_create("pyjama_driver", 0, NULL , &driver_proc_ops);
    printk("pyjama_module_init: exit\n");
    return 0;
}

static void pyjama_module_exit(void)
{
    printk("pyjama_module_exit: entry\n");
    proc_remove(custom_proc_node);
    printk("pyjama_module_exit: exit\n");
}

module_init(pyjama_module_init);
module_exit(pyjama_module_exit);
