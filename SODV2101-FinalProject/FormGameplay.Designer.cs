namespace SODV2101_FinalProject
{
    partial class FormGameplay
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
            components = new System.ComponentModel.Container();
            GameTick = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // GameTick
            // 
            GameTick.Tick += GameTick_Tick;
            // 
            // Gameplayloop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Gameplayloop";
            Text = "Gameplayloop";
            Load += Gameplayloop_Load;
            KeyUp += Gameplayloop_KeyUp;
            PreviewKeyDown += Gameplayloop_PreviewKeyDown;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer GameTick;
    }
}