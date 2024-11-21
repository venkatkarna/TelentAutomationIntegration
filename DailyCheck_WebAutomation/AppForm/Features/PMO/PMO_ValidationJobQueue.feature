Feature: PMO_ValidationJobQueue

Verify functionality of the Validation Job Queue screen

Background: 	
	Given Launch the solo browser
	When User login with valid solo credentials
	And Click ‘Validation Job Queue’ link from PMO module

@Smoke
Scenario: TC001_SOLO_Login_Validation Job Queue
	Then Verify the display of Validation Job Queue screen

Scenario: TC002_SOLO_Login_Validation Job Queue_Screen element_Verify
	Then Verify the display of element in Validation Job Queue screen

Scenario: TC003_SOLO_Login_Validation Job Queue_search criteria_Validate
	When Click on eBusiness Checkbox
	When Select the Workstream
	Then Verify the filled elements

Scenario: TC004_SOLO_Login_Validation Job Queue_search criteria_Get Details_Click
	When Click on eBusiness Checkbox
	When Select the Workstream
	Then Click on Get Details button

Scenario: TC005_SOLO_Login_Validation Job Queue_search criteria_Get Details_Result
	When Click on eBusiness Checkbox
	When Select the Workstream
	And Click on Get Details button
	Then Verify the display of Results in Validation Job Queue screen

Scenario: TC006_SOLO_Login_Validation Job Queue_Get Details_Reset button
	When Click on eBusiness Checkbox
	When Select the Workstream
	And Click on Reset button
	Then Verify the all search fields and it should be reset successfully

Scenario: TC007_SOLO_Login_Validation Job Queue_Get Details_Export View To Excel button
	When Click on eBusiness Checkbox
	When Select the Workstream
	And Click on Get Details button
	Then Click on Export View To Excel button

Scenario: TC008_SOLO_Login_Validation Job Queue_Get Details_View button
	When Click on eBusiness Checkbox
	When Select the Workstream
	And Click on Get Details button
	And Click on View button

Scenario: TC009_SOLO_Login_Validation Job Queue_Get Details_Exit button
	When Click on eBusiness Checkbox
	When Select the Workstream
	And Click on Get Details button
	And Click on Exit button





	