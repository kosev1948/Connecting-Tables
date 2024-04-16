namespace Connecting_Tables
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
            lbl1 = new Label();
            label2 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            btn1 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(67, 80);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(39, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 80);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Name_bg";
            // 
            // txt1
            // 
            txt1.Location = new Point(43, 124);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 2;
            // 
            // txt2
            // 
            txt2.Location = new Point(194, 124);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 3;
            // 
            // btn1
            // 
            btn1.Location = new Point(79, 249);
            btn1.Name = "btn1";
            btn1.Size = new Size(151, 73);
            btn1.TabIndex = 4;
            btn1.Text = "Insert into rod";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn1);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Connecting Tables";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label label2;
        private TextBox txt1;
        private TextBox txt2;
        private Button btn1;
    }
}
