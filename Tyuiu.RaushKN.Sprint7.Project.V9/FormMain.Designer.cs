namespace Tyuiu.RaushKN.Sprint7.Project.V9
{
    partial class FormMain_RKN
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            toolStripMain = new ToolStrip();
            textBoxCode_RKN = new TextBox();
            textBoxDate_RKN = new TextBox();
            textBoxDuration_RKN = new TextBox();
            textBoxTheme_RKN = new TextBox();
            textBoxCost_RKN = new TextBox();
            textBoxActorLastName_RKN = new TextBox();
            textBoxActorFirstName_RKN = new TextBox();
            textBoxActorPatronymic_RKN = new TextBox();
            buttonAddClip_RKN = new Button();
            buttonEditClip_RKN = new Button();
            buttonDeleteClip_RKN = new Button();
            labelCode_RKN = new Label();
            labelDate_RKN = new Label();
            labelDuration_RKN = new Label();
            labelTheme_RKN = new Label();
            labelCost_RKN = new Label();
            labelActorLastName_RKN = new Label();
            labelActorFirstName_RKN = new Label();
            labelActorPatronymic_RKN = new Label();
            dataGridViewVideoClips_RKN = new DataGridView();
            openFileDialog_RKN = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVideoClips_RKN).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(1366, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStripMain_RKN";
            // 
            // toolStripMain
            // 
            toolStripMain.Location = new Point(0, 24);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Size = new Size(1366, 25);
            toolStripMain.TabIndex = 1;
            toolStripMain.Text = "toolStripMain_RKN";
            // 
            // textBoxCode_RKN
            // 
            textBoxCode_RKN.Location = new Point(12, 50);
            textBoxCode_RKN.Name = "textBoxCode_RKN";
            textBoxCode_RKN.Size = new Size(200, 23);
            textBoxCode_RKN.TabIndex = 3;
            // 
            // textBoxDate_RKN
            // 
            textBoxDate_RKN.Location = new Point(220, 50);
            textBoxDate_RKN.Name = "textBoxDate_RKN";
            textBoxDate_RKN.Size = new Size(200, 23);
            textBoxDate_RKN.TabIndex = 4;
            // 
            // textBoxDuration_RKN
            // 
            textBoxDuration_RKN.Location = new Point(430, 50);
            textBoxDuration_RKN.Name = "textBoxDuration_RKN";
            textBoxDuration_RKN.Size = new Size(200, 23);
            textBoxDuration_RKN.TabIndex = 5;
            // 
            // textBoxTheme_RKN
            // 
            textBoxTheme_RKN.Location = new Point(640, 50);
            textBoxTheme_RKN.Name = "textBoxTheme_RKN";
            textBoxTheme_RKN.Size = new Size(200, 23);
            textBoxTheme_RKN.TabIndex = 6;
            // 
            // textBoxCost_RKN
            // 
            textBoxCost_RKN.Location = new Point(850, 50);
            textBoxCost_RKN.Name = "textBoxCost_RKN";
            textBoxCost_RKN.Size = new Size(200, 23);
            textBoxCost_RKN.TabIndex = 7;
            // 
            // textBoxActorLastName_RKN
            // 
            textBoxActorLastName_RKN.Location = new Point(12, 100);
            textBoxActorLastName_RKN.Name = "textBoxActorLastName_RKN";
            textBoxActorLastName_RKN.Size = new Size(200, 23);
            textBoxActorLastName_RKN.TabIndex = 8;
            // 
            // textBoxActorFirstName_RKN
            // 
            textBoxActorFirstName_RKN.Location = new Point(220, 100);
            textBoxActorFirstName_RKN.Name = "textBoxActorFirstName_RKN";
            textBoxActorFirstName_RKN.Size = new Size(200, 23);
            textBoxActorFirstName_RKN.TabIndex = 9;
            // 
            // textBoxActorPatronymic_RKN
            // 
            textBoxActorPatronymic_RKN.Location = new Point(430, 100);
            textBoxActorPatronymic_RKN.Name = "textBoxActorPatronymic_RKN";
            textBoxActorPatronymic_RKN.Size = new Size(200, 23);
            textBoxActorPatronymic_RKN.TabIndex = 10;
            // 
            // buttonAddClip_RKN
            // 
            buttonAddClip_RKN.Location = new Point(640, 100);
            buttonAddClip_RKN.Name = "buttonAddClip_RKN";
            buttonAddClip_RKN.Size = new Size(75, 23);
            buttonAddClip_RKN.TabIndex = 11;
            buttonAddClip_RKN.Text = "Добавить";
            buttonAddClip_RKN.UseVisualStyleBackColor = true;
            buttonAddClip_RKN.Click += buttonAddClip_Click;
            // 
            // buttonEditClip_RKN
            // 
            buttonEditClip_RKN.Location = new Point(730, 100);
            buttonEditClip_RKN.Name = "buttonEditClip_RKN";
            buttonEditClip_RKN.Size = new Size(75, 23);
            buttonEditClip_RKN.TabIndex = 12;
            buttonEditClip_RKN.Text = "Редактировать";
            buttonEditClip_RKN.UseVisualStyleBackColor = true;
            buttonEditClip_RKN.Click += buttonEditClip_Click;
            // 
            // buttonDeleteClip_RKN
            // 
            buttonDeleteClip_RKN.Location = new Point(820, 100);
            buttonDeleteClip_RKN.Name = "buttonDeleteClip_RKN";
            buttonDeleteClip_RKN.Size = new Size(75, 23);
            buttonDeleteClip_RKN.TabIndex = 13;
            buttonDeleteClip_RKN.Text = "Удалить";
            buttonDeleteClip_RKN.UseVisualStyleBackColor = true;
            buttonDeleteClip_RKN.Click += buttonDeleteClip_Click;
            // 
            // labelCode_RKN
            // 
            labelCode_RKN.AutoSize = true;
            labelCode_RKN.Location = new Point(12, 34);
            labelCode_RKN.Name = "labelCode_RKN";
            labelCode_RKN.Size = new Size(30, 15);
            labelCode_RKN.TabIndex = 14;
            labelCode_RKN.Text = "Код:";
            // 
            // labelDate_RKN
            // 
            labelDate_RKN.AutoSize = true;
            labelDate_RKN.Location = new Point(220, 34);
            labelDate_RKN.Name = "labelDate_RKN";
            labelDate_RKN.Size = new Size(35, 15);
            labelDate_RKN.TabIndex = 15;
            labelDate_RKN.Text = "Дата:";
            // 
            // labelDuration_RKN
            // 
            labelDuration_RKN.AutoSize = true;
            labelDuration_RKN.Location = new Point(430, 34);
            labelDuration_RKN.Name = "labelDuration_RKN";
            labelDuration_RKN.Size = new Size(87, 15);
            labelDuration_RKN.TabIndex = 16;
            labelDuration_RKN.Text = "Длительность:";
            // 
            // labelTheme_RKN
            // 
            labelTheme_RKN.AutoSize = true;
            labelTheme_RKN.Location = new Point(640, 34);
            labelTheme_RKN.Name = "labelTheme_RKN";
            labelTheme_RKN.Size = new Size(38, 15);
            labelTheme_RKN.TabIndex = 17;
            labelTheme_RKN.Text = "Тема:";
            // 
            // labelCost_RKN
            // 
            labelCost_RKN.AutoSize = true;
            labelCost_RKN.Location = new Point(850, 34);
            labelCost_RKN.Name = "labelCost_RKN";
            labelCost_RKN.Size = new Size(70, 15);
            labelCost_RKN.TabIndex = 18;
            labelCost_RKN.Text = "Стоимость:";
            // 
            // labelActorLastName_RKN
            // 
            labelActorLastName_RKN.AutoSize = true;
            labelActorLastName_RKN.Location = new Point(12, 84);
            labelActorLastName_RKN.Name = "labelActorLastName_RKN";
            labelActorLastName_RKN.Size = new Size(100, 15);
            labelActorLastName_RKN.TabIndex = 19;
            labelActorLastName_RKN.Text = "Фамилия актёра:";
            // 
            // labelActorFirstName_RKN
            // 
            labelActorFirstName_RKN.AutoSize = true;
            labelActorFirstName_RKN.Location = new Point(220, 84);
            labelActorFirstName_RKN.Name = "labelActorFirstName_RKN";
            labelActorFirstName_RKN.Size = new Size(73, 15);
            labelActorFirstName_RKN.TabIndex = 20;
            labelActorFirstName_RKN.Text = "Имя актёра:";
            // 
            // labelActorPatronymic_RKN
            // 
            labelActorPatronymic_RKN.AutoSize = true;
            labelActorPatronymic_RKN.Location = new Point(430, 84);
            labelActorPatronymic_RKN.Name = "labelActorPatronymic_RKN";
            labelActorPatronymic_RKN.Size = new Size(85, 13);
            labelActorPatronymic_RKN.TabIndex = 21;
            labelActorPatronymic_RKN.Text = "Отчество актёра:";
            // 
            // dataGridViewVideoClips_RKN
            // 
            dataGridViewVideoClips_RKN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVideoClips_RKN.Location = new Point(12, 150);
            dataGridViewVideoClips_RKN.Name = "dataGridViewVideoClips_RKN";
            dataGridViewVideoClips_RKN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVideoClips_RKN.Size = new Size(1342, 600);
            dataGridViewVideoClips_RKN.TabIndex = 2;
            dataGridViewVideoClips_RKN.CellClick += dataGridViewVideoClips_RKN_CellClick;
            dataGridViewVideoClips_RKN.SelectionChanged += buttonEditClip_Click;
            dataGridViewVideoClips_RKN.UserAddedRow += dataGridViewVideoClips_RKN_UserAddedRow;
            // 
            // openFileDialog_RKN
            // 
            openFileDialog_RKN.FileName = "openFileDialog_RKN";
            // 
            // FormMain_RKN
            // 
            ClientSize = new Size(1366, 768);
            Controls.Add(labelActorFirstName_RKN);
            Controls.Add(labelActorLastName_RKN);
            Controls.Add(labelCost_RKN);
            Controls.Add(labelTheme_RKN);
            Controls.Add(labelDuration_RKN);
            Controls.Add(labelDate_RKN);
            Controls.Add(labelCode_RKN);
            Controls.Add(buttonDeleteClip_RKN);
            Controls.Add(buttonEditClip_RKN);
            Controls.Add(buttonAddClip_RKN);
            Controls.Add(textBoxActorPatronymic_RKN);
            Controls.Add(textBoxActorFirstName_RKN);
            Controls.Add(textBoxActorLastName_RKN);
            Controls.Add(textBoxCost_RKN);
            Controls.Add(textBoxTheme_RKN);
            Controls.Add(textBoxDuration_RKN);
            Controls.Add(textBoxDate_RKN);
            Controls.Add(textBoxCode_RKN);
            Controls.Add(dataGridViewVideoClips_RKN);
            Controls.Add(toolStripMain);
            Controls.Add(menuStripMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStripMain;
            MaximizeBox = false;
            Name = "FormMain_RKN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каталог видео клипов";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVideoClips_RKN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.TextBox textBoxCode_RKN;
        private System.Windows.Forms.TextBox textBoxDate_RKN;
        private System.Windows.Forms.TextBox textBoxDuration_RKN;
        private System.Windows.Forms.TextBox textBoxTheme_RKN;
        private System.Windows.Forms.TextBox textBoxCost_RKN;
        private System.Windows.Forms.TextBox textBoxActorLastName_RKN;
        private System.Windows.Forms.TextBox textBoxActorFirstName_RKN;
        private System.Windows.Forms.TextBox textBoxActorPatronymic_RKN;
        private System.Windows.Forms.Button buttonEditClip_RKN;
        private System.Windows.Forms.Button buttonDeleteClip_RKN;
        private System.Windows.Forms.Button buttonAddClip_RKN;
        private System.Windows.Forms.Label labelCode_RKN;
        private System.Windows.Forms.Label labelDate_RKN;
        private System.Windows.Forms.Label labelDuration_RKN;
        private System.Windows.Forms.Label labelTheme_RKN;
        private System.Windows.Forms.Label labelCost_RKN;
        private System.Windows.Forms.Label labelActorLastName_RKN;
        private System.Windows.Forms.Label labelActorFirstName_RKN;
        private System.Windows.Forms.Label labelActorPatronymic_RKN;
        private new SizeF AutoScaleDimensions;
        private new AutoScaleMode AutoScaleMode;
        private DataGridView dataGridViewVideoClips_RKN;
        private OpenFileDialog openFileDialog_RKN;
    }
}
