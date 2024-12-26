using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.RaushKN.Sprint7.Project.V9.Lib;

namespace Tyuiu.RaushKN.Sprint7.Project.V9
{
    public partial class FormAddFilm : Form
    {
        public FormAddFilm()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonAdd_RKN_Click(object sender, EventArgs e)
        {
            string[] values = new string[10];

            if(int.TryParse(textBoxYear_RKN.Text, out var number))
                if (pathImage != "" && comboBoxGenre_RKN.SelectedIndex > -1 && !string.IsNullOrEmpty(textBoxName_RKN.Text) && !string.IsNullOrEmpty(textBoxName_RKN.Text) && !string.IsNullOrEmpty(textBoxScreenwriter_RKN.Text) && !string.IsNullOrEmpty(textBoxDirector_RKN.Text) && !string.IsNullOrEmpty(textBoxRole_RKN.Text) && !string.IsNullOrEmpty(textBoxRating_RKN.Text) && !string.IsNullOrEmpty(textBoxYear_RKN.Text) && !string.IsNullOrEmpty(textBoxDescription_RKN.Text))
                {
                    values[0] = pathImage;
                    values[1] = textBoxName_RKN.Text;
                    values[2] = textBoxYear_RKN.Text;
                    values[3] = comboBoxGenre_RKN.SelectedIndex.ToString();
                    values[4] = textBoxDirector_RKN.Text;
                    values[5] = textBoxScreenwriter_RKN.Text;
                    values[6] = textBoxCountry_RKN.Text;
                    values[7] = textBoxRating_RKN.Text;
                    values[8] = textBoxRole_RKN.Text;
                    values[9] = textBoxDescription_RKN.Text;

                    ds.AddFilm(values);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Заполните все поля!!!", "Ошибка");
                }
            else
            {
                MessageBox.Show("Неправильный формат даты", "Ошибка");
            }
        }
        string pathImage = @"C:\Users\rausc\source\repos\Tyuiu.RaushKN.Sprint7\Tyuiu.RaushKN.Sprint7.Project.V9\bin\Debug\net8.0-windows\Resources\imageLoadError.jpg";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage_RKN.ShowDialog() == DialogResult.OK)
            {
                pathImage = openFileDialogImage_RKN.FileName;
                pictureBoxPreview_RKN.Image = Image.FromFile(pathImage);
            }
        }
        private void comboBoxGenre_RKN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
