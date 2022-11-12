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
            this.mGroupBox = new System.Windows.Forms.GroupBox();
            this.mTrackBar = new System.Windows.Forms.TrackBar();
            this.ksGroupBox = new System.Windows.Forms.GroupBox();
            this.ksTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kdTrackBar = new System.Windows.Forms.TrackBar();
            this.sideViewPanel = new System.Windows.Forms.Panel();
            this.sideViewPictureBox = new System.Windows.Forms.PictureBox();
            this.debugTextBox = new System.Windows.Forms.RichTextBox();
            this.pauseBttn = new System.Windows.Forms.Button();
            this.startBttn = new System.Windows.Forms.Button();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.renderPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.controlsGroupBox.SuspendLayout();
            this.mGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).BeginInit();
            this.ksGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackBar)).BeginInit();
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
            this.controlsGroupBox.Controls.Add(this.mGroupBox);
            this.controlsGroupBox.Controls.Add(this.ksGroupBox);
            this.controlsGroupBox.Controls.Add(this.groupBox1);
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
            // mGroupBox
            // 
            this.mGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mGroupBox.Controls.Add(this.mTrackBar);
            this.mGroupBox.Location = new System.Drawing.Point(6, 433);
            this.mGroupBox.Name = "mGroupBox";
            this.mGroupBox.Size = new System.Drawing.Size(180, 55);
            this.mGroupBox.TabIndex = 7;
            this.mGroupBox.TabStop = false;
            this.mGroupBox.Text = "m";
            // 
            // mTrackBar
            // 
            this.mTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTrackBar.Location = new System.Drawing.Point(3, 23);
            this.mTrackBar.Maximum = 100;
            this.mTrackBar.Minimum = 1;
            this.mTrackBar.Name = "mTrackBar";
            this.mTrackBar.Size = new System.Drawing.Size(174, 29);
            this.mTrackBar.TabIndex = 4;
            this.mTrackBar.Value = 50;
            this.mTrackBar.ValueChanged += new System.EventHandler(this.MValueChanged);
            // 
            // ksGroupBox
            // 
            this.ksGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ksGroupBox.Controls.Add(this.ksTrackBar);
            this.ksGroupBox.Location = new System.Drawing.Point(6, 371);
            this.ksGroupBox.Name = "ksGroupBox";
            this.ksGroupBox.Size = new System.Drawing.Size(192, 56);
            this.ksGroupBox.TabIndex = 6;
            this.ksGroupBox.TabStop = false;
            this.ksGroupBox.Text = "ks";
            // 
            // ksTrackBar
            // 
            this.ksTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ksTrackBar.Location = new System.Drawing.Point(3, 23);
            this.ksTrackBar.Maximum = 100;
            this.ksTrackBar.Name = "ksTrackBar";
            this.ksTrackBar.Size = new System.Drawing.Size(186, 30);
            this.ksTrackBar.TabIndex = 4;
            this.ksTrackBar.Value = 50;
            this.ksTrackBar.ValueChanged += new System.EventHandler(this.KsValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.kdTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(9, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kd";
            // 
            // kdTrackBar
            // 
            this.kdTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdTrackBar.Location = new System.Drawing.Point(3, 23);
            this.kdTrackBar.Maximum = 100;
            this.kdTrackBar.Name = "kdTrackBar";
            this.kdTrackBar.Size = new System.Drawing.Size(186, 29);
            this.kdTrackBar.TabIndex = 4;
            this.kdTrackBar.Value = 50;
            this.kdTrackBar.ValueChanged += new System.EventHandler(this.KdValueChanged);
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
            // debugTextBox
            // 
            this.debugTextBox.Location = new System.Drawing.Point(6, 641);
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.Size = new System.Drawing.Size(181, 207);
            this.debugTextBox.TabIndex = 2;
            this.debugTextBox.Text = "";
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
            this.mGroupBox.ResumeLayout(false);
            this.mGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).EndInit();
            this.ksGroupBox.ResumeLayout(false);
            this.ksGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackBar)).EndInit();
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
        private GroupBox groupBox1;
        private TrackBar kdTrackBar;
        private GroupBox mGroupBox;
        private TrackBar mTrackBar;
        private GroupBox ksGroupBox;
        private TrackBar ksTrackBar;
    }
}