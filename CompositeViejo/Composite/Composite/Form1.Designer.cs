namespace Composite
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
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMBsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMPRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAPERFILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTACLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAPRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.aMBsToolStripMenuItem,
            this.aDMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONSULTAPERFILToolStripMenuItem,
            this.cONSULTACLIENTESToolStripMenuItem,
            this.cONSULTAPRODUCTOSToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // aMBsToolStripMenuItem
            // 
            this.aMBsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMCLIENTEToolStripMenuItem,
            this.aBMPRODUCTOToolStripMenuItem});
            this.aMBsToolStripMenuItem.Name = "aMBsToolStripMenuItem";
            this.aMBsToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aMBsToolStripMenuItem.Text = "AMBs";
            // 
            // aBMCLIENTEToolStripMenuItem
            // 
            this.aBMCLIENTEToolStripMenuItem.Name = "aBMCLIENTEToolStripMenuItem";
            this.aBMCLIENTEToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aBMCLIENTEToolStripMenuItem.Text = "ABM CLIENTE";
            this.aBMCLIENTEToolStripMenuItem.Click += new System.EventHandler(this.aBMCLIENTEToolStripMenuItem_Click);
            // 
            // aBMPRODUCTOToolStripMenuItem
            // 
            this.aBMPRODUCTOToolStripMenuItem.Name = "aBMPRODUCTOToolStripMenuItem";
            this.aBMPRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aBMPRODUCTOToolStripMenuItem.Text = "ABM PRODUCTO";
            this.aBMPRODUCTOToolStripMenuItem.Click += new System.EventHandler(this.aBMPRODUCTOToolStripMenuItem_Click);
            // 
            // cONSULTAPERFILToolStripMenuItem
            // 
            this.cONSULTAPERFILToolStripMenuItem.Name = "cONSULTAPERFILToolStripMenuItem";
            this.cONSULTAPERFILToolStripMenuItem.Size = new System.Drawing.Size(309, 34);
            this.cONSULTAPERFILToolStripMenuItem.Text = "CONSULTA PERFIL";
            this.cONSULTAPERFILToolStripMenuItem.Click += new System.EventHandler(this.cONSULTAPERFILToolStripMenuItem_Click);
            // 
            // cONSULTACLIENTESToolStripMenuItem
            // 
            this.cONSULTACLIENTESToolStripMenuItem.Name = "cONSULTACLIENTESToolStripMenuItem";
            this.cONSULTACLIENTESToolStripMenuItem.Size = new System.Drawing.Size(309, 34);
            this.cONSULTACLIENTESToolStripMenuItem.Text = "CONSULTA CLIENTES";
            this.cONSULTACLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cONSULTACLIENTESToolStripMenuItem_Click);
            // 
            // cONSULTAPRODUCTOSToolStripMenuItem
            // 
            this.cONSULTAPRODUCTOSToolStripMenuItem.Name = "cONSULTAPRODUCTOSToolStripMenuItem";
            this.cONSULTAPRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(309, 34);
            this.cONSULTAPRODUCTOSToolStripMenuItem.Text = "CONSULTA PRODUCTOS";
            this.cONSULTAPRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.cONSULTAPRODUCTOSToolStripMenuItem_Click);
            // 
            // aDMToolStripMenuItem
            // 
            this.aDMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMUSUARIOToolStripMenuItem,
            this.bACKUToolStripMenuItem});
            this.aDMToolStripMenuItem.Name = "aDMToolStripMenuItem";
            this.aDMToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.aDMToolStripMenuItem.Text = "ADM";
            // 
            // aBMUSUARIOToolStripMenuItem
            // 
            this.aBMUSUARIOToolStripMenuItem.Name = "aBMUSUARIOToolStripMenuItem";
            this.aBMUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aBMUSUARIOToolStripMenuItem.Text = "ABM USUARIO";
            this.aBMUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.aBMUSUARIOToolStripMenuItem_Click);
            // 
            // bACKUToolStripMenuItem
            // 
            this.bACKUToolStripMenuItem.Name = "bACKUToolStripMenuItem";
            this.bACKUToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bACKUToolStripMenuItem.Text = "BACKUP";
            this.bACKUToolStripMenuItem.Click += new System.EventHandler(this.bACKUToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMBsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMCLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMPRODUCTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAPERFILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTACLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAPRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bACKUToolStripMenuItem;
    }
}

