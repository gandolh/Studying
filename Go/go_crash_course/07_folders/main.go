package main

import "fmt"

func main() {
	fmt.Println("hello")
	//long method
	i := 1
	for i <= 10 {
		fmt.Println(i)
		i++
	}
	//short method
	for i := 1; i <= 10; i++ {
		fmt.Printf("text number %d\n", i)
	}

	//fizz buzz
	for i := 1; i <= 100; i++ {
		if i%15 == 0 {
			fmt.Println("fizzbuzz")
		} else if i%3 == 0 {
			fmt.Println("buzz")
		} else if i%5 == 0 {
			fmt.Println("fizz")
		}

	}
}
