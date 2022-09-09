using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Dice
{
    public class NormalDice: Dice
    {
        Random random = new Random();
        public NormalDice() : base("Normal Dice")
        {
        
        }

        public override int RollNormalDice()
        {
            int number = GenerateRandomNumber();
            return number;
        }

        public override int RollPipeDice()
        {
            throw new NotImplementedException();
        }

        private int GenerateRandomNumber()
        {
            int number = NormalFaces[random.Next(NormalFaces.Count)];
            return number;
        } 
    }
}
