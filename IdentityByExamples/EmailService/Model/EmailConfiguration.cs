namespace EmailService
{
    public class EmailConfiguration
    {
        public string From { get; set; } 
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public bool HasProxy { get; set; }
        public string ProxyHost { get; set; }
        public int ProxyPort { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
