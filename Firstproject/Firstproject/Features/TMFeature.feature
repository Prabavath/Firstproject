Feature: TMFeature

As a TurnUp Portal admin
I would like to create,edit,delete time and material records
So that I can manage employees time and material successfully


Scenario: Create time and material record with valid details
	Given I logged into TurnUp portal successfully
	When  I navigate to time and material page
	And   I create a new time and material record
	Then  The record should be created successfully
