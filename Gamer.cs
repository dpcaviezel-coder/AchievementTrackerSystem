namespace AchievementTrackerSystem
{
    public class Gamer
    {
        public string Username { get; }
        public int Level { get; }

        public Gamer(string username, int level)
        {
            Username = username;
            Level = level;
        }
    }
}