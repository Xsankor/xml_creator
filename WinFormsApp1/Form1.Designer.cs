namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            N_ZAP = new DataGridViewTextBoxColumn();
            PR_NOV = new DataGridViewTextBoxColumn();
            ID_PAC = new DataGridViewTextBoxColumn();
            VPOLIS = new DataGridViewTextBoxColumn();
            NPOLIS = new DataGridViewTextBoxColumn();
            ST_OKATO = new DataGridViewTextBoxColumn();
            NOVOR = new DataGridViewTextBoxColumn();
            IDCASE = new DataGridViewTextBoxColumn();
            DATE_1 = new DataGridViewTextBoxColumn();
            DATE_2 = new DataGridViewTextBoxColumn();
            USL_OK = new DataGridViewTextBoxColumn();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            menuStrip1 = new MenuStrip();
            местоХраненияToolStripMenuItem = new ToolStripMenuItem();
            открытьМестоХраненияToolStripMenuItem = new ToolStripMenuItem();
            задатьПапкуСохраненияToolStripMenuItem = new ToolStripMenuItem();
            добавитьЗаписьToolStripMenuItem = new ToolStripMenuItem();
            сгенерироватьXMLToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { N_ZAP, PR_NOV, ID_PAC, VPOLIS, NPOLIS, ST_OKATO, NOVOR, IDCASE, DATE_1, DATE_2, USL_OK });
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(745, 367);
            dataGridView1.TabIndex = 1;
            // 
            // N_ZAP
            // 
            N_ZAP.HeaderText = "N_ZAP";
            N_ZAP.Name = "N_ZAP";
            N_ZAP.ReadOnly = true;
            // 
            // PR_NOV
            // 
            PR_NOV.HeaderText = "PR_NOV";
            PR_NOV.Name = "PR_NOV";
            PR_NOV.ReadOnly = true;
            // 
            // ID_PAC
            // 
            ID_PAC.HeaderText = "ID_PAC";
            ID_PAC.Name = "ID_PAC";
            ID_PAC.ReadOnly = true;
            // 
            // VPOLIS
            // 
            VPOLIS.HeaderText = "VPOLIS";
            VPOLIS.Name = "VPOLIS";
            VPOLIS.ReadOnly = true;
            // 
            // NPOLIS
            // 
            NPOLIS.HeaderText = "NPOLIS";
            NPOLIS.Name = "NPOLIS";
            NPOLIS.ReadOnly = true;
            // 
            // ST_OKATO
            // 
            ST_OKATO.HeaderText = "ST_OKATO";
            ST_OKATO.Name = "ST_OKATO";
            ST_OKATO.ReadOnly = true;
            // 
            // NOVOR
            // 
            NOVOR.HeaderText = "NOVOR";
            NOVOR.Name = "NOVOR";
            NOVOR.ReadOnly = true;
            // 
            // IDCASE
            // 
            IDCASE.HeaderText = "IDCASE";
            IDCASE.Name = "IDCASE";
            IDCASE.ReadOnly = true;
            // 
            // DATE_1
            // 
            DATE_1.HeaderText = "DATE_1";
            DATE_1.Name = "DATE_1";
            DATE_1.ReadOnly = true;
            // 
            // DATE_2
            // 
            DATE_2.HeaderText = "DATE_2";
            DATE_2.Name = "DATE_2";
            DATE_2.ReadOnly = true;
            // 
            // USL_OK
            // 
            USL_OK.HeaderText = "USL_OK";
            USL_OK.Name = "USL_OK";
            USL_OK.ReadOnly = true;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { местоХраненияToolStripMenuItem, добавитьЗаписьToolStripMenuItem, сгенерироватьXMLToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(769, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // местоХраненияToolStripMenuItem
            // 
            местоХраненияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьМестоХраненияToolStripMenuItem, задатьПапкуСохраненияToolStripMenuItem });
            местоХраненияToolStripMenuItem.Name = "местоХраненияToolStripMenuItem";
            местоХраненияToolStripMenuItem.Size = new Size(109, 20);
            местоХраненияToolStripMenuItem.Text = "Место хранения";
            // 
            // открытьМестоХраненияToolStripMenuItem
            // 
            открытьМестоХраненияToolStripMenuItem.Name = "открытьМестоХраненияToolStripMenuItem";
            открытьМестоХраненияToolStripMenuItem.Size = new Size(224, 22);
            открытьМестоХраненияToolStripMenuItem.Text = "Открыть папку сохранения";
            открытьМестоХраненияToolStripMenuItem.Click += открытьМестоХраненияToolStripMenuItem_Click;
            // 
            // задатьПапкуСохраненияToolStripMenuItem
            // 
            задатьПапкуСохраненияToolStripMenuItem.Name = "задатьПапкуСохраненияToolStripMenuItem";
            задатьПапкуСохраненияToolStripMenuItem.Size = new Size(224, 22);
            задатьПапкуСохраненияToolStripMenuItem.Text = "Задать папку сохранения";
            задатьПапкуСохраненияToolStripMenuItem.Click += задатьПапкуСохраненияToolStripMenuItem_Click;
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            добавитьЗаписьToolStripMenuItem.Size = new Size(111, 20);
            добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            добавитьЗаписьToolStripMenuItem.Click += добавитьЗаписьToolStripMenuItem_Click;
            // 
            // сгенерироватьXMLToolStripMenuItem
            // 
            сгенерироватьXMLToolStripMenuItem.Name = "сгенерироватьXMLToolStripMenuItem";
            сгенерироватьXMLToolStripMenuItem.Size = new Size(129, 20);
            сгенерироватьXMLToolStripMenuItem.Text = "Сгенерировать XML";
            сгенерироватьXMLToolStripMenuItem.Click += сгенерироватьXMLToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 408);
            Controls.Add(menuStrip1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn N_ZAP;
        private DataGridViewTextBoxColumn PR_NOV;
        private DataGridViewTextBoxColumn ID_PAC;
        private DataGridViewTextBoxColumn VPOLIS;
        private DataGridViewTextBoxColumn NPOLIS;
        private DataGridViewTextBoxColumn ST_OKATO;
        private DataGridViewTextBoxColumn NOVOR;
        private DataGridViewTextBoxColumn IDCASE;
        private DataGridViewTextBoxColumn DATE_1;
        private DataGridViewTextBoxColumn DATE_2;
        private DataGridViewTextBoxColumn USL_OK;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem местоХраненияToolStripMenuItem;
        private ToolStripMenuItem открытьМестоХраненияToolStripMenuItem;
        private ToolStripMenuItem задатьПапкуСохраненияToolStripMenuItem;
        private ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private ToolStripMenuItem сгенерироватьXMLToolStripMenuItem;
    }
}