using System;
public class KeybaseCommands
{
  private string username = "";
  private string password = "";
  public KeybaseCommands(string keyabaseUsername, string keybasePassword)
  {
    username = keyabaseUsername;
    password = keybasePassword;
  }

  public string Decrypt(string encryptedMessage) 
  {
    //TODO decrypt the things here.
    throw new NotImplementedException();
  }

  public string Encrypt(string message) 
  {
    //TODO encrypt the things here.
    throw new NotImplementedException();
  }

}