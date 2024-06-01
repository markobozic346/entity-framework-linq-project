namespace DrugiKolokvijumZadatak
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
            this.btnEmployee = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(4, 83);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(96, 38);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(4, 127);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(943, 357);
            this.dataGrid.TabIndex = 1;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(106, 83);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(96, 38);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.shipperToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziToolStripMenuItem,
            this.izmeniToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.obrisiToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // prikaziToolStripMenuItem
            // 
            this.prikaziToolStripMenuItem.Name = "prikaziToolStripMenuItem";
            this.prikaziToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prikaziToolStripMenuItem.Text = "Prikazi";
            // 
            // izmeniToolStripMenuItem
            // 
            this.izmeniToolStripMenuItem.Name = "izmeniToolStripMenuItem";
            this.izmeniToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmeniToolStripMenuItem.Text = "Izmeni";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // obrisiToolStripMenuItem
            // 
            this.obrisiToolStripMenuItem.Name = "obrisiToolStripMenuItem";
            this.obrisiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.obrisiToolStripMenuItem.Text = "Obrisi";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaToolStripMenuItem.Text = "Lista";
            // 
            // shipperToolStripMenuItem
            // 
            this.shipperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziToolStripMenuItem1,
            this.izmeniToolStripMenuItem1,
            this.dodajToolStripMenuItem1,
            this.obrisiToolStripMenuItem1,
            this.listaToolStripMenuItem1});
            this.shipperToolStripMenuItem.Name = "shipperToolStripMenuItem";
            this.shipperToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.shipperToolStripMenuItem.Text = "Shipper";
            // 
            // izmeniToolStripMenuItem1
            // 
            this.izmeniToolStripMenuItem1.Name = "izmeniToolStripMenuItem1";
            this.izmeniToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.izmeniToolStripMenuItem1.Text = "Izmeni";
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.dodajToolStripMenuItem1.Text = "Dodaj";
            // 
            // obrisiToolStripMenuItem1
            // 
            this.obrisiToolStripMenuItem1.Name = "obrisiToolStripMenuItem1";
            this.obrisiToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.obrisiToolStripMenuItem1.Text = "Obrisi";
            // 
            // listaToolStripMenuItem1
            // 
            this.listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            this.listaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.listaToolStripMenuItem1.Text = "Lista";
            // 
            // prikaziToolStripMenuItem1
            // 
            this.prikaziToolStripMenuItem1.Name = "prikaziToolStripMenuItem1";
            this.prikaziToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.prikaziToolStripMenuItem1.Text = "Prikazi";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izmeniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem1;
    }
}

