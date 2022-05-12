using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Renci.SshNet;
using Renci.SshNet.Sftp;
using System.IO;
using System.Diagnostics;
using WavContact.Models;
using System.Threading;

namespace WavContact.DB
{
    public class WavFTP
    {
        static string host = @"ssh.waview.ch";
        static string username = "waview.ch";
        static string password = @"ssh_waview.ch";
        static string remoteDirectory = "/customers/3/8/4/waview.ch/httpd.www/wavcontact/projects/";

        static string downloadFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + "\\Projects";

        public static List<WavFile> listFiles(Project project)
        {
            List<WavFile> WavFiles = new List<WavFile>();
            
            using (SftpClient sftp = new SftpClient(host, username, password))
            {
                try
                {
                    sftp.Connect();

                    var files = sftp.ListDirectory(remoteDirectory + project.Id);


                    foreach (var file in files)
                    {
                        WavFiles.Add(new WavFile(file.Name, file.FullName, null));
                        Debug.WriteLine(file.Name);
                    }

                    sftp.Disconnect();
                    return WavFiles;
                }
                catch (Exception e)
                {
                    Debug.WriteLine("An exception has been caught " + e.ToString());
                    return null;
                }
            }
        }
        
        public static bool OpenProjectFolder(Project project)
        {
            string path = downloadFolder + "\\" + project.Id.ToString();
            
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                return false;
            }
            else
            {
                Process.Start("Explorer.exe",path);
                return true;
            }
        }

        public static void UploadFile(string filePath, Project project)
        {
            string destination = remoteDirectory + "\\" + project.Id.ToString();
            string source = filePath;
            
            using (SftpClient sftp = new SftpClient(host, username, password))
            {
                try
                {
                    sftp.Connect();
                    
                    //FileStream fs = new FileStream()
                    
                    //sftp.UploadFile()
                }
                catch (Exception e)
                {
                    Debug.WriteLine("An exception has been caught " + e.ToString());
                }

            }
        }
    }
}
