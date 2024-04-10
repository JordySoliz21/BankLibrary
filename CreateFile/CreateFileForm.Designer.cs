namespace CreateFile
{
    partial class CreateFileForm
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
            exitButton = new Button();
            enterButton = new Button();
            saveButton = new Button();
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
            // exitButton
            // 
            exitButton.Location = new Point(331, 238);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(92, 23);
            exitButton.TabIndex = 21;
            exitButton.Text = "Salir";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(190, 238);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(92, 23);
            enterButton.TabIndex = 20;
            enterButton.Text = "Ingresar";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(39, 238);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(92, 23);
            saveButton.TabIndex = 19;
            saveButton.Text = "Guardar como";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // balanceTextBox
            // 
            balanceTextBox.Location = new Point(190, 181);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(233, 23);
            balanceTextBox.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 184);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 17;
            label4.Text = "Saldo";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(190, 85);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(233, 23);
            firstNameTextBox.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 139);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 15;
            label3.Text = "ApellidoPaterno";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(190, 136);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(233, 23);
            lastNameTextBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 88);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 13;
            label2.Text = "Primer nombre";
            // 
            // accountTextBox
            // 
            accountTextBox.Location = new Point(190, 38);
            accountTextBox.Name = "accountTextBox";
            accountTextBox.Size = new Size(233, 23);
            accountTextBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 41);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 11;
            label1.Text = "Cuenta";
            // 
            // CreateFileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 329);
            Controls.Add(exitButton);
            Controls.Add(enterButton);
            Controls.Add(saveButton);
            Controls.Add(balanceTextBox);
            Controls.Add(label4);
            Controls.Add(firstNameTextBox);
            Controls.Add(label3);
            Controls.Add(lastNameTextBox);
            Controls.Add(label2);
            Controls.Add(accountTextBox);
            Controls.Add(label1);
            Name = "CreateFileForm";
            Text = "CreateFileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button enterButton;
        private Button saveButton;
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