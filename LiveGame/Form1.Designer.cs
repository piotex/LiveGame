
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
            this.button_Icon = new System.Windows.Forms.Button();
            this.textBox_CurrentTask = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Icon
            // 
            this.button_Icon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Icon.BackgroundImage = global::LiveGame.Properties.Resources.add;
            this.button_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Icon.Location = new System.Drawing.Point(397, 3);
            this.button_Icon.Name = "button_Icon";
            this.button_Icon.Size = new System.Drawing.Size(50, 50);
            this.button_Icon.TabIndex = 0;
            this.button_Icon.UseVisualStyleBackColor = false;
            this.button_Icon.Click += new System.EventHandler(this.button_Icon_Click);
            this.button_Icon.MouseLeave += new System.EventHandler(this.button_Icon_MouseLeave);
            this.button_Icon.MouseHover += new System.EventHandler(this.button_Icon_MouseHover);
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
            this.panel1.Controls.Add(this.button_Icon);
            this.panel1.Controls.Add(this.textBox_CurrentTask);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 55);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Icon;
        private System.Windows.Forms.TextBox textBox_CurrentTask;
        private System.Windows.Forms.Panel panel1;
    }
}

