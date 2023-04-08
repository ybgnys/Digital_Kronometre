namespace Digital_Kronometre
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("SimSun", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 64, 0);
            textBox1.Location = new Point(334, 74);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 41);
            textBox1.TabIndex = 0;
            textBox1.Text = "  0:0:0            ";
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(298, 133);
            button1.Name = "button1";
            button1.Size = new Size(225, 42);
            button1.TabIndex = 1;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(298, 190);
            button2.Name = "button2";
            button2.Size = new Size(225, 42);
            button2.TabIndex = 2;
            button2.Text = "STOP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(298, 251);
            button3.Name = "button3";
            button3.Size = new Size(225, 42);
            button3.TabIndex = 3;
            button3.Text = "PAUSE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(709, 133);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 4;
            label1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(867, 305);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "KRONOMETRE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}