namespace EmailWorker.Models
{
    public class EmailSettings
    {
        public string SmtpHost { get; set; } = default!;
        public int SmtpPort { get; set; }
        public string Usuario { get; set; } = default!;
        public string Senha { get; set; } = default!;
        public string Remetente { get; set; } = default!;
    }
}
