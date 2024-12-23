namespace RestaurantInterface
{
    partial class Form1
    {
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboTables; // ComboBox для вибору таблиці
        private System.Windows.Forms.Panel panelInputs; // Панель для динамічних полів
        private System.Windows.Forms.ComboBox comboPrimaryKey; // ComboBox для вибору значення первинного ключа
        private System.Windows.Forms.Button btnDelete; // Кнопка для видалення рядка
        private System.Windows.Forms.Button btnExport;


        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboTables = new System.Windows.Forms.ComboBox();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.comboPrimaryKey = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.Location = new System.Drawing.Point(469, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(657, 451);
            this.dataGridView.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::Term.Properties.Resources.download_arrow_4178;
            this.btnLoad.Location = new System.Drawing.Point(58, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(40, 40);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Term.Properties.Resources.green_add_button_12023;
            this.btnAdd.Location = new System.Drawing.Point(12, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboTables
            // 
            this.comboTables.Location = new System.Drawing.Point(104, 21);
            this.comboTables.Name = "comboTables";
            this.comboTables.Size = new System.Drawing.Size(120, 24);
            this.comboTables.TabIndex = 3;
            // 
            // panelInputs
            // 
            this.panelInputs.Location = new System.Drawing.Point(12, 136);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(451, 305);
            this.panelInputs.TabIndex = 4;
            this.panelInputs.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInputs_Paint);
            // 
            // comboPrimaryKey
            // 
            this.comboPrimaryKey.Location = new System.Drawing.Point(104, 99);
            this.comboPrimaryKey.Name = "comboPrimaryKey";
            this.comboPrimaryKey.Size = new System.Drawing.Size(120, 24);
            this.comboPrimaryKey.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Image = global::Term.Properties.Resources._24;
            this.btnDelete.Location = new System.Drawing.Point(58, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::Term.Properties.Resources.excel_4954;
            this.btnExport.Location = new System.Drawing.Point(423, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(40, 40);
            this.btnExport.TabIndex = 7;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1134, 473);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.comboPrimaryKey);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelInputs);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.comboTables);
            this.Name = "Form1";
            this.Text = "Restaurant Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
