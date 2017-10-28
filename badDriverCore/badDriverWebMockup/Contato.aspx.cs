using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace badDriverWebMockup
{
    public partial class Contato : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            bool emailSent = false;

            EmailTextBox.Attributes.Add("value", "E-mail");
            EmailTextBox.Attributes.Add("onfocus", "this.value = '';");
            EmailTextBox.Attributes.Add("onblur", "if (this.value == '') {this.value = 'E-mail';}");

            NomeTextBox.Attributes.Add("value", "Nome");
            NomeTextBox.Attributes.Add("onfocus", "this.value = '';");
            NomeTextBox.Attributes.Add("onblur", "if (this.value == '') {this.value = 'Nome';}");


            TelefoneTextBox.Attributes.Add("value", "Telefone");
            TelefoneTextBox.Attributes.Add("onfocus", "this.value = '';");
            TelefoneTextBox.Attributes.Add("onblur", "if (this.value == '') {this.value = 'Telefone';}");


            AssuntoTextBox.Attributes.Add("value", "Assunto");
            AssuntoTextBox.Attributes.Add("onfocus", "this.value = '';");
            AssuntoTextBox.Attributes.Add("onblur", "if (this.value == '') {this.value = 'Assunto';}");


            MensagemTextBox.Attributes.Add("value", "Mensagem");
            MensagemTextBox.Attributes.Add("onfocus", "this.value = '';");
            MensagemTextBox.Attributes.Add("onblur", "if (this.value == '') {this.value = 'Mensagem';}");

            if (Page.IsPostBack == true)
            {
                try
                {
                    emailSent = badDriverUtils.Email.sendEmail();
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }
    }
}