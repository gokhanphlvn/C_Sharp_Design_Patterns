namespace Composite
{
    /// <summary>
    /// Component
    /// </summary>
    public abstract class FileSystemItem
    {
        public string Name { get; set; }
        public abstract long GetSize();

        public FileSystemItem(string name) { this.Name = name; } 
    }
}
