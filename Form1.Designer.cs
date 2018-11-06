namespace HiLow
{
    partial class formOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOne));
            this.picBoxback = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCashtext = new System.Windows.Forms.Label();
            this.lblCashcoin = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.buttonBet5 = new System.Windows.Forms.Button();
            this.buttonBet10 = new System.Windows.Forms.Button();
            this.buttonBet50 = new System.Windows.Forms.Button();
            this.betPottext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBethigh = new System.Windows.Forms.Button();
            this.btnBetlow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxback
            // 
            this.picBoxback.BackColor = System.Drawing.Color.DarkRed;
            this.picBoxback.Location = new System.Drawing.Point(-214, 0);
            this.picBoxback.Name = "picBoxback";
            this.picBoxback.Size = new System.Drawing.Size(1244, 811);
            this.picBoxback.TabIndex = 0;
            this.picBoxback.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(24, 535);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(983, 262);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblCashtext
            // 
            this.lblCashtext.AutoSize = true;
            this.lblCashtext.BackColor = System.Drawing.Color.DarkRed;
            this.lblCashtext.Font = new System.Drawing.Font("High Tower Text", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashtext.ForeColor = System.Drawing.Color.Yellow;
            this.lblCashtext.Location = new System.Drawing.Point(2, 9);
            this.lblCashtext.Name = "lblCashtext";
            this.lblCashtext.Size = new System.Drawing.Size(96, 39);
            this.lblCashtext.TabIndex = 2;
            this.lblCashtext.Text = "Cash:";
            // 
            // lblCashcoin
            // 
            this.lblCashcoin.AutoSize = true;
            this.lblCashcoin.BackColor = System.Drawing.Color.DarkRed;
            this.lblCashcoin.Font = new System.Drawing.Font("LCD", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashcoin.ForeColor = System.Drawing.Color.Yellow;
            this.lblCashcoin.Location = new System.Drawing.Point(88, 9);
            this.lblCashcoin.Name = "lblCashcoin";
            this.lblCashcoin.Size = new System.Drawing.Size(37, 41);
            this.lblCashcoin.TabIndex = 3;
            this.lblCashcoin.Text = "0";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.DarkRed;
            this.lblNumber.Font = new System.Drawing.Font("Bauhaus 93", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.SeaShell;
            this.lblNumber.Location = new System.Drawing.Point(468, 237);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(101, 108);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "0";
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // buttonBet5
            // 
            this.buttonBet5.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBet5.Location = new System.Drawing.Point(78, 604);
            this.buttonBet5.Name = "buttonBet5";
            this.buttonBet5.Size = new System.Drawing.Size(142, 48);
            this.buttonBet5.TabIndex = 5;
            this.buttonBet5.Text = "+ $5";
            this.buttonBet5.UseVisualStyleBackColor = true;
            this.buttonBet5.Click += new System.EventHandler(this.buttonBet5_Click);
            // 
            // buttonBet10
            // 
            this.buttonBet10.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonBet10.Location = new System.Drawing.Point(78, 668);
            this.buttonBet10.Name = "buttonBet10";
            this.buttonBet10.Size = new System.Drawing.Size(142, 48);
            this.buttonBet10.TabIndex = 6;
            this.buttonBet10.Text = "+ $10";
            this.buttonBet10.UseVisualStyleBackColor = true;
            this.buttonBet10.Click += new System.EventHandler(this.buttonBet10_Click);
            // 
            // buttonBet50
            // 
            this.buttonBet50.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonBet50.Location = new System.Drawing.Point(78, 728);
            this.buttonBet50.Name = "buttonBet50";
            this.buttonBet50.Size = new System.Drawing.Size(142, 48);
            this.buttonBet50.TabIndex = 7;
            this.buttonBet50.Text = "+ $50";
            this.buttonBet50.UseVisualStyleBackColor = true;
            this.buttonBet50.Click += new System.EventHandler(this.buttonBet50_Click);
            // 
            // betPottext
            // 
            this.betPottext.AutoSize = true;
            this.betPottext.BackColor = System.Drawing.Color.Green;
            this.betPottext.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betPottext.Location = new System.Drawing.Point(504, 614);
            this.betPottext.Name = "betPottext";
            this.betPottext.Size = new System.Drawing.Size(35, 38);
            this.betPottext.TabIndex = 8;
            this.betPottext.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(411, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 55);
            this.label2.TabIndex = 9;
            this.label2.Text = "BETPOT:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBethigh
            // 
            this.btnBethigh.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBethigh.Location = new System.Drawing.Point(454, 662);
            this.btnBethigh.Name = "btnBethigh";
            this.btnBethigh.Size = new System.Drawing.Size(130, 54);
            this.btnBethigh.TabIndex = 10;
            this.btnBethigh.Text = "Bet High";
            this.btnBethigh.UseVisualStyleBackColor = true;
            this.btnBethigh.Click += new System.EventHandler(this.btnBethigh_Click);
            // 
            // btnBetlow
            // 
            this.btnBetlow.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetlow.Location = new System.Drawing.Point(454, 722);
            this.btnBetlow.Name = "btnBetlow";
            this.btnBetlow.Size = new System.Drawing.Size(130, 54);
            this.btnBetlow.TabIndex = 11;
            this.btnBetlow.Text = "Bet Low";
            this.btnBetlow.UseVisualStyleBackColor = true;
            this.btnBetlow.Click += new System.EventHandler(this.btnBetlow_Click);
            // 
            // formOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1030, 809);
            this.Controls.Add(this.btnBetlow);
            this.Controls.Add(this.btnBethigh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.betPottext);
            this.Controls.Add(this.buttonBet50);
            this.Controls.Add(this.buttonBet10);
            this.Controls.Add(this.buttonBet5);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblCashcoin);
            this.Controls.Add(this.lblCashtext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBoxback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "formOne";
            this.Text = "HiLow! - The Fun Betting Game";
            this.Load += new System.EventHandler(this.formOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCashtext;
        private System.Windows.Forms.Label lblCashcoin;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button buttonBet5;
        private System.Windows.Forms.Button buttonBet10;
        private System.Windows.Forms.Button buttonBet50;
        private System.Windows.Forms.Label betPottext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBethigh;
        private System.Windows.Forms.Button btnBetlow;
    }
}

