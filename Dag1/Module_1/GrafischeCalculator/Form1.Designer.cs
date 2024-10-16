namespace GrafischeCalculator
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
            label1 = new Label();
            label2 = new Label();
            lblAnswer = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 38);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 0;
            label1.Text = "Value A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 91);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 1;
            label2.Text = "Value B";
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswer.Location = new Point(126, 154);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(81, 30);
            lblAnswer.TabIndex = 2;
            lblAnswer.Text = "Answer";
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtA.Location = new Point(126, 39);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 33);
            txtA.TabIndex = 3;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB.Location = new Point(126, 92);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 33);
            txtB.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(331, 45);
            button1.Name = "button1";
            button1.Size = new Size(75, 80);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 386);
            Controls.Add(button1);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblAnswer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblAnswer;
        private TextBox txtA;
        private TextBox txtB;
        private Button button1;
    }
}
