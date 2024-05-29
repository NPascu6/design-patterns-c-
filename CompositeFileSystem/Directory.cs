namespace CompositeFileSystem
{
    internal class Directory : FileSystemItem
    {
        private List<FileSystemItem> _children = new List<FileSystemItem>();

        public Directory(string name) : base(name)
        {
        }

        public void Add(FileSystemItem fileSystemItem)
        {
            _children.Add(fileSystemItem);
        }

        public void Remove(FileSystemItem fileSystemItem)
        {
            _children.Remove(fileSystemItem);
        }

        public override decimal GetSizeInKB()
        {
            return _children.Sum(child => child.GetSizeInKB());
        }
    }
}
