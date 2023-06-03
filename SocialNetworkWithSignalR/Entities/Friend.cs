namespace SocialNetworkWithSignalR.Entities
{
    public class Friend
    {
        public int Id { get; set; }
        public string OwnId { get; set; } = null!;
        public string YourFriendId { get; set; } = null!;
        public virtual CustomIdentityUser? YourFriend { get; set; } 

    }
}
