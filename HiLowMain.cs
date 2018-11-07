using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Developed & Designed by Nath Thornton
//This code is copyright, Re-use is restricted

namespace HiLow
{
    public partial class HiLoMain : Form
    {
        int Cash;
        int BaseCash = 50;
        int CurrentNumber;
        int NewNumber;
        int Pot;
        int betPot;
        Random rnd = new Random();

        private void formOne_Load(object sender, EventArgs e)
        {
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);
        }

        public HiLoMain()
        {
            InitializeComponent();
            Cash = BaseCash;
            lblCashcoin.Text = Cash.ToString();
            lblNumber.Text = CurrentNumber.ToString();
            CurrentNumber = NewNumber;
        }

        private void KeyEvent(object sender, KeyEventArgs e) //Keyup Events
        {
            if (e.KeyCode == Keys.C) //Adds $100 to the users account {{CHEATMODE}}
            {
                Cash = Cash + 100;
                lblCashcoin.Text = Cash.ToString();
                Console.WriteLine("Added $100 VIA CHEATCOMMAND");
            }
        }

        private void buttonBet5_Click(object sender, EventArgs e)
        {
            Cash = Cash - 5;
            if (Cash < 0)
            {
                Console.WriteLine("You Don't Have enough Funds!");
                MessageBox.Show("You do not have the required funds!");
                Cash = Cash + 5;
            }
            else
            {
                betPot = betPot + 5;
                Console.WriteLine("$5 added to the pot");
                betPottext.Text = betPot.ToString();
                lblCashcoin.Text = Cash.ToString();
            }
        }

        private void buttonBet10_Click(object sender, EventArgs e)
        {
            Cash = Cash - 10;
            if (Cash < 0)
            {
                Console.WriteLine("You Don't Have enough Funds!");
                MessageBox.Show("You do not have the required funds!");
                Cash = Cash + 10;

            }
            else
            {
                betPot = betPot + 10;
                Console.WriteLine("$10 added to the pot");
                betPottext.Text = betPot.ToString();
                lblCashcoin.Text = Cash.ToString();
            }
        }

        private void buttonBet50_Click(object sender, EventArgs e)
        {
            Cash = Cash - 50;
            Payout;

             void label2_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Press C To add 100 Coins", "Cheats!");
            }

             void btnBethigh_Click(object sender, EventArgs e)
            {
                NewNumber = rnd.Next(0, 10);
                Console.WriteLine("Old Number is: " + CurrentNumber + ", New Number Is: " + NewNumber + ".");
                Pot = Pot + betPot;
                betPottext.Text = "0";
                betPot = 0;
                if (NewNumber > CurrentNumber)
                {
                    Cash = Cash + (Pot + Pot);
                    lblCashcoin.Text = Cash.ToString();
                    Console.WriteLine("You Won! $" + (Pot + Pot) + " Has been added to your account");
                }
                else
                {
                    Console.WriteLine("You Lose, The Number was lower!");

                }
                if (NewNumber == CurrentNumber)
                {
                    Cash = Cash + Pot;
                    lblCashcoin.Text = Cash.ToString();
                    Console.WriteLine("The Same Number Appeared...All Bets Have Been Returned");
                }
                else
                {
                    CurrentNumber = NewNumber;
                    lblNumber.Text = CurrentNumber.ToString();
                    Pot = 0;

                }
            }


             void btnBetlow_Click(object sender, EventArgs e)
            {
                {
                    NewNumber = rnd.Next(0, 10);
                    Console.WriteLine("Old Number is: " + CurrentNumber + ", New Number Is: " + NewNumber + ".");
                    Pot = Pot + betPot;
                    betPottext.Text = "0";
                    betPot = 0;
                    if (NewNumber < CurrentNumber)
                    {
                        Cash = Cash + (Pot + Pot);
                        lblCashcoin.Text = Cash.ToString();
                        Console.WriteLine("You Won! $" + (Pot + Pot) + " Has been added to your account");
                    }
                    else
                    {
                        Console.WriteLine("You Lose, The Number was Higher!");

                    }
                    if (NewNumber == CurrentNumber)
                    {
                        Cash = Cash + Pot;
                        lblCashcoin.Text = Cash.ToString();
                        Console.WriteLine("The Same Number Appeared...All Bets Have Been Returned");
                    }
                    else
                    {
                        CurrentNumber = NewNumber;
                        lblNumber.Text = CurrentNumber.ToString();
                        Pot = 0;

                    }
                }
            }

             void lblNumber_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Welcome to HiLo! A simple number betting game created using C# and the windows forms engine.   entirely designed and developed by Nath Thornton of S3RVGames in 2018. For any Bugs, Please Contact the developer directly at nathant995@gmail.com. Thankyou for supporting my game!", "HiLo Information!");
            } // Credits to the Devs
        }
    }
}
