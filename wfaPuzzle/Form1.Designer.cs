
namespace wfaPuzzle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPictures = new System.Windows.Forms.TabPage();
            this.buBackPic = new System.Windows.Forms.Button();
            this.flpPictures = new System.Windows.Forms.FlowLayoutPanel();
            this.cbNumDetails = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buOk = new System.Windows.Forms.Button();
            this.buAddPic = new System.Windows.Forms.Button();
            this.tpField = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buNewPuzzle = new System.Windows.Forms.Button();
            this.tlpField = new System.Windows.Forms.TableLayoutPanel();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.buBackField = new System.Windows.Forms.Button();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buProgram = new System.Windows.Forms.Button();
            this.buExit = new System.Windows.Forms.Button();
            this.buGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpProgram = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.buBackProg = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpPictures.SuspendLayout();
            this.tpField.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tpPictures);
            this.tabControl1.Controls.Add(this.tpField);
            this.tabControl1.Controls.Add(this.tpMain);
            this.tabControl1.Controls.Add(this.tpProgram);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 409);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tpPictures
            // 
            this.tpPictures.BackColor = System.Drawing.Color.LavenderBlush;
            this.tpPictures.Controls.Add(this.buBackPic);
            this.tpPictures.Controls.Add(this.flpPictures);
            this.tpPictures.Controls.Add(this.cbNumDetails);
            this.tpPictures.Controls.Add(this.label1);
            this.tpPictures.Controls.Add(this.buOk);
            this.tpPictures.Controls.Add(this.buAddPic);
            this.tpPictures.Location = new System.Drawing.Point(4, 5);
            this.tpPictures.Name = "tpPictures";
            this.tpPictures.Padding = new System.Windows.Forms.Padding(3);
            this.tpPictures.Size = new System.Drawing.Size(650, 400);
            this.tpPictures.TabIndex = 0;
            this.tpPictures.Text = "Картинки";
            // 
            // buBackPic
            // 
            this.buBackPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buBackPic.BackColor = System.Drawing.Color.Pink;
            this.buBackPic.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buBackPic.FlatAppearance.BorderSize = 2;
            this.buBackPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buBackPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buBackPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buBackPic.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buBackPic.Location = new System.Drawing.Point(6, 348);
            this.buBackPic.Name = "buBackPic";
            this.buBackPic.Size = new System.Drawing.Size(74, 45);
            this.buBackPic.TabIndex = 5;
            this.buBackPic.Text = "⟵";
            this.buBackPic.UseVisualStyleBackColor = false;
            // 
            // flpPictures
            // 
            this.flpPictures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpPictures.AutoScroll = true;
            this.flpPictures.BackColor = System.Drawing.Color.LavenderBlush;
            this.flpPictures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpPictures.Location = new System.Drawing.Point(3, 3);
            this.flpPictures.Name = "flpPictures";
            this.flpPictures.Size = new System.Drawing.Size(644, 340);
            this.flpPictures.TabIndex = 4;
            // 
            // cbNumDetails
            // 
            this.cbNumDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbNumDetails.BackColor = System.Drawing.Color.White;
            this.cbNumDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNumDetails.FormattingEnabled = true;
            this.cbNumDetails.Location = new System.Drawing.Point(456, 359);
            this.cbNumDetails.Name = "cbNumDetails";
            this.cbNumDetails.Size = new System.Drawing.Size(67, 31);
            this.cbNumDetails.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во деталей:";
            // 
            // buOk
            // 
            this.buOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buOk.BackColor = System.Drawing.Color.Pink;
            this.buOk.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buOk.FlatAppearance.BorderSize = 2;
            this.buOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buOk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buOk.Location = new System.Drawing.Point(529, 349);
            this.buOk.Name = "buOk";
            this.buOk.Size = new System.Drawing.Size(115, 45);
            this.buOk.TabIndex = 1;
            this.buOk.Text = "ОК";
            this.buOk.UseVisualStyleBackColor = false;
            // 
            // buAddPic
            // 
            this.buAddPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buAddPic.BackColor = System.Drawing.Color.Pink;
            this.buAddPic.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buAddPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buAddPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buAddPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buAddPic.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buAddPic.Location = new System.Drawing.Point(86, 349);
            this.buAddPic.Name = "buAddPic";
            this.buAddPic.Size = new System.Drawing.Size(186, 45);
            this.buAddPic.TabIndex = 0;
            this.buAddPic.Text = "Добавить картинку";
            this.buAddPic.UseVisualStyleBackColor = false;
            // 
            // tpField
            // 
            this.tpField.Controls.Add(this.tableLayoutPanel1);
            this.tpField.Location = new System.Drawing.Point(4, 5);
            this.tpField.Name = "tpField";
            this.tpField.Padding = new System.Windows.Forms.Padding(3);
            this.tpField.Size = new System.Drawing.Size(650, 400);
            this.tpField.TabIndex = 1;
            this.tpField.Text = "Поле";
            this.tpField.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buNewPuzzle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tlpField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbDetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buBackField, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 394);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // buNewPuzzle
            // 
            this.buNewPuzzle.BackColor = System.Drawing.Color.Pink;
            this.buNewPuzzle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buNewPuzzle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buNewPuzzle.FlatAppearance.BorderSize = 2;
            this.buNewPuzzle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buNewPuzzle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buNewPuzzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buNewPuzzle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buNewPuzzle.Location = new System.Drawing.Point(3, 351);
            this.buNewPuzzle.Name = "buNewPuzzle";
            this.buNewPuzzle.Size = new System.Drawing.Size(316, 40);
            this.buNewPuzzle.TabIndex = 1;
            this.buNewPuzzle.Text = "Начать с начала";
            this.buNewPuzzle.UseVisualStyleBackColor = false;
            // 
            // tlpField
            // 
            this.tlpField.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpField.ColumnCount = 1;
            this.tlpField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpField.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpField.Location = new System.Drawing.Point(325, 3);
            this.tlpField.Name = "tlpField";
            this.tlpField.RowCount = 1;
            this.tlpField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpField.Size = new System.Drawing.Size(316, 318);
            this.tlpField.TabIndex = 2;
            // 
            // gbDetails
            // 
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetails.Location = new System.Drawing.Point(3, 3);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(316, 342);
            this.gbDetails.TabIndex = 0;
            this.gbDetails.TabStop = false;
            // 
            // buBackField
            // 
            this.buBackField.BackColor = System.Drawing.Color.Pink;
            this.buBackField.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buBackField.FlatAppearance.BorderSize = 2;
            this.buBackField.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buBackField.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buBackField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buBackField.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buBackField.Location = new System.Drawing.Point(325, 351);
            this.buBackField.Name = "buBackField";
            this.buBackField.Size = new System.Drawing.Size(120, 40);
            this.buBackField.TabIndex = 3;
            this.buBackField.Text = "На главную";
            this.buBackField.UseVisualStyleBackColor = false;
            // 
            // tpMain
            // 
            this.tpMain.BackColor = System.Drawing.Color.LavenderBlush;
            this.tpMain.BackgroundImage = global::wfaPuzzle.Properties.Resources.back;
            this.tpMain.Controls.Add(this.tableLayoutPanel2);
            this.tpMain.Location = new System.Drawing.Point(4, 5);
            this.tpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tpMain.Name = "tpMain";
            this.tpMain.Size = new System.Drawing.Size(650, 400);
            this.tpMain.TabIndex = 2;
            this.tpMain.Text = "Главная";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::wfaPuzzle.Properties.Resources.back;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buProgram, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buExit, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.buGame, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(650, 400);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buProgram
            // 
            this.buProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buProgram.BackColor = System.Drawing.Color.Pink;
            this.buProgram.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buProgram.FlatAppearance.BorderSize = 2;
            this.buProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buProgram.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buProgram.Location = new System.Drawing.Point(170, 243);
            this.buProgram.Name = "buProgram";
            this.buProgram.Size = new System.Drawing.Size(309, 54);
            this.buProgram.TabIndex = 1;
            this.buProgram.Text = "О программе";
            this.buProgram.UseVisualStyleBackColor = false;
            // 
            // buExit
            // 
            this.buExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buExit.BackColor = System.Drawing.Color.Pink;
            this.buExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buExit.FlatAppearance.BorderSize = 2;
            this.buExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buExit.Location = new System.Drawing.Point(171, 303);
            this.buExit.Name = "buExit";
            this.buExit.Size = new System.Drawing.Size(307, 54);
            this.buExit.TabIndex = 2;
            this.buExit.Text = "Выход";
            this.buExit.UseVisualStyleBackColor = false;
            // 
            // buGame
            // 
            this.buGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buGame.BackColor = System.Drawing.Color.Pink;
            this.buGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buGame.FlatAppearance.BorderSize = 2;
            this.buGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buGame.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buGame.Location = new System.Drawing.Point(170, 183);
            this.buGame.Name = "buGame";
            this.buGame.Size = new System.Drawing.Size(309, 54);
            this.buGame.TabIndex = 0;
            this.buGame.Text = "Играть";
            this.buGame.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::wfaPuzzle.Properties.Resources.text;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 154);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tpProgram
            // 
            this.tpProgram.BackColor = System.Drawing.Color.LavenderBlush;
            this.tpProgram.Controls.Add(this.label2);
            this.tpProgram.Controls.Add(this.buBackProg);
            this.tpProgram.Location = new System.Drawing.Point(4, 5);
            this.tpProgram.Name = "tpProgram";
            this.tpProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tpProgram.Size = new System.Drawing.Size(650, 400);
            this.tpProgram.TabIndex = 3;
            this.tpProgram.Text = "О программе";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 335);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // buBackProg
            // 
            this.buBackProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buBackProg.BackColor = System.Drawing.Color.Pink;
            this.buBackProg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buBackProg.FlatAppearance.BorderSize = 2;
            this.buBackProg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buBackProg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buBackProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buBackProg.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buBackProg.Location = new System.Drawing.Point(6, 348);
            this.buBackProg.Name = "buBackProg";
            this.buBackProg.Size = new System.Drawing.Size(97, 46);
            this.buBackProg.TabIndex = 0;
            this.buBackProg.Text = "⟵";
            this.buBackProg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buBackProg.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::wfaPuzzle.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(682, 433);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "Form1";
            this.Text = "wfaPuzzle";
            this.tabControl1.ResumeLayout(false);
            this.tpPictures.ResumeLayout(false);
            this.tpPictures.PerformLayout();
            this.tpField.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpProgram.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPictures;
        private System.Windows.Forms.ComboBox cbNumDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buOk;
        private System.Windows.Forms.Button buAddPic;
        private System.Windows.Forms.TabPage tpField;
        private System.Windows.Forms.FlowLayoutPanel flpPictures;
        private System.Windows.Forms.TableLayoutPanel tlpField;
        private System.Windows.Forms.Button buNewPuzzle;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buProgram;
        private System.Windows.Forms.Button buExit;
        private System.Windows.Forms.Button buGame;
        private System.Windows.Forms.TabPage tpProgram;
        private System.Windows.Forms.Button buBackProg;
        private System.Windows.Forms.Button buBackPic;
        private System.Windows.Forms.Button buBackField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

