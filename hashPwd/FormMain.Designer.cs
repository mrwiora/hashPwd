namespace hashPwd
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.comboBoxDouble = new System.Windows.Forms.ComboBox();
            this.labelDouble = new System.Windows.Forms.Label();
            this.labelHashType = new System.Windows.Forms.Label();
            this.labelHashedValue = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelSalt = new System.Windows.Forms.Label();
            this.textBoxSalt = new System.Windows.Forms.TextBox();
            this.checkBoxHideHash = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxHashType = new System.Windows.Forms.ComboBox();
            this.progressBarTimeLeft = new System.Windows.Forms.ProgressBar();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            this.textBoxHashValue = new System.Windows.Forms.TextBox();
            this.buttonVerification = new System.Windows.Forms.Button();
            this.checkBoxClearInput = new System.Windows.Forms.CheckBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.checkBoxAppend = new System.Windows.Forms.CheckBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxControls.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDouble
            // 
            this.comboBoxDouble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxDouble, "comboBoxDouble");
            this.comboBoxDouble.FormattingEnabled = true;
            this.comboBoxDouble.Name = "comboBoxDouble";
            this.comboBoxDouble.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDoubleSelectedIndexChanged);
            // 
            // labelDouble
            // 
            resources.ApplyResources(this.labelDouble, "labelDouble");
            this.labelDouble.Name = "labelDouble";
            // 
            // labelHashType
            // 
            resources.ApplyResources(this.labelHashType, "labelHashType");
            this.labelHashType.Name = "labelHashType";
            // 
            // labelHashedValue
            // 
            resources.ApplyResources(this.labelHashedValue, "labelHashedValue");
            this.labelHashedValue.Name = "labelHashedValue";
            // 
            // labelPassword
            // 
            resources.ApplyResources(this.labelPassword, "labelPassword");
            this.labelPassword.Name = "labelPassword";
            // 
            // labelSalt
            // 
            resources.ApplyResources(this.labelSalt, "labelSalt");
            this.labelSalt.Name = "labelSalt";
            // 
            // textBoxSalt
            // 
            resources.ApplyResources(this.textBoxSalt, "textBoxSalt");
            this.textBoxSalt.Name = "textBoxSalt";
            this.textBoxSalt.UseSystemPasswordChar = true;
            this.textBoxSalt.TextChanged += new System.EventHandler(this.TextBoxSaltTextChanged);
            // 
            // checkBoxHideHash
            // 
            resources.ApplyResources(this.checkBoxHideHash, "checkBoxHideHash");
            this.checkBoxHideHash.Name = "checkBoxHideHash";
            this.checkBoxHideHash.UseVisualStyleBackColor = true;
            this.checkBoxHideHash.CheckedChanged += new System.EventHandler(this.CheckBoxHiddenCheckedChanged);
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPasswordTextChanged);
            // 
            // comboBoxHashType
            // 
            this.comboBoxHashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxHashType, "comboBoxHashType");
            this.comboBoxHashType.FormattingEnabled = true;
            this.comboBoxHashType.Items.AddRange(new object[] {
            resources.GetString("comboBoxHashType.Items"),
            resources.GetString("comboBoxHashType.Items1"),
            resources.GetString("comboBoxHashType.Items2"),
            resources.GetString("comboBoxHashType.Items3")});
            this.comboBoxHashType.Name = "comboBoxHashType";
            this.comboBoxHashType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHashTypeSelectedIndexChangedChanged);
            // 
            // progressBarTimeLeft
            // 
            resources.ApplyResources(this.progressBarTimeLeft, "progressBarTimeLeft");
            this.progressBarTimeLeft.Name = "progressBarTimeLeft";
            // 
            // buttonCopyToClipboard
            // 
            resources.ApplyResources(this.buttonCopyToClipboard, "buttonCopyToClipboard");
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.ButtonCopyToClipboardClick);
            // 
            // textBoxHashValue
            // 
            resources.ApplyResources(this.textBoxHashValue, "textBoxHashValue");
            this.textBoxHashValue.Name = "textBoxHashValue";
            this.textBoxHashValue.ReadOnly = true;
            this.textBoxHashValue.TabStop = false;
            this.textBoxHashValue.UseSystemPasswordChar = true;
            // 
            // buttonVerification
            // 
            resources.ApplyResources(this.buttonVerification, "buttonVerification");
            this.buttonVerification.Name = "buttonVerification";
            this.buttonVerification.UseVisualStyleBackColor = true;
            this.buttonVerification.Click += new System.EventHandler(this.ButtonVerificationClick);
            // 
            // checkBoxClearInput
            // 
            resources.ApplyResources(this.checkBoxClearInput, "checkBoxClearInput");
            this.checkBoxClearInput.Name = "checkBoxClearInput";
            this.checkBoxClearInput.UseVisualStyleBackColor = true;
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.checkBoxAppend);
            this.groupBoxControls.Controls.Add(this.checkBoxClearInput);
            this.groupBoxControls.Controls.Add(this.buttonVerification);
            this.groupBoxControls.Controls.Add(this.textBoxHashValue);
            this.groupBoxControls.Controls.Add(this.buttonCopyToClipboard);
            this.groupBoxControls.Controls.Add(this.progressBarTimeLeft);
            this.groupBoxControls.Controls.Add(this.comboBoxHashType);
            this.groupBoxControls.Controls.Add(this.textBoxPassword);
            this.groupBoxControls.Controls.Add(this.checkBoxHideHash);
            this.groupBoxControls.Controls.Add(this.textBoxSalt);
            this.groupBoxControls.Controls.Add(this.labelSalt);
            this.groupBoxControls.Controls.Add(this.labelPassword);
            this.groupBoxControls.Controls.Add(this.labelHashedValue);
            this.groupBoxControls.Controls.Add(this.labelHashType);
            this.groupBoxControls.Controls.Add(this.labelDouble);
            this.groupBoxControls.Controls.Add(this.comboBoxDouble);
            this.groupBoxControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBoxControls, "groupBoxControls");
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.TabStop = false;
            // 
            // checkBoxAppend
            // 
            resources.ApplyResources(this.checkBoxAppend, "checkBoxAppend");
            this.checkBoxAppend.Name = "checkBoxAppend";
            this.checkBoxAppend.UseVisualStyleBackColor = true;
            this.checkBoxAppend.CheckedChanged += new System.EventHandler(this.checkBoxAppend_CheckedChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxControls.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDouble;
        private System.Windows.Forms.Label labelDouble;
        private System.Windows.Forms.Label labelHashType;
        private System.Windows.Forms.Label labelHashedValue;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelSalt;
        private System.Windows.Forms.TextBox textBoxSalt;
        private System.Windows.Forms.CheckBox checkBoxHideHash;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxHashType;
        private System.Windows.Forms.ProgressBar progressBarTimeLeft;
        private System.Windows.Forms.Button buttonCopyToClipboard;
        private System.Windows.Forms.TextBox textBoxHashValue;
        private System.Windows.Forms.Button buttonVerification;
        private System.Windows.Forms.CheckBox checkBoxClearInput;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxAppend;
    }
}

