using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace Task3
{
    class FileExplorer
    {
        public static void SearchFile(string name)
        {
            // выбивает ошибку при обращении к закрытой папке (решено catch)
            string[] drives = Directory.GetLogicalDrives();
            int count = 0;

            foreach (string drive in drives)
            {
                string[] directories = Directory.GetDirectories(drive);
                foreach (string adress in directories)
                {
                    DirectoryInfo subDirectory = new DirectoryInfo(adress);
                    try
                    {
                        FileInfo[] files = subDirectory.GetFiles(name, SearchOption.AllDirectories);
                        foreach (var file in files)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"File found: {file.FullName}");
                            count++;
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{adress} - acces denied!");
                        continue;
                    }
                    finally
                    {
                        Console.ResetColor();
                    }
                }
            }
            Console.WriteLine($"Files found: {count}");
            Console.WriteLine("Done!");
        }
        public static List<FileInfo> GetFileAdress (string name)
        {
            // возвращает коллекцию найденых файлов. модификация SearchFile()
            string[] drives = Directory.GetLogicalDrives();
            List<FileInfo> founded = new List<FileInfo>();

            foreach (string drive in drives)
            {
                string[] directories = Directory.GetDirectories(drive);
                foreach (string adress in directories)
                {
                    DirectoryInfo subDirectory = new DirectoryInfo(adress);
                    try
                    {
                        FileInfo[] files = subDirectory.GetFiles(name, SearchOption.AllDirectories);
                        foreach (var file in files)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"File found: {file.FullName}");
                            founded.Add(file);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{adress} - acces denied!");
                        continue;
                    }
                    finally
                    {
                        Console.ResetColor();
                    }
                }
            }
            Console.WriteLine($"Files found: {founded.Count}");
            Console.WriteLine("Done!");
            return founded;
        }
        public static void ShowContent(string adress)
        {
            FileStream file = File.OpenRead(adress);
            StreamReader reader = new StreamReader(file);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }
        public static void ShowContent (FileInfo document)
        {
            string adress = document.FullName;
            FileStream file = File.OpenRead(adress);
            StreamReader reader = new StreamReader(file);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }

        public static void CreateZip (string adress)
        {
            FileStream source = File.OpenRead(adress);
            FileStream destination = File.Create(adress + ".zip");

            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

            int theByte = source.ReadByte();
            while(theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = source.ReadByte();
            }
            compressor.Close();
            Console.WriteLine("ZIP created!");
        }
    }
}
