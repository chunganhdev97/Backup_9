namespace _2017_QLKH
{
    partial class KhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quanLyKhoHang = new _2017_QLKH.QuanLyKhoHang();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new _2017_QLKH.QuanLyKhoHangTableAdapters.KHACHHANGTableAdapter();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIOITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIENTHOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_makh = new System.Windows.Forms.TextBox();
            this.tbx_tenkh = new System.Windows.Forms.TextBox();
            this.tbx_diachi = new System.Windows.Forms.TextBox();
            this.tbx_gioitinh = new System.Windows.Forms.TextBox();
            this.tbx_dienthoai = new System.Windows.Forms.TextBox();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_fax = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.Location = new System.Drawing.Point(930, 12);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(75, 23);
            this.bt_quaylai.TabIndex = 1;
            this.bt_quaylai.Text = "Quay Lại";
            this.bt_quaylai.UseVisualStyleBackColor = true;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbx_fax);
            this.groupBox1.Controls.Add(this.tbx_email);
            this.groupBox1.Controls.Add(this.tbx_dienthoai);
            this.groupBox1.Controls.Add(this.tbx_gioitinh);
            this.groupBox1.Controls.Add(this.tbx_diachi);
            this.groupBox1.Controls.Add(this.tbx_tenkh);
            this.groupBox1.Controls.Add(this.tbx_makh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 355);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QT Khách Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(256, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 355);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHDataGridViewTextBoxColumn,
            this.tENKHDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.gIOITINHDataGridViewTextBoxColumn,
            this.dIENTHOAIDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.fAXDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kHACHHANGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // quanLyKhoHang
            // 
            this.quanLyKhoHang.DataSetName = "QuanLyKhoHang";
            this.quanLyKhoHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.quanLyKhoHang;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            // 
            // tENKHDataGridViewTextBoxColumn
            // 
            this.tENKHDataGridViewTextBoxColumn.DataPropertyName = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.HeaderText = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.Name = "tENKHDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // gIOITINHDataGridViewTextBoxColumn
            // 
            this.gIOITINHDataGridViewTextBoxColumn.DataPropertyName = "GIOITINH";
            this.gIOITINHDataGridViewTextBoxColumn.HeaderText = "GIOITINH";
            this.gIOITINHDataGridViewTextBoxColumn.Name = "gIOITINHDataGridViewTextBoxColumn";
            // 
            // dIENTHOAIDataGridViewTextBoxColumn
            // 
            this.dIENTHOAIDataGridViewTextBoxColumn.DataPropertyName = "DIENTHOAI";
            this.dIENTHOAIDataGridViewTextBoxColumn.HeaderText = "DIENTHOAI";
            this.dIENTHOAIDataGridViewTextBoxColumn.Name = "dIENTHOAIDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // fAXDataGridViewTextBoxColumn
            // 
            this.fAXDataGridViewTextBoxColumn.DataPropertyName = "FAX";
            this.fAXDataGridViewTextBoxColumn.HeaderText = "FAX";
            this.fAXDataGridViewTextBoxColumn.Name = "fAXDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Điện Thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fax";
            // 
            // tbx_makh
            // 
            this.tbx_makh.Location = new System.Drawing.Point(84, 22);
            this.tbx_makh.Name = "tbx_makh";
            this.tbx_makh.Size = new System.Drawing.Size(100, 20);
            this.tbx_makh.TabIndex = 7;
            // 
            // tbx_tenkh
            // 
            this.tbx_tenkh.Location = new System.Drawing.Point(84, 54);
            this.tbx_tenkh.Name = "tbx_tenkh";
            this.tbx_tenkh.Size = new System.Drawing.Size(148, 20);
            this.tbx_tenkh.TabIndex = 8;
            // 
            // tbx_diachi
            // 
            this.tbx_diachi.Location = new System.Drawing.Point(84, 88);
            this.tbx_diachi.Multiline = true;
            this.tbx_diachi.Name = "tbx_diachi";
            this.tbx_diachi.Size = new System.Drawing.Size(148, 47);
            this.tbx_diachi.TabIndex = 9;
            // 
            // tbx_gioitinh
            // 
            this.tbx_gioitinh.Location = new System.Drawing.Point(84, 152);
            this.tbx_gioitinh.Name = "tbx_gioitinh";
            this.tbx_gioitinh.Size = new System.Drawing.Size(100, 20);
            this.tbx_gioitinh.TabIndex = 10;
            // 
            // tbx_dienthoai
            // 
            this.tbx_dienthoai.Location = new System.Drawing.Point(84, 187);
            this.tbx_dienthoai.Name = "tbx_dienthoai";
            this.tbx_dienthoai.Size = new System.Drawing.Size(100, 20);
            this.tbx_dienthoai.TabIndex = 11;
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(84, 224);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(148, 20);
            this.tbx_email.TabIndex = 12;
            // 
            // tbx_fax
            // 
            this.tbx_fax.Location = new System.Drawing.Point(84, 260);
            this.tbx_fax.Name = "tbx_fax";
            this.tbx_fax.Size = new System.Drawing.Size(148, 20);
            this.tbx_fax.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thêm/Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.label1);
            this.Name = "KhachHang";
            this.Text = "Danh Sách Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyKhoHang quanLyKhoHang;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QuanLyKhoHangTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIOITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIENTHOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbx_fax;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.TextBox tbx_dienthoai;
        private System.Windows.Forms.TextBox tbx_gioitinh;
        private System.Windows.Forms.TextBox tbx_diachi;
        private System.Windows.Forms.TextBox tbx_tenkh;
        private System.Windows.Forms.TextBox tbx_makh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}