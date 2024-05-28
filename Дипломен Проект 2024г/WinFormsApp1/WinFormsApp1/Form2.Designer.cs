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
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            productCode = new TextBox();
            productDescription = new TextBox();
            compSerNum = new TextBox();
            compSerNumCode = new TextBox();
            componentDescription = new TextBox();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(11, 12);
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
            button1.Location = new Point(379, 15);
            button1.Name = "button1";
            button1.Size = new Size(163, 83);
            button1.TabIndex = 1;
            button1.Text = "Нулиране Сер. Номер";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(600, 15);
            button2.Name = "button2";
            button2.Size = new Size(213, 83);
            button2.TabIndex = 2;
            button2.Text = "Отваряне форма за двигател";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 255, 255);
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(17, 379);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(814, 60);
            textBox2.TabIndex = 3;
            textBox2.Text = "1. Сканирайте баркода от Монтажния Лист(Монтажна  Карта) или етикет със Серийния Номер на изделието!";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Cyan;
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(17, 528);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(814, 53);
            textBox4.TabIndex = 5;
            textBox4.Text = "3. Изберете месец и година на производство на двигателя. Потвърдете с бутона ОК!";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(600, 117);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(151, 37);
            textBox5.TabIndex = 6;
            // 
            // productCode
            // 
            productCode.Location = new Point(14, 201);
            productCode.Multiline = true;
            productCode.Name = "productCode";
            productCode.Size = new Size(150, 37);
            productCode.TabIndex = 7;
            // 
            // productDescription
            // 
            productDescription.Location = new Point(191, 201);
            productDescription.Multiline = true;
            productDescription.Name = "productDescription";
            productDescription.Size = new Size(371, 37);
            productDescription.TabIndex = 8;
            // 
            // compSerNum
            // 
            compSerNum.Location = new Point(35, 316);
            compSerNum.Multiline = true;
            compSerNum.Name = "compSerNum";
            compSerNum.Size = new Size(161, 33);
            compSerNum.TabIndex = 9;
            // 
            // compSerNumCode
            // 
            compSerNumCode.Location = new Point(278, 316);
            compSerNumCode.Multiline = true;
            compSerNumCode.Name = "compSerNumCode";
            compSerNumCode.Size = new Size(161, 33);
            compSerNumCode.TabIndex = 10;
            // 
            // componentDescription
            // 
            componentDescription.Location = new Point(491, 316);
            componentDescription.Multiline = true;
            componentDescription.Name = "componentDescription";
            componentDescription.Size = new Size(337, 33);
            componentDescription.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(629, 201);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(163, 37);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(128, 255, 255);
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(17, 445);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(814, 76);
            textBox3.TabIndex = 4;
            textBox3.Text = "2. Сканирайте баркода със Серийния Номер от етикета на двигателя или го въведете ръчно и натиснете ENTER! За повторно сканиране Сер. Номер на двигател първо нулиране с бутона горе и отново т.2.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(338, 117);
            label1.Name = "label1";
            label1.Size = new Size(256, 28);
            label1.TabIndex = 13;
            label1.Text = "Сериен номер на продукт:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 171);
            label2.Name = "label2";
            label2.Size = new Size(164, 28);
            label2.TabIndex = 14;
            label2.Text = "Код на продукта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(278, 171);
            label3.Name = "label3";
            label3.Size = new Size(221, 28);
            label3.TabIndex = 15;
            label3.Text = "Описание на продукта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(618, 171);
            label4.Name = "label4";
            label4.Size = new Size(218, 28);
            label4.TabIndex = 16;
            label4.Text = "Модел на компонента";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 257);
            label5.Name = "label5";
            label5.Size = new Size(151, 56);
            label5.TabIndex = 17;
            label5.Text = "Сериен номер \r\nна компонента";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(266, 257);
            label6.Name = "label6";
            label6.Size = new Size(214, 56);
            label6.TabIndex = 18;
            label6.Text = "Код на сериен номер \r\nна компонента";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(555, 285);
            label7.Name = "label7";
            label7.Size = new Size(248, 28);
            label7.TabIndex = 19;
            label7.Text = "Описание на компонента";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 597);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}