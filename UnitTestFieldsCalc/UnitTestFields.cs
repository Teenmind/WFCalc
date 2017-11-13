using System;
using System.Configuration;
using System.IO;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using TestStack.White.UIItemEvents;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using WindowsFormsApplicationCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFieldsCalc
{
    [TestClass]
    public class UnitTestFields
    {
        private Application GetApplication()
        {
            var configCalcPath = ConfigurationManager.AppSettings["calcPath"];
            var calcPath = string.IsNullOrEmpty(configCalcPath) ? Directory.GetCurrentDirectory() : configCalcPath;
            return Application.Launch($"{calcPath}\\WindowsFormsApplicationCalc.exe");
        }

        [TestMethod]
        public void TestMethodPlus()
        {
            var application = GetApplication();
            Window window = application.GetWindow("Calculator", InitializeOption.NoCache); 

            window.Get<TextBox>("txtA").Text = "5";
            window.Get<TextBox>("txtB").Text = "5";
            window.Get<TextBox>("txtOp").Text = "+";
            window.Get<Button>("btnCalc").Click();
            string res = window.Get<TextBox>("txtRes").Text;
            application.Kill();
            Assert.AreEqual("10",res);
        }

        [TestMethod]
        public void TestMethodMinus()
        {
            var application = GetApplication();
            Window window = application.GetWindow("Calculator", InitializeOption.NoCache);

            window.Get<TextBox>("txtA").Text = "5";
            window.Get<TextBox>("txtB").Text = "5";
            window.Get<TextBox>("txtOp").Text = "-";
            window.Get<Button>("btnCalc").Click();
            string res = window.Get<TextBox>("txtRes").Text;
            application.Kill();
            Assert.AreEqual("0", res);
        }

        [TestMethod]
        public void TestMethodMult()
        {
            var application = GetApplication();
            Window window = application.GetWindow("Calculator", InitializeOption.NoCache);

            window.Get<TextBox>("txtA").Text = "5";
            window.Get<TextBox>("txtB").Text = "5";
            window.Get<TextBox>("txtOp").Text = "*";
            window.Get<Button>("btnCalc").Click();
            string res = window.Get<TextBox>("txtRes").Text;
            application.Kill();
            Assert.AreEqual("25", res);
        }

        [TestMethod]
        public void TestMethodDiv()
        {
            var application = GetApplication();
            Window window = application.GetWindow("Calculator", InitializeOption.NoCache);

            window.Get<TextBox>("txtA").Text = "5";
            window.Get<TextBox>("txtB").Text = "5";
            window.Get<TextBox>("txtOp").Text = "/";
            window.Get<Button>("btnCalc").Click();
            string res = window.Get<TextBox>("txtRes").Text;
            application.Kill();
            Assert.AreEqual("1", res);
        }
    }
}
