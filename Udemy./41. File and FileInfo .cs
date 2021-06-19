using System;
using System.Collections.Generic;
using System.IO;
namespace File_FileInfoNS
{
    public class UFile_FileInfoClass
    {
        static void Main()
        {
            //File 
            var path1 = @"C:\Pranik\pic1.jpg";
            var path2 = @"C:\PranikNikose\Folder";

            File.Copy(path1, path2, true);
            File.Delete(path1);
            if (File.Exists(path2))
                Console.WriteLine("File Exists");
            var content = File.ReadAllText(path2);

            //FileInfo()
            var file_info = new FileInfo(path1);
            file_info.CopyTo("....");
            file_info.Delete();
            if (file_info.Exists)
                Console.WriteLine("file_info Exists");
        }
    }
}

