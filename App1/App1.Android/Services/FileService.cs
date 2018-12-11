using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Service.QuickSettings;
using Android.Views;
using Android.Widget;
using App1.Data;
using App1.Droid.Services;
using Xamarin.Forms;
using DependencyAttribute = Xamarin.Forms.DependencyAttribute;

[assembly: Dependency(typeof(FileService))]

namespace App1.Droid.Services
{
    public class FileService : IFileHelper
    {
        public string GetFilePath(string name)
        {
            string path = System.Environment.GetFolderPath(
              System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, name);
        }
        }
}
