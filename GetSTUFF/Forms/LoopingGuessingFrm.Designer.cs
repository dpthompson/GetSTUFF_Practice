
namespace GetSTUFF.Forms
{
    partial class LoopingGuessingFrm
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
            this.txtbxGuessAtmpt = new System.Windows.Forms.TextBox();
            this.txtbxGuess = new System.Windows.Forms.TextBox();
            this.btnAtempts = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AttemptValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outcome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter How Many attempts you get";
            // 
            // txtbxGuessAtmpt
            // 
            this.txtbxGuessAtmpt.Location = new System.Drawing.Point(282, 99);
            this.txtbxGuessAtmpt.Name = "txtbxGuessAtmpt";
            this.txtbxGuessAtmpt.Size = new System.Drawing.Size(100, 20);
            this.txtbxGuessAtmpt.TabIndex = 1;
            // 
            // txtbxGuess
            // 
            this.txtbxGuess.Location = new System.Drawing.Point(282, 145);
            this.txtbxGuess.Name = "txtbxGuess";
            this.txtbxGuess.Size = new System.Drawing.Size(100, 20);
            this.txtbxGuess.TabIndex = 2;
            // 
            // btnAtempts
            // 
            this.btnAtempts.Location = new System.Drawing.Point(409, 99);
            this.btnAtempts.Name = "btnAtempts";
            this.btnAtempts.Size = new System.Drawing.Size(75, 23);
            this.btnAtempts.TabIndex = 3;
            this.btnAtempts.Text = "button1";
            this.btnAtempts.UseVisualStyleBackColor = true;
            this.btnAtempts.Click += new System.EventHandler(this.btnAtempts_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(409, 145);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "button2";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttemptValue,
            this.Outcome});
            this.dataGridView1.Location = new System.Drawing.Point(176, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 208);
            this.dataGridView1.TabIndex = 6;
            // 
            // AttemptValue
            // 
            this.AttemptValue.DataPropertyName = "AttemptValue";
            this.AttemptValue.HeaderText = "AttemptValue";
            this.AttemptValue.Name = "AttemptValue";
            this.AttemptValue.ReadOnly = true;
            // 
            // Outcome
            // 
            this.Outcome.DataPropertyName = "Outcome";
            this.Outcome.HeaderText = "Outcome";
            this.Outcome.Name = "Outcome";
            this.Outcome.ReadOnly = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(713, 415);
            this.btnReset.Name = "btnReset";
            this.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // LoopingGuessingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnAtempts);
            this.Controls.Add(this.txtbxGuess);
            this.Controls.Add(this.txtbxGuessAtmpt);
            this.Controls.Add(this.label1);
            this.Name = "LoopingGuessingFrm";
            this.Text = "LoopingGuessingFrm";
            this.Load += new System.EventHandler(this.LoopingGuessingFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxGuessAtmpt;
        private System.Windows.Forms.TextBox txtbxGuess;
        private System.Windows.Forms.Button btnAtempts;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttemptValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outcome;
        private System.Windows.Forms.Button btnReset;
    }
}