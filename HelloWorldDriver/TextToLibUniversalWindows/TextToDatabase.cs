using System;

namespace TextToLibUniversalWindows
{
   class TextToDatabase : ITextToBase
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

      //Write (insert) to the database.
      public void WriteToDestination()
      {
         throw new NotImplementedException();
      }
   }
}
