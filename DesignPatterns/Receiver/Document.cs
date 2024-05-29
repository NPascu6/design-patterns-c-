namespace CommandPattern.Receiver
{
    public class Document
    {
        public void Open()
        {
            Console.WriteLine("Document Opened");
        }

        public void Save()
        {
            Console.WriteLine("Document Saved");
        }

        public void Close()
        {
            Console.WriteLine("Document Closed");
        }

        public void Delete()
        {
            Console.WriteLine("Document Deleted");
        }
    }
}
