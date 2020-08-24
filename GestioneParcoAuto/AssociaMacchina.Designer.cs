namespace GestioneParcoAuto
{
    partial class AssociaMacchina
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDipendenti = new System.Windows.Forms.ComboBox();
            this.cbxAuto = new System.Windows.Forms.ComboBox();
            this.btnAssocia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dipendente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Auto";
            // 
            // cbxDipendenti
            // 
            this.cbxDipendenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDipendenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDipendenti.FormattingEnabled = true;
            this.cbxDipendenti.Location = new System.Drawing.Point(133, 103);
            this.cbxDipendenti.Name = "cbxDipendenti";
            this.cbxDipendenti.Size = new System.Drawing.Size(365, 28);
            this.cbxDipendenti.TabIndex = 2;
            // 
            // cbxAuto
            // 
            this.cbxAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAuto.FormattingEnabled = true;
            this.cbxAuto.Location = new System.Drawing.Point(133, 43);
            this.cbxAuto.Name = "cbxAuto";
            this.cbxAuto.Size = new System.Drawing.Size(365, 28);
            this.cbxAuto.TabIndex = 3;
            // 
            // btnAssocia
            // 
            this.btnAssocia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssocia.Location = new System.Drawing.Point(39, 169);
            this.btnAssocia.Name = "btnAssocia";
            this.btnAssocia.Size = new System.Drawing.Size(186, 93);
            this.btnAssocia.TabIndex = 6;
            this.btnAssocia.Text = "ASSOCIA AUTO";
            this.btnAssocia.UseVisualStyleBackColor = true;
            this.btnAssocia.Click += new System.EventHandler(this.btnAssocia_Click);
            // 
            // AssociaMacchina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 321);
            this.Controls.Add(this.btnAssocia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDipendenti);
            this.Controls.Add(this.cbxAuto);
            this.Name = "AssociaMacchina";
            this.Text = "AssociaMacchina";
            this.Load += new System.EventHandler(this.AssociaMacchina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbxDipendenti;
        public System.Windows.Forms.ComboBox cbxAuto;
        private System.Windows.Forms.Button btnAssocia;
    }
}