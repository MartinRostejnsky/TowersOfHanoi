using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    class Game
    {
        protected Stack<int>[] Towers = {
        new Stack<int>(),
        new Stack<int>(),
        new Stack<int>()
        };

        public int TowerA { get { return Towers[0].Count(); } }
        public int TowerB { get { return Towers[1].Count(); } }
        public int TowerC { get { return Towers[2].Count(); } }

        public Game (int discs)
        {
            for (int i = discs; i > 0; i--)
            {
                Towers[0].Push(i);
            }
        }

        public void Move (int a, int b) {
            int aval;
            int bval;
            if (a == b | a > 2 | b > 2 | (!Towers[a].TryPeek(out aval) & !Towers[b].TryPeek(out bval)))
            {
                throw new Exception("Impossible move!");
            }
            if (!Towers[a].TryPeek(out aval))
            {
                this.Towers[a].Push(this.Towers[b].Pop());
            }
            else if (!Towers[b].TryPeek(out bval))
            {
                this.Towers[b].Push(this.Towers[a].Pop());
            }
            else if (aval > bval)
            {
                this.Towers[a].Push(this.Towers[b].Pop());
            }
            else
            {
                this.Towers[b].Push(this.Towers[a].Pop());
            }
        }

        public override string ToString()
        {
            string state = "";
            int biggest = 0;
            foreach (Stack<int> stack in Towers) if (stack.Count > biggest) biggest = stack.Count;
            for (int i = biggest-1; i >= 0; i--) {
                for (int j = 0; j < Towers.Length; j++) {
                    if (j == 0) state += "|";
                    if (i >= Towers[j].Count) state += " ";
                    else state += Towers[j].ElementAt(Towers[j].Count-1-i);
                    state += "|";
                }
                state += "\n";
            }
            return state;
        }
    }
}
