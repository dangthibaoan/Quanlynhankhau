namespace BtlQuanlynhankhau
{
    partial class Canbo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbmato = new System.Windows.Forms.ComboBox();
            this.quanlinhankhauDataSet = new BtlQuanlynhankhau.QuanlinhankhauDataSet();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txttenCB = new System.Windows.Forms.TextBox();
            this.txtmaCB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drgCanbo = new System.Windows.Forms.DataGridView();
            this.cbbTinhtrang = new System.Windows.Forms.ComboBox();
            this.idCanbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanlinhankhauDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drgCanbo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTinhtrang);
            this.groupBox1.Controls.Add(this.cbbmato);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txttenCB);
            this.groupBox1.Controls.Add(this.txtmaCB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý cán bộ";
            // 
            // cbbmato
            // 
            this.cbbmato.FormattingEnabled = true;
            this.cbbmato.Location = new System.Drawing.Point(148, 112);
            this.cbbmato.Name = "cbbmato";
            this.cbbmato.Size = new System.Drawing.Size(517, 28);
            this.cbbmato.TabIndex = 13;
            // 
            // quanlinhankhauDataSet
            // 
            this.quanlinhankhauDataSet.DataSetName = "QuanlinhankhauDataSet";
            this.quanlinhankhauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(516, 316);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(149, 26);
            this.txtTimkiem.TabIndex = 12;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(410, 312);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(95, 33);
            this.btnTimkiem.TabIndex = 11;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(279, 312);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 33);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(146, 312);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 33);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(9, 312);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 33);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txttenCB
            // 
            this.txttenCB.Location = new System.Drawing.Point(148, 179);
            this.txttenCB.Name = "txttenCB";
            this.txttenCB.Size = new System.Drawing.Size(517, 26);
            this.txttenCB.TabIndex = 6;
            // 
            // txtmaCB
            // 
            this.txtmaCB.Location = new System.Drawing.Point(148, 40);
            this.txtmaCB.Name = "txtmaCB";
            this.txtmaCB.Size = new System.Drawing.Size(517, 26);
            this.txtmaCB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tình Trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Cán Bộ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Tổ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Cán Bộ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drgCanbo);
            this.groupBox2.Location = new System.Drawing.Point(13, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Cán bộ";
            // 
            // drgCanbo
            // 
            this.drgCanbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgCanbo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCanbo,
            this.idTo,
            this.sTenCB,
            this.sTinhtrang});
            this.drgCanbo.Location = new System.Drawing.Point(7, 26);
            this.drgCanbo.Name = "drgCanbo";
            this.drgCanbo.RowHeadersWidth = 62;
            this.drgCanbo.RowTemplate.Height = 28;
            this.drgCanbo.Size = new System.Drawing.Size(658, 161);
            this.drgCanbo.TabIndex = 0;
            this.drgCanbo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgCanbo_CellContentClick);
            // 
            // cbbTinhtrang
            // 
            this.cbbTinhtrang.FormattingEnabled = true;
            this.cbbTinhtrang.Location = new System.Drawing.Point(146, 254);
            this.cbbTinhtrang.Name = "cbbTinhtrang";
            this.cbbTinhtrang.Size = new System.Drawing.Size(519, 28);
            this.cbbTinhtrang.TabIndex = 14;
            // 
            // idCanbo
            // 
            this.idCanbo.DataPropertyName = "idCanbo";
            this.idCanbo.HeaderText = "ID";
            this.idCanbo.MinimumWidth = 8;
            this.idCanbo.Name = "idCanbo";
            this.idCanbo.Width = 150;
            // 
            // idTo
            // 
            this.idTo.DataPropertyName = "idTo";
            this.idTo.HeaderText = "Mã Tổ";
            this.idTo.MinimumWidth = 8;
            this.idTo.Name = "idTo";
            this.idTo.Width = 150;
            // 
            // sTenCB
            // 
            this.sTenCB.DataPropertyName = "sTenCB";
            this.sTenCB.HeaderText = "Tên Cán Bộ";
            this.sTenCB.MinimumWidth = 8;
            this.sTenCB.Name = "sTenCB";
            this.sTenCB.Width = 150;
            // 
            // sTinhtrang
            // 
            this.sTinhtrang.DataPropertyName = "sTinhtrang";
            this.sTinhtrang.HeaderText = "Tình trạng";
            this.sTinhtrang.MinimumWidth = 8;
            this.sTinhtrang.Name = "sTinhtrang";
            this.sTinhtrang.Width = 150;
            // 
            // Canbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Canbo";
            this.Text = "Canbo";
            this.Load += new System.EventHandler(this.Canbo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanlinhankhauDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drgCanbo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbmato;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txttenCB;
        private System.Windows.Forms.TextBox txtmaCB;
        private System.Windows.Forms.DataGridView drgCanbo;
        private QuanlinhankhauDataSet quanlinhankhauDataSet;
        private System.Windows.Forms.ComboBox cbbTinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCanbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTinhtrang;
    }
}