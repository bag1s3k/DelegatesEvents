using DelegatesEvents;
using System;

Player player = new Player();
Party party = new Party();

player.AchievementUnlocked += OnAchievementUnlocked;
player.AchievementUnlocked += party.Cheering;

await player.AddPoints(30);
await player.AddPoints(40);
await player.AddPoints(35);

player.AchievementUnlocked -= OnAchievementUnlocked;
player.AchievementUnlocked -= party.Cheering;

static void OnAchievementUnlocked(int points) => Console.WriteLine($"Congratulations! Achievement unlocked for {points}...");
