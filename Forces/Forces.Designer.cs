namespace Forces
{
    partial class Forces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forces));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.button = new System.Windows.Forms.Button();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.tbMass = new System.Windows.Forms.TrackBar();
            this.pnlField = new System.Windows.Forms.Panel();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMass)).BeginInit();
            this.pnlField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 33;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.pnlOptions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlField, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlOptions.Controls.Add(this.lbArea);
            this.pnlOptions.Controls.Add(this.button);
            this.pnlOptions.Controls.Add(this.tbVolume);
            this.pnlOptions.Controls.Add(this.tbMass);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.Location = new System.Drawing.Point(3, 3);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(154, 444);
            this.pnlOptions.TabIndex = 1;
            // 
            // lbArea
            // 
            this.lbArea.FormattingEnabled = true;
            this.lbArea.Location = new System.Drawing.Point(9, 84);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(133, 95);
            this.lbArea.TabIndex = 3;
            this.lbArea.SelectedIndexChanged += new System.EventHandler(this.lbArea_SelectedIndexChanged);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.White;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(6, 400);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(136, 35);
            this.button.TabIndex = 2;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(10, 49);
            this.tbVolume.Maximum = 1000;
            this.tbVolume.Minimum = 1;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(130, 45);
            this.tbVolume.TabIndex = 1;
            this.tbVolume.Value = 1;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // tbMass
            // 
            this.tbMass.Location = new System.Drawing.Point(10, 10);
            this.tbMass.Maximum = 1000;
            this.tbMass.Minimum = 1;
            this.tbMass.Name = "tbMass";
            this.tbMass.Size = new System.Drawing.Size(130, 45);
            this.tbMass.TabIndex = 0;
            this.tbMass.Value = 1;
            this.tbMass.Scroll += new System.EventHandler(this.tbMass_Scroll);
            // 
            // pnlField
            // 
            this.pnlField.Controls.Add(this.pbBall);
            this.pnlField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlField.Location = new System.Drawing.Point(163, 3);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(634, 444);
            this.pnlField.TabIndex = 0;
            // 
            // pbBall
            // 
            this.pbBall.Image = ((System.Drawing.Image)(resources.GetObject("pbBall.Image")));
            this.pbBall.Location = new System.Drawing.Point(260, 180);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(77, 73);
            this.pbBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBall.TabIndex = 0;
            this.pbBall.TabStop = false;
            // 
            // Forces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Forces";
            this.Text = "Forces";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMass)).EndInit();
            this.pnlField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.TrackBar tbMass;
        private System.Windows.Forms.Panel pnlField;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ListBox lbArea;
    }
}