using Microsoft.EntityFrameworkCore;

namespace dakg
{
    public class GameEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
    }
}

