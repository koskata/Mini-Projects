namespace Hotel_Reservations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(331, 139);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(258, 139);
            button1.TabIndex = 0;
            button1.Text = "Всички стаи";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(806, 64);
            label1.TabIndex = 1;
            label1.Text = "Хотел \"Continental\" *****";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Georgia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(14, 294);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(242, 67);
            button4.TabIndex = 4;
            button4.Text = "Изчисти стая";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(331, 360);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(258, 139);
            button3.TabIndex = 5;
            button3.Text = "Направи резервация";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightGray;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(14, 529);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(134, 55);
            button7.TabIndex = 8;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Silver;
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Georgia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(650, 294);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(242, 67);
            button8.TabIndex = 10;
            button8.Text = "Освободи стая";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 234, 245);
            ClientSize = new Size(914, 600);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button7;
        private Button button8;
    }
}