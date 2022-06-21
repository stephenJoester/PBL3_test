namespace SourceCode.GUI
{
    partial class fMonAn1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLoaiMonAn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchMA = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearchMonAn = new Guna.UI2.WinForms.Guna2Button();
            this.dataMonAn = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddMonAn = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateMonAn = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelMonAn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại món ăn";
            // 
            // cbbLoaiMonAn
            // 
            this.cbbLoaiMonAn.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiMonAn.BorderRadius = 8;
            this.cbbLoaiMonAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiMonAn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiMonAn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiMonAn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLoaiMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbLoaiMonAn.ItemHeight = 30;
            this.cbbLoaiMonAn.Location = new System.Drawing.Point(129, 30);
            this.cbbLoaiMonAn.Name = "cbbLoaiMonAn";
            this.cbbLoaiMonAn.Size = new System.Drawing.Size(225, 36);
            this.cbbLoaiMonAn.TabIndex = 14;
            this.cbbLoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiMonAn_SelectedIndexChanged);
            // 
            // txtSearchMA
            // 
            this.txtSearchMA.Animated = true;
            this.txtSearchMA.BorderRadius = 8;
            this.txtSearchMA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchMA.DefaultText = "";
            this.txtSearchMA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchMA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchMA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchMA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMA.Location = new System.Drawing.Point(588, 31);
            this.txtSearchMA.Name = "txtSearchMA";
            this.txtSearchMA.PasswordChar = '\0';
            this.txtSearchMA.PlaceholderText = "";
            this.txtSearchMA.SelectedText = "";
            this.txtSearchMA.Size = new System.Drawing.Size(196, 38);
            this.txtSearchMA.TabIndex = 21;
            // 
            // btnSearchMonAn
            // 
            this.btnSearchMonAn.BorderRadius = 8;
            this.btnSearchMonAn.BorderThickness = 1;
            this.btnSearchMonAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchMonAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchMonAn.FillColor = System.Drawing.Color.LightGray;
            this.btnSearchMonAn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearchMonAn.ForeColor = System.Drawing.Color.Black;
            this.btnSearchMonAn.Location = new System.Drawing.Point(792, 31);
            this.btnSearchMonAn.Name = "btnSearchMonAn";
            this.btnSearchMonAn.Size = new System.Drawing.Size(114, 35);
            this.btnSearchMonAn.TabIndex = 22;
            this.btnSearchMonAn.Text = "Tìm kiếm";
            this.btnSearchMonAn.Click += new System.EventHandler(this.btnSearchMonAn_Click);
            // 
            // dataMonAn
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dataMonAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMonAn.BackgroundColor = System.Drawing.Color.White;
            this.dataMonAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataMonAn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataMonAn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMonAn.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataMonAn.EnableHeadersVisualStyles = false;
            this.dataMonAn.GridColor = System.Drawing.Color.LightGray;
            this.dataMonAn.Location = new System.Drawing.Point(16, 93);
            this.dataMonAn.Name = "dataMonAn";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMonAn.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataMonAn.RowHeadersVisible = false;
            this.dataMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMonAn.Size = new System.Drawing.Size(945, 456);
            this.dataMonAn.TabIndex = 23;
            this.dataMonAn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataMonAn.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataMonAn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataMonAn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataMonAn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataMonAn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataMonAn.ThemeStyle.GridColor = System.Drawing.Color.LightGray;
            this.dataMonAn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightGray;
            this.dataMonAn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataMonAn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataMonAn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataMonAn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataMonAn.ThemeStyle.HeaderStyle.Height = 23;
            this.dataMonAn.ThemeStyle.ReadOnly = false;
            this.dataMonAn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataMonAn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataMonAn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataMonAn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataMonAn.ThemeStyle.RowsStyle.Height = 22;
            this.dataMonAn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataMonAn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAddMonAn
            // 
            this.btnAddMonAn.BorderRadius = 8;
            this.btnAddMonAn.BorderThickness = 1;
            this.btnAddMonAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMonAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMonAn.FillColor = System.Drawing.Color.LightGray;
            this.btnAddMonAn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAddMonAn.ForeColor = System.Drawing.Color.Black;
            this.btnAddMonAn.Location = new System.Drawing.Point(376, 565);
            this.btnAddMonAn.Name = "btnAddMonAn";
            this.btnAddMonAn.Size = new System.Drawing.Size(114, 35);
            this.btnAddMonAn.TabIndex = 24;
            this.btnAddMonAn.Text = "Thêm";
            this.btnAddMonAn.Click += new System.EventHandler(this.btnAddMonAn_Click);
            // 
            // btnUpdateMonAn
            // 
            this.btnUpdateMonAn.BorderRadius = 8;
            this.btnUpdateMonAn.BorderThickness = 1;
            this.btnUpdateMonAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateMonAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateMonAn.FillColor = System.Drawing.Color.LightGray;
            this.btnUpdateMonAn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnUpdateMonAn.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateMonAn.Location = new System.Drawing.Point(496, 565);
            this.btnUpdateMonAn.Name = "btnUpdateMonAn";
            this.btnUpdateMonAn.Size = new System.Drawing.Size(114, 35);
            this.btnUpdateMonAn.TabIndex = 25;
            this.btnUpdateMonAn.Text = "Cập nhật";
            this.btnUpdateMonAn.Click += new System.EventHandler(this.btnUpdateMonAn_Click);
            // 
            // btnDelMonAn
            // 
            this.btnDelMonAn.BorderRadius = 8;
            this.btnDelMonAn.BorderThickness = 1;
            this.btnDelMonAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelMonAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelMonAn.FillColor = System.Drawing.Color.LightGray;
            this.btnDelMonAn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnDelMonAn.ForeColor = System.Drawing.Color.Black;
            this.btnDelMonAn.Location = new System.Drawing.Point(616, 564);
            this.btnDelMonAn.Name = "btnDelMonAn";
            this.btnDelMonAn.Size = new System.Drawing.Size(114, 35);
            this.btnDelMonAn.TabIndex = 26;
            this.btnDelMonAn.Text = "Xóa";
            this.btnDelMonAn.Click += new System.EventHandler(this.btnDelMonAn_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 8;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(736, 564);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(225, 36);
            this.guna2ComboBox1.TabIndex = 27;
            // 
            // fMonAn1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 622);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.btnDelMonAn);
            this.Controls.Add(this.btnUpdateMonAn);
            this.Controls.Add(this.btnAddMonAn);
            this.Controls.Add(this.dataMonAn);
            this.Controls.Add(this.btnSearchMonAn);
            this.Controls.Add(this.txtSearchMA);
            this.Controls.Add(this.cbbLoaiMonAn);
            this.Controls.Add(this.label3);
            this.Name = "fMonAn1";
            this.Text = "fMonAn1";
            ((System.ComponentModel.ISupportInitialize)(this.dataMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiMonAn;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMA;
        private Guna.UI2.WinForms.Guna2Button btnSearchMonAn;
        private Guna.UI2.WinForms.Guna2DataGridView dataMonAn;
        private Guna.UI2.WinForms.Guna2Button btnAddMonAn;
        private Guna.UI2.WinForms.Guna2Button btnUpdateMonAn;
        private Guna.UI2.WinForms.Guna2Button btnDelMonAn;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}