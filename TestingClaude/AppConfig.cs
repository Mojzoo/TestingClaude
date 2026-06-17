namespace TestingClaude
{
    /// <summary>
    /// Fill in your Gmail credentials here before running the app.
    /// Use a Gmail App Password (NOT your real password):
    /// Google Account → Security → 2-Step Verification → App passwords
    /// </summary>
    public static class AppConfig
    {
        // The Gmail address that will SEND the reset emails
        public const string SenderEmail    = "YOUR_GMAIL@gmail.com";

        // App Password generated from Google Account settings
        public const string SenderPassword = "YOUR_APP_PASSWORD";

        // Display name shown in the email
        public const string SenderName     = "TestingClaude App";
    }
}
