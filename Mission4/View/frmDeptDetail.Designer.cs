namespace Mission4.View
{
    partial class frmDeptDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeptDetail));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDeptId = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtLocId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errDeptId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDeptName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errLocId = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errDeptId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDeptName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLocId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.CausesValidation = false;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(270, 222);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 58);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnWork
            // 
            this.btnWork.Image = ((System.Drawing.Image)(resources.GetObject("btnWork.Image")));
            this.btnWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWork.Location = new System.Drawing.Point(148, 222);
            this.btnWork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(96, 58);
            this.btnWork.TabIndex = 1;
            this.btnWork.Text = "Work";
            this.btnWork.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDeptId);
            this.groupBox1.Controls.Add(this.txtDeptName);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.txtLocId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(460, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblDeptId
            // 
            this.lblDeptId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeptId.Location = new System.Drawing.Point(175, 31);
            this.lblDeptId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(66, 34);
            this.lblDeptId.TabIndex = 0;
            this.lblDeptId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(175, 77);
            this.txtDeptName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(127, 26);
            this.txtDeptName.TabIndex = 1;
            this.txtDeptName.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeptName_Validating);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 38);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 20);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Kode departemen";
            // 
            // txtLocId
            // 
            this.txtLocId.Location = new System.Drawing.Point(175, 126);
            this.txtLocId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocId.Name = "txtLocId";
            this.txtLocId.Size = new System.Drawing.Size(127, 26);
            this.txtLocId.TabIndex = 2;
            this.txtLocId.Validating += new System.ComponentModel.CancelEventHandler(this.txtLocId_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Area Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nama Departemen";
            // 
            // errDeptId
            // 
            this.errDeptId.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errDeptId.ContainerControl = this;
            // 
            // errDeptName
            // 
            this.errDeptName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errDeptName.ContainerControl = this;
            // 
            // errLocId
            // 
            this.errLocId.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errLocId.ContainerControl = this;
            // 
            // frmDeptDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 302);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeptDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departemen detail";
            this.Load += new System.EventHandler(this.frmDeptDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errDeptId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDeptName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLocId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDeptId;
        protected System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label Label1;
        protected System.Windows.Forms.TextBox txtLocId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errDeptId;
        private System.Windows.Forms.ErrorProvider errDeptName;
        private System.Windows.Forms.ErrorProvider errLocId;
    }
}