namespace Hotel_Res
{
    partial class FreeingRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeingRoomForm));
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(259, 289);
            button1.Name = "button1";
            button1.Size = new Size(253, 68);
            button1.TabIndex = 23;
            button1.Text = "Маркирай като освободена";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(68, 57);
            button2.TabIndex = 21;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Font = new Font("Microsoft Sans Serif", 19.69F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(139, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(506, 37);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 23.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(104, 112);
            label1.Name = "label1";
            label1.Size = new Size(571, 36);
            label1.TabIndex = 19;
            label1.Text = "Номер на стая за освобождаване:";
            // 
            // FreeingRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 77, 95);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FreeingRoomForm";
            Text = "FreeingRoomForm";
            Load += FreeingRoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
    }
}