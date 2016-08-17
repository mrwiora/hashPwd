using System;
using System.Drawing;
using System.Windows.Forms;

namespace hashPwd
{
    public partial class FormValidation : Form
    {

        #region Member

        private readonly String m_varHash;
        private readonly String m_varType;
        private readonly String m_varDouble;
        private readonly bool m_varSaltAppend;

        private String m_varToHashVerify;
        private String m_varToSaltVerify;

        #endregion


        #region Constructor

        public FormValidation(string varHashedValue, string varHashType, string varDoubleType, bool varSaltAppend)
        {
            InitializeComponent();
            m_varHash = varHashedValue;
            m_varType = varHashType;
            m_varDouble = varDoubleType;
            m_varSaltAppend = varSaltAppend;
            DialogResult = DialogResult.Cancel;
        }

        #endregion



        #region Methods

        private void ButtonCloseClick(object sender, EventArgs e)
        {
            Close();   
        }

        private void TextBoxPasswordChanged(object sender, EventArgs e)
        {
            GetValues();
            var hash = Crypto.GetHash(m_varToHashVerify, m_varToSaltVerify, m_varType, m_varDouble, m_varSaltAppend);

            if (m_varHash == hash)
            {
                textBoxPassword.BackColor = textBoxSalt.BackColor = Color.LightGreen;
                textBoxPassword.Enabled = textBoxSalt.Enabled = false;
                buttonClose.Enabled = false;
                buttonClose.Text = Resource.VerificationSucceeded;

                // close form after 1.5 seconds
                var timer = new Timer {Interval = 1500};
                timer.Tick += (o, args) => DialogResult = DialogResult.OK;
                timer.Start();
            }
            else
            {
                textBoxPassword.BackColor = textBoxSalt.BackColor = Color.OrangeRed;
            }
        }
        
        /// <summary>
        /// Get values from inputs and store them
        /// </summary>
        private void GetValues()
        {
            m_varToHashVerify = textBoxPassword.Text;
            m_varToSaltVerify = textBoxSalt.Text;
        }

        #endregion
    }
}
