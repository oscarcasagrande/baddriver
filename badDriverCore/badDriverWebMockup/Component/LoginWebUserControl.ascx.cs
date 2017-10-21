using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using model = badDriverModel;
using service = badDriverService;

namespace badDriverWebMockup.Component
{
    public partial class LoginWebUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                model.User user =
                    service.User.GetUserByIOrEmailOrUsernameAndPassword(
                        0,
                        UserEmailTextBox.Text,
                        UserEmailTextBox.Text,
                        PasswordTextBox.Text);

                if (user.Id > 0)
                {
                    Session["UserId"] = user.Id;
                    Session["UserEmail"] = user.Email;
                    FormsAuthentication.RedirectFromLoginPage(user.Nickname, RememberMeSetCheckBox.Checked);
                }

                Response.Write(string.Format("id: {0} , email: {1} , nickname {2}, active {3}", user.Id, user.Email, user.Nickname, user.Active));
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}