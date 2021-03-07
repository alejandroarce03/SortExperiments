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

            while (repetition <= 100)
            {
                prev = value;
                value = random.Next(1, 6);

                while (prev == value)
                {
                    value = random.Next(1, 6);
                    
                }
                
                Cases(value);
                repetition++;
            }
           
        }

        public void Cases(int value)
        {
            int[] tmp;

            switch (value)
            {

                case 1:
                    Stopwatch time = new Stopwatch();
                    time.Start();
                    tmp = ex.CreateArray(10);
                    ex.MergeSort(tmp);
                    time.Stop();
                    var t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1","1","1", t);

                    break;

                case 2:

                    Stopwatch time2 = new Stopwatch();
                    time2.Start();
                    tmp = ex.CreateArray(100);
                    ex.MergeSort(tmp);
                    time2.Stop();
                    var t2 = time2.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "1", "2", t2);
                    break;

                case 3:
                    Stopwatch time3 = new Stopwatch();
                    time3.Start();
                    tmp = ex.CreateArray(1000);
                    ex.MergeSort(tmp);
                    time3.Stop();
                    var t3 = time3.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "1", "3", t3);
                    break;

                case 4:
                    Stopwatch time4 = new Stopwatch();
                    time4.Start();
                    tmp = ex.CreateArray(10);
                    ex.InsertionSort(tmp);
                    time4.Stop();
                    var t4 = time4.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "1", "1", t4);
                    break;

                case 5:
                    Stopwatch time5 = new Stopwatch();
                    time5.Start();
                    tmp = ex.CreateArray(100);
                    ex.InsertionSort(tmp);
                    time5.Stop();
                    var t5 = time5.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "1", "2", t5);
                    break;

                case 6:
                    Stopwatch time6 = new Stopwatch();
                    time6.Start();
                    tmp = ex.CreateArray(1000);
                    ex.InsertionSort(tmp);
                    time6.Stop();
                    var t6 = time6.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "1", "3", t6);
                    break;


            }

        }

       
      
    }
}
