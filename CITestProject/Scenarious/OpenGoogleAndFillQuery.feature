Feature: OpenGoogleAndFillQuery

Scenario: 01 Navigate to Google
	When I navigate to Google page
	Then Google page is displayed

Scenario: 02 Fill in query
	When I fill in query text 'Funny cats'
	And I Click Enter
	Then Result page is displayed