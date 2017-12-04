namespace automobiliai_su_db
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.databaseDataSet = new automobiliai_su_db.DatabaseDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new automobiliai_su_db.DatabaseDataSetTableAdapters.CarsTableAdapter();
            this.tableAdapterManager = new automobiliai_su_db.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kazkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atnaujintiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istrintiPazymaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iseitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.databaseDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsTableAdapter = this.carsTableAdapter;
            this.tableAdapterManager.UpdateOrder = automobiliai_su_db.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kazkasToolStripMenuItem,
            this.atnaujintiToolStripMenuItem,
            this.istrintiPazymaToolStripMenuItem,
            this.iseitiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kazkasToolStripMenuItem
            // 
            this.kazkasToolStripMenuItem.Name = "kazkasToolStripMenuItem";
            this.kazkasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.kazkasToolStripMenuItem.Text = "Naujas";
            this.kazkasToolStripMenuItem.Click += new System.EventHandler(this.kazkasToolStripMenuItem_Click);
            // 
            // atnaujintiToolStripMenuItem
            // 
            this.atnaujintiToolStripMenuItem.Name = "atnaujintiToolStripMenuItem";
            this.atnaujintiToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.atnaujintiToolStripMenuItem.Text = "Atnaujinti pazymeta";
            // 
            // istrintiPazymaToolStripMenuItem
            // 
            this.istrintiPazymaToolStripMenuItem.Name = "istrintiPazymaToolStripMenuItem";
            this.istrintiPazymaToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.istrintiPazymaToolStripMenuItem.Text = "Istrinti pazymeta";
            // 
            // iseitiToolStripMenuItem
            // 
            this.iseitiToolStripMenuItem.Name = "iseitiToolStripMenuItem";
            this.iseitiToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.iseitiToolStripMenuItem.Text = "Iseiti";
            this.iseitiToolStripMenuItem.Click += new System.EventHandler(this.iseitiToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 454);
            this.dataGridView1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Automobiliai";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private DatabaseDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kazkasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem atnaujintiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istrintiPazymaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iseitiToolStripMenuItem;
    }
}

