Feature: LoginToGithub

Scenario: 01 Navigate to GitHub
	When I navigate to GitHub page
	Then GitHub page is displayed

Scenario: 02 Click on Sign In link
	When I click on Sign In link
	Then Login page is displayed

Scenario: 03 Enter Username and Password and click on Sign In button
	When I fill in Username field as 'User123'
	And I fill in Password field as 'Pass123'
	And I click on Sign In button
	Then Main page is displayed