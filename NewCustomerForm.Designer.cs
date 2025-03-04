namespace MultiWindForm
{
    partial class NewCustomerForm
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
            gbCustomer = new GroupBox();
            btnSave = new Button();
            txtEmail = new TextBox();
            lblEmailHeading = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneHeading = new Label();
            txtName = new TextBox();
            lblNameHeading = new Label();
            btnClear = new Button();
            gbCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // gbCustomer
            // 
            gbCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbCustomer.AutoSize = true;
            gbCustomer.Controls.Add(btnClear);
            gbCustomer.Controls.Add(btnSave);
            gbCustomer.Controls.Add(txtEmail);
            gbCustomer.Controls.Add(lblEmailHeading);
            gbCustomer.Controls.Add(txtPhoneNumber);
            gbCustomer.Controls.Add(lblPhoneHeading);
            gbCustomer.Controls.Add(txtName);
            gbCustomer.Controls.Add(lblNameHeading);
            gbCustomer.Location = new Point(12, 12);
            gbCustomer.Name = "gbCustomer";
            gbCustomer.Size = new Size(444, 163);
            gbCustomer.TabIndex = 0;
            gbCustomer.TabStop = false;
            gbCustomer.Text = "New Customer";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(6, 118);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(103, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(335, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblEmailHeading
            // 
            lblEmailHeading.AutoSize = true;
            lblEmailHeading.Location = new Point(6, 53);
            lblEmailHeading.Name = "lblEmailHeading";
            lblEmailHeading.Size = new Size(39, 15);
            lblEmailHeading.TabIndex = 4;
            lblEmailHeading.Text = "Email:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.Location = new Point(103, 79);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(335, 23);
            txtPhoneNumber.TabIndex = 3;
            // 
            // lblPhoneHeading
            // 
            lblPhoneHeading.AutoSize = true;
            lblPhoneHeading.Location = new Point(6, 82);
            lblPhoneHeading.Name = "lblPhoneHeading";
            lblPhoneHeading.Size = new Size(91, 15);
            lblPhoneHeading.TabIndex = 2;
            lblPhoneHeading.Text = "Phone Number:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(103, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(335, 23);
            txtName.TabIndex = 1;
            // 
            // lblNameHeading
            // 
            lblNameHeading.AutoSize = true;
            lblNameHeading.Location = new Point(6, 24);
            lblNameHeading.Name = "lblNameHeading";
            lblNameHeading.Size = new Size(42, 15);
            lblNameHeading.TabIndex = 0;
            lblNameHeading.Text = "Name:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(351, 118);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 165);
            Controls.Add(gbCustomer);
            Name = "NewCustomerForm";
            Text = "New Customer Form";
            gbCustomer.ResumeLayout(false);
            gbCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbCustomer;
        private TextBox txtEmail;
        private Label lblEmailHeading;
        private TextBox txtPhoneNumber;
        private Label lblPhoneHeading;
        private TextBox txtName;
        private Label lblNameHeading;
        private Button btnSave;
        private Button btnClear;
    }
}