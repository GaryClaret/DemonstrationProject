Feature: GetCustomerInformation
	In order to know how much to pay
	As a customer
	I want to see my bill

Scenario: View my bill
	Given I have entered the account screen
	When I click to view my bill
	Then the correct bill details should be displayed on the screen
