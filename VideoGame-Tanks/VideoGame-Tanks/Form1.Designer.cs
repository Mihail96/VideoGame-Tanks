namespace VideoGame_Tanks
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
            this.components = new System.ComponentModel.Container();
            this.P1U = new System.Windows.Forms.Button();
            this.P1D = new System.Windows.Forms.Button();
            this.P1L = new System.Windows.Forms.Button();
            this.P1R = new System.Windows.Forms.Button();
            this.P1F = new System.Windows.Forms.Button();
            this.P2U = new System.Windows.Forms.Button();
            this.P2D = new System.Windows.Forms.Button();
            this.P2L = new System.Windows.Forms.Button();
            this.P2R = new System.Windows.Forms.Button();
            this.P2F = new System.Windows.Forms.Button();
            this.P1 = new System.Windows.Forms.Panel();
            this.P2 = new System.Windows.Forms.Panel();
            this.DzidVG = new System.Windows.Forms.Panel();
            this.DzidHG = new System.Windows.Forms.Panel();
            this.DzidHD = new System.Windows.Forms.Panel();
            this.DzidVD = new System.Windows.Forms.Panel();
            this.DzidVL = new System.Windows.Forms.Panel();
            this.DzidVR = new System.Windows.Forms.Panel();
            this.InfoWin = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SP1 = new System.Windows.Forms.Label();
            this.SP2 = new System.Windows.Forms.Label();
            this.Keyboard = new System.Windows.Forms.Button();
            this.TT = new System.Windows.Forms.Label();
            this.WhiteB = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // P1U
            // 
            this.P1U.BackColor = System.Drawing.Color.Blue;
            this.P1U.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.P1U.FlatAppearance.BorderSize = 0;
            this.P1U.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.P1U.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.P1U.Location = new System.Drawing.Point(0, 0);
            this.P1U.Name = "P1U";
            this.P1U.Size = new System.Drawing.Size(75, 23);
            this.P1U.TabIndex = 0;
            this.P1U.Text = "Up";
            this.P1U.UseVisualStyleBackColor = false;
            this.P1U.Click += new System.EventHandler(this.P1U_Click);
            // 
            // P1D
            // 
            this.P1D.BackColor = System.Drawing.Color.Blue;
            this.P1D.Location = new System.Drawing.Point(0, 29);
            this.P1D.Name = "P1D";
            this.P1D.Size = new System.Drawing.Size(75, 23);
            this.P1D.TabIndex = 1;
            this.P1D.Text = "Down";
            this.P1D.UseVisualStyleBackColor = false;
            // 
            // P1L
            // 
            this.P1L.BackColor = System.Drawing.Color.Blue;
            this.P1L.Location = new System.Drawing.Point(0, 58);
            this.P1L.Name = "P1L";
            this.P1L.Size = new System.Drawing.Size(75, 23);
            this.P1L.TabIndex = 2;
            this.P1L.Text = "Left";
            this.P1L.UseVisualStyleBackColor = false;
            // 
            // P1R
            // 
            this.P1R.BackColor = System.Drawing.Color.Blue;
            this.P1R.Location = new System.Drawing.Point(0, 87);
            this.P1R.Name = "P1R";
            this.P1R.Size = new System.Drawing.Size(75, 23);
            this.P1R.TabIndex = 3;
            this.P1R.Text = "Right";
            this.P1R.UseVisualStyleBackColor = false;
            // 
            // P1F
            // 
            this.P1F.BackColor = System.Drawing.Color.Blue;
            this.P1F.Location = new System.Drawing.Point(0, 116);
            this.P1F.Name = "P1F";
            this.P1F.Size = new System.Drawing.Size(75, 23);
            this.P1F.TabIndex = 4;
            this.P1F.Text = "Fire!";
            this.P1F.UseVisualStyleBackColor = false;
            // 
            // P2U
            // 
            this.P2U.BackColor = System.Drawing.Color.Red;
            this.P2U.Location = new System.Drawing.Point(608, 0);
            this.P2U.Name = "P2U";
            this.P2U.Size = new System.Drawing.Size(75, 23);
            this.P2U.TabIndex = 5;
            this.P2U.Text = "Up";
            this.P2U.UseVisualStyleBackColor = false;
            // 
            // P2D
            // 
            this.P2D.BackColor = System.Drawing.Color.Red;
            this.P2D.Location = new System.Drawing.Point(608, 29);
            this.P2D.Name = "P2D";
            this.P2D.Size = new System.Drawing.Size(75, 23);
            this.P2D.TabIndex = 6;
            this.P2D.Text = "Down";
            this.P2D.UseVisualStyleBackColor = false;
            // 
            // P2L
            // 
            this.P2L.BackColor = System.Drawing.Color.Red;
            this.P2L.Location = new System.Drawing.Point(608, 58);
            this.P2L.Name = "P2L";
            this.P2L.Size = new System.Drawing.Size(75, 23);
            this.P2L.TabIndex = 7;
            this.P2L.Text = "Left";
            this.P2L.UseVisualStyleBackColor = false;
            // 
            // P2R
            // 
            this.P2R.BackColor = System.Drawing.Color.Red;
            this.P2R.Location = new System.Drawing.Point(608, 87);
            this.P2R.Name = "P2R";
            this.P2R.Size = new System.Drawing.Size(75, 23);
            this.P2R.TabIndex = 8;
            this.P2R.Text = "Right";
            this.P2R.UseVisualStyleBackColor = false;
            // 
            // P2F
            // 
            this.P2F.BackColor = System.Drawing.Color.Red;
            this.P2F.Location = new System.Drawing.Point(608, 116);
            this.P2F.Name = "P2F";
            this.P2F.Size = new System.Drawing.Size(75, 23);
            this.P2F.TabIndex = 9;
            this.P2F.Text = "Fire!";
            this.P2F.UseVisualStyleBackColor = false;
            // 
            // P1
            // 
            this.P1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.P1.BackColor = System.Drawing.Color.Blue;
            this.P1.Location = new System.Drawing.Point(84, 29);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(39, 38);
            this.P1.TabIndex = 11;
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.Color.Red;
            this.P2.Location = new System.Drawing.Point(129, 29);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(39, 38);
            this.P2.TabIndex = 12;
            // 
            // DzidVG
            // 
            this.DzidVG.BackColor = System.Drawing.Color.Black;
            this.DzidVG.Location = new System.Drawing.Point(174, 29);
            this.DzidVG.Name = "DzidVG";
            this.DzidVG.Size = new System.Drawing.Size(39, 38);
            this.DzidVG.TabIndex = 13;
            // 
            // DzidHG
            // 
            this.DzidHG.BackColor = System.Drawing.Color.Black;
            this.DzidHG.Location = new System.Drawing.Point(219, 29);
            this.DzidHG.Name = "DzidHG";
            this.DzidHG.Size = new System.Drawing.Size(39, 38);
            this.DzidHG.TabIndex = 14;
            // 
            // DzidHD
            // 
            this.DzidHD.BackColor = System.Drawing.Color.Black;
            this.DzidHD.Location = new System.Drawing.Point(264, 29);
            this.DzidHD.Name = "DzidHD";
            this.DzidHD.Size = new System.Drawing.Size(39, 38);
            this.DzidHD.TabIndex = 15;
            // 
            // DzidVD
            // 
            this.DzidVD.BackColor = System.Drawing.Color.Black;
            this.DzidVD.Location = new System.Drawing.Point(309, 29);
            this.DzidVD.Name = "DzidVD";
            this.DzidVD.Size = new System.Drawing.Size(39, 38);
            this.DzidVD.TabIndex = 16;
            // 
            // DzidVL
            // 
            this.DzidVL.BackColor = System.Drawing.Color.Black;
            this.DzidVL.Location = new System.Drawing.Point(354, 29);
            this.DzidVL.Name = "DzidVL";
            this.DzidVL.Size = new System.Drawing.Size(39, 38);
            this.DzidVL.TabIndex = 16;
            // 
            // DzidVR
            // 
            this.DzidVR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DzidVR.BackColor = System.Drawing.Color.Black;
            this.DzidVR.Location = new System.Drawing.Point(399, 29);
            this.DzidVR.Name = "DzidVR";
            this.DzidVR.Size = new System.Drawing.Size(39, 38);
            this.DzidVR.TabIndex = 16;
            // 
            // InfoWin
            // 
            this.InfoWin.AutoSize = true;
            this.InfoWin.Location = new System.Drawing.Point(138, 5);
            this.InfoWin.Name = "InfoWin";
            this.InfoWin.Size = new System.Drawing.Size(44, 13);
            this.InfoWin.TabIndex = 17;
            this.InfoWin.Text = "InfoWin";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(84, 73);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 18;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(165, 73);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 19;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SP1
            // 
            this.SP1.AutoSize = true;
            this.SP1.Location = new System.Drawing.Point(195, 5);
            this.SP1.Name = "SP1";
            this.SP1.Size = new System.Drawing.Size(48, 13);
            this.SP1.TabIndex = 20;
            this.SP1.Text = "ScoreP1";
            // 
            // SP2
            // 
            this.SP2.AutoSize = true;
            this.SP2.Location = new System.Drawing.Point(249, 5);
            this.SP2.Name = "SP2";
            this.SP2.Size = new System.Drawing.Size(48, 13);
            this.SP2.TabIndex = 21;
            this.SP2.Text = "ScoreP2";
            // 
            // Keyboard
            // 
            this.Keyboard.Location = new System.Drawing.Point(246, 73);
            this.Keyboard.Name = "Keyboard";
            this.Keyboard.Size = new System.Drawing.Size(75, 23);
            this.Keyboard.TabIndex = 22;
            this.Keyboard.Text = "Keyboard";
            this.Keyboard.UseVisualStyleBackColor = true;
            // 
            // TT
            // 
            this.TT.AutoSize = true;
            this.TT.Location = new System.Drawing.Point(306, 5);
            this.TT.Name = "TT";
            this.TT.Size = new System.Drawing.Size(43, 13);
            this.TT.TabIndex = 23;
            this.TT.Text = "ToolTip";
            // 
            // WhiteB
            // 
            this.WhiteB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WhiteB.BackColor = System.Drawing.Color.Lime;
            this.WhiteB.Location = new System.Drawing.Point(444, 29);
            this.WhiteB.Name = "WhiteB";
            this.WhiteB.Size = new System.Drawing.Size(39, 38);
            this.WhiteB.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(695, 491);
            this.Controls.Add(this.WhiteB);
            this.Controls.Add(this.TT);
            this.Controls.Add(this.Keyboard);
            this.Controls.Add(this.SP2);
            this.Controls.Add(this.SP1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.InfoWin);
            this.Controls.Add(this.DzidVR);
            this.Controls.Add(this.DzidVL);
            this.Controls.Add(this.DzidVD);
            this.Controls.Add(this.DzidHD);
            this.Controls.Add(this.DzidHG);
            this.Controls.Add(this.DzidVG);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.P2F);
            this.Controls.Add(this.P2R);
            this.Controls.Add(this.P2L);
            this.Controls.Add(this.P2D);
            this.Controls.Add(this.P2U);
            this.Controls.Add(this.P1F);
            this.Controls.Add(this.P1R);
            this.Controls.Add(this.P1L);
            this.Controls.Add(this.P1D);
            this.Controls.Add(this.P1U);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button P1U;
        private System.Windows.Forms.Button P1D;
        private System.Windows.Forms.Button P1L;
        private System.Windows.Forms.Button P1R;
        private System.Windows.Forms.Button P1F;
        private System.Windows.Forms.Button P2U;
        private System.Windows.Forms.Button P2D;
        private System.Windows.Forms.Button P2L;
        private System.Windows.Forms.Button P2R;
        private System.Windows.Forms.Button P2F;
        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Panel P2;
        private System.Windows.Forms.Panel DzidVG;
        private System.Windows.Forms.Panel DzidHG;
        private System.Windows.Forms.Panel DzidHD;
        private System.Windows.Forms.Panel DzidVD;
        private System.Windows.Forms.Panel DzidVL;
        private System.Windows.Forms.Panel DzidVR;
        private System.Windows.Forms.Label InfoWin;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label SP1;
        private System.Windows.Forms.Label SP2;
        private System.Windows.Forms.Button Keyboard;
        private System.Windows.Forms.Label TT;
        private System.Windows.Forms.Panel WhiteB;
        private System.Windows.Forms.Timer timer1;
    }
}

