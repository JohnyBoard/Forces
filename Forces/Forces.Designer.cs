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
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblMass = new System.Windows.Forms.Label();
            this.lblItemDensity = new System.Windows.Forms.Label();
            this.lblAreaDensity = new System.Windows.Forms.Label();
            this.lblGravity = new System.Windows.Forms.Label();
            this.lblBuyoancy = new System.Windows.Forms.Label();
            this.tbAddedMass = new System.Windows.Forms.TrackBar();
            this.tbAddedVolume = new System.Windows.Forms.TrackBar();
            this.cbPlanets = new System.Windows.Forms.ComboBox();
            this.cbEntities = new System.Windows.Forms.ComboBox();
            this.cbAreas = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.pnlField = new System.Windows.Forms.Panel();
            this.pbBalloon = new System.Windows.Forms.PictureBox();
            this.pbWeight = new System.Windows.Forms.PictureBox();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.tlp.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddedMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddedVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.pnlField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalloon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeight)).BeginInit();
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
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.5F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.5F));
            this.tlp.Controls.Add(this.pnlOptions, 0, 0);
            this.tlp.Controls.Add(this.pnlField, 1, 0);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.Size = new System.Drawing.Size(987, 611);
            this.tlp.TabIndex = 0;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlOptions.Controls.Add(this.lblVolume);
            this.pnlOptions.Controls.Add(this.lblMass);
            this.pnlOptions.Controls.Add(this.lblItemDensity);
            this.pnlOptions.Controls.Add(this.lblAreaDensity);
            this.pnlOptions.Controls.Add(this.lblGravity);
            this.pnlOptions.Controls.Add(this.lblBuyoancy);
            this.pnlOptions.Controls.Add(this.tbAddedMass);
            this.pnlOptions.Controls.Add(this.tbAddedVolume);
            this.pnlOptions.Controls.Add(this.cbPlanets);
            this.pnlOptions.Controls.Add(this.cbEntities);
            this.pnlOptions.Controls.Add(this.cbAreas);
            this.pnlOptions.Controls.Add(this.button);
            this.pnlOptions.Controls.Add(this.tbVolume);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.Location = new System.Drawing.Point(3, 3);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(285, 605);
            this.pnlOptions.TabIndex = 1;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVolume.Location = new System.Drawing.Point(9, 326);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(106, 19);
            this.lblVolume.TabIndex = 22;
            this.lblVolume.Text = "Общий объём:";
            // 
            // lblMass
            // 
            this.lblMass.AutoSize = true;
            this.lblMass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMass.Location = new System.Drawing.Point(8, 307);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(99, 19);
            this.lblMass.TabIndex = 21;
            this.lblMass.Text = "Общая масса:";
            // 
            // lblItemDensity
            // 
            this.lblItemDensity.AutoSize = true;
            this.lblItemDensity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblItemDensity.Location = new System.Drawing.Point(9, 288);
            this.lblItemDensity.Name = "lblItemDensity";
            this.lblItemDensity.Size = new System.Drawing.Size(117, 19);
            this.lblItemDensity.TabIndex = 20;
            this.lblItemDensity.Text = "Плотность тела:";
            // 
            // lblAreaDensity
            // 
            this.lblAreaDensity.AutoSize = true;
            this.lblAreaDensity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAreaDensity.Location = new System.Drawing.Point(9, 269);
            this.lblAreaDensity.Name = "lblAreaDensity";
            this.lblAreaDensity.Size = new System.Drawing.Size(129, 19);
            this.lblAreaDensity.TabIndex = 19;
            this.lblAreaDensity.Text = "Плотность среды:";
            // 
            // lblGravity
            // 
            this.lblGravity.AutoSize = true;
            this.lblGravity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGravity.Location = new System.Drawing.Point(10, 250);
            this.lblGravity.Name = "lblGravity";
            this.lblGravity.Size = new System.Drawing.Size(134, 19);
            this.lblGravity.TabIndex = 18;
            this.lblGravity.Text = "Сила притяжения:";
            // 
            // lblBuyoancy
            // 
            this.lblBuyoancy.AutoSize = true;
            this.lblBuyoancy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBuyoancy.Location = new System.Drawing.Point(10, 229);
            this.lblBuyoancy.Name = "lblBuyoancy";
            this.lblBuyoancy.Size = new System.Drawing.Size(118, 19);
            this.lblBuyoancy.TabIndex = 16;
            this.lblBuyoancy.Text = "Сила Архимеда:";
            // 
            // tbAddedMass
            // 
            this.tbAddedMass.Location = new System.Drawing.Point(12, 192);
            this.tbAddedMass.Maximum = 300;
            this.tbAddedMass.Minimum = 30;
            this.tbAddedMass.Name = "tbAddedMass";
            this.tbAddedMass.Size = new System.Drawing.Size(270, 45);
            this.tbAddedMass.TabIndex = 15;
            this.tbAddedMass.Value = 30;
            this.tbAddedMass.Scroll += new System.EventHandler(this.tbAddedMass_Scroll);
            // 
            // tbAddedVolume
            // 
            this.tbAddedVolume.Location = new System.Drawing.Point(12, 90);
            this.tbAddedVolume.Maximum = 300;
            this.tbAddedVolume.Minimum = 30;
            this.tbAddedVolume.Name = "tbAddedVolume";
            this.tbAddedVolume.Size = new System.Drawing.Size(270, 45);
            this.tbAddedVolume.TabIndex = 14;
            this.tbAddedVolume.Value = 30;
            this.tbAddedVolume.Scroll += new System.EventHandler(this.tbAddedVolume_Scroll);
            // 
            // cbPlanets
            // 
            this.cbPlanets.FormattingEnabled = true;
            this.cbPlanets.Location = new System.Drawing.Point(10, 63);
            this.cbPlanets.Name = "cbPlanets";
            this.cbPlanets.Size = new System.Drawing.Size(272, 21);
            this.cbPlanets.TabIndex = 7;
            this.cbPlanets.SelectedIndexChanged += new System.EventHandler(this.cbPlanets_SelectedIndexChanged);
            // 
            // cbEntities
            // 
            this.cbEntities.FormattingEnabled = true;
            this.cbEntities.Location = new System.Drawing.Point(10, 36);
            this.cbEntities.Name = "cbEntities";
            this.cbEntities.Size = new System.Drawing.Size(272, 21);
            this.cbEntities.TabIndex = 6;
            this.cbEntities.SelectedIndexChanged += new System.EventHandler(this.cbEntities_SelectedIndexChanged);
            // 
            // cbAreas
            // 
            this.cbAreas.FormattingEnabled = true;
            this.cbAreas.Location = new System.Drawing.Point(10, 9);
            this.cbAreas.Name = "cbAreas";
            this.cbAreas.Size = new System.Drawing.Size(272, 21);
            this.cbAreas.TabIndex = 5;
            this.cbAreas.SelectedIndexChanged += new System.EventHandler(this.cbAreas_SelectedIndexChanged);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.White;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(7, 567);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(275, 35);
            this.button.TabIndex = 2;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(13, 138);
            this.tbVolume.Maximum = 300;
            this.tbVolume.Minimum = 30;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(269, 45);
            this.tbVolume.TabIndex = 1;
            this.tbVolume.Value = 30;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // pnlField
            // 
            this.pnlField.Controls.Add(this.pbBalloon);
            this.pnlField.Controls.Add(this.pbWeight);
            this.pnlField.Controls.Add(this.pbItem);
            this.pnlField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlField.Location = new System.Drawing.Point(294, 3);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(690, 605);
            this.pnlField.TabIndex = 0;
            // 
            // pbBalloon
            // 
            this.pbBalloon.Image = ((System.Drawing.Image)(resources.GetObject("pbBalloon.Image")));
            this.pbBalloon.Location = new System.Drawing.Point(268, 110);
            this.pbBalloon.Name = "pbBalloon";
            this.pbBalloon.Size = new System.Drawing.Size(77, 73);
            this.pbBalloon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBalloon.TabIndex = 2;
            this.pbBalloon.TabStop = false;
            // 
            // pbWeight
            // 
            this.pbWeight.Image = ((System.Drawing.Image)(resources.GetObject("pbWeight.Image")));
            this.pbWeight.Location = new System.Drawing.Point(268, 269);
            this.pbWeight.Name = "pbWeight";
            this.pbWeight.Size = new System.Drawing.Size(77, 73);
            this.pbWeight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWeight.TabIndex = 1;
            this.pbWeight.TabStop = false;
            // 
            // pbItem
            // 
            this.pbItem.Image = ((System.Drawing.Image)(resources.GetObject("pbItem.Image")));
            this.pbItem.Location = new System.Drawing.Point(268, 190);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(77, 73);
            this.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem.TabIndex = 0;
            this.pbItem.TabStop = false;
            // 
            // Forces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 611);
            this.Controls.Add(this.tlp);
            this.Name = "Forces";
            this.Text = "Forces";
            this.tlp.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddedMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddedVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.pnlField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBalloon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.Panel pnlField;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.PictureBox pbWeight;
        private System.Windows.Forms.PictureBox pbBalloon;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.TrackBar tbAddedMass;
        private System.Windows.Forms.TrackBar tbAddedVolume;
        private System.Windows.Forms.ComboBox cbPlanets;
        private System.Windows.Forms.ComboBox cbEntities;
        private System.Windows.Forms.ComboBox cbAreas;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label lblItemDensity;
        private System.Windows.Forms.Label lblAreaDensity;
        private System.Windows.Forms.Label lblGravity;
        private System.Windows.Forms.Label lblBuyoancy;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblMass;
    }
}