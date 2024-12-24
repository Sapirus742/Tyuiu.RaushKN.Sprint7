﻿namespace Tyuiu.RaushKN.Sprint7.Project.V9
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            this.chartGenreStatistics_RKN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenreStatistics_RKN)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGenreStatistics_RKN
            // 
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorTickMark.Interval = 1D;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.MajorGrid.Interval = 1D;
            chartArea1.AxisY.MajorTickMark.Interval = 1D;
            chartArea1.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Straight;
            chartArea1.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea1.Name = "ChartAreaGenre_RKN";
            this.chartGenreStatistics_RKN.ChartAreas.Add(chartArea1);
            this.chartGenreStatistics_RKN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGenreStatistics_RKN.Location = new System.Drawing.Point(0, 0);
            this.chartGenreStatistics_RKN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartGenreStatistics_RKN.Name = "chartGenreStatistics_RKN";
            series1.ChartArea = "ChartAreaGenre_RKN";
            series1.Name = "Series1";
            this.chartGenreStatistics_RKN.Series.Add(series1);
            this.chartGenreStatistics_RKN.Size = new System.Drawing.Size(529, 366);
            this.chartGenreStatistics_RKN.TabIndex = 0;
            this.chartGenreStatistics_RKN.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 366);
            this.Controls.Add(this.chartGenreStatistics_RKN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(545, 405);
            this.Name = "FormStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика по жанрам";
            ((System.ComponentModel.ISupportInitialize)(this.chartGenreStatistics_RKN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGenreStatistics_RKN;
    }
}