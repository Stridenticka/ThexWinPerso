namespace WindowsFormsApp1
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
            this.connect = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.photoMitaillette = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.Button();
            this.onephoto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.foldernamebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveTherm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(17, 10);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(93, 38);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(127, 10);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(93, 38);
            this.Disconnect.TabIndex = 1;
            this.Disconnect.Text = "disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // photoMitaillette
            // 
            this.photoMitaillette.Enabled = false;
            this.photoMitaillette.Location = new System.Drawing.Point(548, 154);
            this.photoMitaillette.Name = "photoMitaillette";
            this.photoMitaillette.Size = new System.Drawing.Size(135, 38);
            this.photoMitaillette.TabIndex = 2;
            this.photoMitaillette.Text = "1 photo per 10s";
            this.photoMitaillette.UseVisualStyleBackColor = true;
            this.photoMitaillette.Click += new System.EventHandler(this.Photo1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(475, 22);
            this.textBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 323);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(689, 154);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(115, 38);
            this.stop.TabIndex = 6;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // onephoto
            // 
            this.onephoto.Enabled = false;
            this.onephoto.Location = new System.Drawing.Point(548, 198);
            this.onephoto.Name = "onephoto";
            this.onephoto.Size = new System.Drawing.Size(135, 38);
            this.onephoto.TabIndex = 7;
            this.onephoto.Text = "1 photo ";
            this.onephoto.UseVisualStyleBackColor = true;
            this.onephoto.Click += new System.EventHandler(this.OnePhoto_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(548, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Change save directory";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ChangeDirectory_Click);
            // 
            // foldernamebox
            // 
            this.foldernamebox.Location = new System.Drawing.Point(548, 45);
            this.foldernamebox.Name = "foldernamebox";
            this.foldernamebox.Size = new System.Drawing.Size(314, 22);
            this.foldernamebox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Save directory";
            // 
            // saveTherm
            // 
            this.saveTherm.Location = new System.Drawing.Point(548, 242);
            this.saveTherm.Name = "saveTherm";
            this.saveTherm.Size = new System.Drawing.Size(135, 44);
            this.saveTherm.TabIndex = 11;
            this.saveTherm.Text = "save Temperature";
            this.saveTherm.UseVisualStyleBackColor = true;
            this.saveTherm.Click += new System.EventHandler(this.saveTherm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 507);
            this.Controls.Add(this.saveTherm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foldernamebox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.onephoto);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.photoMitaillette);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button photoMitaillette;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button onephoto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox foldernamebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveTherm;
    }
}

