package main

import (
	"fmt"
	"strings"

	"github.com/gandolh/booking-app/helper"
)

var conferenceName = "Go conference"
var conferenceTickets uint = 50
var remainingTickets uint = 50
var bookings []string

func main() {

	greetUsers()

	for {
		firstname, lastname, email, userTickets := getUserInput()
		isValidName, isValidEmail, isValidTicketNumber := helper.ValidateUserInput(firstname, lastname, email, userTickets, remainingTickets)
		if isValidTicketNumber && isValidName && isValidEmail {
			bookTicket(userTickets, firstname, lastname, email)
			fmt.Printf("These are first names of bookings are %v\n", GetFirstNames())
			if remainingTickets == 0 {
				fmt.Println("Our conference is booked out. Come back next year")
				break
			}
		} else {
			if !isValidName {
				fmt.Printf("first name or last name you entered is too short. Please try again\n")
			}
			if !isValidEmail {
				fmt.Printf("Your email adress doesnt contain @ sign. Please try again\n")
			}
			if !isValidTicketNumber {
				fmt.Printf("You entered an invalid number of tickets\n")
			}
		}
	}
}

func greetUsers() {
	fmt.Printf("Welcome to %v\n", conferenceName)
	fmt.Printf("We have a total of %d tickets and %d still available\n", conferenceTickets, remainingTickets)
	fmt.Printf("get your attend here\n")
}

func GetFirstNames() []string {
	firstNames := []string{}
	for _, booking := range bookings {
		names := strings.Fields(booking)
		firstNames = append(firstNames, names[0])
	}
	return firstNames
}

func getUserInput() (string, string, string, uint) {
	var firstname string
	var lastname string
	var email string
	var userTickets uint
	fmt.Println("Enter your first name:")
	fmt.Scan(&firstname)
	fmt.Println("Enter your last name name:")
	fmt.Scan(&lastname)
	fmt.Println("Enter your email:")
	fmt.Scan(&email)
	fmt.Println("Enter number of tickets:")
	fmt.Scan(&userTickets)
	return firstname, lastname, email, userTickets
}

func bookTicket(userTickets uint, firstname, lastname, email string) {
	remainingTickets -= userTickets
	bookings = append(bookings, firstname+" "+lastname)

	fmt.Printf("Thank you %v %v for booking %v tickets. You will receive confirmation on %v \n", firstname, lastname, userTickets, email)
	fmt.Printf("%v tickets remaining for %v\n", remainingTickets, conferenceName)
}
