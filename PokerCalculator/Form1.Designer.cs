namespace PokerCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.holdLabel1 = new System.Windows.Forms.Label();
            this.holdLabel2 = new System.Windows.Forms.Label();
            this.flopLabel1 = new System.Windows.Forms.Label();
            this.flopLabel2 = new System.Windows.Forms.Label();
            this.flopLabel3 = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.riverLabel = new System.Windows.Forms.Label();
            this.suitLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.holdSuit1 = new System.Windows.Forms.ComboBox();
            this.holdNumber1 = new System.Windows.Forms.ComboBox();
            this.holdNumber2 = new System.Windows.Forms.ComboBox();
            this.holdSuit2 = new System.Windows.Forms.ComboBox();
            this.flopNumber1 = new System.Windows.Forms.ComboBox();
            this.flopSui1 = new System.Windows.Forms.ComboBox();
            this.turnNumber = new System.Windows.Forms.ComboBox();
            this.turnSuit = new System.Windows.Forms.ComboBox();
            this.flopNumber3 = new System.Windows.Forms.ComboBox();
            this.flopSuit3 = new System.Windows.Forms.ComboBox();
            this.flopNumber2 = new System.Windows.Forms.ComboBox();
            this.flopSuit2 = new System.Windows.Forms.ComboBox();
            this.riverNumber = new System.Windows.Forms.ComboBox();
            this.riverSuit = new System.Windows.Forms.ComboBox();
            this.warningText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.RankingLabel = new System.Windows.Forms.Label();
            this.ProbabilityLabel = new System.Windows.Forms.Label();
            this.RoyalFlushLabel = new System.Windows.Forms.Label();
            this.StraightFlushLabel = new System.Windows.Forms.Label();
            this.FoudOfAKindLabel = new System.Windows.Forms.Label();
            this.FullHouseLabel = new System.Windows.Forms.Label();
            this.FlushLabel = new System.Windows.Forms.Label();
            this.StraightLabel = new System.Windows.Forms.Label();
            this.ThreeOfAKindLabel = new System.Windows.Forms.Label();
            this.TwoPairLabel = new System.Windows.Forms.Label();
            this.PairLabel = new System.Windows.Forms.Label();
            this.HighCardLabel = new System.Windows.Forms.Label();
            this.RoyalFlushPercentage = new System.Windows.Forms.TextBox();
            this.StraightFlushPercentage = new System.Windows.Forms.TextBox();
            this.FoudOfAKindPercentage = new System.Windows.Forms.TextBox();
            this.FullHousePercentage = new System.Windows.Forms.TextBox();
            this.FlushPercentage = new System.Windows.Forms.TextBox();
            this.StraightPercentage = new System.Windows.Forms.TextBox();
            this.ThreeOfAKindPercentage = new System.Windows.Forms.TextBox();
            this.TwoPairPercentage = new System.Windows.Forms.TextBox();
            this.PairPercentage = new System.Windows.Forms.TextBox();
            this.HighCardPercentage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // holdLabel1
            // 
            this.holdLabel1.AutoSize = true;
            this.holdLabel1.Location = new System.Drawing.Point(100, 120);
            this.holdLabel1.Name = "holdLabel1";
            this.holdLabel1.Size = new System.Drawing.Size(61, 13);
            this.holdLabel1.TabIndex = 0;
            this.holdLabel1.Text = "*First Hold: ";
            // 
            // holdLabel2
            // 
            this.holdLabel2.AutoSize = true;
            this.holdLabel2.Location = new System.Drawing.Point(100, 160);
            this.holdLabel2.Name = "holdLabel2";
            this.holdLabel2.Size = new System.Drawing.Size(79, 13);
            this.holdLabel2.TabIndex = 1;
            this.holdLabel2.Text = "*Second Hold: ";
            // 
            // flopLabel1
            // 
            this.flopLabel1.AutoSize = true;
            this.flopLabel1.Location = new System.Drawing.Point(100, 200);
            this.flopLabel1.Name = "flopLabel1";
            this.flopLabel1.Size = new System.Drawing.Size(55, 13);
            this.flopLabel1.TabIndex = 2;
            this.flopLabel1.Text = "First Flop: ";
            // 
            // flopLabel2
            // 
            this.flopLabel2.AutoSize = true;
            this.flopLabel2.Location = new System.Drawing.Point(100, 240);
            this.flopLabel2.Name = "flopLabel2";
            this.flopLabel2.Size = new System.Drawing.Size(73, 13);
            this.flopLabel2.TabIndex = 3;
            this.flopLabel2.Text = "Second Flop: ";
            // 
            // flopLabel3
            // 
            this.flopLabel3.AutoSize = true;
            this.flopLabel3.Location = new System.Drawing.Point(100, 280);
            this.flopLabel3.Name = "flopLabel3";
            this.flopLabel3.Size = new System.Drawing.Size(60, 13);
            this.flopLabel3.TabIndex = 4;
            this.flopLabel3.Text = "Third Flop: ";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(100, 320);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(35, 13);
            this.turnLabel.TabIndex = 5;
            this.turnLabel.Text = "Turn: ";
            // 
            // riverLabel
            // 
            this.riverLabel.AutoSize = true;
            this.riverLabel.Location = new System.Drawing.Point(100, 360);
            this.riverLabel.Name = "riverLabel";
            this.riverLabel.Size = new System.Drawing.Size(38, 13);
            this.riverLabel.TabIndex = 6;
            this.riverLabel.Text = "River: ";
            // 
            // suitLabel
            // 
            this.suitLabel.AutoSize = true;
            this.suitLabel.Location = new System.Drawing.Point(250, 70);
            this.suitLabel.Name = "suitLabel";
            this.suitLabel.Size = new System.Drawing.Size(25, 13);
            this.suitLabel.TabIndex = 7;
            this.suitLabel.Text = "Suit";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(450, 70);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(44, 13);
            this.numberLabel.TabIndex = 8;
            this.numberLabel.Text = "Number";
            // 
            // holdSuit1
            // 
            this.holdSuit1.FormattingEnabled = true;
            this.holdSuit1.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.holdSuit1.Location = new System.Drawing.Point(253, 112);
            this.holdSuit1.Name = "holdSuit1";
            this.holdSuit1.Size = new System.Drawing.Size(121, 21);
            this.holdSuit1.TabIndex = 9;
            // 
            // holdNumber1
            // 
            this.holdNumber1.FormattingEnabled = true;
            this.holdNumber1.Items.AddRange(new object[] {
            "A",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K"});
            this.holdNumber1.Location = new System.Drawing.Point(453, 112);
            this.holdNumber1.Name = "holdNumber1";
            this.holdNumber1.Size = new System.Drawing.Size(121, 21);
            this.holdNumber1.TabIndex = 10;
            // 
            // holdNumber2
            // 
            this.holdNumber2.FormattingEnabled = true;
            this.holdNumber2.Items.AddRange(new object[] {
            "A",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K"});
            this.holdNumber2.Location = new System.Drawing.Point(453, 152);
            this.holdNumber2.Name = "holdNumber2";
            this.holdNumber2.Size = new System.Drawing.Size(121, 21);
            this.holdNumber2.TabIndex = 12;
            // 
            // holdSuit2
            // 
            this.holdSuit2.FormattingEnabled = true;
            this.holdSuit2.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.holdSuit2.Location = new System.Drawing.Point(253, 152);
            this.holdSuit2.Name = "holdSuit2";
            this.holdSuit2.Size = new System.Drawing.Size(121, 21);
            this.holdSuit2.TabIndex = 11;
            // 
            // flopNumber1
            // 
            this.flopNumber1.FormattingEnabled = true;
            this.flopNumber1.Items.AddRange(new object[] {
            "A",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K"});
            this.flopNumber1.Location = new System.Drawing.Point(453, 192);
            this.flopNumber1.Name = "flopNumber1";
            this.flopNumber1.Size = new System.Drawing.Size(121, 21);
            this.flopNumber1.TabIndex = 14;
            // 
            // flopSui1
            // 
            this.flopSui1.FormattingEnabled = true;
            this.flopSui1.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.flopSui1.Location = new System.Drawing.Point(253, 192);
            this.flopSui1.Name = "flopSui1";
            this.flopSui1.Size = new System.Drawing.Size(121, 21);
            this.flopSui1.TabIndex = 13;
            // 
            // turnNumber
            // 
            this.turnNumber.FormattingEnabled = true;
            this.turnNumber.Items.AddRange(new object[] {
            "A",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K"});
            this.turnNumber.Location = new System.Drawing.Point(453, 317);
            this.turnNumber.Name = "turnNumber";
            this.turnNumber.Size = new System.Drawing.Size(121, 21);
            this.turnNumber.TabIndex = 20;
            // 
            // turnSuit
            // 
            this.turnSuit.FormattingEnabled = true;
            this.turnSuit.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.turnSuit.Location = new System.Drawing.Point(253, 317);
            this.turnSuit.Name = "turnSuit";
            this.turnSuit.Size = new System.Drawing.Size(121, 21);
            this.turnSuit.TabIndex = 19;
            // 
            // flopNumber3
            // 
            this.flopNumber3.FormattingEnabled = true;
            this.flopNumber3.Items.AddRange(new object[] {
            "A",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K"});
            this.flopNumber3.Location = new System.Drawing.Point(453, 277);
            this.flopNumber3.Name = "flopNumber3";
            this.flopNumber3.Size = new System.Drawing.Size(121, 21);
            this.flopNumber3.TabIndex = 18;
            // 
            // flopSuit3
            // 
            this.flopSuit3.FormattingEnabled = true;
            this.flopSuit3.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.flopSuit3.Location = new System.Drawing.Point(253, 277);
            this.flopSuit3.Name = "flopSuit3";
            this.flopSuit3.Size = new System.Drawing.Size(121, 21);
            this.flopSuit3.TabIndex = 17;
            // 
            // flopNumber2
            // 
            this.flopNumber2.FormattingEnabled = true;
            this.flopNumber2.Items.AddRange(new object[] {
            "A",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K"});
            this.flopNumber2.Location = new System.Drawing.Point(453, 237);
            this.flopNumber2.Name = "flopNumber2";
            this.flopNumber2.Size = new System.Drawing.Size(121, 21);
            this.flopNumber2.TabIndex = 16;
            // 
            // flopSuit2
            // 
            this.flopSuit2.FormattingEnabled = true;
            this.flopSuit2.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.flopSuit2.Location = new System.Drawing.Point(253, 237);
            this.flopSuit2.Name = "flopSuit2";
            this.flopSuit2.Size = new System.Drawing.Size(121, 21);
            this.flopSuit2.TabIndex = 15;
            // 
            // riverNumber
            // 
            this.riverNumber.FormattingEnabled = true;
            this.riverNumber.Items.AddRange(new object[] {
            "A",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K"});
            this.riverNumber.Location = new System.Drawing.Point(453, 352);
            this.riverNumber.Name = "riverNumber";
            this.riverNumber.Size = new System.Drawing.Size(121, 21);
            this.riverNumber.TabIndex = 22;
            // 
            // riverSuit
            // 
            this.riverSuit.FormattingEnabled = true;
            this.riverSuit.Items.AddRange(new object[] {
            "Heart",
            "Diamond",
            "Spade",
            "Club"});
            this.riverSuit.Location = new System.Drawing.Point(253, 352);
            this.riverSuit.Name = "riverSuit";
            this.riverSuit.Size = new System.Drawing.Size(121, 21);
            this.riverSuit.TabIndex = 21;
            // 
            // warningText
            // 
            this.warningText.AutoSize = true;
            this.warningText.Location = new System.Drawing.Point(100, 400);
            this.warningText.Name = "warningText";
            this.warningText.Size = new System.Drawing.Size(156, 13);
            this.warningText.TabIndex = 23;
            this.warningText.Text = "Must * items in order to proceed";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(453, 395);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(121, 23);
            this.startButton.TabIndex = 24;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // RankingLabel
            // 
            this.RankingLabel.AutoSize = true;
            this.RankingLabel.Location = new System.Drawing.Point(780, 70);
            this.RankingLabel.Name = "RankingLabel";
            this.RankingLabel.Size = new System.Drawing.Size(47, 13);
            this.RankingLabel.TabIndex = 25;
            this.RankingLabel.Text = "Ranking";
            // 
            // ProbabilityLabel
            // 
            this.ProbabilityLabel.AutoSize = true;
            this.ProbabilityLabel.Location = new System.Drawing.Point(890, 70);
            this.ProbabilityLabel.Name = "ProbabilityLabel";
            this.ProbabilityLabel.Size = new System.Drawing.Size(55, 13);
            this.ProbabilityLabel.TabIndex = 26;
            this.ProbabilityLabel.Text = "Probability";
            // 
            // RoyalFlushLabel
            // 
            this.RoyalFlushLabel.AutoSize = true;
            this.RoyalFlushLabel.Location = new System.Drawing.Point(780, 110);
            this.RoyalFlushLabel.Name = "RoyalFlushLabel";
            this.RoyalFlushLabel.Size = new System.Drawing.Size(59, 13);
            this.RoyalFlushLabel.TabIndex = 27;
            this.RoyalFlushLabel.Text = "RoyalFlush";
            // 
            // StraightFlushLabel
            // 
            this.StraightFlushLabel.AutoSize = true;
            this.StraightFlushLabel.Location = new System.Drawing.Point(780, 140);
            this.StraightFlushLabel.Name = "StraightFlushLabel";
            this.StraightFlushLabel.Size = new System.Drawing.Size(68, 13);
            this.StraightFlushLabel.TabIndex = 28;
            this.StraightFlushLabel.Text = "StraightFlush";
            // 
            // FoudOfAKindLabel
            // 
            this.FoudOfAKindLabel.AutoSize = true;
            this.FoudOfAKindLabel.Location = new System.Drawing.Point(780, 170);
            this.FoudOfAKindLabel.Name = "FoudOfAKindLabel";
            this.FoudOfAKindLabel.Size = new System.Drawing.Size(70, 13);
            this.FoudOfAKindLabel.TabIndex = 29;
            this.FoudOfAKindLabel.Text = "FoudOfAKind";
            // 
            // FullHouseLabel
            // 
            this.FullHouseLabel.AutoSize = true;
            this.FullHouseLabel.Location = new System.Drawing.Point(780, 200);
            this.FullHouseLabel.Name = "FullHouseLabel";
            this.FullHouseLabel.Size = new System.Drawing.Size(54, 13);
            this.FullHouseLabel.TabIndex = 30;
            this.FullHouseLabel.Text = "FullHouse";
            // 
            // FlushLabel
            // 
            this.FlushLabel.AutoSize = true;
            this.FlushLabel.Location = new System.Drawing.Point(780, 230);
            this.FlushLabel.Name = "FlushLabel";
            this.FlushLabel.Size = new System.Drawing.Size(32, 13);
            this.FlushLabel.TabIndex = 31;
            this.FlushLabel.Text = "Flush";
            // 
            // StraightLabel
            // 
            this.StraightLabel.AutoSize = true;
            this.StraightLabel.Location = new System.Drawing.Point(780, 260);
            this.StraightLabel.Name = "StraightLabel";
            this.StraightLabel.Size = new System.Drawing.Size(43, 13);
            this.StraightLabel.TabIndex = 32;
            this.StraightLabel.Text = "Straight";
            // 
            // ThreeOfAKindLabel
            // 
            this.ThreeOfAKindLabel.AutoSize = true;
            this.ThreeOfAKindLabel.Location = new System.Drawing.Point(780, 290);
            this.ThreeOfAKindLabel.Name = "ThreeOfAKindLabel";
            this.ThreeOfAKindLabel.Size = new System.Drawing.Size(74, 13);
            this.ThreeOfAKindLabel.TabIndex = 33;
            this.ThreeOfAKindLabel.Text = "ThreeOfAKind";
            // 
            // TwoPairLabel
            // 
            this.TwoPairLabel.AutoSize = true;
            this.TwoPairLabel.Location = new System.Drawing.Point(780, 320);
            this.TwoPairLabel.Name = "TwoPairLabel";
            this.TwoPairLabel.Size = new System.Drawing.Size(46, 13);
            this.TwoPairLabel.TabIndex = 34;
            this.TwoPairLabel.Text = "TwoPair";
            // 
            // PairLabel
            // 
            this.PairLabel.AutoSize = true;
            this.PairLabel.Location = new System.Drawing.Point(780, 350);
            this.PairLabel.Name = "PairLabel";
            this.PairLabel.Size = new System.Drawing.Size(25, 13);
            this.PairLabel.TabIndex = 35;
            this.PairLabel.Text = "Pair";
            // 
            // HighCardLabel
            // 
            this.HighCardLabel.AutoSize = true;
            this.HighCardLabel.Location = new System.Drawing.Point(780, 380);
            this.HighCardLabel.Name = "HighCardLabel";
            this.HighCardLabel.Size = new System.Drawing.Size(51, 13);
            this.HighCardLabel.TabIndex = 36;
            this.HighCardLabel.Text = "HighCard";
            // 
            // textBox1
            // 
            this.RoyalFlushPercentage.Location = new System.Drawing.Point(890, 105);
            this.RoyalFlushPercentage.Name = "RoyalFlushPercentage";
            this.RoyalFlushPercentage.Size = new System.Drawing.Size(100, 20);
            this.RoyalFlushPercentage.TabIndex = 37;
            // 
            // textBox2
            // 
            this.StraightFlushPercentage.Location = new System.Drawing.Point(890, 135);
            this.StraightFlushPercentage.Name = "StraightFlushPercentage";
            this.StraightFlushPercentage.Size = new System.Drawing.Size(100, 20);
            this.StraightFlushPercentage.TabIndex = 38;
            // 
            // textBox3
            // 
            this.FoudOfAKindPercentage.Location = new System.Drawing.Point(890, 165);
            this.FoudOfAKindPercentage.Name = "FoudOfAKindPercentage";
            this.FoudOfAKindPercentage.Size = new System.Drawing.Size(100, 20);
            this.FoudOfAKindPercentage.TabIndex = 39;
            // 
            // textBox4
            // 
            this.FullHousePercentage.Location = new System.Drawing.Point(890, 195);
            this.FullHousePercentage.Name = "FullHousePercentage";
            this.FullHousePercentage.Size = new System.Drawing.Size(100, 20);
            this.FullHousePercentage.TabIndex = 40;
            // 
            // textBox5
            // 
            this.FlushPercentage.Location = new System.Drawing.Point(890, 225);
            this.FlushPercentage.Name = "FlushPercentage";
            this.FlushPercentage.Size = new System.Drawing.Size(100, 20);
            this.FlushPercentage.TabIndex = 41;
            // 
            // textBox6
            // 
            this.StraightPercentage.Location = new System.Drawing.Point(890, 255);
            this.StraightPercentage.Name = "StraightPercentage";
            this.StraightPercentage.Size = new System.Drawing.Size(100, 20);
            this.StraightPercentage.TabIndex = 42;
            // 
            // textBox7
            // 
            this.ThreeOfAKindPercentage.Location = new System.Drawing.Point(890, 285);
            this.ThreeOfAKindPercentage.Name = "ThreeOfAKindPercentage";
            this.ThreeOfAKindPercentage.Size = new System.Drawing.Size(100, 20);
            this.ThreeOfAKindPercentage.TabIndex = 43;
            // 
            // textBox8
            // 
            this.TwoPairPercentage.Location = new System.Drawing.Point(890, 315);
            this.TwoPairPercentage.Name = "TwoPairPercentage";
            this.TwoPairPercentage.Size = new System.Drawing.Size(100, 20);
            this.TwoPairPercentage.TabIndex = 44;
            // 
            // textBox9
            // 
            this.PairPercentage.Location = new System.Drawing.Point(890, 345);
            this.PairPercentage.Name = "PairPercentage";
            this.PairPercentage.Size = new System.Drawing.Size(100, 20);
            this.PairPercentage.TabIndex = 45;
            // 
            // textBox10
            // 
            this.HighCardPercentage.Location = new System.Drawing.Point(890, 375);
            this.HighCardPercentage.Name = "HighCardPercentage";
            this.HighCardPercentage.Size = new System.Drawing.Size(100, 20);
            this.HighCardPercentage.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 486);
            this.Controls.Add(this.HighCardPercentage);
            this.Controls.Add(this.PairPercentage);
            this.Controls.Add(this.TwoPairPercentage);
            this.Controls.Add(this.ThreeOfAKindPercentage);
            this.Controls.Add(this.StraightPercentage);
            this.Controls.Add(this.FlushPercentage);
            this.Controls.Add(this.FullHousePercentage);
            this.Controls.Add(this.FoudOfAKindPercentage);
            this.Controls.Add(this.StraightFlushPercentage);
            this.Controls.Add(this.RoyalFlushPercentage);
            this.Controls.Add(this.HighCardLabel);
            this.Controls.Add(this.PairLabel);
            this.Controls.Add(this.TwoPairLabel);
            this.Controls.Add(this.ThreeOfAKindLabel);
            this.Controls.Add(this.StraightLabel);
            this.Controls.Add(this.FlushLabel);
            this.Controls.Add(this.FullHouseLabel);
            this.Controls.Add(this.FoudOfAKindLabel);
            this.Controls.Add(this.StraightFlushLabel);
            this.Controls.Add(this.RoyalFlushLabel);
            this.Controls.Add(this.ProbabilityLabel);
            this.Controls.Add(this.RankingLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.warningText);
            this.Controls.Add(this.riverNumber);
            this.Controls.Add(this.riverSuit);
            this.Controls.Add(this.turnNumber);
            this.Controls.Add(this.turnSuit);
            this.Controls.Add(this.flopNumber3);
            this.Controls.Add(this.flopSuit3);
            this.Controls.Add(this.flopNumber2);
            this.Controls.Add(this.flopSuit2);
            this.Controls.Add(this.flopNumber1);
            this.Controls.Add(this.flopSui1);
            this.Controls.Add(this.holdNumber2);
            this.Controls.Add(this.holdSuit2);
            this.Controls.Add(this.holdNumber1);
            this.Controls.Add(this.holdSuit1);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.suitLabel);
            this.Controls.Add(this.riverLabel);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.flopLabel3);
            this.Controls.Add(this.flopLabel2);
            this.Controls.Add(this.flopLabel1);
            this.Controls.Add(this.holdLabel2);
            this.Controls.Add(this.holdLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label holdLabel1;
        private System.Windows.Forms.Label holdLabel2;
        private System.Windows.Forms.Label flopLabel1;
        private System.Windows.Forms.Label flopLabel2;
        private System.Windows.Forms.Label flopLabel3;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label riverLabel;
        private System.Windows.Forms.Label suitLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.ComboBox holdSuit1;
        private System.Windows.Forms.ComboBox holdNumber1;
        private System.Windows.Forms.ComboBox holdNumber2;
        private System.Windows.Forms.ComboBox holdSuit2;
        private System.Windows.Forms.ComboBox flopNumber1;
        private System.Windows.Forms.ComboBox flopSui1;
        private System.Windows.Forms.ComboBox turnNumber;
        private System.Windows.Forms.ComboBox turnSuit;
        private System.Windows.Forms.ComboBox flopNumber3;
        private System.Windows.Forms.ComboBox flopSuit3;
        private System.Windows.Forms.ComboBox flopNumber2;
        private System.Windows.Forms.ComboBox flopSuit2;
        private System.Windows.Forms.ComboBox riverNumber;
        private System.Windows.Forms.ComboBox riverSuit;
        private System.Windows.Forms.Label warningText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label RankingLabel;
        private System.Windows.Forms.Label ProbabilityLabel;
        private System.Windows.Forms.Label RoyalFlushLabel;
        private System.Windows.Forms.Label StraightFlushLabel;
        private System.Windows.Forms.Label FoudOfAKindLabel;
        private System.Windows.Forms.Label FullHouseLabel;
        private System.Windows.Forms.Label FlushLabel;
        private System.Windows.Forms.Label StraightLabel;
        private System.Windows.Forms.Label ThreeOfAKindLabel;
        private System.Windows.Forms.Label TwoPairLabel;
        private System.Windows.Forms.Label PairLabel;
        private System.Windows.Forms.Label HighCardLabel;
        private System.Windows.Forms.TextBox RoyalFlushPercentage;
        private System.Windows.Forms.TextBox StraightFlushPercentage;
        private System.Windows.Forms.TextBox FoudOfAKindPercentage;
        private System.Windows.Forms.TextBox FullHousePercentage;
        private System.Windows.Forms.TextBox FlushPercentage;
        private System.Windows.Forms.TextBox StraightPercentage;
        private System.Windows.Forms.TextBox ThreeOfAKindPercentage;
        private System.Windows.Forms.TextBox TwoPairPercentage;
        private System.Windows.Forms.TextBox PairPercentage;
        private System.Windows.Forms.TextBox HighCardPercentage;
    }
}

