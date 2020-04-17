namespace Řazení
{
    partial class Řazení
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.velikostPole = new System.Windows.Forms.NumericUpDown();
            this.tlStart = new System.Windows.Forms.Button();
            this.vstupniPole = new System.Windows.Forms.DataGridView();
            this.tlNoveHodnoty = new System.Windows.Forms.Button();
            this.vystupniPole = new System.Windows.Forms.DataGridView();
            this.tlDoleSmaz = new System.Windows.Forms.Button();
            this.tlKopirujDolu = new System.Windows.Forms.Button();
            this.tlSeradVyberMinima = new System.Windows.Forms.Button();
            this.bt_bubblesort = new System.Windows.Forms.Button();
            this.bt_Combsort = new System.Windows.Forms.Button();
            this.bt_quicksort = new System.Windows.Forms.Button();
            this.bt_HeapSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.velikostPole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vstupniPole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vystupniPole)).BeginInit();
            this.SuspendLayout();
            // 
            // velikostPole
            // 
            this.velikostPole.Cursor = System.Windows.Forms.Cursors.Default;
            this.velikostPole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.velikostPole.Location = new System.Drawing.Point(15, 20);
            this.velikostPole.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.velikostPole.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.velikostPole.Name = "velikostPole";
            this.velikostPole.Size = new System.Drawing.Size(40, 29);
            this.velikostPole.TabIndex = 0;
            this.velikostPole.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.velikostPole.ValueChanged += new System.EventHandler(this.velikostPole_ValueChanged);
            // 
            // tlStart
            // 
            this.tlStart.Location = new System.Drawing.Point(95, 20);
            this.tlStart.Name = "tlStart";
            this.tlStart.Size = new System.Drawing.Size(164, 29);
            this.tlStart.TabIndex = 1;
            this.tlStart.Text = "Start – generuj nové pole!";
            this.tlStart.UseVisualStyleBackColor = true;
            this.tlStart.Click += new System.EventHandler(this.tlStart_Click);
            // 
            // vstupniPole
            // 
            this.vstupniPole.AllowUserToAddRows = false;
            this.vstupniPole.AllowUserToDeleteRows = false;
            this.vstupniPole.AllowUserToResizeColumns = false;
            this.vstupniPole.AllowUserToResizeRows = false;
            this.vstupniPole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.vstupniPole.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vstupniPole.DefaultCellStyle = dataGridViewCellStyle5;
            this.vstupniPole.Location = new System.Drawing.Point(313, 20);
            this.vstupniPole.MultiSelect = false;
            this.vstupniPole.Name = "vstupniPole";
            this.vstupniPole.ReadOnly = true;
            this.vstupniPole.RowHeadersVisible = false;
            this.vstupniPole.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.vstupniPole.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vstupniPole.Size = new System.Drawing.Size(240, 23);
            this.vstupniPole.TabIndex = 2;
            this.vstupniPole.Visible = false;
            this.vstupniPole.SelectionChanged += new System.EventHandler(this.vstupniPole_SelectionChanged);
            // 
            // tlNoveHodnoty
            // 
            this.tlNoveHodnoty.Location = new System.Drawing.Point(15, 68);
            this.tlNoveHodnoty.Name = "tlNoveHodnoty";
            this.tlNoveHodnoty.Size = new System.Drawing.Size(160, 29);
            this.tlNoveHodnoty.TabIndex = 3;
            this.tlNoveHodnoty.Text = "Generuj nahoru nové hodnoty!";
            this.tlNoveHodnoty.UseVisualStyleBackColor = true;
            this.tlNoveHodnoty.Visible = false;
            this.tlNoveHodnoty.Click += new System.EventHandler(this.tlNoveHodnoty_Click);
            // 
            // vystupniPole
            // 
            this.vystupniPole.AllowUserToAddRows = false;
            this.vystupniPole.AllowUserToDeleteRows = false;
            this.vystupniPole.AllowUserToResizeColumns = false;
            this.vystupniPole.AllowUserToResizeRows = false;
            this.vystupniPole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.vystupniPole.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vystupniPole.DefaultCellStyle = dataGridViewCellStyle6;
            this.vystupniPole.Location = new System.Drawing.Point(15, 110);
            this.vystupniPole.MultiSelect = false;
            this.vystupniPole.Name = "vystupniPole";
            this.vystupniPole.ReadOnly = true;
            this.vystupniPole.RowHeadersVisible = false;
            this.vystupniPole.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.vystupniPole.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vystupniPole.Size = new System.Drawing.Size(240, 23);
            this.vystupniPole.TabIndex = 4;
            this.vystupniPole.Visible = false;
            this.vystupniPole.SelectionChanged += new System.EventHandler(this.vystupniPole_SelectionChanged);
            // 
            // tlDoleSmaz
            // 
            this.tlDoleSmaz.Location = new System.Drawing.Point(181, 68);
            this.tlDoleSmaz.Name = "tlDoleSmaz";
            this.tlDoleSmaz.Size = new System.Drawing.Size(74, 29);
            this.tlDoleSmaz.TabIndex = 5;
            this.tlDoleSmaz.Text = "Dole smaž!";
            this.tlDoleSmaz.UseVisualStyleBackColor = true;
            this.tlDoleSmaz.Visible = false;
            this.tlDoleSmaz.Click += new System.EventHandler(this.tlDoleSmaz_Click);
            // 
            // tlKopirujDolu
            // 
            this.tlKopirujDolu.Location = new System.Drawing.Point(261, 68);
            this.tlKopirujDolu.Name = "tlKopirujDolu";
            this.tlKopirujDolu.Size = new System.Drawing.Size(78, 29);
            this.tlKopirujDolu.TabIndex = 6;
            this.tlKopirujDolu.Text = "Kopíruj dolů!";
            this.tlKopirujDolu.UseVisualStyleBackColor = true;
            this.tlKopirujDolu.Visible = false;
            this.tlKopirujDolu.Click += new System.EventHandler(this.tlKopirujDolu_Click);
            // 
            // tlSeradVyberMinima
            // 
            this.tlSeradVyberMinima.Location = new System.Drawing.Point(345, 68);
            this.tlSeradVyberMinima.Name = "tlSeradVyberMinima";
            this.tlSeradVyberMinima.Size = new System.Drawing.Size(129, 29);
            this.tlSeradVyberMinima.TabIndex = 7;
            this.tlSeradVyberMinima.Text = "Seřaď výběrem minima!";
            this.tlSeradVyberMinima.UseVisualStyleBackColor = true;
            this.tlSeradVyberMinima.Visible = false;
            this.tlSeradVyberMinima.Click += new System.EventHandler(this.tlSeradVyberMinima_Click);
            // 
            // bt_bubblesort
            // 
            this.bt_bubblesort.Location = new System.Drawing.Point(480, 68);
            this.bt_bubblesort.Name = "bt_bubblesort";
            this.bt_bubblesort.Size = new System.Drawing.Size(129, 29);
            this.bt_bubblesort.TabIndex = 8;
            this.bt_bubblesort.Text = "Seřaď bubble sortem!";
            this.bt_bubblesort.UseVisualStyleBackColor = true;
            this.bt_bubblesort.Visible = false;
            this.bt_bubblesort.Click += new System.EventHandler(this.bt_bubblesort_Click);
            // 
            // bt_Combsort
            // 
            this.bt_Combsort.Location = new System.Drawing.Point(615, 68);
            this.bt_Combsort.Name = "bt_Combsort";
            this.bt_Combsort.Size = new System.Drawing.Size(129, 29);
            this.bt_Combsort.TabIndex = 9;
            this.bt_Combsort.Text = "Seřaď comb sortem!";
            this.bt_Combsort.UseVisualStyleBackColor = true;
            this.bt_Combsort.Visible = false;
            this.bt_Combsort.Click += new System.EventHandler(this.bt_Combsort_Click);
            // 
            // bt_quicksort
            // 
            this.bt_quicksort.Location = new System.Drawing.Point(885, 68);
            this.bt_quicksort.Name = "bt_quicksort";
            this.bt_quicksort.Size = new System.Drawing.Size(129, 43);
            this.bt_quicksort.TabIndex = 10;
            this.bt_quicksort.Text = "Seřaď quick sortem! //nefunguje";
            this.bt_quicksort.UseVisualStyleBackColor = true;
            this.bt_quicksort.Visible = false;
            this.bt_quicksort.Click += new System.EventHandler(this.bt_quicksort_Click);
            // 
            // bt_HeapSort
            // 
            this.bt_HeapSort.Location = new System.Drawing.Point(750, 68);
            this.bt_HeapSort.Name = "bt_HeapSort";
            this.bt_HeapSort.Size = new System.Drawing.Size(129, 29);
            this.bt_HeapSort.TabIndex = 11;
            this.bt_HeapSort.Text = "Seřaď heap sortem!";
            this.bt_HeapSort.UseVisualStyleBackColor = true;
            this.bt_HeapSort.Visible = false;
            this.bt_HeapSort.Click += new System.EventHandler(this.bt_HeapSort_Click);
            // 
            // Řazení
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 166);
            this.Controls.Add(this.bt_HeapSort);
            this.Controls.Add(this.bt_quicksort);
            this.Controls.Add(this.bt_Combsort);
            this.Controls.Add(this.bt_bubblesort);
            this.Controls.Add(this.tlSeradVyberMinima);
            this.Controls.Add(this.tlKopirujDolu);
            this.Controls.Add(this.tlDoleSmaz);
            this.Controls.Add(this.vystupniPole);
            this.Controls.Add(this.tlNoveHodnoty);
            this.Controls.Add(this.vstupniPole);
            this.Controls.Add(this.tlStart);
            this.Controls.Add(this.velikostPole);
            this.Name = "Řazení";
            this.Text = "Řazení";
            ((System.ComponentModel.ISupportInitialize)(this.velikostPole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vstupniPole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vystupniPole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown velikostPole;
        private System.Windows.Forms.Button tlStart;
        private System.Windows.Forms.DataGridView vstupniPole;
        private System.Windows.Forms.Button tlNoveHodnoty;
        private System.Windows.Forms.DataGridView vystupniPole;
        private System.Windows.Forms.Button tlDoleSmaz;
        private System.Windows.Forms.Button tlKopirujDolu;
        private System.Windows.Forms.Button tlSeradVyberMinima;
        private System.Windows.Forms.Button bt_bubblesort;
        private System.Windows.Forms.Button bt_Combsort;
        private System.Windows.Forms.Button bt_quicksort;
        private System.Windows.Forms.Button bt_HeapSort;
    }
}

