
namespace GetSTUFF.Forms
{
    partial class GuessingGameFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxNumber = new System.Windows.Forms.TextBox();
            this.btnStartGuessing = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnHigher = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter  A number between 1 and 100";
            // 
            // txtbxNumber
            // 
            this.txtbxNumber.Location = new System.Drawing.Point(294, 98);
            this.txtbxNumber.Name = "txtbxNumber";
            this.txtbxNumber.Size = new System.Drawing.Size(100, 20);
            this.txtbxNumber.TabIndex = 1;
            // 
            // btnStartGuessing
            // 
            this.btnStartGuessing.Location = new System.Drawing.Point(280, 194);
            this.btnStartGuessing.Name = "btnStartGuessing";
            this.btnStartGuessing.Size = new System.Drawing.Size(127, 23);
            this.btnStartGuessing.TabIndex = 2;
            this.btnStartGuessing.Text = "Start to Guess";
            this.btnStartGuessing.UseVisualStyleBackColor = true;
            this.btnStartGuessing.Click += new System.EventHandler(this.btnStartGuessing_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(291, 152);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(35, 13);
            this.lblPrompt.TabIndex = 3;
            this.lblPrompt.Text = "label2";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(713, 415);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(345, 267);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(75, 23);
            this.btnLower.TabIndex = 5;
            this.btnLower.Text = "Lower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnHigher
            // 
            this.btnHigher.Location = new System.Drawing.Point(264, 267);
            this.btnHigher.Name = "btnHigher";
            this.btnHigher.Size = new System.Drawing.Size(75, 23);
            this.btnHigher.TabIndex = 6;
            this.btnHigher.Text = "Higher";
            this.btnHigher.UseVisualStyleBackColor = true;
            this.btnHigher.Click += new System.EventHandler(this.btnHigher_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(264, 238);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(345, 238);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(12, 415);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 9;
            this.btnGoBack.Text = "GoBack";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // GuessingGameFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnHigher);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnStartGuessing);
            this.Controls.Add(this.txtbxNumber);
            this.Controls.Add(this.label1);
            this.Name = "GuessingGameFrm";
            this.Text = "GuessingGameFrm";
            this.Load += new System.EventHandler(this.GuessingGameFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxNumber;
        private System.Windows.Forms.Button btnStartGuessing;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnHigher;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnGoBack;
    }
}