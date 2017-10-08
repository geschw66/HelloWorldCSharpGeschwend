using System;
using TextToLibUniversalWindows;
using System.Configuration;
using System.Linq;

namespace HelloWorldDriver
{
   class Program
   {
      static void Main(string[] args)
      {
         try
         {
            //If the destinations were to write to a database, or an application server.
            // this would garner any connection strings, address of the application server etc.
            // since this being written to a console, we really don't need this.
            var section = (ConfigurationManager.GetSection("WriteDestinations/Destinations") as System.Collections.Hashtable)
                 .Cast<System.Collections.DictionaryEntry>()
                 .ToDictionary(n => n.Key.ToString(), n => n.Value.ToString());

            string platform = "MOBILE";
            string locationInformation;
            section.TryGetValue(platform, out locationInformation);

            ITextToBase textToConsole = new TextToConsole(locationInformation);
            textToConsole.GetTextFromSource();
            textToConsole.WriteToDestination();
         }
         catch (ArgumentNullException e)
         {
            Console.WriteLine("ERROR: string to write is NULL: " + e.Message);
         }
         catch (Exception e)
         {
            Console.WriteLine("ERROR: " + e.Message);
         }
         

      }
   }
}
