
namespace Exercice_Dice
{
    partial class Form1
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
            this.Btn_RollDice = new System.Windows.Forms.Button();
            this.lbl_DiceType = new System.Windows.Forms.Label();
            this.lbl_TotalPoints = new System.Windows.Forms.Label();
            this.lbl_Points = new System.Windows.Forms.Label();
            this.pct_DiceImage = new System.Windows.Forms.PictureBox();
            this.lbl_GameTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_DiceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_RollDice
            // 
            this.Btn_RollDice.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Btn_RollDice.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_RollDice.ForeColor = System.Drawing.Color.Lime;
            this.Btn_RollDice.Location = new System.Drawing.Point(154, 274);
            this.Btn_RollDice.Name = "Btn_RollDice";
            this.Btn_RollDice.Size = new System.Drawing.Size(211, 84);
            this.Btn_RollDice.TabIndex = 0;
            this.Btn_RollDice.Text = "Roll Dice";
            this.Btn_RollDice.UseVisualStyleBackColor = false;
            this.Btn_RollDice.Click += new System.EventHandler(this.Btn_RollDice_Click);
            // 
            // lbl_DiceType
            // 
            this.lbl_DiceType.AutoSize = true;
            this.lbl_DiceType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DiceType.ForeColor = System.Drawing.Color.Lime;
            this.lbl_DiceType.Location = new System.Drawing.Point(202, 124);
            this.lbl_DiceType.Name = "lbl_DiceType";
            this.lbl_DiceType.Size = new System.Drawing.Size(119, 32);
            this.lbl_DiceType.TabIndex = 1;
            this.lbl_DiceType.Text = "Dice Type";
            // 
            // lbl_TotalPoints
            // 
            this.lbl_TotalPoints.AutoSize = true;
            this.lbl_TotalPoints.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalPoints.ForeColor = System.Drawing.Color.Lime;
            this.lbl_TotalPoints.Location = new System.Drawing.Point(360, 388);
            this.lbl_TotalPoints.Name = "lbl_TotalPoints";
            this.lbl_TotalPoints.Size = new System.Drawing.Size(117, 25);
            this.lbl_TotalPoints.TabIndex = 2;
            this.lbl_TotalPoints.Text = "Total Points :";
            // 
            // lbl_Points
            // 
            this.lbl_Points.AutoSize = true;
            this.lbl_Points.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Points.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Points.Location = new System.Drawing.Point(471, 389);
            this.lbl_Points.Name = "lbl_Points";
            this.lbl_Points.Size = new System.Drawing.Size(63, 25);
            this.lbl_Points.TabIndex = 3;
            this.lbl_Points.Text = "Points";
            // 
            // pct_DiceImage
            // 
            this.pct_DiceImage.Location = new System.Drawing.Point(210, 159);
            this.pct_DiceImage.Name = "pct_DiceImage";
            this.pct_DiceImage.Size = new System.Drawing.Size(100, 94);
            this.pct_DiceImage.TabIndex = 4;
            this.pct_DiceImage.TabStop = false;
            // 
            // lbl_GameTitle
            // 
            this.lbl_GameTitle.AutoSize = true;
            this.lbl_GameTitle.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_GameTitle.ForeColor = System.Drawing.Color.Lime;
            this.lbl_GameTitle.Location = new System.Drawing.Point(123, 40);
            this.lbl_GameTitle.Name = "lbl_GameTitle";
            this.lbl_GameTitle.Size = new System.Drawing.Size(277, 39);
            this.lbl_GameTitle.TabIndex = 5;
            this.lbl_GameTitle.Text = "Dice Roller Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(546, 424);
            this.Controls.Add(this.lbl_GameTitle);
            this.Controls.Add(this.pct_DiceImage);
            this.Controls.Add(this.lbl_Points);
            this.Controls.Add(this.lbl_TotalPoints);
            this.Controls.Add(this.lbl_DiceType);
            this.Controls.Add(this.Btn_RollDice);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Roller Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_DiceImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_RollDice;
        private System.Windows.Forms.Label lbl_DiceType;
        private System.Windows.Forms.Label lbl_TotalPoints;
        private System.Windows.Forms.Label lbl_Points;
        private System.Windows.Forms.PictureBox pct_DiceImage;
        private System.Windows.Forms.Label lbl_GameTitle;
    }
}

