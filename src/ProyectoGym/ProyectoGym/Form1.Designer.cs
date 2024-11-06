

namespace ProyectoGym
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
            button1 = new Button();
            NameText = new Label();
            BirthText = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(512, 175);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += but1;
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Location = new Point(79, 104);
            NameText.Name = "NameText";
            NameText.Size = new Size(0, 25);
            NameText.TabIndex = 1;
            NameText.Click += label1_Click;
            // 
            // BirthText
            // 
            BirthText.AutoSize = true;
            BirthText.Location = new Point(258, 104);
            BirthText.Name = "BirthText";
            BirthText.Size = new Size(0, 25);
            BirthText.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 468);
            Controls.Add(BirthText);
            Controls.Add(NameText);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void but1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private Button button1;
        private Label NameText;
        private Label BirthText;
    }
}
