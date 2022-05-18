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

                    if (!sftp.Exists(remoteDirectory + project.Id))
                    {
                        sftp.CreateDirectory(remoteDirectory + project.Id);
                    }
                    else
                    {
                        var files = sftp.ListDirectory(remoteDirectory + project.Id);

                        foreach (var file in files)
                        {
                            if (file.Name != "." && file.Name != "..")
                            {
                                WavFiles.Add(new WavFile(file.Name, file.FullName, null));
                                Debug.WriteLine(file.Name);
                            }

                        }
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
            
            if (Directory.Exists(path))
            {
                Process.Start("Explorer.exe", path);
                return true;
            }
            else
            {
                CreateProjectDirectory(project);
                return false;
            }
        }

        public static void CreateProjectDirectory(Project project)
        {
            string path = downloadFolder + "\\" + project.Id.ToString();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static void UploadFile(string filePath, Project project)
        {
            string destination = remoteDirectory + project.Id.ToString();
            string source = filePath;
            
            using (SftpClient sftp = new SftpClient(host, username, password))
            {
                try
                {
                    sftp.Connect();

                    if (!sftp.Exists(destination))
                    {
                        sftp.CreateDirectory(destination);
                    }
                        
                    sftp.ChangeDirectory(destination);

                    using (FileStream fs = new FileStream(filePath, FileMode.Open))

                    {

                        sftp.BufferSize = 4 * 1024;

                        sftp.UploadFile(fs, Path.GetFileName(filePath));

                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine("An exception has been caught " + e.ToString());
                }

            }
        }

        /// <summary>
        /// Télécharge un fichier unique sur le serveur FTP
        /// </summary>
        /// <param name="fileToDownload">Le fichier que l'on souhaite télécharger</param>
        /// <param name="project">Le projet auquel appartient le fichier</param>
        public static void DownloadFile(WavFile fileToDownload, Project project)
        {
            if (fileToDownload != null)
            {
                using (SftpClient sftp = new SftpClient(host, username, password))
                {
                    try
                    {
                        sftp.Connect();

                        string localpath = downloadFolder + "\\" + project.Id.ToString() + "\\" + fileToDownload.Name;

                        if (File.Exists(localpath))
                        {
                            File.Delete(localpath);
                        }

                        using (Stream fileStream = File.OpenWrite(localpath))
                        {
                            sftp.DownloadFile(fileToDownload.RemotePath, fileStream);
                            fileToDownload.LocalPath = localpath;
                        }

                        sftp.Disconnect();
                    }
                    catch (Exception er)
                    {
                        Console.WriteLine("An exception has been caught " + er.ToString());
                    }
                }
            }
            
        }

        public static void DeleteFile(WavFile fileToDelete, Project project)
        {
            using (SftpClient sftp = new SftpClient(host, username, password))
            {
                try
                {
                    sftp.Connect();

                    if (sftp.Exists(fileToDelete.RemotePath))
                        sftp.DeleteFile(fileToDelete.RemotePath);
                    else
                        Debug.WriteLine("File doesn't exist");

                    sftp.Disconnect();

                    if (File.Exists(fileToDelete.LocalPath))
                    {
                        File.Delete(fileToDelete.LocalPath);
                    }
                }
                catch (Exception er)
                {
                    Console.WriteLine("An exception has been caught " + er.ToString());
                }
            }
        }
    }
}
