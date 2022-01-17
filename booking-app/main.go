package main

import "fmt"

func main() {
	var firstname string
	var lastname string
	var email string
	var userTickets uint
	conferenceName := "Go conference"
	var conferenceTickets uint = 50
	var remainingTickets uint = 50
	fmt.Printf("Welcome to %v\n", conferenceName)
	fmt.Printf("We have a total of %d tickets and %d still available\n", conferenceTickets, remainingTickets)
	fmt.Printf("get your attend here\n")
	fmt.Println("Enter your first name:")
	fmt.Scan(&firstname)
	fmt.Println("Enter your last name name:")
	fmt.Scan(&lastname)
	fmt.Println("Enter your email:")
	fmt.Scan(&email)
	fmt.Println("Enter number of tickets:")
	fmt.Scan(&userTickets)
	remainingTickets -= userTickets
	fmt.Printf("Thank you %v %v for booking %v tickets. You will receive confirmation on %v \n", firstname, lastname, userTickets, email)
	fmt.Printf("%v tickets remaining for %v", remainingTickets, conferenceName)
	//57:00
}
