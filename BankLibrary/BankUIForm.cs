using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLibrary
{
    public partial class BankUIForm : Form
    {
        protected int TextBoxCount { get; set; } = 4;
        public enum TextBoxIndice { Account, First, Last, Balance}
        public BankUIForm()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            foreach (Control guicontrol in Controls)
            {
                (guicontrol as TextBox)?.Clear();
            }
        }

        public void SetTextBoxValue(string[] values)
        {
            if (values.Length != TextBoxCount)
            {
                throw (new ArgumentException
                    ($"There must be {TextBoxCount} string in the array",
                    nameof(values)));
            }
            else
            {
                accountTextBox.Text = values[(int)TextBoxIndice.Account];
                firstNameTextBox.Text = values[(int)TextBoxIndice.First];
                lastNameTextBox.Text = values[(int)TextBoxIndice.Last];
                balanceTextBox.Text = values[(int)TextBoxIndice.Balance];
            }
        }

        public string[] GetTextBoxValues()
        {
            return new string[] {
                accountTextBox.Text, firstNameTextBox.Text,
                lastNameTextBox.Text, balanceTextBox.Text
            };
        }
    }
}
