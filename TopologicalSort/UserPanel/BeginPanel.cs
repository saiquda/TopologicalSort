using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TopologicalSort.UserPanel
{
    public partial class BeginPanel : UserControl
    {
        Random rnd = new Random();
        SortedDictionary<long, long> point = new SortedDictionary<long, long>();
        bool flag = false;
        public BeginPanel()
        {
            InitializeComponent();
            TimeBox.SelectionAlignment = HorizontalAlignment.Center;
            CountText.SelectionAlignment = HorizontalAlignment.Center;
            InputTextBox.SelectionAlignment = HorizontalAlignment.Center;
            OutputTextBox.SelectionAlignment = HorizontalAlignment.Center;
            for (int n = 0; n < 20; n++)
            {
                chart1.Series[0].Points.AddXY(n, n + (n - 1));
                chart1.Series[2].Points.AddXY(n, (n * (n - 1)) / 2);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Clear();
            OutputTextBox.Clear();
            TimeBox.Clear();
            CountText.Clear();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortButton_Click(object sender, EventArgs e)
        {
            OutputTextBox.Clear();
            TimeBox.Clear();
            string[] line = CountText.Text.Split();
            int n = int.Parse(line[0]);
            int k = int.Parse(line[1]);
            char[] ch = { ' ', '\n' };
            string[] str = InputTextBox.Text.Split(ch);
            string ans = AlgorithmSort.Sort(n, k, str);
            for (int i = 0; i < ans.Length; i++)
                OutputTextBox.Text += ans[i];
            TimeBox.Text = AlgorithmSort.time.Elapsed.Ticks.ToString();
            if (AlgorithmSort.cycle == false)
            {
                if (flag)
                {
                    chart1.Series[1].Points.Clear();
                    if (point.ContainsKey(ans.Length))
                        point[ans.Length] = AlgorithmSort.a;
                    else
                        point.Add(ans.Length, AlgorithmSort.a);
                    foreach (var item in point)
                        chart1.Series[1].Points.AddXY(item.Key, item.Value);
                }
            }
            flag = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.FileName = "Unnamed.txt";
            SFD.Filter = "(Текстовый файл: )|*.txt";
            if (SFD.ShowDialog() == DialogResult.OK)
                File.WriteAllText(SFD.FileName, OutputTextBox.Text);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "(Текстовый файл: )|*.txt";
            string temp = null;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                CountText.Text = File.ReadLines(OFD.FileName).First();
                temp = File.ReadAllText(OFD.FileName);
                temp = temp.Remove(0, 3);
                InputTextBox.Text = temp.Trim();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Clear();
            OutputTextBox.Clear();
            TimeBox.Clear();
            CountText.Clear();
          
            int n = rnd.Next(2, 20);
            int k = rnd.Next(1, n);
            string line = null;
            for (int i = 0; i < k;i++)
            {
                int temp1 = rnd.Next(1, n);
                int temp2 = rnd.Next(1, n);
                if(temp1 != temp2)
                {
                    line += temp1 + " " + temp2 + "\n";
                    i++;
                }
            }
            if(line != null)
            InputTextBox.Text = line.Trim();
            CountText.Text = n + " " + k;
        }
        /// <summary>
        /// Подсчёт времени выполнения метода
        /// </summary>
        /// <param name="action">Выполняемый метод</param>
        /// <param name="ar">Параметр</param>
        /// <returns>Возвращаем время выполнения метода в миллисекундах</returns>
        private long RunningTime(Action<int[]> action, int[] ar)
        {
            Stopwatch sw = new Stopwatch();
            GC.Collect();
            sw.Start();
            action.Invoke(ar);
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
    }
}
