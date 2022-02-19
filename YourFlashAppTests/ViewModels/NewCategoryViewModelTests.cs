using Microsoft.VisualStudio.TestTools.UnitTesting;
using YourFlashApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFlashApp.ViewModels.Tests
{
    [TestClass()]
    public class NewCategoryViewModelTests
    {
        [TestMethod()]
        public void ValidateSave_Return_True_Test()
        {
            NewCategoryViewModel model = new NewCategoryViewModel();

            model.name = "Home";
            model.IsCategoryExist = false;

            bool actual = model.ValidateSave();

            Assert.IsTrue(actual);
        }


        [TestMethod()]
        public void ValidateSave_Return_False_Test_1()
        {
            NewCategoryViewModel model = new NewCategoryViewModel();

            model.name = "";
            model.IsCategoryExist = false;

            bool actual = model.ValidateSave();

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void ValidateSave_Return_False_Test_2()
        {
            NewCategoryViewModel model = new NewCategoryViewModel();

            model.name = "University";
            model.IsCategoryExist = true;

            bool actual = model.ValidateSave();

            Assert.IsFalse(actual);
        }

    }
}