using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_Dice
{
    public partial class Form1 : Form
    {
        private readonly Controller controller;
        private int totalPoints;
        private string dice;
        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Btn_RollDice_Click(object sender, EventArgs e)
        {
            dice = controller.RollDice().Name.ToString();
            lbl_DiceType.Text = dice;
            lbl_DiceType.Visible = true;
            lbl_Points.Visible = true;
            GenerateNumberFromDice();
            pct_DiceImage.Visible = true;
            lbl_Points.Text = totalPoints.ToString();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_DiceType.Visible = false;
            pct_DiceImage.Visible = false;
            lbl_Points.Visible = false;
        }

        private void GenerateNumberFromDice()
        {
            if (dice == "Normal Dice")
            {
                NormalDice normalDice = new NormalDice();
                int number = normalDice.RollNormalDice();
                switch (number)
                {
                    case 1:
                        pct_DiceImage.Image = Image.FromFile("../../../Images/Dice1.png");
                        pct_DiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 2:
                        pct_DiceImage.Image = Image.FromFile("../../../Images/Dice2.png");
                        pct_DiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 3:
                        pct_DiceImage.Image = Image.FromFile("../../../Images/Dice3.png");
                        pct_DiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 4:
                        pct_DiceImage.Image = Image.FromFile("../../../Images/Dice4.png");
                        pct_DiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 5:
                        pct_DiceImage.Image = Image.FromFile("../../../Images/Dice5.png");
                        pct_DiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 6:
                        pct_DiceImage.Image = Image.FromFile("../../../Images/Dice6.png");
                        pct_DiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                }
                lbl_Points.Text = number.ToString();
                totalPoints = totalPoints + number;
            }
            else
            {
                PipeDice pipeDice = new PipeDice();
                int number = pipeDice.RollPipeDice();
                switch (number)
                {
                    case 1:
                        pct_DiceImage.Image = Image.FromFile("../../../Images/Dice1.png");
                        pct_DiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 2:
                        pct_DiceImage.Image = Image.FromFile("../../../Images/Dice2.png");
                        pct_DiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 3:
                        pct_DiceImage.Image = Image.FromFile("../../../Images/Dice3.png");
                        pct_DiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 4:
                        pct_DiceImage.Image = Image.FromFile("../../../Images/Dice4.png");
                        pct_DiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 5:
                        pct_DiceImage.Image = Image.FromFile("../../../Images/Dice5.png");
                        pct_DiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 6:
                        pct_DiceImage.Image = Image.FromFile("../../../Images/Dice6.png");
                        pct_DiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                }
                lbl_Points.Text = number.ToString();
                totalPoints = totalPoints + number;
            }
        }
    }
}
