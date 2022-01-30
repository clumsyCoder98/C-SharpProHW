using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Task3MVP
{
    class Model
    {
        public string SearchFile(string filename)
        {
            string name = filename + "*";
            StringBuilder text = new StringBuilder();
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
                            
                            text.AppendLine($"File found: {file.FullName}");
                            count++;
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        text.AppendLine($"{adress} - acces denied!");
                        continue;
                    }
                }
            }
            text.AppendLine($"Files found: {count}");
            string result = text.ToString();
            return result;
        }
        public string ShowContent(string adress)
        {
            FileStream file = File.OpenRead(adress);
            StreamReader reader = new StreamReader(file);
            string content = reader.ReadToEnd();
            reader.Close();
            return content;
        }
        public void CreateZip(string adress)
        {
            FileStream source = File.OpenRead(adress);
            FileStream destination = File.Create(adress + ".zip");

            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

            int theByte = source.ReadByte();
            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = source.ReadByte();
            }
            compressor.Close();
        }
    }
}
