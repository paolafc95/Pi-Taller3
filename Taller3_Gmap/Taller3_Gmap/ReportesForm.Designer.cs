namespace Taller3_Gmap
{
    partial class ReportesForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.chartTest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCargarGráfico = new System.Windows.Forms.Button();
            this.infoxRegionesBtn = new System.Windows.Forms.Button();
            this.áreaInvesBtn = new System.Windows.Forms.Button();
            this.ciudadesBtn = new System.Windows.Forms.Button();
            this.clasificaciónBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(540, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartTest
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartArea3.Name = "ChartArea3";
            chartArea4.Name = "ChartArea4";
            chartArea5.Name = "ChartArea5";
            this.chartTest.ChartAreas.Add(chartArea1);
            this.chartTest.ChartAreas.Add(chartArea2);
            this.chartTest.ChartAreas.Add(chartArea3);
            this.chartTest.ChartAreas.Add(chartArea4);
            this.chartTest.ChartAreas.Add(chartArea5);
            legend1.Name = "Legend1";
            this.chartTest.Legends.Add(legend1);
            this.chartTest.Location = new System.Drawing.Point(13, 105);
            this.chartTest.Name = "chartTest";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Grupos";
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Región";
            series2.YValuesPerPoint = 4;
            series3.ChartArea = "ChartArea3";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Área de investigación";
            series4.ChartArea = "ChartArea4";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Clasificación";
            series5.ChartArea = "ChartArea5";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "Ciudades";
            this.chartTest.Series.Add(series1);
            this.chartTest.Series.Add(series2);
            this.chartTest.Series.Add(series3);
            this.chartTest.Series.Add(series4);
            this.chartTest.Series.Add(series5);
            this.chartTest.Size = new System.Drawing.Size(604, 392);
            this.chartTest.TabIndex = 1;
            this.chartTest.Text = "Estadística";
            this.chartTest.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnCargarGráfico
            // 
            this.btnCargarGráfico.Location = new System.Drawing.Point(13, 510);
            this.btnCargarGráfico.Name = "btnCargarGráfico";
            this.btnCargarGráfico.Size = new System.Drawing.Size(86, 23);
            this.btnCargarGráfico.TabIndex = 2;
            this.btnCargarGráfico.Text = "Cargar gráfico";
            this.btnCargarGráfico.UseVisualStyleBackColor = true;
            this.btnCargarGráfico.Click += new System.EventHandler(this.btnCargarGráfico_Click);
            // 
            // infoxRegionesBtn
            // 
            this.infoxRegionesBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoxRegionesBtn.Location = new System.Drawing.Point(44, 51);
            this.infoxRegionesBtn.Name = "infoxRegionesBtn";
            this.infoxRegionesBtn.Size = new System.Drawing.Size(124, 35);
            this.infoxRegionesBtn.TabIndex = 3;
            this.infoxRegionesBtn.Text = "Regiones";
            this.infoxRegionesBtn.UseVisualStyleBackColor = true;
            this.infoxRegionesBtn.Click += new System.EventHandler(this.infoxRegionesBtn_Click);
            // 
            // áreaInvesBtn
            // 
            this.áreaInvesBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.áreaInvesBtn.Location = new System.Drawing.Point(174, 51);
            this.áreaInvesBtn.Name = "áreaInvesBtn";
            this.áreaInvesBtn.Size = new System.Drawing.Size(151, 35);
            this.áreaInvesBtn.TabIndex = 4;
            this.áreaInvesBtn.Text = "Área de investigación";
            this.áreaInvesBtn.UseVisualStyleBackColor = true;
            this.áreaInvesBtn.Click += new System.EventHandler(this.áreaInvesBtn_Click);
            // 
            // ciudadesBtn
            // 
            this.ciudadesBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadesBtn.Location = new System.Drawing.Point(464, 51);
            this.ciudadesBtn.Name = "ciudadesBtn";
            this.ciudadesBtn.Size = new System.Drawing.Size(126, 35);
            this.ciudadesBtn.TabIndex = 5;
            this.ciudadesBtn.Text = "Ciudades";
            this.ciudadesBtn.UseVisualStyleBackColor = true;
            this.ciudadesBtn.Click += new System.EventHandler(this.ciudadesBtn_Click);
            // 
            // clasificaciónBtn
            // 
            this.clasificaciónBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clasificaciónBtn.Location = new System.Drawing.Point(331, 51);
            this.clasificaciónBtn.Name = "clasificaciónBtn";
            this.clasificaciónBtn.Size = new System.Drawing.Size(127, 35);
            this.clasificaciónBtn.TabIndex = 6;
            this.clasificaciónBtn.Text = "Clasificación";
            this.clasificaciónBtn.UseVisualStyleBackColor = true;
            this.clasificaciónBtn.Click += new System.EventHandler(this.clasificaciónBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Acontinuación seleccione la información que desea ver:";
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clasificaciónBtn);
            this.Controls.Add(this.ciudadesBtn);
            this.Controls.Add(this.áreaInvesBtn);
            this.Controls.Add(this.infoxRegionesBtn);
            this.Controls.Add(this.btnCargarGráfico);
            this.Controls.Add(this.chartTest);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "ReportesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.ReportesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTest;
        private System.Windows.Forms.Button btnCargarGráfico;
        private System.Windows.Forms.Button infoxRegionesBtn;
        private System.Windows.Forms.Button áreaInvesBtn;
        private System.Windows.Forms.Button ciudadesBtn;
        private System.Windows.Forms.Button clasificaciónBtn;
        private System.Windows.Forms.Label label1;
    }
}