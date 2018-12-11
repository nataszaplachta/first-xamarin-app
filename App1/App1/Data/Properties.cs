using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Data
{
    public class Properties
    {
        public static IDictionary<string, object> AppProperties = Application.Current.Properties;

        public static async Task Save()
        {
           await Application.Current.SavePropertiesAsync();
        }

    }
}
