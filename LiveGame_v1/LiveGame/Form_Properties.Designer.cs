
namespace LiveGame
{
    partial class Form_Properties
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
            this.textBox_Processes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Processes
            // 
            this.textBox_Processes.Location = new System.Drawing.Point(0, 0);
            this.textBox_Processes.Multiline = true;
            this.textBox_Processes.Name = "textBox_Processes";
            this.textBox_Processes.Size = new System.Drawing.Size(221, 358);
            this.textBox_Processes.TabIndex = 0;
            this.textBox_Processes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form_Properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Processes);
            this.Name = "Form_Properties";
            this.Text = "Form_Properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Processes;
    }
}