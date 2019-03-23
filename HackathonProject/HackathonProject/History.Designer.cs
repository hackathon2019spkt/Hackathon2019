namespace HackathonProject
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.label5 = new System.Windows.Forms.Label();
            this.dtgv_LishSu = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_ODelete = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_LishSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ODelete)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(379, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 40);
            this.label5.TabIndex = 17;
            this.label5.Text = "HISTORY";
            // 
            // dtgv_LishSu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgv_LishSu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_LishSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_LishSu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgv_LishSu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_LishSu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_LishSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_LishSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_LishSu.DoubleBuffered = true;
            this.dtgv_LishSu.EnableHeadersVisualStyles = false;
            this.dtgv_LishSu.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgv_LishSu.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dtgv_LishSu.Location = new System.Drawing.Point(76, 74);
            this.dtgv_LishSu.Name = "dtgv_LishSu";
            this.dtgv_LishSu.ReadOnly = true;
            this.dtgv_LishSu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_LishSu.RowTemplate.Height = 24;
            this.dtgv_LishSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_LishSu.Size = new System.Drawing.Size(754, 587);
            this.dtgv_LishSu.TabIndex = 18;
            // 
            // btn_ODelete
            // 
            this.btn_ODelete.Image = ((System.Drawing.Image)(resources.GetObject("btn_ODelete.Image")));
            this.btn_ODelete.ImageActive = null;
            this.btn_ODelete.Location = new System.Drawing.Point(400, 687);
            this.btn_ODelete.Name = "btn_ODelete";
            this.btn_ODelete.Size = new System.Drawing.Size(55, 55);
            this.btn_ODelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ODelete.TabIndex = 19;
            this.btn_ODelete.TabStop = false;
            this.btn_ODelete.Zoom = 10;
            this.btn_ODelete.Click += new System.EventHandler(this.btn_ODelete_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.btn_ODelete);
            this.Controls.Add(this.dtgv_LishSu);
            this.Controls.Add(this.label5);
            this.Name = "History";
            this.Size = new System.Drawing.Size(925, 755);
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_LishSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ODelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgv_LishSu;
        private Bunifu.Framework.UI.BunifuImageButton btn_ODelete;
    }
}
