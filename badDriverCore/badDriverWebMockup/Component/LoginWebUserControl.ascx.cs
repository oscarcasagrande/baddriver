using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                badDriverCore.model.User user =
                badDriverCore.domain.User.GetUserByIOrEmailOrUsernameAndPassword(
                    0,
                    UserEmailTextBox.Text,
                    UserEmailTextBox.Text,
                    PasswordTextBox.Text);

                Response.Write(string.Format("id: {0} , email: {1} , nickname {2}, active {3}", user.Id, user.Email, user.Nickname, user.Active));
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}