namespace HackathonProject
{
    partial class Upload
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.dtgv_SaveExp = new System.Windows.Forms.DataGridView();
            this.btn_Load = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SaveExp)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(355, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 40);
            this.label5.TabIndex = 18;
            this.label5.Text = "SAVED LIST";
            // 
            // dtgv_SaveExp
            // 
            this.dtgv_SaveExp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_SaveExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_SaveExp.Location = new System.Drawing.Point(23, 103);
            this.dtgv_SaveExp.Name = "dtgv_SaveExp";
            this.dtgv_SaveExp.RowTemplate.Height = 24;
            this.dtgv_SaveExp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_SaveExp.Size = new System.Drawing.Size(881, 488);
            this.dtgv_SaveExp.TabIndex = 19;
            // 
            // btn_Load
            // 
            this.btn_Load.Active = false;
            this.btn_Load.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(162)))), ((int)(((byte)(77)))));
            this.btn_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(183)))), ((int)(((byte)(84)))));
            this.btn_Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Load.BorderRadius = 0;
            this.btn_Load.ButtonText = "Load Experiment";
            this.btn_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Load.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Load.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Load.Iconimage = null;
            this.btn_Load.Iconimage_right = null;
            this.btn_Load.Iconimage_right_Selected = null;
            this.btn_Load.Iconimage_Selected = null;
            this.btn_Load.IconMarginLeft = 0;
            this.btn_Load.IconMarginRight = 0;
            this.btn_Load.IconRightVisible = true;
            this.btn_Load.IconRightZoom = 0D;
            this.btn_Load.IconVisible = true;
            this.btn_Load.IconZoom = 90D;
            this.btn_Load.IsTab = false;
            this.btn_Load.Location = new System.Drawing.Point(309, 625);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(183)))), ((int)(((byte)(84)))));
            this.btn_Load.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(162)))), ((int)(((byte)(77)))));
            this.btn_Load.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Load.selected = false;
            this.btn_Load.Size = new System.Drawing.Size(290, 55);
            this.btn_Load.TabIndex = 20;
            this.btn_Load.Text = "Load Experiment";
            this.btn_Load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Load.Textcolor = System.Drawing.Color.White;
            this.btn_Load.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.dtgv_SaveExp);
            this.Controls.Add(this.label5);
            this.Name = "Upload";
            this.Size = new System.Drawing.Size(925, 755);
            this.Load += new System.EventHandler(this.Upload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SaveExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgv_SaveExp;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Load;
    }
}
