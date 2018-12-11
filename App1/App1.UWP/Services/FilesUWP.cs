using App1.Data;
using App1.UWP.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(FilesUWP))]
namespace App1.UWP.Services
{
    public class FilesUWP : IFileHelper
    {
        public string GetFilePath(string name)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, name);
        }
    }
}
