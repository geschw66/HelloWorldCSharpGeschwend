namespace TextToLibUniversalWindows
{
   public interface ITextToBase
   {

         //TextString property: limited to getting the text string.
         string TextString { get; }

         //Reads text string from source, and populates the TextString property.
         void GetTextFromSource();

         //Library provides a unique function to determine where to write to.
         // every derived class must implement this.
         void WriteToDestination();

   }
}