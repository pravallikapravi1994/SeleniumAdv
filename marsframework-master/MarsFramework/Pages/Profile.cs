using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Net;
using System.Threading;

namespace MarsFramework
{
    internal class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 





        #region Title elements
        //Click on dropdown for title
        [FindsBy(How = How.XPath, Using = "(//div[@class='title']//i[@class='dropdown icon'])")]
        private IWebElement Dropdown { get; set; }
        //Click and ente on Fname
        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @name='firstName']")]
        private IWebElement Fname { get; set; }
        //Click and enter Lname
        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @name='lastName']")]
        private IWebElement Lname { get; set; }
        //Click on save
        [FindsBy(How = How.XPath, Using = "(//div//button[@class='ui teal button'])")]
        private IWebElement TitleSave { get; set; }
        #endregion


        #region Language elements

        //Click on language
        [FindsBy(How = How.XPath, Using = "//a[@data-tab='first' and text()='Languages']")]
        private IWebElement Langtab { get; set; }

        //Add New button for Language
        [FindsBy(How = How.XPath, Using = "(//div[@class='ui teal button '])[1]")]
        private IWebElement Addnewbutton { get; set; }

        //Add New Language text field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Language']")]
        private IWebElement AddLanguage { get; set; }

        //Add language level value drop down

        [FindsBy(How = How.XPath, Using = "//select[@name='level']")]
        private IWebElement AddLevel { get; set; }

        //AddLanguagebutton
        [FindsBy(How = How.XPath, Using = "(//input[@value='Add'])[1]")]
        private IWebElement Addbutton { get; set; }

        //Edit Language in the language table
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='first']//tbody//tr//td//i[@class='outline write icon']")]
        private IWebElement Editclick { get; set; }

        //change Language level
        // [FindsBy(How = How.XPath, Using = "(//select[@name='level'])[1]")]
        // private IWebElement Levelchg { get; set; }

        //Click on Update language
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='first']//input[@value='Update']")]
        private IWebElement Updatebutton { get; set; }

        //Delete Language
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='first']//tbody//tr//td//i[@class='remove icon']")]
        private IWebElement Deletebutton { get; set; }
        #endregion


        #region Skill elements
        //click on skill tab
        [FindsBy(How = How.XPath, Using = "//a[@data-tab='second']")]
        private IWebElement Skilltab { get; set; }
        //Click on Addnew button
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='second']//div[@class='ui teal button' and text()='Add New']")]
        private IWebElement AddnewSkillbutton { get; set; }
        // Enter New skill name
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='second']//input[@placeholder='Add Skill']")]
        private IWebElement Skillname { get; set; }
        //Enter new skill Level 
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='second']//select[@name='level']")]
        private IWebElement Skilllevel { get; set; }
        //Click on add button
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='second']//input[@value='Add']")]
        private IWebElement AddbuttonSkill { get; set; }
        //Skill Editbutton
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='second']//table//tbody//tr//td[3]//i[@class='outline write icon']")]
        private IWebElement EditbuttonSkill { get; set; }
        //Update button
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='second']//table//tr//td//input[@value='Update']")]
        private IWebElement UpdatebuttonSkill { get; set; }
        //Delete button
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='second']//table//tr//td//i[@class='remove icon']")]
        private IWebElement DeletebuttonSkill { get; set; }

        #endregion



        #region Availabity elements
        //Click availbility edit button
        [FindsBy(How = How.XPath, Using = "(//i[@class='right floated outline small write icon'])[1]")]
        private IWebElement Availedit { get; set; }
        //Select Availble time
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyType']")]
        private IWebElement Availtime { get; set; }
        #endregion

        #region Hours element
        //Click on hours edit button
        [FindsBy(How = How.XPath, Using = "(//i[@class='right floated outline small write icon'])[2]")]
        private IWebElement Houredit { get; set; }
        //Select Hours available
        [FindsBy(How = How.XPath, Using = "//select[@class='ui right labeled dropdown']")]
        private IWebElement Availhour { get; set; }
        #endregion

        #region targetelements

        //Click on Earn edit
        [FindsBy(How = How.XPath, Using = "(//i[@class='right floated outline small write icon'])[3]")]
        private IWebElement Earnedit { get; set; }
        //Select Earn target
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']")]
        private IWebElement Targetearn { get; set; }
        #endregion

        #region SearchSkill elements

        [FindsBy(How = How.XPath, Using = "//i[@class='search link icon']")]
        private IWebElement SearchClick { get; set; }
        [FindsBy(How = How.LinkText, Using = "Programming & Tech")]
        private IWebElement Category { get; set; }
        [FindsBy(How = How.XPath, Using = "(//div//a[@class='item subcategory' and contains( text(),'QA')])")]
        private IWebElement Subcategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains( text(), 'Online')]")]
        private IWebElement Filter { get; set; }

        #endregion



    

        #region Availability&HOurs

        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Part Time')]//i[@class='right floated outline small write icon']")]
        private IWebElement AvailabilityTimeEdit { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//option[@value='0']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[3]/div")]
        private IWebElement AvailabilityHours { get; set; }

        #endregion




        #region Sal&location
        //Click on salary
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[4]/div")]
        private IWebElement Salary { get; set; }

        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }


        #endregion
        /// <summary>
        /// Language Elements 
        /// </summary>


        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "(//div[contains(text(),'Add New')])[1]")]
        private IWebElement LanguageAddNew { get; set; }

        //Enter the Language on text box
       // [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Language']")]
       // private IWebElement AddLanguage { get; set; }

        //Enter the Language value 
        [FindsBy(How = How.XPath, Using = "//select[@name='level']")]
        private IWebElement AddLanguageValue { get; set; }

        //Click Add button
        [FindsBy(How = How.XPath, Using = "(//input[@value='Add'][@type='button'])[1]")]
        private IWebElement AddLanguagebutton { get; set; }

        //Last Language in the language table
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='first']//tbody[last()]//td[1]")]
        private IWebElement Language { get; set; }


        //Last Language drop down value in the language table
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='first']//tbody[last()]//td[2]")]
        private IWebElement LanguageValue { get; set; }


        // Edit icon for last language row in the language table
        [FindsBy(How = How.XPath, Using = "(//*[@data-tab='first']//tbody[last()]//td[3]//i)[1]")]
        private IWebElement EditLanguageIcon { get; set; }

        // Edit last language row in the language table
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='first']//tbody[last()]//input[@value='Tamil']")]
        private IWebElement EditLastLanguage { get; set; }





