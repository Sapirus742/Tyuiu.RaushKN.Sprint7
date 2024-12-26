namespace Tyuiu.RaushKN.Sprint7.Project.V9
{
    partial class FormAddFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddFilm));
            textBoxName_RKN = new TextBox();
            textBoxRole_RKN = new TextBox();
            textBoxYear_RKN = new TextBox();
            textBoxDescription_RKN = new TextBox();
            textBoxDirector_RKN = new TextBox();
            textBoxScreenwriter_RKN = new TextBox();
            textBoxRating_RKN = new TextBox();
            textBoxCountry_RKN = new TextBox();
            buttonAdd_RKN = new Button();
            openFileDialogImage_RKN = new OpenFileDialog();
            labelName_RKN = new Label();
            labelYear_RKN = new Label();
            labelGenre_RKN = new Label();
            labelDirector_RKN = new Label();
            labelScreenwriter_RKN = new Label();
            labelCountry_RKN = new Label();
            labelRating_RKN = new Label();
            labelRole_RKN = new Label();
            labelDescription_RKN = new Label();
            comboBoxGenre_RKN = new ComboBox();
            pictureBoxPreview_RKN = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview_RKN).BeginInit();
            SuspendLayout();
            // 
            // textBoxName_RKN
            // 
            textBoxName_RKN.Location = new Point(356, 41);
            textBoxName_RKN.Margin = new Padding(2);
            textBoxName_RKN.Name = "textBoxName_RKN";
            textBoxName_RKN.Size = new Size(258, 23);
            textBoxName_RKN.TabIndex = 0;
            // 
            // textBoxRole_RKN
            // 
            textBoxRole_RKN.Location = new Point(367, 243);
            textBoxRole_RKN.Margin = new Padding(2);
            textBoxRole_RKN.Name = "textBoxRole_RKN";
            textBoxRole_RKN.Size = new Size(247, 23);
            textBoxRole_RKN.TabIndex = 1;
            // 
            // textBoxYear_RKN
            // 
            textBoxYear_RKN.Location = new Point(143, 359);
            textBoxYear_RKN.Margin = new Padding(2);
            textBoxYear_RKN.Name = "textBoxYear_RKN";
            textBoxYear_RKN.Size = new Size(72, 23);
            textBoxYear_RKN.TabIndex = 2;
            // 
            // textBoxDescription_RKN
            // 
            textBoxDescription_RKN.Location = new Point(356, 281);
            textBoxDescription_RKN.Margin = new Padding(2);
            textBoxDescription_RKN.Name = "textBoxDescription_RKN";
            textBoxDescription_RKN.Size = new Size(258, 23);
            textBoxDescription_RKN.TabIndex = 3;
            // 
            // textBoxDirector_RKN
            // 
            textBoxDirector_RKN.Location = new Point(356, 119);
            textBoxDirector_RKN.Margin = new Padding(2);
            textBoxDirector_RKN.Name = "textBoxDirector_RKN";
            textBoxDirector_RKN.Size = new Size(258, 23);
            textBoxDirector_RKN.TabIndex = 4;
            // 
            // textBoxScreenwriter_RKN
            // 
            textBoxScreenwriter_RKN.Location = new Point(356, 158);
            textBoxScreenwriter_RKN.Margin = new Padding(2);
            textBoxScreenwriter_RKN.Name = "textBoxScreenwriter_RKN";
            textBoxScreenwriter_RKN.Size = new Size(258, 23);
            textBoxScreenwriter_RKN.TabIndex = 6;
            // 
            // textBoxRating_RKN
            // 
            textBoxRating_RKN.Location = new Point(540, 200);
            textBoxRating_RKN.Margin = new Padding(2);
            textBoxRating_RKN.Name = "textBoxRating_RKN";
            textBoxRating_RKN.Size = new Size(88, 23);
            textBoxRating_RKN.TabIndex = 7;
            // 
            // textBoxCountry_RKN
            // 
            textBoxCountry_RKN.Location = new Point(352, 200);
            textBoxCountry_RKN.Margin = new Padding(2);
            textBoxCountry_RKN.Name = "textBoxCountry_RKN";
            textBoxCountry_RKN.Size = new Size(87, 23);
            textBoxCountry_RKN.TabIndex = 8;
            // 
            // buttonAdd_RKN
            // 
            buttonAdd_RKN.Cursor = Cursors.Hand;
            buttonAdd_RKN.Location = new Point(356, 325);
            buttonAdd_RKN.Margin = new Padding(2);
            buttonAdd_RKN.Name = "buttonAdd_RKN";
            buttonAdd_RKN.Size = new Size(258, 37);
            buttonAdd_RKN.TabIndex = 9;
            buttonAdd_RKN.Text = "Добавить";
            buttonAdd_RKN.UseVisualStyleBackColor = true;
            buttonAdd_RKN.Click += buttonAdd_RKN_Click;
            // 
            // openFileDialogImage_RKN
            // 
            openFileDialogImage_RKN.FileName = "openFileDialog1";
            openFileDialogImage_RKN.Filter = "Изображение|*.JPG;*.PNG;";
            // 
            // labelName_RKN
            // 
            labelName_RKN.Location = new Point(273, 40);
            labelName_RKN.Margin = new Padding(2, 0, 2, 0);
            labelName_RKN.Name = "labelName_RKN";
            labelName_RKN.Size = new Size(77, 22);
            labelName_RKN.TabIndex = 12;
            labelName_RKN.Text = "Название:";
            labelName_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelYear_RKN
            // 
            labelYear_RKN.Location = new Point(40, 360);
            labelYear_RKN.Margin = new Padding(2, 0, 2, 0);
            labelYear_RKN.Name = "labelYear_RKN";
            labelYear_RKN.Size = new Size(101, 22);
            labelYear_RKN.TabIndex = 13;
            labelYear_RKN.Text = "Год создания:";
            labelYear_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelGenre_RKN
            // 
            labelGenre_RKN.Location = new Point(250, 78);
            labelGenre_RKN.Margin = new Padding(2, 0, 2, 0);
            labelGenre_RKN.Name = "labelGenre_RKN";
            labelGenre_RKN.Size = new Size(102, 22);
            labelGenre_RKN.TabIndex = 14;
            labelGenre_RKN.Text = "Тема:";
            labelGenre_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDirector_RKN
            // 
            labelDirector_RKN.Location = new Point(275, 118);
            labelDirector_RKN.Margin = new Padding(2, 0, 2, 0);
            labelDirector_RKN.Name = "labelDirector_RKN";
            labelDirector_RKN.Size = new Size(77, 22);
            labelDirector_RKN.TabIndex = 15;
            labelDirector_RKN.Text = "Режессёр:";
            labelDirector_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelScreenwriter_RKN
            // 
            labelScreenwriter_RKN.Location = new Point(275, 157);
            labelScreenwriter_RKN.Margin = new Padding(2, 0, 2, 0);
            labelScreenwriter_RKN.Name = "labelScreenwriter_RKN";
            labelScreenwriter_RKN.Size = new Size(77, 22);
            labelScreenwriter_RKN.TabIndex = 16;
            labelScreenwriter_RKN.Text = "Стоимость:";
            labelScreenwriter_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCountry_RKN
            // 
            labelCountry_RKN.Location = new Point(284, 199);
            labelCountry_RKN.Margin = new Padding(2, 0, 2, 0);
            labelCountry_RKN.Name = "labelCountry_RKN";
            labelCountry_RKN.Size = new Size(64, 22);
            labelCountry_RKN.TabIndex = 17;
            labelCountry_RKN.Text = "Страна:";
            labelCountry_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelRating_RKN
            // 
            labelRating_RKN.Location = new Point(443, 201);
            labelRating_RKN.Margin = new Padding(2, 0, 2, 0);
            labelRating_RKN.Name = "labelRating_RKN";
            labelRating_RKN.Size = new Size(88, 22);
            labelRating_RKN.TabIndex = 18;
            labelRating_RKN.Text = "Длительность:";
            labelRating_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelRole_RKN
            // 
            labelRole_RKN.Location = new Point(276, 242);
            labelRole_RKN.Margin = new Padding(2, 0, 2, 0);
            labelRole_RKN.Name = "labelRole_RKN";
            labelRole_RKN.Size = new Size(87, 22);
            labelRole_RKN.TabIndex = 19;
            labelRole_RKN.Text = "ФИО актёров:";
            labelRole_RKN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDescription_RKN
            // 
            labelDescription_RKN.Location = new Point(273, 281);
            labelDescription_RKN.Margin = new Padding(2, 0, 2, 0);
            labelDescription_RKN.Name = "labelDescription_RKN";
            labelDescription_RKN.Size = new Size(77, 22);
            labelDescription_RKN.TabIndex = 20;
            labelDescription_RKN.Text = "Описание:";
            labelDescription_RKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxGenre_RKN
            // 
            comboBoxGenre_RKN.DisplayMember = "0";
            comboBoxGenre_RKN.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenre_RKN.FormattingEnabled = true;
            comboBoxGenre_RKN.Items.AddRange(new object[] { "Боевик", "Комедия", "Мюзикл", "Фантастика", "Хоррор", "Реклама", "Благотворительность", "Романтика" });
            comboBoxGenre_RKN.Location = new Point(356, 79);
            comboBoxGenre_RKN.Margin = new Padding(2);
            comboBoxGenre_RKN.Name = "comboBoxGenre_RKN";
            comboBoxGenre_RKN.Size = new Size(146, 23);
            comboBoxGenre_RKN.TabIndex = 22;
            comboBoxGenre_RKN.SelectedIndexChanged += comboBoxGenre_RKN_SelectedIndexChanged;
            // 
            // pictureBoxPreview_RKN
            // 
            pictureBoxPreview_RKN.BackColor = SystemColors.ButtonShadow;
            pictureBoxPreview_RKN.Cursor = Cursors.Hand;
            pictureBoxPreview_RKN.Image = (Image)resources.GetObject("pictureBoxPreview_RKN.Image");
            pictureBoxPreview_RKN.Location = new Point(11, 15);
            pictureBoxPreview_RKN.Margin = new Padding(2);
            pictureBoxPreview_RKN.Name = "pictureBoxPreview_RKN";
            pictureBoxPreview_RKN.Size = new Size(258, 336);
            pictureBoxPreview_RKN.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPreview_RKN.TabIndex = 11;
            pictureBoxPreview_RKN.TabStop = false;
            pictureBoxPreview_RKN.Click += pictureBox1_Click;
            // 
            // FormAddFilm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 391);
            Controls.Add(comboBoxGenre_RKN);
            Controls.Add(labelDescription_RKN);
            Controls.Add(labelRole_RKN);
            Controls.Add(labelCountry_RKN);
            Controls.Add(labelScreenwriter_RKN);
            Controls.Add(labelDirector_RKN);
            Controls.Add(labelYear_RKN);
            Controls.Add(labelName_RKN);
            Controls.Add(pictureBoxPreview_RKN);
            Controls.Add(buttonAdd_RKN);
            Controls.Add(textBoxCountry_RKN);
            Controls.Add(textBoxRating_RKN);
            Controls.Add(textBoxScreenwriter_RKN);
            Controls.Add(textBoxDirector_RKN);
            Controls.Add(textBoxDescription_RKN);
            Controls.Add(textBoxYear_RKN);
            Controls.Add(textBoxRole_RKN);
            Controls.Add(textBoxName_RKN);
            Controls.Add(labelGenre_RKN);
            Controls.Add(labelRating_RKN);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddFilm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить новый видеоклип";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview_RKN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxName_RKN;
        private System.Windows.Forms.TextBox textBoxRole_RKN;
        private System.Windows.Forms.TextBox textBoxYear_RKN;
        private System.Windows.Forms.TextBox textBoxDescription_RKN;
        private System.Windows.Forms.TextBox textBoxDirector_RKN;
        private System.Windows.Forms.TextBox textBoxScreenwriter_RKN;
        private System.Windows.Forms.TextBox textBoxRating_RKN;
        private System.Windows.Forms.TextBox textBoxCountry_RKN;
        private System.Windows.Forms.Button buttonAdd_RKN;
        private System.Windows.Forms.PictureBox pictureBoxPreview_RKN;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage_RKN;
        private System.Windows.Forms.Label labelName_RKN;
        private System.Windows.Forms.Label labelYear_RKN;
        private System.Windows.Forms.Label labelGenre_RKN;
        private System.Windows.Forms.Label labelDirector_RKN;
        private System.Windows.Forms.Label labelScreenwriter_RKN;
        private System.Windows.Forms.Label labelCountry_RKN;
        private System.Windows.Forms.Label labelRating_RKN;
        private System.Windows.Forms.Label labelRole_RKN;
        private System.Windows.Forms.Label labelDescription_RKN;
        private System.Windows.Forms.ComboBox comboBoxGenre_RKN;
    }
}
#endregion