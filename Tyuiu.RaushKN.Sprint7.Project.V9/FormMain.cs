using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.Design.Behavior;
using Tyuiu.RaushKN.Sprint7.Project.V9.Lib;

namespace Tyuiu.RaushKN.Sprint7.Project.V9
{
    public partial class FormMain_RKN : Form
    {
        DataService ds = new DataService();
        public List<VideoClip> videoClips = new List<VideoClip>();
        public const string filePath = "video_clips.csv";
        public FormMain_RKN()
        {
            InitializeComponent();
            LoadData();
            UpdateDataGridView();
            this.dataGridViewVideoClips_RKN.SelectionChanged += new EventHandler(dataGridViewVideoClips_RKN_SelectionChanged);
        }

        private void dataGridViewVideoClips_RKN_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVideoClips_RKN.SelectedRows.Count > 0)
            {
                MessageBox.Show("Selection changed!");
                var selectedClip = (VideoClip)dataGridViewVideoClips_RKN.SelectedRows[0].DataBoundItem;
                // Обновление текстовых полей с данными выбранного клипа
                textBoxCode_RKN.Text = selectedClip.Code;
                textBoxDate_RKN.Text = selectedClip.Date.ToString("yyyy-MM-dd");
                textBoxDuration_RKN.Text = selectedClip.Duration.ToString();
                textBoxTheme_RKN.Text = selectedClip.Theme;
                textBoxCost_RKN.Text = selectedClip.Cost.ToString();
                textBoxActorLastName_RKN.Text = selectedClip.ActorLastName;
                textBoxActorFirstName_RKN.Text = selectedClip.ActorFirstName;
                textBoxActorPatronymic_RKN.Text = selectedClip.ActorPatronymic;
            }
        }

        private void dataGridViewVideoClips_RKN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обработчик события для выбора строки
            if (e.RowIndex >= 0)
            {
                var selectedClip = (VideoClip)dataGridViewVideoClips_RKN.Rows[e.RowIndex].DataBoundItem;
                // Обновление текстовых полей с данными выбранного клипа
                textBoxCode_RKN.Text = selectedClip.Code;
                textBoxDate_RKN.Text = selectedClip.Date.ToString("yyyy-MM-dd");
                textBoxDuration_RKN.Text = selectedClip.Duration.ToString();
                textBoxTheme_RKN.Text = selectedClip.Theme;
                textBoxCost_RKN.Text = selectedClip.Cost.ToString();
                textBoxActorLastName_RKN.Text = selectedClip.ActorLastName;
                textBoxActorFirstName_RKN.Text = selectedClip.ActorFirstName;
                textBoxActorPatronymic_RKN.Text = selectedClip.ActorPatronymic;
            }
        }

        private void dataGridViewVideoClips_RKN_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            // Обработчик события для добавления строки
            var newRow = e.Row;
            // Обновление данных в новой строке
            newRow.Cells["Code"].Value = textBoxCode_RKN.Text;
            newRow.Cells["Date"].Value = textBoxDate_RKN.Text;
            newRow.Cells["Duration"].Value = textBoxDuration_RKN.Text;
            newRow.Cells["Theme"].Value = textBoxTheme_RKN.Text;
            newRow.Cells["Cost"].Value = textBoxCost_RKN.Text;
            newRow.Cells["ActorLastName"].Value = textBoxActorLastName_RKN.Text;
            newRow.Cells["ActorFirstName"].Value = textBoxActorFirstName_RKN.Text;
            newRow.Cells["ActorPatronymic"].Value = textBoxActorPatronymic_RKN.Text;
        }



        public void LoadData()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 7)
                    {
                        videoClips.Add(new VideoClip
                        {
                            Code = parts[0],
                            Date = DateTime.Parse(parts[1]),
                            Duration = TimeSpan.Parse(parts[2]),
                            Theme = parts[3],
                            Cost = decimal.Parse(parts[4]),
                            ActorLastName = parts[5],
                            ActorFirstName = parts[6],
                            ActorPatronymic = parts[7]
                        });
                    }
                }
            }
        }

        public void SaveData()
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var clip in videoClips)
                {
                    writer.WriteLine($"{clip.Code},{clip.Date},{clip.Duration},{clip.Theme},{clip.Cost},{clip.ActorLastName},{clip.ActorFirstName},{clip.ActorPatronymic}");
                }
            }
        }

        private bool isUpdatingDataGridView = false;

        private void UpdateDataGridView()
        {
            if (isUpdatingDataGridView) return; // Если обновляем, выходим

            try
            {
                isUpdatingDataGridView = true; // Устанавливаем флаг
                dataGridViewVideoClips_RKN.DataSource = null; // Сбрасываем источник данных
                dataGridViewVideoClips_RKN.DataSource = videoClips; // Устанавливаем новый источник данных
            }
            finally
            {
                isUpdatingDataGridView = false; // Сбрасываем флаг
            }
        }

        public void buttonAddClip_Click(object sender, EventArgs e)
        {
            try
            {
                var newClip = new VideoClip
                {
                    Code = textBoxCode_RKN.Text,
                    Date = DateTime.Parse(textBoxDate_RKN.Text),
                    Duration = TimeSpan.Parse(textBoxDuration_RKN.Text),
                    Theme = textBoxTheme_RKN.Text,
                    Cost = decimal.Parse(textBoxCost_RKN.Text),
                    ActorLastName = textBoxActorLastName_RKN.Text,
                    ActorFirstName = textBoxActorFirstName_RKN.Text,
                    ActorPatronymic = textBoxActorPatronymic_RKN.Text
                };
                videoClips.Add(newClip);
                UpdateDataGridView();
                SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении клипа: {ex.Message}");
            }
        }

        public void buttonEditClip_Click(Object sender, EventArgs e)
        {
            if (dataGridViewVideoClips_RKN.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedClip = (VideoClip)dataGridViewVideoClips_RKN.SelectedRows[0].DataBoundItem;
                    selectedClip.Code = textBoxCode_RKN.Text;
                    selectedClip.Date = DateTime.Parse(textBoxDate_RKN.Text);
                    selectedClip.Duration = TimeSpan.Parse(textBoxDuration_RKN.Text);
                    selectedClip.Theme = textBoxTheme_RKN.Text;
                    selectedClip.Cost = decimal.Parse(textBoxCost_RKN.Text);
                    selectedClip.ActorLastName = textBoxActorLastName_RKN.Text;
                    selectedClip.ActorFirstName = textBoxActorFirstName_RKN.Text;
                    selectedClip.ActorPatronymic = textBoxActorPatronymic_RKN.Text;

                    UpdateDataGridView();
                    SaveData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при редактировании клипа: {ex.Message}");
                }
            }
        }

        public void buttonDeleteClip_Click(object sender, EventArgs e)
        {
            if (dataGridViewVideoClips_RKN.SelectedRows.Count > 0)
            {
                var selectedClip = (VideoClip)dataGridViewVideoClips_RKN.SelectedRows[0].DataBoundItem;
                videoClips.Remove(selectedClip);
                UpdateDataGridView();
                SaveData();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите клип для удаления.");
            }
        }

        public class VideoClip
        {
            public string Code { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan Duration { get; set; }
            public string Theme { get; set; }
            public decimal Cost { get; set; }
            public string ActorLastName { get; set; }
            public string ActorFirstName { get; set; }
            public string ActorPatronymic { get; set; }

        }
    }
}
