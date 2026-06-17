using System;
using System.Net;
using System.Net.Mail;

namespace TestingClaude
{
    public static class EmailHelper
    {
        /// <summary>
        /// Sends a password-reset OTP email to the given Gmail address.
        /// </summary>
        public static void SendResetEmail(string toEmail, string otpCode)
        {
            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(AppConfig.SenderEmail, AppConfig.SenderPassword),
                EnableSsl   = true
            };

            string subject = "TestingClaude — Password Reset Code";
            string body    =
                $"Hello,\n\n" +
                $"Your password reset code is:\n\n" +
                $"    {otpCode}\n\n" +
                $"This code expires in 10 minutes. If you did not request a reset, ignore this email.\n\n" +
                $"— TestingClaude App";

            var message = new MailMessage
            {
                From       = new MailAddress(AppConfig.SenderEmail, AppConfig.SenderName),
                Subject    = subject,
                Body       = body,
                IsBodyHtml = false
            };
            message.To.Add(toEmail);

            smtp.Send(message);
        }
    }
}
