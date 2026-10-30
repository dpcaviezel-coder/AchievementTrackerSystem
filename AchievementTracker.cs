namespace AchievementTrackerSystem
{
    public class AchievementTracker
    {
        public Gamer Gamer { get; set; }
        public List<Achievement> Achievements { get; set; }

        public AchievementTracker(Gamer gamer, List<Achievement> achievements)
        {
            Gamer = gamer;
            Achievements = achievements;
        }

        public void AddAchievement(Achievement achievement)
        {
            Achievements.Add(achievement);
        }

        public void RemoveAchievement(Achievement achievement)
        {
            Achievements.Remove(achievement);
        }

        public void DisplayAllAchievements()
{
    Console.WriteLine("===== Achievements =====\n");

    foreach (Achievement achievement in Achievements)
    {
        string status = achievement.IsUnlocked ? "Unlocked" : "Locked";

        Console.WriteLine(achievement.Title);
        Console.WriteLine($"Status: {status}");
        Console.WriteLine($"Points: {achievement.Points}\n");
    }

    Console.WriteLine();
}

        public void DisplayUnlockedAchievements()
        {
            Console.WriteLine("===== Unlocked Achievements =====");
            foreach (Achievement achievement in Achievements)
            {
                if (achievement.UnlockAchievement != null)
                {
                    Console.WriteLine($"{achievement.IsUnlocked: Unlocked ? Locked}\n");
                }
            }
            Console.WriteLine();
        }

        public void DisplayLockedAchievements()
        {
            Console.WriteLine("===== Locked Achievements =====");
            foreach (Achievement achievement in Achievements)
            {
                if (achievement.UnlockAchievement == null)
                {
                    Console.WriteLine($"{achievement.IsUnlocked: Unlocked ? Locked}\n");
                }
            }
            Console.WriteLine();
        }


        public void CalculateTotalPoints()
        {
            int totalPoints = 0;
            foreach(Achievement achievement in Achievements)
            {
                totalPoints += achievement.Points;
            }
            Console.WriteLine($"Total Achievement Points: {totalPoints}");
        }
    }
}