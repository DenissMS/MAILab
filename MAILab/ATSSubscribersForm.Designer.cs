using System.Collections.Generic;
using System.Windows.Forms;

namespace MAILab
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
            this.dgvDataBase = new System.Windows.Forms.DataGridView();
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbRequestParameters = new System.Windows.Forms.GroupBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Childrens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alcoholic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Married = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataBase
            // 
            this.dgvDataBase.AllowUserToAddRows = false;
            this.dgvDataBase.AllowUserToDeleteRows = false;
            this.dgvDataBase.AllowUserToResizeRows = false;
            this.dgvDataBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDataBase.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDataBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataBase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDataBase.ColumnHeadersHeight = 20;
            this.dgvDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ФИО,
            this.Address,
            this.Birth,
            this.Facilities,
            this.Debt,
            this.Childrens,
            this.Desc,
            this.Alcoholic,
            this.Married});
            this.dgvDataBase.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDataBase.Location = new System.Drawing.Point(214, 12);
            this.dgvDataBase.Name = "dgvDataBase";
            this.dgvDataBase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDataBase.RowHeadersVisible = false;
            this.dgvDataBase.Size = new System.Drawing.Size(320, 292);
            this.dgvDataBase.TabIndex = 0;
            // 
            // cmbFilters
            // 
            this.cmbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilters.FormattingEnabled = true;
            this.cmbFilters.Location = new System.Drawing.Point(65, 9);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(131, 21);
            this.cmbFilters.TabIndex = 1;
            this.cmbFilters.SelectedIndexChanged += new System.EventHandler(this.cmbFilters_SelectedIndexChanged);
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
            this.gbRequestParameters.Location = new System.Drawing.Point(12, 36);
            this.gbRequestParameters.Name = "gbRequestParameters";
            this.gbRequestParameters.Size = new System.Drawing.Size(196, 225);
            this.gbRequestParameters.TabIndex = 3;
            this.gbRequestParameters.TabStop = false;
            this.gbRequestParameters.Text = "Параметры запроса";
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(12, 12);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(47, 13);
            this.lblRequest.TabIndex = 2;
            this.lblRequest.Text = "Запрос:";
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 20;
            // 
            // ФИО
            // 
            this.ФИО.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ФИО.FillWeight = 1F;
            this.ФИО.HeaderText = "Имя";
            this.ФИО.Name = "ФИО";
            this.ФИО.ReadOnly = true;
            this.ФИО.Width = 120;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Address.FillWeight = 1F;
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 60;
            // 
            // Birth
            // 
            this.Birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Birth.FillWeight = 1F;
            this.Birth.HeaderText = "Дата рождения";
            this.Birth.Name = "Birth";
            this.Birth.ReadOnly = true;
            this.Birth.Width = 60;
            // 
            // Facilities
            // 
            this.Facilities.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Facilities.FillWeight = 1F;
            this.Facilities.HeaderText = "Льготы";
            this.Facilities.Name = "Facilities";
            this.Facilities.ReadOnly = true;
            this.Facilities.Width = 70;
            // 
            // Debt
            // 
            this.Debt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Debt.FillWeight = 1F;
            this.Debt.HeaderText = "Долг";
            this.Debt.Name = "Debt";
            this.Debt.ReadOnly = true;
            this.Debt.Width = 40;
            // 
            // Childrens
            // 
            this.Childrens.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Childrens.FillWeight = 1F;
            this.Childrens.HeaderText = "Дети";
            this.Childrens.Name = "Childrens";
            this.Childrens.ReadOnly = true;
            this.Childrens.Width = 30;
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Desc.FillWeight = 1F;
            this.Desc.HeaderText = "Дополнительно";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Width = 70;
            // 
            // Alcoholic
            // 
            this.Alcoholic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Alcoholic.FillWeight = 1F;
            this.Alcoholic.HeaderText = "Нарушитель";
            this.Alcoholic.Name = "Alcoholic";
            this.Alcoholic.ReadOnly = true;
            this.Alcoholic.Width = 30;
            // 
            // Married
            // 
            this.Married.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Married.FillWeight = 1F;
            this.Married.HeaderText = "В браке";
            this.Married.MinimumWidth = 20;
            this.Married.Name = "Married";
            this.Married.ReadOnly = true;
            this.Married.Width = 30;
            // 
            // ATSSubscribersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 316);
            this.Controls.Add(this.gbRequestParameters);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cmbFilters);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.dgvDataBase);
            this.Name = "ATSSubscribersForm";
            this.Text = "Абоненты АТС - Михальченко Денис";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataBase;
        private System.Windows.Forms.ComboBox cmbFilters;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbRequestParameters;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private List<Control> lСriterias = new List<Control>();
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ФИО;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Birth;
        private DataGridViewTextBoxColumn Facilities;
        private DataGridViewTextBoxColumn Debt;
        private DataGridViewTextBoxColumn Childrens;
        private DataGridViewTextBoxColumn Desc;
        private DataGridViewTextBoxColumn Alcoholic;
        private DataGridViewTextBoxColumn Married;
    }
}

