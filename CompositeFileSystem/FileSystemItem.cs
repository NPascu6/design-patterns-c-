namespace CompositeFileSystem
{
    internal abstract class FileSystemItem
    {
        public string Name { get; }

        public FileSystemItem(string name)
        {
            Name = name;
        }

        public abstract decimal GetSizeInKB();
    }
}
