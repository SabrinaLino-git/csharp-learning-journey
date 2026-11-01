using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
         // Set up the game
            Random random = new Random();
            int roundsPlayed = 8;
            List<int> allScores = new List<int>();
            Console.WriteLine($"Playing {roundsPlayed} rounds...\n");
            
            
         // Simulate playing rounds and log every score
            for (int round = 1; round <= roundsPlayed; round++){
                int score = random.Next(0, 101);
                allScores.Add(score);
                Console.WriteLine($"Round {round}: scored {score} points");
            }
            
            Console.WriteLine($"\nTotal round logges: {allScores.Count}");
         // Build the Top 5 leaderboard array
        
            allScores.Sort(); // ascending order
            allScores.Reverse(); // reverse order
            
            int[] topScores = new int[5];
            
            for(int i = 0; i <topScores.Length; i++){
                topScores[i] = allScores[i];
            }
            
         // Print the leaderboard
         
            Console.WriteLine("\nTop 5\n");
            for(int i = 0; i<topScores.Length; i++){
                Console.WriteLine($"{i+ 1}: {topScores[i]} points");
            }
}
}
