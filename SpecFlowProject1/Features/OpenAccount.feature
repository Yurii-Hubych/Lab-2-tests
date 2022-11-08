Feature: OpenAccount

A short summary of the feature

@feature1
Scenario: A new account should be opened successfuly
	Given XYZ Bank page
	When click Bank Manager Login, click Open Account, choose Customer name Hermoine Granger, choose Currency Rupee, click Process
	Then Success alert should appear
