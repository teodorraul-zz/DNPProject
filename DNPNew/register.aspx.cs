using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace DNPNew
{
    public partial class register : System.Web.UI.Page
    {
        string errorMessage = "";
        string fullname;
        string username;
        string password1;
        string password2;
        string email;

        protected void Button1_Click(object sender, EventArgs e)
        {
            fullname = fullnameRBox.Text;
            username = usernameRBox.Text;
            password1 = passwordRBox.Text;
            password2 = confirmPasswordRBox.Text;
            email = emailRBox.Text;

            int errors = 0;
            Label errorMessage = new Label();

            if (fullname == "")
            {
                errorMessage.Text += "ENTER A FULL NAME<br>";
                errors++;
            }

            if (username == "")
            {
                errorMessage.Text += "ENTER A USERNAME<br>";
                errors++;
            }

            if (email == "")
            {
                errorMessage.Text += "ENTER A email<br>";
                errors++;
            }

            if (password1 != password2)
            {
                errorMessage.Text += "WRONG FUCKING PASSWORD<br>";
                errors++;
            }

            if (errors != 0)
            {
                Controls.Add(errorMessage);
            }
            else
            {
                if (alreadyRegistered(username))
                    errorMessage.Text = "User already registered, please log in to proceed";
                else {
                    SaveUser();
                    errorMessage.Text = "User successfully registered, continue by logging in";
                }
                Controls.Add(errorMessage);

            }
        }

        public void SaveUser()
        {

            var db = new DBEntity();

            user u = new user();
            u.email = username;
            u.fullname = fullname;
            u.password = password1;
            u.username = username;
            db.users.Add(u);
            db.SaveChanges();
        }
        public bool alreadyRegistered(string newUsername) {
            var db = new DBEntity();
            List<user> list = db.users.ToList();
            foreach (user u in list)
                if (u.username == newUsername)
                    return true;

            return false;
        }
    

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("login.aspx", true);
        }
    }
}