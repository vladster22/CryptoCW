using System;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Cipher;

namespace Cipher
{
    public partial class CryptosForm : Form
    {
        private AESProvider AesProvider;
        private DESProvider DesProvider;

        //to invoke UI elements when required
        private delegate void UpdateUIHandler(string Message);

        //for asynchronous programming
        private delegate void ProcessCipherHandler(OperationType t);
        private ProcessCipherHandler ProcessCipherDelegate;
        private AsyncCallback AsyCall;

        //to hold start and elapsed time of threads
        private DateTime DTStart;
        private TimeSpan TSElapsed;

        private enum OperationType { EncryptText, DecryptText, EncryptFile, DecryptFile };
        //secondary thread must invoke the combobox to retrieve index. instead hold index at a variable
        private int ComboBoxIndex = 1;

        private bool exeptionOccured = false;
        private ManualResetEvent ManualStop = new ManualResetEvent(false);

        public CryptosForm()
        {
            InitializeComponent();
            InitComboBox();

            AesProvider = new AESProvider();
            DesProvider = new DESProvider();

            AesProvider.ProgressChanged += new ProgressEventHandler(AESProgressChanged);
            DesProvider.ProgressChanged += new ProgressEventHandler(DESProgressChanged);

            ProcessCipherDelegate = new ProcessCipherHandler(ProcessCipher);
            AsyCall = new AsyncCallback(ProcessCompleted);
        }

        void DESProgressChanged(object o, ProgressEventArgs args)
        {
            TSElapsed = DateTime.Now.Subtract(DTStart);
            string Elapsed = TSElapsed.Hours.ToString("D2") + ":" +
                             TSElapsed.Minutes.ToString("D2") + ":" +
                             TSElapsed.Seconds.ToString("D2");

            Update_ProgressBar(args.progress.ToString());
            Update_LabelTimer(Elapsed);

            if (ManualStop.WaitOne(0, false))
                args.stop = true;
        }

        void AESProgressChanged(object o, ProgressEventArgs args)
        {
            TSElapsed = DateTime.Now.Subtract(DTStart);
            string Elapsed = TSElapsed.Hours.ToString("D2") + ":" +
                             TSElapsed.Minutes.ToString("D2") + ":" +
                             TSElapsed.Seconds.ToString("D2");

            Update_ProgressBar(args.progress.ToString());
            Update_LabelTimer(Elapsed);

            if (ManualStop.WaitOne(0, false))
                args.stop = true;
        }

