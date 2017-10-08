using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextToLibUniversalWindows;
namespace UnitTestTextTo
{
   [TestClass]
   public class UnitTestsTextToLibUniversalWindows
   {
      //Testing return type (would be the first unit test to
      // test in Test Driven Development).
      [TestMethod]
      public void TestTextToConsoleTextStringProperty()
      {
         //Simple setup:
         string testingTextString = null;
         string platform = "CONSOLE";
         TextToConsole textToConsole = new TextToConsole(platform);
         textToConsole.GetTextFromSource();
         testingTextString = textToConsole.TextString;

         //Per specification the property should return a string type.
         Assert.IsInstanceOfType(testingTextString, typeof(string));
      }

      //Test PRE condition of GetTextFromSource() method.
      [TestMethod]
      public void TestTextToConsolePreGetTextFromSource()
      {
         //Simple setup:
         string testingTextString = null;
         string platform = "CONSOLE";
         TextToConsole textToConsole = new TextToConsole(platform);
         testingTextString = textToConsole.TextString;

         //If GetTextFromSource() has not been called, parameter
         //   should be null.
         Assert.AreEqual(null, testingTextString);
      }

      //Test POST condition of GetTextFromSource() method.
      [TestMethod]
      public void TestTextToConsoleGetTextFromSource()
      {
         string testingTextString = null;
         string platform = "CONSOLE";
         TextToConsole textToConsole = new TextToConsole(platform);
         textToConsole.GetTextFromSource();
         testingTextString = textToConsole.TextString;

         //If GetTextFromSource() HAS been called, parameter
         //   should NOT be null.
         Assert.AreNotEqual(null, testingTextString);
      }

      //Per Program requirement string should be "Hello World!"
      [TestMethod]
      public void TestTextStringEqualToHelloWorld()
      {
         string Actual = null;
         string Expected = "Hello World!";

         string platform = "CONSOLE";
         TextToConsole textToConsole = new TextToConsole(platform);
         textToConsole.GetTextFromSource();
         Actual = textToConsole.TextString;

         //Per the requirements the Expected value of the string should
         //   be "Hello World!" (If its not, then requirements have changed, or
         //   requirements are not fully understood.
         Assert.AreEqual(Expected, Actual);
      }


      [TestMethod]
      public void TestTextToConsoleWriteToDestination()
      {
         string platform = "CONSOLE";
         TextToConsole textToConsole = new TextToConsole(platform);
         try
         {
            //Did not call GetTextFrom source so exception should be thrown.
            textToConsole.WriteToDestination();
         }
         catch (ArgumentNullException e)
         {
            //If the getTextFromSource fails to assign a string to the
            //  TextString. Contains( <string>, <substring>).
            StringAssert.Contains(e.Message,"String used for output is NULL");
            return;
         }
        
      }
   }
}
