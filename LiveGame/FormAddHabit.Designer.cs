
namespace LiveGame
{
    partial class FormAddHabit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddHabit));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Msg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_addHabit = new System.Windows.Forms.Button();
            this.comboBox_Frequency = new System.Windows.Forms.ComboBox();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_AutoClose = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Frequency:";
            // 
            // textBox_Msg
            // 
            this.textBox_Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Msg.Location = new System.Drawing.Point(100, 46);
            this.textBox_Msg.Name = "textBox_Msg";
            this.textBox_Msg.Size = new System.Drawing.Size(250, 26);
            this.textBox_Msg.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Message:";
            // 
            // button_addHabit
            // 
            this.button_addHabit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_addHabit.BackgroundImage")));
            this.button_addHabit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_addHabit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_addHabit.Location = new System.Drawing.Point(360, 10);
            this.button_addHabit.Name = "button_addHabit";
            this.button_addHabit.Size = new System.Drawing.Size(60, 60);
            this.button_addHabit.TabIndex = 5;
            this.button_addHabit.UseVisualStyleBackColor = true;
            this.button_addHabit.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Frequency
            // 
            this.comboBox_Frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Frequency.FormattingEnabled = true;
            this.comboBox_Frequency.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Every 3 days"});
            this.comboBox_Frequency.Location = new System.Drawing.Point(100, 12);
            this.comboBox_Frequency.Name = "comboBox_Frequency";
            this.comboBox_Frequency.Size = new System.Drawing.Size(250, 28);
            this.comboBox_Frequency.TabIndex = 10;
            // 
            // textBox_Time
            // 
            this.textBox_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Time.Location = new System.Drawing.Point(100, 78);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.Size = new System.Drawing.Size(250, 26);
            this.textBox_Time.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(50, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time:";
            // 
            // checkBox_AutoClose
            // 
            this.checkBox_AutoClose.AutoSize = true;
            this.checkBox_AutoClose.Checked = true;
            this.checkBox_AutoClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AutoClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_AutoClose.Location = new System.Drawing.Point(16, 160);
            this.checkBox_AutoClose.Name = "checkBox_AutoClose";
            this.checkBox_AutoClose.Size = new System.Drawing.Size(106, 24);
            this.checkBox_AutoClose.TabIndex = 13;
            this.checkBox_AutoClose.Text = "Auto Close";
            this.checkBox_AutoClose.UseVisualStyleBackColor = true;
            // 
            // FormAddHabit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 196);
            this.Controls.Add(this.checkBox_AutoClose);
            this.Controls.Add(this.textBox_Time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Frequency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Msg);
            this.Controls.Add(this.button_addHabit);
            this.Controls.Add(this.label2);
            this.Name = "FormAddHabit";
            this.Text = "FormAddHabit";
            this.Load += new System.EventHandler(this.FormAddHabit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Msg;
        private System.Windows.Forms.Button button_addHabit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Frequency;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_AutoClose;
    }
}