namespace ConvertResource
{
    partial class ConvertForm
    {
        /// <summary>
        /// Variables de diseño necesarias.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpia todos los recursos en uso.
        /// </summary>
        /// <param name="disposing">True si los recursos gestionados deben ser liberados; False en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por Windows Forms Designer

        /// <summary>
        /// El diseñador soporta el método requerido - no
        /// utiliza el editor de código para modificar el contenido de este método.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertForm));
            this.txtResources = new System.Windows.Forms.TextBox();
            this.labResources = new System.Windows.Forms.Label();
            this.btnResources = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelRESX = new System.Windows.Forms.Label();
            this.txtResx = new System.Windows.Forms.TextBox();
            this.btnResx = new System.Windows.Forms.Button();
            this.openFileDialog_resx = new System.Windows.Forms.OpenFileDialog();
            this.mainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResources
            // 
            this.txtResources.Location = new System.Drawing.Point(28, 54);
            this.txtResources.Margin = new System.Windows.Forms.Padding(4);
            this.txtResources.Name = "txtResources";
            this.txtResources.Size = new System.Drawing.Size(456, 25);
            this.txtResources.TabIndex = 2;
            // 
            // labResources
            // 
            this.labResources.AutoSize = true;
            this.labResources.Location = new System.Drawing.Point(25, 18);
            this.labResources.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labResources.Name = "labResources";
            this.labResources.Size = new System.Drawing.Size(135, 17);
            this.labResources.TabIndex = 1;
            this.labResources.Text = "Select *.resource file:";
            // 
            // btnResources
            // 
            this.btnResources.Location = new System.Drawing.Point(509, 54);
            this.btnResources.Margin = new System.Windows.Forms.Padding(4);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(35, 25);
            this.btnResources.TabIndex = 1;
            this.btnResources.Text = "...";
            this.btnResources.UseVisualStyleBackColor = true;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(150, 185);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 32);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(382, 185);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.tabPage1);
            this.mainTab.Controls.Add(this.tabPage2);
            this.mainTab.Location = new System.Drawing.Point(30, 21);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(580, 149);
            this.mainTab.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labResources);
            this.tabPage1.Controls.Add(this.txtResources);
            this.tabPage1.Controls.Add(this.btnResources);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(572, 119);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Decompile (resources to RESX)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelRESX);
            this.tabPage2.Controls.Add(this.txtResx);
            this.tabPage2.Controls.Add(this.btnResx);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(572, 119);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compile (RESX to resources)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelRESX
            // 
            this.labelRESX.AutoSize = true;
            this.labelRESX.Location = new System.Drawing.Point(26, 21);
            this.labelRESX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRESX.Name = "labelRESX";
            this.labelRESX.Size = new System.Drawing.Size(109, 17);
            this.labelRESX.TabIndex = 3;
            this.labelRESX.Text = "Select *.resx file:";
            // 
            // txtResx
            // 
            this.txtResx.Location = new System.Drawing.Point(29, 57);
            this.txtResx.Margin = new System.Windows.Forms.Padding(4);
            this.txtResx.Name = "txtResx";
            this.txtResx.Size = new System.Drawing.Size(456, 25);
            this.txtResx.TabIndex = 5;
            // 
            // btnResx
            // 
            this.btnResx.Location = new System.Drawing.Point(510, 57);
            this.btnResx.Margin = new System.Windows.Forms.Padding(4);
            this.btnResx.Name = "btnResx";
            this.btnResx.Size = new System.Drawing.Size(35, 25);
            this.btnResx.TabIndex = 4;
            this.btnResx.Text = "...";
            this.btnResx.UseVisualStyleBackColor = true;
            this.btnResx.Click += new System.EventHandler(this.btnResx_Click);
            // 
            // ConvertForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 237);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ConvertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".NET Resource Converter";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MyDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MyDragEnter);
            this.mainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtResources;
        private System.Windows.Forms.Label labResources;
        private System.Windows.Forms.Button btnResources;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelRESX;
        private System.Windows.Forms.TextBox txtResx;
        private System.Windows.Forms.Button btnResx;
        private System.Windows.Forms.OpenFileDialog openFileDialog_resx;
    }
}

