using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFramework;

namespace Tests
{
    [TestClass]
    public class Test1
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void TestMethod1()
        {
            CloudinaryLoginPage.GoTo();
            CloudinaryLoginPage.Login("felix+evgenivolchonok@cloudinary.com", "9Uo27J1A8ScO!");
            MainMenu.MediaLibraryTab.Select();
            MediaLibraryPage.UploadButton();
            UploadScreenPage.UpperMenu(UpperTabs.MyFiles);
            UploadScreenPage.Advanced.PublicId("Image_Upload");
            UploadScreenPage.UploadImageFromPC("C:\\image\\download.png");
            AfterUploadPage.RightClickOnAddedImage(AfterUploadPage.RightClickMenu.Manage);
            Assert.AreEqual(ManageScreenPage.GetPublicId(), "Image_Upload");

        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.GoBack();
            AfterUploadPage.RightClickOnAddedImage(AfterUploadPage.RightClickMenu.Delete);
            Driver.Close();
        }
    }
}
