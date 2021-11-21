
namespace OS2_projekt_EmanuelRadotovic
{
    partial class Main_window
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
            this.normalTextLb = new System.Windows.Forms.Label();
            this.normalTextBox = new System.Windows.Forms.TextBox();
            this.loadNTextButton = new System.Windows.Forms.Button();
            this.encryptedTextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.decryptedTextBox = new System.Windows.Forms.TextBox();
            this.genrateKeys = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secretKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.privateKeyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.encrptAESButton = new System.Windows.Forms.Button();
            this.decrptAESButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.genAESbutton = new System.Windows.Forms.Button();
            this.sha1TxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SHA1button = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.verifyButton = new System.Windows.Forms.Button();
            this.signitureTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SignButton = new System.Windows.Forms.Button();
            this.loadDSButton = new System.Windows.Forms.Button();
            this.DStxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // normalTextLb
            // 
            this.normalTextLb.AutoSize = true;
            this.normalTextLb.Location = new System.Drawing.Point(632, 12);
            this.normalTextLb.Name = "normalTextLb";
            this.normalTextLb.Size = new System.Drawing.Size(72, 13);
            this.normalTextLb.TabIndex = 1;
            this.normalTextLb.Text = "Text in txt file:";
            // 
            // normalTextBox
            // 
            this.normalTextBox.Location = new System.Drawing.Point(635, 28);
            this.normalTextBox.Multiline = true;
            this.normalTextBox.Name = "normalTextBox";
            this.normalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.normalTextBox.Size = new System.Drawing.Size(593, 138);
            this.normalTextBox.TabIndex = 2;
            // 
            // loadNTextButton
            // 
            this.loadNTextButton.Location = new System.Drawing.Point(876, 172);
            this.loadNTextButton.Name = "loadNTextButton";
            this.loadNTextButton.Size = new System.Drawing.Size(126, 37);
            this.loadNTextButton.TabIndex = 3;
            this.loadNTextButton.Text = "Load text";
            this.loadNTextButton.UseVisualStyleBackColor = true;
            this.loadNTextButton.Click += new System.EventHandler(this.loadNTextButton_Click);
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(635, 307);
            this.encryptedTextBox.Multiline = true;
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.encryptedTextBox.Size = new System.Drawing.Size(235, 276);
            this.encryptedTextBox.TabIndex = 4;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(6, 24);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(114, 36);
            this.encryptButton.TabIndex = 5;
            this.encryptButton.Text = "<-Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(6, 66);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(114, 36);
            this.decryptButton.TabIndex = 6;
            this.decryptButton.Text = "Decrypt->";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.Location = new System.Drawing.Point(1008, 307);
            this.decryptedTextBox.Multiline = true;
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.decryptedTextBox.Size = new System.Drawing.Size(220, 276);
            this.decryptedTextBox.TabIndex = 7;
            // 
            // genrateKeys
            // 
            this.genrateKeys.Location = new System.Drawing.Point(214, 575);
            this.genrateKeys.Name = "genrateKeys";
            this.genrateKeys.Size = new System.Drawing.Size(126, 37);
            this.genrateKeys.TabIndex = 8;
            this.genrateKeys.Text = "Generate RSA keys";
            this.genrateKeys.UseVisualStyleBackColor = true;
            this.genrateKeys.Click += new System.EventHandler(this.genrateKeys_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secretKeyTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 168);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AES key";
            // 
            // secretKeyTextBox
            // 
            this.secretKeyTextBox.Location = new System.Drawing.Point(9, 39);
            this.secretKeyTextBox.Multiline = true;
            this.secretKeyTextBox.Name = "secretKeyTextBox";
            this.secretKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.secretKeyTextBox.Size = new System.Drawing.Size(553, 115);
            this.secretKeyTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secret Key";
            // 
            // privateKeyTextBox
            // 
            this.privateKeyTextBox.Location = new System.Drawing.Point(9, 202);
            this.privateKeyTextBox.Multiline = true;
            this.privateKeyTextBox.Name = "privateKeyTextBox";
            this.privateKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.privateKeyTextBox.Size = new System.Drawing.Size(553, 115);
            this.privateKeyTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Private Key";
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Location = new System.Drawing.Point(9, 40);
            this.publicKeyTextBox.Multiline = true;
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.publicKeyTextBox.Size = new System.Drawing.Size(553, 115);
            this.publicKeyTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Public Key";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.encryptButton);
            this.groupBox2.Controls.Add(this.decryptButton);
            this.groupBox2.Location = new System.Drawing.Point(876, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 112);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asymmetric(RSA)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.encrptAESButton);
            this.groupBox3.Controls.Add(this.decrptAESButton);
            this.groupBox3.Location = new System.Drawing.Point(876, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 112);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symmetric(AES)";
            // 
            // encrptAESButton
            // 
            this.encrptAESButton.Location = new System.Drawing.Point(6, 24);
            this.encrptAESButton.Name = "encrptAESButton";
            this.encrptAESButton.Size = new System.Drawing.Size(114, 36);
            this.encrptAESButton.TabIndex = 5;
            this.encrptAESButton.Text = "<-Encrypt";
            this.encrptAESButton.UseVisualStyleBackColor = true;
            this.encrptAESButton.Click += new System.EventHandler(this.encrptAESButton_Click);
            // 
            // decrptAESButton
            // 
            this.decrptAESButton.Location = new System.Drawing.Point(6, 66);
            this.decrptAESButton.Name = "decrptAESButton";
            this.decrptAESButton.Size = new System.Drawing.Size(114, 36);
            this.decrptAESButton.TabIndex = 6;
            this.decrptAESButton.Text = "Decrypt->";
            this.decrptAESButton.UseVisualStyleBackColor = true;
            this.decrptAESButton.Click += new System.EventHandler(this.decrptAESButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Encrypted text:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1005, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Decrypted text:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.publicKeyTextBox);
            this.groupBox4.Controls.Add(this.privateKeyTextBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(12, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(572, 330);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RSA keys";
            // 
            // genAESbutton
            // 
            this.genAESbutton.Location = new System.Drawing.Point(214, 186);
            this.genAESbutton.Name = "genAESbutton";
            this.genAESbutton.Size = new System.Drawing.Size(126, 37);
            this.genAESbutton.TabIndex = 14;
            this.genAESbutton.Text = "Generate AES key";
            this.genAESbutton.UseVisualStyleBackColor = true;
            this.genAESbutton.Click += new System.EventHandler(this.genAESbutton_Click);
            // 
            // sha1TxtBox
            // 
            this.sha1TxtBox.Location = new System.Drawing.Point(635, 239);
            this.sha1TxtBox.Name = "sha1TxtBox";
            this.sha1TxtBox.Size = new System.Drawing.Size(461, 20);
            this.sha1TxtBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Message digest(SHA-1):";
            // 
            // SHA1button
            // 
            this.SHA1button.Location = new System.Drawing.Point(1102, 230);
            this.SHA1button.Name = "SHA1button";
            this.SHA1button.Size = new System.Drawing.Size(126, 37);
            this.SHA1button.TabIndex = 17;
            this.SHA1button.Text = "Hash text";
            this.SHA1button.UseVisualStyleBackColor = true;
            this.SHA1button.Click += new System.EventHandler(this.SHA1button_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.verifyButton);
            this.groupBox5.Controls.Add(this.signitureTxtBox);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.SignButton);
            this.groupBox5.Controls.Add(this.loadDSButton);
            this.groupBox5.Controls.Add(this.DStxtBox);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(1276, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(219, 525);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Digital signiture";
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(66, 478);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(94, 37);
            this.verifyButton.TabIndex = 22;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // signitureTxtBox
            // 
            this.signitureTxtBox.Location = new System.Drawing.Point(9, 339);
            this.signitureTxtBox.Multiline = true;
            this.signitureTxtBox.Name = "signitureTxtBox";
            this.signitureTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.signitureTxtBox.Size = new System.Drawing.Size(204, 68);
            this.signitureTxtBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Signiture:";
            // 
            // SignButton
            // 
            this.SignButton.Location = new System.Drawing.Point(119, 413);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(94, 37);
            this.SignButton.TabIndex = 19;
            this.SignButton.Text = "Sign";
            this.SignButton.UseVisualStyleBackColor = true;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // loadDSButton
            // 
            this.loadDSButton.Location = new System.Drawing.Point(9, 413);
            this.loadDSButton.Name = "loadDSButton";
            this.loadDSButton.Size = new System.Drawing.Size(94, 37);
            this.loadDSButton.TabIndex = 18;
            this.loadDSButton.Text = "Load text";
            this.loadDSButton.UseVisualStyleBackColor = true;
            this.loadDSButton.Click += new System.EventHandler(this.loadDSButton_Click);
            // 
            // DStxtBox
            // 
            this.DStxtBox.Location = new System.Drawing.Point(9, 39);
            this.DStxtBox.Multiline = true;
            this.DStxtBox.Name = "DStxtBox";
            this.DStxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DStxtBox.Size = new System.Drawing.Size(204, 274);
            this.DStxtBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Text in txt file:";
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 620);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.SHA1button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sha1TxtBox);
            this.Controls.Add(this.genAESbutton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.genrateKeys);
            this.Controls.Add(this.decryptedTextBox);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.loadNTextButton);
            this.Controls.Add(this.normalTextBox);
            this.Controls.Add(this.normalTextLb);
            this.Name = "Main_window";
            this.Text = "Sustav za kriptiranje teksta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_window_FormClosing);
            this.Load += new System.EventHandler(this.Main_window_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label normalTextLb;
        private System.Windows.Forms.TextBox normalTextBox;
        private System.Windows.Forms.Button loadNTextButton;
        private System.Windows.Forms.TextBox encryptedTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox decryptedTextBox;
        private System.Windows.Forms.Button genrateKeys;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox privateKeyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secretKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button encrptAESButton;
        private System.Windows.Forms.Button decrptAESButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button genAESbutton;
        private System.Windows.Forms.TextBox sha1TxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SHA1button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox DStxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SignButton;
        private System.Windows.Forms.Button loadDSButton;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.TextBox signitureTxtBox;
        private System.Windows.Forms.Label label8;
    }
}

