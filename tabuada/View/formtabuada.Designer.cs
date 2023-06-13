namespace tabuada.View
{
    partial class formtabuada
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
            this.txbnumero = new System.Windows.Forms.TextBox();
            this.listBoxResul = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "tabuada";
            // 
            // txbnumero
            // 
            this.txbnumero.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbnumero.Location = new System.Drawing.Point(67, 119);
            this.txbnumero.Name = "txbnumero";
            this.txbnumero.Size = new System.Drawing.Size(100, 31);
            this.txbnumero.TabIndex = 1;
         
            this.txbnumero.TextChanged += new System.EventHandler(this.txbnumero_TextChanged);
            // 
            // listBoxResul
            // 
            this.listBoxResul.FormattingEnabled = true;
            this.listBoxResul.ItemHeight = 15;
            this.listBoxResul.Location = new System.Drawing.Point(67, 217);
            this.listBoxResul.Name = "listBoxResul";
            this.listBoxResul.Size = new System.Drawing.Size(120, 94);
            this.listBoxResul.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o numero da tabuada";
            // 
            // formtabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxResul);
            this.Controls.Add(this.txbnumero);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "formtabuada";
            this.Text = "formtabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txbnumero;
        private ListBox listBoxResul;
        private Label label2;
    }
}