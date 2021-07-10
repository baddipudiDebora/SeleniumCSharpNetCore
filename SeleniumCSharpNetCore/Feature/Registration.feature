Feature: Registration
	Check fields of Resitration page


Scenario: Login user as Administrator
	Given I navigate to application landing page
	When I click on Register link
	Then I validate the form fields and Footer Text
	