Feature: FindoutMore
	check the PageTitle of FindoutMore page

@mytag
Scenario: To validate the contents of FindOutMore page
	Given I navigate to application landing page
	When I click on FindoutMore link
	Then I validate the page title
