namespace SODV2101_FinalProject
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
            Startbtn = new Button();
            Controlbtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Startbtn
            // 
            Startbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Startbtn.Location = new Point(333, 146);
            Startbtn.Name = "Startbtn";
            Startbtn.Size = new Size(160, 86);
            Startbtn.TabIndex = 0;
            Startbtn.Text = "Start";
            Startbtn.UseVisualStyleBackColor = true;
            Startbtn.Click += Startbtn_Click;
            // 
            // Controlbtn
            // 
            Controlbtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Controlbtn.Location = new Point(333, 238);
            Controlbtn.Name = "Controlbtn";
            Controlbtn.Size = new Size(160, 86);
            Controlbtn.TabIndex = 1;
            Controlbtn.Text = "Controls";
            Controlbtn.UseVisualStyleBackColor = true;
            Controlbtn.Click += Controlbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(162, 30);
            label1.Name = "label1";
            label1.Size = new Size(495, 65);
            label1.TabIndex = 2;
            label1.Text = "Rapid Space Shooter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Controlbtn);
            Controls.Add(Startbtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Startbtn;
        private Button Controlbtn;
        private Label label1;
    }
}
