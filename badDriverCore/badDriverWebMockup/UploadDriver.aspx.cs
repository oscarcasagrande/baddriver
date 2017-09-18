using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Web.Security;

namespace badDriverWebMockup
{
    public partial class UploadDriver : System.Web.UI.Page
    {
        static AppSettingsReader reader = new AppSettingsReader();
        static string dir = reader.GetValue("photosDir", typeof(string)).ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {

            if (archivesFileUpload.PostedFile.ContentLength < 8388608)
            {
                try
                {
                    if (archivesFileUpload.HasFile)
                    {
                        try
                        {
                            //Aqui ele vai filtrar pelo tipo de arquivo
                            if (archivesFileUpload.PostedFile.ContentType == "image/jpeg" ||
                                archivesFileUpload.PostedFile.ContentType == "image/png" ||
                                archivesFileUpload.PostedFile.ContentType == "image/bmp")
                            {
                                try
                                {
                                    //Obtem o  HttpFileCollection
                                    HttpFileCollection hfc = Request.Files;
                                    for (int i = 0; i < hfc.Count; i++)
                                    {
                                        HttpPostedFile hpf = hfc[i];
                                        if (hpf.ContentLength > 0)
                                        {
                                            //Pega o nome do arquivo
                                            string nome = System.IO.Path.GetFileName(hpf.FileName);
                                            //Pega a extensão do arquivo
                                            string extensao = Path.GetExtension(hpf.FileName);

                                            //Caminho a onde será salvo
                                            hpf.SaveAs(Server.MapPath("~/DriversPhotos/") + i + extensao);

                                        }

                                    }
                                }
                                catch (Exception ex)
                                {

                                }
                                // Mensagem se tudo ocorreu bem
                                lblUploadStatus.Text = "Todas imagens carregadas com sucesso!";

                            }
                            else
                            {
                                // Mensagem notifica que é permitido carregar apenas 
                                // as imagens definida la em cima.
                                lblUploadStatus.Text = "É permitido carregar apenas imagens!";
                            }
                        }
                        catch (Exception ex)
                        {
                            // Mensagem notifica quando ocorre erros
                            lblUploadStatus.Text = "O arquivo não pôde ser carregado. O seguinte erro ocorreu: " + ex.Message;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mensagem notifica quando ocorre erros
                    lblUploadStatus.Text = "O arquivo não pôde ser carregado. O seguinte erro ocorreu: " + ex.Message;
                }
            }
            else
            {
                // Mensagem notifica quando imagem é superior a 8 MB
                lblUploadStatus.Text = "Não é permitido carregar mais do que 8 MB";
            }

        }
    }
}