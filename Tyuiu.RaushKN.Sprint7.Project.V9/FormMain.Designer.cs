namespace Tyuiu.RaushKN.Sprint7.Project.V9
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            toolStripMenu_RKN = new ToolStrip();
            toolStripButtonAdd_RKN = new ToolStripButton();
            toolStripButtonDelete_RKN = new ToolStripButton();
            toolStripSeparator1_RKN = new ToolStripSeparator();
            toolStripComboBoxSort_RKN = new ToolStripComboBox();
            toolStripSeparator2_RKN = new ToolStripSeparator();
            toolStripButtonInformation_RKN = new ToolStripButton();
            toolStripButtonHelp_RKN = new ToolStripButton();
            toolStripTextBoxSearch_RKN = new ToolStripTextBox();
            toolStripButtonSearch_RKN = new ToolStripButton();
            toolStripButtonStat_RKN = new ToolStripButton();
            toolTip_RKN = new ToolTip(components);
            flowLayoutPanelLeft_RKN = new FlowLayoutPanel();
            labelDescriptionText_RKN = new Label();
            labelRatingText_RKN = new Label();
            labelCountryText_RKN = new Label();
            labelRating_RKN = new Label();
            labelScreenwriter_RKN = new Label();
            labelCountry_RKN = new Label();
            labelRoleText_RKN = new Label();
            labelDirector_RKN = new Label();
            labelRole_RKN = new Label();
            labelScreenwriterText_RKN = new Label();
            pictureBoxPreview_RKN = new PictureBox();
            labelGenre_RKN = new Label();
            labelYear_RKN = new Label();
            labelDirectorText_RKN = new Label();
            labelDescription_RKN = new Label();
            labelGenreText_RKN = new Label();
            labelYearText_RKN = new Label();
            labelName_RKN = new Label();
            panelMain_RKN = new Panel();
            toolStripMenu_RKN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview_RKN).BeginInit();
            panelMain_RKN.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripMenu_RKN
            // 
            toolStripMenu_RKN.BackColor = Color.Gray;
            toolStripMenu_RKN.ImageScalingSize = new Size(20, 20);
            toolStripMenu_RKN.Items.AddRange(new ToolStripItem[] { toolStripButtonAdd_RKN, toolStripButtonDelete_RKN, toolStripSeparator1_RKN, toolStripComboBoxSort_RKN, toolStripSeparator2_RKN, toolStripButtonInformation_RKN, toolStripButtonHelp_RKN, toolStripTextBoxSearch_RKN, toolStripButtonSearch_RKN, toolStripButtonStat_RKN });
            toolStripMenu_RKN.Location = new Point(0, 0);
            toolStripMenu_RKN.Name = "toolStripMenu_RKN";
            toolStripMenu_RKN.Size = new Size(850, 27);
            toolStripMenu_RKN.TabIndex = 3;
            // 
            // toolStripButtonAdd_RKN
            // 
            toolStripButtonAdd_RKN.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAdd_RKN.Image = Properties.Resources._1;
            toolStripButtonAdd_RKN.ImageTransparentColor = Color.Magenta;
            toolStripButtonAdd_RKN.Name = "toolStripButtonAdd_RKN";
            toolStripButtonAdd_RKN.Size = new Size(24, 24);
            toolStripButtonAdd_RKN.Text = "Добавить фильм";
            toolStripButtonAdd_RKN.ToolTipText = "Добавить";
            toolStripButtonAdd_RKN.Click += toolStripButtonAdd_RKN_Click;
            // 
            // toolStripButtonDelete_RKN
            // 
            toolStripButtonDelete_RKN.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDelete_RKN.Enabled = false;
            toolStripButtonDelete_RKN.Image = Properties.Resources._4;
            toolStripButtonDelete_RKN.ImageTransparentColor = Color.Magenta;
            toolStripButtonDelete_RKN.Name = "toolStripButtonDelete_RKN";
            toolStripButtonDelete_RKN.Size = new Size(24, 24);
            toolStripButtonDelete_RKN.Text = "Удалить фильм";
            toolStripButtonDelete_RKN.ToolTipText = "Удалить";
            toolStripButtonDelete_RKN.Click += toolStripButtonDelete_RKN_Click;
            // 
            // toolStripSeparator1_RKN
            // 
            toolStripSeparator1_RKN.Name = "toolStripSeparator1_RKN";
            toolStripSeparator1_RKN.Size = new Size(6, 27);
            // 
            // toolStripComboBoxSort_RKN
            // 
            toolStripComboBoxSort_RKN.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxSort_RKN.Items.AddRange(new object[] { "По дате добавления", "По алфавиту", "По году выхода" });
            toolStripComboBoxSort_RKN.Name = "toolStripComboBoxSort_RKN";
            toolStripComboBoxSort_RKN.Size = new Size(178, 27);
            toolStripComboBoxSort_RKN.ToolTipText = "Сортировка";
            toolStripComboBoxSort_RKN.SelectedIndexChanged += toolStripComboBoxSort_RKN_SelectedIndexChanged;
            // 
            // toolStripSeparator2_RKN
            // 
            toolStripSeparator2_RKN.Name = "toolStripSeparator2_RKN";
            toolStripSeparator2_RKN.Size = new Size(6, 27);
            // 
            // toolStripButtonInformation_RKN
            // 
            toolStripButtonInformation_RKN.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonInformation_RKN.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonInformation_RKN.Image = Properties.Resources.info;
            toolStripButtonInformation_RKN.ImageTransparentColor = Color.Magenta;
            toolStripButtonInformation_RKN.Name = "toolStripButtonInformation_RKN";
            toolStripButtonInformation_RKN.Size = new Size(24, 24);
            toolStripButtonInformation_RKN.Text = "Сведенья о программе";
            toolStripButtonInformation_RKN.Click += toolStripButtonHelp_RKN_Click;
            // 
            // toolStripButtonHelp_RKN
            // 
            toolStripButtonHelp_RKN.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonHelp_RKN.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonHelp_RKN.Image = Properties.Resources.Help1;
            toolStripButtonHelp_RKN.ImageTransparentColor = Color.Magenta;
            toolStripButtonHelp_RKN.Name = "toolStripButtonHelp_RKN";
            toolStripButtonHelp_RKN.Size = new Size(24, 24);
            toolStripButtonHelp_RKN.Text = "Руководство";
            toolStripButtonHelp_RKN.ToolTipText = "Руководство";
            toolStripButtonHelp_RKN.Click += toolStripButtonHelp_RKN_Click_1;
            // 
            // toolStripTextBoxSearch_RKN
            // 
            toolStripTextBoxSearch_RKN.ForeColor = SystemColors.AppWorkspace;
            toolStripTextBoxSearch_RKN.Name = "toolStripTextBoxSearch_RKN";
            toolStripTextBoxSearch_RKN.Size = new Size(164, 27);
            toolStripTextBoxSearch_RKN.Text = "Поиск...";
            toolStripTextBoxSearch_RKN.ToolTipText = "Поиск";
            toolStripTextBoxSearch_RKN.Enter += toolStripTextBoxSearch_RKN_Enter;
            toolStripTextBoxSearch_RKN.Leave += toolStripTextBoxSearch_RKN_Leave;
            // 
            // toolStripButtonSearch_RKN
            // 
            toolStripButtonSearch_RKN.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSearch_RKN.Image = Properties.Resources.Search;
            toolStripButtonSearch_RKN.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearch_RKN.Name = "toolStripButtonSearch_RKN";
            toolStripButtonSearch_RKN.Size = new Size(24, 24);
            toolStripButtonSearch_RKN.Text = "Поиск фильма";
            toolStripButtonSearch_RKN.ToolTipText = "Поиск";
            toolStripButtonSearch_RKN.Click += toolStripButtonSearch_RKN_Click_2;
            // 
            // toolStripButtonStat_RKN
            // 
            toolStripButtonStat_RKN.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonStat_RKN.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonStat_RKN.Image = Properties.Resources.stats;
            toolStripButtonStat_RKN.ImageTransparentColor = Color.Magenta;
            toolStripButtonStat_RKN.Name = "toolStripButtonStat_RKN";
            toolStripButtonStat_RKN.Size = new Size(24, 24);
            toolStripButtonStat_RKN.Text = "Статистика по жанрам";
            // 
            // flowLayoutPanelLeft_RKN
            // 
            flowLayoutPanelLeft_RKN.AutoScroll = true;
            flowLayoutPanelLeft_RKN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanelLeft_RKN.BackColor = Color.White;
            flowLayoutPanelLeft_RKN.Dock = DockStyle.Right;
            flowLayoutPanelLeft_RKN.Location = new Point(850, 0);
            flowLayoutPanelLeft_RKN.Margin = new Padding(2);
            flowLayoutPanelLeft_RKN.Name = "flowLayoutPanelLeft_RKN";
            flowLayoutPanelLeft_RKN.Size = new Size(298, 532);
            flowLayoutPanelLeft_RKN.TabIndex = 1;
            // 
            // labelDescriptionText_RKN
            // 
            labelDescriptionText_RKN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDescriptionText_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDescriptionText_RKN.Location = new Point(455, 285);
            labelDescriptionText_RKN.Margin = new Padding(2, 0, 2, 0);
            labelDescriptionText_RKN.Name = "labelDescriptionText_RKN";
            labelDescriptionText_RKN.Size = new Size(367, 28);
            labelDescriptionText_RKN.TabIndex = 17;
            labelDescriptionText_RKN.Text = "-";
            // 
            // labelRatingText_RKN
            // 
            labelRatingText_RKN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelRatingText_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRatingText_RKN.Location = new Point(455, 257);
            labelRatingText_RKN.Margin = new Padding(2, 0, 2, 0);
            labelRatingText_RKN.Name = "labelRatingText_RKN";
            labelRatingText_RKN.Size = new Size(367, 28);
            labelRatingText_RKN.TabIndex = 16;
            labelRatingText_RKN.Text = "-";
            labelRatingText_RKN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCountryText_RKN
            // 
            labelCountryText_RKN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCountryText_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCountryText_RKN.Location = new Point(455, 219);
            labelCountryText_RKN.Margin = new Padding(2, 0, 2, 0);
            labelCountryText_RKN.Name = "labelCountryText_RKN";
            labelCountryText_RKN.Size = new Size(367, 28);
            labelCountryText_RKN.TabIndex = 15;
            labelCountryText_RKN.Text = "-";
            labelCountryText_RKN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelRating_RKN
            // 
            labelRating_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRating_RKN.Location = new Point(288, 247);
            labelRating_RKN.Margin = new Padding(2, 0, 2, 0);
            labelRating_RKN.Name = "labelRating_RKN";
            labelRating_RKN.Size = new Size(150, 28);
            labelRating_RKN.TabIndex = 12;
            labelRating_RKN.Text = "Длительность:";
            labelRating_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelScreenwriter_RKN
            // 
            labelScreenwriter_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelScreenwriter_RKN.Location = new Point(307, 167);
            labelScreenwriter_RKN.Margin = new Padding(2, 0, 2, 0);
            labelScreenwriter_RKN.Name = "labelScreenwriter_RKN";
            labelScreenwriter_RKN.Size = new Size(131, 28);
            labelScreenwriter_RKN.TabIndex = 9;
            labelScreenwriter_RKN.Text = "Стоимость:";
            labelScreenwriter_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCountry_RKN
            // 
            labelCountry_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCountry_RKN.Location = new Point(307, 221);
            labelCountry_RKN.Margin = new Padding(2, 0, 2, 0);
            labelCountry_RKN.Name = "labelCountry_RKN";
            labelCountry_RKN.Size = new Size(131, 28);
            labelCountry_RKN.TabIndex = 11;
            labelCountry_RKN.Text = "Страна:";
            labelCountry_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelRoleText_RKN
            // 
            labelRoleText_RKN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelRoleText_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRoleText_RKN.Location = new Point(455, 195);
            labelRoleText_RKN.Margin = new Padding(2, 0, 2, 0);
            labelRoleText_RKN.Name = "labelRoleText_RKN";
            labelRoleText_RKN.Size = new Size(367, 28);
            labelRoleText_RKN.TabIndex = 14;
            labelRoleText_RKN.Text = "-";
            labelRoleText_RKN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDirector_RKN
            // 
            labelDirector_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDirector_RKN.Location = new Point(307, 139);
            labelDirector_RKN.Margin = new Padding(2, 0, 2, 0);
            labelDirector_RKN.Name = "labelDirector_RKN";
            labelDirector_RKN.Size = new Size(131, 28);
            labelDirector_RKN.TabIndex = 8;
            labelDirector_RKN.Text = "Режиссер:";
            labelDirector_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelRole_RKN
            // 
            labelRole_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRole_RKN.Location = new Point(297, 193);
            labelRole_RKN.Margin = new Padding(2, 0, 2, 0);
            labelRole_RKN.Name = "labelRole_RKN";
            labelRole_RKN.Size = new Size(141, 28);
            labelRole_RKN.TabIndex = 10;
            labelRole_RKN.Text = "ФИО актёров:";
            labelRole_RKN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelScreenwriterText_RKN
            // 
            labelScreenwriterText_RKN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelScreenwriterText_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelScreenwriterText_RKN.Location = new Point(455, 167);
            labelScreenwriterText_RKN.Margin = new Padding(2, 0, 2, 0);
            labelScreenwriterText_RKN.Name = "labelScreenwriterText_RKN";
            labelScreenwriterText_RKN.Size = new Size(367, 28);
            labelScreenwriterText_RKN.TabIndex = 13;
            labelScreenwriterText_RKN.Text = "-";
            labelScreenwriterText_RKN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxPreview_RKN
            // 
            pictureBoxPreview_RKN.BackColor = Color.FromArgb(255, 224, 192);
            pictureBoxPreview_RKN.Image = (Image)resources.GetObject("pictureBoxPreview_RKN.Image");
            pictureBoxPreview_RKN.Location = new Point(29, 58);
            pictureBoxPreview_RKN.Margin = new Padding(2);
            pictureBoxPreview_RKN.Name = "pictureBoxPreview_RKN";
            pictureBoxPreview_RKN.Size = new Size(233, 340);
            pictureBoxPreview_RKN.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPreview_RKN.TabIndex = 2;
            pictureBoxPreview_RKN.TabStop = false;
            // 
            // labelGenre_RKN
            // 
            labelGenre_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGenre_RKN.Location = new Point(272, 111);
            labelGenre_RKN.Margin = new Padding(2, 0, 2, 0);
            labelGenre_RKN.Name = "labelGenre_RKN";
            labelGenre_RKN.Size = new Size(166, 28);
            labelGenre_RKN.TabIndex = 7;
            labelGenre_RKN.Text = "Направленность:";
            labelGenre_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelYear_RKN
            // 
            labelYear_RKN.AutoSize = true;
            labelYear_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelYear_RKN.Location = new Point(29, 409);
            labelYear_RKN.Margin = new Padding(2, 0, 2, 0);
            labelYear_RKN.Name = "labelYear_RKN";
            labelYear_RKN.Size = new Size(127, 24);
            labelYear_RKN.TabIndex = 6;
            labelYear_RKN.Text = "Дата записи:";
            // 
            // labelDirectorText_RKN
            // 
            labelDirectorText_RKN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDirectorText_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDirectorText_RKN.Location = new Point(455, 139);
            labelDirectorText_RKN.Margin = new Padding(2, 0, 2, 0);
            labelDirectorText_RKN.Name = "labelDirectorText_RKN";
            labelDirectorText_RKN.Size = new Size(367, 28);
            labelDirectorText_RKN.TabIndex = 12;
            labelDirectorText_RKN.Text = "-";
            labelDirectorText_RKN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDescription_RKN
            // 
            labelDescription_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDescription_RKN.Location = new Point(307, 275);
            labelDescription_RKN.Margin = new Padding(2, 0, 2, 0);
            labelDescription_RKN.Name = "labelDescription_RKN";
            labelDescription_RKN.Size = new Size(131, 28);
            labelDescription_RKN.TabIndex = 13;
            labelDescription_RKN.Text = "Описание:";
            labelDescription_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelGenreText_RKN
            // 
            labelGenreText_RKN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelGenreText_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGenreText_RKN.Location = new Point(455, 111);
            labelGenreText_RKN.Margin = new Padding(2, 0, 2, 0);
            labelGenreText_RKN.Name = "labelGenreText_RKN";
            labelGenreText_RKN.Size = new Size(367, 28);
            labelGenreText_RKN.TabIndex = 11;
            labelGenreText_RKN.Text = "-";
            labelGenreText_RKN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelYearText_RKN
            // 
            labelYearText_RKN.AutoSize = true;
            labelYearText_RKN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelYearText_RKN.Location = new Point(160, 409);
            labelYearText_RKN.Margin = new Padding(2, 0, 2, 0);
            labelYearText_RKN.Name = "labelYearText_RKN";
            labelYearText_RKN.Size = new Size(16, 24);
            labelYearText_RKN.TabIndex = 10;
            labelYearText_RKN.Text = "-";
            // 
            // labelName_RKN
            // 
            labelName_RKN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelName_RKN.AutoEllipsis = true;
            labelName_RKN.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName_RKN.Location = new Point(260, 10);
            labelName_RKN.Margin = new Padding(2, 0, 2, 0);
            labelName_RKN.Name = "labelName_RKN";
            labelName_RKN.Size = new Size(542, 46);
            labelName_RKN.TabIndex = 5;
            labelName_RKN.Text = "Выберите видеоклип";
            labelName_RKN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain_RKN
            // 
            panelMain_RKN.AutoScroll = true;
            panelMain_RKN.BackColor = Color.FromArgb(224, 224, 224);
            panelMain_RKN.Controls.Add(labelName_RKN);
            panelMain_RKN.Controls.Add(labelYearText_RKN);
            panelMain_RKN.Controls.Add(labelGenreText_RKN);
            panelMain_RKN.Controls.Add(labelDescription_RKN);
            panelMain_RKN.Controls.Add(labelDirectorText_RKN);
            panelMain_RKN.Controls.Add(labelYear_RKN);
            panelMain_RKN.Controls.Add(labelGenre_RKN);
            panelMain_RKN.Controls.Add(pictureBoxPreview_RKN);
            panelMain_RKN.Controls.Add(labelScreenwriterText_RKN);
            panelMain_RKN.Controls.Add(labelRole_RKN);
            panelMain_RKN.Controls.Add(labelDirector_RKN);
            panelMain_RKN.Controls.Add(labelRoleText_RKN);
            panelMain_RKN.Controls.Add(labelCountry_RKN);
            panelMain_RKN.Controls.Add(labelScreenwriter_RKN);
            panelMain_RKN.Controls.Add(labelRating_RKN);
            panelMain_RKN.Controls.Add(labelCountryText_RKN);
            panelMain_RKN.Controls.Add(labelRatingText_RKN);
            panelMain_RKN.Controls.Add(labelDescriptionText_RKN);
            panelMain_RKN.Dock = DockStyle.Fill;
            panelMain_RKN.Location = new Point(0, 27);
            panelMain_RKN.Margin = new Padding(4, 3, 4, 3);
            panelMain_RKN.Name = "panelMain_RKN";
            panelMain_RKN.Size = new Size(850, 505);
            panelMain_RKN.TabIndex = 18;
            panelMain_RKN.Paint += panelMain_RKN_Paint;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 532);
            Controls.Add(panelMain_RKN);
            Controls.Add(toolStripMenu_RKN);
            Controls.Add(flowLayoutPanelLeft_RKN);
            Margin = new Padding(2);
            MinimumSize = new Size(1164, 571);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Проект | Вариант 9 | Рауш К.Н.";
            Resize += FormMain_Resize;
            toolStripMenu_RKN.ResumeLayout(false);
            toolStripMenu_RKN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview_RKN).EndInit();
            panelMain_RKN.ResumeLayout(false);
            panelMain_RKN.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu_RKN;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd_RKN;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete_RKN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1_RKN;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch_RKN;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch_RKN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2_RKN;
        private System.Windows.Forms.ToolStripButton toolStripButtonInformation_RKN;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp_RKN;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSort_RKN;
        private ToolTip toolTip_RKN;
        private ToolStripButton toolStripButtonStat_RKN;
        private Label labelDescriptionText_RKN;
        private Label labelRatingText_RKN;
        private Label labelCountryText_RKN;
        private Label labelRating_RKN;
        private Label labelScreenwriter_RKN;
        private Label labelCountry_RKN;
        private Label labelRoleText_RKN;
        private Label labelDirector_RKN;
        private Label labelRole_RKN;
        private Label labelScreenwriterText_RKN;
        private PictureBox pictureBoxPreview_RKN;
        private Label labelGenre_RKN;
        private Label labelYear_RKN;
        private Label labelDirectorText_RKN;
        private Label labelDescription_RKN;
        private Label labelGenreText_RKN;
        private Label labelYearText_RKN;
        private Label labelName_RKN;
        private Panel panelMain_RKN;
        public FlowLayoutPanel flowLayoutPanelLeft_RKN;
    }
}
