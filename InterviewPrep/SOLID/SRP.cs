namespace InterviewPrep.SOLID
{
    public interface IDocument
    {
        void Open();
        void Save();
    }

    // PDF Document Class (Single Responsibility: Handling PDF-specific logic)
    public class PdfDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening PDF document");
        public void Save() => Console.WriteLine("Saving PDF document");
    }

    // Word Document Class (Single Responsibility: Handling Word-specific logic)
    public class WordDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening Word document");
        public void Save() => Console.WriteLine("Saving Word document");
    }
}
