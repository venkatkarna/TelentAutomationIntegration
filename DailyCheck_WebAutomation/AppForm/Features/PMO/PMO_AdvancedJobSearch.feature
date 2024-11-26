Feature: PMO_AdvancedJobSearch

Verify functionality of the Advanced Job Search screen.

Background:
	Given Launch the solo browser
	When User login with valid solo credentials
	And Click ‘Advanced Job Search’ link from PMO module

@Smoke
Scenario: TC001_SOLO_Login_Advanced Job Search
	Then Verify the display of Advanced Job Search screen

Scenario: TC002_SOLO_Login_Advanced Job Search_Screen element_Verify
	Then Verify the display of element in Advanced Job Search screen

Scenario: TC003_SOLO_Login_Advanced Job Search_search criteria_Validate
	When Click on eBus Checkbox
	When Select the Workstream
	Then Verify the filled elements in Advanced Job Search screen

Scenario: TC004_SOLO_Login_Advanced Job Search_search criteria_Get Details_Click
	When Click on eBus Checkbox
	When Select the Workstream
	Then Click on Get Details button

Scenario: TC005_SOLO_Login_Advanced Job Search_search criteria_Get Details_Result
	When Click on eBus Checkbox
	When Select the Workstream
	And Click on Get Details button
	Then Verify the display of Results in Advanced Job Search screen

Scenario: TC006_SOLO_Login_Advanced Job Search_Clear button
	When Click on eBus Checkbox
	When Select the Workstream
	And Click on Clear button
	Then Verify the cleared values from the Advanced Job Search screen

Scenario: TC007_SOLO_Login_Advanced Job Search_My Jobs button
	When Click on My Job button
	Then Verify the display of jobs in Search Results grid

Scenario: TC008_SOLO_Login_Advanced Job Search_Add Job button
	When Click on My Job button
	When Click on Add Job button
	Then Verify the display of Add job screen

Scenario: TC009_SOLO_Login_Advanced Job Search_Copy Job button
	When Click on My Job button
	When Select the first job from Search Results grid
	And Click on Copy Job button
	And Click on Copy button after select the Depot from dropdown
	Then Verify the display of Copied Job screen

Scenario: TC010_SOLO_Login_Advanced Job Search_Take-off Hold button
	When Click on My Job button
	And Click on More button
	And Select the Job Status as On Hold
	And Click on Get Details button
	When Select the first job from Search Results grid
	And Click on Take-off Hold button
	Then Verify the display of Job Info screen

Scenario: TC011_SOLO_Login_Advanced Job Search_Remove Owner button
	When Click on My Job button
	And Click on Get Details button
	When Select the first job from Search Results grid
	And Click on Remove Owner button
	Then Verify the alert message and accept it

Scenario: TC012_SOLO_Login_Advanced Job Search_Export View To Excel button
	When Click on My Job button
	And Click on Get Details button


#Scenario: TC006_SOLO_Login_Validation Job Queue_Get Details_Reset button
#	Given Launch the solo browser
#	When User login with valid solo credentials
#	And Click ‘Advanced Job Search’ link from PMO module
#	When Click on eBus Checkbox
#	When Select the Workstream
#	And Click on Get Details button
#	And Click on Reset button
#	Then Verify the all search fields and it should be reset successfully
#
#Scenario: TC007_SOLO_Login_Validation Job Queue_Get Details_Export View To Excel button
#	Given Launch the solo browser
#	When User login with valid solo credentials
#	And Click ‘Advanced Job Search’ link from PMO module
#	When Click on eBus Checkbox
#	When Select the Workstream
#	And Click on Get Details button
#	Then Click on Export View To Excel button
#
#Scenario: TC008_SOLO_Login_Validation Job Queue_Get Details_View button
#	Given Launch the solo browser
#	When User login with valid solo credentials
#	And Click ‘Advanced Job Search’ link from PMO module
#	When Click on eBus Checkbox
#	When Select the Workstream
#	And Click on Get Details button
#	And Click on View button
#
#Scenario: TC009_SOLO_Login_Validation Job Queue_Get Details_Exit button
#	Given Launch the solo browser
#	When User login with valid solo credentials
#	And Click ‘Advanced Job Search’ link from PMO module
#	When Click on eBus Checkbox
#	When Select the Workstream
#	And Click on Get Details button
#	And Click on Exit button





	