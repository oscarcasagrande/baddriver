using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace badDriverWebMockup
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Page.User.Identity.IsAuthenticated)
            {

            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            badDriverCore.model.User user = new badDriverCore.model.User()
            {
                Active = false,
                Email = UserEmailTextBox.Text,
                Id = 0,
                Nickname = NicknameTextBox.Text,
                Password = PasswordTextBox.Text
            };

            try
            {
                user = badDriverCore.domain.User.CreateUser(user);
                user = badDriverCore.domain.User.GetUserByIOrEmailOrUsernameAndPassword(0, user.Email, user.Nickname, user.Password);
                if (user.Id == 0)
                {
                    throw new Exception("User not created.");
                }
                else
                {
                    Response.Redirect(string.Format("~/ConfirmacaoCadastro.aspx?ID={0}", user.Id.ToString()), true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}