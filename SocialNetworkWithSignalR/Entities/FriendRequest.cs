﻿namespace SocialNetworkWithSignalR.Entities
{
    public class FriendRequest
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public string Status { get; set; }= null!;
        public string SenderId { get; set; } = null!;
        public string ReceiverId { get; set; } = null!;
        public virtual CustomIdentityUser? Receiver { get; set; }
    }
}
