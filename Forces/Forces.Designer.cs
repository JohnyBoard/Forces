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
            this.pnlField = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.tbGravity = new System.Windows.Forms.TrackBar();
            this.tbBuyoancy = new System.Windows.Forms.TrackBar();
            this.button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlField.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGravity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBuyoancy)).BeginInit();
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
            // pnlField
            // 
            this.pnlField.Controls.Add(this.pbBall);
            this.pnlField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlField.Location = new System.Drawing.Point(163, 3);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(634, 444);
            this.pnlField.TabIndex = 0;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlOptions.Controls.Add(this.button);
            this.pnlOptions.Controls.Add(this.tbBuyoancy);
            this.pnlOptions.Controls.Add(this.tbGravity);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.Location = new System.Drawing.Point(3, 3);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(154, 444);
            this.pnlOptions.TabIndex = 1;
            // 
            // pbBall
            // 
            this.pbBall.Image = ((System.Drawing.Image)(resources.GetObject("pbBall.Image")));
            this.pbBall.Location = new System.Drawing.Point(249, 9);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(77, 73);
            this.pbBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBall.TabIndex = 0;
            this.pbBall.TabStop = false;
            // 
            // tbGravity
            // 
            this.tbGravity.Location = new System.Drawing.Point(10, 10);
            this.tbGravity.Name = "tbGravity";
            this.tbGravity.Size = new System.Drawing.Size(130, 45);
            this.tbGravity.TabIndex = 0;
            this.tbGravity.Scroll += new System.EventHandler(this.tbGravity_Scroll);
            // 
            // tbBuyoancy
            // 
            this.tbBuyoancy.Location = new System.Drawing.Point(10, 49);
            this.tbBuyoancy.Name = "tbBuyoancy";
            this.tbBuyoancy.Size = new System.Drawing.Size(130, 45);
            this.tbBuyoancy.TabIndex = 1;
            this.tbBuyoancy.Scroll += new System.EventHandler(this.tbBuyoancy_Scroll);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(6, 412);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(136, 23);
            this.button.TabIndex = 2;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
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
            this.pnlField.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGravity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBuyoancy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.TrackBar tbBuyoancy;
        private System.Windows.Forms.TrackBar tbGravity;
        private System.Windows.Forms.Panel pnlField;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.Button button;
    }
}