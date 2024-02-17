<script>
    import {openModal} from "../store";
    
</script>

<header class="flex flex-col relative z-20">
    <div class="max-w-[1400px] mx-auto w-full flex justify-between
        items-center p-4 py-6">
        <a href="/" >
            <h1 class="font-semibold"> Swoley <span class="text-indigo-400"> Moley </span> </h1>
        </a>
        <button class="md:hidden grid place-items-center" on:click={() => $openModal = true}>
            <i class="fa-solid fa-bars"></i>
        </button>
        <nav class="hidden md:flex items-center gap-4 lg:gap-6">
            <a class="duration-200 hover:text-indigo-400 cursor-pointer"
             href="#product">
              Product
             </a>
            <a class="duration-200 hover:text-indigo-400 cursor-pointer"
             href="#reviews">
              Reviews
             </a>
            <a class="duration-200 hover:text-indigo-400 cursor-pointer"
             href="#faqs">
              FAQs
             </a>
            <button class="specialBtn">
                <p>Start free today</p>
            </button>
        </nav>  
</header>