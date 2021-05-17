namespace Forces
{
    partial class Impuls
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
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pnlField = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tbMass1 = new System.Windows.Forms.TrackBar();
            this.tbMass2 = new System.Windows.Forms.TrackBar();
            this.tlpMenu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMass2)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMenu
            // 
            this.tlpMenu.ColumnCount = 2;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpMenu.Controls.Add(this.pnlMenu, 0, 0);
            this.tlpMenu.Controls.Add(this.pnlField, 1, 0);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(800, 450);
            this.tlpMenu.TabIndex = 0;
            // 
            // pnlField
            // 
            this.pnlField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlField.Location = new System.Drawing.Point(163, 3);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(634, 444);
            this.pnlField.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlMenu.Controls.Add(this.tbMass2);
            this.pnlMenu.Controls.Add(this.tbMass1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(3, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(154, 444);
            this.pnlMenu.TabIndex = 1;
            // 
            // tbMass1
            // 
            this.tbMass1.Location = new System.Drawing.Point(4, 3);
            this.tbMass1.Name = "tbMass1";
            this.tbMass1.Size = new System.Drawing.Size(147, 45);
            this.tbMass1.TabIndex = 0;
            this.tbMass1.Scroll += new System.EventHandler(this.tbMass1_Scroll);
            // 
            // tbMass2
            // 
            this.tbMass2.Location = new System.Drawing.Point(4, 41);
            this.tbMass2.Name = "tbMass2";
            this.tbMass2.Size = new System.Drawing.Size(147, 45);
            this.tbMass2.TabIndex = 1;
            this.tbMass2.Scroll += new System.EventHandler(this.tbMass2_Scroll);
            // 
            // Impuls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMenu);
            this.Name = "Impuls";
            this.Text = "Impuls";
            this.tlpMenu.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMass2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TrackBar tbMass2;
        private System.Windows.Forms.TrackBar tbMass1;
        private System.Windows.Forms.Panel pnlField;
    }
}