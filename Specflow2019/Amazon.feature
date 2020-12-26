
Feature: Amazon
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Try to Login to Amazon with incorrect Password
	Given I am navigate to "https://www.amazon.com"
	And I have clicked on Sign in link
	When I enter email or phone number "8149907899"
	And I click on continue button
	And I enter password
	And I click on Sign in button
	Then I should get error message "Your password is incorrect"

Scenario: Try to Login to Amazon with incorrect Username
	Given I am navigate to "https://www.amazon.com"
	And I have clicked on Sign in link
	When I enter email or phone number "123456789012345"
	And I click on continue button
	Then I should get error message "We cannot find an account with that mobile number"


	
	