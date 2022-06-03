using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.DB
{
    public class WavFile
    {
        private string _name;
        private string _remotePath;
        private string _localPath;

        public string Name { get => _name; set => _name = value; }
        public string RemotePath { get => _remotePath; set => _remotePath = value; }
        public string LocalPath { get => _localPath; set => _localPath = value; }

        public WavFile(string name, string remotePath, string localPath)
        {
            _name = name;
            _remotePath = remotePath;
            _localPath = localPath;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
