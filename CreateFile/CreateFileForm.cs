using BankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankLibrary.BankUIForm;

namespace CreateFile
{
    public partial class CreateFileForm : BankUIForm
    {
        private FileRepository? _fileRepository;
        public CreateFileForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Nombre de archivo invalido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        _fileRepository = new FileRepository(fileName);
                        _fileRepository?.OpenOrCreateFile();

                        saveButton.Enabled = false;
                        saveButton.Enabled = true;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string[] values = GetTextBoxValues();

            if (!string.IsNullOrEmpty(values[(int)TextBoxIndice.Account]))
            {
                try
                {
                    int accountNumber = int.Parse(values[(int)TextBoxIndice.Account]);

                    if (accountNumber > 0)
                    {
                        var record = new Record(accountNumber,
                             values[(int)TextBoxIndice.First],
                             values[(int)TextBoxIndice.Last],
                             decimal.Parse(values[(int)TextBoxIndice.Balance]));

                        _fileRepository.WriteRecordToFile(record);
                    }
                    else
                    {
                        MessageBox.Show("Numero de cuenta invalido", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato invalido", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ClearTextBoxes();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                _fileRepository?.CloseFile();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }
    }
}
