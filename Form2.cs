using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace test_video_smoke
{
    public partial class Form2 : Form
    {
        int[] data_base;
        int[] data_exp;
        double tp, fn, tn, fp, recall, prec;
        bool is_load = false;

        public Form2()
        {
            InitializeComponent();
        }

        // ЗАГРУЗКА ФАЙЛОВ
        private void _load1_Click(object sender, EventArgs e)
        {
            is_load = false;
            if (_open.ShowDialog() == DialogResult.OK)
            {
                data_base = JsonConvert.DeserializeObject<int[]>(File.ReadAllText(_open.FileName));
                string[] fragments = _open.FileName.Split('\\');
                _path1.Text = fragments[fragments.Length - 1];
                is_load = true;
            }
        }
        private void _load2_Click(object sender, EventArgs e)
        {
            is_load = false;
            if (_open.ShowDialog() == DialogResult.OK)
            {
                data_exp = JsonConvert.DeserializeObject<int[]>(File.ReadAllText(_open.FileName));
                string[] fragments = _open.FileName.Split('\\');
                _path2.Text = fragments[fragments.Length - 1];
                is_load = true;
            }
        }

        // ВЫЧИСЛИТЬ
        private void _calc_Click(object sender, EventArgs e)
        {
            if (is_load)
            {
                int L = data_exp.Length;
                tp = 0;
                fn = 0;
                tn = 0;
                fp = 0;
                for (int i = 0; i < L; i++)
                {
                    if (data_base[i] == 1)
                    {
                        if (data_exp[i] == 1)
                        {
                            tp++;
                        }
                        if (data_exp[i] == 0)
                        {
                            fn++;
                        }
                    }
                    if (data_base[i] == 0)
                    {
                        if (data_exp[i] == 1)
                        {
                            fp++;
                        }
                        if (data_exp[i] == 0)
                        {
                            tn++;
                        }
                    }
                }
                tp /= L;
                fn /= L;
                tn /= L;
                fp /= L;
                _tp.Text = Math.Round(100 * tp, 2).ToString();
                _fn.Text = Math.Round(100 * fn, 2).ToString();
                _tn.Text = Math.Round(100 * tn, 2).ToString();
                _fp.Text = Math.Round(100 * fp, 2).ToString();
                _acc.Text = Math.Round(100 * (tp + tn) / (tp + fn + tn + fp), 2).ToString();
                _fpr.Text = Math.Round(100 * fp / (tn + fp), 2).ToString();
                _fnr.Text = Math.Round(100 * fn / (fn + tp), 2).ToString();
                prec = Math.Round(100 * tp / (tp + fp), 2);
                _prec.Text = prec.ToString();
                recall = Math.Round(100 * tp / (tp + fn), 2);
                _recall.Text = recall.ToString();
                _f1.Text = Math.Round(2 * recall * prec / (recall + prec), 2).ToString();
            }
            else
            {
                MessageBox.Show($"Files missing.");
            }
        }
    }
}
