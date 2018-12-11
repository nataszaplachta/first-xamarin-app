using App1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddNewStudentPage : ContentPage
	{
		public AddNewStudentPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var firstName = entryFirstName.Text;
            var lastName = entryLastName.Text;
            int className = int.Parse(entryClassName.Text);
            DateTime birthday = dpBirthday.Date;

            var student = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                ClassNumber = className,
                Birthday = birthday
            };
            var result = await App.LocalDB.SaveItem(student);

            if (result > 0)
            {
                await DisplayAlert("SUKCES", "Student dodany do bazy", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("BŁĄD", "Nie udało się dodać studenta", "OK");

            }
        }
    }
}