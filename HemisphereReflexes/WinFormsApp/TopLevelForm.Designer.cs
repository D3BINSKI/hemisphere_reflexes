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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vectorInterpolationSetRadioBttn = new System.Windows.Forms.RadioButton();
            this.colorInterpolationSetRadioBttn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zValueTrackBar = new System.Windows.Forms.TrackBar();
            this.mGroupBox = new System.Windows.Forms.GroupBox();
            this.mTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kdTrackBar = new System.Windows.Forms.TrackBar();
            this.ksGroupBox = new System.Windows.Forms.GroupBox();
            this.ksTrackBar = new System.Windows.Forms.TrackBar();
            this.pauseBttn = new System.Windows.Forms.Button();
            this.startBttn = new System.Windows.Forms.Button();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.renderPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.controlsGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zValueTrackBar)).BeginInit();
            this.mGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackBar)).BeginInit();
            this.ksGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackBar)).BeginInit();
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
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(851, 645);
            this.mainPanel.TabIndex = 0;
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.panel2);
            this.controlsGroupBox.Controls.Add(this.panel1);
            this.controlsGroupBox.Controls.Add(this.pauseBttn);
            this.controlsGroupBox.Controls.Add(this.startBttn);
            this.controlsGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlsGroupBox.Location = new System.Drawing.Point(673, 0);
            this.controlsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlsGroupBox.Size = new System.Drawing.Size(178, 645);
            this.controlsGroupBox.TabIndex = 1;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(5, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 183);
            this.panel2.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vectorInterpolationSetRadioBttn);
            this.groupBox3.Controls.Add(this.colorInterpolationSetRadioBttn);
            this.groupBox3.Location = new System.Drawing.Point(9, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 69);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color computation";
            // 
            // vectorInterpolationSetRadioBttn
            // 
            this.vectorInterpolationSetRadioBttn.AutoSize = true;
            this.vectorInterpolationSetRadioBttn.Checked = true;
            this.vectorInterpolationSetRadioBttn.Location = new System.Drawing.Point(3, 44);
            this.vectorInterpolationSetRadioBttn.Name = "vectorInterpolationSetRadioBttn";
            this.vectorInterpolationSetRadioBttn.Size = new System.Drawing.Size(129, 19);
            this.vectorInterpolationSetRadioBttn.TabIndex = 1;
            this.vectorInterpolationSetRadioBttn.TabStop = true;
            this.vectorInterpolationSetRadioBttn.Text = "vector interpolation";
            this.vectorInterpolationSetRadioBttn.UseVisualStyleBackColor = true;
            this.vectorInterpolationSetRadioBttn.CheckedChanged += new System.EventHandler(this.vectorInterpolationSetRadioBttn_CheckedChanged);
            // 
            // colorInterpolationSetRadioBttn
            // 
            this.colorInterpolationSetRadioBttn.AutoSize = true;
            this.colorInterpolationSetRadioBttn.Location = new System.Drawing.Point(6, 19);
            this.colorInterpolationSetRadioBttn.Name = "colorInterpolationSetRadioBttn";
            this.colorInterpolationSetRadioBttn.Size = new System.Drawing.Size(123, 19);
            this.colorInterpolationSetRadioBttn.TabIndex = 0;
            this.colorInterpolationSetRadioBttn.Text = "color interpolation";
            this.colorInterpolationSetRadioBttn.UseVisualStyleBackColor = true;
            this.colorInterpolationSetRadioBttn.CheckedChanged += new System.EventHandler(this.colorInterpolationSetRadioBttn_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.mGroupBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ksGroupBox);
            this.panel1.Location = new System.Drawing.Point(11, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 188);
            this.panel1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zValueTrackBar);
            this.groupBox2.Location = new System.Drawing.Point(6, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(143, 41);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "z";
            // 
            // zValueTrackBar
            // 
            this.zValueTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zValueTrackBar.Location = new System.Drawing.Point(3, 18);
            this.zValueTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zValueTrackBar.Maximum = 2000;
            this.zValueTrackBar.Minimum = 1;
            this.zValueTrackBar.Name = "zValueTrackBar";
            this.zValueTrackBar.Size = new System.Drawing.Size(137, 21);
            this.zValueTrackBar.TabIndex = 4;
            this.zValueTrackBar.Value = 50;
            this.zValueTrackBar.ValueChanged += new System.EventHandler(this.zValueTrackbarChanged);
            // 
            // mGroupBox
            // 
            this.mGroupBox.Controls.Add(this.mTrackBar);
            this.mGroupBox.Location = new System.Drawing.Point(6, 93);
            this.mGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mGroupBox.Name = "mGroupBox";
            this.mGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mGroupBox.Size = new System.Drawing.Size(143, 41);
            this.mGroupBox.TabIndex = 7;
            this.mGroupBox.TabStop = false;
            this.mGroupBox.Text = "m";
            // 
            // mTrackBar
            // 
            this.mTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTrackBar.Location = new System.Drawing.Point(3, 18);
            this.mTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mTrackBar.Maximum = 100;
            this.mTrackBar.Minimum = 1;
            this.mTrackBar.Name = "mTrackBar";
            this.mTrackBar.Size = new System.Drawing.Size(137, 21);
            this.mTrackBar.TabIndex = 4;
            this.mTrackBar.Value = 50;
            this.mTrackBar.ValueChanged += new System.EventHandler(this.MValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kdTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(149, 41);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kd";
            // 
            // kdTrackBar
            // 
            this.kdTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdTrackBar.Location = new System.Drawing.Point(3, 18);
            this.kdTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kdTrackBar.Maximum = 100;
            this.kdTrackBar.Name = "kdTrackBar";
            this.kdTrackBar.Size = new System.Drawing.Size(143, 21);
            this.kdTrackBar.TabIndex = 4;
            this.kdTrackBar.Value = 50;
            this.kdTrackBar.ValueChanged += new System.EventHandler(this.KdValueChanged);
            // 
            // ksGroupBox
            // 
            this.ksGroupBox.Controls.Add(this.ksTrackBar);
            this.ksGroupBox.Location = new System.Drawing.Point(3, 47);
            this.ksGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ksGroupBox.Name = "ksGroupBox";
            this.ksGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ksGroupBox.Size = new System.Drawing.Size(146, 42);
            this.ksGroupBox.TabIndex = 6;
            this.ksGroupBox.TabStop = false;
            this.ksGroupBox.Text = "ks";
            // 
            // ksTrackBar
            // 
            this.ksTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ksTrackBar.Location = new System.Drawing.Point(3, 18);
            this.ksTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ksTrackBar.Maximum = 100;
            this.ksTrackBar.Name = "ksTrackBar";
            this.ksTrackBar.Size = new System.Drawing.Size(140, 22);
            this.ksTrackBar.TabIndex = 4;
            this.ksTrackBar.Value = 50;
            this.ksTrackBar.ValueChanged += new System.EventHandler(this.KsValueChanged);
            // 
            // pauseBttn
            // 
            this.pauseBttn.Location = new System.Drawing.Point(5, 48);
            this.pauseBttn.Margin = new System.Windows.Forms.Padding(4);
            this.pauseBttn.Name = "pauseBttn";
            this.pauseBttn.Size = new System.Drawing.Size(167, 22);
            this.pauseBttn.TabIndex = 1;
            this.pauseBttn.Text = "Pause";
            this.pauseBttn.UseVisualStyleBackColor = true;
            this.pauseBttn.Click += new System.EventHandler(this.pauseBttn_Click);
            // 
            // startBttn
            // 
            this.startBttn.Location = new System.Drawing.Point(5, 20);
            this.startBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBttn.Name = "startBttn";
            this.startBttn.Size = new System.Drawing.Size(167, 22);
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
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(667, 645);
            this.canvasPanel.TabIndex = 0;
            // 
            // renderPictureBox
            // 
            this.renderPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.renderPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renderPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.renderPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.renderPictureBox.Name = "renderPictureBox";
            this.renderPictureBox.Size = new System.Drawing.Size(667, 645);
            this.renderPictureBox.TabIndex = 0;
            this.renderPictureBox.TabStop = false;
            this.renderPictureBox.WaitOnLoad = true;
            this.renderPictureBox.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.renderPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TopLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 645);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TopLevelForm";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.controlsGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zValueTrackBar)).EndInit();
            this.mGroupBox.ResumeLayout(false);
            this.mGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackBar)).EndInit();
            this.ksGroupBox.ResumeLayout(false);
            this.ksGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackBar)).EndInit();
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
        private GroupBox groupBox1;
        private TrackBar kdTrackBar;
        private GroupBox mGroupBox;
        private TrackBar mTrackBar;
        private GroupBox ksGroupBox;
        private TrackBar ksTrackBar;
        private Panel panel1;
        private GroupBox groupBox2;
        private TrackBar zValueTrackBar;
        private Button startBttn;
        private Panel panel2;
        private GroupBox groupBox3;
        private RadioButton vectorInterpolationSetRadioBttn;
        private RadioButton colorInterpolationSetRadioBttn;
    }
}