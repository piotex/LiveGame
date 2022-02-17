
namespace LiveGame
{
    partial class FormAddManuallyEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddManuallyEvent));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_AutoClose = new System.Windows.Forms.CheckBox();
            this.checkBox_AddBackward = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(100, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(100, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time [min] :";
            // 
            // checkBox_AutoClose
            // 
            this.checkBox_AutoClose.AutoSize = true;
            this.checkBox_AutoClose.Checked = true;
            this.checkBox_AutoClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AutoClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_AutoClose.Location = new System.Drawing.Point(14, 154);
            this.checkBox_AutoClose.Name = "checkBox_AutoClose";
            this.checkBox_AutoClose.Size = new System.Drawing.Size(106, 24);
            this.checkBox_AutoClose.TabIndex = 5;
            this.checkBox_AutoClose.Text = "Auto Close";
            this.checkBox_AutoClose.UseVisualStyleBackColor = true;
            // 
            // checkBox_AddBackward
            // 
            this.checkBox_AddBackward.AutoSize = true;
            this.checkBox_AddBackward.Checked = true;
            this.checkBox_AddBackward.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AddBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_AddBackward.Location = new System.Drawing.Point(14, 124);
            this.checkBox_AddBackward.Name = "checkBox_AddBackward";
            this.checkBox_AddBackward.Size = new System.Drawing.Size(131, 24);
            this.checkBox_AddBackward.TabIndex = 6;
            this.checkBox_AddBackward.Text = "Add Backward";
            this.checkBox_AddBackward.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(360, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddManuallyEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 186);
            this.Controls.Add(this.checkBox_AddBackward);
            this.Controls.Add(this.checkBox_AutoClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormAddManuallyEvent";
            this.Text = "FormAddManuallyEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_AutoClose;
        private System.Windows.Forms.CheckBox checkBox_AddBackward;
    }
}