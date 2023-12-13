namespace InterviewPrep.SOLID
{
    // Liskov Substitution Principle
    // Subtypes are substitutable for their base types.

    // Template Method Pattern (Liskov Substitution Principle)
    // Template method ensures a common structure for derived classes.

    // Template Method Interface
    public interface IDocumentProcessor
    {
        void ProcessDocument();
    }

    // Template Method Class
    public abstract class DocumentProcessorBase : IDocumentProcessor
    {
        public void ProcessDocument()
        {
            // Common processing logic
            OpenDocument();
            EditDocument();
            SaveDocument();
        }

        protected abstract void OpenDocument();
        protected abstract void EditDocument();
        protected abstract void SaveDocument();
    }

    // PdfDocumentProcessor (Liskov Substitution Principle)
    public class PdfDocumentProcessor : DocumentProcessorBase
    {
        protected override void OpenDocument() => Console.WriteLine("Opening PDF document");
        protected override void EditDocument() => Console.WriteLine("Editing PDF document");
        protected override void SaveDocument() => Console.WriteLine("Saving PDF document");
    }

    // WordDocumentProcessor (Liskov Substitution Principle)
    public class WordDocumentProcessor : DocumentProcessorBase
    {
        protected override void OpenDocument() => Console.WriteLine("Opening Word document");
        protected override void EditDocument() => Console.WriteLine("Editing Word document");
        protected override void SaveDocument() => Console.WriteLine("Saving Word document");
    }
}
