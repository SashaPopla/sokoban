using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    // делегат для класу Game
    public delegate void deShowItem(Place place, Cell cell);
    public delegate void deShowStat(int placed, int total);

    public partial class LabirintForm : Form
    {
        int width, height;
        int level_nr, last_level_nr;

        PictureBox[,] box;

        Game game;

        public LabirintForm()
        {
            InitializeComponent();
            last_level_nr = 1;
            game = new Game(ShowItem, ShowStat);
        }

        public void OpenLevel(int level_nr)
        {
            if (level_nr > last_level_nr)
            {
                return;
            }

            this.level_nr = level_nr;

            if(!game.Init(level_nr, out width, out height))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                return;
            }

            InitPictures();
            game.ShowLevel();
        }

        public void InitPictures() 
        {
            box = new PictureBox[width,height];

            int bw, bh;

            bw = panel.Width / width;
            bh = panel.Height / height;

            if (bw < bh)
                bh = bw;
            else
                bw = bh;

            panel.Controls.Clear();

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
                    //picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
                    picture.Tag = new Place(x, y);
                    panel.Controls.Add(picture);
                    box[x, y] = picture;
                }
            }
        }
        public void ShowItem(Place place, Cell item)
        {
            box[place.x, place.y].Image = CellToPicture(item);
        }

        public void ShowStat(int placed, int total)
        {
            toolStat.Text = placed.ToString() + " з " + total.ToString();
            toolLevel.Text = level_nr.ToString();
            toolDone.Visible = placed == total;

            if(placed == total)
            {
                if(level_nr == last_level_nr)
                {
                    last_level_nr = level_nr + 1;
                }
            }
        }

        private void toolPrevLevel_Click(object sender, EventArgs e)
        {
            if(level_nr > 1)
            {
                OpenLevel(level_nr - 1);
            }
        }

        private void toolNextLevel_Click(object sender, EventArgs e)
        {
            OpenLevel(level_nr + 1);
        }

        private void LabirintForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: game.Step(-1, 0); break;
                case Keys.Right: game.Step(1, 0); break;
                case Keys.Down: game.Step(0, 1); break;
                case Keys.Up: game.Step(0, -1); break;
                case Keys.Escape: RestartLevel(); break;
            }
        }

        private void RestartLevel()
        {
            game.Init(level_nr, out width, out height);
            game.ShowLevel();
        }

        private void panel_Resize(object sender, EventArgs e)
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
                    box[x, y].Location = new System.Drawing.Point(x * (bw - 1), y * (bh - 1));
                    box[x, y].Size = new System.Drawing.Size(bw, bh);
                }
            }
        }

        private void toolRestart_Click(object sender, EventArgs e)
        {
            game.Init(level_nr, out width, out height);
            game.ShowLevel();
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
    }
}
