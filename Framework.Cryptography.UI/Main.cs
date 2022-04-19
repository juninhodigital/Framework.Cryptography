using Framework.Core;
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

            txtInput.Focus();
        } 

        #endregion

        #region| Controls |

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                var output = string.Empty;

                if (ddlType.SelectedIndex == 0)
                {
                    output = Cryptography.EncryptUsingTripleDES(txtInput.Text);
                }
                else
                {
                    if (IsValidSecurePhrase())
                    {
                        output = Cryptography.Encrypt(txtInput.Text, txtSecurePhrase.Text);
                    }
                }

                if (output.IsNotNull())
                {
                    txtOutput.Text = output;

                    Clipboard.SetText(output);

                    MessageBox.Show("Encrypted data copied to the clipboard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                var output = string.Empty;

                if (ddlType.SelectedIndex == 0)
                {
                    output = Cryptography.DecryptUsingTripleDES(txtInput.Text);
                }
                else
                {
                    if (IsValidSecurePhrase())
                    {
                        output = Cryptography.Decrypt(txtInput.Text, txtSecurePhrase.Text);
                    }
                }

                if (output.IsNotNull())
                {
                    txtOutput.Text = output;

                    Clipboard.SetText(output);

                    MessageBox.Show("Decrypted data copied to the clipboard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            }
            else
            {
                txtSecurePhrase.Enabled = true;
            }
        }

        #endregion

        #region| Methods |

        private bool IsValidSecurePhrase()
        {
            errorProvider1.Clear();

            if (txtSecurePhrase.Text.IsNull())
            {
                errorProvider1.SetError(txtSecurePhrase, "Required field");
                return false;
            }

            return true;

        }

        private bool IsValidInput()
        {
            errorProvider1.Clear();

            if (txtInput.Text.IsNull())
            {
                errorProvider1.SetError(txtInput, "Required field");
                return false;
            }

            return true;
        }    

        #endregion
    }
}
