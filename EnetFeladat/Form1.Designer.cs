namespace EnetFeladat
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
            this.components = new System.ComponentModel.Container();
            this.A_timer = new System.Windows.Forms.Timer(this.components);
            this.B_timer = new System.Windows.Forms.Timer(this.components);
            this.C_timer = new System.Windows.Forms.Timer(this.components);
            this.D_timer = new System.Windows.Forms.Timer(this.components);
            this.shutDown = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A_timer
            // 
            this.A_timer.Enabled = true;
            this.A_timer.Tick += new System.EventHandler(this.A_timer_Tick);
            // 
            // B_timer
            // 
            this.B_timer.Enabled = true;
            this.B_timer.Tick += new System.EventHandler(this.B_timer_Tick);
            // 
            // C_timer
            // 
            this.C_timer.Enabled = true;
            this.C_timer.Tick += new System.EventHandler(this.C_timer_Tick);
            // 
            // D_timer
            // 
            this.D_timer.Enabled = true;
            this.D_timer.Tick += new System.EventHandler(this.D_timer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 37);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 654);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Feladat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer A_timer;
        private System.Windows.Forms.Timer B_timer;
        private System.Windows.Forms.Timer C_timer;
        private System.Windows.Forms.Timer D_timer;
        private System.Windows.Forms.Timer shutDown;
        private System.Windows.Forms.Button button1;
    }
}

