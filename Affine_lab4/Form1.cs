using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace lab4
{
	public partial class Form1 : Form
	{
		Bitmap bmp;
		Pen pen = new Pen(Color.Red, 4);
		public Form1()
		{
			InitializeComponent();
			bmp = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
			pictureBox.Image = bmp;
			pen.EndCap = LineCap.ArrowAnchor;
		}

        public class Edge
        {
            public My_point P1, P2;
            public Edge(My_point p1, My_point p2) { P1 = p1; P2 = p2; }
            public bool contains(My_point p) { return p == P1 || p == P2; }
            public My_point start() { return P1; }
            public My_point end() { return P2; }
        }

        public class My_point
        {
            public float X, Y;
            public My_point(float x, float y) { X = x; Y = y; }
            public static bool operator ==(My_point p1, My_point p2)
            {
                if (System.Object.ReferenceEquals(p1, p2))
                    return true;
                if (((object)p1 == null) || ((object)p2 == null))
                    return false;
                return p1.X == p2.X && p1.Y == p2.Y;
            }
            public static bool operator !=(My_point p1, My_point p2)
            {
                return !(p1 == p2);
            }
        }

        Graphics g;
		List<My_point> points = new List<My_point>(); // список точек
		List<Edge> edges = new List<Edge>(); // список рёбер
		My_point select_point_add = null; // для рисования ребра
		My_point select_point_del = null; // для  удаления ребра
		My_point rotate_point = null; // точка, относительно которой поворачиваем
		My_point center_point = null; // центральная точка фигуры
                                      //my_point position_point = null;
        /// <summary>
        /// является ли точка центром для поворота
        /// </summary>
        bool is_point_rot = false; 
		//bool is_point_pos = false; // является ли точка проверяемой на расположение относительно ребра
		SolidBrush brush = new SolidBrush(Color.LightGreen);

		/// <summary>
		/// Добавляем/удаляем точки и рёбра
		/// </summary>
		private void pictureBox_MouseClick(object sender, MouseEventArgs e)
		{
			My_point p = null;
			foreach (My_point pp in points)
				if (Math.Abs(pp.X - e.X) <= 3 && Math.Abs(pp.Y - e.Y) <= 3)
					p = pp;

			// если нажата левая кнопка мыши, то добавляем
            if (e.Button == MouseButtons.Left)
            {
				// если нажата кнопка "центр" для поворота фигуры
                if (is_point_rot) 
                {
                    rotate_point = new My_point(e.X, e.Y);
					g.FillEllipse(brush, rotate_point.X - 4, rotate_point.Y - 4, 8, 8);
                    pictureBox.Image = bmp;
                    is_point_rot = false;
                    return;
                }

				// если точки не было, то рисуем её
                if (p == null) 
                {
                    My_point new_p = new My_point(e.X, e.Y);
                    points.Add(new_p);
					g.FillEllipse(brush, new_p.X - 4, new_p.Y - 4, 8, 8);
                    pictureBox.Image = bmp;
                    select_point_add = null;
					center_point = CenterPoint();
                    return;
                }

				// если точка уже есть и она не центр для поворота, то делаем её началом для ребра
                if (select_point_add == null)  
                {
                    select_point_add = p;
                    return;
                }
				
				// иначе, точка - конец ребра, рисуем ребро
                Edge ed = new Edge(select_point_add, p);
                select_point_add = null;
                edges.Add(ed);
				g.DrawLine(pen, ed.P1.X, ed.P1.Y, ed.P2.X, ed.P2.Y);
				center_point = CenterPoint();
                pictureBox.Image = bmp;
            }

			// иначе - удаляем
            else
            {
                if (p != null)
                {
					// если точка принадлежит ребру, то рассматриваем удаление ребра
                    if (edges.Any(element => element.contains(p))) 
                    {
						// если не выбрана первая точка удаляемого ребра, то выбираем её
                        if (select_point_del == null) 
                        {
                            select_point_del = p;
                            return;
                        }

						// удаляем ребро
                        edges.RemoveAll(element => element.contains(p) && element.contains(select_point_del));
                        select_point_del = null;
                        RedrawImage();
                        return;
                    }

					// иначе, удаляем просто точку
                    points.Remove(p);
                    select_point_del = null;
                    RedrawImage();
                }
            }
		}

		/// <summary>
		/// Перемещение фигуры на заданные сдвиги по Х и У
		/// </summary>
		private void Button_dis_Click(object sender, EventArgs e)
		{
			rotate_point = null;
			int kx = (int)set_dis_x.Value, ky = (int)set_dis_y.Value;
			foreach (My_point p in points)
			{
				p.X += kx;
				p.Y += ky;
			}
			RedrawImage();
		}

		/// <summary>
		/// Поворот фигуры на заданный угол относительно заданной точки
		/// </summary>
		private void Button_root_Click(object sender, EventArgs e)
		{
			if (rotate_point == null)
			{
				MessageBox.Show("Не выбрана точка для поворота фигуры!", "Ошибка", MessageBoxButtons.OK);
				return;
			}
			Rotate_figure((int)set_rot_ang.Value);
		}

		private void Rotate_figure(int degree)
		{
			double angle = ((double)degree * Math.PI) / 180;
			foreach (My_point p in points)
			{
				p.X -= rotate_point.X;
				p.Y -= rotate_point.Y;
				double xa = p.X * Math.Cos(angle) + p.Y * Math.Sin(angle);
				double ya = p.Y * Math.Cos(angle) - p.X * Math.Sin(angle);
				p.X = (float)(xa + rotate_point.X);
				p.Y = (float)(ya + rotate_point.Y);
			}
			RedrawImage();
		}

		/// <summary>
		/// Выбор точки, относительно которой будет поворачиваться фигура
		/// </summary>
		private void Button_set_center_Click(object sender, EventArgs e)
		{
			is_point_rot = true;
		}

		/// <summary>
		/// Изменение масштаба заданной фигуры
		/// </summary>
		private void Button_sc_Click(object sender, EventArgs e)
		{
			rotate_point = null;
			My_point center = CenterPoint();
			double kx = (double)set_sc_x.Value;
			double ky = (double)set_sc_y.Value;
			foreach (My_point p in points)
			{
				p.X -= center_point.X;
				p.Y -= center_point.Y;
				p.X = (int)(p.X * kx);
				p.Y = (int)(p.Y * ky);
				p.X += center_point.X;
				p.Y += center_point.Y;
			}
			RedrawImage();
		}

		/// <summary>
		/// Очищаем рисунок
		/// </summary>
		private void Button_clear_Click(object sender, EventArgs e)
		{
			g.Clear(Color.White);
			rotate_point = null;
			is_point_rot = false;
			points.Clear();
			edges.Clear();
			pictureBox.Image = bmp;
			set_dis_x.Value = set_dis_y.Value = set_rot_ang.Value = 0;
			set_sc_x.Value = set_sc_y.Value = 1M;
		}

		/// <summary>
		/// Вычисляем координаты центра фигуры
		/// </summary>
		private My_point CenterPoint()
		{
			if (points.Count == 0)
				return null;
			float sumX = 0, sumY = 0;
			foreach (My_point p in points)
			{
				sumX += p.X;
				sumY += p.Y;
			}
			sumX /= points.Count;
			sumY /= points.Count;
			return new My_point(sumX, sumY);
		}

		/// <summary>
		/// Перерисовываем pictureBox
		/// </summary>
		private void RedrawImage()
		{
            if (!checkBox2.Checked)
			    g.Clear(Color.White);
			if (rotate_point != null)
				g.FillEllipse(brush, rotate_point.X - 4, rotate_point.Y - 4, 8, 8);
			foreach (My_point p in points)
				g.FillEllipse(brush, p.X - 4, p.Y - 4, 8, 8);
			foreach (Edge e in edges)
				g.DrawLine(pen, e.P1.X, e.P1.Y, e.P2.X, e.P2.Y);
			pictureBox.Image = bmp;
			center_point = CenterPoint();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			g = Graphics.FromImage(bmp);
		}
        

		/// <summary>
		/// Определяет c какой стороны относительно направленного ребра лежит точка
		/// </summary>
		/// <param name="ed">ребро</param>
		/// <param name="pt">точка</param>
		/// <returns>1 - слева, -1 - справа, 0 - на ребре</returns>
		private int Pos_rel_edge(Edge ed, My_point pt)
		{
			double z = (ed.P2.Y - ed.P1.Y) * pt.X + (ed.P1.X - ed.P2.X) * pt.Y + (ed.P1.X * (ed.P1.Y - ed.P2.Y) + ed.P1.Y * (ed.P2.X - ed.P1.X));
			if (z < 0)
				return -1;
			else
				if (z > 0)
					return 1;
				else
					return 0;
		}
        

		/// <summary>
		/// Вычисляется абсолютное значение угла между двумя ребрами
		/// </summary>
		/// <param name="e1">Первое ребро</param>
		/// <param name="e2">Второе ребро</param>
		/// <returns>Возвращается значение угла между ребрами в градусах</returns>
		private double Degree_between_edges(Edge e1, Edge e2)
		{
            float e1X = e1.P2.X - e1.P1.X;
            float e1Y = e1.P2.Y - e1.P1.Y;
            float e2X = e2.P2.X - e2.P1.X;
            float e2Y = e2.P2.Y - e2.P1.Y;
			double res = Math.Acos((e1X * e2X + e1Y * e2Y) / (Math.Sqrt(e1X * e1X + e1Y * e1Y) * Math.Sqrt(e2X * e2X + e2Y * e2Y))) * (180 / Math.PI);
			return res;
		}

		private void Button_rot_avg_Click(object sender, EventArgs e)
		{
			if ((edges.Count != 1) || (points.Count != 2))
			{
				MessageBox.Show("Нарисуйте только одно ребро!", "Ошибка!");
				return;
			}
			Edge ed = edges[0];
			rotate_point = new My_point(ed.P1.X + (ed.P2.X - ed.P1.X) / 2, ed.P1.Y + (ed.P2.Y - ed.P1.Y) / 2);
			Rotate_figure(90);
			rotate_point = null;
		}

		My_point Intersection(My_point A, My_point B, My_point C, My_point D)
		{
			double xo = A.X, yo = A.Y;
			double p = B.X - A.X, q = B.Y - A.Y;

			double x1 = C.X, y1 = C.Y;
			double p1 = D.X - C.X, q1 = D.Y - C.Y;

			double x = (xo * q * p1 - x1 * q1 * p - yo * p * p1 + y1 * p * p1) /
				(q * p1 - q1 * p);
			double y = (yo * p * q1 - y1 * p1 * q - xo * q * q1 + x1 * q * q1) /
				(p * q1 - p1 * q);

			return new My_point((int)Math.Round(x), (int)Math.Round(y));
		}

		private void Button_intersec_Click(object sender, EventArgs e)
		{
			if ((edges.Count != 2) || (points.Count != 4))
			{
				MessageBox.Show("Нарисуйте только два ребра!", "Ошибка!");
				return;
			}
			Edge e1 = edges[0];
			Edge e2 = edges[1];
			My_point its = Intersection(e1.start(), e1.end(), e2.start(), e2.end());
			if ((its.X >= Math.Min(e1.P1.X, e1.P2.X)) && (its.X <= Math.Max(e1.P1.X, e1.P2.X)) &&
				(its.X >= Math.Min(e2.P1.X, e2.P2.X)) && (its.X <= Math.Max(e2.P1.X, e2.P2.X)) &&
				(its.Y >= Math.Min(e1.P1.Y, e1.P2.Y)) && (its.Y <= Math.Max(e1.P1.Y, e1.P2.Y)) &&
				(its.Y >= Math.Min(e2.P1.Y, e2.P2.Y)) && (its.Y <= Math.Max(e2.P1.Y, e2.P2.Y)))
			{
				g.FillEllipse(new SolidBrush(Color.Black), its.X - 4, its.Y - 4, 8, 8);
				pictureBox.Refresh();
			}
			else
				MessageBox.Show("Ребра не пересекаются!", "Сообщение");
		}
    }
}
