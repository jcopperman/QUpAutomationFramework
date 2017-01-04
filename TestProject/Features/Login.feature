Feature: Login
	Check if the Login functionality works
	As expected with different permuations and
	combinations of data

@smoke @positive
Scenario: Check Login with correct username and password
	Given I have navigated to the application
	And I see the homepage
	Then I click login
	When I enter Username and password
	| UserName | Password |
	| admin    | password |
	Then I click login button
	Then I should see the username

@smoke @negative
Scenario: Check Login with incorrect username and password
	Given I have navigated to the application
	And I see the homepage
	Then I click login
	When I enter Username and password
	| UserName | Password |
	| falseusername    | falsepassword |
	Then I click login button
	Then I should see the username
