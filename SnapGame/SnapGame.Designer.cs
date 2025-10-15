namespace SnapGame
{
    partial class SnapGame
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
            this.txtNoOfDeck = new System.Windows.Forms.TextBox();
            this.lblNoOfDecks = new System.Windows.Forms.Label();
            this.lblMatchingConditon = new System.Windows.Forms.Label();
            this.ddlMatchingCondition = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtNoOfPlayers = new System.Windows.Forms.TextBox();
            this.lblNoOfPlayers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNoOfDeck
            // 
            this.txtNoOfDeck.Location = new System.Drawing.Point(356, 81);
            this.txtNoOfDeck.Name = "txtNoOfDeck";
            this.txtNoOfDeck.Size = new System.Drawing.Size(168, 22);
            this.txtNoOfDeck.TabIndex = 1;
            // 
            // lblNoOfDecks
            // 
            this.lblNoOfDecks.AutoSize = true;
            this.lblNoOfDecks.Location = new System.Drawing.Point(230, 81);
            this.lblNoOfDecks.Name = "lblNoOfDecks";
            this.lblNoOfDecks.Size = new System.Drawing.Size(86, 16);
            this.lblNoOfDecks.TabIndex = 0;
            this.lblNoOfDecks.Text = "No. Of Decks";
            // 
            // lblMatchingConditon
            // 
            this.lblMatchingConditon.AutoSize = true;
            this.lblMatchingConditon.Location = new System.Drawing.Point(230, 175);
            this.lblMatchingConditon.Name = "lblMatchingConditon";
            this.lblMatchingConditon.Size = new System.Drawing.Size(120, 16);
            this.lblMatchingConditon.TabIndex = 4;
            this.lblMatchingConditon.Text = "Matching Condition";
            // 
            // ddlMatchingCondition
            // 
            this.ddlMatchingCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMatchingCondition.Items.AddRange(new object[] {
            "FaceValue",
            "Suit",
            "Both"});
            this.ddlMatchingCondition.Location = new System.Drawing.Point(356, 171);
            this.ddlMatchingCondition.Name = "ddlMatchingCondition";
            this.ddlMatchingCondition.Size = new System.Drawing.Size(168, 24);
            this.ddlMatchingCondition.TabIndex = 5;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(233, 250);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(271, 36);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(31, 316);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(749, 136);
            this.lblResult.TabIndex = 7;
            // 
            // txtNoOfPlayers
            // 
            this.txtNoOfPlayers.Location = new System.Drawing.Point(356, 125);
            this.txtNoOfPlayers.Name = "txtNoOfPlayers";
            this.txtNoOfPlayers.Size = new System.Drawing.Size(168, 22);
            this.txtNoOfPlayers.TabIndex = 3;
            // 
            // lblNoOfPlayers
            // 
            this.lblNoOfPlayers.AutoSize = true;
            this.lblNoOfPlayers.Location = new System.Drawing.Point(230, 125);
            this.lblNoOfPlayers.Name = "lblNoOfPlayers";
            this.lblNoOfPlayers.Size = new System.Drawing.Size(93, 16);
            this.lblNoOfPlayers.TabIndex = 2;
            this.lblNoOfPlayers.Text = "No. Of Players";
            // 
            // SnapGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.ddlMatchingCondition);
            this.Controls.Add(this.lblMatchingConditon);
            this.Controls.Add(this.lblNoOfPlayers);
            this.Controls.Add(this.lblNoOfDecks);
            this.Controls.Add(this.txtNoOfPlayers);
            this.Controls.Add(this.txtNoOfDeck);
            this.Name = "SnapGame";
            this.Text = "Snap Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoOfDeck;
        private System.Windows.Forms.Label lblNoOfDecks;
        private System.Windows.Forms.Label lblMatchingConditon;
        private System.Windows.Forms.ComboBox ddlMatchingCondition;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtNoOfPlayers;
        private System.Windows.Forms.Label lblNoOfPlayers;
    }
}

