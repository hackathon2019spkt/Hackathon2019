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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Load = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtgv_SaveExp = new System.Windows.Forms.DataGridView();
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
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // dtgv_SaveExp
            // 
            this.dtgv_SaveExp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_SaveExp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_SaveExp.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_SaveExp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_SaveExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_SaveExp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_SaveExp.Location = new System.Drawing.Point(54, 98);
            this.dtgv_SaveExp.MultiSelect = false;
            this.dtgv_SaveExp.Name = "dtgv_SaveExp";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_SaveExp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_SaveExp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgv_SaveExp.RowTemplate.Height = 24;
            this.dtgv_SaveExp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_SaveExp.Size = new System.Drawing.Size(806, 509);
            this.dtgv_SaveExp.TabIndex = 21;
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.dtgv_SaveExp);
            this.Controls.Add(this.btn_Load);
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
        private Bunifu.Framework.UI.BunifuFlatButton btn_Load;
        private System.Windows.Forms.DataGridView dtgv_SaveExp;
    }
}
