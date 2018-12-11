using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using App1.Data;
using App1.iOS.Services;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(IosFileService))]
namespace App1.iOS.Services
{

    public class IosFileService : IFileHelper
    {
        public string GetFilePath(string name)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal); string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, name);
        }
    }
}