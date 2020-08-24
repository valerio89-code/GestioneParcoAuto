namespace GestioneParcoAuto
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_auto = new System.Windows.Forms.DataGridView();
            this.btnAggiungiMacchina = new System.Windows.Forms.Button();
            this.btnAssociaAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_auto)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_auto
            // 
            this.grid_auto.AllowUserToAddRows = false;
            this.grid_auto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_auto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_auto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_auto.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_auto.Location = new System.Drawing.Point(33, 12);
            this.grid_auto.Name = "grid_auto";
            this.grid_auto.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_auto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_auto.Size = new System.Drawing.Size(920, 240);
            this.grid_auto.TabIndex = 0;
            // 
            // btnAggiungiMacchina
            // 
            this.btnAggiungiMacchina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiMacchina.Location = new System.Drawing.Point(33, 298);
            this.btnAggiungiMacchina.Name = "btnAggiungiMacchina";
            this.btnAggiungiMacchina.Size = new System.Drawing.Size(278, 106);
            this.btnAggiungiMacchina.TabIndex = 1;
            this.btnAggiungiMacchina.Text = "AGGIUNGI AUTO";
            this.btnAggiungiMacchina.UseVisualStyleBackColor = true;
            this.btnAggiungiMacchina.Click += new System.EventHandler(this.btnAggiungiMacchina_Click);
            // 
            // btnAssociaAuto
            // 
            this.btnAssociaAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssociaAuto.Location = new System.Drawing.Point(486, 298);
            this.btnAssociaAuto.Name = "btnAssociaAuto";
            this.btnAssociaAuto.Size = new System.Drawing.Size(278, 106);
            this.btnAssociaAuto.TabIndex = 2;
            this.btnAssociaAuto.Text = "ASSOCIA AUTO";
            this.btnAssociaAuto.UseVisualStyleBackColor = true;
            this.btnAssociaAuto.Click += new System.EventHandler(this.btnAssociaAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.btnAssociaAuto);
            this.Controls.Add(this.btnAggiungiMacchina);
            this.Controls.Add(this.grid_auto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_auto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_auto;
        private System.Windows.Forms.Button btnAggiungiMacchina;
        private System.Windows.Forms.Button btnAssociaAuto;
    }
}

