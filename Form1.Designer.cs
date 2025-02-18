namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CREATE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.T_NAME = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.Label();
            this.READ = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.T_NUMBER = new System.Windows.Forms.TextBox();
            this.T_ADDRESS = new System.Windows.Forms.TextBox();
            this.T_REMARK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CREATE
            // 
            this.CREATE.Location = new System.Drawing.Point(688, 312);
            this.CREATE.Name = "CREATE";
            this.CREATE.Size = new System.Drawing.Size(133, 55);
            this.CREATE.TabIndex = 0;
            this.CREATE.Text = "新增";
            this.CREATE.UseVisualStyleBackColor = true;
            this.CREATE.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(566, 432);
            this.dataGridView1.TabIndex = 1;
            // 
            // T_NAME
            // 
            this.T_NAME.Location = new System.Drawing.Point(753, 103);
            this.T_NAME.Name = "T_NAME";
            this.T_NAME.Size = new System.Drawing.Size(240, 25);
            this.T_NAME.TabIndex = 2;
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Location = new System.Drawing.Point(685, 106);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(49, 15);
            this.NAME.TabIndex = 3;
            this.NAME.Text = "NAME";
            // 
            // READ
            // 
            this.READ.Location = new System.Drawing.Point(846, 312);
            this.READ.Name = "READ";
            this.READ.Size = new System.Drawing.Size(133, 55);
            this.READ.TabIndex = 4;
            this.READ.Text = "查詢";
            this.READ.UseVisualStyleBackColor = true;
            this.READ.Click += new System.EventHandler(this.button2_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(688, 388);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(133, 55);
            this.UPDATE.TabIndex = 5;
            this.UPDATE.Text = "修改(對應NAME)";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.button3_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(846, 388);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(133, 55);
            this.DELETE.TabIndex = 6;
            this.DELETE.Text = "刪除";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.button4_Click);
            // 
            // T_NUMBER
            // 
            this.T_NUMBER.Location = new System.Drawing.Point(753, 145);
            this.T_NUMBER.Name = "T_NUMBER";
            this.T_NUMBER.Size = new System.Drawing.Size(240, 25);
            this.T_NUMBER.TabIndex = 9;
            // 
            // T_ADDRESS
            // 
            this.T_ADDRESS.Location = new System.Drawing.Point(753, 191);
            this.T_ADDRESS.Name = "T_ADDRESS";
            this.T_ADDRESS.Size = new System.Drawing.Size(240, 25);
            this.T_ADDRESS.TabIndex = 10;
            // 
            // T_REMARK
            // 
            this.T_REMARK.Location = new System.Drawing.Point(753, 237);
            this.T_REMARK.Name = "T_REMARK";
            this.T_REMARK.Size = new System.Drawing.Size(240, 25);
            this.T_REMARK.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "ADDRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "REMARK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.T_REMARK);
            this.Controls.Add(this.T_ADDRESS);
            this.Controls.Add(this.T_NUMBER);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.READ);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.T_NAME);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CREATE);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CREATE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox T_NAME;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Button READ;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.TextBox T_NUMBER;
        private System.Windows.Forms.TextBox T_ADDRESS;
        private System.Windows.Forms.TextBox T_REMARK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

