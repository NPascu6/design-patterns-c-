namespace CompositeFileSystem
{
    internal class FileItem : FileSystemItem
    {
        private long FileBytes { get; }

        public FileItem(string name, long fileBytes) : base(name)
        {
            this.FileBytes = fileBytes;
        }

        public override decimal GetSizeInKB()
        {
            return decimal.Divide(this.FileBytes, 1024);
        }
    }
}
