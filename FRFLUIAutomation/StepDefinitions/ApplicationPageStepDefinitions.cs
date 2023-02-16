using FRFLUIAutomation.Drivers;
using FRFLUIAutomation.Pages;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Diagnostics.Metrics;
using System.IO;
using TechTalk.SpecFlow.Assist;

namespace FRFLUIAutomation.StepDefinitions
{
    [Binding]
    public sealed class ApplicationPageStepDefinitions
    {
        private readonly Driver _driver;
        private readonly ApplicationPage _applicationPage;

        public ApplicationPageStepDefinitions(Driver driver)
        {
            _driver = driver;
            _applicationPage = new ApplicationPage(_driver.Page);
          
        }

        [Given(@"the user on the FRFL Website")]
        public void GivenTheUserOnTheFRFLWebsite()
        {
            _driver.Page.GotoAsync("https://frfl-uat.azurewebsites.net/");
        }

        [When(@"the user fills the main applicant details (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*)")]
        
        public async Task WhenTheUserFillsTheMainApplicantDetailsAsync(string title, string forename, string middlename, string surname, string dobDay, string dobMonth, string dobYear, string status, string dependants, string hometel, string mobiletel, string email)
        {
            await _applicationPage.appApplyNowBtn();
            await _applicationPage.acceptAll();
            await _applicationPage.acceptAndProceed();
            await _applicationPage.appNextBtn();
            await _applicationPage.FillMainApplicant(title, forename, middlename, surname, dobDay, dobMonth, dobYear, status, dependants, hometel, mobiletel, email);

        }

        [When(@"the address (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*)")]
        public async Task WhenTheAddressDetails(string flatNumber, string buildingName, string buildingNumber, string street, string town, string city, string county, string postcode, string timeAtAddressYrs, string timeAtAddressMths, string residency)
        {
            await _applicationPage.FillMainAddressDetails(flatNumber, buildingName, buildingNumber, street, town, city, county, postcode, timeAtAddressYrs, timeAtAddressMths, residency);
        }


        [When(@"fills in the employment details (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*)")]
        public async Task WhenFillsInTheEmploymentDetailsAsync(string employmentType, string occupation, string companyName, string workcity, string employmentTelephone, string employmentTimeSpentInJobYr, string employmentTimeSpentInJobM, string employmentTakeHomePay, string employmentIncomeFrequency)
        {
            await _applicationPage.FillEmploymentDetails(employmentType, occupation, companyName, workcity, employmentTelephone, employmentTimeSpentInJobYr, employmentTimeSpentInJobM, employmentTakeHomePay, employmentIncomeFrequency);
        }

        [When(@"fills in the additional Info (.*)")]
        public async Task WhenFillsInTheAdditionalInfoAsync(string howDidYouHearAboutUs)
        {
            await _applicationPage.FillAdditionalInfo(howDidYouHearAboutUs);
        }

        [When(@"fills in the vehicle details (.*),(.*),(.*),(.*),(.*),(.*),(.*)")]
        public async Task WhenFillsInTheVehicleDetailsAsync(string vehicleReg, string vehicleType, string vehicleManufacturer, string vehicleMileage, string vehiclePrice, string cashDeposit, string partExchangeDeposit)
        {
            await _applicationPage.FillVehicleDetails(vehicleReg, vehicleType, vehicleManufacturer, vehicleMileage, vehiclePrice, cashDeposit, partExchangeDeposit);
        }

        [When(@"verify the information and click Apply! button")]
        public async Task WhenVerifyTheInformationAndClickApplyButton()
        {
           await _applicationPage.VerifyDetailsAndClickApplyButton();
            
        }

       

        [Then(@"the application should be submitted and gets the decision page")]
        public async Task ThenTheApplicationShouldBeSubmittedAndGetsTheDecisionPage()
        {
            await _applicationPage.decisionVisible();
        }


      [Then(@"click on the finish and close the page")]
        public async Task ThenClickOnTheFinishAndCloseThePage()
        {
            await _applicationPage.appFinish();
        }

    }
}