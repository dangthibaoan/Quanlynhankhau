namespace BtlQuanlynhankhau
{
    partial class Todanpho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cbbmaphuong = new System.Windows.Forms.ComboBox();
            this.txtsotamvang = new System.Windows.Forms.TextBox();
            this.txtsothuongtru = new System.Windows.Forms.TextBox();
            this.txtsohotline = new System.Windows.Forms.TextBox();
            this.txtsotamtru = new System.Windows.Forms.TextBox();
            this.txttencbca = new System.Windows.Forms.TextBox();
            this.txttento = new System.Windows.Forms.TextBox();
            this.txttentotruong = new System.Windows.Forms.TextBox();
            this.txtmato = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quanlinhankhauDataSet = new BtlQuanlynhankhau.QuanlinhankhauDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drgTodanpho = new System.Windows.Forms.DataGridView();
            this.idTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPhuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTencbca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTentotruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSĐT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSothuongtru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSotamtru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSotamvang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPhuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPhuongTableAdapter = new BtlQuanlynhankhau.QuanlinhankhauDataSetTableAdapters.tblPhuongTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanlinhankhauDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drgTodanpho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhuongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlammoi);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.cbbmaphuong);
            this.groupBox1.Controls.Add(this.txtsotamvang);
            this.groupBox1.Controls.Add(this.txtsothuongtru);
            this.groupBox1.Controls.Add(this.txtsohotline);
            this.groupBox1.Controls.Add(this.txtsotamtru);
            this.groupBox1.Controls.Add(this.txttencbca);
            this.groupBox1.Controls.Add(this.txttento);
            this.groupBox1.Controls.Add(this.txttentotruong);
            this.groupBox1.Controls.Add(this.txtmato);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí tổ dân phố";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(893, 241);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(121, 40);
            this.btnlammoi.TabIndex = 20;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(672, 241);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(121, 40);
            this.btnsua.TabIndex = 19;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(453, 241);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(121, 40);
            this.btnthem.TabIndex = 18;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cbbmaphuong
            // 
            this.cbbmaphuong.DataSource = this.tblPhuongBindingSource;
            this.cbbmaphuong.DisplayMember = "idPhuong";
            this.cbbmaphuong.FormattingEnabled = true;
            this.cbbmaphuong.Location = new System.Drawing.Point(118, 117);
            this.cbbmaphuong.Name = "cbbmaphuong";
            this.cbbmaphuong.Size = new System.Drawing.Size(220, 28);
            this.cbbmaphuong.TabIndex = 17;
            this.cbbmaphuong.SelectedIndexChanged += new System.EventHandler(this.cbbmaphuong_SelectedIndexChanged);
            // 
            // txtsotamvang
            // 
            this.txtsotamvang.Location = new System.Drawing.Point(795, 186);
            this.txtsotamvang.Name = "txtsotamvang";
            this.txtsotamvang.Size = new System.Drawing.Size(219, 26);
            this.txtsotamvang.TabIndex = 16;
            this.txtsotamvang.TextChanged += new System.EventHandler(this.txtsotamvang_TextChanged);
            // 
            // txtsothuongtru
            // 
            this.txtsothuongtru.Location = new System.Drawing.Point(795, 114);
            this.txtsothuongtru.Name = "txtsothuongtru";
            this.txtsothuongtru.Size = new System.Drawing.Size(219, 26);
            this.txtsothuongtru.TabIndex = 15;
            this.txtsothuongtru.TextChanged += new System.EventHandler(this.txtsothuongtru_TextChanged);
            // 
            // txtsohotline
            // 
            this.txtsohotline.Location = new System.Drawing.Point(795, 53);
            this.txtsohotline.Name = "txtsohotline";
            this.txtsohotline.Size = new System.Drawing.Size(219, 26);
            this.txtsohotline.TabIndex = 14;
            this.txtsohotline.TextChanged += new System.EventHandler(this.txtsohotline_TextChanged);
            // 
            // txtsotamtru
            // 
            this.txtsotamtru.Location = new System.Drawing.Point(453, 189);
            this.txtsotamtru.Name = "txtsotamtru";
            this.txtsotamtru.Size = new System.Drawing.Size(217, 26);
            this.txtsotamtru.TabIndex = 13;
            this.txtsotamtru.TextChanged += new System.EventHandler(this.txtsotamtru_TextChanged);
            // 
            // txttencbca
            // 
            this.txttencbca.Location = new System.Drawing.Point(453, 55);
            this.txttencbca.Name = "txttencbca";
            this.txttencbca.Size = new System.Drawing.Size(215, 26);
            this.txttencbca.TabIndex = 12;
            this.txttencbca.TextChanged += new System.EventHandler(this.txttencbca_TextChanged);
            // 
            // txttento
            // 
            this.txttento.Location = new System.Drawing.Point(118, 187);
            this.txttento.Name = "txttento";
            this.txttento.Size = new System.Drawing.Size(220, 26);
            this.txttento.TabIndex = 11;
            this.txttento.TextChanged += new System.EventHandler(this.txttento_TextChanged);
            // 
            // txttentotruong
            // 
            this.txttentotruong.Location = new System.Drawing.Point(453, 114);
            this.txttentotruong.Name = "txttentotruong";
            this.txttentotruong.Size = new System.Drawing.Size(217, 26);
            this.txttentotruong.TabIndex = 10;
            this.txttentotruong.TextChanged += new System.EventHandler(this.txttentotruong_TextChanged);
            // 
            // txtmato
            // 
            this.txtmato.Location = new System.Drawing.Point(118, 55);
            this.txtmato.Name = "txtmato";
            this.txtmato.Size = new System.Drawing.Size(220, 26);
            this.txtmato.TabIndex = 9;
            this.txtmato.TextChanged += new System.EventHandler(this.txtmato_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(687, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số Hotline";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số thường trú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số Tạm Vắng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên CBCA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên tổ trưởng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tạm trú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên tổ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phường";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tổ";
            // 
            // quanlinhankhauDataSet
            // 
            this.quanlinhankhauDataSet.DataSetName = "QuanlinhankhauDataSet";
            this.quanlinhankhauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drgTodanpho);
            this.groupBox2.Location = new System.Drawing.Point(12, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1028, 363);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tổ dân phố";
            // 
            // drgTodanpho
            // 
            this.drgTodanpho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgTodanpho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTo,
            this.idPhuong,
            this.sTento,
            this.sTencbca,
            this.sTentotruong,
            this.sSĐT,
            this.iSothuongtru,
            this.iSotamtru,
            this.iSotamvang});
            this.drgTodanpho.Location = new System.Drawing.Point(7, 26);
            this.drgTodanpho.Name = "drgTodanpho";
            this.drgTodanpho.RowHeadersWidth = 62;
            this.drgTodanpho.RowTemplate.Height = 28;
            this.drgTodanpho.Size = new System.Drawing.Size(1007, 326);
            this.drgTodanpho.TabIndex = 2;
            this.drgTodanpho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgTodanpho_CellContentClick);
            // 
            // idTo
            // 
            this.idTo.DataPropertyName = "idTo";
            this.idTo.HeaderText = "ID";
            this.idTo.MinimumWidth = 8;
            this.idTo.Name = "idTo";
            this.idTo.Width = 150;
            // 
            // idPhuong
            // 
            this.idPhuong.DataPropertyName = "idPhuong";
            this.idPhuong.HeaderText = "Mã phường";
            this.idPhuong.MinimumWidth = 8;
            this.idPhuong.Name = "idPhuong";
            this.idPhuong.Width = 150;
            // 
            // sTento
            // 
            this.sTento.DataPropertyName = "sTento";
            this.sTento.HeaderText = "Tên tổ";
            this.sTento.MinimumWidth = 8;
            this.sTento.Name = "sTento";
            this.sTento.Width = 150;
            // 
            // sTencbca
            // 
            this.sTencbca.DataPropertyName = "sTencbca";
            this.sTencbca.HeaderText = "Tên CBCA";
            this.sTencbca.MinimumWidth = 8;
            this.sTencbca.Name = "sTencbca";
            this.sTencbca.Width = 150;
            // 
            // sTentotruong
            // 
            this.sTentotruong.DataPropertyName = "sTentotruong";
            this.sTentotruong.HeaderText = "Tên tổ trưởng";
            this.sTentotruong.MinimumWidth = 8;
            this.sTentotruong.Name = "sTentotruong";
            this.sTentotruong.Width = 150;
            // 
            // sSĐT
            // 
            this.sSĐT.DataPropertyName = "sSĐT";
            this.sSĐT.HeaderText = "Số ĐIện Thoại";
            this.sSĐT.MinimumWidth = 8;
            this.sSĐT.Name = "sSĐT";
            this.sSĐT.Width = 150;
            // 
            // iSothuongtru
            // 
            this.iSothuongtru.DataPropertyName = "iSothuongtru";
            this.iSothuongtru.HeaderText = "Số thường trú";
            this.iSothuongtru.MinimumWidth = 8;
            this.iSothuongtru.Name = "iSothuongtru";
            this.iSothuongtru.Width = 150;
            // 
            // iSotamtru
            // 
            this.iSotamtru.DataPropertyName = "iSotamtru";
            this.iSotamtru.HeaderText = "Số tạm trú";
            this.iSotamtru.MinimumWidth = 8;
            this.iSotamtru.Name = "iSotamtru";
            this.iSotamtru.Width = 150;
            // 
            // iSotamvang
            // 
            this.iSotamvang.DataPropertyName = "iSotamvang";
            this.iSotamvang.HeaderText = "Số tạm vắng";
            this.iSotamvang.MinimumWidth = 8;
            this.iSotamvang.Name = "iSotamvang";
            this.iSotamvang.Width = 150;
            // 
            // tblPhuongBindingSource
            // 
            this.tblPhuongBindingSource.DataMember = "tblPhuong";
            this.tblPhuongBindingSource.DataSource = this.quanlinhankhauDataSet;
            // 
            // tblPhuongTableAdapter
            // 
            this.tblPhuongTableAdapter.ClearBeforeFill = true;
            // 
            // Todanpho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Todanpho";
            this.Text = "Todanpho";
            this.Load += new System.EventHandler(this.Todanpho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanlinhankhauDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drgTodanpho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhuongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbmaphuong;
        private System.Windows.Forms.TextBox txtsotamvang;
        private System.Windows.Forms.TextBox txtsothuongtru;
        private System.Windows.Forms.TextBox txtsohotline;
        private System.Windows.Forms.TextBox txtsotamtru;
        private System.Windows.Forms.TextBox txttencbca;
        private System.Windows.Forms.TextBox txttento;
        private System.Windows.Forms.TextBox txttentotruong;
        private System.Windows.Forms.TextBox txtmato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView drgTodanpho;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTencbca;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTentotruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSĐT;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSothuongtru;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSotamtru;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSotamvang;
        private QuanlinhankhauDataSet quanlinhankhauDataSet;
        private System.Windows.Forms.BindingSource tblPhuongBindingSource;
        private QuanlinhankhauDataSetTableAdapters.tblPhuongTableAdapter tblPhuongTableAdapter;
    }
}