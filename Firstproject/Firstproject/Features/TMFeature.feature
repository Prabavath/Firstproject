Feature: TMFeature

As a TurnUp Portal admin
I would like to create,edit,delete time and material records
So that I can manage employees time and material successfully


Scenario: Create time and material record with valid details
	Given I logged into TurnUp portal successfully
	When  I navigate to time and material page
	And   I create a new time and material record
	Then  The record should be created successfully

Scenario Outline: Edit existing time and material record with valid details
	Given I logged into TurnUp portal successfully
	When  I navigate to time and material page
	And   I update '<code>','<Description>' and '<Price>' on an existing time and material record
	Then  The record should be updated '<code>','<Description>' and '<Price>'

Examples: 
| code   | Description | Price |
| June   | Spring      | $200.00  |
| July   | Winter      | $400.00   |
| August | Summer      | $600.00   |

Scenario Outline:  Delete existing time and material record with valid details
	Given I logged into TurnUp portal successfully
	When  I navigate to time and material page
	And I delete '<code>','<Description>' and '<Price>' on an existing time and material record
	Then The record should be deleted '<code>','<Description>' and '<Price>'

Examples: 
| code | Description | Price   |
| June | Spring      | $200.00 |
