namespace ImageProcessing
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dIPToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem = new ToolStripMenuItem();
            grayscalingToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            convolutionalToolsToolStripMenuItem = new ToolStripMenuItem();
            smoothingToolStripMenuItem = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            embossingToolStripMenuItem = new ToolStripMenuItem();
            laplacianToolStripMenuItem = new ToolStripMenuItem();
            horizontalVerticalToolStripMenuItem = new ToolStripMenuItem();
            allDirectionsToolStripMenuItem = new ToolStripMenuItem();
            lossyToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            embossToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            edgeToolStripMenuItem = new ToolStripMenuItem();
            detectToolStripMenuItem = new ToolStripMenuItem();
            enhanceToolStripMenuItem = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            tabPage4 = new TabPage();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button5 = new Button();
            pictureBox6 = new PictureBox();
            tabPage3 = new TabPage();
            button8 = new Button();
            button7 = new Button();
            label20 = new Label();
            label19 = new Label();
            textBox7 = new TextBox();
            label18 = new Label();
            textBox6 = new TextBox();
            label17 = new Label();
            button6 = new Button();
            label16 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            saveFileDialog2 = new SaveFileDialog();
            label21 = new Label();
            label22 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ControlLightLight;
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(menuStrip2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Basic DIP";
            tabPage1.Click += tabPage1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(534, 361);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 6;
            label2.Text = "Processed Image";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 361);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 5;
            label1.Text = "Loaded Image";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(411, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(359, 296);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(20, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dIPToolStripMenuItem, convolutionalToolsToolStripMenuItem });
            menuStrip2.Location = new Point(3, 3);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(786, 28);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // dIPToolStripMenuItem
            // 
            dIPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pixelCopyToolStripMenuItem, grayscalingToolStripMenuItem, inversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem });
            dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            dIPToolStripMenuItem.Size = new Size(85, 24);
            dIPToolStripMenuItem.Text = "DIP Tools";
            // 
            // pixelCopyToolStripMenuItem
            // 
            pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            pixelCopyToolStripMenuItem.Size = new Size(168, 26);
            pixelCopyToolStripMenuItem.Text = "Pixel Copy";
            pixelCopyToolStripMenuItem.Click += pixelCopyToolStripMenuItem_Click;
            // 
            // grayscalingToolStripMenuItem
            // 
            grayscalingToolStripMenuItem.Name = "grayscalingToolStripMenuItem";
            grayscalingToolStripMenuItem.Size = new Size(168, 26);
            grayscalingToolStripMenuItem.Text = "Grayscaling";
            grayscalingToolStripMenuItem.Click += grayscalingToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(168, 26);
            inversionToolStripMenuItem.Text = "Inversion";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(168, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(168, 26);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // convolutionalToolsToolStripMenuItem
            // 
            convolutionalToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smoothingToolStripMenuItem, gaussianBlurToolStripMenuItem, meanRemovalToolStripMenuItem, embossingToolStripMenuItem, sharpenToolStripMenuItem, edgeToolStripMenuItem });
            convolutionalToolsToolStripMenuItem.Name = "convolutionalToolsToolStripMenuItem";
            convolutionalToolsToolStripMenuItem.Size = new Size(154, 24);
            convolutionalToolsToolStripMenuItem.Text = "Convolutional Tools";
            // 
            // smoothingToolStripMenuItem
            // 
            smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            smoothingToolStripMenuItem.Size = new Size(191, 26);
            smoothingToolStripMenuItem.Text = "Smoothing";
            smoothingToolStripMenuItem.Click += smoothingToolStripMenuItem_Click;
            // 
            // gaussianBlurToolStripMenuItem
            // 
            gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            gaussianBlurToolStripMenuItem.Size = new Size(191, 26);
            gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            gaussianBlurToolStripMenuItem.Click += gaussianBlurToolStripMenuItem_Click;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(191, 26);
            meanRemovalToolStripMenuItem.Text = "Mean Removal";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click;
            // 
            // embossingToolStripMenuItem
            // 
            embossingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { laplacianToolStripMenuItem, horizontalVerticalToolStripMenuItem, allDirectionsToolStripMenuItem, lossyToolStripMenuItem, horizontalToolStripMenuItem, verticalToolStripMenuItem, embossToolStripMenuItem });
            embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            embossingToolStripMenuItem.Size = new Size(191, 26);
            embossingToolStripMenuItem.Text = "Embossing";
            embossingToolStripMenuItem.Click += embossingToolStripMenuItem_Click;
            // 
            // laplacianToolStripMenuItem
            // 
            laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            laplacianToolStripMenuItem.Size = new Size(217, 26);
            laplacianToolStripMenuItem.Text = "Laplacian";
            laplacianToolStripMenuItem.Click += laplacianToolStripMenuItem_Click;
            // 
            // horizontalVerticalToolStripMenuItem
            // 
            horizontalVerticalToolStripMenuItem.Name = "horizontalVerticalToolStripMenuItem";
            horizontalVerticalToolStripMenuItem.Size = new Size(217, 26);
            horizontalVerticalToolStripMenuItem.Text = "Horizontal-Vertical";
            horizontalVerticalToolStripMenuItem.Click += horizontalVerticalToolStripMenuItem_Click;
            // 
            // allDirectionsToolStripMenuItem
            // 
            allDirectionsToolStripMenuItem.Name = "allDirectionsToolStripMenuItem";
            allDirectionsToolStripMenuItem.Size = new Size(217, 26);
            allDirectionsToolStripMenuItem.Text = "All Directions";
            allDirectionsToolStripMenuItem.Click += allDirectionsToolStripMenuItem_Click;
            // 
            // lossyToolStripMenuItem
            // 
            lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            lossyToolStripMenuItem.Size = new Size(217, 26);
            lossyToolStripMenuItem.Text = "Lossy";
            lossyToolStripMenuItem.Click += lossyToolStripMenuItem_Click;
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(217, 26);
            horizontalToolStripMenuItem.Text = "Horizontal";
            horizontalToolStripMenuItem.Click += horizontalToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(217, 26);
            verticalToolStripMenuItem.Text = "Vertical";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // embossToolStripMenuItem
            // 
            embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            embossToolStripMenuItem.Size = new Size(217, 26);
            embossToolStripMenuItem.Text = "Emboss";
            embossToolStripMenuItem.Click += embossToolStripMenuItem_Click;
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(191, 26);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // edgeToolStripMenuItem
            // 
            edgeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { detectToolStripMenuItem, enhanceToolStripMenuItem });
            edgeToolStripMenuItem.Name = "edgeToolStripMenuItem";
            edgeToolStripMenuItem.Size = new Size(191, 26);
            edgeToolStripMenuItem.Text = "Edge";
            // 
            // detectToolStripMenuItem
            // 
            detectToolStripMenuItem.Name = "detectToolStripMenuItem";
            detectToolStripMenuItem.Size = new Size(147, 26);
            detectToolStripMenuItem.Text = "Detect";
            detectToolStripMenuItem.Click += detectToolStripMenuItem_Click;
            // 
            // enhanceToolStripMenuItem
            // 
            enhanceToolStripMenuItem.Name = "enhanceToolStripMenuItem";
            enhanceToolStripMenuItem.Size = new Size(147, 26);
            enhanceToolStripMenuItem.Text = "Enhance";
            enhanceToolStripMenuItem.Click += enhanceToolStripMenuItem_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ControlLightLight;
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Subtraction";
            // 
            // button4
            // 
            button4.Location = new Point(657, 350);
            button4.Name = "button4";
            button4.Size = new Size(118, 32);
            button4.TabIndex = 13;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(536, 350);
            button3.Name = "button3";
            button3.Size = new Size(115, 32);
            button3.TabIndex = 12;
            button3.Text = "Subtract";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(279, 350);
            button2.Name = "button2";
            button2.Size = new Size(239, 32);
            button2.TabIndex = 11;
            button2.Text = "Load Background";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 350);
            button1.Name = "button1";
            button1.Size = new Size(239, 32);
            button1.TabIndex = 10;
            button1.Text = "Load Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(536, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(239, 309);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(279, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(239, 309);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(18, 35);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(238, 309);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.ControlLightLight;
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(pictureBox6);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 417);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Coins";
            tabPage4.Click += tabPage4_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(644, 248);
            label15.Name = "label15";
            label15.Size = new Size(17, 20);
            label15.TabIndex = 14;
            label15.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(644, 204);
            label14.Name = "label14";
            label14.Size = new Size(17, 20);
            label14.TabIndex = 13;
            label14.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(644, 174);
            label13.Name = "label13";
            label13.Size = new Size(17, 20);
            label13.TabIndex = 12;
            label13.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(644, 140);
            label12.Name = "label12";
            label12.Size = new Size(17, 20);
            label12.TabIndex = 11;
            label12.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(644, 106);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 10;
            label11.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(644, 70);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 9;
            label10.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(445, 248);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 8;
            label9.Text = "Total";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(445, 204);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 7;
            label8.Text = "5 Peso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(445, 174);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 6;
            label7.Text = "1 Peso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(445, 140);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 5;
            label6.Text = "25 Centavos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(445, 106);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 4;
            label5.Text = "10 Centavos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 70);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "5 Centavos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 23);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Coin Count";
            // 
            // button5
            // 
            button5.Location = new Point(21, 356);
            button5.Name = "button5";
            button5.Size = new Size(317, 29);
            button5.TabIndex = 1;
            button5.Text = "Start Coin Count";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(21, 23);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(317, 317);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 417);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "OR Neural Network";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // button8
            // 
            button8.Location = new Point(48, 218);
            button8.Name = "button8";
            button8.Size = new Size(249, 29);
            button8.TabIndex = 14;
            button8.Text = "Train";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(48, 183);
            button7.Name = "button7";
            button7.Size = new Size(249, 29);
            button7.TabIndex = 13;
            button7.Text = "Initialize";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(598, 42);
            label20.Name = "label20";
            label20.Size = new Size(55, 20);
            label20.TabIndex = 12;
            label20.Text = "Output";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(48, 135);
            label19.Name = "label19";
            label19.Size = new Size(56, 20);
            label19.TabIndex = 11;
            label19.Text = "Epochs";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(172, 128);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 10;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(48, 82);
            label18.Name = "label18";
            label18.Size = new Size(103, 20);
            label18.TabIndex = 9;
            label18.Text = "Hidden Layers";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(172, 75);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(48, 42);
            label17.Name = "label17";
            label17.Size = new Size(47, 20);
            label17.TabIndex = 7;
            label17.Text = "Fields";
            // 
            // button6
            // 
            button6.Location = new Point(598, 126);
            button6.Name = "button6";
            button6.Size = new Size(125, 29);
            button6.TabIndex = 6;
            button6.Text = "Load Output";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(420, 42);
            label16.Name = "label16";
            label16.Size = new Size(43, 20);
            label16.TabIndex = 5;
            label16.Text = "Input";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(598, 76);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(420, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(420, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(420, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(420, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk_1;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk_1;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            openFileDialog3.FileOk += openFileDialog3_FileOk;
            // 
            // saveFileDialog2
            // 
            saveFileDialog2.FileOk += saveFileDialog2_FileOk;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(48, 273);
            label21.Name = "label21";
            label21.Size = new Size(199, 20);
            label21.TabIndex = 15;
            label21.Text = "Minimum Hidden Neurons: 1";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(48, 305);
            label22.Name = "label22";
            label22.Size = new Size(162, 20);
            label22.TabIndex = 16;
            label22.Text = "Minimum Epochs: 5120";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form4";
            Text = "Form4";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem dIPToolStripMenuItem;
        private ToolStripMenuItem pixelCopyToolStripMenuItem;
        private ToolStripMenuItem grayscalingToolStripMenuItem;
        private ToolStripMenuItem inversionToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private TabPage tabPage4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private SaveFileDialog saveFileDialog2;
        private ToolStripMenuItem convolutionalToolsToolStripMenuItem;
        private ToolStripMenuItem smoothingToolStripMenuItem;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossingToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem laplacianToolStripMenuItem;
        private ToolStripMenuItem horizontalVerticalToolStripMenuItem;
        private ToolStripMenuItem allDirectionsToolStripMenuItem;
        private ToolStripMenuItem lossyToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripMenuItem embossToolStripMenuItem;
        private ToolStripMenuItem edgeToolStripMenuItem;
        private ToolStripMenuItem detectToolStripMenuItem;
        private ToolStripMenuItem enhanceToolStripMenuItem;
        private PictureBox pictureBox6;
        private Button button5;
        private Label label3;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label15;
        private Label label14;
        private TabPage tabPage3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label16;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button6;
        private Button button8;
        private Button button7;
        private Label label20;
        private Label label19;
        private TextBox textBox7;
        private Label label18;
        private TextBox textBox6;
        private Label label17;
        private Label label22;
        private Label label21;
    }
}