namespace CS311_Project2_SEB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            // Retrieve the bet amount from the text box and parse it to a double.
            if (double.TryParse(txtBetAmount.Text, out double BetAmount))
            {
                // Check if the bet amount is within the player's bank balance.
                if (BetAmount > playerBank)
                {
                    MessageBox.Show("Bet amount cannot exceed your current bank balance.");
                }
                else
                {
                    // If the bet can be covered, proceed with the game.
                    CalculateScore(BetAmount);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid bet amount.");
            }
        }
    }
}