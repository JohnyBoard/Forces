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
            this.lblArchimed = new System.Windows.Forms.Label();
            this.lblGravity = new System.Windows.Forms.Label();
            this.lblItemMass = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblItemDensity = new System.Windows.Forms.Label();
            this.lblAreaDensity = new System.Windows.Forms.Label();
            this.cbPlanets = new System.Windows.Forms.ComboBox();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.cbAreas = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.pnlField = new System.Windows.Forms.Panel();
            this.pbBalloon = new System.Windows.Forms.PictureBox();
            this.pbWeight = new System.Windows.Forms.PictureBox();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.trAddedVolume = new System.Windows.Forms.TrackBar();
            this.tlp.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.pnlField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalloon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trAddedVolume)).BeginInit();
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
            this.tlp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.Size = new System.Drawing.Size(1067, 554);
            this.tlp.TabIndex = 0;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlOptions.Controls.Add(this.trAddedVolume);
            this.pnlOptions.Controls.Add(this.lblArchimed);
            this.pnlOptions.Controls.Add(this.lblGravity);
            this.pnlOptions.Controls.Add(this.lblItemMass);
            this.pnlOptions.Controls.Add(this.lblVolume);
            this.pnlOptions.Controls.Add(this.lblItemDensity);
            this.pnlOptions.Controls.Add(this.lblAreaDensity);
            this.pnlOptions.Controls.Add(this.cbPlanets);
            this.pnlOptions.Controls.Add(this.cbItems);
            this.pnlOptions.Controls.Add(this.cbAreas);
            this.pnlOptions.Controls.Add(this.button);
            this.pnlOptions.Controls.Add(this.tbVolume);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.Location = new System.Drawing.Point(4, 4);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(205, 546);
            this.pnlOptions.TabIndex = 1;
            // 
            // lblArchimed
            // 
            this.lblArchimed.AutoSize = true;
            this.lblArchimed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArchimed.Location = new System.Drawing.Point(12, 272);
            this.lblArchimed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchimed.Name = "lblArchimed";
            this.lblArchimed.Size = new System.Drawing.Size(149, 22);
            this.lblArchimed.TabIndex = 13;
            this.lblArchimed.Text = "Сила Архимеда:";
            // 
            // lblGravity
            // 
            this.lblGravity.AutoSize = true;
            this.lblGravity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGravity.Location = new System.Drawing.Point(12, 249);
            this.lblGravity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGravity.Name = "lblGravity";
            this.lblGravity.Size = new System.Drawing.Size(134, 22);
            this.lblGravity.TabIndex = 12;
            this.lblGravity.Text = "Сила тяжести:";
            // 
            // lblItemMass
            // 
            this.lblItemMass.AutoSize = true;
            this.lblItemMass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblItemMass.Location = new System.Drawing.Point(12, 225);
            this.lblItemMass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemMass.Name = "lblItemMass";
            this.lblItemMass.Size = new System.Drawing.Size(111, 22);
            this.lblItemMass.TabIndex = 11;
            this.lblItemMass.Text = "Масса тела:";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVolume.Location = new System.Drawing.Point(12, 202);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(114, 22);
            this.lblVolume.TabIndex = 10;
            this.lblVolume.Text = "Объем тела:";
            // 
            // lblItemDensity
            // 
            this.lblItemDensity.AutoSize = true;
            this.lblItemDensity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblItemDensity.Location = new System.Drawing.Point(12, 178);
            this.lblItemDensity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemDensity.Name = "lblItemDensity";
            this.lblItemDensity.Size = new System.Drawing.Size(149, 22);
            this.lblItemDensity.TabIndex = 9;
            this.lblItemDensity.Text = "Плотность тела:";
            // 
            // lblAreaDensity
            // 
            this.lblAreaDensity.AutoSize = true;
            this.lblAreaDensity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAreaDensity.Location = new System.Drawing.Point(12, 155);
            this.lblAreaDensity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreaDensity.Name = "lblAreaDensity";
            this.lblAreaDensity.Size = new System.Drawing.Size(163, 22);
            this.lblAreaDensity.TabIndex = 8;
            this.lblAreaDensity.Text = "Плотность среды:";
            // 
            // cbPlanets
            // 
            this.cbPlanets.FormattingEnabled = true;
            this.cbPlanets.Location = new System.Drawing.Point(13, 118);
            this.cbPlanets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPlanets.Name = "cbPlanets";
            this.cbPlanets.Size = new System.Drawing.Size(176, 24);
            this.cbPlanets.TabIndex = 7;
            this.cbPlanets.SelectedIndexChanged += new System.EventHandler(this.cbPlanets_SelectedIndexChanged);
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(13, 85);
            this.cbItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(176, 24);
            this.cbItems.TabIndex = 6;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // cbAreas
            // 
            this.cbAreas.FormattingEnabled = true;
            this.cbAreas.Location = new System.Drawing.Point(13, 52);
            this.cbAreas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAreas.Name = "cbAreas";
            this.cbAreas.Size = new System.Drawing.Size(176, 24);
            this.cbAreas.TabIndex = 5;
            this.cbAreas.SelectedIndexChanged += new System.EventHandler(this.cbAreas_SelectedIndexChanged);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.White;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(8, 492);
            this.button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(181, 43);
            this.button.TabIndex = 2;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(12, 4);
            this.tbVolume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVolume.Maximum = 1000;
            this.tbVolume.Minimum = 1;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(173, 56);
            this.tbVolume.TabIndex = 1;
            this.tbVolume.Value = 1;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // pnlField
            // 
            this.pnlField.Controls.Add(this.pbBalloon);
            this.pnlField.Controls.Add(this.pbWeight);
            this.pnlField.Controls.Add(this.pbItem);
            this.pnlField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlField.Location = new System.Drawing.Point(217, 4);
            this.pnlField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(846, 546);
            this.pnlField.TabIndex = 0;
            // 
            // pbBalloon
            // 
            this.pbBalloon.Image = ((System.Drawing.Image)(resources.GetObject("pbBalloon.Image")));
            this.pbBalloon.Location = new System.Drawing.Point(357, 134);
            this.pbBalloon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBalloon.Name = "pbBalloon";
            this.pbBalloon.Size = new System.Drawing.Size(103, 90);
            this.pbBalloon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBalloon.TabIndex = 2;
            this.pbBalloon.TabStop = false;
            // 
            // pbWeight
            // 
            this.pbWeight.Image = ((System.Drawing.Image)(resources.GetObject("pbWeight.Image")));
            this.pbWeight.Location = new System.Drawing.Point(357, 330);
            this.pbWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbWeight.Name = "pbWeight";
            this.pbWeight.Size = new System.Drawing.Size(103, 90);
            this.pbWeight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWeight.TabIndex = 1;
            this.pbWeight.TabStop = false;
            // 
            // pbItem
            // 
            this.pbItem.Image = ((System.Drawing.Image)(resources.GetObject("pbItem.Image")));
            this.pbItem.Location = new System.Drawing.Point(357, 232);
            this.pbItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(103, 90);
            this.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem.TabIndex = 0;
            this.pbItem.TabStop = false;
            // 
            // trAddedVolume
            // 
            this.trAddedVolume.Location = new System.Drawing.Point(13, 319);
            this.trAddedVolume.Margin = new System.Windows.Forms.Padding(4);
            this.trAddedVolume.Maximum = 200;
            this.trAddedVolume.Name = "trAddedVolume";
            this.trAddedVolume.Size = new System.Drawing.Size(173, 56);
            this.trAddedVolume.TabIndex = 14;
            this.trAddedVolume.Value = 1;
            this.trAddedVolume.Scroll += new System.EventHandler(this.trAddedVolume_Scroll);
            // 
            // Forces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tlp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Forces";
            this.Text = "Forces";
            this.tlp.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.pnlField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBalloon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trAddedVolume)).EndInit();
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
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblItemDensity;
        private System.Windows.Forms.Label lblAreaDensity;
        private System.Windows.Forms.PictureBox pbWeight;
        private System.Windows.Forms.Label lblItemMass;
        private System.Windows.Forms.Label lblArchimed;
        private System.Windows.Forms.Label lblGravity;
        private System.Windows.Forms.PictureBox pbBalloon;
        private System.Windows.Forms.TrackBar trAddedVolume;
    }
}