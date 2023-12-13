namespace InterviewPrep.SOLID
{
    // Open/Closed Principle
    // The DocumentEditor class is open for extension (new document types) but closed for modification.

    // Strategy Pattern (Open/Closed Principle)
    // Each document type is a strategy.

    // Strategy Interface
    public interface IDocumentStrategy
    {
        IDocument CreateDocument();
    }

    // PDF Document Strategy
    public class PdfDocumentStrategy : IDocumentStrategy
    {
        public IDocument CreateDocument() => new PdfDocument();
    }

    // Word Document Strategy
    public class WordDocumentStrategy : IDocumentStrategy
    {
        public IDocument CreateDocument() => new WordDocument();
    }

    // DocumentEditor (Uses Strategy)
    public class DocumentEditor
    {
        private readonly IDocumentStrategy documentStrategy;

        public DocumentEditor(IDocumentStrategy strategy)
        {
            this.documentStrategy = strategy;
        }

        public void EditDocument()
        {
            IDocument document = documentStrategy.CreateDocument();
            document.Open();
            // Additional editing logic
            document.Save();
        }
    }
}
