Feature: BookReservation
	Reserving a book

@mytag
Scenario: Succesfully reserving a book
	Given the book entitled Harry Potter is available
	When a reservation request is sent
	Then the reservation is successful