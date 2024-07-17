namespace VRChat_Offline_World_Loader
{
    partial class VRChatOfflineWorldLoader
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            button5 = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(559, 93);
            button1.Name = "button1";
            button1.Size = new Size(78, 42);
            button1.TabIndex = 0;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 103);
            label1.Name = "label1";
            label1.Size = new Size(265, 32);
            label1.TabIndex = 1;
            label1.Text = "VRChat Install Directory";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(278, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.VRC_Logo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(19, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 79);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 33.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(181, 21);
            label3.Name = "label3";
            label3.Size = new Size(457, 63);
            label3.TabIndex = 6;
            label3.Text = "Offline World Loader";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 148);
            label4.Name = "label4";
            label4.Size = new Size(211, 32);
            label4.TabIndex = 7;
            label4.Text = "VRCW File to Load";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(329, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(559, 141);
            button2.Name = "button2";
            button2.Size = new Size(78, 42);
            button2.TabIndex = 9;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 244);
            button3.Name = "button3";
            button3.Size = new Size(254, 70);
            button3.TabIndex = 10;
            button3.Text = "Update World";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(272, 244);
            button4.Name = "button4";
            button4.Size = new Size(254, 70);
            button4.TabIndex = 11;
            button4.Text = "Launch Loaded World";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 183);
            label5.Name = "label5";
            label5.Size = new Size(587, 56);
            label5.TabIndex = 12;
            label5.Text = "This process swaps out the VRChat error world for a custom world,\r\nand purposefully errors out the game to load you there.";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.Location = new Point(541, 244);
            button5.Name = "button5";
            button5.Size = new Size(96, 70);
            button5.TabIndex = 13;
            button5.Text = "Reset World";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // VRChatOfflineWorldLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 326);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "VRChatOfflineWorldLoader";
            Text = "VRChat Offline World Loader - by @tuckerisapizza";
            Load += VRChatOfflineWorldLoader_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label5;
        private Button button5;
        private OpenFileDialog openFileDialog1;
    }
}