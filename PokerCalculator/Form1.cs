using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokerCalculator
{
    public partial class Form1 : Form
    {
        private Dictionary<string, CardSuits> _suitMapper;
        private Dictionary<string, int> _numberMapper;
        private List<Cards> _hands;

        private ICalculation _calculation;

        public Form1()
        {
            InitializeComponent();

            InitializeRepositories();
            InitializeMapper();
        }

        private void InitializeRepositories()
        {
            _calculation = new Calculation();
        }

        private void InitializeMapper()
        {
            _suitMapper = new Dictionary<string, CardSuits>
            {
                {"Heart", CardSuits.Hearts},
                {"Diamond", CardSuits.Diamonds},
                {"Spade", CardSuits.Spades},
                {"Club", CardSuits.Clubs}
            };

            _numberMapper = new Dictionary<string, int>
            {
                {"A", 1},
                {"2", 2},
                {"3", 3},
                {"4", 4},
                {"5", 5},
                {"6", 6},
                {"7", 7},
                {"8", 8},
                {"9", 9},
                {"10", 10},
                {"J", 11},
                {"Q", 12},
                {"K", 13}
            };
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!RequiredItemsAreEntered())
            {
                // terminate the program
                const string warningTest = "Requried items are not entered. Program closed!";
                
                MessageBox.Show(warningTest);
                Application.Exit();
            }

            //Calculate(_hands) 
            // calculate based on two given cards
            GetCardValues();
            var probabilityList = _calculation.Probability(_hands, _hands.Count);
            UpdateOutput(probabilityList);

        }

        private bool RequiredItemsAreEntered()
        {
            return !holdSuit1.SelectedItem.Equals(null) && !holdNumber1.SelectedItem.Equals(null) && !holdSuit2.SelectedItem.Equals(null) && !holdNumber2.SelectedItem.Equals(null);
        }

        private void GetCardValues()
        {
            var handSuit1 = holdSuit1.SelectedItem.ToString();
            var handNumber1 = holdNumber1.SelectedItem.ToString();
            var handSuit2 = holdSuit2.SelectedItem.ToString();
            var handNumber2 = holdNumber2.SelectedItem.ToString();

            _hands = new List<Cards>
            {
                new Cards(_suitMapper[handSuit1], _numberMapper[handNumber1]),
                new Cards(_suitMapper[handSuit2], _numberMapper[handNumber2])
            };
        }

        private void UpdateOutput(List<Probability> probablityList)
        {
            RoyalFlushPercentage.Text = probablityList[0].Percentage.ToString();
        }
    }
}
