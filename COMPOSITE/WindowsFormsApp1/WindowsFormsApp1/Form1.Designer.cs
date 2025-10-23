namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pRINCIPALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTACLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARCLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bAJACLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESTOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREARUSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREARUSUARISOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSIGNARPERSMISOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRINCIPALToolStripMenuItem,
            this.bDASToolStripMenuItem,
            this.cREARUSUARIOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pRINCIPALToolStripMenuItem
            // 
            this.pRINCIPALToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem,
            this.aLTACLIENTEToolStripMenuItem,
            this.eDITARCLIENTEToolStripMenuItem,
            this.bAJACLIENTEToolStripMenuItem});
            this.pRINCIPALToolStripMenuItem.Name = "pRINCIPALToolStripMenuItem";
            this.pRINCIPALToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.pRINCIPALToolStripMenuItem.Text = "PRINCIPAL";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            this.lOGINToolStripMenuItem.Click += new System.EventHandler(this.lOGINToolStripMenuItem_Click);
            // 
            // aLTACLIENTEToolStripMenuItem
            // 
            this.aLTACLIENTEToolStripMenuItem.Name = "aLTACLIENTEToolStripMenuItem";
            this.aLTACLIENTEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aLTACLIENTEToolStripMenuItem.Text = "ALTA CLIENTE";
            this.aLTACLIENTEToolStripMenuItem.Click += new System.EventHandler(this.aLTACLIENTEToolStripMenuItem_Click);
            // 
            // eDITARCLIENTEToolStripMenuItem
            // 
            this.eDITARCLIENTEToolStripMenuItem.Name = "eDITARCLIENTEToolStripMenuItem";
            this.eDITARCLIENTEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eDITARCLIENTEToolStripMenuItem.Text = "EDITAR CLIENTE";
            this.eDITARCLIENTEToolStripMenuItem.Click += new System.EventHandler(this.eDITARCLIENTEToolStripMenuItem_Click);
            // 
            // bAJACLIENTEToolStripMenuItem
            // 
            this.bAJACLIENTEToolStripMenuItem.Name = "bAJACLIENTEToolStripMenuItem";
            this.bAJACLIENTEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bAJACLIENTEToolStripMenuItem.Text = "BAJA CLIENTE";
            this.bAJACLIENTEToolStripMenuItem.Click += new System.EventHandler(this.bAJACLIENTEToolStripMenuItem_Click);
            // 
            // bDASToolStripMenuItem
            // 
            this.bDASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKUPToolStripMenuItem,
            this.rESTOREToolStripMenuItem});
            this.bDASToolStripMenuItem.Name = "bDASToolStripMenuItem";
            this.bDASToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.bDASToolStripMenuItem.Text = "BDAS";
            // 
            // bACKUPToolStripMenuItem
            // 
            this.bACKUPToolStripMenuItem.Name = "bACKUPToolStripMenuItem";
            this.bACKUPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bACKUPToolStripMenuItem.Text = "BACKUP";
            this.bACKUPToolStripMenuItem.Click += new System.EventHandler(this.bACKUPToolStripMenuItem_Click);
            // 
            // rESTOREToolStripMenuItem
            // 
            this.rESTOREToolStripMenuItem.Name = "rESTOREToolStripMenuItem";
            this.rESTOREToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rESTOREToolStripMenuItem.Text = "RESTORE";
            this.rESTOREToolStripMenuItem.Click += new System.EventHandler(this.rESTOREToolStripMenuItem_Click);
            // 
            // cREARUSUARIOSToolStripMenuItem
            // 
            this.cREARUSUARIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cREARUSUARISOToolStripMenuItem,
            this.aSIGNARPERSMISOToolStripMenuItem});
            this.cREARUSUARIOSToolStripMenuItem.Name = "cREARUSUARIOSToolStripMenuItem";
            this.cREARUSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.cREARUSUARIOSToolStripMenuItem.Text = "CREAR USUARIOS";
            // 
            // cREARUSUARISOToolStripMenuItem
            // 
            this.cREARUSUARISOToolStripMenuItem.Name = "cREARUSUARISOToolStripMenuItem";
            this.cREARUSUARISOToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cREARUSUARISOToolStripMenuItem.Text = "CREAR USUARISO";
            this.cREARUSUARISOToolStripMenuItem.Click += new System.EventHandler(this.cREARUSUARISOToolStripMenuItem_Click);
            // 
            // aSIGNARPERSMISOToolStripMenuItem
            // 
            this.aSIGNARPERSMISOToolStripMenuItem.Name = "aSIGNARPERSMISOToolStripMenuItem";
            this.aSIGNARPERSMISOToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aSIGNARPERSMISOToolStripMenuItem.Text = "ASIGNAR PERSMISO";
            this.aSIGNARPERSMISOToolStripMenuItem.Click += new System.EventHandler(this.aSIGNARPERSMISOToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pRINCIPALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLTACLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARCLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bAJACLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bDASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bACKUPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESTOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cREARUSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cREARUSUARISOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSIGNARPERSMISOToolStripMenuItem;
    }
}

