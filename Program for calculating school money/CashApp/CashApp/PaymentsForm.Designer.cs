namespace CashApp
{
    partial class PaymentsForm
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
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(139, 20);
            label1.Name = "label1";
            label1.Size = new Size(497, 47);
            label1.TabIndex = 0;
            label1.Text = "За къде се отнася плащането:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(139, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(491, 33);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(228, 123);
            label3.Name = "label3";
            label3.Size = new Size(314, 47);
            label3.TabIndex = 33;
            label3.Text = "Колко ще платите:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(139, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(491, 33);
            textBox2.TabIndex = 34;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(286, 212);
            button2.Name = "button2";
            button2.Size = new Size(202, 53);
            button2.TabIndex = 35;
            button2.Text = "Плащане";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(228, 341);
            button3.Name = "button3";
            button3.Size = new Size(340, 82);
            button3.TabIndex = 37;
            button3.Text = "Виж всички плащания";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // PaymentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PaymentsForm";
            Text = "PaymentsForm";
            Load += PaymentsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
    }
}