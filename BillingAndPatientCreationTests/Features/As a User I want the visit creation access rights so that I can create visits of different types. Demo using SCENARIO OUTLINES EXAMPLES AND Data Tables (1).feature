Feature: As a User I want the visit creation access rights so that I can create visits of different types. Demo using SCENARIO OUTLINES EXAMPLES AND Data Tables
This implementation will enable hospital staff to create visits of type - Ambulatory,Inpatient,Outpatient via UI and HL7 Inbound. 
#Feature : F1021
#Feature: Visit Creation ability for user in ER


Background:
#BACKGROUND IS ALWAYS ONLY ONE FOR A SINGLE FEATURE FILE
#Has to be mentioned immediately after FEATURE keyword and description
Given User has the following config data  set up
| Field            | Value    |
| AddVisitSecRight | TRUE     |
| IsFullRegEP      | TRUE     |
| Username         | jongmore |
| Password         | pass     |


Rule: Validation of the Feature when visits are created via UI Only
To test all visit types can be created successfully in the ER application
@Smoke
@Priority1
@PlannedForAutomation
@UITest
Scenario Outline: Ability for User to create visits of all types 
When User to create visit of type <VisitType> where Care level is <CareLevel> and Service is <Service>
Then the visit is registered and data persisted in the DB  with Visit type as  <VisitType> and Care level equal to <CareLevel> and Service equal to :<Service>

Examples:
| Test Description        | VisitType  | CareLevel  | Service     |
| Ambulatory Vis Creation | Ambulatory | Ambulatory | ICU         |
| Inpatient Vis Creation  | Inpatient  | Acute      | GenMedicine |
| Outpatient Vis Creation | Outpatient | cl1        | CTScan      |
| Emergency Vis Creation  | Emergency  | critical   | dialysis    |

Scenario: Calculation of Billing amount if ailment service availed is MRI and age is greater than 60
Given User has availed 
| Field          | Value |
| ailmentservice | MRI   |
| age            | 61    |
When patient takes out the MRI
Then billing amount is 
| Field         | Value       |
| billingamount | 600 DOLLARS |
