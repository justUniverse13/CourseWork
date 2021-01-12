Feature: RegressionScenario
	
	@Smoke
@FullRegression
Scenario: TC_C1_Verify that shop contains Search at the header
	When I open In EZShoes page
	Then item with 'Search' placeholder displayed

	@Smoke
@FullRegression
Scenario: TC_C2_Verify that the Logo contains "EZShoes" text
	When I open In EZShoes page
	Then 'EZShoes' text displayed 

	@Smoke
@FullRegression
Scenario: TC_C3_Verify that header contains navigation bars
	When I open In EZShoes page
	Then 'Popular Shoes' nav bar displayed
	And 'Shoes' nav bar displayed
	And 'Adidas' nav bar displayed
	And 'Nike' nav bar displayed
	And 'ShopCart' nav bar displayed

	@Smoke
@FullRegression
Scenario: TC_C4_Verify that shoes items displayed
	When I open In EZShoes page
	And Shoes items displayed

	@Smoke
@FullRegression
Scenario: TC_C5_Verify that " 2021 All rigths reserved" located in the bottom
	When I open In EZShoes page
	And I scoll to the bottom
	Then '© 2021 All rigths reserved· ' text displayed 

	@Smoke
@FullRegression
Scenario: TC_C6_Verify that "Back to the top" button displayed
	When I open In EZShoes page
	And I scoll to the bottom
	Then 'Back to top' text displayed 