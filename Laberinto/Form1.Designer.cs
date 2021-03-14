namespace Laberinto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.visualizador = new System.Windows.Forms.DataGridView();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.Grafico = new System.Windows.Forms.DataGridView();
            this.pnVisualizador = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.pnAll = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.visualizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            this.pnVisualizador.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.pnAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // visualizador
            // 
            this.visualizador.AllowUserToAddRows = false;
            this.visualizador.AllowUserToDeleteRows = false;
            this.visualizador.AllowUserToResizeColumns = false;
            this.visualizador.AllowUserToResizeRows = false;
            this.visualizador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.visualizador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.visualizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visualizador.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 24, 0, 24);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.visualizador.DefaultCellStyle = dataGridViewCellStyle1;
            this.visualizador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizador.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.visualizador.Location = new System.Drawing.Point(0, 0);
            this.visualizador.MaximumSize = new System.Drawing.Size(965, 873);
            this.visualizador.MinimumSize = new System.Drawing.Size(965, 873);
            this.visualizador.MultiSelect = false;
            this.visualizador.Name = "visualizador";
            this.visualizador.RowHeadersVisible = false;
            this.visualizador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.visualizador.RowTemplate.Height = 24;
            this.visualizador.ShowEditingIcon = false;
            this.visualizador.Size = new System.Drawing.Size(965, 873);
            this.visualizador.TabIndex = 0;
            this.visualizador.SelectionChanged += new System.EventHandler(this.visualizador_SelectionChanged);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(42, 30);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(488, 80);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "INICIAR LABERINTO";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Grafico
            // 
            this.Grafico.AllowUserToAddRows = false;
            this.Grafico.AllowUserToDeleteRows = false;
            this.Grafico.AllowUserToResizeColumns = false;
            this.Grafico.AllowUserToResizeRows = false;
            this.Grafico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grafico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grafico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grafico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grafico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grafico.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grafico.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grafico.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grafico.Enabled = false;
            this.Grafico.Location = new System.Drawing.Point(0, 0);
            this.Grafico.MaximumSize = new System.Drawing.Size(965, 873);
            this.Grafico.MinimumSize = new System.Drawing.Size(965, 873);
            this.Grafico.MultiSelect = false;
            this.Grafico.Name = "Grafico";
            this.Grafico.ReadOnly = true;
            this.Grafico.RowHeadersVisible = false;
            this.Grafico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Grafico.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Grafico.RowTemplate.Height = 150;
            this.Grafico.ShowEditingIcon = false;
            this.Grafico.Size = new System.Drawing.Size(965, 873);
            this.Grafico.TabIndex = 2;
            this.Grafico.Visible = false;
            // 
            // pnVisualizador
            // 
            this.pnVisualizador.Controls.Add(this.Grafico);
            this.pnVisualizador.Controls.Add(this.visualizador);
            this.pnVisualizador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnVisualizador.Location = new System.Drawing.Point(30, 30);
            this.pnVisualizador.Name = "pnVisualizador";
            this.pnVisualizador.Size = new System.Drawing.Size(963, 869);
            this.pnVisualizador.TabIndex = 3;
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.btnIniciar);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnBottom.Location = new System.Drawing.Point(1023, 0);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Padding = new System.Windows.Forms.Padding(20);
            this.pnBottom.Size = new System.Drawing.Size(553, 929);
            this.pnBottom.TabIndex = 4;
            // 
            // pnAll
            // 
            this.pnAll.BackColor = System.Drawing.Color.Transparent;
            this.pnAll.Controls.Add(this.pnVisualizador);
            this.pnAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAll.Location = new System.Drawing.Point(0, 0);
            this.pnAll.Name = "pnAll";
            this.pnAll.Padding = new System.Windows.Forms.Padding(30);
            this.pnAll.Size = new System.Drawing.Size(1023, 929);
            this.pnAll.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 929);
            this.Controls.Add(this.pnAll);
            this.Controls.Add(this.pnBottom);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.visualizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).EndInit();
            this.pnVisualizador.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.pnAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView visualizador;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.DataGridView Grafico;
        private System.Windows.Forms.Panel pnVisualizador;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Panel pnAll;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

