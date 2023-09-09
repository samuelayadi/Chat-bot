namespace ChatBox_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Textbox2 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkMagenta;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 550);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Fuchsia;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 58);
            panel2.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkMagenta;
            panel5.Location = new Point(196, 26);
            panel5.Name = "panel5";
            panel5.Size = new Size(17, 15);
            panel5.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 14);
            label2.Name = "label2";
            label2.Size = new Size(162, 27);
            label2.TabIndex = 0;
            label2.Text = "SILKY THE BOT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 27);
            label1.Name = "label1";
            label1.Size = new Size(145, 35);
            label1.TabIndex = 2;
            label1.Text = "CHATBOT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(268, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(333, 12);
            label3.Name = "label3";
            label3.Size = new Size(162, 27);
            label3.TabIndex = 2;
            label3.Text = "SILKY THE BOT";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 51);
            label4.Name = "label4";
            label4.Size = new Size(66, 24);
            label4.TabIndex = 3;
            label4.Text = "Online";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkMagenta;
            flowLayoutPanel1.Controls.Add(Textbox2);
            flowLayoutPanel1.Location = new Point(268, 99);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(563, 330);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // Textbox2
            // 
            Textbox2.AutoSize = true;
            Textbox2.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Textbox2.Location = new Point(3, 0);
            Textbox2.Name = "Textbox2";
            Textbox2.Size = new Size(0, 24);
            Textbox2.TabIndex = 6;
            Textbox2.Click += label5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkMagenta;
            panel3.Location = new Point(341, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(17, 15);
            panel3.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(268, 457);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(563, 65);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkMagenta;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(837, 469);
            button1.Name = "button1";
            button1.Size = new Size(105, 42);
            button1.TabIndex = 7;
            button1.Text = "SEND";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkMagenta;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(900, 33);
            button2.Name = "button2";
            button2.Size = new Size(42, 36);
            button2.TabIndex = 8;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(954, 548);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Textbox2;
        private Panel panel3;
        private Panel panel5;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}