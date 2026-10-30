using System;

namespace AchievementTrackerSystem
{
    class Program
    {
        static void Main()
        {
            Gamer gamer1 = new Gamer(
                "Six_Paths",
                12);

            Achievement achievement1 =
                new Achievement(
                    "Monster Hunter",
                    "Defeat 100 enemies,",
                    50);

            Achievement achievement2 =
                new Achievement(
                    "Treasure Seeker",
                    "Open 50 chests",
                    25);

            achievement1.UnlockAchievement();

            List<Achievement> achievements = new List<Achievement>
                    {
                        achievement1,
                        achievement2
                    };

            AchievementTracker achievementTracker =
                new AchievementTracker(
                    gamer1,
                    achievements);

            achievementTracker.DisplayAllAchievements();
            achievementTracker.CalculateTotalPoints();
        }
    }
}