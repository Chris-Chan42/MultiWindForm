﻿namespace MultiWindForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnNew = new Button();
            dgvCustomers = new DataGridView();
            customerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Location = new Point(678, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(110, 23);
            btnNew.TabIndex = 0;
            btnNew.Text = "New Customer";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { customerIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn });
            dgvCustomers.DataSource = customerBindingSource;
            dgvCustomers.Location = new Point(12, 59);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(776, 379);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Customer);
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(573, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(99, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Customer";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(dgvCustomers);
            Controls.Add(btnNew);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNew;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
        private Button btnEdit;
    }
}
