Feature: RPNCalc
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given input "1,2,+"
	Then output 3

	Scenario: Add two numbers 2nd
	Given input "2,2,+"
	Then output 3
