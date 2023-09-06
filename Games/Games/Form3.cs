using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class Form3 : Form
    {
        //private int _widht = 900;
        private int _height = 800;
        private int _sizeofSides = 40;
        public Form3()
        {
            this.Width = _widht;
            this.Height = _height;
            InitializeComponent();
            _generateMap();
        }

        private void _generateMap()
        {
            for (int i = 0; i < _widht / _sizeofSides; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox. BackColor = Color.Black;
                pictureBox.Location = new Point(0, _sizeofSides * i);
                pictureBox.Size = new Size(_widht - 100, 1);
                this.Controls.Add(pictureBox);
            }
            for (int i = 0; i <= _height / _sizeofSides; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Black;
                pictureBox.Location = new Point( _sizeofSides * i,0);
                pictureBox.Size = new Size(1,_widht);
                this.Controls.Add(pictureBox);
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(OKP);
        }
        private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right" or "D":
                    pictureBox1.Location = new Point(pictureBox1.Location.X+ _sizeofSides, pictureBox1.Location.Y);
                    break;
                case "Left" or "A":
                    pictureBox1.Location = new Point(pictureBox1.Location.X - _sizeofSides, pictureBox1.Location.Y);
                    break;
                case "Up" or "W":
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y- _sizeofSides);
                    break;
                case "Down" or "S":
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y+ _sizeofSides);
                    break;
            }
        }
    }
}
