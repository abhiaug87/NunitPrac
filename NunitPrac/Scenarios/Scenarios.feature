Feature: Scenarios for buggy car. 
The top 5 critical functionalities for buggy car are Register, Login, Traverse, Vote & Logout.
These have been combined in the following scenarios.

@test
@basic
@Headless
Scenario: First time user - Registration Flow
	Given I am on the main page
	And I want to register
	When I add my details
	Then I am registered successfully

@test
@alt
@Headless
Scenario: Cancel out of the Registration flow
	Given I am on the main page
	And I want to register
	When I click cancel
	Then I am redirected to the main page

@test
@basic
@Headless
Scenario: First Vote for favorite car
	Given I am on the main page
	And I login to the application
	And I select my favorite car
	When I cast a vote for my favorite car
	Then I am able to see the appropriate message

@test
@alt
@Headless
Scenario: Revote favourite car
	Given I am on the main page
	And I login to the application
	And I select my favorite car
	Then I am able to see the appropriate message

@test
@basic
@Headless
Scenario: Traverse through pages and logout
	Given I am on the main page
	And I login to the application
	And I click on the list of cars
	When I traverse forward through the pages
	And I traverse back through the pages
	Then I am able to see the different cars
	And I logout of the application