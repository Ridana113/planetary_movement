using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myUCLib;

namespace planetary_movement
{
    public partial class Form1 : Form
    {
        const float G = 6.67e-11F;
        float x01, y01, x02, y02;
        float v0x1, v0x2, v0y1, v0y2;
        float R;
        float ax1, ay1, ax2, ay2;
        float dt = 0.01F;
        float m1, m2;

        private void Axis_Click(object sender, EventArgs e)
        {
            x01 = Convert.ToSingle(Ox1.Text);
            y01 = Convert.ToSingle(Oy1.Text);
            x02 = Convert.ToSingle(Ox2.Text);
            y02 = Convert.ToSingle(Oy2.Text);
            axis1.Axis_Type = 1;
            axis1.x_Name = "Ox";
            axis1.y_Name = "Oy";
            axis1.x_Base = (float)Math.Abs(x01 * 10);
            axis1.y_Base = (float)Math.Abs(y01 * 10);
            axis1.AxisDraw();
            axis1.DinToPic();
            axis1.StatToDin();
            Invalidate();
            axis1.Pix_Size = 0.01f;
            axis1.PixDraw(x01,y01, Color.Green, 1);
            axis1.StatToDin();
            axis1.Pix_Size = 0.02f;
            axis1.DinToPic();
            axis1.PixDraw(x02,y02, Color.Blue, 1);
            axis1.StatToDin();
            axis1.DinToPic();
        }

        float Fx2, Fx1, Fy2, Fy1;
        float x1, x2, y1, y2;
        float vx1, vx2, vy1, vy2;
        float xc, yc, vxc, vyc;
        float x1next, y1next, x2next, y2next;
        float vx1next, vy1next, vx2next, vy2next;

        private void Perezapusk_Click_1(object sender, EventArgs e)
        {
            int z = 0;
            mass1.Text = Convert.ToString(z);
            mass2.Text = Convert.ToString(z);
            Ox1.Text = Convert.ToString(z);
            Ox2.Text = Convert.ToString(z);
            Oy1.Text = Convert.ToString(z);
            Oy2.Text = Convert.ToString(z);
            Speed_x1.Text = Convert.ToString(z);
            Speed_x2.Text = Convert.ToString(z);
            Speed_y1.Text = Convert.ToString(z);
            Speed_y2.Text = Convert.ToString(z);
            axis1.ClearDin();
            axis1.ClearPic();
            timer1.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                m1 = Convert.ToSingle(mass1.Text);
                m2 = Convert.ToSingle(mass2.Text);
                v0x1 = Convert.ToSingle(Speed_x1.Text);
                v0y1 = Convert.ToSingle(Speed_y1.Text);
                v0x2 = Convert.ToSingle(Speed_x2.Text);
                v0y2 = Convert.ToSingle(Speed_y2.Text);

                if (m1 < 0 || m2 < 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Уважаемый пользователь, пожалуйста, введите все величины в виде положительного числа");
                }
            }
            catch (FormatException)
            {
                timer1.Stop();
                MessageBox.Show("Уважаемый пользователь, пожалуйста, введите ЧИСЛО!");
                int z = 0;
                m1 = Convert.ToSingle(z);
                m2 = Convert.ToSingle(z);
                x01 = Convert.ToSingle(z);
                y01 = Convert.ToSingle(z);
                x02 = Convert.ToSingle(z);
                y02 = Convert.ToSingle(z);
                v0x1 = Convert.ToSingle(z);
                v0y1 = Convert.ToSingle(z);
                v0x2 = Convert.ToSingle(z);
                v0y2 = Convert.ToSingle(z);
                return;
            }
            x1next = x01;
            x2next = x02;
            y1next = y01;
            y2next = y02;
            vx1next = v0x1;
            vy1next = v0y1;
            vx2next = v0x2;
            vy2next = v0y2;
            timer1.Enabled = true;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            R = (float)Math.Sqrt((float)(Math.Pow((x2next - x1next), 2) + Math.Pow((y2next - y1next), 2)));
            vxc = (vx1 * m1 + vx2 * m2) / (m1 + m2);
            vyc = (vy1 * m1 + vy2 * m2) / (m1 + m2);

            Fx1 = (-G * m1 * m2 * (x2 - x1)) / ((float)Math.Pow(R, 3));
            Fy1 = (-G * m1 * m2 * (y2 - y1)) / ((float)Math.Pow(R, 3));
            Fx2 = -Fx1;
            Fy2 = -Fy1;
            ax1 = Fx1 / m1;
            ax2 = Fx2 / m2;
            ay1 = Fy1 / m1;
            ay2 = Fy2 / m2;
            vx1 = vx1next - vxc + ax1 * dt;
            vy1 = vy1next - vyc + ay1 * dt;
            vx2 = vx2next - vxc + ax2 * dt;
            vy2 = vy2next - vyc + ay2 * dt;
            x1 = (float)(x1next + vx1 * dt + ax1 * 0.5 * Math.Pow(dt, 2));
            y1 = (float)(y1next + vy1 * dt + ay1 * 0.5 * Math.Pow(dt, 2));
            x2 = (float)(x2next + vx2 * dt + ax2 * 0.5 * Math.Pow(dt, 2));
            y2 = (float)(y2next + vy2 * dt + ay2 * 0.5 * Math.Pow(dt, 2));
            axis1.Pix_Size = 0.01f;
            axis1.PixDraw((float)(x1 - xc), (float)(y1 - yc), Color.Green, 1);
            axis1.StatToDin();
            axis1.Pix_Size = 0.015f;
            axis1.PixDraw((float)(x1 - xc), (float)(y1 - yc), Color.Black, 2);
            axis1.DinToPic();
            axis1.Pix_Size = 0.015f;
            axis1.PixDraw((float)(x2 - xc), (float)(y2 - yc), Color.Gray, 1);
            axis1.Pix_Size = 0.02f;
            axis1.StatToDin();
            axis1.PixDraw((float)(x2 - xc), (float)(y2 - yc), Color.Blue, 2);
            axis1.DinToPic();
            x1next = x1;
            x2next = x2;
            y1next = y1;
            y2next = y2;
            vx1next = vx1;
            vx2next = vx2;
            vy1next = vy1;
            vy2next = vy2;
        }
    }
} 


//скорость центра масс и центр масс(х1*м1+х2м2)/2
//отображение в системе центра масс. координаты пример х1-хс1