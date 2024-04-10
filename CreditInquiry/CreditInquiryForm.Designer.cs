namespace CreditInquiry
{
    partial class CreditInquiryForm
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
            displayTextBox = new TextBox();
            openButton = new Button();
            creditButton = new Button();
            debitButton = new Button();
            zeroButton = new Button();
            doneButton = new Button();
            SuspendLayout();
            // 
            // displayTextBox
            // 
            displayTextBox.Location = new Point(24, 22);
            displayTextBox.Multiline = true;
            displayTextBox.Name = "displayTextBox";
            displayTextBox.Size = new Size(650, 215);
            displayTextBox.TabIndex = 0;
            // 
            // openButton
            // 
            openButton.Location = new Point(24, 264);
            openButton.Name = "openButton";
            openButton.Size = new Size(92, 23);
            openButton.TabIndex = 1;
            openButton.Text = "Abrir archivo";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // creditButton
            // 
            creditButton.Location = new Point(157, 264);
            creditButton.Name = "creditButton";
            creditButton.Size = new Size(121, 23);
            creditButton.TabIndex = 2;
            creditButton.Text = "Saldos con credito";
            creditButton.UseVisualStyleBackColor = true;
            // 
            // debitButton
            // 
            debitButton.Location = new Point(314, 264);
            debitButton.Name = "debitButton";
            debitButton.Size = new Size(116, 23);
            debitButton.TabIndex = 3;
            debitButton.Text = "Saldos con debito";
            debitButton.UseVisualStyleBackColor = true;
            // 
            // zeroButton
            // 
            zeroButton.Location = new Point(461, 264);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(106, 23);
            zeroButton.TabIndex = 4;
            zeroButton.Text = "Saldos en cero";
            zeroButton.UseVisualStyleBackColor = true;
            // 
            // doneButton
            // 
            doneButton.Location = new Point(599, 264);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(75, 23);
            doneButton.TabIndex = 5;
            doneButton.Text = "Salir";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += doneButton_Click;
            // 
            // CreditInquiryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 316);
            Controls.Add(doneButton);
            Controls.Add(zeroButton);
            Controls.Add(debitButton);
            Controls.Add(creditButton);
            Controls.Add(openButton);
            Controls.Add(displayTextBox);
            Name = "CreditInquiryForm";
            Text = "CreditInquiryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displayTextBox;
        private Button openButton;
        private Button creditButton;
        private Button debitButton;
        private Button zeroButton;
        private Button doneButton;
    }
}