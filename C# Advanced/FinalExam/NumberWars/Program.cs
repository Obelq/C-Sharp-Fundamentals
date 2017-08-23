using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Queue<KeyValuePair<char, int>>();
            var player2 = new Queue<KeyValuePair<char, int>>();

            var input1 = Console.ReadLine().Split(' ');
            foreach (var pair in input1)
            {
                var number = int.Parse(pair.Substring(0, pair.Length - 1));
                char letter = pair[pair.Length - 1];
                player1.Enqueue(new KeyValuePair<char, int>(letter, number));
            }

            var input2 = Console.ReadLine().Split(' ');
            foreach (var pair in input2)
            {
                var number = int.Parse(pair.Substring(0, pair.Length - 1));
                char letter = pair[pair.Length - 1];
                player2.Enqueue(new KeyValuePair<char, int>(letter, number));
            }
            var cylclesCounter = 0;
            while (player1.Count != 0 && player2.Count != 0)
            {
                cylclesCounter++;

                if (cylclesCounter > 1000000)
                {
                    break;
                }
                var firstPlayerCard = player1.Dequeue();
                var secondPlayerCard = player2.Dequeue();
                if (firstPlayerCard.Value == secondPlayerCard.Value)
                {
                    //Voina
                    var wonCards = new List<KeyValuePair<char, int>>();
                    wonCards.Add(firstPlayerCard);
                    wonCards.Add(secondPlayerCard);

                    while (true)
                    {
                        var firstPlayer3Cards = new List<KeyValuePair<char, int>>();
                        var secondPlayer3Cards = new List<KeyValuePair<char, int>>();

                        for (int i = 0; i < 3; i++)
                        {
                            if (player1.Count == 0)
                            {
                                if (player2.Count == 0)
                                {
                                    Console.WriteLine($"Draw after {cylclesCounter} turns");
                                    return;
                                }
                                Console.WriteLine($"Second player wins after {cylclesCounter} turns");
                                return;
                            }
                            if (player2.Count == 0)
                            {
                                Console.WriteLine($"First player wins after {cylclesCounter} turns");
                                return;
                            }
                            firstPlayer3Cards.Add(player1.Dequeue());
                            secondPlayer3Cards.Add(player2.Dequeue());
                        }
                        foreach (var card in firstPlayer3Cards)
                        {
                            wonCards.Add(card);
                        }
                        foreach (var card in secondPlayer3Cards)
                        {
                            wonCards.Add(card);
                        }
                        int lettersScore1 = firstPlayer3Cards.Select(x => (int)x.Key).Sum();
                        int lettersScore2 = secondPlayer3Cards.Select(x => (int)x.Key).Sum();
                        if (lettersScore1 > lettersScore2)
                        {
                            foreach (var card in wonCards.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key))
                            {
                                player1.Enqueue(card);
                            }
                            break;
                        }
                        if (lettersScore1 < lettersScore2)
                        {
                            foreach (var card in wonCards.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key))
                            {
                                player2.Enqueue(card);
                            }
                            break;
                        }
                    }
                }
                else if (firstPlayerCard.Value > secondPlayerCard.Value)
                {
                    player1.Enqueue(firstPlayerCard);
                    player1.Enqueue(secondPlayerCard);
                }
                else
                {
                    player2.Enqueue(secondPlayerCard);
                    player2.Enqueue(firstPlayerCard);
                }
            }

            if (player1.Count == 0)
            {
                if (player2.Count == 0)
                {
                    Console.WriteLine($"Draw after {cylclesCounter} turns");
                    return;
                }
                Console.WriteLine($"Second player wins after {cylclesCounter} turns");
            }
            else if (player2.Count == 0)
            {
                Console.WriteLine($"First player wins after {cylclesCounter} turns");
            }
        }
    }
}
