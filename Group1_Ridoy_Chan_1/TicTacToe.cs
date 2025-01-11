using Group1_Ridoy_Chan_1.Properties;
using System.Data.Common;

namespace Group1_Ridoy_Chan_1
{
    public partial class TicTacToe : Form
    {
        private const int INIT_TOP = 150;
        private const int INIT_LEFT = 40;
        private const int WIDTH = 80;
        private const int HEIGHT = 80;
        private const int VGAP = 10;
        private const int HGAP = 10;

        private int numberOfRows = 3;
        private int index = 0;

        private int round = 1;
        private int player1Score = 0;
        private int player2Score = 0;

        private readonly Bitmap circleImage;
        private readonly Bitmap xImage;
        private readonly Bitmap winnerImage;

        public TicTacToe()
        {
            InitializeComponent();

            // Adding 3x3 and 5x5 grid size selection
            gridSizeComboBox.Items.Add("3 x 3");
            gridSizeComboBox.Items.Add("5 x 5");
            gridSizeComboBox.SelectedIndex = 0; // Default to 3x3

            // load images
            using (var ms = new MemoryStream(Resources.Circle))
            {
                circleImage = new Bitmap(ms);
            }

            using (var ms = new MemoryStream(Resources.X))
            {
                xImage = new Bitmap(ms);
            }

            using (var ms = new MemoryStream(Resources.Winner))
            {
                winnerImage = new Bitmap(ms);
            }

            InitializeGrid(numberOfRows); //initialize the grid with the default 3x3 size

        }

        
        private void InitializeGrid(int numberOfRows)
        {
            int x = INIT_LEFT;
            int y = INIT_TOP;

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    PictureBox pictureBox = new()
                    {
                        Left = x,
                        Top = y,
                        Width = WIDTH,
                        Height = HEIGHT,
                        BackColor = Color.White,
                        Name = i.ToString() + "," + j.ToString(),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Tag = "grid" // Tag to differentiate game cells
                    };

                    this.Controls.Add(pictureBox);

                    pictureBox.Click += B_Click;

                    x += WIDTH + HGAP;
                }

