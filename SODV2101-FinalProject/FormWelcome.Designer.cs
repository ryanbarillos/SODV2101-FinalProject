namespace SODV2101_FinalProject
{
    partial class FormWelcome
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
            Startbtn = new Button();
            Controlbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Startbtn
            // 
            Startbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Startbtn.Location = new Point(476, 243);
            Startbtn.Margin = new Padding(4, 5, 4, 5);
            Startbtn.Name = "Startbtn";
            Startbtn.Size = new Size(229, 143);
            Startbtn.TabIndex = 0;
            Startbtn.Text = "Start";
            Startbtn.UseVisualStyleBackColor = true;
            Startbtn.Click += Startbtn_Click;
            // 
            // Controlbtn
            // 
            Controlbtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Controlbtn.Location = new Point(476, 397);
            Controlbtn.Margin = new Padding(4, 5, 4, 5);
            Controlbtn.Name = "Controlbtn";
            Controlbtn.Size = new Size(229, 143);
            Controlbtn.TabIndex = 1;
            Controlbtn.Text = "Controls";
            Controlbtn.UseVisualStyleBackColor = true;
            Controlbtn.Click += Controlbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(208, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(740, 96);
            label1.TabIndex = 2;
            label1.Text = "Rapid Space Shooter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(231, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(690, 36);
            label2.TabIndex = 3;
            label2.Text = "By Emmanuel Padaguan, Nathaniel Gatus, Ryan Barillos";
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1143, 750);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Controlbtn);
            Controls.Add(Startbtn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormWelcome";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Startbtn;
        private Button Controlbtn;
        private Label label1;
        private Label label2;
    }
}
