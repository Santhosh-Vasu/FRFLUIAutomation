
//using Microsoft.Playwright;
//using Microsoft.Playwright.NUnit;

//namespace UIAutomation;

//public class NUnitPlaywright : PageTest
//{
//    [SetUp]
//    public async Task Setup()
//    {

//        await Page.GotoAsync("https://frfl-uat.azurewebsites.net/");
//    }

//    [Test]
//    public async Task Test1()
//    {


//        await Page.Locator("text=Apply now").ClickAsync();

//        await Page.Locator("text=Accept All").ClickAsync();

//        await Page.Locator("#consumer-form > frf-wizard > div > div:nth-child(2) > div > div > div > div:nth-child(1) > da-terms-step > frf-wizard-step > div > div > div.col-sm-8.body > form > div.row.btn-row > div.col-xs-8.col-sm-10 > div > label > input").CheckAsync();
//        await Page.Locator("id=next").ClickAsync();

//        await Expect(Page.Locator("id=forename")).ToBeVisibleAsync();

//        await Page.Locator("id=title").SelectOptionAsync("mr");
//        await Page.FillAsync("id=forename", "John");
//        await Page.FillAsync("id=middlename", "K");
//        await Page.FillAsync("id=surname", "Honai");

//        await Page.Locator("id=dobDay").SelectOptionAsync("14: 14");
//        await Page.Locator("id=dobMonth").SelectOptionAsync("11: 11");
//        await Page.Locator("id=dobYear").SelectOptionAsync("48: 1975");

//        await Page.Locator("id=status").SelectOptionAsync("civilPartnership");
//        await Page.Locator("id=dependants").SelectOptionAsync("1: 0");

//        await Page.FillAsync("id=hometel", "07453443212");
//        await Page.FillAsync("id=mobiletel", "07453443213");

//        await Page.FillAsync("id=email", "John@test.com");
//        await Page.Locator("#consumer-form > frf-wizard > div > div:nth-child(2) > div > div > div > div:nth-child(1) > da-primary-applicant-step > frf-wizard-step > div > div > div.col-sm-8.body > form > da-address > form > div:nth-child(2) > div.col-sm-6.col-sm-offset-1 > div > label > input").ClickAsync();

//        await Page.FillAsync("id=flatNumber", "3");
//        await Page.FillAsync("id=buildingName", "TestAvenue");
//        await Page.FillAsync("id=buildingNumber", "2");
//        await Page.FillAsync("id=street", "Hands Walk");
//        await Page.FillAsync("id=town", "Bottesford");
//        await Page.FillAsync("id=city", "Nottingham");
//        await Page.FillAsync("id=county", "Leicestershire");
//        await Page.FillAsync("id=postcode", "NG13 0AB");

//        await Page.Locator("id=timeAtAddressYrs").SelectOptionAsync("7: 6");
//        await Page.Locator("id=timeAtAddressMths").SelectOptionAsync("6: 5");
//        await Page.Locator("id=residency").SelectOptionAsync("homeowner");

//        await Page.Locator("#consumer-form > frf-wizard > div > div:nth-child(2) > div > div > div > div.row.btn-row > div > div > div > div.pull-right.col-xs-6 > button").ClickAsync();

//        await Page.Locator("id=employmentType").SelectOptionAsync("fullTimePermanent");
//        await Page.FillAsync("id=occupation", "Accountant");
//        await Page.FillAsync("id=companyName", "B&M");
//        await Page.FillAsync("id=city", "London");
//        await Page.FillAsync("id=employmentTelephone", "06545353665");
//        await Page.Locator("id=employmentTimeSpentInJobYr").SelectOptionAsync("5: 4");
//        await Page.Locator("id=employmentTimeSpentInJobM").SelectOptionAsync("6: 5");
//        await Page.FillAsync("id=employmentTakeHomePay", "2500");
//        await Page.Locator("id=employmentIncomeFrequency").SelectOptionAsync("monthly");



//        await Page.Locator("#consumer-form > frf-wizard > div > div:nth-child(2) > div > div > div > div.row.btn-row > div > div > div > div > button").ClickAsync();

//        await Page.Locator("#consumer-form > frf-wizard > div > div:nth-child(2) > div > div > div > div:nth-child(1) > da-additional-income-decision-step > frf-wizard-step > div > div > div.col-sm-8.body > form > div > div.col-sm-6 > label:nth-child(2) > input").ClickAsync();
//        await Page.Locator("#consumer-form > frf-wizard > div > div:nth-child(2) > div > div > div > div.row.btn-row > div > div > div > div.pull-right.col-xs-6 > button").ClickAsync();


//        await Page.Locator("id=howDidYouHearAboutUs").SelectOptionAsync("google");

//        await Page.ClickAsync("#chosenVehicle");
//        await Page.FillAsync("id=vehicleReg", "EF03 NBE");
//        await Page.Locator("id=vehicleType").SelectOptionAsync("car");
//        await Page.FillAsync("id=vehicleManufacturer", "Ford");
//        await Page.FillAsync("id=vehicleMileage", "123212");
//        await Page.FillAsync("id=vehiclePrice", "1250");
//        await Page.FillAsync("id=cashDeposit", "200");
//        await Page.FillAsync("id=partExchangeDeposit", "50");


//        await Page.Locator("#consumer-form > frf-wizard > div > div:nth-child(2) > div > div > div > div.row.btn-row > div > div > div > div.pull-right.col-xs-6 > button").ClickAsync();


//        await Expect(Page.Locator("text=Apply!")).ToBeVisibleAsync();
//        await Page.WaitForResponseAsync(x => x.Url.EndsWith("/portalapi/application/v1/multistep") && x.Status == 200);
//        await Page.ClickAsync("text=Apply!");

//        await Expect(Page.Locator("id=decision")).ToBeVisibleAsync(new LocatorAssertionsToBeVisibleOptions { Timeout = 25000 });
//        await Expect(Page.Locator("id=decision")).ToHaveTextAsync("Referred");
//        await Expect(Page.Locator("id=decision-detail")).ToBeVisibleAsync();
//        await Expect(Page.Locator("id=decision-detail")).ToHaveTextAsync("Manual Underwriting");

//        await Page.ClickAsync("text=Finish");


//    }
//}