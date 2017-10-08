using System;

namespace TextToLibUniversalWindows
{
   class TextToMobileApp : ITextToBase
   {
      //Encapsulated string to print out to the console.
      private string textString = null;


      //Allow client to read but not write.
      public string TextString => throw new NotImplementedException();

      //Gets the text from the source.
      public void GetTextFromSource()
      {
         throw new NotImplementedException();
      }

      //Write (send/transmit) to the mobile phone.
      public void WriteToDestination()
      {
         throw new NotImplementedException();
      }
   }
}
