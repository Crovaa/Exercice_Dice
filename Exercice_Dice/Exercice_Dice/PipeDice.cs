using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Dice
{
    public class PipeDice: Dice
    {
        Random random = new Random();
        public PipeDice() : base("Pipe Dice")
        {

        }

        public override int RollPipeDice()
        {
            int number = GenerateRandomNumber();
            return number;
        }

        public override int RollNormalDice()
        {
            throw new NotImplementedException();
        }

        private int GenerateRandomNumber()
        {
            int number = PipeFaces[random.Next(PipeFaces.Count)];
            return number;
        }
    }
}
