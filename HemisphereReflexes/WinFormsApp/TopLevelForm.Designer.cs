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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.setRenderObjectBttn = new System.Windows.Forms.Button();
            this.setRenderObjectColorBttn = new System.Windows.Forms.Button();
            this.chngTextureBttn = new System.Windows.Forms.Button();
            this.changeNormalMapBttn = new System.Windows.Forms.Button();
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
            this.groupBox4.SuspendLayout();
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
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(854, 671);
            this.mainPanel.TabIndex = 0;
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.panel2);
            this.controlsGroupBox.Controls.Add(this.panel1);
            this.controlsGroupBox.Controls.Add(this.pauseBttn);
            this.controlsGroupBox.Controls.Add(this.startBttn);
            this.controlsGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlsGroupBox.Location = new System.Drawing.Point(651, 0);
            this.controlsGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(203, 671);
            this.controlsGroupBox.TabIndex = 1;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.setRenderObjectBttn);
            this.panel2.Controls.Add(this.setRenderObjectColorBttn);
            this.panel2.Controls.Add(this.chngTextureBttn);
            this.panel2.Controls.Add(this.changeNormalMapBttn);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(6, 361);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 306);
            this.panel2.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(3, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 85);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vector modification";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton2.Location = new System.Drawing.Point(3, 47);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(165, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Height Map";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.Location = new System.Drawing.Point(3, 23);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(165, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Normal Map";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // setRenderObjectBttn
            // 
            this.setRenderObjectBttn.AutoSize = true;
            this.setRenderObjectBttn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.setRenderObjectBttn.Location = new System.Drawing.Point(0, 188);
            this.setRenderObjectBttn.Name = "setRenderObjectBttn";
            this.setRenderObjectBttn.Size = new System.Drawing.Size(184, 30);
            this.setRenderObjectBttn.TabIndex = 4;
            this.setRenderObjectBttn.Text = "Set Render Object";
            this.setRenderObjectBttn.UseVisualStyleBackColor = true;
            this.setRenderObjectBttn.Click += new System.EventHandler(this.setRenderObjectBttn_Click);
            // 
            // setRenderObjectColorBttn
            // 
            this.setRenderObjectColorBttn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.setRenderObjectColorBttn.Location = new System.Drawing.Point(0, 218);
            this.setRenderObjectColorBttn.Name = "setRenderObjectColorBttn";
            this.setRenderObjectColorBttn.Size = new System.Drawing.Size(184, 29);
            this.setRenderObjectColorBttn.TabIndex = 3;
            this.setRenderObjectColorBttn.Text = "Set Static Color";
            this.setRenderObjectColorBttn.UseVisualStyleBackColor = true;
            this.setRenderObjectColorBttn.Click += new System.EventHandler(this.setRenderObjectColorBttn_Click);
            // 
            // chngTextureBttn
            // 
            this.chngTextureBttn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chngTextureBttn.Location = new System.Drawing.Point(0, 247);
            this.chngTextureBttn.Name = "chngTextureBttn";
            this.chngTextureBttn.Size = new System.Drawing.Size(184, 29);
            this.chngTextureBttn.TabIndex = 2;
            this.chngTextureBttn.Text = "Set Texture";
            this.chngTextureBttn.UseVisualStyleBackColor = true;
            this.chngTextureBttn.Click += new System.EventHandler(this.chngTextureBttn_Click);
            // 
            // changeNormalMapBttn
            // 
            this.changeNormalMapBttn.AutoSize = true;
            this.changeNormalMapBttn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.changeNormalMapBttn.Location = new System.Drawing.Point(0, 276);
            this.changeNormalMapBttn.Name = "changeNormalMapBttn";
            this.changeNormalMapBttn.Size = new System.Drawing.Size(184, 30);
            this.changeNormalMapBttn.TabIndex = 1;
            this.changeNormalMapBttn.Text = "Set Normal Map";
            this.changeNormalMapBttn.UseVisualStyleBackColor = true;
            this.changeNormalMapBttn.Click += new System.EventHandler(this.changeNormalMapBttn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vectorInterpolationSetRadioBttn);
            this.groupBox3.Controls.Add(this.colorInterpolationSetRadioBttn);
            this.groupBox3.Location = new System.Drawing.Point(10, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(163, 92);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color computation";
            // 
            // vectorInterpolationSetRadioBttn
            // 
            this.vectorInterpolationSetRadioBttn.AutoSize = true;
            this.vectorInterpolationSetRadioBttn.Checked = true;
            this.vectorInterpolationSetRadioBttn.Location = new System.Drawing.Point(3, 59);
            this.vectorInterpolationSetRadioBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vectorInterpolationSetRadioBttn.Name = "vectorInterpolationSetRadioBttn";
            this.vectorInterpolationSetRadioBttn.Size = new System.Drawing.Size(161, 24);
            this.vectorInterpolationSetRadioBttn.TabIndex = 1;
            this.vectorInterpolationSetRadioBttn.TabStop = true;
            this.vectorInterpolationSetRadioBttn.Text = "vector interpolation";
            this.vectorInterpolationSetRadioBttn.UseVisualStyleBackColor = true;
            this.vectorInterpolationSetRadioBttn.CheckedChanged += new System.EventHandler(this.vectorInterpolationSetRadioBttn_CheckedChanged);
            // 
            // colorInterpolationSetRadioBttn
            // 
            this.colorInterpolationSetRadioBttn.AutoSize = true;
            this.colorInterpolationSetRadioBttn.Location = new System.Drawing.Point(7, 25);
            this.colorInterpolationSetRadioBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorInterpolationSetRadioBttn.Name = "colorInterpolationSetRadioBttn";
            this.colorInterpolationSetRadioBttn.Size = new System.Drawing.Size(154, 24);
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
            this.panel1.Location = new System.Drawing.Point(13, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 251);
            this.panel1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zValueTrackBar);
            this.groupBox2.Location = new System.Drawing.Point(7, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 55);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "z";
            // 
            // zValueTrackBar
            // 
            this.zValueTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zValueTrackBar.Location = new System.Drawing.Point(3, 23);
            this.zValueTrackBar.Maximum = 2000;
            this.zValueTrackBar.Minimum = 1;
            this.zValueTrackBar.Name = "zValueTrackBar";
            this.zValueTrackBar.Size = new System.Drawing.Size(157, 29);
            this.zValueTrackBar.TabIndex = 4;
            this.zValueTrackBar.Value = 50;
            this.zValueTrackBar.ValueChanged += new System.EventHandler(this.ZValueTrackbarChanged);
            // 
            // mGroupBox
            // 
            this.mGroupBox.Controls.Add(this.mTrackBar);
            this.mGroupBox.Location = new System.Drawing.Point(7, 124);
            this.mGroupBox.Name = "mGroupBox";
            this.mGroupBox.Size = new System.Drawing.Size(163, 55);
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
            this.mTrackBar.Size = new System.Drawing.Size(157, 29);
            this.mTrackBar.TabIndex = 4;
            this.mTrackBar.Value = 50;
            this.mTrackBar.ValueChanged += new System.EventHandler(this.MValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kdTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 55);
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
            this.kdTrackBar.Size = new System.Drawing.Size(164, 29);
            this.kdTrackBar.TabIndex = 4;
            this.kdTrackBar.Value = 50;
            this.kdTrackBar.ValueChanged += new System.EventHandler(this.KdValueChanged);
            // 
            // ksGroupBox
            // 
            this.ksGroupBox.Controls.Add(this.ksTrackBar);
            this.ksGroupBox.Location = new System.Drawing.Point(3, 63);
            this.ksGroupBox.Name = "ksGroupBox";
            this.ksGroupBox.Size = new System.Drawing.Size(167, 56);
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
            this.ksTrackBar.Size = new System.Drawing.Size(161, 30);
            this.ksTrackBar.TabIndex = 4;
            this.ksTrackBar.Value = 50;
            this.ksTrackBar.ValueChanged += new System.EventHandler(this.KsValueChanged);
            // 
            // pauseBttn
            // 
            this.pauseBttn.Location = new System.Drawing.Point(6, 64);
            this.pauseBttn.Margin = new System.Windows.Forms.Padding(5);
            this.pauseBttn.Name = "pauseBttn";
            this.pauseBttn.Size = new System.Drawing.Size(191, 29);
            this.pauseBttn.TabIndex = 1;
            this.pauseBttn.Text = "Pause";
            this.pauseBttn.UseVisualStyleBackColor = true;
            this.pauseBttn.Click += new System.EventHandler(this.pauseBttn_Click);
            // 
            // startBttn
            // 
            this.startBttn.Location = new System.Drawing.Point(6, 27);
            this.startBttn.Name = "startBttn";
            this.startBttn.Size = new System.Drawing.Size(191, 29);
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
            this.canvasPanel.Size = new System.Drawing.Size(643, 671);
            this.canvasPanel.TabIndex = 0;
            // 
            // renderPictureBox
            // 
            this.renderPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.renderPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renderPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.renderPictureBox.Name = "renderPictureBox";
            this.renderPictureBox.Size = new System.Drawing.Size(643, 671);
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
            this.ClientSize = new System.Drawing.Size(854, 671);
            this.Controls.Add(this.mainPanel);
            this.Name = "TopLevelForm";
            this.Text = "Light Simulation";
            this.mainPanel.ResumeLayout(false);
            this.controlsGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private Button chngTextureBttn;
        private Button changeNormalMapBttn;
        private Button setRenderObjectColorBttn;
        private Button setRenderObjectBttn;
        private GroupBox groupBox4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}