using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roulette
{
    public class Seed
    {
        List<Seed> played = new List<Seed>();
        int id = 0;
        string name = string.Empty;

        public List<Seed> Played
        {
            get { return played; }
            set { played = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Seed(int id)
        {
            this.id = id;
        }

        public Seed(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        
    }
}
