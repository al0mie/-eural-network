using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            study();
           
        }



        void Result(double[,]W)
        {
            double Xcoord = double.Parse(textBox1.Text);
            double  Ycoord = double.Parse(textBox2.Text);
            double  Zcoord = double.Parse(textBox3.Text);
            double[] NewNet = new double[8];
            double[] NewOut = new double[8];

            for (int i = 0; i < 8; i++)
                NewNet[i] = Xcoord * W[0, i] + Ycoord * W[1, i] + Zcoord * W[2, i];

            int max_value = (int)NewNet[0];
            int max_index = 0;
            for (int i = 1; i < 8; i++)
            {
                if (NewNet[i] > max_value)
                {
                    max_value = (int)NewNet[i];
                    max_index = i;
                }
            }

            NewOut[max_index] = 1.0;
                   

            string result = "";
            for (int i = 0; i < 8; i++)
                result += NewOut[i];

            label13.Text = result;
           


        }
    
        public void study()
        {


            double[] FirstQuarterX = new double[10];
            double[] FirstQuarterY = new double[10];
            double[] FirstQuarterZ = new double[10];

            double[] SecondQuarterX = new double[10];
            double[] SecondQuarterY = new double[10];
            double[] SecondQuarterZ = new double[10];

            double[] ThirdQuarterX = new double[10];
            double[] ThirdQuarterY = new double[10];
            double[] ThirdQuarterZ = new double[10];

            double[] FourthQuarterX = new double[10];
            double[] FourthQuarterY = new double[10];
            double[] FourthQuarterZ = new double[10];

            double[] FivthQuarterX = new double[10];
            double[] FivthQuarterY = new double[10];
            double[] FivthQuarterZ = new double[10];

            double[] SixthQuarterX = new double[10];
            double[] SixthQuarterY = new double[10];
            double[] SixthQuarterZ = new double[10];

            double[] SeventhQuarterX = new double[10];
            double[] SeventhQuarterY = new double[10];
            double[] SeventhQuarterZ = new double[10];

            double[] EighthQuarterX = new double[10];
            double[] EighthQuarterY = new double[10];
            double[] EighthQuarterZ = new double[10];

            double[,] W = new double[3, 8];

            double[] NET = new double[8];
            double[] Out = new double[8];
            double[] Error = new double[8];

            double Koef = 0.7;



            Random rand = new Random();


            for (int i = 0; i < 10; i++)
            {
                FirstQuarterX[i] = (double)(rand.Next() % 1000) / 100.0;
                FirstQuarterY[i] = (double)(rand.Next() % 1000) / 100.0;
                FirstQuarterZ[i] = (double)(rand.Next() % 1000) / 100.0;

            }


            for (int i = 0; i < 10; i++)
            {
                SecondQuarterX[i] = (double)(rand.Next() % 1000) / -100.0;
                SecondQuarterY[i] = (double)(rand.Next() % 1000) / 100.0;
                SecondQuarterZ[i] = (double)(rand.Next() % 1000) / 100.0;

            }


            for (int i = 0; i < 10; i++)
            {
                ThirdQuarterX[i] = (double)(rand.Next() % 1000) / -100.0;
                ThirdQuarterY[i] = (double)(rand.Next() % 1000) / -100.0;
                ThirdQuarterZ[i] = (double)(rand.Next() % 1000) / 100.0;
                
            }


            for (int i = 0; i < 10; i++)
            {
                FourthQuarterX[i] = (double)(rand.Next() % 1000) / 100.0;
                FourthQuarterY[i] = (double)(rand.Next() % 1000) / -100.0;
                FourthQuarterZ[i] = (double)(rand.Next() % 1000) / 100.0;
              
            }

            
            for (int i = 0; i < 10; i++)
            {
                FivthQuarterX[i] = (double)(rand.Next() % 1000) / 100.0;
                FivthQuarterY[i] = (double)(rand.Next() % 1000) / 100.0;
                FivthQuarterZ[i] = (double)(rand.Next() % 1000) / -100.0;
              
            }

            
            for (int i = 0; i < 10; i++)
            {
                SixthQuarterX[i] = (double)(rand.Next() % 1000) / -100.0;
                SixthQuarterY[i] = (double)(rand.Next() % 1000) / 100.0;
                SixthQuarterZ[i] = (double)(rand.Next() % 1000) / -100.0;
               
            }

            for (int i = 0; i < 10; i++)
            {
                SeventhQuarterX[i] = (double)(rand.Next() % 1000) / -100.0;
                SeventhQuarterY[i] = (double)(rand.Next() % 1000) / -100.0;
                SeventhQuarterZ[i] = (double)(rand.Next() % 1000) / -100.0;
                
            }

            //   cout << endl << "Eighth Quarter" << endl;
            for (int i = 0; i < 10; i++)
            {
                EighthQuarterX[i] = (double)(rand.Next() % 1000) / 100.0;
                EighthQuarterY[i] = (double)(rand.Next() % 1000) / -100.0;
                EighthQuarterZ[i] = (double)(rand.Next() % 1000) / -100.0;
            
            }

         

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 8; j++)
                {
                    W[i, j] = (double)(rand.Next() % 200 - 100) / 100.0;
                
                }

            for (int k = 0; k < 10; k++)
            {
              
                int counter = 0;
                //FirstQuarter
                while (true)
                {
                    counter++;

                    for (int i = 0; i < 8; i++)
                        NET[i] = FirstQuarterX[k] * W[0, i] + FirstQuarterY[k] * W[1, i] + FirstQuarterZ[k] * W[2, i];

                    double max_value = NET[0];
                    int max_index = 0;
                    for (int i = 1; i < 8; i++)
                    {
                        if (NET[i] > max_value)
                        {
                            max_value = NET[i];
                            max_index = i;
                        }
                    }

                    for (int i = 0; i < 8; i++)
                        Out[i] = 0.0;

                    Out[max_index] = 1.0;

                    Error[0] = 1.0 - Out[0];
                    Error[1] = 0.0 - Out[1];
                    Error[2] = 0.0 - Out[2];
                    Error[3] = 0.0 - Out[3];
                    Error[4] = 0.0 - Out[4];
                    Error[5] = 0.0 - Out[5];
                    Error[6] = 0.0 - Out[6];
                    Error[7] = 0.0 - Out[7];

                    if (Error[0] == 0.0 && Error[1] == 0.0 && Error[2] == 0.0 && Error[3] == 0.0 && Error[4] == 0.0 &&
                        Error[5] == 0.0 && Error[6] == 0.0 && Error[7] == 0.0)
                        break;

                    for (int j = 0; j < 8; j++)
                    {
                        W[0, j] = W[0, j] + FirstQuarterX[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[1, j] = W[1, j] + FirstQuarterY[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[2, j] = W[2, j] + FirstQuarterZ[j] * Error[j] * ((70.0 - counter) / 100.0);
                    }
                }

             
                counter = 0;

                //SecondQuarter
                while (true)
                {
                    counter++;

                    for (int i = 0; i < 8; i++)
                        NET[i] = SecondQuarterX[k] * W[0, i] + SecondQuarterY[k] * W[1, i] + SecondQuarterZ[k] * W[2, i];

                    double max_value = NET[0];
                    int max_index = 0;
                    for (int i = 1; i < 8; i++)
                    {
                        if (NET[i] > max_value)
                        {
                            max_value = NET[i];
                            max_index = i;
                        }
                    }

                    for (int i = 0; i < 8; i++)
                        Out[i] = 0.0;

                    Out[max_index] = 1.0;

                    Error[0] = 0.0 - Out[0];
                    Error[1] = 1.0 - Out[1];
                    Error[2] = 0.0 - Out[2];
                    Error[3] = 0.0 - Out[3];
                    Error[4] = 0.0 - Out[4];
                    Error[5] = 0.0 - Out[5];
                    Error[6] = 0.0 - Out[6];
                    Error[7] = 0.0 - Out[7];

                    if (Error[0] == 0.0 && Error[1] == 0.0 && Error[2] == 0.0 && Error[3] == 0.0 && Error[4] == 0.0 &&
                        Error[5] == 0.0 && Error[6] == 0.0 && Error[7] == 0.0)
                        break;

                    for (int j = 0; j < 8; j++)
                    {
                        W[0, j] = W[0, j] + SecondQuarterX[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[1, j] = W[1, j] + SecondQuarterY[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[2, j] = W[2, j] + SecondQuarterZ[j] * Error[j] * ((70.0 - counter) / 100.0);
                    }
                }


                counter = 0;

                //ThirdQuarter
                while (true)
                {
                    counter++;

                    for (int i = 0; i < 8; i++)
                        NET[i] = ThirdQuarterX[k] * W[0, i] + ThirdQuarterY[k] * W[1, i] + ThirdQuarterZ[k] * W[2, i];

                    double max_value = NET[0];
                    int max_index = 0;
                    for (int i = 1; i < 8; i++)
                    {
                        if (NET[i] > max_value)
                        {
                            max_value = NET[i];
                            max_index = i;
                        }
                    }

                    for (int i = 0; i < 8; i++)
                        Out[i] = 0.0;

                    Out[max_index] = 1.0;

                    Error[0] = 0.0 - Out[0];
                    Error[1] = 0.0 - Out[1];
                    Error[2] = 1.0 - Out[2];
                    Error[3] = 0.0 - Out[3];
                    Error[4] = 0.0 - Out[4];
                    Error[5] = 0.0 - Out[5];
                    Error[6] = 0.0 - Out[6];
                    Error[7] = 0.0 - Out[7];

                    if (Error[0] == 0.0 && Error[1] == 0.0 && Error[2] == 0.0 && Error[3] == 0.0 && Error[4] == 0.0 &&
                        Error[5] == 0.0 && Error[6] == 0.0 && Error[7] == 0.0)
                        break;

                    for (int j = 0; j < 8; j++)
                    {
                        W[0, j] = W[0, j] + ThirdQuarterX[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[1, j] = W[1, j] + ThirdQuarterY[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[2, j] = W[2, j] + ThirdQuarterZ[j] * Error[j] * ((70.0 - counter) / 100.0);
                    }
                }

      
            
                counter = 0;

                //FourthQuarter
                while (true)
                {
                    counter++;

                    for (int i = 0; i < 8; i++)
                        NET[i] = FourthQuarterX[k] * W[0, i] + FourthQuarterY[k] * W[1, i] + FourthQuarterZ[k] * W[2, i];

                    double max_value = NET[0];
                    int max_index = 0;
                    for (int i = 1; i < 8; i++)
                    {
                        if (NET[i] > max_value)
                        {
                            max_value = NET[i];
                            max_index = i;
                        }
                    }

                    for (int i = 0; i < 8; i++)
                        Out[i] = 0.0;

                    Out[max_index] = 1.0;

                    Error[0] = 0.0 - Out[0];
                    Error[1] = 0.0 - Out[1];
                    Error[2] = 0.0 - Out[2];
                    Error[3] = 1.0 - Out[3];
                    Error[4] = 0.0 - Out[4];
                    Error[5] = 0.0 - Out[5];
                    Error[6] = 0.0 - Out[6];
                    Error[7] = 0.0 - Out[7];

                    if (Error[0] == 0.0 && Error[1] == 0.0 && Error[2] == 0.0 && Error[3] == 0.0 && Error[4] == 0.0 &&
                        Error[5] == 0.0 && Error[6] == 0.0 && Error[7] == 0.0)
                        break;

                    for (int j = 0; j < 8; j++)
                    {
                        W[0, j] = W[0, j] + FourthQuarterX[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[1, j] = W[1, j] + FourthQuarterY[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[2, j] = W[2, j] + FourthQuarterZ[j] * Error[j] * ((70.0 - counter) / 100.0);
                    }
                }


                counter = 0;

                //FivthQuarter
                while (true)
                {
                    counter++;

                    for (int i = 0; i < 8; i++)
                        NET[i] = FivthQuarterX[k] * W[0, i] + FivthQuarterY[k] * W[1, i] + FivthQuarterZ[k] * W[2, i];

                    double max_value = NET[0];
                    int max_index = 0;
                    for (int i = 1; i < 8; i++)
                    {
                        if (NET[i] > max_value)
                        {
                            max_value = NET[i];
                            max_index = i;
                        }
                    }

                    for (int i = 0; i < 8; i++)
                        Out[i] = 0.0;

                    Out[max_index] = 1.0;

                    Error[0] = 0.0 - Out[0];
                    Error[1] = 0.0 - Out[1];
                    Error[2] = 0.0 - Out[2];
                    Error[3] = 0.0 - Out[3];
                    Error[4] = 1.0 - Out[4];
                    Error[5] = 0.0 - Out[5];
                    Error[6] = 0.0 - Out[6];
                    Error[7] = 0.0 - Out[7];

                    if (Error[0] == 0.0 && Error[1] == 0.0 && Error[2] == 0.0 && Error[3] == 0.0 && Error[4] == 0.0 &&
                        Error[5] == 0.0 && Error[6] == 0.0 && Error[7] == 0.0)
                        break;

                    for (int j = 0; j < 8; j++)
                    {
                        W[0, j] = W[0, j] + FivthQuarterX[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[1, j] = W[1, j] + FivthQuarterY[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[2, j] = W[2, j] + FivthQuarterZ[j] * Error[j] * ((70.0 - counter) / 100.0);
                    }
                }


                counter = 0;

                //SixthQuarter
                while (true)
                {
                    counter++;

                    for (int i = 0; i < 8; i++)
                        NET[i] = SixthQuarterX[k] * W[0, i] + SixthQuarterY[k] * W[1, i] + SixthQuarterZ[k] * W[2, i];

                    double max_value = NET[0];
                    int max_index = 0;
                    for (int i = 1; i < 8; i++)
                    {
                        if (NET[i] > max_value)
                        {
                            max_value = NET[i];
                            max_index = i;
                        }
                    }

                    for (int i = 0; i < 8; i++)
                        Out[i] = 0.0;

                    Out[max_index] = 1.0;

                    Error[0] = 0.0 - Out[0];
                    Error[1] = 0.0 - Out[1];
                    Error[2] = 0.0 - Out[2];
                    Error[3] = 0.0 - Out[3];
                    Error[4] = 0.0 - Out[4];
                    Error[5] = 1.0 - Out[5];
                    Error[6] = 0.0 - Out[6];
                    Error[7] = 0.0 - Out[7];

                    if (Error[0] == 0.0 && Error[1] == 0.0 && Error[2] == 0.0 && Error[3] == 0.0 && Error[4] == 0.0 &&
                        Error[5] == 0.0 && Error[6] == 0.0 && Error[7] == 0.0)
                        break;

                    for (int j = 0; j < 8; j++)
                    {
                        W[0, j] = W[0, j] + SixthQuarterX[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[1, j] = W[1, j] + SixthQuarterY[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[2, j] = W[2, j] + SixthQuarterZ[j] * Error[j] * ((70.0 - counter) / 100.0);
                    }
                }

                counter = 0;

                //SeventhQuarter
                while (true)
                {
                    counter++;

                    for (int i = 0; i < 8; i++)
                        NET[i] = SeventhQuarterX[k] * W[0, i] + SeventhQuarterY[k] * W[1, i] + SeventhQuarterZ[k] * W[2, i];

                    double max_value = NET[0];
                    int max_index = 0;
                    for (int i = 1; i < 8; i++)
                    {
                        if (NET[i] > max_value)
                        {
                            max_value = NET[i];
                            max_index = i;
                        }
                    }

                    for (int i = 0; i < 8; i++)
                        Out[i] = 0.0;

                    Out[max_index] = 1.0;

                    Error[0] = 0.0 - Out[0];
                    Error[1] = 0.0 - Out[1];
                    Error[2] = 0.0 - Out[2];
                    Error[3] = 0.0 - Out[3];
                    Error[4] = 0.0 - Out[4];
                    Error[5] = 0.0 - Out[5];
                    Error[6] = 1.0 - Out[6];
                    Error[7] = 0.0 - Out[7];

                    if (Error[0] == 0.0 && Error[1] == 0.0 && Error[2] == 0.0 && Error[3] == 0.0 && Error[4] == 0.0 &&
                        Error[5] == 0.0 && Error[6] == 0.0 && Error[7] == 0.0)
                        break;

                    for (int j = 0; j < 8; j++)
                    {
                        W[0, j] = W[0, j] + SeventhQuarterX[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[1, j] = W[1, j] + SeventhQuarterY[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[2, j] = W[2, j] + SeventhQuarterZ[j] * Error[j] * ((70.0 - counter) / 100.0);
                    }
                }

              
                counter = 0;

                //EighthQuarter
                while (true)
                {
                    counter++;

                    for (int i = 0; i < 8; i++)
                        NET[i] = EighthQuarterX[k] * W[0, i] + EighthQuarterY[k] * W[1, i] + EighthQuarterZ[k] * W[2, i];

                    double max_value = NET[0];
                    int max_index = 0;
                    for (int i = 1; i < 8; i++)
                    {
                        if (NET[i] > max_value)
                        {
                            max_value = NET[i];
                            max_index = i;
                        }
                    }

                    for (int i = 0; i < 8; i++)
                        Out[i] = 0.0;

                    Out[max_index] = 1.0;

                    Error[0] = 0.0 - Out[0];
                    Error[1] = 0.0 - Out[1];
                    Error[2] = 0.0 - Out[2];
                    Error[3] = 0.0 - Out[3];
                    Error[4] = 0.0 - Out[4];
                    Error[5] = 0.0 - Out[5];
                    Error[6] = 0.0 - Out[6];
                    Error[7] = 1.0 - Out[7];

                    if (Error[0] == 0.0 && Error[1] == 0.0 && Error[2] == 0.0 && Error[3] == 0.0 && Error[4] == 0.0 &&
                        Error[5] == 0.0 && Error[6] == 0.0 && Error[7] == 0.0)
                        break;

                    for (int j = 0; j < 8; j++)
                    {
                        W[0, j] = W[0, j] + EighthQuarterX[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[1, j] = W[1, j] + EighthQuarterY[j] * Error[j] * ((70.0 - counter) / 100.0);
                        W[2, j] = W[2, j] + EighthQuarterZ[j] * Error[j] * ((70.0 - counter) / 100.0);
                    }
                }

               
                counter = 0;
            }
            Result(W);

            

                  


        }
    }
}