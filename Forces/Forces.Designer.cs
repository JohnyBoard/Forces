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
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.cbAreas = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.pnlField = new System.Windows.Forms.Panel();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.cbPlanets = new System.Windows.Forms.ComboBox();
            this.tlp.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.pnlField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 33;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tlp
            // 
            this.tlp.BackColor = System.Drawing.Color.White;
            this.tlp.ColumnCount = 2;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp.Controls.Add(this.pnlOptions, 0, 0);
            this.tlp.Controls.Add(this.pnlField, 1, 0);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.Size = new System.Drawing.Size(800, 450);
            this.tlp.TabIndex = 0;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlOptions.Controls.Add(this.cbPlanets);
            this.pnlOptions.Controls.Add(this.cbItems);
            this.pnlOptions.Controls.Add(this.cbAreas);
            this.pnlOptions.Controls.Add(this.button);
            this.pnlOptions.Controls.Add(this.tbVolume);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.Location = new System.Drawing.Point(3, 3);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(154, 444);
            this.pnlOptions.TabIndex = 1;
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(10, 69);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(133, 21);
            this.cbItems.TabIndex = 6;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // cbAreas
            // 
            this.cbAreas.FormattingEnabled = true;
            this.cbAreas.Location = new System.Drawing.Point(10, 42);
            this.cbAreas.Name = "cbAreas";
            this.cbAreas.Size = new System.Drawing.Size(133, 21);
            this.cbAreas.TabIndex = 5;
            this.cbAreas.SelectedIndexChanged += new System.EventHandler(this.cbAreas_SelectedIndexChanged);
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
            this.tbVolume.Location = new System.Drawing.Point(9, 3);
            this.tbVolume.Maximum = 1000;
            this.tbVolume.Minimum = 1;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(130, 45);
            this.tbVolume.TabIndex = 1;
            this.tbVolume.Value = 1;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // pnlField
            // 
            this.pnlField.Controls.Add(this.pbItem);
            this.pnlField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlField.Location = new System.Drawing.Point(163, 3);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(634, 444);
            this.pnlField.TabIndex = 0;
            // 
            // pbItem
            // 
            this.pbItem.Image = ((System.Drawing.Image)(resources.GetObject("pbItem.Image")));
            this.pbItem.Location = new System.Drawing.Point(3, 9);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(77, 73);
            this.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem.TabIndex = 0;
            this.pbItem.TabStop = false;
            // 
            // cbPlanets
            // 
            this.cbPlanets.FormattingEnabled = true;
            this.cbPlanets.Location = new System.Drawing.Point(10, 96);
            this.cbPlanets.Name = "cbPlanets";
            this.cbPlanets.Size = new System.Drawing.Size(133, 21);
            this.cbPlanets.TabIndex = 7;
            this.cbPlanets.SelectedIndexChanged += new System.EventHandler(this.cbPlanets_SelectedIndexChanged);
            // 
            // Forces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlp);
            this.Name = "Forces";
            this.Text = "Forces";
            this.tlp.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.pnlField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Panel pnlField;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.ComboBox cbAreas;
        private System.Windows.Forms.ComboBox cbPlanets;
    }
}