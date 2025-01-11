namespace Group1_Ridoy_Chan_1
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            gridSizeComboBox = new ComboBox();
            grpPlayer1 = new GroupBox();
            pictureBoxPlayer1Wins = new PictureBox();
            lblPlayer1Score = new Label();
            pictureBox1 = new PictureBox();
            grpPlayer2 = new GroupBox();
            pictureBoxPlayer2Wins = new PictureBox();
            lblPlayer2Score = new Label();
            pictureBox2 = new PictureBox();
            btnStartNewGame = new Button();
            btnExit = new Button();
            textBox1 = new TextBox();
            lblRoundResult = new Label();
            lblGridSize = new Label();
            lblRound = new Label();
            lblScoreBoard = new Label();
            grpPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1Wins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2Wins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gridSizeComboBox
            // 
            gridSizeComboBox.BackColor = SystemColors.Info;
            gridSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            gridSizeComboBox.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gridSizeComboBox.FormattingEnabled = true;
            gridSizeComboBox.Location = new Point(773, 43);
            gridSizeComboBox.Name = "gridSizeComboBox";
            gridSizeComboBox.Size = new Size(189, 46);
            gridSizeComboBox.TabIndex = 1;
            gridSizeComboBox.SelectedIndexChanged += gridSizeComboBox_SelectedIndexChanged;
            // 
            // grpPlayer1
            // 
            grpPlayer1.BackColor = Color.DarkGreen;
            grpPlayer1.Controls.Add(pictureBoxPlayer1Wins);
            grpPlayer1.Controls.Add(lblPlayer1Score);
            grpPlayer1.Controls.Add(pictureBox1);
            grpPlayer1.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPlayer1.ForeColor = Color.White;
            grpPlayer1.Location = new Point(577, 288);
            grpPlayer1.Name = "grpPlayer1";
            grpPlayer1.Size = new Size(186, 306);
            grpPlayer1.TabIndex = 5;
            grpPlayer1.TabStop = false;
            grpPlayer1.Text = "Player 1";
            // 
            // pictureBoxPlayer1Wins
            // 
            pictureBoxPlayer1Wins.Location = new Point(37, 183);
            pictureBoxPlayer1Wins.Name = "pictureBoxPlayer1Wins";
            pictureBoxPlayer1Wins.Size = new Size(106, 102);
            pictureBoxPlayer1Wins.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlayer1Wins.TabIndex = 2;
            pictureBoxPlayer1Wins.TabStop = false;
            // 
            // lblPlayer1Score
            // 
            lblPlayer1Score.BackColor = Color.Transparent;
            lblPlayer1Score.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer1Score.ForeColor = Color.Gold;
            lblPlayer1Score.Location = new Point(37, 127);
            lblPlayer1Score.Name = "lblPlayer1Score";
            lblPlayer1Score.Size = new Size(106, 38);
            lblPlayer1Score.TabIndex = 1;
            lblPlayer1Score.Text = "0";
            lblPlayer1Score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // grpPlayer2
            // 
            grpPlayer2.BackColor = Color.DarkGreen;
            grpPlayer2.Controls.Add(pictureBoxPlayer2Wins);
            grpPlayer2.Controls.Add(lblPlayer2Score);
            grpPlayer2.Controls.Add(pictureBox2);
            grpPlayer2.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPlayer2.ForeColor = Color.White;
            grpPlayer2.Location = new Point(787, 288);
            grpPlayer2.Name = "grpPlayer2";
            grpPlayer2.Size = new Size(186, 306);
            grpPlayer2.TabIndex = 6;
            grpPlayer2.TabStop = false;
            grpPlayer2.Text = "Player 2";
            // 
            // pictureBoxPlayer2Wins
            // 
            pictureBoxPlayer2Wins.Location = new Point(39, 183);
            pictureBoxPlayer2Wins.Name = "pictureBoxPlayer2Wins";
            pictureBoxPlayer2Wins.Size = new Size(106, 102);
            pictureBoxPlayer2Wins.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlayer2Wins.TabIndex = 2;
            pictureBoxPlayer2Wins.TabStop = false;
            // 
            // lblPlayer2Score
            // 
            lblPlayer2Score.BackColor = Color.Transparent;
            lblPlayer2Score.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer2Score.ForeColor = Color.Gold;
            lblPlayer2Score.Location = new Point(39, 129);
            lblPlayer2Score.Name = "lblPlayer2Score";
            lblPlayer2Score.Size = new Size(106, 38);
            lblPlayer2Score.TabIndex = 1;
            lblPlayer2Score.Text = "0";
            lblPlayer2Score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkCyan;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(63, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnStartNewGame
            // 
            btnStartNewGame.AutoSize = true;
            btnStartNewGame.BackColor = Color.LightGoldenrodYellow;
            btnStartNewGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartNewGame.ForeColor = SystemColors.ActiveCaptionText;
            btnStartNewGame.Location = new Point(200, 32);
            btnStartNewGame.Name = "btnStartNewGame";
            btnStartNewGame.Size = new Size(249, 65);
            btnStartNewGame.TabIndex = 7;
            btnStartNewGame.Text = "&Start a New Game";
            btnStartNewGame.UseVisualStyleBackColor = false;
            btnStartNewGame.Click += btnStartNewGame_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.LightGoldenrodYellow;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(35, 32);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(124, 65);
            btnExit.TabIndex = 8;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 45);
            textBox1.TabIndex = 9;
            // 
            // lblRoundResult
            // 
            lblRoundResult.BackColor = Color.Transparent;
            lblRoundResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoundResult.ForeColor = Color.Black;
            lblRoundResult.Location = new Point(776, 123);
            lblRoundResult.Name = "lblRoundResult";
            lblRoundResult.Size = new Size(186, 45);
            lblRoundResult.TabIndex = 10;
            lblRoundResult.Text = "1";
            lblRoundResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGridSize
            // 
            lblGridSize.BackColor = Color.Transparent;
            lblGridSize.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGridSize.ForeColor = Color.Black;
            lblGridSize.Location = new Point(553, 43);
            lblGridSize.Name = "lblGridSize";
            lblGridSize.Size = new Size(189, 46);
            lblGridSize.TabIndex = 11;
            lblGridSize.Text = "Grid Size:";
            lblGridSize.TextAlign = ContentAlignment.TopRight;
            // 
            // lblRound
            // 
            lblRound.BackColor = Color.Transparent;
            lblRound.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRound.ForeColor = Color.Black;
            lblRound.Location = new Point(553, 123);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(191, 45);
            lblRound.TabIndex = 12;
            lblRound.Text = "Round:";
            lblRound.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblScoreBoard
            // 
            lblScoreBoard.BackColor = Color.Transparent;
            lblScoreBoard.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblScoreBoard.ForeColor = Color.Black;
            lblScoreBoard.Location = new Point(685, 214);
            lblScoreBoard.Name = "lblScoreBoard";
            lblScoreBoard.Size = new Size(191, 45);
            lblScoreBoard.TabIndex = 13;
            lblScoreBoard.Text = "Score Board";
            lblScoreBoard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(1030, 689);
            Controls.Add(lblScoreBoard);
            Controls.Add(lblRound);
            Controls.Add(lblGridSize);
            Controls.Add(lblRoundResult);
            Controls.Add(textBox1);
            Controls.Add(btnExit);
            Controls.Add(btnStartNewGame);
            Controls.Add(grpPlayer2);
            Controls.Add(gridSizeComboBox);
            Controls.Add(grpPlayer1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLight;
            Margin = new Padding(4, 5, 4, 5);
            Name = "TicTacToe";
            Text = "Group1_Ridoy_Chan";
            grpPlayer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1Wins).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpPlayer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2Wins).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox gridSizeComboBox;
        private GroupBox grpPlayer1;
        private GroupBox grpPlayer2;
        private Button btnStartNewGame;
        private Button btnExit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label lblRoundResult;
        private Label lblPlayer1Score;
        private Label lblPlayer2Score;
        private Label lblGridSize;
        private Label lblRound;
        private Label lblScoreBoard;
        private PictureBox pictureBoxPlayer1Wins;
        private PictureBox pictureBoxPlayer2Wins;
    }
}
