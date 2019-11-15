namespace MyCalculator
{
    partial class Form1
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
            System.Windows.Forms.Button Num10;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.output1 = new System.Windows.Forms.TextBox();
            this.ButtonBox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Equal1 = new System.Windows.Forms.Button();
            this.fun5 = new System.Windows.Forms.Button();
            this.Fun11 = new System.Windows.Forms.Button();
            this.Fun13 = new System.Windows.Forms.Button();
            this.Fun14 = new System.Windows.Forms.Button();
            this.Fun12 = new System.Windows.Forms.Button();
            this.fun4 = new System.Windows.Forms.Button();
            this.fun3 = new System.Windows.Forms.Button();
            this.Fun2 = new System.Windows.Forms.Button();
            this.memory11 = new System.Windows.Forms.Button();
            this.memory4 = new System.Windows.Forms.Button();
            this.memory2 = new System.Windows.Forms.Button();
            this.memory5 = new System.Windows.Forms.Button();
            this.memory3 = new System.Windows.Forms.Button();
            this.memory1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            Num10 = new System.Windows.Forms.Button();
            this.ButtonBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Num10
            // 
            Num10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            Num10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            Num10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Num10.Location = new System.Drawing.Point(72, 193);
            Num10.Name = "Num10";
            Num10.Size = new System.Drawing.Size(36, 27);
            Num10.TabIndex = 0;
            Num10.Text = ".";
            Num10.UseMnemonic = false;
            Num10.UseVisualStyleBackColor = true;
            Num10.Click += new System.EventHandler(this.Num10_Click);
            // 
            // output1
            // 
            this.output1.BackColor = System.Drawing.Color.White;
            this.output1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output1.Location = new System.Drawing.Point(12, 27);
            this.output1.Multiline = true;
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(239, 62);
            this.output1.TabIndex = 0;
            this.output1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.output1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.output1_KeyPress);
            // 
            // ButtonBox
            // 
            this.ButtonBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonBox.Controls.Add(this.button4);
            this.ButtonBox.Controls.Add(Num10);
            this.ButtonBox.Controls.Add(this.Num0);
            this.ButtonBox.Controls.Add(this.Num9);
            this.ButtonBox.Controls.Add(this.button1);
            this.ButtonBox.Controls.Add(this.Num6);
            this.ButtonBox.Controls.Add(this.Num3);
            this.ButtonBox.Controls.Add(this.Num8);
            this.ButtonBox.Controls.Add(this.Num7);
            this.ButtonBox.Controls.Add(this.Num5);
            this.ButtonBox.Controls.Add(this.Num4);
            this.ButtonBox.Controls.Add(this.Num2);
            this.ButtonBox.Controls.Add(this.Num1);
            this.ButtonBox.Controls.Add(this.Equal1);
            this.ButtonBox.Controls.Add(this.fun5);
            this.ButtonBox.Controls.Add(this.Fun11);
            this.ButtonBox.Controls.Add(this.Fun13);
            this.ButtonBox.Controls.Add(this.Fun14);
            this.ButtonBox.Controls.Add(this.Fun12);
            this.ButtonBox.Controls.Add(this.fun4);
            this.ButtonBox.Controls.Add(this.fun3);
            this.ButtonBox.Controls.Add(this.Fun2);
            this.ButtonBox.Controls.Add(this.memory11);
            this.ButtonBox.Controls.Add(this.memory4);
            this.ButtonBox.Controls.Add(this.memory2);
            this.ButtonBox.Controls.Add(this.memory5);
            this.ButtonBox.Controls.Add(this.memory3);
            this.ButtonBox.Controls.Add(this.memory1);
            this.ButtonBox.Location = new System.Drawing.Point(12, 112);
            this.ButtonBox.Name = "ButtonBox";
            this.ButtonBox.Size = new System.Drawing.Size(239, 220);
            this.ButtonBox.TabIndex = 1;
            this.ButtonBox.TabStop = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(141, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Fun1_Click);
            // 
            // Num0
            // 
            this.Num0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num0.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num0.Location = new System.Drawing.Point(0, 193);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(72, 27);
            this.Num0.TabIndex = 0;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Num9
            // 
            this.Num9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num9.Location = new System.Drawing.Point(72, 168);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(36, 25);
            this.Num9.TabIndex = 0;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::MyCalculator.Properties.Resources.Capture;
            this.button1.Location = new System.Drawing.Point(140, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 41);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Num6
            // 
            this.Num6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num6.Location = new System.Drawing.Point(72, 135);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(36, 29);
            this.Num6.TabIndex = 0;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // Num3
            // 
            this.Num3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3.Location = new System.Drawing.Point(72, 100);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(36, 31);
            this.Num3.TabIndex = 0;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Num8
            // 
            this.Num8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num8.Location = new System.Drawing.Point(36, 167);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(36, 25);
            this.Num8.TabIndex = 0;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // Num7
            // 
            this.Num7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num7.Location = new System.Drawing.Point(0, 167);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(36, 25);
            this.Num7.TabIndex = 0;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // Num5
            // 
            this.Num5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num5.Location = new System.Drawing.Point(36, 135);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(36, 29);
            this.Num5.TabIndex = 0;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // Num4
            // 
            this.Num4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num4.Location = new System.Drawing.Point(0, 135);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(36, 29);
            this.Num4.TabIndex = 0;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // Num2
            // 
            this.Num2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(36, 100);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(36, 31);
            this.Num2.TabIndex = 0;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num1
            // 
            this.Num1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(0, 100);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(36, 31);
            this.Num1.TabIndex = 0;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Equal1
            // 
            this.Equal1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal1.Location = new System.Drawing.Point(193, 135);
            this.Equal1.Name = "Equal1";
            this.Equal1.Size = new System.Drawing.Size(43, 80);
            this.Equal1.TabIndex = 0;
            this.Equal1.Text = "=";
            this.Equal1.UseVisualStyleBackColor = true;
            this.Equal1.Click += new System.EventHandler(this.Equal1_Click);
            // 
            // fun5
            // 
            this.fun5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fun5.Location = new System.Drawing.Point(152, 135);
            this.fun5.Name = "fun5";
            this.fun5.Size = new System.Drawing.Size(35, 37);
            this.fun5.TabIndex = 0;
            this.fun5.Text = "*";
            this.fun5.UseVisualStyleBackColor = true;
            this.fun5.Click += new System.EventHandler(this.fun5_Click_1);
            // 
            // Fun11
            // 
            this.Fun11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fun11.Location = new System.Drawing.Point(193, 53);
            this.Fun11.Name = "Fun11";
            this.Fun11.Size = new System.Drawing.Size(43, 41);
            this.Fun11.TabIndex = 0;
            this.Fun11.Text = "x^";
            this.Fun11.UseVisualStyleBackColor = true;
            this.Fun11.Click += new System.EventHandler(this.Fun11_Click);
            // 
            // Fun13
            // 
            this.Fun13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fun13.Location = new System.Drawing.Point(192, 10);
            this.Fun13.Name = "Fun13";
            this.Fun13.Size = new System.Drawing.Size(44, 40);
            this.Fun13.TabIndex = 0;
            this.Fun13.Text = "CE";
            this.Fun13.UseVisualStyleBackColor = true;
            this.Fun13.Click += new System.EventHandler(this.Fun13_Click);
            // 
            // Fun14
            // 
            this.Fun14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fun14.Location = new System.Drawing.Point(152, 100);
            this.Fun14.Name = "Fun14";
            this.Fun14.Size = new System.Drawing.Size(35, 31);
            this.Fun14.TabIndex = 0;
            this.Fun14.Text = "%";
            this.Fun14.UseVisualStyleBackColor = true;
            this.Fun14.Click += new System.EventHandler(this.Fun14_Click);
            // 
            // Fun12
            // 
            this.Fun12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fun12.Location = new System.Drawing.Point(192, 100);
            this.Fun12.Name = "Fun12";
            this.Fun12.Size = new System.Drawing.Size(44, 31);
            this.Fun12.TabIndex = 0;
            this.Fun12.Text = "1/x";
            this.Fun12.UseVisualStyleBackColor = true;
            this.Fun12.Click += new System.EventHandler(this.Fun12_Click);
            // 
            // fun4
            // 
            this.fun4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fun4.Location = new System.Drawing.Point(113, 100);
            this.fun4.Name = "fun4";
            this.fun4.Size = new System.Drawing.Size(35, 31);
            this.fun4.TabIndex = 0;
            this.fun4.Text = "/";
            this.fun4.UseVisualStyleBackColor = true;
            this.fun4.Click += new System.EventHandler(this.fun4_Click_1);
            // 
            // fun3
            // 
            this.fun3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fun3.Location = new System.Drawing.Point(113, 135);
            this.fun3.Name = "fun3";
            this.fun3.Size = new System.Drawing.Size(35, 37);
            this.fun3.TabIndex = 0;
            this.fun3.Text = "-";
            this.fun3.UseVisualStyleBackColor = true;
            this.fun3.Click += new System.EventHandler(this.fun3_Click_1);
            // 
            // Fun2
            // 
            this.Fun2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fun2.Location = new System.Drawing.Point(113, 178);
            this.Fun2.Name = "Fun2";
            this.Fun2.Size = new System.Drawing.Size(74, 36);
            this.Fun2.TabIndex = 0;
            this.Fun2.Text = "+";
            this.Fun2.UseVisualStyleBackColor = true;
            this.Fun2.Click += new System.EventHandler(this.Fun2_Click);
            // 
            // memory11
            // 
            this.memory11.Location = new System.Drawing.Point(72, 69);
            this.memory11.Name = "memory11";
            this.memory11.Size = new System.Drawing.Size(63, 25);
            this.memory11.TabIndex = 0;
            this.memory11.Text = "MS";
            this.memory11.UseVisualStyleBackColor = true;
            // 
            // memory4
            // 
            this.memory4.Location = new System.Drawing.Point(72, 41);
            this.memory4.Name = "memory4";
            this.memory4.Size = new System.Drawing.Size(63, 25);
            this.memory4.TabIndex = 0;
            this.memory4.Text = "MR";
            this.memory4.UseVisualStyleBackColor = true;
            // 
            // memory2
            // 
            this.memory2.Location = new System.Drawing.Point(72, 10);
            this.memory2.Name = "memory2";
            this.memory2.Size = new System.Drawing.Size(63, 25);
            this.memory2.TabIndex = 0;
            this.memory2.Text = "M-";
            this.memory2.UseVisualStyleBackColor = true;
            // 
            // memory5
            // 
            this.memory5.Location = new System.Drawing.Point(0, 69);
            this.memory5.Name = "memory5";
            this.memory5.Size = new System.Drawing.Size(66, 25);
            this.memory5.TabIndex = 0;
            this.memory5.Text = "Sqrt";
            this.memory5.UseVisualStyleBackColor = true;
            this.memory5.Click += new System.EventHandler(this.button20_Click);
            // 
            // memory3
            // 
            this.memory3.Location = new System.Drawing.Point(0, 41);
            this.memory3.Name = "memory3";
            this.memory3.Size = new System.Drawing.Size(66, 25);
            this.memory3.TabIndex = 0;
            this.memory3.Text = "MC";
            this.memory3.UseVisualStyleBackColor = true;
            // 
            // memory1
            // 
            this.memory1.Location = new System.Drawing.Point(0, 10);
            this.memory1.Name = "memory1";
            this.memory1.Size = new System.Drawing.Size(66, 25);
            this.memory1.TabIndex = 0;
            this.memory1.Text = "M+";
            this.memory1.UseVisualStyleBackColor = true;
            this.memory1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(261, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.conversionToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.existToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scientificToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.scientificToolStripMenuItem.Text = "&Scientific";
            // 
            // conversionToolStripMenuItem
            // 
            this.conversionToolStripMenuItem.Name = "conversionToolStripMenuItem";
            this.conversionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.conversionToolStripMenuItem.Text = "&Unit Conversion";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // existToolStripMenuItem
            // 
            this.existToolStripMenuItem.Name = "existToolStripMenuItem";
            this.existToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.existToolStripMenuItem.Text = "&Exit";
            this.existToolStripMenuItem.Click += new System.EventHandler(this.existToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "&copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "(";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(153, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = ")";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(204, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Sin";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 344);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButtonBox);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output1;
        private System.Windows.Forms.GroupBox ButtonBox;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Equal1;
        private System.Windows.Forms.Button fun5;
        private System.Windows.Forms.Button fun4;
        private System.Windows.Forms.Button fun3;
        private System.Windows.Forms.Button Fun2;
        private System.Windows.Forms.Button memory11;
        private System.Windows.Forms.Button memory4;
        private System.Windows.Forms.Button memory2;
        private System.Windows.Forms.Button memory5;
        private System.Windows.Forms.Button memory3;
        private System.Windows.Forms.Button memory1;
        private System.Windows.Forms.Button Fun11;
        private System.Windows.Forms.Button Fun13;
        private System.Windows.Forms.Button Fun14;
        private System.Windows.Forms.Button Fun12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
    }
}

