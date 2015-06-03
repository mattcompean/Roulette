using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Roulette
{
    public class Tournament
    {
        List<Seed> seeds = new List<Seed>();
        List<Seed> byeList = new List<Seed>();

        public Tournament(int numSeeds)
        {
            for (int i = 0; i < numSeeds; i++)
            {
                Seed s = new Seed(i + 1);
                seeds.Add(s);
            }

            ShuffleSeeds();
        }

        public Tournament(int numSeeds, List<string> names)
        {
            int seedCount = numSeeds;

            if (names.Count > numSeeds)
            {
                seedCount = names.Count;
            }

            for (int i = 0; i < seedCount; i++)
            {
                Seed s = new Seed(i + 1, names[i]);
                seeds.Add(s);
            }

            ShuffleSeeds(); 
        }

        private void ShuffleSeeds()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();

            int s = seeds.Count;

            Console.WriteLine("Shuffling seeds");

            while (s > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < s * (Byte.MaxValue / s)));
                int i = (box[0] % s);
                s--;

                Seed value = seeds[i];
                seeds[i] = seeds[s];
                seeds[s] = value;
            }

            Console.WriteLine("Seeds shuffled");
        }

        public void Generate(RichTextBox output)
        {
            bool evenPlayers = true;

            if (seeds.Count % 2 != 0) evenPlayers = false;

            int maxRounds;
            int round = 0;

            if (evenPlayers)
            {
                maxRounds = seeds.Count - 1;

                List<Seed> row1 = new List<Seed>(seeds.Take(seeds.Count / 2));
                List<Seed> row2 = new List<Seed>(seeds.Skip(seeds.Count / 2));
        
                while (round != maxRounds)
                {
                    output.AppendText("Round " + (round + 1)+ ":\n");
                    Match.PlayRound(output, row1, row2);
                    round++;
                    output.AppendText("\n");
                }
            }
            else
            {
                maxRounds = seeds.Count;

                List<Seed> row1 = new List<Seed>(seeds.Take((seeds.Count / 2) + 1)); //get the odd seed
                List<Seed> row2 = new List<Seed>(seeds.Skip((seeds.Count / 2) + 1));
                row2.Add(new Seed(-1, "bye"));

                while (round != maxRounds)
                {
                    output.AppendText("Round " + (round + 1) + ":\n");
                    Match.PlayRoundWithBye(output, row1, row2);
                    round++;
                }
            }
        }
    }
}
