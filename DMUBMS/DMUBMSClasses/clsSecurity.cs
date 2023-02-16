using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Data.SqlClient;

/// <summary>
/// basic security class - free to use so long as you credit the author i.e. me
/// Matthew Dean mjdean@dmu.ac.uk
/// last update 17/8/2018
/// </summary>
/// 

namespace DMUBMSClasses
{
    public class clsSecurity
    {
        public class clsEMail
        {
            ///this class is internal to clsSecurity just to make it simpler to use
            ///you may want to consider using this definition to create your own class
            ///within your class library and then get rid of this definition
            public string Subject { get; internal set; }
            public string Recipient { get; internal set; }
            public string Sender { get; internal set; }
            public string Body { get; internal set; }

            public void SendEMail()
            {
                //sends an email
                //this function won't work till all the code is activated
                System.Net.Mail.MailMessage eMail = new System.Net.Mail.MailMessage();
                System.Net.Mail.SmtpClient Server = new System.Net.Mail.SmtpClient("mail.dmu.ac.uk");
                eMail = new System.Net.Mail.MailMessage(this.Sender, this.Recipient, this.Subject, this.Body);
                //Server.Send(eMail);
            }

        }

        //private data members
        //used to store the email address of the currently authenticated user
        private string mUserEMail = "";
        //indicates if the user is admin or not
        private Boolean mAdmin = false;
        //records the number of failed login attempts
        private Int32 mAttempts;
        //stores the most recently sent email message by the security system
        private clsEMail mEMailMessage;

        //constructor
        public clsSecurity()
        {
            //set attempts to zero
            mAttempts = 0;
        }

        public string Register(string EMail, string Password1, string Password2, Boolean Active)
        //public method allowing the user to sign up for an account
        {
            //var to store any errors
            string Message = "";
            //if the email address isn't taken
            if (EMailTaken(EMail) == false)
            {
                //if the two passwords match
                if (Password1 == Password2)
                {
                    //check pasword complexity
                    Message = CheckPassword(Password1);
                    //if complexity OK
                    if (Message == "")
                    {
                        //if the email is valid
                        if (IsValidEmail(EMail))
                        {
                            //get the hash of the plain text password
                            string HashPassword = GetHashString(Password1 + EMail);
                            //add the record to the database
                            clsDataConnection DB = new clsDataConnection();
                            DB.AddParameter("@AccountEMail", EMail.ToLower());
                            DB.AddParameter("@AccountPassword", HashPassword);
                            DB.AddParameter("@Active", Active);
                            DB.Execute("sproc_tblAccount_Add");
                            //if active not set to true then request email activation
                            if (Active == false)
                            {
                                //send the activation email
                                SendActivationEMail(EMail);
                                //set the return message
                                Message = "An email has been sent to your account allowing you to activate the account";
                            }
                            else
                            {
                                //set the return message
                                Message = "The account has been created.";
                            }
                        }
                        else
                        {
                            //set the return message
                            Message = "The e-mail address is not in a valid format";
                        }
                    }
                }
                //if the passwords do not match
                else
                {
                    //generate an error message
                    Message = "The passwords do not match.";
                }
            }
            else
            {
                //generate an error message
                Message = "The account already exists.";
            }
            //return the error message (if there is one)
            return Message;
        }

        private Boolean EMailTaken(string EMail)
        {
            //tests to see if the email address is taken
            //connect to the database and see if it there already
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AccountEMail", EMail.ToLower());
            DB.Execute("sproc_tblAccount_FilterByEMail");
            //if one record found then it is already gone
            if (DB.Count == 1)
            {
                //return true
                return true;
            }
            else
            {
                //return false
                return false;
            }
        }

        private string GetHashString(string SomeText)
        {
            //generates a hash for storing secure data in the database
            if (SomeText != "")//if there is text to process
            {
                //create an instance of the hash generator
                SHA256Managed HashGenerator = new SHA256Managed();
                //var to store the final hash
                string HashString;
                //array to store the bytes of the orignal text
                byte[] TextBytes;
                //array to store the bytes of the new hash
                byte[] HashBytes;
                //convert the text in the string to an array of bytes
                TextBytes = System.Text.Encoding.UTF8.GetBytes(SomeText);
                //generate the hash based on the array of bytes
                HashBytes = HashGenerator.ComputeHash(TextBytes);
                //generate the hash string replacing blank characters with -
                HashString = BitConverter.ToString(HashBytes).Replace("-", "");
                return HashString;
            }
            else        //if there is nothing to process
            {
                //return a blank string
                return "";
            }
        }

