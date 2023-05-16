using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaPuzzle
{
    public partial class Form1 : Form
    {
        private Game g;
        private FmWin FmWin;

        public PictureBox[] allPictures;
        public PictureBox[,] Details;
        Random rand = new Random();
        public int numDetail = 1;
        public Point startPoint;
        public Point[,] cellLocation;
        public int deltax = 50;
        public int deltay = 50;
        public Bitmap newBmp;


        public Form1()
        {
            InitializeComponent();

            cbNumDetails.Items.Add("4");
            cbNumDetails.Items.Add("9");
            cbNumDetails.Items.Add("16");
            cbNumDetails.Items.Add("25");
            cbNumDetails.SelectedIndex = 0;

            tabControl1.SelectedTab = tpMain;

            g = new Game();
            g.DoReset();
            g.Picture = Properties.Resources._1;

            allPictures = new PictureBox[g.CountResources];

            CreatePbAllPictures();

            buOk.Click += BuOk_Click;
            buNewPuzzle.Click += BuNewPuzzle_Click;
            tpPictures.Enter += TabPage1_Enter;
            buAddPic.Click += BuAddPic_Click;
            this.Resize += Form1_Resize;

            buGame.Click += (s, e) => tabControl1.SelectTab(tpPictures);
            buProgram.Click += (s, e) => tabControl1.SelectTab(tpProgram);
            buExit.Click += (s, e) => Close();
            buBackField.Click += (s, e) => tabControl1.SelectTab(tpMain);
            buBackPic.Click += (s, e) => tabControl1.SelectTab(tpMain);
            buBackProg.Click += (s, e) => tabControl1.SelectTab(tpMain);

            FmWin = new FmWin(tabControl1, tpPictures);
        }
        
        /// <summary>
        /// Перерисовка поля и деталей под размер формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object? sender, EventArgs e)
        {
            if (tlpField.Width > tlpField.Height)
            {
                tlpField.Height = tableLayoutPanel1.Height;
                tlpField.Width = tlpField.Height;
            } else
            {
                tlpField.Width = tableLayoutPanel1.Width/2;
                tlpField.Height = tlpField.Width;
            }
            deltax = Convert.ToInt32(0.5 * tlpField.Width / tlpField.RowCount);
            deltay = Convert.ToInt32(0.5 * tlpField.Height / tlpField.ColumnCount);
            cellLocation = new Point[g.SizePic, g.SizePic];
            for (int row = 0; row < g.SizePic; row++)
            {
                for (int col = 0; col < g.SizePic; col++)
                {
                    cellLocation[row, col].X = tlpField.Location.X + tlpField.Width / tlpField.ColumnCount * col;
                    cellLocation[row, col].Y = tlpField.Location.Y + tlpField.Height / tlpField.RowCount * row;
                }
            }
            for (int i = 0; i < g.SizePic; i++)
            {
                for (int j = 0; j < g.SizePic; j++)
                {
                    if (tlpField.Width / tlpField.ColumnCount <= tlpField.Height / tlpField.RowCount)
                    {
                        Details[i, j].Width = tlpField.Width / tlpField.ColumnCount;
                        Details[i, j].Height = tlpField.Width / tlpField.ColumnCount;
                    }
                    else
                    {
                        Details[i, j].Width = tlpField.Height / tlpField.RowCount;
                        Details[i, j].Height = tlpField.Height / tlpField.RowCount;
                    }

                }
            }
        }
        
        /// <summary>
        /// Добавление картинки с компьютера в ресурсы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuAddPic_Click(object? sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                newBmp = new Bitmap(dialog.FileName);
                
                g.Picture = newBmp;
                SaveFileDialog sdialog = new SaveFileDialog();
                sdialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
                sdialog.FileName = @"../../../Resources/" + (g.CountResources + 1).ToString() + ".jpg";
                newBmp.Save(sdialog.FileName);

            }
        }
        
        /// <summary>
        /// удаление и добавление картинок из ресурсов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabPage1_Enter(object? sender, EventArgs e)
        {
            for (int i = 0; i < g.CountResources; i++)
            {
                flpPictures.Controls.Remove(allPictures[i]);
            }
            for (int i = 0; i < g.SizePic; i++)
            {
                allPictures[i].Dispose();
                allPictures[i].Image = null;
            }
            for (int i = 0; i < g.SizePic; i++)
            {
                for (int j = 0; j < g.SizePic; j++)
                {
                    Details[i, j].Dispose();
                    Details[i, j].Image = null;
                }
            }
            numDetail = 1;
            g.DoReset();
            allPictures = new PictureBox[g.CountResources];
            g.Picture = Properties.Resources._1;
            CreatePbAllPictures();
            allPictures[0].BorderStyle = BorderStyle.Fixed3D;
        }
        
        /// <summary>
        /// Создание массива PictureBox'ов из картинок
        /// </summary>
        private void CreatePbAllPictures()
        {
            for (int i = 0; i < g.CountResources; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile("../../../Resources/" + (i+1).ToString() + ".jpg");
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Tag = i;
                pic.Height = 200;
                pic.Width = 200;
                pic.Tag = i;
                allPictures[i] = pic;
                flpPictures.Controls.Add(pic);

                allPictures[i].Click += AllPictures_Click;
            }
        }

        /// <summary>
        /// Добавление выбранной картинки в класс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllPictures_Click(object? sender, EventArgs e)
        {
            if (sender is Control c)
            {
                for (int i = 0;i < allPictures.Length;i++)
                {
                    allPictures[i].BorderStyle = BorderStyle.None;
                    if (c.Tag == allPictures[i].Tag)
                    {
                        allPictures[i].BorderStyle = BorderStyle.Fixed3D;
                        g.Picture = allPictures[i].Image as Bitmap;
                    }
                }
            }
        }

        /// <summary>
        /// Открытие вкладки с картинками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuNewPuzzle_Click(object? sender, EventArgs e)
        {
            tabControl1.SelectTab(tpPictures);
        }

        /// <summary>
        /// настройка размеров, строк, столбцов tablelayoutpanel, определение позиций ячеек, разбиение картинки
        /// размещение деталей на вкладке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuOk_Click(object? sender, EventArgs e)
        {
            g.SizePic = Convert.ToInt32(Math.Sqrt(Convert.ToDouble((cbNumDetails.Text))));
            deltax = Convert.ToInt32(0.4 * tlpField.Width / tlpField.RowCount);
            deltay = Convert.ToInt32(0.4 * tlpField.Height / tlpField.ColumnCount);

            //изменение размеров tablelayout
            tlpField.ColumnCount = g.SizePic;
            tlpField.RowCount = g.SizePic;

            for (int col = 0; col < tlpField.ColumnCount; col++)
            {
                tlpField.ColumnStyles.Add(new ColumnStyle());
                tlpField.ColumnStyles[col].SizeType = SizeType.Percent;
                tlpField.ColumnStyles[col].Width = 40;
                
            }
            for (int row = 0; row < tlpField.RowCount; row++)
            {
                tlpField.RowStyles.Add(new RowStyle());
                tlpField.RowStyles[row].SizeType = SizeType.Percent;
                tlpField.RowStyles[row].Height = 40;
            }
            tabControl1.SelectTab(tpField);

            cellLocation = new Point[g.SizePic, g.SizePic];
            for (int row = 0; row < g.SizePic; row++)
            {
                for (int col = 0; col < g.SizePic; col++)
                {
                    cellLocation[row, col].X = tlpField.Location.X + tlpField.Width/tlpField.ColumnCount*col;
                    cellLocation[row, col].Y = tlpField.Location.Y + tlpField.Height/tlpField.RowCount*row;
                }
            }


            //разбиение картинки
            Details = new PictureBox[g.SizePic, g.SizePic];
            Image im = g.Picture as Bitmap;

            int w = im.Width;
            int h = im.Height;

            // координаты по X
            int[] x = new int[g.SizePic + 1];
            x[0] = 0;
            for (int i = 1; i <= g.SizePic; i++)
            {
                x[i] = w * i / g.SizePic;
            }

            // координаты по Y
            int[] y = new int[g.SizePic + 1];
            y[0] = 0;
            for (int i = 1; i <= g.SizePic; i++)
            {
                y[i] = h * i / g.SizePic;
            }

            Bitmap bmp;
            Graphics graf;
            for (int j = 0; j < g.SizePic; j++)
            {
                for (int i = 0; i < g.SizePic; i++)
                {
                    // размеры bmp
                    w = x[i + 1] - x[i];
                    h = y[j + 1] - y[j];
                    bmp = new Bitmap(w, h);
                    
                    graf = Graphics.FromImage(bmp);
                    graf.DrawImage(im, new Rectangle(0, 0, w, h), new Rectangle(x[i], y[j], w, h), GraphicsUnit.Pixel);

                    PictureBox pb = new PictureBox();
                    Details[i, j] = pb;

                    pb.Image = bmp;
                    pb.Width = tlpField.Width / tlpField.ColumnCount;
                    pb.Height = tlpField.Height / tlpField.RowCount;
                    pb.Location = new Point(rand.Next(gbDetails.Width- pb.Width), rand.Next(gbDetails.Height- pb.Width));
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Tag = numDetail;
                    tpField.Controls.Add(Details[i, j]);
                    Details[i, j].BringToFront();

                    Details[i, j].MouseDown += All_MouseDown;
                    Details[i, j].MouseMove += All_MouseMove;
                    Details[i, j].MouseUp += All_MouseUp;

                    numDetail++;
                    graf.Dispose();
                    
                }
            }
            im.Dispose();
            g.CreateArray();
            Invalidate();
        }

        /// <summary>
        /// Добавление детали к tablelayoutpanel (в случае подходящего местоположения), проверка на правильность сборки пазла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void All_MouseUp(object? sender, MouseEventArgs e)
        {
            if (sender is Control c)
            {
                for (int i = 0; i < g.SizePic; i++)
                {
                    for (int j = 0; j < g.SizePic; j++)
                    {
                        if (c.Location.X < cellLocation[j, i].X + deltax && c.Location.X > cellLocation[j, i].X - deltax &&
                         c.Location.Y < cellLocation[j, i].Y + deltay && c.Location.Y > cellLocation[j, i].Y - deltay)
                        {

                            //проверить ячейку свободна или нет
                            if (tlpField.GetControlFromPosition(i, j) == null)
                            {
                                try
                                {
                                    c.Dock = DockStyle.Fill;
                                    c.Parent = tlpField;
                                    c.Margin = new Padding(0);
                                    tlpField.SetCellPosition(c, new TableLayoutPanelCellPosition(i, j));
                                }
                                catch (Exception)
                                {
                                    c.Parent = gbDetails;
                                    c.Dock = DockStyle.None;
                                    c.Location = new Point(rand.Next(gbDetails.Width - c.Width), rand.Next(gbDetails.Height - c.Width));
                                }

                            }
                            else
                            {
                                try
                                {
                                    Control con = tlpField.GetControlFromPosition(i, j);
                                    con.Parent = gbDetails;
                                    c.Parent = tlpField;
                                    c.Dock = DockStyle.Fill;
                                    c.Margin = new Padding(0);
                                    tlpField.SetCellPosition(c, new TableLayoutPanelCellPosition(i, j));
                                    con.Dock = DockStyle.None;
                                    con.Location = new Point(rand.Next(gbDetails.Width - con.Width), rand.Next(gbDetails.Height - con.Width));
                                    con.BringToFront();
                                }
                                catch (Exception)
                                {
                                    c.Parent = gbDetails;
                                    c.Dock = DockStyle.None;
                                    c.Location = new Point(rand.Next(gbDetails.Width - c.Width), rand.Next(gbDetails.Height - c.Width));
                                }
                            }
                            break;
                        }
                        
                    }

                }

                for (int i = 0; i < g.SizePic; i++)
                {
                    for (int j = 0; j < g.SizePic; j++)
                    {
                        Control temp = tlpField.GetControlFromPosition(j, i);
                        
                        g.CheckFinish(temp, i, j);
                        if (g.win == false)
                        {
                            break;
                        }
                    }
                    if (g.win == false)
                    {
                        break;
                    }
                }
                if (g.win == true)
                {
                    new FmWin(tabControl1, tpPictures).ShowDialog();
                }
            }
        }

        /// <summary>
        /// Перемещение детали
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void All_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (sender is Control c)
                {
                    c.Dock = DockStyle.None;
                    c.Location = new Point(
                        c.Location.X + e.X - startPoint.X,
                        c.Location.Y + e.Y - startPoint.Y
                        );
                    tlpField.Invalidate();
                }
            }
        }

        /// <summary>
        /// Запоминание местоположения детали
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void All_MouseDown(object? sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            if (sender is Control c)
            {
                c.Parent = tpField;
                c.BringToFront();
            }
        }
    }
}
