﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using model = badDriverModel;
using service = badDriverService;

namespace badDriverWebMockup
{
    public partial class ConfirmacaoCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            model.User user =
                service.User.GetUserById(Convert.ToInt32(Request["ID"].ToString()));

            LabelMensagem.Text = 
                string.Format("Usuário <strong>{0}</strong> registrado, confirme seu registro pelo link que será enviado no seu e-mail {1}.", user.Nickname, user.Email);

        }
    }
}