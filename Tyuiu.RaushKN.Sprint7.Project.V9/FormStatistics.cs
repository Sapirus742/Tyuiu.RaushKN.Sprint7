using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.RaushKN.Sprint7.Project.V9.Lib;

namespace Tyuiu.RaushKN.Sprint7.Project.V9
{
    public partial class FormStatistics : Form
    {
        DataService ds = new DataService();
        public FormStatistics()
        {
            InitializeComponent();
            ShowStatistics();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ShowStatistics()
        {
            chartGenreStatistics_RKN.Series[0].Points.Clear();

            chartGenreStatistics_RKN.ChartAreas[0].AxisX.Title = "Жанры";
            chartGenreStatistics_RKN.ChartAreas[0].AxisY.Title = "Количество фильмов";

            string[] genres = { "Боевик", "Детектив", "Драма", "Исторический фильм", "Комедия", "Мюзикл", "Фантастика", "Хоррор", "Романтика" };
            int[] genreStats = ds.GetGenreStatistics();

            for (int i = 0; i < genres.Length; i++)
            {
                chartGenreStatistics_RKN.Series[0].Points.AddXY(genres[i], genreStats[i]);
            }

        }
    }
}
