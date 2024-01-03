namespace CashApp
{
    partial class BalanceForm
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
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(216, 145);
            label2.Name = "label2";
            label2.Size = new Size(164, 47);
            label2.TabIndex = 17;
            label2.Text = "Баланс - ";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Red;
            progressBar1.Location = new Point(3, 195);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(794, 8);
            progressBar1.TabIndex = 18;
            // 
            // BalanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Name = "BalanceForm";
            Text = "BalanceForm";
            Load += BalanceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ProgressBar progressBar1;
    }
}