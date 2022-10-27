namespace WinFormsApp
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.debugTextBox = new System.Windows.Forms.RichTextBox();
            this.pauseBttn = new System.Windows.Forms.Button();
            this.startBttn = new System.Windows.Forms.Button();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.controlsGroupBox.SuspendLayout();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.controlsGroupBox);
            this.mainPanel.Controls.Add(this.canvasPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(901, 521);
            this.mainPanel.TabIndex = 0;
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.debugTextBox);
            this.controlsGroupBox.Controls.Add(this.pauseBttn);
            this.controlsGroupBox.Controls.Add(this.startBttn);
            this.controlsGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlsGroupBox.Location = new System.Drawing.Point(697, 0);
            this.controlsGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(204, 521);
            this.controlsGroupBox.TabIndex = 1;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // debugTextBox
            // 
            this.debugTextBox.Location = new System.Drawing.Point(11, 160);
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.Size = new System.Drawing.Size(181, 207);
            this.debugTextBox.TabIndex = 2;
            this.debugTextBox.Text = "";
            // 
            // pauseBttn
            // 
            this.pauseBttn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pauseBttn.Location = new System.Drawing.Point(3, 52);
            this.pauseBttn.Margin = new System.Windows.Forms.Padding(5);
            this.pauseBttn.Name = "pauseBttn";
            this.pauseBttn.Size = new System.Drawing.Size(198, 29);
            this.pauseBttn.TabIndex = 1;
            this.pauseBttn.Text = "Pause";
            this.pauseBttn.UseVisualStyleBackColor = true;
            // 
            // startBttn
            // 
            this.startBttn.Dock = System.Windows.Forms.DockStyle.Top;
            this.startBttn.Location = new System.Drawing.Point(3, 23);
            this.startBttn.Name = "startBttn";
            this.startBttn.Size = new System.Drawing.Size(198, 29);
            this.startBttn.TabIndex = 0;
            this.startBttn.Text = "Start";
            this.startBttn.UseVisualStyleBackColor = true;
            this.startBttn.Click += new System.EventHandler(this.startBttn_Click);
            // 
            // canvasPanel
            // 
            this.canvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPanel.Controls.Add(this.pictureBox1);
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(15);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(690, 521);
            this.canvasPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(688, 519);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 521);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.controlsGroupBox.ResumeLayout(false);
            this.canvasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private Panel canvasPanel;
        private PictureBox pictureBox1;
        private GroupBox controlsGroupBox;
        private Button pauseBttn;
        private Button startBttn;
        private RichTextBox debugTextBox;
    }
}