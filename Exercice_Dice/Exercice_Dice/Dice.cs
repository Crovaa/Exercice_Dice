using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Dice
{
    public abstract class Dice
    {
        protected readonly string name;
        protected List<int> resultNormalDice;
        protected List<int> resultPipeDice;

        public string Name { get => name; }
        public List<int> NormalFaces { get => resultNormalDice; }
        public List<int> PipeFaces { get => resultPipeDice; }

        public Dice(string name)
        {
            this.name = name;
            resultNormalDice = new List<int> { 1, 2, 3, 4, 5, 6 };
            resultPipeDice = new List<int> { 1, 2, 3, 4, 4, 5, 5, 6, 6 };
        }

        public abstract int RollNormalDice();
        public abstract int RollPipeDice();

    }
}
