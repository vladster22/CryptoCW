namespace Cipher
{
    partial class CryptosForm
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
            this.PropertiesGBox = new System.Windows.Forms.GroupBox();
            this.KeyTBox = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.AlgoCBox = new System.Windows.Forms.ComboBox();
            this.AlgoLabel = new System.Windows.Forms.Label();
            this.ProgressGBox = new System.Windows.Forms.GroupBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.CryptoGBox = new System.Windows.Forms.GroupBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TextTabPage = new System.Windows.Forms.TabPage();
            this.DecryptTextLabel = new System.Windows.Forms.Label();
            this.EncryptTextLabel = new System.Windows.Forms.Label();
            this.InputTextLabel = new System.Windows.Forms.Label();
            this.DecryptTextButton = new System.Windows.Forms.Button();
            this.EncryptTextButton = new System.Windows.Forms.Button();
            this.DecryptTextTBox = new System.Windows.Forms.TextBox();
            this.EncryptTextTBox = new System.Windows.Forms.TextBox();
            this.InputTextTBox = new System.Windows.Forms.TextBox();
            this.FileTabPage = new System.Windows.Forms.TabPage();
            this.DecryptFileLabel = new System.Windows.Forms.Label();
            this.EncryptFileLabel = new System.Windows.Forms.Label();
            this.InputFileLabel = new System.Windows.Forms.Label();
            this.DecryptFileButton = new System.Windows.Forms.Button();
            this.button_EnFile_Browse = new System.Windows.Forms.Button();
            this.EncryptFileButton = new System.Windows.Forms.Button();
            this.button_File_Browse = new System.Windows.Forms.Button();
            this.button_DeFile_Browse = new System.Windows.Forms.Button();
            this.DecryptFileTBox = new System.Windows.Forms.TextBox();
            this.EncryptFileTBox = new System.Windows.Forms.TextBox();
            this.InputFileTBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PropertiesGBox.SuspendLayout();
            this.ProgressGBox.SuspendLayout();
            this.CryptoGBox.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TextTabPage.SuspendLayout();
            this.FileTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PropertiesGBox
            // 
            this.PropertiesGBox.Controls.Add(this.KeyTBox);
            this.PropertiesGBox.Controls.Add(this.KeyLabel);
            this.PropertiesGBox.Controls.Add(this.AlgoCBox);
            this.PropertiesGBox.Controls.Add(this.AlgoLabel);
            this.PropertiesGBox.Location = new System.Drawing.Point(2, 5);
            this.PropertiesGBox.Name = "PropertiesGBox";
            this.PropertiesGBox.Size = new System.Drawing.Size(483, 48);
            this.PropertiesGBox.TabIndex = 0;
            this.PropertiesGBox.TabStop = false;
            this.PropertiesGBox.Text = "Properties";
            // 
            // KeyTBox
            // 
            this.KeyTBox.Location = new System.Drawing.Point(288, 17);
            this.KeyTBox.MaxLength = 8;
            this.KeyTBox.Name = "KeyTBox";
            this.KeyTBox.Size = new System.Drawing.Size(181, 20);
            this.KeyTBox.TabIndex = 3;
            this.KeyTBox.Text = "DefaultK";
            this.KeyTBox.Leave += new System.EventHandler(this.textBoxKey_Leave);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(179, 20);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(94, 13);
            this.KeyLabel.TabIndex = 2;
            this.KeyLabel.Text = "Key(8 Characters):";
            // 
            // AlgoCBox
            // 
            this.AlgoCBox.FormattingEnabled = true;
            this.AlgoCBox.Location = new System.Drawing.Point(75, 17);
            this.AlgoCBox.Name = "AlgoCBox";
            this.AlgoCBox.Size = new System.Drawing.Size(98, 21);
            this.AlgoCBox.TabIndex = 1;
            this.AlgoCBox.SelectedIndexChanged += new System.EventHandler(this.AlgoCBox_SelectedIndexChanged);
            // 
            // AlgoLabel
            // 
            this.AlgoLabel.AutoSize = true;
            this.AlgoLabel.Location = new System.Drawing.Point(16, 20);
            this.AlgoLabel.Name = "AlgoLabel";
            this.AlgoLabel.Size = new System.Drawing.Size(53, 13);
            this.AlgoLabel.TabIndex = 0;
            this.AlgoLabel.Text = "Algorithm:";
            // 
            // ProgressGBox
            // 
            this.ProgressGBox.Controls.Add(this.StopButton);
            this.ProgressGBox.Controls.Add(this.TimerLabel);
            this.ProgressGBox.Controls.Add(this.ProgressBar);
            this.ProgressGBox.Location = new System.Drawing.Point(2, 382);
            this.ProgressGBox.Name = "ProgressGBox";
            this.ProgressGBox.Size = new System.Drawing.Size(483, 82);
            this.ProgressGBox.TabIndex = 1;
            this.ProgressGBox.TabStop = false;
            this.ProgressGBox.Text = "Progress";
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(19, 50);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(100, 23);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(127, 55);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(49, 13);
            this.TimerLabel.TabIndex = 2;
            this.TimerLabel.Text = "00:00:00";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(19, 19);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(450, 22);
            this.ProgressBar.TabIndex = 1;
            // 
            // CryptoGBox
            // 
            this.CryptoGBox.Controls.Add(this.TabControl);
            this.CryptoGBox.Location = new System.Drawing.Point(2, 59);
            this.CryptoGBox.Name = "CryptoGBox";
            this.CryptoGBox.Size = new System.Drawing.Size(483, 317);
            this.CryptoGBox.TabIndex = 2;
            this.CryptoGBox.TabStop = false;
            this.CryptoGBox.Text = "Encryption - Decryption";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TextTabPage);
            this.TabControl.Controls.Add(this.FileTabPage);
            this.TabControl.Location = new System.Drawing.Point(9, 19);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(465, 292);
            this.TabControl.TabIndex = 0;
            // 
            // TextTabPage
            // 
            this.TextTabPage.Controls.Add(this.DecryptTextLabel);
            this.TextTabPage.Controls.Add(this.EncryptTextLabel);
            this.TextTabPage.Controls.Add(this.InputTextLabel);
            this.TextTabPage.Controls.Add(this.DecryptTextButton);
            this.TextTabPage.Controls.Add(this.EncryptTextButton);
            this.TextTabPage.Controls.Add(this.DecryptTextTBox);
            this.TextTabPage.Controls.Add(this.EncryptTextTBox);
            this.TextTabPage.Controls.Add(this.InputTextTBox);
            this.TextTabPage.Location = new System.Drawing.Point(4, 22);
            this.TextTabPage.Name = "TextTabPage";
            this.TextTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TextTabPage.Size = new System.Drawing.Size(457, 266);
            this.TextTabPage.TabIndex = 0;
            this.TextTabPage.Text = "Text";
            this.TextTabPage.UseVisualStyleBackColor = true;
            // 
            // DecryptTextLabel
            // 
            this.DecryptTextLabel.AutoSize = true;
            this.DecryptTextLabel.Location = new System.Drawing.Point(3, 162);
            this.DecryptTextLabel.Name = "DecryptTextLabel";
            this.DecryptTextLabel.Size = new System.Drawing.Size(83, 13);
            this.DecryptTextLabel.TabIndex = 21;
            this.DecryptTextLabel.Text = "Decrypted Text:";
            // 
            // EncryptTextLabel
            // 
            this.EncryptTextLabel.AutoSize = true;
            this.EncryptTextLabel.Location = new System.Drawing.Point(3, 83);
            this.EncryptTextLabel.Name = "EncryptTextLabel";
            this.EncryptTextLabel.Size = new System.Drawing.Size(82, 13);
            this.EncryptTextLabel.TabIndex = 20;
            this.EncryptTextLabel.Text = "Encrypted Text:";
            // 
            // InputTextLabel
            // 
            this.InputTextLabel.AutoSize = true;
            this.InputTextLabel.Location = new System.Drawing.Point(3, 7);
            this.InputTextLabel.Name = "InputTextLabel";
            this.InputTextLabel.Size = new System.Drawing.Size(87, 13);
            this.InputTextLabel.TabIndex = 19;
            this.InputTextLabel.Text = "Input(Plain) Text:";
            // 
            // DecryptTextButton
            // 
            this.DecryptTextButton.Location = new System.Drawing.Point(112, 237);
            this.DecryptTextButton.Name = "DecryptTextButton";
            this.DecryptTextButton.Size = new System.Drawing.Size(100, 23);
            this.DecryptTextButton.TabIndex = 18;
            this.DecryptTextButton.Text = "Decrypt";
            this.DecryptTextButton.UseVisualStyleBackColor = true;
            this.DecryptTextButton.Click += new System.EventHandler(this.DecryptTextButton_Click);
            // 
            // EncryptTextButton
            // 
            this.EncryptTextButton.Location = new System.Drawing.Point(6, 237);
            this.EncryptTextButton.Name = "EncryptTextButton";
            this.EncryptTextButton.Size = new System.Drawing.Size(100, 23);
            this.EncryptTextButton.TabIndex = 17;
            this.EncryptTextButton.Text = "Encrypt";
            this.EncryptTextButton.UseVisualStyleBackColor = true;
            this.EncryptTextButton.Click += new System.EventHandler(this.EncryptTextButton_Click);
            // 
            // DecryptTextTBox
            // 
            this.DecryptTextTBox.Location = new System.Drawing.Point(6, 178);
            this.DecryptTextTBox.Multiline = true;
            this.DecryptTextTBox.Name = "DecryptTextTBox";
            this.DecryptTextTBox.ReadOnly = true;
            this.DecryptTextTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DecryptTextTBox.Size = new System.Drawing.Size(445, 55);
            this.DecryptTextTBox.TabIndex = 16;
            // 
            // EncryptTextTBox
            // 
            this.EncryptTextTBox.Location = new System.Drawing.Point(6, 99);
            this.EncryptTextTBox.Multiline = true;
            this.EncryptTextTBox.Name = "EncryptTextTBox";
            this.EncryptTextTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EncryptTextTBox.Size = new System.Drawing.Size(445, 55);
            this.EncryptTextTBox.TabIndex = 15;
            // 
            // InputTextTBox
            // 
            this.InputTextTBox.Location = new System.Drawing.Point(6, 23);
            this.InputTextTBox.Multiline = true;
            this.InputTextTBox.Name = "InputTextTBox";
            this.InputTextTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputTextTBox.Size = new System.Drawing.Size(445, 55);
            this.InputTextTBox.TabIndex = 14;
            // 
            // FileTabPage
            // 
            this.FileTabPage.Controls.Add(this.DecryptFileLabel);
            this.FileTabPage.Controls.Add(this.EncryptFileLabel);
            this.FileTabPage.Controls.Add(this.InputFileLabel);
            this.FileTabPage.Controls.Add(this.DecryptFileButton);
            this.FileTabPage.Controls.Add(this.button_EnFile_Browse);
            this.FileTabPage.Controls.Add(this.EncryptFileButton);
            this.FileTabPage.Controls.Add(this.button_File_Browse);
            this.FileTabPage.Controls.Add(this.button_DeFile_Browse);
            this.FileTabPage.Controls.Add(this.DecryptFileTBox);
            this.FileTabPage.Controls.Add(this.EncryptFileTBox);
            this.FileTabPage.Controls.Add(this.InputFileTBox);
            this.FileTabPage.Location = new System.Drawing.Point(4, 22);
            this.FileTabPage.Name = "FileTabPage";
            this.FileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FileTabPage.Size = new System.Drawing.Size(457, 266);
            this.FileTabPage.TabIndex = 1;
            this.FileTabPage.Text = "File";
            this.FileTabPage.UseVisualStyleBackColor = true;
            // 
            // DecryptFileLabel
            // 
            this.DecryptFileLabel.AutoSize = true;
            this.DecryptFileLabel.Location = new System.Drawing.Point(3, 162);
            this.DecryptFileLabel.Name = "DecryptFileLabel";
            this.DecryptFileLabel.Size = new System.Drawing.Size(78, 13);
            this.DecryptFileLabel.TabIndex = 26;
            this.DecryptFileLabel.Text = "Decrypted File:";
            // 
            // EncryptFileLabel
            // 
            this.EncryptFileLabel.AutoSize = true;
            this.EncryptFileLabel.Location = new System.Drawing.Point(3, 83);
            this.EncryptFileLabel.Name = "EncryptFileLabel";
            this.EncryptFileLabel.Size = new System.Drawing.Size(205, 13);
            this.EncryptFileLabel.TabIndex = 25;
            this.EncryptFileLabel.Text = "Encrypted File(Browse and Click Decrypt):";
            // 
            // InputFileLabel
            // 
            this.InputFileLabel.AutoSize = true;
            this.InputFileLabel.Location = new System.Drawing.Point(3, 7);
            this.InputFileLabel.Name = "InputFileLabel";
            this.InputFileLabel.Size = new System.Drawing.Size(180, 13);
            this.InputFileLabel.TabIndex = 24;
            this.InputFileLabel.Text = "Input File(Browse and Click Encrypt):";
            // 
            // DecryptFileButton
            // 
            this.DecryptFileButton.Location = new System.Drawing.Point(112, 237);
            this.DecryptFileButton.Name = "DecryptFileButton";
            this.DecryptFileButton.Size = new System.Drawing.Size(100, 23);
            this.DecryptFileButton.TabIndex = 21;
            this.DecryptFileButton.Text = "Decrypt";
            this.DecryptFileButton.UseVisualStyleBackColor = true;
            this.DecryptFileButton.Click += new System.EventHandler(this.DecryptFileButton_Click);
            // 
            // button_EnFile_Browse
            // 
            this.button_EnFile_Browse.Location = new System.Drawing.Point(385, 97);
            this.button_EnFile_Browse.Name = "button_EnFile_Browse";
            this.button_EnFile_Browse.Size = new System.Drawing.Size(65, 23);
            this.button_EnFile_Browse.TabIndex = 20;
            this.button_EnFile_Browse.Text = "Browse";
            this.button_EnFile_Browse.UseVisualStyleBackColor = true;
            this.button_EnFile_Browse.Click += new System.EventHandler(this.button_EnFile_Browse_Click);
            // 
            // EncryptFileButton
            // 
            this.EncryptFileButton.Location = new System.Drawing.Point(6, 237);
            this.EncryptFileButton.Name = "EncryptFileButton";
            this.EncryptFileButton.Size = new System.Drawing.Size(100, 23);
            this.EncryptFileButton.TabIndex = 18;
            this.EncryptFileButton.Text = "Encrypt";
            this.EncryptFileButton.UseVisualStyleBackColor = true;
            this.EncryptFileButton.Click += new System.EventHandler(this.EncryptFileButton_Click);
            // 
            // button_File_Browse
            // 
            this.button_File_Browse.Location = new System.Drawing.Point(385, 21);
            this.button_File_Browse.Name = "button_File_Browse";
            this.button_File_Browse.Size = new System.Drawing.Size(65, 23);
            this.button_File_Browse.TabIndex = 17;
            this.button_File_Browse.Text = "Browse";
            this.button_File_Browse.UseVisualStyleBackColor = true;
            this.button_File_Browse.Click += new System.EventHandler(this.button_File_Browse_Click);
            // 
            // button_DeFile_Browse
            // 
            this.button_DeFile_Browse.Location = new System.Drawing.Point(384, 176);
            this.button_DeFile_Browse.Name = "button_DeFile_Browse";
            this.button_DeFile_Browse.Size = new System.Drawing.Size(65, 23);
            this.button_DeFile_Browse.TabIndex = 23;
            this.button_DeFile_Browse.Text = "Browse";
            this.button_DeFile_Browse.UseVisualStyleBackColor = true;
            this.button_DeFile_Browse.Click += new System.EventHandler(this.button_DeFile_Browse_Click);
            // 
            // DecryptFileTBox
            // 
            this.DecryptFileTBox.Location = new System.Drawing.Point(6, 178);
            this.DecryptFileTBox.Name = "DecryptFileTBox";
            this.DecryptFileTBox.ReadOnly = true;
            this.DecryptFileTBox.Size = new System.Drawing.Size(372, 20);
            this.DecryptFileTBox.TabIndex = 22;
            // 
            // EncryptFileTBox
            // 
            this.EncryptFileTBox.Location = new System.Drawing.Point(6, 99);
            this.EncryptFileTBox.Name = "EncryptFileTBox";
            this.EncryptFileTBox.ReadOnly = true;
            this.EncryptFileTBox.Size = new System.Drawing.Size(373, 20);
            this.EncryptFileTBox.TabIndex = 19;
            // 
            // InputFileTBox
            // 
            this.InputFileTBox.Location = new System.Drawing.Point(6, 23);
            this.InputFileTBox.Name = "InputFileTBox";
            this.InputFileTBox.ReadOnly = true;
            this.InputFileTBox.Size = new System.Drawing.Size(373, 20);
            this.InputFileTBox.TabIndex = 16;
            // 
            // CryptosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(489, 468);
            this.Controls.Add(this.CryptoGBox);
            this.Controls.Add(this.ProgressGBox);
            this.Controls.Add(this.PropertiesGBox);
            this.MaximizeBox = false;
            this.Name = "CryptosForm";
            this.Text = "Cryptos v1.4";
            this.PropertiesGBox.ResumeLayout(false);
            this.PropertiesGBox.PerformLayout();
            this.ProgressGBox.ResumeLayout(false);
            this.ProgressGBox.PerformLayout();
            this.CryptoGBox.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.TextTabPage.ResumeLayout(false);
            this.TextTabPage.PerformLayout();
            this.FileTabPage.ResumeLayout(false);
            this.FileTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PropertiesGBox;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.ComboBox AlgoCBox;
        private System.Windows.Forms.Label AlgoLabel;
        private System.Windows.Forms.TextBox KeyTBox;
        private System.Windows.Forms.GroupBox ProgressGBox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.GroupBox CryptoGBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TextTabPage;
        private System.Windows.Forms.TextBox DecryptTextTBox;
        private System.Windows.Forms.TextBox EncryptTextTBox;
        private System.Windows.Forms.TextBox InputTextTBox;
        private System.Windows.Forms.TabPage FileTabPage;
        private System.Windows.Forms.Label EncryptTextLabel;
        private System.Windows.Forms.Label InputTextLabel;
        private System.Windows.Forms.Button DecryptTextButton;
        private System.Windows.Forms.Button EncryptTextButton;
        private System.Windows.Forms.Label DecryptTextLabel;
        private System.Windows.Forms.Button DecryptFileButton;
        private System.Windows.Forms.Button button_EnFile_Browse;
        private System.Windows.Forms.Button EncryptFileButton;
        private System.Windows.Forms.Button button_File_Browse;
        private System.Windows.Forms.Button button_DeFile_Browse;
        private System.Windows.Forms.TextBox DecryptFileTBox;
        private System.Windows.Forms.TextBox EncryptFileTBox;
        private System.Windows.Forms.TextBox InputFileTBox;
        
        private System.Windows.Forms.Label DecryptFileLabel;
        private System.Windows.Forms.Label EncryptFileLabel;
        private System.Windows.Forms.Label InputFileLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}

