namespace WinFormsApp
{
    partial class TopLevelForm
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
            this.sideViewPanel = new System.Windows.Forms.Panel();
            this.sideViewPictureBox = new System.Windows.Forms.PictureBox();
            this.pauseBttn = new System.Windows.Forms.Button();
            this.startBttn = new System.Windows.Forms.Button();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.renderPictureBox = new System.Windows.Forms.PictureBox();
            this.debugTextBox = new System.Windows.Forms.RichTextBox();
            this.mainPanel.SuspendLayout();
            this.controlsGroupBox.SuspendLayout();
            this.sideViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideViewPictureBox)).BeginInit();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.controlsGroupBox);
            this.mainPanel.Controls.Add(this.canvasPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(973, 860);
            this.mainPanel.TabIndex = 0;
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.sideViewPanel);
            this.controlsGroupBox.Controls.Add(this.debugTextBox);
            this.controlsGroupBox.Controls.Add(this.pauseBttn);
            this.controlsGroupBox.Controls.Add(this.startBttn);
            this.controlsGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlsGroupBox.Location = new System.Drawing.Point(769, 0);
            this.controlsGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(204, 860);
            this.controlsGroupBox.TabIndex = 1;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // sideViewPanel
            // 
            this.sideViewPanel.Controls.Add(this.sideViewPictureBox);
            this.sideViewPanel.Location = new System.Drawing.Point(6, 26);
            this.sideViewPanel.Name = "sideViewPanel";
            this.sideViewPanel.Size = new System.Drawing.Size(186, 207);
            this.sideViewPanel.TabIndex = 3;
            // 
            // sideViewPictureBox
            // 
            this.sideViewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sideViewPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.sideViewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.sideViewPictureBox.Name = "sideViewPictureBox";
            this.sideViewPictureBox.Size = new System.Drawing.Size(186, 207);
            this.sideViewPictureBox.TabIndex = 0;
            this.sideViewPictureBox.TabStop = false;
            // 
            // pauseBttn
            // 
            this.pauseBttn.Location = new System.Drawing.Point(6, 276);
            this.pauseBttn.Margin = new System.Windows.Forms.Padding(5);
            this.pauseBttn.Name = "pauseBttn";
            this.pauseBttn.Size = new System.Drawing.Size(198, 29);
            this.pauseBttn.TabIndex = 1;
            this.pauseBttn.Text = "Pause";
            this.pauseBttn.UseVisualStyleBackColor = true;
            // 
            // startBttn
            // 
            this.startBttn.Location = new System.Drawing.Point(6, 239);
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
            this.canvasPanel.Controls.Add(this.renderPictureBox);
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(15);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(762, 860);
            this.canvasPanel.TabIndex = 0;
            // 
            // renderPictureBox
            // 
            this.renderPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.renderPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renderPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.renderPictureBox.Name = "renderPictureBox";
            this.renderPictureBox.Size = new System.Drawing.Size(762, 860);
            this.renderPictureBox.TabIndex = 0;
            this.renderPictureBox.TabStop = false;
            this.renderPictureBox.WaitOnLoad = true;
            this.renderPictureBox.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.renderPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // debugTextBox
            // 
            this.debugTextBox.Location = new System.Drawing.Point(3, 556);
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.Size = new System.Drawing.Size(181, 207);
            this.debugTextBox.TabIndex = 2;
            this.debugTextBox.Text = "";
            // 
            // TopLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 860);
            this.Controls.Add(this.mainPanel);
            this.Name = "TopLevelForm";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.controlsGroupBox.ResumeLayout(false);
            this.sideViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sideViewPictureBox)).EndInit();
            this.canvasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.renderPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private Panel canvasPanel;
        private PictureBox renderPictureBox;
        private GroupBox controlsGroupBox;
        private Button pauseBttn;
        private Button startBttn;
        private Panel sideViewPanel;
        private PictureBox sideViewPictureBox;
        private RichTextBox debugTextBox;
    }
}