        public string Login(string EMail, string Password)
        {
            //signs in a user based on their email and password
            //ver to store any error messages
            string Error = "";
            //if not all attempts are used up
            if (mAttempts < 3)
            {
                //convert the plain text password to a hash code
                Password = GetHashString(Password + EMail);
                //find the record matching the users email address and password
                clsDataConnection UserAccount = new clsDataConnection();
                //add the parameters
                UserAccount.AddParameter("@AccountEMail", EMail);
                UserAccount.AddParameter("@AccountPassword", Password);
                //execute the query
                UserAccount.Execute("sproc_tblAccount_FilterByEmailAndPassword");
                //If there is only one record found then return true
                if (UserAccount.Count >= 1)
                {
                    //get the state of admin
                    mAdmin = Convert.ToBoolean(UserAccount.DataTable.Rows[0]["IsAdmin"]);
                    //store the users email address in the data member
                    mUserEMail = EMail;
                }
                else //otherwise return false
                {
                    //increment the number of failed attempts
                    mAttempts++;
                    //return a message
                    Error = "Login failed";
                }
            }
            else
            {
                //return a message
                Error = "There have been too many failed attempts please exit the application.";
            }
            //return any error messages
            return Error;
        }

        private Boolean LoginWithTempPW(string EMail, string TempPW)
        {
            //used to log an account in using a temporary password

            //find the record matching the users email address and password
            clsDataConnection UserAccount = new clsDataConnection();
            //add the parameters
            UserAccount.AddParameter("@AccountEMail", EMail);
            UserAccount.AddParameter("@TempPW", TempPW);
            //execute the query
            UserAccount.Execute("sproc_tblAccount_FilterByEmailAndTempPW");
            //If there is only one record found then return true
            if (UserAccount.Count >= 1)
            {
                //set the users email address
                mUserEMail = EMail;
                //return true to indicate login ok
                return true;
            }
            else //otherwise return false
            {
                return false;
            }
        }
        public string UserEMail
        //allows access to email address of the current user
        {
            get
            {
                //return the email address
                return mUserEMail;
            }
        }

        public clsEMail EMailMessage
        //allows access to the last sent email message
        {
            get
            {
                //retunr the message
                return mEMailMessage;
            }
        }

        public bool Authenticated
        //indicates if the current user is authenticated
        {
            get
            {
                //if there is a valid email address
                if (mUserEMail != "")
                {
                    //return true
                    return true;
                }
                else
                {
                    //return false
                    return false;
                }
            }
        }


        private string CheckPassword(string Password)
        //used to check that the password meets requirments
        {
            string Err = "";
            //if the password is less then 7 characters
            if (Password.Length < 7)
            {
                Err = "Your password must be at least 7 characters ";
            }
            //if the password doesn't contain a number
            if (ContainsNumber(Password) == false)
            {
                Err = Err + "your password must contain a number ";
            }
            //return any errors
            return Err;
        }

        private bool IsValidEmail(string EMail)
        {
            //tests to see if an email is in a valid format
            try
            {
                //try to assign the eail to an instance of System.Net.Mail.MailAddress
                System.Net.Mail.MailAddress addr = new System.Net.Mail.MailAddress(EMail);
                //if all ok return true
                return true;
            }
            catch
            {
                //else return false
                return false;
            }
        }

        private Boolean ContainsNumber(string Password)
        {
            //checks to see if a password contains a number
            //var to indicate found
            Boolean Found = false;
            //counter for loop
            int Counter = 0;
            //used to store a single character
            char AChar;
            //while found is false and char less than 9
            while (Found == false & Counter < 9)
            {
                //set temp to the value of Counter plus 48 to point at the numeric ascii codes
                int Temp = Counter + 48;
                //get the char value of the ascii code
                AChar = (char)Temp;
                //if the code is in the password
                if (Password.Contains(AChar) == true)
                {
                    //set found = true
                    Found = true;
                }
                else
                {
                    //otherwise keep looking
                    Counter += 1;
                }
            }
            //return the state of found
            return Found;
        }

        public string ChangePasswordWithTempPW(string EMail, string TempPW, string Password1, string Password2)
        {
            //used to change a password using a temporary system generated password

            //var to store any errors
            string Message = "";
            //if the pw is blank then stop the process
            if (TempPW != "")
            {
                //if the account logs in OK
                if (LoginWithTempPW(EMail, TempPW) == true)
                {
                    //if the two passwords match
                    if (Password1 == Password2)
                    {
                        //check pasword complexity
                        Message = CheckPassword(Password1);
                        //if complexity OK
                        if (Message == "")
                        {
                            //get the hash of the plain text password
                            string HashPassword = GetHashString(Password1 + EMail);
                            //update the users passwod
                            clsDataConnection DB = new clsDataConnection();
                            DB.AddParameter("@AccountEMail", EMail.ToLower());
                            DB.AddParameter("@AccountPassword", HashPassword);
                            DB.Execute("sproc_tblAccount_UpdatePassword");
                            //return a message
                            Message = "The password has been changed";
                        }
                    }
                    //if the passwords do not match
                    else
                    {
                        //generate an error message
                        Message = "The passwords do not match.";
                    }
                }
                else
                {
                    //generate an error message
                    Message = "String not valid.";
                }
            }
            else
            {
                //generate an error message
                Message = "String not valid.";
            }
            //return the error message (if there is one)
            return Message;
        }

