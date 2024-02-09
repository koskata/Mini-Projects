namespace WinFormsApp1
{
    partial class Form2
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            productCode = new TextBox();
            productDescription = new TextBox();
            compSerNum = new TextBox();
            compSerNumCode = new TextBox();
            componentDescription = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 128);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(325, 12);
            button1.Name = "button1";
            button1.Size = new Size(163, 82);
            button1.TabIndex = 1;
            button1.Text = "Нулиране Сер. Номер";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(496, 12);
            button2.Name = "button2";
            button2.Size = new Size(213, 82);
            button2.TabIndex = 2;
            button2.Text = "Отваряне форма за двигател";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 255, 255);
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 230);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(697, 60);
            textBox2.TabIndex = 3;
            textBox2.Text = "1. Сканирайте баркода от Монтажния Лист(Монтажна  Карта) или етикет със Серийния Номер на изделието!";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(128, 255, 255);
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(11, 296);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(698, 74);
            textBox3.TabIndex = 4;
            textBox3.Text = "2. Сканирайте баркода със Серийния Номер от етикета на двигателя или го въведете ръчно и натиснете ENTER! За повторно сканиране Сер. Номер на двигател първо нулиране с бутона горе и отново т.2.";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Cyan;
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(12, 376);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(697, 45);
            textBox4.TabIndex = 5;
            textBox4.Text = "3. Изберете месец и година на производство на двигателя. Потвърдете с бутона ОК!";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 146);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(151, 37);
            textBox5.TabIndex = 6;
            // 
            // productCode
            // 
            productCode.Location = new Point(169, 146);
            productCode.Multiline = true;
            productCode.Name = "productCode";
            productCode.Size = new Size(150, 37);
            productCode.TabIndex = 7;
            // 
            // productDescription
            // 
            productDescription.Location = new Point(325, 146);
            productDescription.Multiline = true;
            productDescription.Name = "productDescription";
            productDescription.Size = new Size(371, 37);
            productDescription.TabIndex = 8;
            // 
            // compSerNum
            // 
            compSerNum.Location = new Point(38, 189);
            compSerNum.Multiline = true;
            compSerNum.Name = "compSerNum";
            compSerNum.Size = new Size(161, 34);
            compSerNum.TabIndex = 9;
            // 
            // compSerNumCode
            // 
            compSerNumCode.Location = new Point(205, 189);
            compSerNumCode.Multiline = true;
            compSerNumCode.Name = "compSerNumCode";
            compSerNumCode.Size = new Size(161, 34);
            compSerNumCode.TabIndex = 10;
            // 
            // componentDescription
            // 
            componentDescription.Location = new Point(372, 189);
            componentDescription.Multiline = true;
            componentDescription.Name = "componentDescription";
            componentDescription.Size = new Size(337, 34);
            componentDescription.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(325, 103);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(163, 37);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 429);
            Controls.Add(textBox6);
            Controls.Add(componentDescription);
            Controls.Add(compSerNumCode);
            Controls.Add(compSerNum);
            Controls.Add(productDescription);
            Controls.Add(productCode);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBox1;
        public Button button1;
        public Button button2;
        public TextBox textBox2;
        public TextBox textBox3;
        public TextBox textBox4;
        public TextBox textBox5;
        public TextBox productCode;
        public TextBox productDescription;
        public TextBox compSerNum;
        public TextBox compSerNumCode;
        public TextBox componentDescription;
        public TextBox textBox6;
    }
}