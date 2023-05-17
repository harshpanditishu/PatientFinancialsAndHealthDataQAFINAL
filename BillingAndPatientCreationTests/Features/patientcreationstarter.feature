Feature: Visit Creation
This implementation will enable hospital staff to create visits of type - Ambulatory,Inpatient,Outpatient via UI and HL7 Inbound
#Feature : F1021
#Feature: Visit Creation ability for user in ER

@Smoke
@Priority1
@PlannedForAutomation
@UITest
Scenario: User can create a visit of type Ambulatory
Given User has the security right "CreateVisit" to create a visit
When User creates a patient/visit in ER with the visit type as Ambulatory
Then the Ambulatory visit is successfully registered in ER with the visit data getting persisted in the CVClient table  

