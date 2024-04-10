namespace ReadSequentialAccessFile
{
    partial class ReadSequentialAccessFileForm
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
            nextButton = new Button();
            openButton = new Button();
            balanceTextBox = new TextBox();
            label4 = new Label();
            firstNameTextBox = new TextBox();
            label3 = new Label();
            lastNameTextBox = new TextBox();
            label2 = new Label();
            accountTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Location = new Point(200, 231);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(126, 23);
            nextButton.TabIndex = 19;
            nextButton.Text = "Siguiente registro";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // openButton
            // 
            openButton.Location = new Point(59, 231);
            openButton.Name = "openButton";
            openButton.Size = new Size(92, 23);
            openButton.TabIndex = 18;
            openButton.Text = "Abrir archivo";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // balanceTextBox
            // 
            balanceTextBox.Location = new Point(210, 174);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(233, 23);
            balanceTextBox.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 177);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 16;
            label4.Text = "Saldo";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(210, 78);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(233, 23);
            firstNameTextBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 132);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 14;
            label3.Text = "ApellidoPaterno";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(210, 129);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(233, 23);
            lastNameTextBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 81);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 12;
            label2.Text = "Primer nombre";
            // 
            // accountTextBox
            // 
            accountTextBox.Location = new Point(210, 31);
            accountTextBox.Name = "accountTextBox";
            accountTextBox.Size = new Size(233, 23);
            accountTextBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 34);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 10;
            label1.Text = "Cuenta";
            // 
            // ReadSequentialAccessFileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 299);
            Controls.Add(nextButton);
            Controls.Add(openButton);
            Controls.Add(balanceTextBox);
            Controls.Add(label4);
            Controls.Add(firstNameTextBox);
            Controls.Add(label3);
            Controls.Add(lastNameTextBox);
            Controls.Add(label2);
            Controls.Add(accountTextBox);
            Controls.Add(label1);
            Name = "ReadSequentialAccessFileForm";
            Text = "ReadSequentialAccessFileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Button openButton;
        private TextBox balanceTextBox;
        private Label label4;
        private TextBox firstNameTextBox;
        private Label label3;
        private TextBox lastNameTextBox;
        private Label label2;
        private TextBox accountTextBox;
        private Label label1;
    }
}