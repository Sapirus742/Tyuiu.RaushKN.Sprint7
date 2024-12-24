namespace Tyuiu.RaushKN.Sprint7.Project.V9
{
    partial class FormInformatoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformatoin));
            label1 = new Label();
            buttonOK_RKN = new Button();
            pictureBoxAvatar_RKN = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_RKN).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 25);
            label1.Name = "label1";
            label1.Size = new Size(302, 150);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // buttonOK_RKN
            // 
            buttonOK_RKN.Cursor = Cursors.Hand;
            buttonOK_RKN.Location = new Point(415, 193);
            buttonOK_RKN.Name = "buttonOK_RKN";
            buttonOK_RKN.Size = new Size(80, 29);
            buttonOK_RKN.TabIndex = 2;
            buttonOK_RKN.Text = "OK";
            buttonOK_RKN.UseVisualStyleBackColor = true;
            buttonOK_RKN.Click += buttonOK_RKN_Click;
            // 
            // pictureBoxAvatar_RKN
            // 
            pictureBoxAvatar_RKN.Image = Properties.Resources.photo;
            pictureBoxAvatar_RKN.Location = new Point(12, 25);
            pictureBoxAvatar_RKN.Name = "pictureBoxAvatar_RKN";
            pictureBoxAvatar_RKN.Size = new Size(145, 141);
            pictureBoxAvatar_RKN.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_RKN.TabIndex = 1;
            pictureBoxAvatar_RKN.TabStop = false;
            // 
            // FormInformatoin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 233);
            Controls.Add(buttonOK_RKN);
            Controls.Add(pictureBoxAvatar_RKN);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInformatoin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_RKN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_RKN;
        private System.Windows.Forms.Button buttonOK_RKN;
    }
}