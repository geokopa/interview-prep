namespace InterviewPrep.SOLID
{
    // Interface Segregation Principle
    // Clients are not forced to depend on methods they do not use.

    // Adapter Pattern (Interface Segregation Principle)
    // Adapter allows the client to work with the expected interface.

    // Client Interface
    public interface IDocumentViewer
    {
        void ViewDocument();
    }

    // Adapter
    public class DocumentViewerAdapter : IDocumentViewer
    {
        private readonly IDocumentProcessor documentProcessor;

        public DocumentViewerAdapter(IDocumentProcessor documentProcessor)
        {
            this.documentProcessor = documentProcessor;
        }

        public void ViewDocument()
        {
            // Additional logic if needed
            documentProcessor.ProcessDocument();
        }
    }
}
