namespace AnimacijeProg3Seminarska
{
    partial class SemaforForm
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
            this.rdecaGumb = new System.Windows.Forms.Button();
            this.rumenaGumb = new System.Windows.Forms.Button();
            this.zelenaGumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdecaGumb
            // 
            this.rdecaGumb.Location = new System.Drawing.Point(456, 124);
            this.rdecaGumb.Name = "rdecaGumb";
            this.rdecaGumb.Size = new System.Drawing.Size(152, 71);
            this.rdecaGumb.TabIndex = 0;
            this.rdecaGumb.Text = "RDEČA";
            this.rdecaGumb.UseVisualStyleBackColor = true;
            this.rdecaGumb.Click += new System.EventHandler(this.rdecaGumb_Click);
            // 
            // rumenaGumb
            // 
            this.rumenaGumb.Location = new System.Drawing.Point(456, 291);
            this.rumenaGumb.Name = "rumenaGumb";
            this.rumenaGumb.Size = new System.Drawing.Size(152, 71);
            this.rumenaGumb.TabIndex = 1;
            this.rumenaGumb.Text = "RUMENA";
            this.rumenaGumb.UseVisualStyleBackColor = true;
            this.rumenaGumb.Click += new System.EventHandler(this.rumenaGumb_Click);
            // 
            // zelenaGumb
            // 
            this.zelenaGumb.Location = new System.Drawing.Point(456, 458);
            this.zelenaGumb.Name = "zelenaGumb";
            this.zelenaGumb.Size = new System.Drawing.Size(152, 71);
            this.zelenaGumb.TabIndex = 2;
            this.zelenaGumb.Text = "ZELENA";
            this.zelenaGumb.UseVisualStyleBackColor = true;
            this.zelenaGumb.Click += new System.EventHandler(this.zelenaGumb_Click);
            // 
            // SemaforForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1170);
            this.Controls.Add(this.zelenaGumb);
            this.Controls.Add(this.rumenaGumb);
            this.Controls.Add(this.rdecaGumb);
            this.Name = "SemaforForm";
            this.Text = "Semafor";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Semafor_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rdecaGumb;
        private System.Windows.Forms.Button rumenaGumb;
        private System.Windows.Forms.Button zelenaGumb;
    }
}

