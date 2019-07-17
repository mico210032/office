
using System;
using System.Windows.Forms;
using System.IO;

namespace Given
{
 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // private const string FILE_NAME = "123.txt";
        
        private void button1_Click(object sender, EventArgs e)
        {
            var datetime = DateTime.Now;
            StreamWriter sw = new StreamWriter("123.txt", true);
            sw.WriteLine("進入時間為"+datetime+"\r");
            sw.Close();           
        }

        private void button2_Click(object sender, EventArgs e)
        {

                var datetime = DateTime.Now;
                StreamWriter sw = new StreamWriter("123.txt", true);
                sw.WriteLine("出去時間為" + datetime + "\r");
                sw.Close();
            }
        int a,b,c = 0; //a=總和 , b=時間 , c=比較

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader str = new StreamReader("123.txt");
            string input;
            //case 1
            if (comboBox1.Text=="08:00~16:00")
            {
               string[]t= { "上午 08", "上午 09", "上午 10", "上午 11", "下午 12", "下午 01", "下午 02", "下午 03", "下午 04" };
                 for(int i=0;i<9;i++)
                {
                    str.BaseStream.Seek(0, SeekOrigin.Begin);
                    while ((input=str.ReadLine())!=null)
                        {
                            if(input.IndexOf(t[i])!=-1)
                            {
                        
                                    c++;
                            }
                    
                    }
                       str.ReadToEnd();
                    if (c>a)
                        {
                        a = c;
                        b = i;
                        c = 0;
                        }
                         c = 0;
                       if(a>0)
                    { 
                    label1.Text = "最多時段為" + t[b]+"共"+a+ "人";
                    }
                       if(a==0)
                    {
                        label1.Text = "無此紀錄";
                    }
                } 
                
            }
            //case 2
            a = 0;
            b = 0;
            c = 0;
            if (comboBox1.Text == "00:00~12:00")
            {
                string[] t = { "上午 00", "上午 01", "上午 02", "上午 03", "上午 04", "上午 05", "上午 06", "上午 07", "上午 08", "上午 09", "上午 10", "上午 11" };
                for (int i = 0; i < 12; i++)
                {
                    str.BaseStream.Seek(0, SeekOrigin.Begin);
                    while ((input = str.ReadLine()) != null)
                    {
                        if (input.IndexOf(t[i]) != -1)
                        {

                            c++;
                        }

                    }
                    str.ReadToEnd();
                    if (c > a)
                    {
                        a = c;
                        b = i;
                        c = 0;
                    }
                    c = 0;
                    if (a > 0)
                    {
                        label1.Text = "最多時段為" + t[b] + "共" + a + "人";
                    }
                    if (a == 0)
                    {
                        label1.Text = "無此紀錄";
                    }
                }

            }
            //case 3 
                 a = 0;
                b = 0;
                c = 0;
            if (comboBox1.Text == "12:00~23:59")
            {
                string[] t = { "下午 12", "下午 01", "下午 02", "下午 03", "下午 04", "下午 05", "下午 06", "下午 07", "下午 08", "下午 09", "下午 10", "下午 11" };
                for (int i = 0; i < 12; i++)
                {
                    str.BaseStream.Seek(0, SeekOrigin.Begin);
                    while ((input = str.ReadLine()) != null)
                    {
                        if (input.IndexOf(t[i]) != -1)
                        {

                            c++;
                        }

                    }
                    str.ReadToEnd();
                    if (c > a)
                    {
                        a = c;
                        b = i;
                        c = 0;
                    }
                    c = 0;
                    if (a > 0)
                    {
                        label1.Text = "最多時段為" + t[b] + "共" + a + "人";
                    }
                    if (a == 0)
                    {
                        label1.Text = "無此紀錄";
                    }
                }

            }
            //case4 
            a = 0;
            b = 0;
            c = 0;
            if (comboBox1.Text == "00:00~23:59")
            {
                string[] t = { "上午 00", "上午 01", "上午 02", "上午 03", "上午 04", "上午 05", "上午 06", "上午 07", "上午 08", "上午 09", "上午 10", "上午 11", "下午 12", "下午 01", "下午 02", "下午 03", "下午 04", "下午 05", "下午 06", "下午 07", "下午 08", "下午 09", "下午 10", "下午 11" };
                for (int i = 0; i < 24; i++)
                {
                    str.BaseStream.Seek(0, SeekOrigin.Begin);
                    while ((input = str.ReadLine()) != null)
                    {
                        if (input.IndexOf(t[i]) != -1)
                        {

                            c++;
                        }

                    }
                    str.ReadToEnd();
                    if (c > a)
                    {
                        a = c;
                        b = i;
                        c = 0;
                    }
                    c = 0;
                    if (a > 0)
                    {
                        label1.Text = "最多時段為" + t[b] + "共" + a + "人";
                    }
                    if (a == 0)
                    {
                        label1.Text = "無此紀錄";
                    }
                }
               
            } 

        }
        
    }
    }

