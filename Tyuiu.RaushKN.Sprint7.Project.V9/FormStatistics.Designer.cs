namespace Tyuiu.RaushKN.Sprint7.Project.V9
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
            chartGenreStatistics_RKN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartGenreStatistics_RKN).BeginInit();
            SuspendLayout();
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
            chartGenreStatistics_RKN.ChartAreas.Add(chartArea1);
            chartGenreStatistics_RKN.Dock = DockStyle.Fill;
            chartGenreStatistics_RKN.Location = new Point(0, 0);
            chartGenreStatistics_RKN.Margin = new Padding(2);
            chartGenreStatistics_RKN.Name = "chartGenreStatistics_RKN";
            series1.ChartArea = "ChartAreaGenre_RKN";
            series1.Name = "Series1";
            chartGenreStatistics_RKN.Series.Add(series1);
            chartGenreStatistics_RKN.Size = new Size(617, 422);
            chartGenreStatistics_RKN.TabIndex = 0;
            chartGenreStatistics_RKN.Click += chart1_Click;
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 422);
            Controls.Add(chartGenreStatistics_RKN);
            Margin = new Padding(2);
            MinimumSize = new Size(633, 461);
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)chartGenreStatistics_RKN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGenreStatistics_RKN;
    }
}