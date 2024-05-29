using CompositeFileSystem;
using Directory = CompositeFileSystem.Directory;

FileSystemItem documents = new FileItem("Documents", 122230);
Console.WriteLine("Documents size:" + documents.GetSizeInKB());
FileSystemItem music = new FileItem("Music", 3212000);
Console.WriteLine("Music size:" + music.GetSizeInKB());
FileSystemItem pictures = new FileItem("Pictures", 83000000000);
Console.WriteLine("Pictures size:" + pictures.GetSizeInKB());

Directory rootDirectory = new Directory("Root");
Console.WriteLine(rootDirectory.GetSizeInKB());

Directory folder1 = new Directory("Folder1");
Console.WriteLine("\nFolder1 fsize:");
Console.WriteLine(folder1.GetSizeInKB());

Directory folder2 = new Directory("Folder2");
Console.WriteLine("\nFolder2 fsize:");
Console.WriteLine(folder2.GetSizeInKB());

Console.WriteLine($"\nAdding documents and music to folder 1");
folder1.Add(documents);
folder1.Add(music);

Console.WriteLine($"\nFolder 1 size:");
Console.WriteLine(folder1.GetSizeInKB());

Console.WriteLine($"\nAdding pictures to folder 2");
folder2.Add(pictures);

Console.WriteLine($"\nFolder 2 size:");
Console.WriteLine(folder2.GetSizeInKB());

Console.WriteLine("\nAdding folders to root directory");
rootDirectory.Add(folder1);
rootDirectory.Add(folder2);
Console.WriteLine("\nRootDirectory folder size:");
Console.WriteLine(rootDirectory.GetSizeInKB());

Console.ReadKey();