        private string GetTempPW()
        {
            //generates a temporary system generated password
            //var to store the password
            string TempPW = "";
            //create a new object for random numbers
            Random rnd = new Random();
            //loop 40 times 
            for (Int32 Count = 0; Count < 40; Count++)
            {
                //generate a random number between 0 and 9
                string ANo = rnd.Next(9).ToString();
                //concatenate the number to the TempPW string
                TempPW = TempPW + ANo;
            }
            //return the string
            return TempPW;
        }
        public string ChangePassword(string EMail, string CurrentPassword, string Password1, string Password2)
        {
            //used to change a users password
            //var to store any errors
            string Message = "";
            //if the account logs in OK 
            if (Login(EMail, CurrentPassword) == "" | mAdmin == true)
            {
                //if the two passwords match
                if (Password1 == Password2)
                {
                    //check pasword complexity
                    Message = CheckPassword(Password1);
                    if (Message == "")
                    {
                        //get the hash of the plain text password
                        string HashPassword = GetHashString(Password1 + EMail);
                        //updat the password
                        clsDataConnection DB = new clsDataConnection();
                        DB.AddParameter("@AccountEMail", EMail.ToLower());
                        DB.AddParameter("@AccountPassword", HashPassword);
                        DB.Execute("sproc_tblAccount_UpdatePassword");
                        Message = "The password has been changed.";
                    }
                }
                //if the passwords do not match
                else
                {
                    //generate an error message
                    Message = "The passwords do not match.";
                }
            }
            else
            {
                //generate an error message
                Message = "The existing password was not correct.";
            }
            //return the error message (if there is one)
            return Message;
        }

        private void SendActivationEMail(string EMail)
        {
            //sends an activation email to the user when email confirmation is required
            //generate a new email message
            mEMailMessage = new clsEMail();
            //set the subject
            mEMailMessage.Subject = "Instructions for activating your account";
            //set the recipient
            mEMailMessage.Recipient = EMail;
            //set the sender
            mEMailMessage.Sender = "noreply@dmubms.com";
            //generate a temporary system password
            string TempPW = GetTempPW();
            //set the body of the email
            mEMailMessage.Body = "<a href=ActivateAccount.aspx?EMail=" + EMail + "&TempPW=" + TempPW + ">Activate Account</a>";
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AccountEMail", EMail.ToLower());
            DB.AddParameter("@TempPW", TempPW);
            //update the temporary password
            DB.Execute("sproc_tblAccount_UpdateTempPW");
            //send the email
            mEMailMessage.SendEMail();
        }

        public string ReSet(string EMail)
        {
            //used to generate a re-set password email message
            //string to store any message
            String Message = "";
            //if the email exists
            if (EMailTaken(EMail) == true)
            {
                //generate a new email message
                mEMailMessage = new clsEMail();
                mEMailMessage.Subject = "Instructions for re-setting your password";
                mEMailMessage.Recipient = EMail;
                mEMailMessage.Sender = "noreply@dmubms.com";
                //get the temp password
                string TempPW = GetTempPW();
                mEMailMessage.Body = "<a href=ChangePassword.aspx?EMail=" + EMail + "&TempPW=" + TempPW + ">Re Set Password</a>";
                //updat the temp password in the database
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@AccountEMail", EMail.ToLower());
                DB.AddParameter("@TempPW", TempPW);
                DB.Execute("sproc_tblAccount_UpdateTempPW");
                //send the email
                mEMailMessage.SendEMail();
                //set the return message
                Message = "An email has been sent to your acccount with instructions on how to re-set your password.";
            }
            else
            {
                //send error
                Message = "Account not found";
            }
            //return any messages
            return Message;
        }

        public Boolean Admin
        {
            //used to flag if the user is admin or not
            get
            {
                //return state of data member
                return mAdmin;
            }
        }

        public string ActivateAccount(string EMail, string TempPW)
        {
            //used to activate a web generated account to verify the email address
            //var to store any errors
            string Message = "";
            //if there is a temp pasword
            if (TempPW != "")
            {
                //if it is possible to login using temp pw
                if (LoginWithTempPW(EMail, TempPW) == true)
                {
                    if (Message == "")
                    {
                        //Activate the account
                        clsDataConnection DB = new clsDataConnection();
                        DB.AddParameter("@AccountEMail", EMail.ToLower());
                        DB.Execute("sproc_tblAccount_Activate");
                        Message = "The account has been activated";
                    }
                }
                else
                {
                    //generate an error
                    Message = "The was a problem activating the account";
                }
            }
            else
            {
                //generate an error
                Message = "Invalid string";
            }
            //return the error message (if there is one)
            return Message;
        }
    }
}