
namespace LiveGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_AddEvent = new System.Windows.Forms.Button();
            this.textBox_CurrentTask = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Habits = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_AddEvent
            // 
            this.button_AddEvent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_AddEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddEvent.BackgroundImage")));
            this.button_AddEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddEvent.Location = new System.Drawing.Point(397, 3);
            this.button_AddEvent.Name = "button_AddEvent";
            this.button_AddEvent.Size = new System.Drawing.Size(50, 50);
            this.button_AddEvent.TabIndex = 0;
            this.button_AddEvent.UseVisualStyleBackColor = false;
            this.button_AddEvent.Click += new System.EventHandler(this.button_Icon_Click);
            this.button_AddEvent.MouseLeave += new System.EventHandler(this.button_Icon_MouseLeave);
            this.button_AddEvent.MouseHover += new System.EventHandler(this.button_Icon_MouseHover);
            // 
            // textBox_CurrentTask
            // 
            this.textBox_CurrentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_CurrentTask.Location = new System.Drawing.Point(3, 3);
            this.textBox_CurrentTask.Name = "textBox_CurrentTask";
            this.textBox_CurrentTask.Size = new System.Drawing.Size(160, 22);
            this.textBox_CurrentTask.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button_Habits);
            this.panel1.Controls.Add(this.button_AddEvent);
            this.panel1.Controls.Add(this.textBox_CurrentTask);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 55);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // button_Habits
            // 
            this.button_Habits.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Habits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Habits.BackgroundImage")));
            this.button_Habits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Habits.Location = new System.Drawing.Point(341, 3);
            this.button_Habits.Name = "button_Habits";
            this.button_Habits.Size = new System.Drawing.Size(50, 50);
            this.button_Habits.TabIndex = 3;
            this.button_Habits.UseVisualStyleBackColor = false;
            this.button_Habits.Click += new System.EventHandler(this.button_Habits_Click);
            this.button_Habits.MouseLeave += new System.EventHandler(this.button_Habits_MouseLeave);
            this.button_Habits.MouseHover += new System.EventHandler(this.button_Habits_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(460, 65);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddEvent;
        private System.Windows.Forms.TextBox textBox_CurrentTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Habits;
    }
}

