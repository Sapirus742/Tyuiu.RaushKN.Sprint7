using Tyuiu.RaushKN.Sprint7.Project.V9.Lib;

namespace Tyuiu.RaushKN.Sprint7.Project.V9
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        int openedFilm = -1;
        int sortType = 0;
        Size defaultLabelSize;

        string pathImg = $@"{Directory.GetCurrentDirectory()}\image\";

        public FormMain()
        {
            InitializeComponent();
            UpdateFilmsButtons();
            ds.ClearUnusedImages();

            toolStripComboBoxSort_RKN.SelectedIndex = sortType;
            defaultLabelSize = labelGenreText_RKN.Size;
        }
        private void buttonAdd_RKN_Click(object sender, EventArgs e)
        {
            FormAddFilm AddForm = new FormAddFilm();
            AddForm.ShowDialog();
            UpdateFilmsButtons();
        }

        private void buttonDelete_RKN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить информацию о {labelName_RKN.Text}?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                flowLayoutPanelLeft_RKN.Controls.Clear();
                ds.DeleteFilm(openedFilm);
                InfoReset();
                UpdateFilmsButtons();
            }
        }
        public void Search(string request)
        {
            flowLayoutPanelLeft_RKN.Controls.Clear();

            string[] allFilmsNames = ds.GetNecessaryTypeInfo(1);
            string[] allFilmsImages = ds.GetNecessaryTypeInfo(0);

            for (int i = 0; i < allFilmsNames.Length; i++)
            {
                string lowerFilmName = allFilmsNames[i].ToLower();

                if (lowerFilmName.Contains(request.ToLower()))
                {
                    Button newButton = CreateButton(allFilmsNames[i], i, allFilmsImages[i], i);
                    flowLayoutPanelLeft_RKN.Controls.Add(newButton);
                }
            }

            if (flowLayoutPanelLeft_RKN.Controls.Count == 0)
            {
                UpdateFilmsButtons();
                MessageBox.Show("Запрос не найден.", "Ошибка");
            }
        }
        private Button CreateButton(string filmName, int lineNum, string pathImage, int tabIndex)
        {
            Size buttonSize = new Size(94, 141);
            Button openButton = new Button();
            openButton.Size = buttonSize;
            openButton.Text = filmName;
            openButton.ForeColor = Color.Black;
            openButton.TextAlign = ContentAlignment.BottomCenter;
            openButton.Name = $"buttonFilm{lineNum}_RKN";
            try
            {
                openButton.BackgroundImage = Image.FromFile(pathImg + pathImage);
            }
            catch
            {
                openButton.BackgroundImage = Image.FromFile($@"{Directory.GetCurrentDirectory()}\Resources\imageLoadError.jpg");
            }
            openButton.BackgroundImageLayout = ImageLayout.Stretch;
            openButton.TabIndex = tabIndex;
            openButton.Click += new EventHandler(this.OpenFilm);
            return openButton;
        }
        private void InfoReset()
        {
            pictureBoxPreview_RKN.Image = Image.FromFile($@"{Directory.GetCurrentDirectory()}\Resources\imagePlaceholder.jpg");
            labelName_RKN.Text = "Выберите фильм";
            labelCountryText_RKN.Text = "-";
            labelScreenwriterText_RKN.Text = "-";
            labelDirectorText_RKN.Text = "-";
            labelGenreText_RKN.Text = "-";
            labelRoleText_RKN.Text = "-";
            labelRatingText_RKN.Text = "-";
            labelYearText_RKN.Text = "-";
            labelDescriptionText_RKN.Text = "-";

            toolStripButtonDelete_RKN.Enabled = false;
        }
        public void UpdateFilmsButtons()
        {
            flowLayoutPanelLeft_RKN.Controls.Clear();
            int filmsCount = ds.GetFilmCount();
            if (filmsCount == 0) return;

            string[] temp;
            int[] sortedLinesNums = new int[filmsCount];

            switch (sortType)
            {
                case 0:
                    for (int i = 0; i < filmsCount; i++)
                    {
                        temp = ds.GetNecessaryFilmInfo(i);
                        Button newButton = CreateButton(temp[1], i, temp[0], i);
                        flowLayoutPanelLeft_RKN.Controls.Add(newButton);
                    }
                    break;

                case 1:
                    string[] names = ds.GetNecessaryTypeInfo(1);
                    string[] sortedNames = ds.GetNecessaryTypeInfo(1);
                    Array.Sort(sortedNames);

                    for (int i = 0; i < filmsCount; i++)
                    {
                        for (int j = 0; j < filmsCount; j++)
                        {
                            if (sortedNames[i] == names[j])
                            {
                                sortedLinesNums[i] = j;
                                break;
                            }
                        }
                    }

                    foreach (int item in sortedLinesNums)
                    {
                        temp = ds.GetNecessaryFilmInfo(item);
                        Button newButton = CreateButton(temp[1], item, temp[0], item);
                        flowLayoutPanelLeft_RKN.Controls.Add(newButton);
                    }
                    break;

                case 2:
                    string[] years = ds.GetNecessaryTypeInfo(2);
                    for (int i = 0; i < sortedLinesNums.Length; i++)
                    {
                        sortedLinesNums[i] = i;
                    }

                    string tempYearString;
                    int tempYearInt;
                    for (int i = 0; i < years.Length - 1; i++)
                    {
                        for (int j = i + 1; j < years.Length; j++)
                        {
                            if (int.Parse(years[i]) > int.Parse(years[j]))
                            {
                                tempYearString = years[i];
                                years[i] = years[j];
                                years[j] = tempYearString;

                                tempYearInt = sortedLinesNums[i];
                                sortedLinesNums[i] = sortedLinesNums[j];
                                sortedLinesNums[j] = tempYearInt;
                            }
                        }
                    }

                    foreach (int item in sortedLinesNums)
                    {
                        temp = ds.GetNecessaryFilmInfo(item);
                        Button newButton = CreateButton(temp[1], item, temp[0], item);
                        flowLayoutPanelLeft_RKN.Controls.Add(newButton);
                    }
                    break;
            }
        }


        private void OpenFilm(Object sender, EventArgs e)
        {
            string[] genres = { "Боевик", "Детектив", "Драма", "Исторический фильм", "Комедия", "Мюзикл", "Фантастика", "Хоррор", "Романтика"};
            Button b = (Button)sender;
            toolStripButtonDelete_RKN.Enabled = true;
            openedFilm = b.TabIndex;

            string[] data = ds.GetNecessaryFilmInfo(openedFilm);

            try
            {
                pictureBoxPreview_RKN.Image = Image.FromFile(pathImg + data[0]);
            }
            catch
            {
                pictureBoxPreview_RKN.Image = Image.FromFile($@"{Directory.GetCurrentDirectory()}\Resources\imageLoadError.jpg");
            }
            labelName_RKN.Text = data[1];
            labelYearText_RKN.Text = data[2];
            labelGenreText_RKN.Text = genres[int.Parse(data[3])];
            labelDirectorText_RKN.Text = data[4];
            labelScreenwriterText_RKN.Text = data[5];
            labelCountryText_RKN.Text = data[6];
            labelRoleText_RKN.Text = data[8];
            labelRatingText_RKN.Text = data[7];
            labelDescriptionText_RKN.Text = data[9];

            MoveLabels();
        }


        private void toolStripButtonAdd_RKN_Click(object sender, EventArgs e)
        {
            FormAddFilm AddForm = new FormAddFilm();
            AddForm.ShowDialog();
            UpdateFilmsButtons();
        }


        private void toolStripButtonDelete_RKN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить информацию о {labelName_RKN.Text}?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                flowLayoutPanelLeft_RKN.Controls.Clear();
                ds.DeleteFilm(openedFilm);
                InfoReset();
                UpdateFilmsButtons();
            }

        }


        private void toolStripButtonSearch_RKN_Click_2(object sender, EventArgs e)
        {
            string searchRequest = toolStripTextBoxSearch_RKN.Text;

            if (!string.IsNullOrEmpty(searchRequest))
            {
                Search(searchRequest.ToLower());
            }
            else
            {
                UpdateFilmsButtons();
                MessageBox.Show("Задан пустой поисковой запрос.", "Ошибка");
            }
        }

        private void toolStripButtonStat_RKN_Click_3(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics();
            formStatistics.ShowDialog();
        }

        private void toolStripTextBoxSearch_RKN_Enter(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch_RKN.Text == "Поиск...")
            {
                toolStripTextBoxSearch_RKN.Text = "";
                toolStripTextBoxSearch_RKN.ForeColor = Color.Black;
            }
        }

        private void toolStripTextBoxSearch_RKN_Leave(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch_RKN.Text == "")
            {
                toolStripTextBoxSearch_RKN.Text = "Поиск...";
                toolStripTextBoxSearch_RKN.ForeColor = Color.Silver;
            }
        }

        private void toolStripButtonHelp_RKN_Click(object sender, EventArgs e)
        {
            FormInformatoin formInformation = new FormInformatoin();
            formInformation.ShowDialog();
        }

        private void toolStripButtonHelp_RKN_Click_1(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }


        private Size GetLabelSize(Label neededLabel)
        {
            Size neededSize = new Size(neededLabel.Width, defaultLabelSize.Height);

            Size result = neededLabel.GetPreferredSize(neededSize);
            return result;
        }

        private void MoveLabels()
        {
            Label[] titles = { labelDirector_RKN, labelScreenwriter_RKN, labelRole_RKN, labelCountry_RKN, labelRating_RKN, labelDescription_RKN };
            Label[] parametrs = { labelDirectorText_RKN, labelScreenwriterText_RKN, labelRoleText_RKN, labelCountryText_RKN, labelRatingText_RKN, labelDescriptionText_RKN };

            for (int i = 0; i < parametrs.Length; i++)
            {
                Size parametrSize = new Size(parametrs[i].Width, GetLabelSize(parametrs[i]).Height);

                parametrs[i].Size = parametrSize;

                if (i != parametrs.Length - 1)
                {
                    int AxisY = parametrs[i].Location.Y + parametrs[i].Size.Height;
                    parametrs[i + 1].Location = new Point(parametrs[i].Location.X, AxisY);
                    titles[i + 1].Location = new Point(titles[i].Location.X, AxisY);
                }
            }


        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            MoveLabels();
        }

        private void toolStripComboBoxSort_RKN_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortType = toolStripComboBoxSort_RKN.SelectedIndex;
            UpdateFilmsButtons();
        }

        private void panelMain_RKN_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