                x = INIT_LEFT;
                y += HEIGHT + VGAP;
            }
        }

        private void B_Click(object? sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && pictureBox.Image == null) // If cell is empty
            {
                // Set the image based on which player's turn it is
                pictureBox.Image = index++ % 2 == 0 ? circleImage : xImage;

                if (CheckWinner() != null)
                {
                    HandleWinner();
                }
                else if (AreAllCellsFilled())
                {
                    MessageBox.Show("It's a Draw!");
                    round++;
                    ResetGame();
                }
            }
        }


        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void restartGame()
        {
            round = 1;
            player1Score = 0;
            player2Score = 0;

            UpdateScoreDisplay();
            ResetGame();
        }


        // Method to check if there is a winner by analyzing rows, columns, and diagonals
        private List<PictureBox>? CheckWinner()
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                var rowWin = CheckLine(i, 0, 0, 1); // Check rows
                if (rowWin != null)
                    return rowWin;

                var colWin = CheckLine(0, i, 1, 0); // Check columns
                if (colWin != null)
                    return colWin;
            }

            var diagWin1 = CheckLine(0, 0, 1, 1); // Check diagonals
            if (diagWin1 != null)
                return diagWin1;

            var diagWin2 = CheckLine(0, numberOfRows - 1, 1, -1); // Check diagonals
            if (diagWin2 != null)
                return diagWin2;

            return null; // return null if no winner
        }


        // Method to check a line (row, column, or diagonal) for winning condition
        private List<PictureBox>? CheckLine(int startX, int startY, int stepX, int stepY)
        {
            List<PictureBox> winningLine = [];
            Image? firstImage = null;

            // Loop through the line
            for (int i = 0; i < numberOfRows; i++)
            {
                int x = startX + i * stepX; // Calculate the x and y coordinates
                int y = startY + i * stepY; 
                var box = GetPictureBoxAt(x, y); // Get the PictureBox at the x and y coordinates

                if (box == null || box.Image == null) // If the PictureBox is empty
                {
                    return null;
                }

                if (firstImage == null) 
                {
                    firstImage = box.Image; // Set the first image
                }
                else if (firstImage != box.Image) // If the image is different from the first image
                {
                    return null;
                }

                winningLine.Add(box); // Add the PictureBox to the winning line 
            }

            return winningLine; 
        }


        // Method to get the PictureBox at a specific row and column
        private PictureBox? GetPictureBoxAt(int row, int column)
        {
            // Search for the PictureBox using its row and column 
            foreach (var pictureBox in this.Controls.OfType<PictureBox>())
            {
                if (pictureBox.Name == $"{row},{column}")
                {
                    return pictureBox; // Return the PictureBox if found
                }
            }
            return null; // Return null if no PictureBox is found
        }

        // handles winner
        private void HandleWinner()
        {
            if (index % 2 == 0)
            {
                // Player 2 wins this round
                player2Score++;
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                // Player 1 wins this round
                player1Score++;
                MessageBox.Show("Player 1 Wins!");
            }

            round++;
            ResetGame();

        }

        // updates winner badge
        private void UpdateWinnerBadge()
        {
            // Clear both winner images
            pictureBoxPlayer1Wins.Image = null;
            pictureBoxPlayer1Wins.Image = null;

            // Check which player has a higher score and display the winner badge
            if (player1Score > 0 && player1Score > player2Score)
            {
                pictureBoxPlayer1Wins.Image = winnerImage; // Player 1 has a higher score
            }
            else if (player2Score > 0 && player2Score > player1Score)
            {
                pictureBoxPlayer2Wins.Image = winnerImage; // Player 2 has a higher score
            }
            // If the scores are equal or both are 0, no badge will be shown
        }

        // checks if all cells are filled
        private bool AreAllCellsFilled()
        {
            // Get all PictureBox controls
            var pictureBoxes = this.Controls.OfType<PictureBox>().ToArray();

            // Loop through the array of PictureBox controls
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                var pictureBox = pictureBoxes[i];

                // Check if the PictureBox is a game cell and is empty
                if (pictureBox.Tag?.ToString() == "grid" && pictureBox.Image == null)
                {
                    return false; // Not all cells are filled
                }
            }

            return true; // All cells are filled
        }


        // resets the game
        private void ResetGame()
        {
            // Clear the grid cells
            ClearGridCells();

            // reset index
            index = 0;

            // update score display and winner badge
            UpdateScoreDisplay();
            UpdateWinnerBadge();
        }

        // clears grid cells
        private void ClearGridCells()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox && pictureBox.Tag?.ToString() == "grid")
                {
                    pictureBox.Image = null; // Clear the image for game cells
                }
            }
        }

        // updates score display
        private void UpdateScoreDisplay()
        {
            lblPlayer1Score.Text = player1Score.ToString();
            lblPlayer2Score.Text = player2Score.ToString();
            lblRoundResult.Text = round.ToString();
        }

        // clears the grid
        private void ClearGrid()
        {
            List<Control> controlsToRemove = new List<Control>();

            // Remove all PictureBox controls with the "grid" tag
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "grid")
                {
                    controlsToRemove.Add(control);
                }
            }

            // Dispose of the PictureBox controls
            foreach (Control control in controlsToRemove)
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
        }

        // handles game exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // handles grid size change
        private void gridSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            restartGame();
            // Ensure that the selected item is a string
            if (gridSizeComboBox.SelectedItem is string selectedSize)
            {
                int selectedNumberOfRows;
                if (selectedSize == "3 x 3")
                {
                    selectedNumberOfRows = 3;
                }
                else if (selectedSize == "5 x 5")
                {
                    selectedNumberOfRows = 5;
                }
                else
                {
                    return;
                }

                // If the selected number of rows is different from the current number of rows
                if (selectedNumberOfRows != numberOfRows)
                {
                    numberOfRows = selectedNumberOfRows;// Update the number of rows
                    ClearGrid();
                    InitializeGrid(numberOfRows);
                    ResetGame();
                }
            }
        }
    }
}