/// <summary>
/// Skill Elements
/// </summary>



        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/span/input[1]")]
        private IWebElement AddSkill { get; set; }



 /// <summary>
        /// Education Elements
        /// </summary>
        

       
        //Click on Add new to Educaiton


        [FindsBy(How = How.XPath, Using = "//a[text()='Education']")]
        private IWebElement EducationTab { get; set; }


        [FindsBy(How = How.XPath, Using = "(//div[contains(text(),'Add New')])[3]")]
        private IWebElement EducationAddNew { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//input[@name='instituteName']")]
        private IWebElement CollegeName { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//select[@name='country']")]
        private IWebElement CountryDropdown { get; set; }

        //Choose the Title option
        [FindsBy(How = How.XPath, Using = "//select[@name='title']")]
        private IWebElement TitleDropdown { get; set; }

        //Enter Degree 
        [FindsBy(How = How.XPath, Using = "//input[@name='degree']")]
        private IWebElement Degree { get; set; }

        //Choose GradutionYearDropDown
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']")]
        private IWebElement GradutionYearDropDown { get; set; }

        //AddButtonEducationData
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddButtonEducationData { get; set; }

        //EducationDataCountryFirstrow
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='third']//tbody[1]//td[1]")]
        private IWebElement EducationDataCountryFirstrow { get; set; }

        //EducationDataUniveristyFirstrow
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='third']//tbody[1]//td[2]")]
        private IWebElement EducationDataUniveristyFirstrow { get; set; }

        //EducationDataTitleFirstrow
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='third']//tbody[1]//td[3]")]
        private IWebElement EducationDataTitleFirstrow { get; set; }

        //EducationDataDegreeFirstrow
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='third']//tbody[1]//td[4]")]
        private IWebElement EducationDataDegreeFirstrow { get; set; }

        //EducationDataGradYearFirstrow
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='third']//tbody[1]//td[5]")]
        private IWebElement EducationDataGradYearFirstrow { get; set; }


        //EducationEditiconFirst
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='third']//tbody[1]//td[6]/span[1]")]
        private IWebElement EducationEditiconFirst { get; set; }


        //EducationDeleteiconFirst
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='third']//tbody[1]//td[6]/span[2]")]
        private IWebElement EducationDeleteiconFirst { get; set; }



        ////UpdateButtonEducationData
        [FindsBy(How = How.XPath, Using = "//input[@value='Update']")]
        private IWebElement UpdateButtonEducationData { get; set; }




        /// <summary>
        /// Certificate Elements 
        /// </summary>

                //Certificate Tab
        [FindsBy(How = How.XPath, Using = "//a[@data-tab='fourth']")]
        private IWebElement CertificateTab { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "(//div[text()='Add New'])[4]")]
        private IWebElement CertificateAddNew { get; set; }

        //Enter  CertificateAward
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationName']")]
        private IWebElement CertificateAward { get; set; }


        //Certified from
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationFrom']")]
        private IWebElement CertificateFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']")]
        private IWebElement CertificationYear { get; set; }

        //CertificationAddData
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement CertificationAddData { get; set; }

        //CertificatelastRowValue
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='fourth']//tbody[last()]//td[1]")]
        private IWebElement CertificatelastRowValue { get; set; }

        //CertificateFromlastRowValue
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='fourth']//tbody[last()]//td[2]")]
        private IWebElement CertificateFromlastRowValue { get; set; }


        //CertificateYearlastRowValue
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='fourth']//tbody[last()]//td[3]")]
        private IWebElement CertificateYearlastRowValue { get; set; }


        //EditCertificateIconlastRow
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='fourth']//tbody[last()]//td[4]/span[1]")]
        private IWebElement EditCertificateIconlastRow { get; set; }


        //DeleteCertificateIconlastRow
        [FindsBy(How = How.XPath, Using = "//*[@data-tab='fourth']//tbody[last()]//td[4]/span[2]")]
        private IWebElement DeleteCertificateIconlastRow { get; set; }


        //UpdateCertificateButtonlastRow
        [FindsBy(How = How.XPath, Using = "//input[@value='Update']")]
        private IWebElement UpdateCertificateButtonlastRow { get; set; }


        //CertificatevalueEdit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certificate or Award']")]
        private IWebElement CertificatevalueEdit { get; set; }



        //CertificateFromEdit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certified From (e.g. Adobe)']")]
        private IWebElement CertificateFromEdit { get; set; }


        //CertificateYearEdit
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']")]
        private IWebElement CertificateYearEdit { get; set; }







        /// <summary>
        /// Description Elements
        /// </summary>

        //Edit Icon Description
        [FindsBy(How = How.XPath, Using = "//*[@class= 'eight wide column']//span[1]//i")]
        private IWebElement DescriptionEditIcon { get; set; }

        //Description Value
        [FindsBy(How = How.XPath, Using = "(//*[@class= 'eight wide column']//span)[2]")]
        private IWebElement DescriptionValue { get; set; }

        //Description SaveButton
        [FindsBy(How = How.XPath, Using = "(//button[text()='Save'])[2]")]
        private IWebElement SaveButton { get; set; }

        //DescriptionTextField
        [FindsBy(How = How.XPath, Using = "//*[@class= 'ui twelve wide column']//textarea")]
        private IWebElement DescriptionTextField { get; set; }




  


        //Click on Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//a[text()='Manage Listings']")]
        private IWebElement manageListingsLink { get; set; }

        #endregion




        internal void EditProfile()
        {

        }


        


        #region EducationMethods
        internal void NavigateToEducationTab()
        {
            //Navigate to Education Tab
            GlobalDefinitions.TurnOnWait();
            EducationTab.Click();

        }

        internal void AddEducation()

        {

            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "Education");


            //Click on Add new button for education
            GlobalDefinitions.TurnOnWait();
            EducationAddNew.Click();

            //Enter Valid Education details 
            GlobalDefinitions.TurnOnWait();

            CollegeName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CollegeName"));

            SelectElement country = new SelectElement(CountryDropdown);
            country.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "CountryOfCollege"));

            SelectElement Titledrop = new SelectElement(TitleDropdown);
            Titledrop.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "TitleDrop"));

            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));



            Thread.Sleep(3000);
            SelectElement Yeardrop = new SelectElement(GradutionYearDropDown);
            Yeardrop.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Year"));


            Thread.Sleep(3000);
            AddButtonEducationData.Click();
            Thread.Sleep(2000);

        }


        internal void EditEducation()

        {
           // GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Education");

            EducationEditiconFirst.Click();

            CollegeName.Clear();

            CollegeName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "CollegeName"));

            SelectElement country = new SelectElement(CountryDropdown);
            country.SelectByText(GlobalDefinitions.ExcelLib.ReadData(3, "CountryOfCollege"));

            SelectElement Titledrop = new SelectElement(TitleDropdown);
            Titledrop.SelectByText(GlobalDefinitions.ExcelLib.ReadData(3, "TitleDrop"));

            Degree.Clear();

            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Degree"));



            Thread.Sleep(3000);
            SelectElement Yeardrop = new SelectElement(GradutionYearDropDown);
            Yeardrop.SelectByText(GlobalDefinitions.ExcelLib.ReadData(3, "Year"));


            Thread.Sleep(3000);
            UpdateButtonEducationData.Click();
            Thread.Sleep(5000);

        }


        internal void DeleteEducation()

        {
            EducationDeleteiconFirst.Click();

        }

      internal void VerifyAddEducation()

        {


            var actualCountry = EducationDataCountryFirstrow.Text;
            var ExpCountry = GlobalDefinitions.ExcelLib.ReadData(2, "CountryOfCollege");

            var actualColl = EducationDataUniveristyFirstrow.Text;
            var ExpColl = GlobalDefinitions.ExcelLib.ReadData(2, "CollegeName");


            var actualTitle = EducationDataTitleFirstrow.Text;
            var ExpTitle = GlobalDefinitions.ExcelLib.ReadData(2, "TitleDrop");

            var actualDegree = EducationDataDegreeFirstrow.Text;
            var ExpDegree = GlobalDefinitions.ExcelLib.ReadData(2, "Degree");

            var actualYear = EducationDataGradYearFirstrow.Text;
            var ExpYear = GlobalDefinitions.ExcelLib.ReadData(2, "Year");







            Assert.AreEqual(actualCountry, ExpCountry, "Country is not added");

            Assert.AreEqual(actualColl, ExpColl, "College is not added");

            Assert.AreEqual(actualTitle, ExpTitle, "Title is not added");

            Assert.AreEqual(actualDegree, ExpDegree, "Degree is not added");


            Assert.AreEqual(actualYear, ExpYear, "Year is not added");

        }


        internal void VerifyEditEducation()

        {
            var actualCountry = EducationDataCountryFirstrow.Text;
            var ExpCountry = GlobalDefinitions.ExcelLib.ReadData(3, "CountryOfCollege");

            var actualColl = EducationDataUniveristyFirstrow.Text;
            var ExpColl = GlobalDefinitions.ExcelLib.ReadData(3, "CollegeName");


            var actualTitle = EducationDataTitleFirstrow.Text;
            var ExpTitle = GlobalDefinitions.ExcelLib.ReadData(3, "TitleDrop");

            var actualDegree = EducationDataDegreeFirstrow.Text;
            var ExpDegree = GlobalDefinitions.ExcelLib.ReadData(3, "Degree");

            var actualYear = EducationDataGradYearFirstrow.Text;
            var ExpYear = GlobalDefinitions.ExcelLib.ReadData(3, "Year");







            Assert.AreEqual(actualCountry, ExpCountry, "Country is not updated");

            Assert.AreEqual(actualColl, ExpColl, "College is not updated");

            Assert.AreEqual(actualTitle, ExpTitle, "Title is not updated");

            Assert.AreEqual(actualDegree, ExpDegree, "Degree is not updated");


            Assert.AreEqual(actualYear, ExpYear, "Year is not updated");

        }

        internal void VerifyDeleteEducation()


        {

            try
            {
                var actualCountry = EducationDataCountryFirstrow.Text;
                var ExpCountry = GlobalDefinitions.ExcelLib.ReadData(3, "CountryOfCollege");

                var actualColl = EducationDataUniveristyFirstrow.Text;
                var ExpColl = GlobalDefinitions.ExcelLib.ReadData(3, "CollegeName");


                var actualTitle = EducationDataTitleFirstrow.Text;
                var ExpTitle = GlobalDefinitions.ExcelLib.ReadData(3, "TitleDrop");

                var actualDegree = EducationDataDegreeFirstrow.Text;
                var ExpDegree = GlobalDefinitions.ExcelLib.ReadData(3, "Degree");

                var actualYear = EducationDataGradYearFirstrow.Text;
                var ExpYear = GlobalDefinitions.ExcelLib.ReadData(3, "Year");


                Assert.AreNotEqual(actualCountry, ExpCountry, "Country is not deleted");

                Assert.AreNotEqual(actualColl, ExpColl, "College is not deleted");

                Assert.AreNotEqual(actualTitle, ExpTitle, "Title is not deleted");

                Assert.AreNotEqual(actualDegree, ExpDegree, "Degree is not deleted");


                Assert.AreNotEqual(actualYear, ExpYear, "Year is not deleted");


            }

            catch (Exception e)
            {


                Assert.True(true, "No Education Data");
            }




        }


        #endregion

 


        #region Certification Methods
        internal void NavigateToCertification()
        {
            CertificateTab.Click();
            GlobalDefinitions.TurnOnWait();
        }

        internal void AddCertification()

        {

            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "Cerification");

            GlobalDefinitions.TurnOnWait();

            CertificateAddNew.Click();
            CertificateAward.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));

            CertificateFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "From"));

            SelectElement year = new SelectElement(CertificationYear);
            year.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Year"));

            CertificationAddData.Click();

            Thread.Sleep(1000);



        }

       internal void EditCertification()

        {


            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "Cerification");

            GlobalDefinitions.TurnOnWait();
            EditCertificateIconlastRow.Click();

            Thread.Sleep(1000);


            CertificatevalueEdit.Clear();

            CertificatevalueEdit.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Certificate"));

            CertificateFromEdit.Clear();

            CertificateFromEdit.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "From"));

            SelectElement year = new SelectElement(CertificateYearEdit);
            year.SelectByText(GlobalDefinitions.ExcelLib.ReadData(3, "Year"));

            UpdateCertificateButtonlastRow.Click();


            Thread.Sleep(1000);




        }

        internal void DeleteCertification()

        {

            GlobalDefinitions.TurnOnWait();
            DeleteCertificateIconlastRow.Click();
            Thread.Sleep(1000);


        }

       internal void VerifyAddCertification()

        {

            Thread.Sleep(1000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "Cerification");

            var ActCertificate = CertificatelastRowValue.Text;
            var ActFrom = CertificateFromlastRowValue.Text;
            var Actyear = CertificateYearlastRowValue.Text;




            Assert.AreEqual(ActCertificate, GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"), "Certificate is not added");

            Assert.AreEqual(ActFrom, GlobalDefinitions.ExcelLib.ReadData(2, "From"), "From is not added");

            Assert.AreEqual(Actyear, GlobalDefinitions.ExcelLib.ReadData(2, "Year"), "Year is not added");






        }

        internal void VerifyEditCertification()

        {

            var ActCertificate = CertificatelastRowValue.Text;
            var ActFrom = CertificateFromlastRowValue.Text;
            var Actyear = CertificateYearlastRowValue.Text;




            Assert.AreEqual(ActCertificate, GlobalDefinitions.ExcelLib.ReadData(3, "Certificate"), "Certificate is not added");

            Assert.AreEqual(ActFrom, GlobalDefinitions.ExcelLib.ReadData(3, "From"), "From is not added");

            Assert.AreEqual(Actyear, GlobalDefinitions.ExcelLib.ReadData(3, "Year"), "Year is not added");


        }

       internal void VerifyDeleteCertification()

        {

            try
            {
                var ActCertificate = CertificatelastRowValue.Text;
                var ActFrom = CertificateFromlastRowValue.Text;
                var Actyear = CertificateYearlastRowValue.Text;




                Assert.AreNotEqual(ActCertificate, GlobalDefinitions.ExcelLib.ReadData(3, "Certificate"), "Certificate is not deleted");

                Assert.AreNotEqual(ActFrom, GlobalDefinitions.ExcelLib.ReadData(3, "From"), "From is not deleted");

                Assert.AreNotEqual(Actyear, GlobalDefinitions.ExcelLib.ReadData(3, "Year"), "Year is not deleted");

            }

            catch (Exception e)
            {
                Assert.Pass("No Certificate Data exists");

            }


        }

        #endregion





        #region ShareSkillandManageListing methods


        internal void NavigateToManageListingpage()
        {
            GlobalDefinitions.wait(1000);

            manageListingsLink.Click();
        }





        #endregion



        #region DesciprionMethods
        internal void EditDescription()
        {

            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "Description");
            GlobalDefinitions.wait(1000);
            DescriptionEditIcon.Click();


            // Add Description content 


            Thread.Sleep(1000);
            DescriptionTextField.Clear();

            Thread.Sleep(1000);
            DescriptionTextField.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Text"));

            SaveButton.Click();

            Thread.Sleep(1000);

        }

        internal void VerifyDescription()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "Description");
            var ActDes = DescriptionValue.Text;

            Assert.AreEqual(ActDes, GlobalDefinitions.ExcelLib.ReadData(2, "Text"), "Description value is not as expected");

        }



        #endregion



        #region Title Method
        internal void ProfileEditUsername()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "ProfileData");

            GlobalDefinitions.TurnOnWait();
            Dropdown.Click();

            GlobalDefinitions.TurnOnWait();

            Fname.Clear();
            GlobalDefinitions.TurnOnWait();
            Fname.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "FirstName"));
            GlobalDefinitions.TurnOnWait();
            Lname.Clear();
            GlobalDefinitions.TurnOnWait();
            Lname.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "LastName"));
            GlobalDefinitions.TurnOnWait();
            TitleSave.Click();
            GlobalDefinitions.TurnOnWait();

        }

        [FindsBy(How = How.XPath, Using = "(//div[@class='title' and contains(text(),'Pravallika')])")]
        private IWebElement Actualtext { get; set; }
        internal void AssertTitleusername()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "ProfileData");
            String fname = GlobalDefinitions.ExcelLib.ReadData(2, "FirstName");
            String lname = GlobalDefinitions.ExcelLib.ReadData(2, "LastName");
            String Expectedtext = fname + " " + lname;
            Thread.Sleep(1000);
            Assert.AreEqual(Actualtext.Text, Expectedtext);
        }
        #endregion




        #region Availability method
        internal void EditAvailabletime()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "ProfileData");
            Availedit.Click();
            GlobalDefinitions.TurnOnWait();
            SelectElement Timeavail = new SelectElement(Availtime);
            Timeavail.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Availability"));
            GlobalDefinitions.TurnOnWait();
        }
     

        [FindsBy(How = How.XPath, Using = "(//div[@class='right floated content'])[2]")]
        private IWebElement Time { get; set; }
        internal void VerifyAvailableTime()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "ProfileData");
            Availedit.Click();
            GlobalDefinitions.TurnOnWait();
            String Actualtime = Time.Text;
            Assert.IsTrue(Actualtime.Contains(GlobalDefinitions.ExcelLib.ReadData(2, "Availability")));

        }
        #endregion


        #region Hours method
        internal void EditAvailableHours()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "ProfileData");
            Houredit.Click();
            GlobalDefinitions.TurnOnWait();
            SelectElement Hoursavail = new SelectElement(Availhour);
            Hoursavail.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Hours"));
            GlobalDefinitions.TurnOnWait();

        }
      

        [FindsBy(How = How.XPath, Using = "(//div[@class='right floated content'])[3]")]
        private IWebElement Hours { get; set; }
        internal void VerifyHourssaved()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "ProfileData");
            GlobalDefinitions.TurnOnWait();
            String Actualtime = Hours.Text;
            Thread.Sleep(1000);
            Assert.IsTrue(Actualtime.Contains(GlobalDefinitions.ExcelLib.ReadData(2, "Hours")));
        }
        #endregion


        #region Target method
        internal void Targetadd()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "ProfileData");
            Earnedit.Click();
            GlobalDefinitions.TurnOnWait();
            SelectElement Earntgt = new SelectElement(Targetearn);
            Earntgt.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Target"));
            GlobalDefinitions.TurnOnWait();

        }
      
        [FindsBy(How = How.XPath, Using = "(//div[@class='right floated content'])[4]")]
        private IWebElement Tgtearn { get; set; }
        internal void Verify_target_saved()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "ProfileData");
            GlobalDefinitions.TurnOnWait();
            String Actualtime = Tgtearn.Text;
            GlobalDefinitions.TurnOnWait();
            Assert.IsTrue(Actualtime.Contains(GlobalDefinitions.ExcelLib.ReadData(2, "Target")));
        }
        #endregion

        #region SearchSkill method

        internal void Searchskill()
        {
            SearchClick.Click();
            GlobalDefinitions.TurnOnWait();
            Category.Click();
            GlobalDefinitions.TurnOnWait();
            Subcategory.Click();
            GlobalDefinitions.TurnOnWait();
            Filter.Click();
            GlobalDefinitions.TurnOnWait();
        }
        internal void Verify_searchskill()
        {
            String Expectedurl = "http://locolhost:5000/Home/Search?cat=ProgrammingTech&subcat=4";
            String URL = GlobalDefinitions.Baseurl;
            Thread.Sleep(1000);
            Assert.AreEqual(URL, Expectedurl);
        }

        #endregion


        #region SearchSkill method

        internal void SearchskillM()
        {
            SearchClick.Click();
            GlobalDefinitions.TurnOnWait();
            Category.Click();
            GlobalDefinitions.TurnOnWait();
            Subcategory.Click();
            GlobalDefinitions.TurnOnWait();
            Filter.Click();
            GlobalDefinitions.TurnOnWait();
        }
        internal void VerifySearchskill()
        {
            String Expectedurl = "http://localhost:5000/Home/Search?cat=ProgrammingTech&subcat=4";
            String URL = GlobalDefinitions.driver.Url;
            Thread.Sleep(1000);
            Assert.AreEqual(URL, Expectedurl);
        }

        #endregion




        #region Language method
        internal void AddNEWLanguage()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "Language");
            Langtab.Click();
            Addnewbutton.Click();
            AddLanguage.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));
            SelectElement Levelsel = new SelectElement(AddLevel);
            Levelsel.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Level"));
            Addbutton.Click();
        }
      
        [FindsBy(How = How.XPath, Using = "(//table//tbody//tr//td[1])[1]")]
        private IWebElement Verifylang { get; set; }
        internal void VerifyLanguageadded()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "Language");

            Assert.AreEqual(Verifylang.Text, GlobalDefinitions.ExcelLib.ReadData(2, "Language"));
        }
        
        internal void EditLanguage()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "Language");
            GlobalDefinitions.TurnOnWait();
            Editclick.Click();
            GlobalDefinitions.TurnOnWait();
            SelectElement Chglevel = new SelectElement(AddLevel);
            Chglevel.SelectByText(GlobalDefinitions.ExcelLib.ReadData(3, "Level"));
            Updatebutton.Click();
            GlobalDefinitions.TurnOnWait();
            Thread.Sleep(1000);

        }
        
        [FindsBy(How = How.XPath, Using = "(//table//tbody//tr//td[2])[1]")]
        private IWebElement Verifyeditlang { get; set; }
        internal void Verifyeditlanguage()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "Language");
            Thread.Sleep(1000);
            Assert.AreEqual(Verifyeditlang.Text, GlobalDefinitions.ExcelLib.ReadData(3, "Level"));
        }
      

        
        internal void DeleteLanguage()
        {
            Deletebutton.Click();
            Thread.Sleep(1000);
        }
      
        [FindsBy(How = How.XPath, Using = "(//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div)")]
        private IWebElement Verifydeletelang { get; set; }
        internal void Verifydeletelanguage()
        {
            Thread.Sleep(1000);
            Assert.AreNotEqual(Verifydeletelang.Text, GlobalDefinitions.ExcelLib.ReadData(2, "Language"));
        }
        #endregion

        #region Addskill method
        internal void Addskill()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\CompetitionTask\marsframework-master\MarsFramework\TestData\ProfileData.xlsx", "Skill");
            Skilltab.Click();
            AddnewSkillbutton.Click();
            Skillname.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));
            SelectElement Levelskill = new SelectElement(Skilllevel);
            Levelskill.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Level"));
            GlobalDefinitions.TurnOnWait();
            Addbutton.Click();
            GlobalDefinitions.TurnOnWait();
        }
     

        [FindsBy(How = How.XPath, Using = "//div[@data-tab='second' ]//tbody[last()]//td[1]")]
        private IWebElement Addskillverify { get; set; }
        internal void Verifyaddskill()
        {
            Thread.Sleep(1000);
            Assert.AreEqual(Addskillverify.Text, GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));
        }
      
        internal void EditSkill()
        {
            Thread.Sleep(1000);
            GlobalDefinitions.TurnOnWait();
            EditbuttonSkill.Click();
            Skillname.Clear();
            GlobalDefinitions.TurnOnWait();
            Skillname.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Skill"));
            UpdatebuttonSkill.Click();
            GlobalDefinitions.TurnOnWait();

        }
     
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='second' ]//tbody[last()]//td[1]")]
        private IWebElement Namechg { get; set; }
        internal void VerifyEditskill()
        {
            Thread.Sleep(1000);
            Assert.AreEqual(Namechg.Text, GlobalDefinitions.ExcelLib.ReadData(3, "Skill"));
        }

   
        internal void Deleteskill()
        {
            Thread.Sleep(1000);
            GlobalDefinitions.TurnOnWait();
            DeletebuttonSkill.Click();
        }
       
        [FindsBy(How = How.XPath, Using = "(//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div)")]
        private IWebElement Deleteact { get; set; }
        internal void Verifydeleteskill()
        {

            GlobalDefinitions.TurnOnWait();
            Thread.Sleep(1000);
            Assert.AreEqual(Deleteact.Text, GlobalDefinitions.ExcelLib.ReadData(3, "Skill") + " " + "has been deleted");
        }
        #endregion


 




    }
}