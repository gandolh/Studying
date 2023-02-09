package main

import "fmt"

func main() {
	fmt.Println("hello")
	//arrays
	// var fruitArr [2]string
	// //assing values
	// fruitArr[0] = "apple"
	// fruitArr[1] = "orange"

	//declare and assign
	// fruitArr := [2]string{"Apple", "Orange"}
	// fmt.Println(fruitArr)
	// fmt.Println(fruitArr[0])

	fruitSlice := []string{"apple", "orange", "grape"}
	fmt.Println(fruitSlice)
	fmt.Println(len(fruitSlice))
	fmt.Println(fruitSlice[1:3])

}
