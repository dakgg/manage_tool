namespace dakg
{
    public class GameEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string ProfileImage { get; set; }
    }
}

