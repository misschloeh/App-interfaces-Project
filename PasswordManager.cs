using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string Password
    { get {
      return Password;
    }
      set {
        if (value.Length >= 8) {
          Password = value;
        } 
      }
    }

    public bool Hidden
    { get; private set; }

 
    public string HeaderSymbol {
      get {
        return "----------";
      }
    }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    public void Display() {
      Console.WriteLine("Password");
      Console.WriteLine(HeaderSymbol);
      if (Hidden == false) {
        Console.WriteLine(Password);
      } else {
        Console.WriteLine("*****");
      }
    }

    public void Reset() {
      Password = " ";
      Hidden = false;
    }
  }
}