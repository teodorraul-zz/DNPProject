using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DNPNew
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Text = "";
            string name = TextBox1.Text;
            string password = TextBox2.Text;

            if (name == "") {
                Label3.Text = "Username cannot be empty";
                return;
            }
            if (password == "") {
                Label3.Text = "Password cannot be empty";
                return;
            }

            var db = new DBEntity();
            List<user> list = db.users.ToList();


            foreach (user u in list)
                if (u.username == name) {
                    if (u.password == password)
                    {
                        Label3.Text = "Login succrssfull";
                        return;
                    }
                    else {
                        Label3.Text = "Wrong password";
                        return;
                    }
                }

            Label3.Text = "Username not found in the database. Check your username or click on Register if you are a new user";
        }
        void testDB() {

            var db = new DBEntity();
            List<user> list = db.users.ToList();

            foreach (user u in list)
                Label1.Text += u.username;

                }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("register.aspx", true);
        }
    }
}