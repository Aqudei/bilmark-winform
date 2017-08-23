namespace bilmark_winform
{
    partial class MainForm
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textUsername = new MetroFramework.Controls.MetroTextBox();
            this.textPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.textGeneratedToken = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.buttonGetToken = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSendReq = new MetroFramework.Controls.MetroButton();
            this.textResponse = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textBaseUrl = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.textToken = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.comboMethod = new MetroFramework.Controls.MetroComboBox();
            this.textResource = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(739, 446);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.groupBox2);
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(731, 404);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "USER TEST";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.groupBox1, true);
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.buttonGetToken);
            this.groupBox1.Controls.Add(this.textGeneratedToken);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.textUsername);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 302);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication Test";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username:";
            // 
            // textUsername
            // 
            // 
            // 
            // 
            this.textUsername.CustomButton.Image = null;
            this.textUsername.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.textUsername.CustomButton.Name = "";
            this.textUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textUsername.CustomButton.TabIndex = 1;
            this.textUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textUsername.CustomButton.UseSelectable = true;
            this.textUsername.CustomButton.Visible = false;
            this.textUsername.Lines = new string[0];
            this.textUsername.Location = new System.Drawing.Point(88, 42);
            this.textUsername.MaxLength = 32767;
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUsername.SelectedText = "";
            this.textUsername.SelectionLength = 0;
            this.textUsername.SelectionStart = 0;
            this.textUsername.ShortcutsEnabled = true;
            this.textUsername.Size = new System.Drawing.Size(185, 23);
            this.textUsername.TabIndex = 1;
            this.textUsername.UseSelectable = true;
            this.textUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textUsername.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // textPassword
            // 
            // 
            // 
            // 
            this.textPassword.CustomButton.Image = null;
            this.textPassword.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.textPassword.CustomButton.Name = "";
            this.textPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPassword.CustomButton.TabIndex = 1;
            this.textPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPassword.CustomButton.UseSelectable = true;
            this.textPassword.CustomButton.Visible = false;
            this.textPassword.Lines = new string[0];
            this.textPassword.Location = new System.Drawing.Point(88, 85);
            this.textPassword.MaxLength = 32767;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '\0';
            this.textPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.ShortcutsEnabled = true;
            this.textPassword.Size = new System.Drawing.Size(185, 23);
            this.textPassword.TabIndex = 3;
            this.textPassword.UseSelectable = true;
            this.textPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Password:";
            // 
            // textGeneratedToken
            // 
            // 
            // 
            // 
            this.textGeneratedToken.CustomButton.Image = null;
            this.textGeneratedToken.CustomButton.Location = new System.Drawing.Point(99, 2);
            this.textGeneratedToken.CustomButton.Name = "";
            this.textGeneratedToken.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.textGeneratedToken.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textGeneratedToken.CustomButton.TabIndex = 1;
            this.textGeneratedToken.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textGeneratedToken.CustomButton.UseSelectable = true;
            this.textGeneratedToken.CustomButton.Visible = false;
            this.textGeneratedToken.Lines = new string[0];
            this.textGeneratedToken.Location = new System.Drawing.Point(88, 185);
            this.textGeneratedToken.MaxLength = 32767;
            this.textGeneratedToken.Multiline = true;
            this.textGeneratedToken.Name = "textGeneratedToken";
            this.textGeneratedToken.PasswordChar = '\0';
            this.textGeneratedToken.PromptText = "Generated Token";
            this.textGeneratedToken.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textGeneratedToken.SelectedText = "";
            this.textGeneratedToken.SelectionLength = 0;
            this.textGeneratedToken.SelectionStart = 0;
            this.textGeneratedToken.ShortcutsEnabled = true;
            this.textGeneratedToken.Size = new System.Drawing.Size(185, 88);
            this.textGeneratedToken.TabIndex = 5;
            this.textGeneratedToken.UseSelectable = true;
            this.textGeneratedToken.WaterMark = "Generated Token";
            this.textGeneratedToken.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textGeneratedToken.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(37, 185);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Token:";
            // 
            // buttonGetToken
            // 
            this.buttonGetToken.Location = new System.Drawing.Point(198, 114);
            this.buttonGetToken.Name = "buttonGetToken";
            this.buttonGetToken.Size = new System.Drawing.Size(75, 23);
            this.buttonGetToken.TabIndex = 6;
            this.buttonGetToken.Text = "Get Token";
            this.buttonGetToken.UseSelectable = true;
            this.buttonGetToken.Click += new System.EventHandler(this.buttonGetToken_Click);
            // 
            // groupBox2
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.groupBox2, true);
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.textResource);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.comboMethod);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.textToken);
            this.groupBox2.Controls.Add(this.buttonSendReq);
            this.groupBox2.Controls.Add(this.textResponse);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.textBaseUrl);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(318, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 390);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Test";
            // 
            // buttonSendReq
            // 
            this.buttonSendReq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendReq.Location = new System.Drawing.Point(303, 253);
            this.buttonSendReq.Name = "buttonSendReq";
            this.buttonSendReq.Size = new System.Drawing.Size(89, 23);
            this.buttonSendReq.TabIndex = 6;
            this.buttonSendReq.Text = "Send Request";
            this.buttonSendReq.UseSelectable = true;
            this.buttonSendReq.Click += new System.EventHandler(this.buttonSendReq_Click);
            // 
            // textResponse
            // 
            this.textResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textResponse.CustomButton.Image = null;
            this.textResponse.CustomButton.Location = new System.Drawing.Point(209, 2);
            this.textResponse.CustomButton.Name = "";
            this.textResponse.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.textResponse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textResponse.CustomButton.TabIndex = 1;
            this.textResponse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textResponse.CustomButton.UseSelectable = true;
            this.textResponse.CustomButton.Visible = false;
            this.textResponse.Lines = new string[0];
            this.textResponse.Location = new System.Drawing.Point(97, 282);
            this.textResponse.MaxLength = 32767;
            this.textResponse.Multiline = true;
            this.textResponse.Name = "textResponse";
            this.textResponse.PasswordChar = '\0';
            this.textResponse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textResponse.SelectedText = "";
            this.textResponse.SelectionLength = 0;
            this.textResponse.SelectionStart = 0;
            this.textResponse.ShortcutsEnabled = true;
            this.textResponse.Size = new System.Drawing.Size(295, 88);
            this.textResponse.TabIndex = 5;
            this.textResponse.UseSelectable = true;
            this.textResponse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textResponse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(11, 282);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Response:";
            // 
            // textBaseUrl
            // 
            this.textBaseUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBaseUrl.CustomButton.Image = null;
            this.textBaseUrl.CustomButton.Location = new System.Drawing.Point(273, 1);
            this.textBaseUrl.CustomButton.Name = "";
            this.textBaseUrl.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBaseUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBaseUrl.CustomButton.TabIndex = 1;
            this.textBaseUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBaseUrl.CustomButton.UseSelectable = true;
            this.textBaseUrl.CustomButton.Visible = false;
            this.textBaseUrl.Lines = new string[] {
        "http://127.0.0.1:3000"};
            this.textBaseUrl.Location = new System.Drawing.Point(97, 42);
            this.textBaseUrl.MaxLength = 32767;
            this.textBaseUrl.Name = "textBaseUrl";
            this.textBaseUrl.PasswordChar = '\0';
            this.textBaseUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBaseUrl.SelectedText = "";
            this.textBaseUrl.SelectionLength = 0;
            this.textBaseUrl.SelectionStart = 0;
            this.textBaseUrl.ShortcutsEnabled = true;
            this.textBaseUrl.Size = new System.Drawing.Size(295, 23);
            this.textBaseUrl.TabIndex = 1;
            this.textBaseUrl.Text = "http://127.0.0.1:3000";
            this.textBaseUrl.UseSelectable = true;
            this.textBaseUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBaseUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(11, 42);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Base URL:";
            // 
            // textToken
            // 
            // 
            // 
            // 
            this.textToken.CustomButton.Image = null;
            this.textToken.CustomButton.Location = new System.Drawing.Point(209, 2);
            this.textToken.CustomButton.Name = "";
            this.textToken.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.textToken.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textToken.CustomButton.TabIndex = 1;
            this.textToken.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textToken.CustomButton.UseSelectable = true;
            this.textToken.CustomButton.Visible = false;
            this.textToken.Lines = new string[0];
            this.textToken.Location = new System.Drawing.Point(97, 119);
            this.textToken.MaxLength = 32767;
            this.textToken.Multiline = true;
            this.textToken.Name = "textToken";
            this.textToken.PasswordChar = '\0';
            this.textToken.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textToken.SelectedText = "";
            this.textToken.SelectionLength = 0;
            this.textToken.SelectionStart = 0;
            this.textToken.ShortcutsEnabled = true;
            this.textToken.Size = new System.Drawing.Size(295, 88);
            this.textToken.TabIndex = 7;
            this.textToken.UseSelectable = true;
            this.textToken.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textToken.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 218);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Method:";
            // 
            // comboMethod
            // 
            this.comboMethod.FormattingEnabled = true;
            this.comboMethod.ItemHeight = 23;
            this.comboMethod.Location = new System.Drawing.Point(97, 218);
            this.comboMethod.Name = "comboMethod";
            this.comboMethod.Size = new System.Drawing.Size(295, 29);
            this.comboMethod.TabIndex = 9;
            this.comboMethod.UseSelectable = true;
            // 
            // textResource
            // 
            this.textResource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textResource.CustomButton.Image = null;
            this.textResource.CustomButton.Location = new System.Drawing.Point(273, 1);
            this.textResource.CustomButton.Name = "";
            this.textResource.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textResource.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textResource.CustomButton.TabIndex = 1;
            this.textResource.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textResource.CustomButton.UseSelectable = true;
            this.textResource.CustomButton.Visible = false;
            this.textResource.Lines = new string[] {
        "/users"};
            this.textResource.Location = new System.Drawing.Point(97, 71);
            this.textResource.MaxLength = 32767;
            this.textResource.Name = "textResource";
            this.textResource.PasswordChar = '\0';
            this.textResource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textResource.SelectedText = "";
            this.textResource.SelectionLength = 0;
            this.textResource.SelectionStart = 0;
            this.textResource.ShortcutsEnabled = true;
            this.textResource.Size = new System.Drawing.Size(295, 23);
            this.textResource.TabIndex = 11;
            this.textResource.Text = "/users";
            this.textResource.UseSelectable = true;
            this.textResource.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textResource.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(11, 71);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Resource:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(31, 119);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(45, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Token:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 526);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainForm";
            this.Text = "REST REQUEST TEST";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox textUsername;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTextBox textGeneratedToken;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton buttonGetToken;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton buttonSendReq;
        private MetroFramework.Controls.MetroTextBox textResponse;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textBaseUrl;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox textToken;
        private MetroFramework.Controls.MetroComboBox comboMethod;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox textResource;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}

