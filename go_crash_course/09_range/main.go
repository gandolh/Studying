package main

import "fmt"

func main() {
	fmt.Println("hello")
	// ids := []int{33, 76, 54, 23, 11, 2}

	// //loop through ids
	// for i, id := range ids {
	// 	// fmt.Println(i, id)
	// 	fmt.Printf("%d %d\n", i, id)
	// }
	// //not using index
	// for _, id := range ids {
	// 	// fmt.Println(i, id)
	// 	fmt.Printf("%d\n", id)
	// }

	// //add ids together
	// sum := 0
	// for _, id := range ids {
	// 	sum += id

	// }
	// fmt.Println(sum)

	//range with map
	emails := map[string]string{"Bob": "bob@gmail.com", "sher": "she/he@gmail.com"}

	for k, v := range emails {
		fmt.Printf("%s: %s\n", k, v)
	}
	for k := range emails {
		fmt.Println("name:", k)
	}
}
