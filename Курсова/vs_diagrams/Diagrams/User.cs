using System;
using System.Collections.Generic;

namespace SmartHomePlatform
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<Home> Homes { get; set; } = new();
        public List<Notification> Notifications { get; set; } = new();
    }
}