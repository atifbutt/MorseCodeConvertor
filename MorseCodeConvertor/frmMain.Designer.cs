namespace MorseCodeConvertor
{
    partial class frmMain
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
            this.TbxSender = new System.Windows.Forms.TextBox();
            this.BtnSender = new System.Windows.Forms.Button();
            this.TbxReciever = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbxSender
            // 
            this.TbxSender.Location = new System.Drawing.Point(12, 36);
            this.TbxSender.Multiline = true;
            this.TbxSender.Name = "TbxSender";
            this.TbxSender.Size = new System.Drawing.Size(278, 262);
            this.TbxSender.TabIndex = 0;
            // 
            // BtnSender
            // 
            this.BtnSender.Location = new System.Drawing.Point(12, 304);
            this.BtnSender.Name = "BtnSender";
            this.BtnSender.Size = new System.Drawing.Size(278, 23);
            this.BtnSender.TabIndex = 1;
            this.BtnSender.Text = "Send";
            this.BtnSender.UseVisualStyleBackColor = true;
            this.BtnSender.Click += new System.EventHandler(this.BtnSender_Click);
            // 
            // TbxReciever
            // 
            this.TbxReciever.Location = new System.Drawing.Point(296, 36);
            this.TbxReciever.Multiline = true;
            this.TbxReciever.Name = "TbxReciever";
            this.TbxReciever.ReadOnly = true;
            this.TbxReciever.Size = new System.Drawing.Size(278, 291);
            this.TbxReciever.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reciever :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxReciever);
            this.Controls.Add(this.BtnSender);
            this.Controls.Add(this.TbxSender);
            this.Name = "frmMain";
            this.Text = "Morser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxSender;
        private System.Windows.Forms.Button BtnSender;
        private System.Windows.Forms.TextBox TbxReciever;
        private System.Windows.Forms.Label label1;
    }
}

