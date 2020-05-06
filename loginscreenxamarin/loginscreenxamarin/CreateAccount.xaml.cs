using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using loginscreenlibrary;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loginscreenxamarin
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class CreateAccount : ContentPage
  {
    public CreateAccount()
    {
      InitializeComponent();
      




    }

    private void NewUser_btn(object sender, EventArgs e)
    {
      
      string username = NewUser.Text.ToLower().Trim();
      string password = NewPassword.Text;
      string confirmedpass = ConfirmedPass.Text; 
      LoginScreenUser user = MainPage.Users.Find(u => u.Username == username);
      if (user != null)
      {
        DisplayAlert("Username unavailable", "Use another username", "Ok");
      }

      else
      {
        if (password == confirmedpass)
        {
          MainPage.Users.Add(new LoginScreenUser(username, password));
          Navigation.PopAsync();
        }
        else
        {
          DisplayAlert(" Passwords do not match", "Re-type password", "Ok");
        }
             
      }
      

      

    }
  }
}