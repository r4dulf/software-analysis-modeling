using System;
using System.Collections.Generic;

namespace SmartHomePlatform
{
    public class Notification
    {
        public Guid Id { get; set; }
        public NotificationType Type { get; set; }
        public string Message { get; set; } = string.Empty;
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}