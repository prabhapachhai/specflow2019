Feature: AutomationPractice
	

@mytag
Scenario: Try to Login to AutomationPractice site with incorrect Username and incorrect Password
	Given I am navigated to "http://demo.automationtesting.in/Register.html"
	And I enter the below information
	| FirstName | LastName | Address |
	| Vaibhav   | Hiware   | xyz     |
	| Vaibhav1  | Hiware1  | xyz1    |
	