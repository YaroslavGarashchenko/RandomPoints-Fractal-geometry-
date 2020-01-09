using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPoint
{
    public partial class FormFractal : Form
    {
        public FormFractal()
        {
            InitializeComponent();
        }

        List<PointF> pointFs = new List<PointF>();
        private Random r = new Random();

        /// <summary>
        /// Generation of random coordinates of a new starting point
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            numericUpDownPointX.Value = (decimal)Math.Round(r.NextDouble(), 3);
            numericUpDownPointY.Value = (decimal)Math.Round(r.NextDouble(), 3);
        }
        /// <summary>
        /// Adding a point to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewPoints.Rows.Count <= (int)numericUpDownCountPoint.Value)
            {
                string[] row0 = { numericUpDownPointX.Value.ToString().Trim(), numericUpDownPointY.Value.ToString().Trim() };
                dataGridViewPoints.Rows.Add(row0);
                pointFs.Add(new PointF { X = (float)numericUpDownPointX.Value, Y = (float)numericUpDownPointY.Value });
            }
        }
        /// <summary>
        /// Erasing data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonErase_Click(object sender, EventArgs e)
        {
            dataGridViewPoints.Rows.Clear();
            pointFs.Clear();
        }
        /// <summary>
        /// The creation of a fractal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            int initialPoint = (int)numericUpDownCountPoint.Value;
            int totalPoint = (int)numericUpDownAllPoint.Value;

            PointF currentPoint = new PointF { X = pointFs.Average(n => n.X), Y = pointFs.Average(n => n.Y) };

            for (int i = initialPoint; i < totalPoint; i++)
            {
                pointFs.Add(NewPoint(currentPoint));
                currentPoint = pointFs[i];
            }
            int imageX = (int)numericUpDownPaperX.Value;
            int imageY = (int)numericUpDownPaperY.Value;
            PixelFormat pixel = PixelFormat.Format24bppRgb;
            Color newColor = Color.FromArgb(128, 255, 12);
            Bitmap imageTemp = new Bitmap(imageX, imageY, pixel);
            
            // Loop through the images pixels to reset color.
            for (int i = 0; i < totalPoint; i++)
            {
                imageTemp.SetPixel((int)(pointFs[i].X * imageX), (int)(pointFs[i].Y * imageY), newColor);
            }
            // Set the PictureBox to display the image.
            pictureBoxViewing.Image = imageTemp;
        }
        /// <summary>
        /// Determining the coordinates of the new generated point
        /// </summary>
        /// <returns></returns>
        private PointF NewPoint(PointF iPoint)
        {
            int selectNum = r.Next(0, (int)numericUpDownCountPoint.Value);
            PointF selectPoint = pointFs[selectNum];
            PointF newPoint = new PointF();
            if (comboBoxRatio.Text.Trim() == "1/1" || comboBoxRatio.Text.Trim() == "")
            {
                newPoint = new PointF { X = (selectPoint.X + iPoint.X) / 2, Y = (selectPoint.Y + iPoint.Y) / 2 };
            }
            else if (comboBoxRatio.Text.Trim() == "1/2")
            {
                newPoint = new PointF
                {
                    X = (selectPoint.X < iPoint.X ? selectPoint.X : iPoint.X) + 1 * Math.Abs(selectPoint.X - iPoint.X) / 3,
                    Y = (selectPoint.Y < iPoint.Y ? selectPoint.Y : iPoint.Y) + 1 * Math.Abs(selectPoint.Y - iPoint.Y) / 3
                };
            }
            else if (comboBoxRatio.Text.Trim() == "2/1")
            {
                newPoint = new PointF
                {
                    X = (selectPoint.X < iPoint.X ? selectPoint.X : iPoint.X) + 2 * Math.Abs(selectPoint.X - iPoint.X) / 3,
                    Y = (selectPoint.Y < iPoint.Y ? selectPoint.Y : iPoint.Y) + 2 * Math.Abs(selectPoint.Y - iPoint.Y) / 3
                };
            }
            else if (comboBoxRatio.Text.Trim() == "1/3")
            {
                newPoint = new PointF
                {
                    X = (selectPoint.X < iPoint.X ? selectPoint.X : iPoint.X) + 1 * Math.Abs(selectPoint.X - iPoint.X) / 4,
                    Y = (selectPoint.Y < iPoint.Y ? selectPoint.Y : iPoint.Y) + 1 * Math.Abs(selectPoint.Y - iPoint.Y) / 4
                };
            }
            else if (comboBoxRatio.Text.Trim() == "3/1")
            {
                newPoint = new PointF
                {
                    X = (selectPoint.X < iPoint.X ? selectPoint.X : iPoint.X) + 3 * Math.Abs(selectPoint.X - iPoint.X) / 4,
                    Y = (selectPoint.Y < iPoint.Y ? selectPoint.Y : iPoint.Y) + 3 * Math.Abs(selectPoint.Y - iPoint.Y) / 4
                };
            }
            else if (comboBoxRatio.Text.Trim() == "Random")
            {
                float num = (float)r.NextDouble();
                newPoint = new PointF
                {
                    X = (selectPoint.X < iPoint.X ? selectPoint.X : iPoint.X) + num * Math.Abs(selectPoint.X - iPoint.X),
                    Y = (selectPoint.Y < iPoint.Y ? selectPoint.Y : iPoint.Y) + num * Math.Abs(selectPoint.Y - iPoint.Y)
                };
            }

            return newPoint;
        }
    }
}
