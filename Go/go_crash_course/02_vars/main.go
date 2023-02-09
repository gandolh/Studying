package main

import "fmt"

func main() {

	//using var
	// var name string = "Gandolh"
	// var name = "Gandolh"
	//shorthand
	name := "gandolh"

	var age int32 = 75
	const isCool = true
	// isCool=false
	fmt.Println(name, age)
	fmt.Printf("%T\n", name)
	fmt.Printf("%T\n", isCool)
	width, height := 1.5, 3.4
	fmt.Println(width, height)

}
