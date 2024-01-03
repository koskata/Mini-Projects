namespace CashApp
{
    partial class ТranslatingMoneyForm
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
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(171, 138);
            label2.Name = "label2";
            label2.Size = new Size(462, 47);
            label2.TabIndex = 22;
            label2.Text = "Колко искате да приведете:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(171, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(462, 39);
            textBox2.TabIndex = 27;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(297, 245);
            button2.Name = "button2";
            button2.Size = new Size(202, 41);
            button2.TabIndex = 28;
            button2.Text = "Преведи";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(305, 25);
            label3.Name = "label3";
            label3.Size = new Size(181, 47);
            label3.TabIndex = 29;
            label3.Text = "Преводач";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(171, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(462, 39);
            textBox3.TabIndex = 30;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(229, 356);
            button3.Name = "button3";
            button3.Size = new Size(340, 82);
            button3.TabIndex = 38;
            button3.Text = "Виж всички преводи";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ТranslatingMoneyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Name = "ТranslatingMoneyForm";
            Text = "ТranslatingMoneyForm";
            Load += ТranslatingMoneyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private TextBox textBox3;
        private Button button3;
    }
}