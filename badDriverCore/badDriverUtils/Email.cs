using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Configuration;


namespace badDriverUtils
{
    public static class Email
    {
        static NetworkCredential _credential;

        static string _to;

        static NetworkCredential getEmailCredentials()
        {
            AppSettingsReader reader = new AppSettingsReader();
            _credential = new NetworkCredential();

            try
            {
                _credential.UserName = reader.GetValue("smtpUsername", typeof(string)).ToString();
                _credential.Password = reader.GetValue("smtpPassword", typeof(string)).ToString();
                _to = reader.GetValue("to", typeof(string)).ToString();
            }
            catch (Exception ex)
            {
                Exception x = new Exception();
                string messageError = string.Empty;

                if (_credential.UserName == null)
                {
                    messageError += "## credential.UserName is null. ";
                }
                if (_credential.Password == null)
                {
                    messageError += "## credential.Password is null. ";
                }
                x = new Exception(messageError, ex.InnerException);

                throw ex;
            }

            return _credential;
        }

        static SmtpClient getSmtpClient()
        {
            SmtpClient result = new SmtpClient();

            AppSettingsReader reader = new AppSettingsReader();

            result.DeliveryMethod = SmtpDeliveryMethod.Network;
            result.Timeout = 100000;
            result.UseDefaultCredentials = false;

            try
            {
                result.Credentials = getEmailCredentials();
                result.EnableSsl = (bool)(reader.GetValue("smtpEnableSsl", typeof(bool)));
                result.Host = (reader.GetValue("smtpServer", typeof(string))).ToString();
                result.Port = (int)(reader.GetValue("smtpPort", typeof(int)));

            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public static bool sendEmail(string subject, string message, bool isHtmlBody, List<KeyValuePair<string, string>> toFrom)
        {
            bool result = false;
            MailMessage mail = null;

            try
            {
                using (mail = new MailMessage())
                {

                    mail.To.Add(_to);
                    mail.IsBodyHtml = isHtmlBody;
                    mail.Subject = subject;

                    foreach (var tf in toFrom)
                    {
                        message = message.Replace(tf.Key, tf.Value);
                    }

                    mail.Body = message;
                    mail.Priority = MailPriority.Normal;

                    SmtpClient smtpClient = getSmtpClient();

                    if (_credential.UserName.Contains("@") == true)
                    {
                        mail.From = new MailAddress(_credential.UserName);
                        smtpClient.Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mail.Dispose();
            }

            return result;
        }
    }
}
