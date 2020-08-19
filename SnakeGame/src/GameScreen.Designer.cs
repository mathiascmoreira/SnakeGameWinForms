namespace SnakeGame
{
    partial class GameScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonNewGame = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gameOverMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewGame.Location = new System.Drawing.Point(12, 9);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Padding = new System.Windows.Forms.Padding(5);
            this.buttonNewGame.Size = new System.Drawing.Size(72, 25);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNewGame.Click += new System.EventHandler(this.ButtonNewGame_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPause.Location = new System.Drawing.Point(90, 9);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Padding = new System.Windows.Forms.Padding(5);
            this.buttonPause.Size = new System.Drawing.Size(65, 25);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Pause";
            this.buttonPause.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(161, 9);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(5);
            this.buttonClose.Size = new System.Drawing.Size(45, 25);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // gameOverMessage
            // 
            this.gameOverMessage.AutoSize = true;
            this.gameOverMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverMessage.ForeColor = System.Drawing.Color.Red;
            this.gameOverMessage.Location = new System.Drawing.Point(79, 232);
            this.gameOverMessage.Name = "gameOverMessage";
            this.gameOverMessage.Size = new System.Drawing.Size(314, 63);
            this.gameOverMessage.TabIndex = 3;
            this.gameOverMessage.Text = "Game Over";
            this.gameOverMessage.Visible = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 527);
            this.Controls.Add(this.gameOverMessage);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GameScreen";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label buttonNewGame;
        private System.Windows.Forms.Label buttonPause;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label gameOverMessage;
    }
}

