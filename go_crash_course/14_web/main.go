package main

import (
	"fmt"
	"net/http"
)

func index(w http.ResponseWriter, r *http.Request) {
	fmt.Fprintf(w, "hello world")
}

func about(w http.ResponseWriter, r *http.Request) {
	fmt.Fprintf(w, "<p>sdadsa</p>")
}

func main() {
	fmt.Println("hello")
	http.HandleFunc("/", index)
	http.HandleFunc("/about", about)
	fmt.Println("Server 3d")
	http.ListenAndServe(":3000", nil)
}
