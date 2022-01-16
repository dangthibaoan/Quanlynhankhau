namespace BtlQuanlynhankhau
{
    partial class Phuong
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
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtsoNK = new System.Windows.Forms.TextBox();
            this.txtSotodanpho = new System.Windows.Forms.TextBox();
            this.txtTenphuong = new System.Windows.Forms.TextBox();
            this.txtMaphuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrPhuong = new System.Windows.Forms.DataGridView();
            this.idPhuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenphuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanlinhankhauDataSet = new BtlQuanlynhankhau.QuanlinhankhauDataSet();
            this.btnbaoCao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPhuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlinhankhauDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlammoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtsoNK);
            this.groupBox1.Controls.Add(this.txtSotodanpho);
            this.groupBox1.Controls.Add(this.txtTenphuong);
            this.groupBox1.Controls.Add(this.txtMaphuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(435, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý phường";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(302, 339);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(118, 38);
            this.btnlammoi.TabIndex = 12;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(156, 339);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 38);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 339);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 38);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtsoNK
            // 
            this.txtsoNK.Location = new System.Drawing.Point(141, 232);
            this.txtsoNK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoNK.Name = "txtsoNK";
            this.txtsoNK.Size = new System.Drawing.Size(266, 26);
            this.txtsoNK.TabIndex = 9;
            // 
            // txtSotodanpho
            // 
            this.txtSotodanpho.Location = new System.Drawing.Point(141, 168);
            this.txtSotodanpho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSotodanpho.Name = "txtSotodanpho";
            this.txtSotodanpho.Size = new System.Drawing.Size(266, 26);
            this.txtSotodanpho.TabIndex = 7;
            // 
            // txtTenphuong
            // 
            this.txtTenphuong.Location = new System.Drawing.Point(141, 111);
            this.txtTenphuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenphuong.Name = "txtTenphuong";
            this.txtTenphuong.Size = new System.Drawing.Size(266, 26);
            this.txtTenphuong.TabIndex = 6;
            // 
            // txtMaphuong
            // 
            this.txtMaphuong.Location = new System.Drawing.Point(141, 58);
            this.txtMaphuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaphuong.Name = "txtMaphuong";
            this.txtMaphuong.Size = new System.Drawing.Size(266, 26);
            this.txtMaphuong.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số nhân khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tổ dân phố";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Phường";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phường";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrPhuong);
            this.groupBox2.Location = new System.Drawing.Point(453, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(707, 397);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phường";
            // 
            // dgrPhuong
            // 
            this.dgrPhuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPhuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPhuong,
            this.sTenphuong,
            this.iSoto,
            this.iSoNK});
            this.dgrPhuong.Location = new System.Drawing.Point(6, 25);
            this.dgrPhuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrPhuong.Name = "dgrPhuong";
            this.dgrPhuong.RowHeadersWidth = 62;
            this.dgrPhuong.RowTemplate.Height = 28;
            this.dgrPhuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrPhuong.Size = new System.Drawing.Size(682, 352);
            this.dgrPhuong.TabIndex = 0;
            this.dgrPhuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrPhuong_CellContentClick);
            // 
            // idPhuong
            // 
            this.idPhuong.DataPropertyName = "idPhuong";
            this.idPhuong.HeaderText = "ID";
            this.idPhuong.MinimumWidth = 8;
            this.idPhuong.Name = "idPhuong";
            this.idPhuong.Width = 150;
            // 
            // sTenphuong
            // 
            this.sTenphuong.DataPropertyName = "sTenphuong";
            this.sTenphuong.HeaderText = "Tên phường";
            this.sTenphuong.MinimumWidth = 8;
            this.sTenphuong.Name = "sTenphuong";
            this.sTenphuong.Width = 150;
            // 
            // iSoto
            // 
            this.iSoto.DataPropertyName = "iSoto";
            this.iSoto.HeaderText = "Số tổ";
            this.iSoto.MinimumWidth = 8;
            this.iSoto.Name = "iSoto";
            this.iSoto.Width = 150;
            // 
            // iSoNK
            // 
            this.iSoNK.DataPropertyName = "iSoNK";
            this.iSoNK.HeaderText = "Số nhân khẩu";
            this.iSoNK.MinimumWidth = 8;
            this.iSoNK.Name = "iSoNK";
            this.iSoNK.Width = 150;
            // 
            // quanlinhankhauDataSet
            // 
            this.quanlinhankhauDataSet.DataSetName = "QuanlinhankhauDataSet";
            this.quanlinhankhauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnbaoCao
            // 
            this.btnbaoCao.Location = new System.Drawing.Point(1023, 415);
            this.btnbaoCao.Name = "btnbaoCao";
            this.btnbaoCao.Size = new System.Drawing.Size(118, 38);
            this.btnbaoCao.TabIndex = 2;
            this.btnbaoCao.Text = "Báo Cáo";
            this.btnbaoCao.UseVisualStyleBackColor = true;
            this.btnbaoCao.Click += new System.EventHandler(this.btnbaoCao_Click);
            // 
            // Phuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 465);
            this.Controls.Add(this.btnbaoCao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Phuong";
            this.Text = "Phuong";
            this.Load += new System.EventHandler(this.Phuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrPhuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlinhankhauDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtsoNK;
        private System.Windows.Forms.TextBox txtSotodanpho;
        private System.Windows.Forms.TextBox txtTenphuong;
        private System.Windows.Forms.TextBox txtMaphuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrPhuong;
        private QuanlinhankhauDataSet quanlinhankhauDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenphuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoNK;
        private System.Windows.Forms.Button btnbaoCao;
    }
}