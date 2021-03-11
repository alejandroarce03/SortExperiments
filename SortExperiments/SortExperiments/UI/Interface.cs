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
                value = random.Next(1, 12);

                while (prev == value)
                {
                    value = random.Next(1, 12);
                }

                switch (value)
                {
                    case 1:
                        if (count[0] <= 120)
                        {
                            count[0]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 2:
                        if (count[1] <= 120)
                        {
                            count[1]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 3:
                        if (count[2] <= 120)
                        {
                            count[2]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 4:
                        if (count[3] <= 120)
                        {
                            count[3]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 5:
                        if (count[4] <= 120)
                        {
                            count[4]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 6:
                        if (count[5] <= 120)
                        {
                            count[5]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 7:
                        if (count[6] <= 120)
                        {
                            count[6]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 8:
                        if (count[7] <= 120)
                        {
                            count[7]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 9:
                        if (count[8] <= 120)
                        {
                            count[8]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 10:
                        if (count[9] <= 120)
                        {
                            count[9]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 11:
                        if (count[10] <= 120)
                        {
                            count[10]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 12:
                        if (count[11] <= 120)
                        {
                            count[11]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                }
                Console.WriteLine(repetition);
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
                    dt.Rows.Add("1","1","1", t);
                    break;

                case 2:
                    tmp = ex.CreateRandomArray(100);
                    ex.MergeSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "1", "2", t);
                    break;

                case 3:
                    tmp = ex.CreateRandomArray(1000);
                    ex.MergeSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "1", "3", t);
                    break;

                case 4:
                    tmp = ex.CreateRandomArray(10);
                    ex.InsertionSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "2", "1", t);
                    break;

                case 5:
                    tmp = ex.CreateRandomArray(100);
                    ex.InsertionSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "2", "2", t);
                    break;

                case 6:
                    tmp = ex.CreateRandomArray(1000);
                    ex.InsertionSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "2", "3", t);
                    break;

                case 7:
                    tmp = ex.CreateAscendentArray(ex.CreateRandomArray(10));
                    ex.MergeSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "1", "1", t);
                    break;

                case 8:
                    tmp = ex.CreateAscendentArray(ex.CreateRandomArray(100));
                    ex.MergeSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "1", "2", t);
                    break;

                case 9:
                    tmp = ex.CreateAscendentArray(ex.CreateRandomArray(1000));
                    ex.MergeSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "1", "3", t);
                    break;

                case 10:
                    tmp = ex.CreateAscendentArray(ex.CreateRandomArray(10));
                    ex.InsertionSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "2", "1", t);
                    break;

                case 11:
                    tmp = ex.CreateRandomArray(100);
                    ex.InsertionSort(tmp);
                    time.Stop();
                     t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "2", "2", t);
                    break;

                case 12:
                    tmp = ex.CreateAscendentArray(ex.CreateRandomArray(1000));
                    ex.InsertionSort(tmp);
                    time.Stop();
                    t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "2", "3", t);
                    break;

            }

        }

      
    }
}
