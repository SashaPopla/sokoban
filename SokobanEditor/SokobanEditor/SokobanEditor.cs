using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SokobanEditor
{
    public enum Cell
    {
        none,
        wall,
        abox,
        done,
        here,
        user
    };
    public partial class SokobanEditor : Form
    {
        PictureBox[,] box;
        Cell[,] cell;
        int width, height;
        Cell CurrentCell = Cell.none;
        LevelFile level;
        int Currentlevel = 1;

        static int MinWidth = 5; static int MinHeight = 5;
        static int MaxWidth = 40; static int MaxHeight = 40;

        public SokobanEditor()
        {
            InitializeComponent();
        }

        private void SokobanEditor_Load(object sender, EventArgs e)
        {
            level = new LevelFile("levels.txt");
            Currentlevel = 1;
            LoadLevel();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x, y;

            x = ((Point)((PictureBox)sender).Tag).X;
            y = ((Point)((PictureBox)sender).Tag).Y;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ShowCell(x, y, CurrentCell);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ShowCell(x, y, Cell.none);
            }
        }

        private void ShowCell(int x, int y, Cell c)
        {
            if (c == Cell.user)
            {
                for (int x2 = 0; x2 < width; x2++)
                    for (int y2 = 0; y2 < height; y2++)
                        if (cell[x2, y2] == Cell.user)
                            ShowCell(x2, y2, Cell.none); // стираємо юзера першого, бо не може бути 2 юзера в сінгл версії
            }

            cell[x, y] = c;
            box[x, y].Image = CellToPicture(c);
            CalcStat();
        }

        public void InitPictures()
        {
            int bw, bh;

            bw = panel.Width / width;
            bh = panel.Height / height;

            if (bw < bh)
                bh = bw;
            else
                bw = bh;

            box = new PictureBox[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    PictureBox picture = new PictureBox();
                    picture.BackColor = System.Drawing.Color.White;
                    picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    picture.Location = new System.Drawing.Point(x * (bw - 1), y * (bh - 1));
                    picture.Size = new System.Drawing.Size(bw, bh);
                    picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
                    picture.Tag = new Point(x, y);
                    panel.Controls.Add(picture);
                    box[x, y] = picture;
                }
            }
        }

        public void LoadPictures()
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    box[x, y].Image = CellToPicture(cell[x, y]);
        }

        private void SokobanEditor_Resize(object sender, EventArgs e)
        {
            int bw, bh;

            bw = panel.Width / width;
            bh = panel.Height / height;

            if (bw < bh)
                bh = bw;
            else
                bw = bh;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    box[x,y].Size = new System.Drawing.Size(bw, bh);
                    box[x,y].Location = new System.Drawing.Point(x * (bw - 1), y * (bh - 1));
                }
            }
        }

        private void SetCurrentCell(Cell SelectedCell)
        {
            CurrentCell = SelectedCell;

            toolWall.Checked = CurrentCell == Cell.wall;
            toolAbox.Checked = CurrentCell == Cell.abox;
            toolDone.Checked = CurrentCell == Cell.done;
            toolHere.Checked = CurrentCell == Cell.here;
            toolUser.Checked = CurrentCell == Cell.user;
            toolNone.Checked = CurrentCell == Cell.none;
        }

        private void toolWall_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.wall);
        }

        private void toolAbox_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.abox);
        }

        private void toolHere_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.here);
        }

        private void toolDone_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.done);
        }

        private void toolNone_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.none);
        }

        private void toolUser_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.user);
        }
        private Image CellToPicture(Cell c)
        {
            switch (c)
            {
                case Cell.none: return Properties.Resources.none;
                case Cell.wall: return Properties.Resources.wall;
                case Cell.abox: return Properties.Resources.abox;
                case Cell.here: return Properties.Resources.here;
                case Cell.done: return Properties.Resources.done;
                case Cell.user: return Properties.Resources.user;
                default: return Properties.Resources.none;
            }
        }
        private void ResizeLevel(int w, int h)
        {
            if (w < MinWidth) return;
            if (w > MaxWidth) return;
            if (h < MinHeight) return;
            if (h > MaxHeight) return;

            Cell[,] NewCell = new Cell[w, h];

            for (int x = 0; x < Math.Min(w, width); x++)
            {
                for (int y = 0; y < Math.Min(h, height); y++)
                {
                    NewCell[x, y] = cell[x, y];
                }
            }

            width = w;
            height = h;

            panel.Controls.Clear();
            cell = NewCell;

            InitPictures();
            LoadPictures();
        }
        private string IsGoodLevel()
        {
            int users = CountItems(Cell.user);
            if (users == 0)
                return "Потрібен гравець на полі!";
            if (users > 1)
                return "Потрібен один гравець на полі!";

            int aboxs = CountItems(Cell.abox);
            int heres = CountItems(Cell.here);

            if (aboxs == 0)
                return "Потрібен хотяб один ящик";
            if (aboxs != heres)
                return "Кількість ящиків повинна бути рівна кількістю місць для них";

            return "Все добре!";
        }
        private void toolSave_Click(object sender, EventArgs e)
        {
            SaveLevel();
        }
        private void SaveLevel()
        {
            string error = IsGoodLevel();

            if (error == "")
            {
                MessageBox.Show(error, "ERROR");
                return;
            }

            level.SaveLevel(Currentlevel, cell);
        }
        private void toolPrev_Click(object sender, EventArgs e)
        {
            if(Currentlevel > 1)
            {
                SaveLevel();
                Currentlevel--;
                LoadLevel();
            }
        }
        private void LoadLevel()
        {
            cell = level.LoadLevel(Currentlevel);

            width = cell.GetLength(0);
            height = cell.GetLength(1);

            toolStripTextBoxLabirintSize.Text = width.ToString() + "x" + height.ToString();

            panel.Controls.Clear();
            InitPictures();
            LoadPictures();
            CalcStat();
        }

        private void toolNext_Click(object sender, EventArgs e)
        {
            SaveLevel();
            Currentlevel++;
            LoadLevel();
        }

        private void toolStripButtonSetSize_Click(object sender, EventArgs e)
        {
            string[] dl = { "x" };
            string[] wh = toolStripTextBoxLabirintSize.Text.Split(dl, StringSplitOptions.RemoveEmptyEntries);
        
            int w = int.Parse(wh[0]);
            int h = int.Parse(wh[1]);

            ResizeLevel(w, h);
        }

        private void toolStripTextBoxLabirintSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                toolStripButtonSetSize_Click(sender, null);
            }
        }

        private int CountItems(Cell item)
        {
            int count = 0;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (cell[x, y] == item)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public void CalcStat()
        {
            int boxes = 0, heres = 0, boxesDone = 0;

            for(int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (cell[x,y] == Cell.abox)
                    {
                        boxes++;
                    }

                    if (cell[x,y] == Cell.here)
                    {
                        heres++;
                    }

                    if (cell[x, y] == Cell.done)
                    {
                        boxesDone++;
                    }
                }
            }

            statAbox.Text = boxes.ToString() + "x";
            statHere.Text = heres.ToString() + "x";
            statDone.Text = boxesDone.ToString() + "x";
        }
    }
}