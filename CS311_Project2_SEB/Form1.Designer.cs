namespace CS311_Project2_SEB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDie1 = new Label();
            lblDie2 = new Label();
            btnRoll = new Button();
            lblBankAmount = new Label();
            lblAmount = new Label();
            lblBetAmount = new Label();
            txtBetAmount = new TextBox();
            lblOutcome = new Label();
            SuspendLayout();
            // 
            // lblDie1
            // 
            lblDie1.AutoSize = true;
            lblDie1.Location = new Point(1028, 64);
            lblDie1.Name = "lblDie1";
            lblDie1.Size = new Size(70, 32);
            lblDie1.TabIndex = 0;
            lblDie1.Text = "Die 1";
            // 
            // lblDie2
            // 
            lblDie2.AutoSize = true;
            lblDie2.Location = new Point(1120, 64);
            lblDie2.Name = "lblDie2";
            lblDie2.Size = new Size(70, 32);
            lblDie2.TabIndex = 1;
            lblDie2.Text = "Die 2";
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(877, 131);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(464, 88);
            btnRoll.TabIndex = 2;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblBankAmount
            // 
            lblBankAmount.AutoSize = true;
            lblBankAmount.Location = new Point(183, 131);
            lblBankAmount.Name = "lblBankAmount";
            lblBankAmount.Size = new Size(191, 32);
            lblBankAmount.TabIndex = 3;
            lblBankAmount.Text = "Amount in Bank:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(365, 131);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(97, 32);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "$100.00";
            // 
            // lblBetAmount
            // 
            lblBetAmount.AutoSize = true;
            lblBetAmount.Location = new Point(183, 163);
            lblBetAmount.Name = "lblBetAmount";
            lblBetAmount.Size = new Size(179, 32);
            lblBetAmount.TabIndex = 5;
            lblBetAmount.Text = "Amount To Bet:";
            // 
            // txtBetAmount
            // 
            txtBetAmount.Location = new Point(365, 166);
            txtBetAmount.Name = "txtBetAmount";
            txtBetAmount.Size = new Size(200, 39);
            txtBetAmount.TabIndex = 6;
            txtBetAmount.Text = "Enter Bet Amount";
            // 
            // lblOutcome
            // 
            lblOutcome.AutoSize = true;
            lblOutcome.Location = new Point(474, 362);
            lblOutcome.Name = "lblOutcome";
            lblOutcome.Size = new Size(117, 32);
            lblOutcome.TabIndex = 7;
            lblOutcome.Text = "OutCome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 677);
            Controls.Add(lblOutcome);
            Controls.Add(txtBetAmount);
            Controls.Add(lblBetAmount);
            Controls.Add(lblAmount);
            Controls.Add(lblBankAmount);
            Controls.Add(btnRoll);
            Controls.Add(lblDie2);
            Controls.Add(lblDie1);
            Name = "Form1";
            Text = "Craps";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDie1;
        private Label lblDie2;
        private Button btnRoll;
        private Label lblBankAmount;
        private Label lblAmount;
        private Label lblBetAmount;
        private TextBox txtBetAmount;
        private Label lblOutcome;
        private double playerBank = 100.00;


        private void CalculateScore(double BetAmount)
        {
            // Step 1: Generate random numbers for two dice.
            Random random = new Random();
            int die1 = random.Next(1, 7); // Generates a random number between 1 and 6.
            int die2 = random.Next(1, 7);

            // Step 2: Calculate the sum of the dice.
            int sum = die1 + die2;

            // Step 3: Determine the outcome of the game according to Craps rules.
            // You can define your Craps game logic here.

            // Step 4: Display the values of the dice in the appropriate labels.
            lblDie1.Text = "Die 1: " + die1.ToString();
            lblDie2.Text = "Die 2: " + die2.ToString();

            // Step 5: Display a message about winning or losing in the appropriate label.
            string outcomeMessage = "You " + DetermineOutcome(sum); // Implement DetermineOutcome() based on your Craps rules.
            lblOutcome.Text = outcomeMessage;

            // Step 6: Update the player's bank based on the outcome.
            UpdateBank(outcomeMessage, BetAmount);

            // Step 7: Display the correct balance for the user's bank in the appropriate label.
            // Assuming you have a variable to store the player's bank amount (e.g., double playerBank).
            lblAmount.Text = "$" + playerBank.ToString("0.00");
        }

        private void UpdateBank(string outcomeMessage, double BetAmount)
        {
            // Define the player's starting bank amount.
            //double playerBank = 100.00; // You can change this value as needed.

            // Parse the outcome message to determine if the player won or lost.
            if (outcomeMessage.Contains("Win"))
            {
                // Implement logic to add money to the player's bank when they win.
                playerBank += BetAmount; // For example, add $10 to the bank on a win.
            }
            else if (outcomeMessage.Contains("Lose"))
            {
                // Implement logic to subtract money from the player's bank when they lose.
                playerBank -= BetAmount; // For example, subtract $10 from the bank on a loss.
            }

            // Update the player's bank with the new balance.
            lblAmount.Text = "$" + playerBank.ToString("0.00");
        }



        private string DetermineOutcome(int sum)
        {
            // Implement the Craps game logic to determine the outcome based on the sum of the dice.
            // You can define your game rules here. For example:
            if (sum == 7 || sum == 11)
            {
                return "Win: You rolled a 7 or 11!";
            }
            else if (sum == 2 || sum == 3 || sum == 12)
            {
                return "Lose: You rolled a 2, 3, or 12!";
            }
            else
            {
                return "Continue playing..."; // The game continues, and no money is added or subtracted yet.
            }
        }
    }
}