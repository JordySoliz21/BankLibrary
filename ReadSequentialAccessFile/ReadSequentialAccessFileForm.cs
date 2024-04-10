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

namespace ReadSequentialAccessFile 
{
    public partial class ReadSequentialAccessFileForm : BankUIForm
    {
        private FileRepository? _fileRepository;
        public ReadSequentialAccessFileForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                ClearTextBoxes();

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
                        _fileRepository?.OpenFile();

                        openButton.Enabled = false;
                        nextButton.Enabled = true;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "Error de archivo",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                var inputRecord = _fileRepository?.ReadNextRecord();

                if (inputRecord != null)
                {
                    string [] inputFields = inputRecord.Split(',');
                    SetTextBoxValue(inputFields);
                }
                else
                {
                    _fileRepository?.CloseFile();
                    openButton.Enabled = true;
                    nextButton.Enabled = false;
                    ClearTextBoxes();

                    MessageBox.Show("No mas hay registros en el archivo", string.Empty,
                        MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
