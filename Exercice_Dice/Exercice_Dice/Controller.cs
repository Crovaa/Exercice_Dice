using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Dice
{
    public class Controller
    {
        private List<Dice> dices;
        private Dice dice;
        Random random = new Random();

        public Controller()
        {
            dices = new List<Dice>();
            dices.Add(new NormalDice());
            dices.Add(new PipeDice());
        }

        public Dice RollDice()
        {
            return dices[random.Next(dices.Count)];
        }
    }
}
