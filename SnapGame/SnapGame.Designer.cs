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
            this.SuspendLayout();
            // 
            // txtNoOfDeck
            // 
            this.txtNoOfDeck.Location = new System.Drawing.Point(356, 81);
            this.txtNoOfDeck.Name = "txtNoOfDeck";
            this.txtNoOfDeck.Size = new System.Drawing.Size(168, 22);
            this.txtNoOfDeck.TabIndex = 0;
            // 
            // lblNoOfDecks
            // 
            this.lblNoOfDecks.AutoSize = true;
            this.lblNoOfDecks.Location = new System.Drawing.Point(230, 81);
            this.lblNoOfDecks.Name = "lblNoOfDecks";
            this.lblNoOfDecks.Size = new System.Drawing.Size(86, 16);
            this.lblNoOfDecks.TabIndex = 1;
            this.lblNoOfDecks.Text = "No. Of Decks";
            // 
            // lblMatchingConditon
            // 
            this.lblMatchingConditon.AutoSize = true;
            this.lblMatchingConditon.Location = new System.Drawing.Point(230, 140);
            this.lblMatchingConditon.Name = "lblMatchingConditon";
            this.lblMatchingConditon.Size = new System.Drawing.Size(120, 16);
            this.lblMatchingConditon.TabIndex = 2;
            this.lblMatchingConditon.Text = "Matching Condition";
            // 
            // ddlMatchingCondition
            // 
            this.ddlMatchingCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMatchingCondition.Items.AddRange(new object[] {
            "FaceValue",
            "Suit",
            "Both"});
            this.ddlMatchingCondition.Location = new System.Drawing.Point(356, 136);
            this.ddlMatchingCondition.Name = "ddlMatchingCondition";
            this.ddlMatchingCondition.Size = new System.Drawing.Size(168, 24);
            this.ddlMatchingCondition.TabIndex = 3;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(233, 208);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(271, 36);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(229, 294);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 6;
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
            this.Controls.Add(this.lblNoOfDecks);
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
    }
}

