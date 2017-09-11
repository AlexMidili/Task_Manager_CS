using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Controls.Calendar;
//using System.Windows.Controls.DatePicker;

namespace TaskManager_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a, b;
        int count;
        bool znak = true;
        int sec = 0;
        int min = 0;
        int second = 0;
        int hours = 0;
        int times = 0;
        int batman = 0;

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                default:
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            /*календарик*/
            this.dateTimePicker1.Format = DateTimePickerFormat.Time;
            this.dateTimePicker1.Width = 100;
            this.dateTimePicker1.ShowUpDown = true;
            label11.Text = "Время запуска программы";

            /*Напоминалка*/
            Timer timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 100;
            timer1.Start();
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            label5.Text = "0";
            label10.Text = "сек";
            label9.Text = "Ваше уведомление появится через: ";
            label3.Text = "";
            label4.Text = "";
            this.Text = "TaskManager";
            label1.Text = "Введите ваше будущее уведомление";
            label6.Text = "Hour";
            label7.Text = "Min";
            label8.Text = "Sec";
            button1.Text = "Выполнить уведомление";
            
            /* Калькулятор*/
            button20.Text = "0";
            button19.Text = ".";
            button18.Text = "=";
            button17.Text = "1";
            button16.Text = "2";
            button15.Text = "3";
            button14.Text = "/";
            button13.Text = "4";
            button12.Text = "5";
            button11.Text = "6";
            button10.Text = "*";
            button9.Text = "7";
            button8.Text = "8";
            button7.Text = "9";
            button6.Text = "-";
            button5.Text = "+";
            button4.Text = "+/-";
            button3.Text = "<-";
            button2.Text = "Clear";
        }

       
        private void timer2_Tick(object sender, EventArgs e)
        {
            sec++;
            batman = times - sec;
            label5.Text = batman.ToString();
            if (sec == times)
            {
                timer2.Enabled = false;
                MessageBox.Show("Задча:\t" + textBox1.Text + "\tупомянута!", "Напоминание");
            }

                              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sec = 0;
            batman = 0;
            times = 0;
            hours = int.Parse(textBox3.Text);
            min = int.Parse(textBox4.Text);
            second = int.Parse(textBox5.Text);

            if(hours != 0)
                {
                    times += 3600 * hours;
                }

            if (min != 0)
                {
                    times += 60 * min;
                }

            if (second != 0)
                {
                    times += second;
                }

            timer2.Enabled = true;
            //timer2.Start();
            //label5.Text = timer2.Interval.ToString();
         }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        /*private void setBalloonTip()
            {
            notifyIcon1.Icon = SystemIcons.Exclamation;
            notifyIcon1.BalloonTipTitle = "Balloon Tip title";
            notifyIcon1.BalloonTipText = "Balloon Tip Text.";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            this.Click += new EventHandler(Form1_Load);
            }*/

        private void tabPage3_Click(object sender, EventArgs e)
        {
            this.label4.Text = this.monthCalendar1.SelectionRange.Start.ToShortDateString();
            //DatePicker datePickerFor2017 = new DatePicker();
            /*
            MonthCalendar basicCalendar = new MonthCalendar();
            basicCalendar.Display= new DateTime(2017, 1, 7);*/
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.label4.Text = this.monthCalendar1.SelectionRange.Start.ToShortDateString();
        }


        private void button17_Click(object sender, EventArgs e)
                {

                    textBox2.Text = textBox2.Text + 1;
                }

             private void button16_Click(object sender, EventArgs e)
                {
                    textBox2.Text = textBox2.Text + 2;
                }

             private void button15_Click(object sender, EventArgs e)
                {
                    textBox2.Text = textBox2.Text + 3;
                }

             private void button14_Click(object sender, EventArgs e)
                {
            
                a = float.Parse(textBox2.Text);
                textBox2.Clear();
                count = 4;
                label3.Text = a.ToString() + "/";
                }

             private void button20_Click(object sender, EventArgs e)
                {
                    textBox2.Text = textBox2.Text + 0;
                }

             private void textBox2_TextChanged(object sender, EventArgs e)
                {

                }

                private void button2_Click(object sender, EventArgs e)
                {
                 textBox2.Text = "";
                 label3.Text = "";
                }

                private void button13_Click(object sender, EventArgs e)
                {
                    textBox2.Text = textBox2.Text + 4;
                }

                private void button12_Click(object sender, EventArgs e)
                {
                    textBox2.Text = textBox2.Text + 5;
                }

                private void button11_Click(object sender, EventArgs e)
                {
                    textBox2.Text = textBox2.Text + 6;
                }

                private void button9_Click(object sender, EventArgs e)
                {
                    textBox2.Text = textBox2.Text + 7;
                }

                private void button8_Click(object sender, EventArgs e)
                {
                    textBox2.Text = textBox2.Text + 8;
                }

                private void button7_Click(object sender, EventArgs e)
                {
                    textBox2.Text = textBox2.Text + 9;
                }

                private void button19_Click(object sender, EventArgs e)
                {
                    if (textBox2.Text.IndexOf(',') == -1)
                    {
                        textBox2.Text += ",";
                    }
                }


                 private void tabPage2_Click(object sender, EventArgs e)
                    {
           
                    }

                 private void button5_Click(object sender, EventArgs e)
                    {
                    a = float.Parse(textBox2.Text);
                    textBox2.Clear();
                    count = 1;
                    label3.Text = a.ToString() + "+";
                    }

                private void button6_Click(object sender, EventArgs e)
                {
                    a = float.Parse(textBox2.Text);
                    textBox2.Clear();
                    count = 2;
                    label3.Text = a.ToString() + "-";
                }

                private void button10_Click(object sender, EventArgs e)
                {
                    a = float.Parse(textBox2.Text);
                    textBox2.Clear();
                    count = 3;
                    label3.Text = a.ToString() + "*";
                }

                private void button18_Click(object sender, EventArgs e)
                {
                 calculate();
                 label3.Text = "";
                }

                private void button3_Click(object sender, EventArgs e)
                {
                    int length = textBox2.Text.Length - 1;
                    string text = textBox2.Text;
                    textBox2.Clear();
                    for (int i = 0; i < length; i++)
                        {
                        textBox2.Text = textBox2.Text + text[i];
                        }
                }

                private void button4_Click(object sender, EventArgs e)
                {
                    if (znak == true)
                    {
                        textBox2.Text = "-" + textBox2.Text;
                        znak = false;
                    }
                    else if (znak == false)
                    { 
                        textBox2.Text = "-" + textBox2.Text;
                        znak = true;
                    }
                 }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void currentTime_Click(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = DateTime.Now;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /*Текущее время в Напоминалка*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime ThToday = DateTime.Now;
            string ThData = ThToday.ToString();
            this.label2.Text = ThData;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
