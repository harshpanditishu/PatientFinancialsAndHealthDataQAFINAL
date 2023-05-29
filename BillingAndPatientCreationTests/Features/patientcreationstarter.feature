Feature: Visit Creation
This implementation will enable hospital staff to create visits of type - Ambulatory,Inpatient,Outpatient via UI and HL7 Inbound
#Feature : F1021
#Feature: Visit Creation ability for user in ER

@Smoke
@Priority1
@PlannedForAutomation
@UITest
Scenario: User can create a visit of type Ambulatory with future admit dates
Given User has the security right "CreateVisit" to create a visit and visitadmitdate as '01/12/2022' 
| Field          | Value        |
| CareLevel      | Acute        |
| VisitType      | Ambulatory   |
When User creates a patient/visit in ER with the visit type as Ambulatory
Then the Ambulatory visit is successfully registered in ER with the visit data getting persisted in the CVClient table  


@Smoke
  Scenario: Validate auto discharge when discharge date is a future date
    Given I have a visit which has discharge date set in '3 days time'
    When I initiate the auto discharge proess or service OR when the process is running
    Then the the visit should be discharged on that date


@Smoke
   Scenario: Validate auto discharge when discharge date is a past date
    Given I have a visit which has discharge date set  '3 days ago'
    When I initiate the auto discharge proess or service OR when the process is running
    Then the the visit should be discharged on that date
