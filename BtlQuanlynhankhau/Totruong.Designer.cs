namespace BtlQuanlynhankhau
{
    partial class Totruong
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
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txttenTT = new System.Windows.Forms.TextBox();
            this.txtMatt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drgTotruong = new System.Windows.Forms.DataGridView();
            this.idTotruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTentotruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanlinhankhauDataSet = new BtlQuanlynhankhau.QuanlinhankhauDataSet();
            this.cbbmato = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drgTotruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlinhankhauDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbmato);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLammoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txttenTT);
            this.groupBox1.Controls.Add(this.txtMatt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí tổ trưởng";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(596, 190);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(156, 26);
            this.txtTimkiem.TabIndex = 11;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(496, 185);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(90, 36);
            this.btnTimkiem.TabIndex = 10;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(662, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 36);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(496, 112);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(90, 36);
            this.btnLammoi.TabIndex = 8;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(662, 43);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 36);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(496, 43);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 36);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txttenTT
            // 
            this.txttenTT.Location = new System.Drawing.Point(141, 191);
            this.txttenTT.Name = "txttenTT";
            this.txttenTT.Size = new System.Drawing.Size(332, 26);
            this.txttenTT.TabIndex = 5;
            this.txttenTT.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMatt
            // 
            this.txtMatt.Location = new System.Drawing.Point(141, 48);
            this.txtMatt.Name = "txtMatt";
            this.txtMatt.Size = new System.Drawing.Size(332, 26);
            this.txtMatt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên tổ trưởng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Tổ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tổ trưởng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drgTotruong);
            this.groupBox2.Location = new System.Drawing.Point(13, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tổ trưởng";
            // 
            // drgTotruong
            // 
            this.drgTotruong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgTotruong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTotruong,
            this.idTo,
            this.sTentotruong});
            this.drgTotruong.Location = new System.Drawing.Point(7, 26);
            this.drgTotruong.Name = "drgTotruong";
            this.drgTotruong.RowHeadersWidth = 62;
            this.drgTotruong.RowTemplate.Height = 28;
            this.drgTotruong.Size = new System.Drawing.Size(762, 141);
            this.drgTotruong.TabIndex = 0;
            this.drgTotruong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgTotruong_CellContentClick);
            // 
            // idTotruong
            // 
            this.idTotruong.DataPropertyName = "idTotruong";
            this.idTotruong.HeaderText = "ID";
            this.idTotruong.MinimumWidth = 8;
            this.idTotruong.Name = "idTotruong";
            this.idTotruong.Width = 150;
            // 
            // idTo
            // 
            this.idTo.DataPropertyName = "idTo";
            this.idTo.HeaderText = "Mã Tổ";
            this.idTo.MinimumWidth = 8;
            this.idTo.Name = "idTo";
            this.idTo.Width = 150;
            // 
            // sTentotruong
            // 
            this.sTentotruong.DataPropertyName = "sTentotruong";
            this.sTentotruong.HeaderText = "sTentotruong";
            this.sTentotruong.MinimumWidth = 8;
            this.sTentotruong.Name = "sTentotruong";
            this.sTentotruong.Width = 150;
            // 
            // quanlinhankhauDataSet
            // 
            this.quanlinhankhauDataSet.DataSetName = "QuanlinhankhauDataSet";
            this.quanlinhankhauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbmato
            // 
            this.cbbmato.FormattingEnabled = true;
            this.cbbmato.Location = new System.Drawing.Point(141, 114);
            this.cbbmato.Name = "cbbmato";
            this.cbbmato.Size = new System.Drawing.Size(332, 28);
            this.cbbmato.TabIndex = 12;
            // 
            // Totruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Totruong";
            this.Text = "Totruong";
            this.Load += new System.EventHandler(this.Totruong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drgTotruong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlinhankhauDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txttenTT;
        private System.Windows.Forms.TextBox txtMatt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView drgTotruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTotruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTentotruong;
        private QuanlinhankhauDataSet quanlinhankhauDataSet;
        private System.Windows.Forms.ComboBox cbbmato;
    }
}