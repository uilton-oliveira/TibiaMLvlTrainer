namespace TibiaMLVL
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
            this.activeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerInterval = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.timerInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // activeButton
            // 
            this.activeButton.Location = new System.Drawing.Point(12, 62);
            this.activeButton.Name = "activeButton";
            this.activeButton.Size = new System.Drawing.Size(75, 23);
            this.activeButton.TabIndex = 0;
            this.activeButton.Text = "Start";
            this.activeButton.UseVisualStyleBackColor = true;
            this.activeButton.Click += new System.EventHandler(this.activeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(121, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wylaczone";
            // 
            // timerInterval
            // 
            this.timerInterval.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.timerInterval.Location = new System.Drawing.Point(13, 12);
            this.timerInterval.Maximum = new decimal(new int[] {
            360000,
            0,
            0,
            0});
            this.timerInterval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timerInterval.Name = "timerInterval";
            this.timerInterval.Size = new System.Drawing.Size(168, 20);
            this.timerInterval.TabIndex = 2;
            this.timerInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ms";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Manaski";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 92);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timerInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mlvl";
            ((System.ComponentModel.ISupportInitialize)(this.timerInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button activeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown timerInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

