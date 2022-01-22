package helper

import "strings"

func ValidateUserInput(firstname, lastname, email string, userTickets, remainingTickets uint) (bool, bool, bool) {
	isValidName := len(firstname) >= 2 && len(lastname) >= 2
	isValidEmail := strings.Contains(email, "@")
	isValidTicketNumber := userTickets > 0 && userTickets <= remainingTickets
	return isValidName, isValidEmail, isValidTicketNumber
	// isValidCity= city=="singapore" || city=="london"
}
