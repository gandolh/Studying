package main

import "fmt"

func main() {
	a := 5
	b := &a
	fmt.Println(a, b)
	fmt.Printf("%T\n", b)
	fmt.Println(*b, b, *&a)

	//change val with pointer
	*b = 10
	fmt.Println(a)
}
