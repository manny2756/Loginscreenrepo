using System;

namespace loginscreenlibrary
{
  public class LoginScreenUser
  {
    public string Username { get; set; }

    public string Password { get; set; }
    public string Nickname { get; set; }


    public LoginScreenUser( string username, string password)
    {

      Username = username;
      Password = password; 

    }

  }
}
