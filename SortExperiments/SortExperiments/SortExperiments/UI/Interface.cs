using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortExperiments.Model;

namespace SortExperiments.UI

{
    public partial class Interface : Form
    {
        private Experiment ex;
        private DataTable dt;

        public Interface()
        {
            ex = new Experiment();
            InitializeComponent();
            dt = new DataTable();
            CreateTable();
            CreateExperiment();


        }

        public void CreateTable()
        {
            dt.Columns.Add("Sort");
            dt.Columns.Add("Data state");
            dt.Columns.Add("Array size");
            dt.Columns.Add("Time");
            dt.Columns.Add("Tratamiento");
            report.DataSource = dt;
        }

        private void CreateExperiment()
        {
            int repetition = 1;
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = 0;
            int prev = -1;
            int[] count = new int[12];

            while (repetition <= 1200)
            {
                prev = value;
                value = random.Next(1, 13);

                while (prev == value)
                {
                    value = random.Next(1, 13);
                }

                switch (value)
                {
                    case 1:
                        if (count[0] < 100)
                        {
                            count[0]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 2:
                        if (count[1] < 100)
                        {
                            count[1]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 3:
                        if (count[2] < 100)
                        {
                            count[2]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 4:
                        if (count[3] < 100)
                        {
                            count[3]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 5:
                        if (count[4] < 100)
                        {
                            count[4]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 6:
                        if (count[5] < 100)
                        {
                            count[5]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 7:
                        if (count[6] < 100)
                        {
                            count[6]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 8:
                        if (count[7] < 100)
                        {
                            count[7]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 9:
                        if (count[8] < 100)
                        {
                            count[8]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 10:
                        if (count[9] < 100)
                        {
                            count[9]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 11:
                        if (count[10] < 100)
                        {
                            count[10]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 12:
                        if (count[11] < 100)
                        {
                            count[11]++;
                            Cases(value);
                            repetition++;
                        }
               
                        break;

                } Console.WriteLine(count[0] + "  " + count[1] + "  " + count[2] + "  " + count[3] + "  " + count[4] + "  " + count[5] + "  " + count[6] + "  " + count[7] + "  " + count[8] + "  " + count[9] + "  " + count[10] + "  " + count[11]);
            }
        }

        public void Cases(int value)
        {
            int[] tmp;
            Stopwatch time = new Stopwatch();
            time.Start();
            var t = 0.0;
            switch (value)
            {

                case 1:
                    tmp = ex.CreateRandomArray(10);
                    ex.MergeSort(tmp);
                    time.Stop();
                    t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1","1","1", t, "1");
                    break;

                case 2:
                    tmp = ex.CreateRandomArray(100);
                    ex.MergeSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "1", "2", t, "2");
                    break;

                case 3:
                    tmp = ex.CreateRandomArray(1000);
                    ex.MergeSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "1", "3", t, "3");
                    break;

                case 4:
                    tmp = ex.CreateRandomArray(10);
                    ex.InsertionSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "2", "1", t, "4");
                    break;

                case 5:
                    tmp = ex.CreateRandomArray(100);
                    ex.InsertionSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "2", "2", t, "5");
                    break;

                case 6:
                    tmp = ex.CreateRandomArray(1000);
                    ex.InsertionSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "2", "3", t, "6");
                    break;

                case 7:
                    tmp = ex.CreateAscendentArray(ex.CreateRandomArray(10));
                    ex.MergeSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "1", "1", t, "7");
                    break;

                case 8:
                    tmp = ex.CreateAscendentArray(ex.CreateRandomArray(100));
                    ex.MergeSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "1", "2", t, "8");
                    break;

                case 9:
                    tmp = ex.CreateAscendentArray(ex.CreateRandomArray(1000));
                    ex.MergeSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "1", "3", t, "9");
                    break;

                case 10:
                    tmp = ex.CreateAscendentArray(ex.CreateRandomArray(10));
                    ex.InsertionSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "2", "1", t, "10");
                    break;

                case 11:
                    tmp = ex.CreateRandomArray(100);
                    ex.InsertionSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "2", "2", t, "11");
                    break;

                case 12:
                    tmp = ex.CreateAscendentArray(ex.CreateRandomArray(1000));
                    ex.InsertionSort(tmp);
                    time.Stop();
                    t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "2", "3", t, "12");
                    break;

            }


        }

      
    }
}
