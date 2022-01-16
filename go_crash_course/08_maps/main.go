package main

import "fmt"

func main() {
	//define map
	// emails := make(map[string]string)

	//assing kv
	// emails["Bob"] = "bob@gmail.com"
	// emails["sheeran"] = "sher@gmail.com"
	// emails["Mike"] = "mick@gmail.com"
	//declare map and add kv
	emails := map[string]string{"Bob": "bob@gmail.com", "sheeran": "she@nail.it"}
	fmt.Println(emails)
	fmt.Println(emails["Bob"])
	fmt.Println(len(emails))

	//delete from map
	delete(emails, "Bob")
	fmt.Println(emails)

}
