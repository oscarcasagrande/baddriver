using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace badDriverCore.utils
{
    public static class Email
    {
        static NetworkCredential getEmailCredentials()
        {
            NetworkCredential credential = new NetworkCredential();

            AppSettingsReader reader = new AppSettingsReader();

            try
            {
                credential.UserName = reader.GetValue("username", typeof(string)).ToString();
                credential.Password = reader.GetValue("password", typeof(string)).ToString();
            }
            catch (Exception ex)
            {
                Exception x = new Exception();
                string messageError = string.Empty;

                if (credential.UserName == null)
                {
                    messageError += "## credential.UserName is null. ";
                }
                if (credential.Password == null)
                {
                    messageError += "## credential.Password is null. ";
                }
                x = new Exception(messageError, ex.InnerException);

                throw ex;
            }

            return credential;
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
                result.EnableSsl = (bool)(reader.GetValue("enableSsl", typeof(bool)));
                result.Host = (reader.GetValue("smtpServer", typeof(string))).ToString();
                result.Port = (int)(reader.GetValue("smtpPort", typeof(int)));

            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public static bool sendEmail(string to, string subject, string message, bool isHtmlBody, List<KeyValuePair<string, string>> toFrom)
        {
            bool result = false;
            MailMessage mail = null;
            try
            {

                using (mail = new MailMessage())
                {

                    mail.To.Add(to);
                    mail.IsBodyHtml = isHtmlBody;
                    mail.Subject = subject;

                    foreach (var tf in toFrom)
                    {
                        message.Replace(tf.Key, tf.Value);
                    }

                    mail.Body = message;
                    mail.Priority = MailPriority.Normal;

                    SmtpClient smtpClient = getSmtpClient();
                    mail.From = new MailAddress(getEmailCredentials().UserName);
                    smtpClient.Send(mail);
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
