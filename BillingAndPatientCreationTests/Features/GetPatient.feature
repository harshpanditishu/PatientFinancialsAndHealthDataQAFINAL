Feature: GetPatient

Getting patient details from consuming Getpatient service by passing the patient id

@APITesting
Scenario: Verify Patient details are obtained by passing the patient id in the GetPatient API Endpoint
	Given Following query parameters are inserted into the GetPatient API URL. (The patient id is of an existing patient)
	| Field     | Value |
	| PatientID | 123GA |
	When The URL is hit with the PatientID : "PatientID"
	Then following patient details are returned
| Field            | Value    |
| PatientID        | 123ga    |
| PatientFirstName | Dave     |
| PatientLastName  | Marsh    |
| PatientAge       | 40       |
| Nationality      | American |
