Feature: Telent_SM_Inspection

SM Inspection screen validation

@Smoke
Scenario: TC001-Launch the Street Manager application
Given Launch the SM browser
When Enter the valid SM Email address 
When Enter the valid SM Password
And Click the Sign in button
Then Verify the SM application page contents