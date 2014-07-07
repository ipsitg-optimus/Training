using System;
using System.IO;
using System.IO.Compression;
namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayDriveAttributes();
            DisplayNewFiles();
            Console.WriteLine(Path.GetFullPath("Induction"));
            FileManipulations();
            Console.ReadLine();
            Compress(new FileInfo("C:\\Induction\\FileWrite.txt"));
            Console.ReadLine();
        }

        /// <summary>
        /// Displays information about the C Drive of the system.
        /// </summary>
        static void DisplayDriveAttributes()
        {
            DriveInfo info = new DriveInfo("C");
            Console.WriteLine("---------Information of C Drive---------");
            Console.WriteLine("Name of Drive: " + info.Name);
            Console.WriteLine("Total Size:" + info.TotalSize);
            Console.WriteLine("Available Free space: " + info.AvailableFreeSpace);
            Console.WriteLine("Format of the Drive: " + info.DriveFormat);
            Console.WriteLine("Drive type: " + info.DriveType);
        }

        /// <summary>
        /// Displays new files and folders created.
        /// </summary>
        static void DisplayNewFiles()
        {
            Console.WriteLine("\n\n---------Information about new files and folder---------");
            DirectoryInfo directory = new DirectoryInfo("C:\\Induction");
            Console.WriteLine("Full name of the directory: " + directory.FullName);
            Console.WriteLine("Creation time of directory: " + directory.CreationTime);
            Console.WriteLine("Parent of the directory: " + directory.Parent);
            Console.WriteLine("Displaying information of all files in this directory.\n");
            foreach (FileInfo file in directory.GetFiles())
            {
                Console.WriteLine("\nName of the file: " + file.Name);
                Console.WriteLine("Extension of the file: " + file.Extension);
                Console.WriteLine("Is read only: " + file.IsReadOnly);
                Console.WriteLine("Last Access time: " + file.LastAccessTime);
                Console.WriteLine("Size of the file: " + file.Length);
            }
        }

        /// <summary>
        /// Does certain manipulations on the files.
        /// </summary>
        static void FileManipulations()
        {
            File.SetAttributes("C:\\Induction\\FileRead.txt", FileAttributes.ReadOnly);
            StreamReader readfile = new StreamReader("c:\\induction\\fileread.txt");
            string myString = readfile.ReadToEnd();
            readfile.Close();
            StreamWriter writefile = new StreamWriter("C:\\Induction\\FileWrite.txt");
            writefile.Write(myString);
            writefile.Close();
        }

        /// <summary>
        /// this method compresses the file using g zip compression.
        /// </summary>
        public static void Compress(FileInfo fileToCompress)
        {
            using (FileStream originalFileStream = fileToCompress.OpenRead())
            {
                if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                {
                    using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                    {
                        using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                        {
                            originalFileStream.CopyTo(compressionStream);
                            Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
                                fileToCompress.Name, fileToCompress.Length.ToString(), compressedFileStream.Length.ToString());
                        }
                    }
                }
            }
        }
    }
}
