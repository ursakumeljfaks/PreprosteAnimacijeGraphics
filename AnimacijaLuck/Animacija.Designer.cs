namespace AnimacijaLuck
{
    partial class Animacija
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
            this.startGumb = new System.Windows.Forms.Button();
            this.stopGumb = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startGumb
            // 
            this.startGumb.Location = new System.Drawing.Point(223, 243);
            this.startGumb.Name = "startGumb";
            this.startGumb.Size = new System.Drawing.Size(222, 72);
            this.startGumb.TabIndex = 0;
            this.startGumb.Text = "START";
            this.startGumb.UseVisualStyleBackColor = true;
            this.startGumb.Click += new System.EventHandler(this.startGumb_Click);
            // 
            // stopGumb
            // 
            this.stopGumb.Location = new System.Drawing.Point(596, 243);
            this.stopGumb.Name = "stopGumb";
            this.stopGumb.Size = new System.Drawing.Size(222, 72);
            this.stopGumb.TabIndex = 1;
            this.stopGumb.Text = "STOP";
            this.stopGumb.UseVisualStyleBackColor = true;
            this.stopGumb.Click += new System.EventHandler(this.stopGumb_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Animacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 409);
            this.Controls.Add(this.stopGumb);
            this.Controls.Add(this.startGumb);
            this.Name = "Animacija";
            this.Text = "Animacija lučk";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Lucke_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGumb;
        private System.Windows.Forms.Button stopGumb;
        private System.Windows.Forms.Timer timer;
    }
}

