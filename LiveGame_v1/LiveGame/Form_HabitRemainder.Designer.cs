
namespace LiveGame
{
    partial class Form_HabitRemainder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HabitRemainder));
            this.button_HabitRemainder_OK = new System.Windows.Forms.Button();
            this.button_HabitRemainder_X = new System.Windows.Forms.Button();
            this.textBox_Processes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_HabitRemainder_OK
            // 
            this.button_HabitRemainder_OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_HabitRemainder_OK.BackgroundImage")));
            this.button_HabitRemainder_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_HabitRemainder_OK.Location = new System.Drawing.Point(206, 65);
            this.button_HabitRemainder_OK.Name = "button_HabitRemainder_OK";
            this.button_HabitRemainder_OK.Size = new System.Drawing.Size(148, 50);
            this.button_HabitRemainder_OK.TabIndex = 2;
            this.button_HabitRemainder_OK.UseVisualStyleBackColor = true;
            this.button_HabitRemainder_OK.Click += new System.EventHandler(this.button_HabitRemainder_OK_Click);
            // 
            // button_HabitRemainder_X
            // 
            this.button_HabitRemainder_X.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_HabitRemainder_X.BackgroundImage")));
            this.button_HabitRemainder_X.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_HabitRemainder_X.Location = new System.Drawing.Point(360, 65);
            this.button_HabitRemainder_X.Name = "button_HabitRemainder_X";
            this.button_HabitRemainder_X.Size = new System.Drawing.Size(78, 50);
            this.button_HabitRemainder_X.TabIndex = 3;
            this.button_HabitRemainder_X.UseVisualStyleBackColor = true;
            this.button_HabitRemainder_X.Click += new System.EventHandler(this.button_HabitRemainder_X_Click);
            // 
            // textBox_Processes
            // 
            this.textBox_Processes.AutoSize = true;
            this.textBox_Processes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Processes.Location = new System.Drawing.Point(10, 10);
            this.textBox_Processes.Name = "textBox_Processes";
            this.textBox_Processes.Size = new System.Drawing.Size(60, 24);
            this.textBox_Processes.TabIndex = 4;
            this.textBox_Processes.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox_Processes);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 48);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button_HabitRemainder_OK);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.button_HabitRemainder_X);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(300, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 120);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 480);
            this.panel3.TabIndex = 7;
            // 
            // Form_HabitRemainder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_HabitRemainder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_HabitRemainder";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_HabitRemainder_OK;
        private System.Windows.Forms.Button button_HabitRemainder_X;
        private System.Windows.Forms.Label textBox_Processes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}