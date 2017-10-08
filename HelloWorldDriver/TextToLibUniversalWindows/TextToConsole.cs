using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToLibUniversalWindows
{
   public class TextToConsole : ITextToBase
   {


      //encapsulated string to print out to the console
      private string textString = null;
      
      //location is a string that has destination information for write locations.
      private string location = null;

      public TextToConsole(string location)
      {
         this.location = location;
      }

      //Allows client to read but not write.
      public string TextString { get => textString; }

      //Gets the text from the source, for now its hard coded.
      public void GetTextFromSource()
      {
         //For now its just hard coded into the method.
         textString = "Hello World!";
      }

      //Write to the Console.
      public void WriteToDestination()
      {
         if (String.IsNullOrEmpty(textString))
         {
            throw new ArgumentNullException("String used for output is NULL or empty.");
         }

         Console.WriteLine("The location to write the message is: "+location);
         Console.WriteLine(textString);
         Console.ReadLine();

      }
   }
}

