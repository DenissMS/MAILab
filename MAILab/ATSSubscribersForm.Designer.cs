namespace ZPA_Lab_1
{
    partial class ATSSubscribersForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbRequests = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbRequestParameters = new System.Windows.Forms.GroupBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.chbPensioners = new System.Windows.Forms.CheckBox();
            this.chbAlcoholics = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbRequestParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(214, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbRequests
            // 
            this.cmbRequests.FormattingEnabled = true;
            this.cmbRequests.Location = new System.Drawing.Point(59, 17);
            this.cmbRequests.Name = "cmbRequests";
            this.cmbRequests.Size = new System.Drawing.Size(131, 21);
            this.cmbRequests.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(121, 267);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 37);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Выполнить запрос";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbRequestParameters
            // 
            this.gbRequestParameters.Controls.Add(this.chbAlcoholics);
            this.gbRequestParameters.Controls.Add(this.chbPensioners);
            this.gbRequestParameters.Controls.Add(this.lblRequest);
            this.gbRequestParameters.Controls.Add(this.cmbRequests);
            this.gbRequestParameters.Location = new System.Drawing.Point(12, 12);
            this.gbRequestParameters.Name = "gbRequestParameters";
            this.gbRequestParameters.Size = new System.Drawing.Size(196, 249);
            this.gbRequestParameters.TabIndex = 3;
            this.gbRequestParameters.TabStop = false;
            this.gbRequestParameters.Text = "Параметры запроса";
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(6, 20);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(47, 13);
            this.lblRequest.TabIndex = 2;
            this.lblRequest.Text = "Запрос:";
            // 
            // chbPensioners
            // 
            this.chbPensioners.AutoSize = true;
            this.chbPensioners.Location = new System.Drawing.Point(9, 56);
            this.chbPensioners.Name = "chbPensioners";
            this.chbPensioners.Size = new System.Drawing.Size(90, 17);
            this.chbPensioners.TabIndex = 5;
            this.chbPensioners.Text = "Пенсионеры";
            this.chbPensioners.UseVisualStyleBackColor = true;
            // 
            // chbAlcoholics
            // 
            this.chbAlcoholics.AutoSize = true;
            this.chbAlcoholics.Location = new System.Drawing.Point(9, 79);
            this.chbAlcoholics.Name = "chbAlcoholics";
            this.chbAlcoholics.Size = new System.Drawing.Size(86, 17);
            this.chbAlcoholics.TabIndex = 6;
            this.chbAlcoholics.Text = "Алкоголики";
            this.chbAlcoholics.UseVisualStyleBackColor = true;
            // 
            // ATSSubscribersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 316);
            this.Controls.Add(this.gbRequestParameters);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ATSSubscribersForm";
            this.Text = "Абоненты АТС - Михальченко Денис";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbRequestParameters.ResumeLayout(false);
            this.gbRequestParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbRequests;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbRequestParameters;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.CheckBox chbAlcoholics;
        private System.Windows.Forms.CheckBox chbPensioners;
    }
}

