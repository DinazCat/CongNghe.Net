namespace ProductManagement
{
    partial class Form1
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
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxOrigin = new System.Windows.Forms.TextBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.textBoxPName = new System.Windows.Forms.TextBox();
            this.textBoxPID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDownPrice2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice1 = new System.Windows.Forms.NumericUpDown();
            this.buttonFindProductsByPriceRange = new System.Windows.Forms.Button();
            this.buttonFindExpiredProducts = new System.Windows.Forms.Button();
            this.buttonFindOriginJapan = new System.Windows.Forms.Button();
            this.buttonFindMaxPrice = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteAllExpiredProducts = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonCheckExpiredProduct = new System.Windows.Forms.Button();
            this.textBoxFindOrigin = new System.Windows.Forms.TextBox();
            this.buttonDeleteByOrigin = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteProduct);
            this.groupBox1.Controls.Add(this.buttonAddProduct);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBoxOrigin);
            this.groupBox1.Controls.Add(this.numericUpDownPrice);
            this.groupBox1.Controls.Add(this.numericUpDownQuantity);
            this.groupBox1.Controls.Add(this.textBoxPName);
            this.groupBox1.Controls.Add(this.textBoxPID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin sản phầm";
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(163, 220);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProduct.TabIndex = 13;
            this.buttonDeleteProduct.Text = "Xóa SP";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(60, 220);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 12;
            this.buttonAddProduct.Text = "Lưu SP";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // textBoxOrigin
            // 
            this.textBoxOrigin.Location = new System.Drawing.Point(117, 158);
            this.textBoxOrigin.Name = "textBoxOrigin";
            this.textBoxOrigin.Size = new System.Drawing.Size(133, 20);
            this.textBoxOrigin.TabIndex = 10;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(117, 128);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownPrice.TabIndex = 9;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(117, 95);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownQuantity.TabIndex = 8;
            // 
            // textBoxPName
            // 
            this.textBoxPName.Location = new System.Drawing.Point(117, 63);
            this.textBoxPName.Name = "textBoxPName";
            this.textBoxPName.Size = new System.Drawing.Size(133, 20);
            this.textBoxPName.TabIndex = 7;
            // 
            // textBoxPID
            // 
            this.textBoxPID.Location = new System.Drawing.Point(117, 31);
            this.textBoxPID.Name = "textBoxPID";
            this.textBoxPID.Size = new System.Drawing.Size(133, 20);
            this.textBoxPID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày hết hạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xuất xứ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.numericUpDownPrice2);
            this.groupBox2.Controls.Add(this.numericUpDownPrice1);
            this.groupBox2.Controls.Add(this.buttonFindProductsByPriceRange);
            this.groupBox2.Controls.Add(this.buttonFindExpiredProducts);
            this.groupBox2.Controls.Add(this.buttonFindOriginJapan);
            this.groupBox2.Controls.Add(this.buttonFindMaxPrice);
            this.groupBox2.Location = new System.Drawing.Point(324, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 262);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chức năng tìm kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 184);
            this.dataGridView1.TabIndex = 6;
            // 
            // numericUpDownPrice2
            // 
            this.numericUpDownPrice2.Location = new System.Drawing.Point(450, 39);
            this.numericUpDownPrice2.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numericUpDownPrice2.Name = "numericUpDownPrice2";
            this.numericUpDownPrice2.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownPrice2.TabIndex = 5;
            // 
            // numericUpDownPrice1
            // 
            this.numericUpDownPrice1.Location = new System.Drawing.Point(354, 39);
            this.numericUpDownPrice1.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numericUpDownPrice1.Name = "numericUpDownPrice1";
            this.numericUpDownPrice1.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownPrice1.TabIndex = 4;
            // 
            // buttonFindProductsByPriceRange
            // 
            this.buttonFindProductsByPriceRange.Location = new System.Drawing.Point(273, 30);
            this.buttonFindProductsByPriceRange.Name = "buttonFindProductsByPriceRange";
            this.buttonFindProductsByPriceRange.Size = new System.Drawing.Size(75, 35);
            this.buttonFindProductsByPriceRange.TabIndex = 3;
            this.buttonFindProductsByPriceRange.Text = "Xuất SP có ĐG [a,b]";
            this.buttonFindProductsByPriceRange.UseVisualStyleBackColor = true;
            this.buttonFindProductsByPriceRange.Click += new System.EventHandler(this.buttonFindProductsByPriceRange_Click);
            // 
            // buttonFindExpiredProducts
            // 
            this.buttonFindExpiredProducts.Location = new System.Drawing.Point(167, 29);
            this.buttonFindExpiredProducts.Name = "buttonFindExpiredProducts";
            this.buttonFindExpiredProducts.Size = new System.Drawing.Size(89, 37);
            this.buttonFindExpiredProducts.TabIndex = 2;
            this.buttonFindExpiredProducts.Text = "Xuất toàn bộ SP quá hạn";
            this.buttonFindExpiredProducts.UseVisualStyleBackColor = true;
            this.buttonFindExpiredProducts.Click += new System.EventHandler(this.buttonFindExpiredProducts_Click);
            // 
            // buttonFindOriginJapan
            // 
            this.buttonFindOriginJapan.Location = new System.Drawing.Point(96, 29);
            this.buttonFindOriginJapan.Name = "buttonFindOriginJapan";
            this.buttonFindOriginJapan.Size = new System.Drawing.Size(65, 37);
            this.buttonFindOriginJapan.TabIndex = 1;
            this.buttonFindOriginJapan.Text = "1 SP từ Nhật Bản";
            this.buttonFindOriginJapan.UseVisualStyleBackColor = true;
            this.buttonFindOriginJapan.Click += new System.EventHandler(this.buttonFindOriginJapan_Click);
            // 
            // buttonFindMaxPrice
            // 
            this.buttonFindMaxPrice.Location = new System.Drawing.Point(15, 29);
            this.buttonFindMaxPrice.Name = "buttonFindMaxPrice";
            this.buttonFindMaxPrice.Size = new System.Drawing.Size(75, 37);
            this.buttonFindMaxPrice.TabIndex = 0;
            this.buttonFindMaxPrice.Text = "1 SP có ĐG cao nhất";
            this.buttonFindMaxPrice.UseVisualStyleBackColor = true;
            this.buttonFindMaxPrice.Click += new System.EventHandler(this.buttonFindMaxPrice_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(12, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(855, 219);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm sau khi nhập";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonDeleteAllExpiredProducts);
            this.groupBox4.Controls.Add(this.buttonDeleteAll);
            this.groupBox4.Controls.Add(this.buttonCheckExpiredProduct);
            this.groupBox4.Controls.Add(this.textBoxFindOrigin);
            this.groupBox4.Controls.Add(this.buttonDeleteByOrigin);
            this.groupBox4.Location = new System.Drawing.Point(585, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 184);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chọn thao tác";
            // 
            // buttonDeleteAllExpiredProducts
            // 
            this.buttonDeleteAllExpiredProducts.Location = new System.Drawing.Point(136, 118);
            this.buttonDeleteAllExpiredProducts.Name = "buttonDeleteAllExpiredProducts";
            this.buttonDeleteAllExpiredProducts.Size = new System.Drawing.Size(101, 42);
            this.buttonDeleteAllExpiredProducts.TabIndex = 4;
            this.buttonDeleteAllExpiredProducts.Text = "Xóa toàn bộ SP quá hạn";
            this.buttonDeleteAllExpiredProducts.UseVisualStyleBackColor = true;
            this.buttonDeleteAllExpiredProducts.Click += new System.EventHandler(this.buttonDeleteAllExpiredProducts_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Location = new System.Drawing.Point(15, 118);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(101, 42);
            this.buttonDeleteAll.TabIndex = 3;
            this.buttonDeleteAll.Text = "Xóa toàn bộ SP trong kho ";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // buttonCheckExpiredProduct
            // 
            this.buttonCheckExpiredProduct.Location = new System.Drawing.Point(15, 77);
            this.buttonCheckExpiredProduct.Name = "buttonCheckExpiredProduct";
            this.buttonCheckExpiredProduct.Size = new System.Drawing.Size(222, 23);
            this.buttonCheckExpiredProduct.TabIndex = 2;
            this.buttonCheckExpiredProduct.Text = "Kiểm tra kho có SP quá hạn hay không?";
            this.buttonCheckExpiredProduct.UseVisualStyleBackColor = true;
            this.buttonCheckExpiredProduct.Click += new System.EventHandler(this.buttonCheckExpiredProduct_Click);
            // 
            // textBoxFindOrigin
            // 
            this.textBoxFindOrigin.Location = new System.Drawing.Point(122, 29);
            this.textBoxFindOrigin.Name = "textBoxFindOrigin";
            this.textBoxFindOrigin.Size = new System.Drawing.Size(120, 20);
            this.textBoxFindOrigin.TabIndex = 1;
            // 
            // buttonDeleteByOrigin
            // 
            this.buttonDeleteByOrigin.Location = new System.Drawing.Point(15, 20);
            this.buttonDeleteByOrigin.Name = "buttonDeleteByOrigin";
            this.buttonDeleteByOrigin.Size = new System.Drawing.Size(86, 37);
            this.buttonDeleteByOrigin.TabIndex = 0;
            this.buttonDeleteByOrigin.Text = "Xóa SP theo xuất xứ bất kỳ";
            this.buttonDeleteByOrigin.UseVisualStyleBackColor = true;
            this.buttonDeleteByOrigin.Click += new System.EventHandler(this.buttonDeleteByOrigin_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(553, 184);
            this.dataGridView2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 511);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "LINQ to Object - Quản lý sản phẩm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.TextBox textBoxPName;
        private System.Windows.Forms.TextBox textBoxPID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrigin;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice2;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice1;
        private System.Windows.Forms.Button buttonFindProductsByPriceRange;
        private System.Windows.Forms.Button buttonFindExpiredProducts;
        private System.Windows.Forms.Button buttonFindOriginJapan;
        private System.Windows.Forms.Button buttonFindMaxPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDeleteAllExpiredProducts;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Button buttonCheckExpiredProduct;
        private System.Windows.Forms.TextBox textBoxFindOrigin;
        private System.Windows.Forms.Button buttonDeleteByOrigin;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonDeleteProduct;
    }
}

