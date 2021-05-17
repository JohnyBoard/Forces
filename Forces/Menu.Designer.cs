namespace Forces
{
    partial class Menu
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
            this.btnBuyoancy = new System.Windows.Forms.Button();
            this.btnImpuls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuyoancy
            // 
            this.btnBuyoancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyoancy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuyoancy.Location = new System.Drawing.Point(13, 13);
            this.btnBuyoancy.Name = "btnBuyoancy";
            this.btnBuyoancy.Size = new System.Drawing.Size(176, 33);
            this.btnBuyoancy.TabIndex = 0;
            this.btnBuyoancy.Text = "Сила Архимеда";
            this.btnBuyoancy.UseVisualStyleBackColor = true;
            this.btnBuyoancy.Click += new System.EventHandler(this.btnBuyoancy_Click);
            // 
            // btnImpuls
            // 
            this.btnImpuls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpuls.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImpuls.Location = new System.Drawing.Point(12, 52);
            this.btnImpuls.Name = "btnImpuls";
            this.btnImpuls.Size = new System.Drawing.Size(176, 33);
            this.btnImpuls.TabIndex = 1;
            this.btnImpuls.Text = "Импульс?";
            this.btnImpuls.UseVisualStyleBackColor = true;
            this.btnImpuls.Click += new System.EventHandler(this.btnImpuls_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(201, 459);
            this.Controls.Add(this.btnImpuls);
            this.Controls.Add(this.btnBuyoancy);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuyoancy;
        private System.Windows.Forms.Button btnImpuls;
    }
}