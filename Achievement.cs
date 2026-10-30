namespace AchievementTrackerSystem
{
    public class Achievement
    {
        public string Title { get; }
        public string Description { get; }
        public int Points { get; }
        public bool IsUnlocked = false;


        public Achievement(string title, string description, int points)
        {
            Title = title;
            Description = description;
            Points = points;
        }

        public void UnlockAchievement()
        {
            IsUnlocked = true;
        }
    }
}