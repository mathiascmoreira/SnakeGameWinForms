namespace SnakeGame
{
    partial class Form1
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
            this.gameFieldPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gameFieldPanel
            // 
            this.gameFieldPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameFieldPanel.Location = new System.Drawing.Point(88, 66);
            this.gameFieldPanel.Margin = new System.Windows.Forms.Padding(2);
            this.gameFieldPanel.Name = "gameFieldPanel";
            this.gameFieldPanel.Size = new System.Drawing.Size(544, 559);
            this.gameFieldPanel.TabIndex = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 684);
            this.Controls.Add(this.gameFieldPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel gameFieldPanel;
    }
}

