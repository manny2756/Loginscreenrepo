using loginscreenlibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace loginscreenxamarin
{
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(false)]
  public partial class MainPage : ContentPage
  {
    string correctUser = "manny";
    public static List<LoginScreenUser> Users { get; set; } = new List<LoginScreenUser> { new LoginScreenUser("manny", "Lakers24") {Nickname = "" } };
    string correctPassword = "Lakers24";
    public MainPage()
    {
      InitializeComponent();
    }

    private void BtnSignIn_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
      string username = Username.Text.ToLower().Trim();
      LoginScreenUser user = Users.Find(u => u.Username == username);

      if (user != null)
      {
        if (Password.Text == user.Password)
        {

          Navigation.PushAsync(new SuccessPage());

        }
        else
        {
          Mainlabel.Text = "Sign In Failed, Invalid Password";
          DisplayAlert("Sign In Failed", "Your password is invalid", "Ok");
        }

      }
      else
      {
        Mainlabel.Text = "Sign In Failed, Invalid Username";
        DisplayAlert("Sign In Failed", "Your username is invalid", "Ok");

      }

    }

    private void Create_btn(object sender, EventArgs e)
    {
      Navigation.PushAsync(new CreateAccount());
    }
  }
}
