package main

import (
	"fmt"
	"strconv"
)

type Person struct {
	// firstname string
	// lastname  string
	// city      string
	// gender    bool
	// age       int

	firstname, lastname, city string
	gender                    bool
	age                       int
}

// Greeting method (value receiver)
func (p Person) greet() string {
	return "hello my name is " + p.firstname + " " + p.lastname + " and i am " + strconv.Itoa(p.age)
}

//hasBirthday pointer receiver
func (p *Person) hasBirthday() {
	p.age++
}

//get married pointer receiver
func (p *Person) getMarried(spouseLastName string) {
	if !p.gender {
		return
	} else {
		p.lastname = spouseLastName
	}

}
func main() {
	//init Person using struct
	person1 := Person{firstname: "gandolh", lastname: "the white", city: "New york bro", gender: true, age: 25}
	//alternative
	person2 := Person{"gandolh", "the white", "New york bro", true, 25}
	fmt.Println(person1)
	fmt.Println(person2)
	person1.age++
	fmt.Println(person1.firstname, person1.age)
	person1.hasBirthday()
	person1.hasBirthday()
	person1.hasBirthday()
	person1.getMarried("the sur")
	fmt.Println(person1.greet())

}
