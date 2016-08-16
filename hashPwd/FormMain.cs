using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace hashPwd
{
    public partial class FormMain : Form
    {
        #region Member

        private const int TimeMin = 0;
        private const int TimeMax = 10;
        private int m_timeLeft;

        private String m_varToHash;
        private String m_varHashType;
        private String m_varSalt;
        private String m_varDoubleType;
        private String m_varHashedValue;

        #endregion



        #region Constructor

        public FormMain()
        {
            InitializeComponent();
            InitializeForm();
            
        }

        #endregion



        #region Methods

        /// <summary>
        /// Initialize form and controls
        /// </summary>
        private void InitializeForm()
        {
            AcceptButton = buttonCopyToClipboard;

            var version = Assembly.GetExecutingAssembly().GetName().Version;
            Text += string.Format(" {0}.{1}", version.Major, version.Minor);

            progressBarTimeLeft.Minimum = TimeMin;
            progressBarTimeLeft.Maximum = TimeMax;

            StartTimer();
            ResetAll();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }
        private void ShowMe()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }

        /// <summary>
        /// Update hash value
        /// </summary>
        private void UpdateHash()
        {
            textBoxHashValue.Text = Crypto.GetHash(m_varToHash, m_varSalt, m_varHashType, m_varDoubleType);
        }

        /// <summary>
        /// Reset all GUI elements to default
        /// </summary>
        private void ResetAll()
        {
            comboBoxHashType.SelectedIndex = comboBoxHashType.FindStringExact("SHA1");
            textBoxPassword.Text = textBoxHashValue.Text = textBoxSalt.Text = "";
            textBoxPassword.Focus();
            checkBoxClearInput.Checked = checkBoxHideHash.Checked = true;
            buttonVerification.Text = Resource.Verification;
            buttonVerification.BackColor = Color.Empty;
            buttonCopyToClipboard.Enabled = buttonVerification.Enabled = false;
        }

        private void TextBoxPasswordTextChanged(object sender, EventArgs e)
        {
            GetValues();
            UpdateHash();

            if (textBoxHashValue.TextLength > 0)
            {
                buttonCopyToClipboard.Enabled = buttonVerification.Enabled = true;
            }
            else
            {
                ResetAll();
            }

            if (buttonVerification.Text == Resource.VerificationSucceeded)
            {
                buttonVerification.Text = Resource.Verification;
                buttonVerification.BackColor = Color.Empty;
                buttonVerification.Enabled = true;
            }
        }

        private void TextBoxSaltTextChanged(object sender, EventArgs e)
        {
            GetValues();
            UpdateHash();

            if (buttonVerification.Text == Resource.VerificationSucceeded)
            {
                buttonVerification.Text = Resource.Verification;
                buttonVerification.BackColor = Color.Empty;
                buttonVerification.Enabled = true;
            }
        }

        private void ComboBoxHashTypeSelectedIndexChangedChanged(object sender, EventArgs e)
        {
            GetValues();
            comboBoxDouble.Items.Clear();

            switch (comboBoxHashType.Text)
            {
                case "SHA1":
                case "SHA256":
                case "SHA512":
                    comboBoxDouble.Items.Add(Resource.None);
                    comboBoxDouble.Items.Add("MD5");

                    break;
                case "MD5":
                    comboBoxDouble.Items.Add(Resource.None);
                    comboBoxDouble.Items.Add("SHA1");
                    break;

                default:
                    comboBoxDouble.Items.Add(Resource.None);
                    break;
            }

            comboBoxDouble.SelectedIndex = 0;

            UpdateHash();
        }

        private void ComboBoxDoubleSelectedIndexChanged(object sender, EventArgs e)
        {
            GetValues();
            UpdateHash();
        }
        
        private void CheckBoxHiddenCheckedChanged(object sender, EventArgs e)
        {
            textBoxHashValue.UseSystemPasswordChar = checkBoxHideHash.Checked;
        }

        private void StartTimer()
        {
            // create timer with an interval of 1 sec
            var timer = new Timer { Interval = 1000 };
            timer.Tick += (s, eargs) => UpdateProgressBar();
            timer.Start();
        }
        
        private void UpdateProgressBar()
        {
            if (m_timeLeft > 0)
            {
                progressBarTimeLeft.Value = m_timeLeft;
            }
            else if (m_timeLeft == 0)
            {
                Clipboard.Clear();
                progressBarTimeLeft.Hide();
            }

            m_timeLeft--;
        }

        private void ButtonCopyToClipboardClick(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxHashValue.Text);
                m_timeLeft = 10;
                progressBarTimeLeft.Show();

                if (checkBoxClearInput.Checked)
                {
                    ResetAll();
                    this.WindowState = FormWindowState.Minimized;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{1} ...: {0}", Resource.SomethingWentWrong, ex.Message));
            } 

        }

        /// <summary>
        /// Obtain all values from form
        /// </summary>
        private void GetValues() 
        {
            m_varToHash = textBoxPassword.Text;
            m_varSalt = textBoxSalt.Text;
            m_varHashType = comboBoxHashType.Text;
            m_varDoubleType = comboBoxDouble.Text;
            m_varHashedValue = textBoxHashValue.Text;
        }

        private void ButtonVerificationClick(object sender, EventArgs e)
        {
            GetValues();

            using (var validationForm = new FormValidation(m_varHashedValue, m_varHashType, m_varDoubleType))
            {
                if (validationForm.ShowDialog() == DialogResult.OK)
                {
                    buttonVerification.Text = Resource.VerificationSucceeded;
                    buttonVerification.BackColor = Color.LightGreen;
                    buttonVerification.Enabled = false;
                    buttonCopyToClipboard.Select();
                }
            }
        }

        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (var box = new AboutBox())
            {
                box.ShowDialog();
            }
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
