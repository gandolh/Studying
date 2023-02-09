package main

import (
	"fmt"
	"runtime"
)

func main() {
	fmt.Printf("there are %v ", runtime.GOMAXPROCS(-1))
}
