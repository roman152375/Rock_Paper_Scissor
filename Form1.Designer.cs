namespace Rock_Paper_Scissor
{
    partial class Rock_Paper_Scissor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rock_Paper_Scissor));
            this.btnRock = new System.Windows.Forms.PictureBox();
            this.btnPaper = new System.Windows.Forms.PictureBox();
            this.btnScissor = new System.Windows.Forms.PictureBox();
            this.computerR = new System.Windows.Forms.PictureBox();
            this.computerP = new System.Windows.Forms.PictureBox();
            this.computerS = new System.Windows.Forms.PictureBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt1score = new System.Windows.Forms.TextBox();
            this.txt2score = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRock.BackgroundImage")));
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRock.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRock.ErrorImage")));
            this.btnRock.Location = new System.Drawing.Point(41, 49);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(88, 73);
            this.btnRock.TabIndex = 0;
            this.btnRock.TabStop = false;
            this.btnRock.WaitOnLoad = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaper.BackgroundImage")));
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaper.Location = new System.Drawing.Point(41, 176);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(88, 70);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.TabStop = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScissor.BackgroundImage")));
            this.btnScissor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScissor.Location = new System.Drawing.Point(41, 300);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(88, 72);
            this.btnScissor.TabIndex = 2;
            this.btnScissor.TabStop = false;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // computerR
            // 
            this.computerR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("computerR.BackgroundImage")));
            this.computerR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.computerR.Location = new System.Drawing.Point(626, 49);
            this.computerR.Name = "computerR";
            this.computerR.Size = new System.Drawing.Size(96, 73);
            this.computerR.TabIndex = 3;
            this.computerR.TabStop = false;
            // 
            // computerP
            // 
            this.computerP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("computerP.BackgroundImage")));
            this.computerP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.computerP.Location = new System.Drawing.Point(626, 176);
            this.computerP.Name = "computerP";
            this.computerP.Size = new System.Drawing.Size(96, 70);
            this.computerP.TabIndex = 4;
            this.computerP.TabStop = false;
            // 
            // computerS
            // 
            this.computerS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("computerS.BackgroundImage")));
            this.computerS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.computerS.Location = new System.Drawing.Point(626, 300);
            this.computerS.Name = "computerS";
            this.computerS.Size = new System.Drawing.Size(96, 72);
            this.computerS.TabIndex = 5;
            this.computerS.TabStop = false;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtResult.Location = new System.Drawing.Point(256, 351);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(257, 20);
            this.txtResult.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(626, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Computer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(256, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Player1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(256, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Computer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt1score
            // 
            this.txt1score.Location = new System.Drawing.Point(326, 72);
            this.txt1score.Name = "txt1score";
            this.txt1score.Size = new System.Drawing.Size(39, 20);
            this.txt1score.TabIndex = 11;
            this.txt1score.TextChanged += new System.EventHandler(this.txt1score_TextChanged);
            // 
            // txt2score
            // 
            this.txt2score.Location = new System.Drawing.Point(326, 108);
            this.txt2score.Name = "txt2score";
            this.txt2score.Size = new System.Drawing.Size(39, 20);
            this.txt2score.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(647, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Quit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rock_Paper_Scissor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt2score);
            this.Controls.Add(this.txt1score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.computerS);
            this.Controls.Add(this.computerP);
            this.Controls.Add(this.computerR);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Rock_Paper_Scissor";
            this.Text = "Rock_Paper_Scissor";
            ((System.ComponentModel.ISupportInitialize)(this.btnRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnRock;
        private System.Windows.Forms.PictureBox btnPaper;
        private System.Windows.Forms.PictureBox btnScissor;
        private System.Windows.Forms.PictureBox computerR;
        private System.Windows.Forms.PictureBox computerP;
        private System.Windows.Forms.PictureBox computerS;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt1score;
        private System.Windows.Forms.TextBox txt2score;
        private System.Windows.Forms.Button button1;
    }
}

