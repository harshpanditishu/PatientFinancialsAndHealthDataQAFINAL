Feature: LoadReport of PATIENTS for HTML REPORT GENERATION
Loading patient data for reports creation

@ReportstestCases
Scenario: To verify if the loaded patient data is exported to an html report form wth correct data
	Given User loads the data for following data of multiple patients
	| Fname   | MName | Age | Insurance | Lname     | Nationality |
	| Mark    | S     | 23  | Aetna     | Bride     | American    |
	| John    | R     | 43  | Aetna     | Nash      | Australian  |
	| Anna    | S     | 63  | Aetna     | Brown     | American    |
	| Shiv    | Y     | 83  | Aetna     | Kumar     | Indian      |
	| Dassler | O     | 23  | Aetna     | Matt      | German      |
	| Chan    | P     | 36  | Aetna     | Patterson | American    |
	| Jimmy   | E     | 42  | Aetna     | Bob       | American    |

	When User initiates the loading of data
	Then All the data of the patients loaded in the previous step can be viewed in html format
	