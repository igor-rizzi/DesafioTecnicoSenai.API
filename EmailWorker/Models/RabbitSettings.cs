﻿namespace EmailWorker.Models
{
    public class RabbitSettings
    {
        public string Host { get; set; } = default!;
        public int Port { get; set; }
        public string User { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string QueueName { get; set; } = default!;
    }
}
