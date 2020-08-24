namespace Covid_19
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.chart_Covid19 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Covid19 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Covid19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Covid19)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_Country.Items.AddRange(new object[] {
            ""});
            this.comboBox_Country.Location = new System.Drawing.Point(91, 11);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(262, 22);
            this.comboBox_Country.Sorted = true;
            this.comboBox_Country.TabIndex = 0;
            this.comboBox_Country.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Country_SelectionChangeCommitted);
            // 
            // chart_Covid19
            // 
            this.chart_Covid19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "Covid-19Area";
            this.chart_Covid19.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Covid19.Legends.Add(legend1);
            this.chart_Covid19.Location = new System.Drawing.Point(12, 44);
            this.chart_Covid19.Name = "chart_Covid19";
            this.chart_Covid19.Size = new System.Drawing.Size(932, 677);
            this.chart_Covid19.TabIndex = 1;
            this.chart_Covid19.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country";
            // 
            // dataGridView_Covid19
            // 
            this.dataGridView_Covid19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Covid19.ColumnHeadersHeight = 34;
            this.dataGridView_Covid19.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Covid19.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView_Covid19.Location = new System.Drawing.Point(950, 44);
            this.dataGridView_Covid19.Name = "dataGridView_Covid19";
            this.dataGridView_Covid19.ReadOnly = true;
            this.dataGridView_Covid19.RowHeadersVisible = false;
            this.dataGridView_Covid19.RowHeadersWidth = 62;
            this.dataGridView_Covid19.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Covid19.RowTemplate.Height = 28;
            this.dataGridView_Covid19.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Covid19.Size = new System.Drawing.Size(526, 677);
            this.dataGridView_Covid19.TabIndex = 3;            
            //
            // Form
            //
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 768); 
            this.Controls.Add(this.dataGridView_Covid19);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_Covid19);
            this.Controls.Add(this.comboBox_Country);
            this.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Covid-19 Status by Country";
            this.Icon = new System.Drawing.Icon("resources/covid-19.ico");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Covid19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Covid19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        //
        // Controls
        //
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Covid19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Covid19;

    }
}

