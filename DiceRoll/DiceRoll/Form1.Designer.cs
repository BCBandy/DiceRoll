namespace DiceRoll
{
    partial class form_stdDist
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
            this.btn_go = new System.Windows.Forms.Button();
            this.txt_numRolls = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lastRoll = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_seed = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txt_numDice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txt_2ndlastroll = new System.Windows.Forms.Label();
            this.cb_linq = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(9, 200);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(94, 36);
            this.btn_go.TabIndex = 1;
            this.btn_go.Text = "GO!";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // txt_numRolls
            // 
            this.txt_numRolls.Location = new System.Drawing.Point(12, 149);
            this.txt_numRolls.Name = "txt_numRolls";
            this.txt_numRolls.Size = new System.Drawing.Size(91, 20);
            this.txt_numRolls.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of rolls:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "d2 N:";
            // 
            // txt_lastRoll
            // 
            this.txt_lastRoll.AutoSize = true;
            this.txt_lastRoll.Location = new System.Drawing.Point(66, 32);
            this.txt_lastRoll.Name = "txt_lastRoll";
            this.txt_lastRoll.Size = new System.Drawing.Size(20, 13);
            this.txt_lastRoll.TabIndex = 6;
            this.txt_lastRoll.Text = "roll";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seed:";
            // 
            // txt_seed
            // 
            this.txt_seed.Location = new System.Drawing.Point(12, 71);
            this.txt_seed.Name = "txt_seed";
            this.txt_seed.Size = new System.Drawing.Size(91, 20);
            this.txt_seed.TabIndex = 9;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(109, 12);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(39, 224);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 10;
            // 
            // txt_numDice
            // 
            this.txt_numDice.Location = new System.Drawing.Point(12, 110);
            this.txt_numDice.Name = "txt_numDice";
            this.txt_numDice.Size = new System.Drawing.Size(91, 20);
            this.txt_numDice.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "# Dice (1-32)";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "d1 N:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_2ndlastroll
            // 
            this.txt_2ndlastroll.AutoSize = true;
            this.txt_2ndlastroll.Location = new System.Drawing.Point(66, 12);
            this.txt_2ndlastroll.Name = "txt_2ndlastroll";
            this.txt_2ndlastroll.Size = new System.Drawing.Size(20, 13);
            this.txt_2ndlastroll.TabIndex = 14;
            this.txt_2ndlastroll.Text = "roll";
            // 
            // cb_linq
            // 
            this.cb_linq.AutoSize = true;
            this.cb_linq.Location = new System.Drawing.Point(15, 175);
            this.cb_linq.Name = "cb_linq";
            this.cb_linq.Size = new System.Drawing.Size(51, 17);
            this.cb_linq.TabIndex = 15;
            this.cb_linq.Text = "LINQ";
            this.cb_linq.UseVisualStyleBackColor = true;
            // 
            // form_stdDist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 248);
            this.Controls.Add(this.cb_linq);
            this.Controls.Add(this.txt_2ndlastroll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_numDice);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txt_seed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_lastRoll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_numRolls);
            this.Controls.Add(this.btn_go);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(0, 20);
            this.Name = "form_stdDist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dice Roll Distribution";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.TextBox txt_numRolls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_lastRoll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_seed;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txt_numDice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label txt_2ndlastroll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_linq;
    }
}

