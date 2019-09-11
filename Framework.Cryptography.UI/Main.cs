using System;
using System.Windows.Forms;

namespace Framework.Cryptography.UI
{
    public partial class Main : Form
    {
        #region| Constructor |
        
        public Main()
        {
            InitializeComponent();
        }
        #endregion

        #region| Events |

        private void Main_Load(object sender, EventArgs e)
        {
            // Set the default encryption type
            ddlType.SelectedIndex = 1;
        } 

        #endregion

        #region| Controls |

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if(ddlType.SelectedIndex==0)
            {
                txtOutput.Text = Cryptography.EncryptUsingTripleDES(txtInput.Text);
            }
            else
            {
                txtOutput.Text = Cryptography.Encrypt(txtInput.Text, txtSecurePhrase.Text);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (ddlType.SelectedIndex == 0)
            {
                txtOutput.Text = Cryptography.DecryptUsingTripleDES(txtInput.Text);
            }
            else
            {
                txtOutput.Text = Cryptography.Decrypt(txtInput.Text, txtSecurePhrase.Text);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtInput.Text  = string.Empty;
            txtOutput.Text = string.Empty;
        }

        private void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlType.SelectedIndex==0)
            {
                txtSecurePhrase.Enabled = false;
                txtSecurePhrase.Text    = "";
            }
            else
            {
                txtSecurePhrase.Enabled = true;
                txtSecurePhrase.Text    = "Fr@m3w0rk";

            }
        }

        #endregion
    }
}
