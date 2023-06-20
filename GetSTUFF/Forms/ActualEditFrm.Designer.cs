
namespace GetSTUFF
{
    partial class ActualEditFrm
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
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.txtbxDate = new System.Windows.Forms.TextBox();
            this.txtbxAmt = new System.Windows.Forms.TextBox();
            this.txtbxEditAmt = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtbxCustID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(57, 118);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(100, 20);
            this.txtbxID.TabIndex = 0;
            // 
            // txtbxDate
            // 
            this.txtbxDate.Location = new System.Drawing.Point(312, 118);
            this.txtbxDate.Name = "txtbxDate";
            this.txtbxDate.Size = new System.Drawing.Size(100, 20);
            this.txtbxDate.TabIndex = 1;
            // 
            // txtbxAmt
            // 
            this.txtbxAmt.Location = new System.Drawing.Point(443, 118);
            this.txtbxAmt.Name = "txtbxAmt";
            this.txtbxAmt.Size = new System.Drawing.Size(100, 20);
            this.txtbxAmt.TabIndex = 2;
            // 
            // txtbxEditAmt
            // 
            this.txtbxEditAmt.Location = new System.Drawing.Point(443, 194);
            this.txtbxEditAmt.Name = "txtbxEditAmt";
            this.txtbxEditAmt.Size = new System.Drawing.Size(100, 20);
            this.txtbxEditAmt.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(426, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(565, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtbxCustID
            // 
            this.txtbxCustID.Location = new System.Drawing.Point(185, 118);
            this.txtbxCustID.Name = "txtbxCustID";
            this.txtbxCustID.Size = new System.Drawing.Size(100, 20);
            this.txtbxCustID.TabIndex = 6;
            // 
            // ActualEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxCustID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtbxEditAmt);
            this.Controls.Add(this.txtbxAmt);
            this.Controls.Add(this.txtbxDate);
            this.Controls.Add(this.txtbxID);
            this.Name = "ActualEditFrm";
            this.Text = "ActualEditFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtbxID;
        public System.Windows.Forms.TextBox txtbxDate;
        public System.Windows.Forms.TextBox txtbxAmt;
        private System.Windows.Forms.TextBox txtbxEditAmt;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtbxCustID;
    }
}