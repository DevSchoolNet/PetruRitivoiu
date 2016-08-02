namespace ing_tema1_4
{
    partial class Form2
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
            this.label_numeRobot = new System.Windows.Forms.Label();
            this.textBox_numeRobot = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_numeRobot
            // 
            this.label_numeRobot.AutoSize = true;
            this.label_numeRobot.Location = new System.Drawing.Point(103, 68);
            this.label_numeRobot.Name = "label_numeRobot";
            this.label_numeRobot.Size = new System.Drawing.Size(67, 13);
            this.label_numeRobot.TabIndex = 0;
            this.label_numeRobot.Text = "Nume Robot";
            // 
            // textBox_numeRobot
            // 
            this.textBox_numeRobot.Location = new System.Drawing.Point(85, 84);
            this.textBox_numeRobot.Name = "textBox_numeRobot";
            this.textBox_numeRobot.Size = new System.Drawing.Size(100, 20);
            this.textBox_numeRobot.TabIndex = 1;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(95, 134);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Deplasare";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_numeRobot);
            this.Controls.Add(this.label_numeRobot);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_numeRobot;
        private System.Windows.Forms.TextBox textBox_numeRobot;
        private System.Windows.Forms.Button button_submit;
    }
}