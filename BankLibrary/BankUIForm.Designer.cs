namespace BankLibrary
{
    partial class BankUIForm
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
            label1 = new Label();
            accountTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            label2 = new Label();
            firstNameTextBox = new TextBox();
            label3 = new Label();
            balanceTextBox = new TextBox();
            label4 = new Label();
            saveButton = new Button();
            enterButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 35);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Cuenta";
            // 
            // accountTextBox
            // 
            accountTextBox.Location = new Point(178, 32);
            accountTextBox.Name = "accountTextBox";
            accountTextBox.Size = new Size(233, 23);
            accountTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(178, 130);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(233, 23);
            lastNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 82);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Primer nombre";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(178, 79);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(233, 23);
            firstNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 133);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 4;
            label3.Text = "ApellidoPaterno";
            // 
            // balanceTextBox
            // 
            balanceTextBox.Location = new Point(178, 175);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(233, 23);
            balanceTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 178);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Saldo";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(27, 232);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(92, 23);
            saveButton.TabIndex = 8;
            saveButton.Text = "Guardar como";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(168, 232);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(92, 23);
            enterButton.TabIndex = 9;
            enterButton.Text = "Ingresar";
            enterButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(319, 232);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(92, 23);
            exitButton.TabIndex = 10;
            exitButton.Text = "Salir";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // BankUIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 294);
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
            Name = "BankUIForm";
            Text = "BankUIForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox accountTextBox;
        private TextBox lastNameTextBox;
        private Label label2;
        private TextBox firstNameTextBox;
        private Label label3;
        private TextBox balanceTextBox;
        private Label label4;
        private Button saveButton;
        private Button enterButton;
        private Button exitButton;
    }
}