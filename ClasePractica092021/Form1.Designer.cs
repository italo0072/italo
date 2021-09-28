
namespace ClasePractica092021
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btGetName = new System.Windows.Forms.Button();
            this.btGetData = new System.Windows.Forms.Button();
            this.lstName = new System.Windows.Forms.ListBox();
            this.dgData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // btGetName
            // 
            this.btGetName.Location = new System.Drawing.Point(13, 42);
            this.btGetName.Name = "btGetName";
            this.btGetName.Size = new System.Drawing.Size(117, 43);
            this.btGetName.TabIndex = 0;
            this.btGetName.Text = "Get Name";
            this.btGetName.UseVisualStyleBackColor = true;
            this.btGetName.Click += new System.EventHandler(this.btGetName_Click);
            // 
            // btGetData
            // 
            this.btGetData.Location = new System.Drawing.Point(13, 302);
            this.btGetData.Name = "btGetData";
            this.btGetData.Size = new System.Drawing.Size(117, 48);
            this.btGetData.TabIndex = 1;
            this.btGetData.Text = "GetData";
            this.btGetData.UseVisualStyleBackColor = true;
            this.btGetData.Click += new System.EventHandler(this.btGetData_Click);
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.Location = new System.Drawing.Point(213, 42);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(256, 186);
            this.lstName.TabIndex = 2;
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(213, 302);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(560, 192);
            this.dgData.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.btGetData);
            this.Controls.Add(this.btGetName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGetName;
        private System.Windows.Forms.Button btGetData;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.DataGridView dgData;
    }
}

