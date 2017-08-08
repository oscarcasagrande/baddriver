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

            credential.UserName = string.Empty;
            credential.Password = string.Empty;

            return credential;
        }

        public static bool sendEmail(string template, string to, string from, string subject, string message, bool isHtmlBody, List<KeyValuePair<string, string>> toFrom)
        {
            bool result = false;
            MailMessage mail = null;
            try
            {

                using (mail = new MailMessage())
                {
                    mail.From = new MailAddress(from);
                    mail.To.Add(to);
                    mail.IsBodyHtml = isHtmlBody;
                    mail.Subject = subject;

                    foreach (var tf in toFrom)
                    {
                        message.Replace(tf.Key, tf.Value);
                    }

                    mail.Body = message;
                    mail.Priority = MailPriority.Normal;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                mail.Dispose();
            }

            return result;
        }
    }
}
