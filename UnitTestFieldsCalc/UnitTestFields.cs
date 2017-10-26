using System;
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
        [TestMethod]
        public void TestMethodPlus()
        {
            Application application = Application.Launch("C:\\my stuff\\ORT courses\\Homeworks\\WindowsFormsApplicationCalc\\WindowsFormsApplicationCalc\\obj\\Release\\WindowsFormsApplicationCalc.exe");
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
            Application application = Application.Launch("C:\\my stuff\\ORT courses\\Homeworks\\WindowsFormsApplicationCalc\\WindowsFormsApplicationCalc\\obj\\Release\\WindowsFormsApplicationCalc.exe");
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
            Application application = Application.Launch("C:\\my stuff\\ORT courses\\Homeworks\\WindowsFormsApplicationCalc\\WindowsFormsApplicationCalc\\obj\\Release\\WindowsFormsApplicationCalc.exe");
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
            Application application = Application.Launch("C:\\my stuff\\ORT courses\\Homeworks\\WindowsFormsApplicationCalc\\WindowsFormsApplicationCalc\\obj\\Release\\WindowsFormsApplicationCalc.exe");
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
