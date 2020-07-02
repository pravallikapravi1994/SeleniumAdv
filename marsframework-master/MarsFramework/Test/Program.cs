using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
           
            [Test, Order(1)]
            public void AddShareSkillService()
            {

                GlobalDefinitions.TurnOnWait();

                ShareSkill s = new ShareSkill();
                s.EnterShareSkill();



                GlobalDefinitions.wait(3000);

              

                
                
                GlobalDefinitions.TurnOnWait();



                ManageListings ml = new ManageListings();
                ml.VerifySavedServiceListings();


            }



            [Test, Order(2)]
            public void EditShareSkill()
            {

                GlobalDefinitions.TurnOnWait();

                Profile profile = new Profile();
                profile.NavigateToManageListingpage();

                GlobalDefinitions.TurnOnWait();


              

                
                GlobalDefinitions.TurnOnWait();

                ManageListings ml = new ManageListings();
                ml.EditSharedSkill();


                GlobalDefinitions.TurnOnWait();
                profile.NavigateToManageListingpage();

                GlobalDefinitions.TurnOnWait();
                ml.VerifySavedServiceListings();

               

                GlobalDefinitions.TurnOnWait();     

            }



            [Test, Order(4)]
            public void DeleteShareSkillIsDeleted()
            {

                GlobalDefinitions.TurnOnWait();

                Profile profile = new Profile();
                profile.NavigateToManageListingpage();

                GlobalDefinitions.TurnOnWait();
                GlobalDefinitions.wait(1000);

                ManageListings ml = new ManageListings();
                ml.DeleteSharedSkill();

                GlobalDefinitions.TurnOnWait();
                GlobalDefinitions.wait(1000);
                ml.DeleteSharedYes();

                GlobalDefinitions.TurnOnWait();
                GlobalDefinitions.wait(1000);
                ml.VerifyDeleted();


            }

            [Test, Order(3)]
            public void DeleteShareSkillNotDeleted()
            {

                GlobalDefinitions.TurnOnWait();

                Profile profile = new Profile();
                profile.NavigateToManageListingpage();

                GlobalDefinitions.TurnOnWait();

                ManageListings ml = new ManageListings();
                GlobalDefinitions.wait(1000);
                ml.DeleteSharedSkill();

                GlobalDefinitions.TurnOnWait();
                GlobalDefinitions.wait(1000);
                ml.DeleteSharedSkillNo();

                GlobalDefinitions.TurnOnWait();
                GlobalDefinitions.wait(1000);
                ml.VerifyNotDeleted();


            }


            [Test, Order(5)]
            public void Description()
            {
                Profile des = new Profile();
                GlobalDefinitions.wait(1000);

                des.EditDescription();
                GlobalDefinitions.wait(1000);
                des.VerifyDescription();

            }




            [Test, Order(12)]
            public void Education()
            {
                Profile Edu = new Profile();
                GlobalDefinitions.wait(1000);

                Edu.NavigateToEducationTab();
                GlobalDefinitions.wait(1000);
                Edu.AddEducation();
                GlobalDefinitions.wait(1000);
                Edu.VerifyAddEducation();

                GlobalDefinitions.wait(1000);
                Edu.EditEducation();

                GlobalDefinitions.wait(1000);
                Edu.VerifyEditEducation();


                GlobalDefinitions.wait(1000);
                Edu.DeleteEducation();


                GlobalDefinitions.wait(1000);
                //Edu.VerifyDeleteEducation();


            }




            [Test, Order(13)]
            public void Certification()
            {
                Profile certification = new Profile();
                GlobalDefinitions.wait(1000);


                certification.NavigateToCertification();
                Thread.Sleep(1000);

                certification.AddCertification();
                Thread.Sleep(1000);

                certification.VerifyAddCertification();
                Thread.Sleep(1000);

                certification.EditCertification();
                Thread.Sleep(1000);


                certification.VerifyEditCertification();
                GlobalDefinitions.wait(1000);

                Thread.Sleep(2000);

                certification.DeleteCertification();
                GlobalDefinitions.wait(1000);
                Thread.Sleep(1000);


               // certification.VerifyDeleteCertification();

                

            }



            [Test, Order(6)]
            public void Updateusername()
            {
                Profile un = new Profile();
                un.ProfileEditUsername();
                un.AssertTitleusername();
            }

            [Test, Order(9)]
            public void EditAvailability()
            {
                Profile Avail = new Profile();
                Avail.EditAvailabletime();
                Avail.VerifyAvailableTime();
            }


            [Test, Order(7)]
            public void EditHours()
            {
                Profile Hours = new Profile();
                Hours.EditAvailableHours();
                Hours.VerifyHourssaved();
            }


            [Test, Order(8)]
            public void EditTarget()
            {
                Profile Target = new Profile();
                Target.Targetadd();
                Target.Verify_target_saved();
            }


            [Test, Order(10)]
            public void Language()
            {
                Profile lang = new Profile();
                lang.AddNEWLanguage();
                lang.VerifyLanguageadded();
                lang.EditLanguage();
                lang.Verifyeditlanguage();
                lang.DeleteLanguage();
                lang.Verifydeletelanguage();
            }


            [Test, Order(11)]
            public void Skill()
            {
                Profile Skill = new Profile();
                Skill.Addskill();

                Skill.Verifyaddskill();

                Skill.EditSkill();
                Skill.VerifyEditskill();

                Skill.Deleteskill();
                Skill.Verifydeleteskill();
            }



            [Test, Order(12)]
            public void SearchSkill()
            {
                Profile Search = new Profile();
                Search.SearchskillM();

                Search.VerifySearchskill();
            }




        }
    }
}