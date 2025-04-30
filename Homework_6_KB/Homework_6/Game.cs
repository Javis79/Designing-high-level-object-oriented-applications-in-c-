using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    class Game
    {
        public static void Run()
        {
            int rounds = 30; // how many rounds
            int score1 = 10; // both players cooperate
            int score2 = 15; // one player betrays - winner
            int score3 = -10; // one player betrays - loser
            int score4 = 0; // both players betray
			int game_nr = 0;
			// note: it can be shown mathematically that this game is non-trivial if: 
			// 1) score2 > score1 > score4 > score3, AND
			// 2) 2*score1 > score2 + score3

			List <Player> players = new List<Player>();
            Player p0 = new Player(new StrategyCounter(), "Counter");
            Player p1 = new Player(new StrategyForgiving(), "Forgiving");
            Player p2 = new Player(new StrategyGrudger(), "Grudger");
            Player p3 = new Player(new StrategyRandom(), "Random");
            Player p4 = new Player(new StrategyRepeater(), "Repeater");
            players.Add(p0);
            players.Add(p1);
            players.Add(p2);
            players.Add(p3);
            players.Add(p4);
            for (int j = players.Count-1; j >= 0; j--)
            {
                for (int k = j-1; k >= 0; k--)
                {
                    game_nr++;
                    for (int i = 0; i < rounds; i++)
                    {
						players[j].PartnerMoves.Clear();
						players[k].PartnerMoves.Clear();
						bool move1 = players[j].GetNextMove();
                        bool move2 = players[k].GetNextMove();

                        if (move1 && move2) // both players cooperated
                        {
                            // update score
                            players[j].Score += score1;
                            players[k].Score += score1;
                            // update players' knowledge about their partner
                            players[j].PartnerMoves.Add(true);
                            players[k].PartnerMoves.Add(true);
                        }
                        else if (move1) // player2 betrayed player1
                        {
                            players[j].Score += score3;
                            players[k].Score += score2;
                            players[j].PartnerMoves.Add(false);
                            players[k].PartnerMoves.Add(true);
                        }
                        else if (move2) // player1 betrayed player2
                        {
                            players[j].Score += score2;
                            players[k].Score += score3;
                            players[j].PartnerMoves.Add(true);
                            players[k].PartnerMoves.Add(false);
                        }
                        else // both players betrayed
                        {
                            players[j].Score += score4;
                            players[k].Score += score4;
                            players[j].PartnerMoves.Add(false);
                            players[k].PartnerMoves.Add(false);
                        }
                        //Console.WriteLine(move1);
                        //Console.WriteLine(move2);
                    }

					Console.WriteLine($"\n---Game {game_nr}---\n");
					Console.WriteLine($"Player{j} score: " + players[j].Score);
                    Console.WriteLine($"Player{k} score: " + players[k].Score);
                }
            }
            Console.WriteLine("\nResults table:");
            for (int i = 0; i < players.Count; i++) 
            {
                Console.WriteLine($"---{players[i].StrategyName}---");
                Console.WriteLine($"Player{i} score: " + players[i].Score);
            }
        }
    }
}
