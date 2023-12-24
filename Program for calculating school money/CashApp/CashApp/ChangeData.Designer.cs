namespace CashApp
{
    partial class ChangeData
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
            Enter = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            Schoolarship = new Button();
            label2 = new Label();
            Transport = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // Enter
            // 
            Enter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Enter.Location = new Point(290, 91);
            Enter.Name = "Enter";
            Enter.Size = new Size(205, 27);
            Enter.TabIndex = 13;
            Enter.Text = "Въведи";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(73, 44);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(633, 41);
            textBox1.TabIndex = 12;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(288, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 11;
            label1.Text = "Въведете месец:";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Red;
            progressBar1.Location = new Point(3, 138);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(794, 8);
            progressBar1.TabIndex = 14;
            // 
            // Schoolarship
            // 
            Schoolarship.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Schoolarship.Location = new Point(36, 281);
            Schoolarship.Name = "Schoolarship";
            Schoolarship.Size = new Size(320, 111);
            Schoolarship.TabIndex = 15;
            Schoolarship.Text = "Стипендия";
            Schoolarship.UseVisualStyleBackColor = true;
            Schoolarship.Click += Schoolarship_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(179, 149);
            label2.Name = "label2";
            label2.Size = new Size(433, 45);
            label2.TabIndex = 16;
            label2.Text = "Какво искате да промените:";
            // 
            // Transport
            // 
            Transport.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Transport.Location = new Point(441, 281);
            Transport.Name = "Transport";
            Transport.Size = new Size(320, 111);
            Transport.TabIndex = 17;
            Transport.Text = "Транспортни";
            Transport.UseVisualStyleBackColor = true;
            Transport.Click += Transport_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(36, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 35);
            textBox2.TabIndex = 18;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(441, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 35);
            textBox3.TabIndex = 19;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // ChangeData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(Transport);
            Controls.Add(label2);
            Controls.Add(Schoolarship);
            Controls.Add(progressBar1);
            Controls.Add(Enter);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ChangeData";
            Text = "ChangeData";
            Load += ChangeData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Enter;
        private TextBox textBox1;
        private Label label1;
        private ProgressBar progressBar1;
        private Button Schoolarship;
        private Label label2;
        private Button Transport;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}