        void ProcessCompleted(IAsyncResult r)
        {
            if (r.AsyncState is string)
            {
                if (!exeptionOccured)
                    if (ManualStop.WaitOne(0, false))
                        MessageBox.Show((string)r.AsyncState + "Aborted..", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show((string)r.AsyncState + "Completed..", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                Update_ProgressBar("0");
            }
        }

        private void EncryptTextButton_Click(object sender, EventArgs e)
        {
            ProcessCipherDelegate.BeginInvoke(OperationType.EncryptText, AsyCall, "Encrypting Text ");
        }

        private void DecryptTextButton_Click(object sender, EventArgs e)
        {
            ProcessCipherDelegate.BeginInvoke(OperationType.DecryptText, AsyCall, "Decrypting Text ");
        }

        private void EncryptFileButton_Click(object sender, EventArgs e)
        {
            ProcessCipherDelegate.BeginInvoke(OperationType.EncryptFile, AsyCall, "Encrypting File ");
        }

        private void DecryptFileButton_Click(object sender, EventArgs e)
        {
            ProcessCipherDelegate.BeginInvoke(OperationType.DecryptFile, AsyCall, "Decrypting File ");
        }

        private void ProcessCipher(OperationType OpType)
        {
            DTStart = DateTime.Now;
            exeptionOccured = false;
            ManualStop.Reset();

            try
            {
                if (OpType == OperationType.DecryptFile)
                {
                    if (!File.Exists(EncryptFileTBox.Text))
                    {
                        throw new Exception("File Does Not Exist: " + EncryptFileTBox.Text);
                    }

                    if (ComboBoxIndex == 0)
                    {
                        DesProvider.Decrypt(EncryptFileTBox.Text, DecryptFileTBox.Text, KeyTBox.Text);
                    }
                    else
                    {
                        AesProvider.Decrypt(EncryptFileTBox.Text, DecryptFileTBox.Text, KeyTBox.Text);
                    }
                }
                else if (OpType == OperationType.EncryptFile)
                {
                    if (!File.Exists(InputFileTBox.Text))
                    {
                        throw new Exception("File Does Not Exist: " + InputFileTBox.Text);
                    }

                    if (ComboBoxIndex == 0)
                    {
                        DesProvider.Encrypt(InputFileTBox.Text, EncryptFileTBox.Text, KeyTBox.Text);
                    }
                    else
                    {
                        AesProvider.Encrypt(InputFileTBox.Text, EncryptFileTBox.Text, KeyTBox.Text);
                    }
                }
                else if (OpType == OperationType.EncryptText)
                {
                    if (ComboBoxIndex == 0)
                    {
                        byte[] EnBytesBuffer = DesProvider.Encrypt(Encoding.Unicode.GetBytes(InputTextTBox.Text), KeyTBox.Text);
                        Update_EncryptedText(Convert.ToBase64String(EnBytesBuffer));
                    }
                    else
                    {
                        byte[] EnBytesBuffer = AesProvider.Encrypt(Encoding.Unicode.GetBytes(InputTextTBox.Text), KeyTBox.Text);
                        Update_EncryptedText(Convert.ToBase64String(EnBytesBuffer));
                    }
                }
                else if (OpType == OperationType.DecryptText)
                {
                    if (ComboBoxIndex == 0)
                    {
                        byte[] EnBytesBuffer = Convert.FromBase64String(EncryptTextTBox.Text);
                        Update_DecryptedText(Encoding.Unicode.GetString
                            (DesProvider.Decrypt(EnBytesBuffer, KeyTBox.Text)));
                    }
                    else
                    {
                        byte[] EnBytesBuffer = Convert.FromBase64String(EncryptTextTBox.Text);
                        Update_DecryptedText(Encoding.Unicode.GetString
                            (AesProvider.Decrypt(EnBytesBuffer, KeyTBox.Text)));
                    }
                }
            }
            catch (Exception e)
            {
                exeptionOccured = true;
                MessageBox.Show("Error: " + e.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ManualStop.Set();
        }

        #region Update UI Components If Required, Event Handlers For UI Elements and etc..
        private void Update_EncryptedText(string Text)
        {
            if (EncryptTextTBox.InvokeRequired)
            {
                EncryptTextTBox.Invoke(new UpdateUIHandler(Update_EncryptedText), Text);
            }
            else
            {
                EncryptTextTBox.Text = Text;
            }
        }

        private void Update_DecryptedText(string Text)
        {
            if (DecryptTextTBox.InvokeRequired)
            {
                DecryptTextTBox.Invoke(new UpdateUIHandler(Update_DecryptedText), Text);
            }
            else
            {
                DecryptTextTBox.Text = Text;
            }
        }

        private void Update_ProgressBar(string Value)
        {
            if (ProgressBar.InvokeRequired)
            {
                ProgressBar.Invoke(new UpdateUIHandler(Update_ProgressBar), Value);
            }
            else
            {
                ProgressBar.Value = Int16.Parse(Value);
            }
        }

        private void Update_LabelTimer(string Elapsed)
        {
            if (TimerLabel.InvokeRequired)
            {
                TimerLabel.Invoke(new UpdateUIHandler(Update_LabelTimer), Elapsed);
            }
            else
            {
                TimerLabel.Text = Elapsed;
            }
        }

        private void InitComboBox()
        {
            AlgoCBox.Items.Add("DES (64 Bit)");
            AlgoCBox.Items.Add("AES (128 Bit)");
            AlgoCBox.Items.Add("AES (192 Bit)");
            AlgoCBox.Items.Add("AES (256 Bit)");
            AlgoCBox.SelectedIndex = ComboBoxIndex;
        }

        private void AlgoCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (AlgoCBox.SelectedIndex)
            {
                case 0:
                    KeyTBox.MaxLength = 8;
                    KeyTBox.Text = "DefaultK";
                    KeyLabel.Text = "Key(8 Characters):";
                    ComboBoxIndex = 0;
                    break;
                case 1:
                    KeyTBox.MaxLength = 16;
                    KeyTBox.Text = "DefaultKeyForAes";
                    KeyLabel.Text = "Key(16 Characters):";
                    ComboBoxIndex = 1;
                    break;
                case 2:
                    KeyTBox.MaxLength = 24;
                    KeyTBox.Text = "DefaultKeyForAes192BitAl";
                    KeyLabel.Text = "Key(24 Characters):";
                    ComboBoxIndex = 2;
                    break;
                case 3:
                    KeyTBox.MaxLength = 32;
                    KeyTBox.Text = "DefaultKeyForAes256BitAlgorithm.";
                    KeyLabel.Text = "Key(32 Characters):";
                    ComboBoxIndex = 3;
                    break;
            }
        }

        private void button_File_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All File Types(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                InputFileTBox.Text = openFileDialog.FileName;
                EncryptFileTBox.Text = openFileDialog.FileName + ".enc";
                DecryptFileTBox.Text = openFileDialog.FileName + ".enc" + Path.GetExtension(openFileDialog.FileName);

            }
        }

        private void button_EnFile_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Encrypted File(*.enc)|*.enc";
            openFileDialog.Filter += "|All File Types(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                EncryptFileTBox.Text = openFileDialog.FileName;
            }
        }

        private void button_DeFile_Browse_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "All File Types(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DecryptFileTBox.Text = saveFileDialog.FileName;
            }
        }

        private void textBoxKey_Leave(object sender, EventArgs e)
        {
            if (AlgoCBox.SelectedIndex == 0 && KeyTBox.Text.Length != 8)
            {
                MessageBox.Show("Key Must Be 8 Characters Long..", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                KeyTBox.Text = "DefaultK";
            }
            else if (AlgoCBox.SelectedIndex == 1 && KeyTBox.Text.Length != 16)
            {
                MessageBox.Show("Key Must Be 16 Characters Long..", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                KeyTBox.Text = "DefaultKeyForAes";
            }
            else if (AlgoCBox.SelectedIndex == 2 && KeyTBox.Text.Length != 24)
            {
                MessageBox.Show("Key Must Be 24 Characters Long..", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                KeyTBox.Text = "DefaultKeyForAes192BitAl";
            }
            else if (AlgoCBox.SelectedIndex == 3 && KeyTBox.Text.Length != 32)
            {
                MessageBox.Show("Key Must Be 32 Characters Long..", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                KeyTBox.Text = "DefaultKeyForAes256BitAlgorithm.";
            }
        }
        #endregion
    }
}