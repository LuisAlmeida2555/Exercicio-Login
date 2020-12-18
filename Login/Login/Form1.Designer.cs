namespace Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizador";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(15, 36);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 1;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(15, 86);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(100, 20);
            this.txtsenha.TabIndex = 3;
            this.txtsenha.UseSystemPasswordChar = true;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(177, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bttlogin
            // 
            this.bttlogin.Image = global::Login.Properties.Resources.enter1;
            this.bttlogin.Location = new System.Drawing.Point(80, 118);
            this.bttlogin.Name = "bttlogin";
            this.bttlogin.Size = new System.Drawing.Size(35, 35);
            this.bttlogin.TabIndex = 4;
            this.bttlogin.UseVisualStyleBackColor = true;
            this.bttlogin.Click += new System.EventHandler(this.bttlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 165);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttlogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button bttlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

