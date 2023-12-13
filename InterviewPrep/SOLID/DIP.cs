namespace InterviewPrep.SOLID
{
    // Dependency Inversion Principle
    // High-level modules do not depend on low-level modules; both depend on abstractions.

    // Dependency Injection (DIP)
    // Dependencies are injected rather than created within the class.

    // Dependency Interface
    public interface IDocumentProcessorFactory
    {
        IDocumentProcessor CreateDocumentProcessor();
    }

    // Dependency Implementation
    public class PdfDocumentProcessorFactory : IDocumentProcessorFactory
    {
        public IDocumentProcessor CreateDocumentProcessor() => new PdfDocumentProcessor();
    }

    // Client Using Dependency (Injected)
    public class DocumentViewerClient
    {
        private readonly IDocumentViewer documentViewer;

        public DocumentViewerClient(IDocumentViewer documentViewer)
        {
            this.documentViewer = documentViewer;
        }

        public void ViewDocument()
        {
            documentViewer.ViewDocument();
        }
    }
}
