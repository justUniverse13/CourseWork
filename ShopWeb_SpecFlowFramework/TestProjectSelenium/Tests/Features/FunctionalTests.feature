Feature: FunctionalTests
	
	@Smoke
@FullRegression
Scenario: TC_C7_Verify that after clicking on Add to the cart button item displayed in the cart
	When I open In EZShoes page
	Then I click on Add to the Cart button
	And navigate to the 'ShopCart' nav bar
	Then shoes item displayed in ShopCart

	@Smoke
@FullRegression
Scenario: TC_C8_Verify that list of items changed after clicking on different sub categories
	When I open In EZShoes page
	And navigate to the 'Popular Shoes' nav bar
	And Shoes items displayed
	And navigate to the 'Shoes' nav bar
	And Shoes items displayed
	And navigate to the 'Adidas' nav bar
	And Shoes items displayed
	And navigate to the 'Nike' nav bar
	And Shoes items displayed

	@Smoke
@FullRegression
Scenario: TC_C9_Verify that the background color can be changed if to turn on/off toggle
	When I open In EZShoes page
	And I click on the toggle button
	And Shoes items displayed
	And I click on the toggle button
	And Shoes items displayed

	@Smoke
@FullRegression
Scenario: TC_C10_Verify that Pay button present in the ShopCart part
	When I open In EZShoes page
	And navigate to the 'ShopCart' nav bar
	Then 'Pay' button displayed

	@Smoke
@FullRegression
Scenario: TC_C11_Verify that after choosing item and clicking on Pay button Making order grid displayed
	When I open In EZShoes page
	Then I click on Add to the Cart button
	And navigate to the 'ShopCart' nav bar
	Then shoes item displayed in ShopCart
	Then 'Pay' button displayed
	And I click on Pay button 

	@Smoke
@FullRegression
Scenario: TC_C12_Verify that after clicking on End shopping request button with success previous steps the order created successfuly
When I open In EZShoes page
	Then I click on Add to the Cart button
	And navigate to the 'ShopCart' nav bar
	Then shoes item displayed in ShopCart
	Then 'Pay' button displayed
	And I click on Pay button
	Then I input 'sadasd' text to the 'name' placeholder
	Then I input 'sadasd' text to the 'surname' placeholder
	Then I input 'sadasd' text to the 'adress' placeholder
	Then I input '432423' text to the 'phone' placeholder
	Then I input '43@sda2423' text to the 'email' placeholder
	And I click on End shopping request button
