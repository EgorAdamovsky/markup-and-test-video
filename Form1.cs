using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Newtonsoft.Json;

namespace test_video_smoke
{
    public struct Rec
    {
        public int frame;
        public bool smoke;

        public Rec(int frame, bool smoke)
        {
            this.frame = frame;
            this.smoke = smoke;
        }

        public override string ToString()
        {
            string status = smoke ? "smoke appears" : "smoke disappears";
            return $"[{frame}] {status}";
        }
    }

    public partial class Form1 : Form
    {
        ImageConverter conveter = new ImageConverter();
        List<Image> frames;
        int all_frames;
        int[] list;
        string output;
        int screen_w = 320, screen_h = 180;

        public Form1()
        {
            InitializeComponent();
        }

        // ЗАГРУЗКА ФАЙЛА
        private void _load_Click(object sender, EventArgs e)
        {
            if (_open.ShowDialog() == DialogResult.OK)
            {
                string[] fragments = _open.FileName.Split('\\');
                _path.Text = fragments[fragments.Length - 1];
                _outfile.Text = _path.Text.Split('.')[0] + ".txt";

                Capture video = new Capture(_open.FileName);
                all_frames = (int)Math.Floor(video.GetCaptureProperty(CapProp.FrameCount));
                frames = new List<Image>(new Image[all_frames]);
                _list.Items.Clear();
                _track.Maximum = all_frames - 1;
                _frame.Maximum = all_frames - 1;
                _frame.Value = 0;

                Mat frame;
                byte[] jpeg;
                for (int i = 0; i < all_frames; i++)
                {
                    frame = video.QueryFrame();
                    CvInvoke.Resize(frame, frame, new Size(screen_w, screen_h), 0, 0, Inter.Linear);
                    Image<Bgr, byte> img = frame.ToImage<Bgr, byte>();
                    jpeg = img.ToJpegData();
                    frames[i] = (Image)conveter.ConvertFrom(jpeg);
                    _progress.Value = (int)(100f * i / all_frames);
                }
                _picturebox.Image = frames[0];
                _progress.Value = 0;
                MessageBox.Show($"{_path.Text} loaded.");
            }
        }

        // ПОЛЗУНОК
        private void _track_Scroll(object sender, EventArgs e)
        {
            _picturebox.Image = frames[_track.Value];
            _frame.Value = _track.Value;
        }
        private void _frame_ValueChanged(object sender, EventArgs e)
        {
            _track.Value = (int)_frame.Value;
            _picturebox.Image = frames[_track.Value];
        }

        // ДОБАВЛЕНИЕ ЗАПИСИ
        private void _start_Click(object sender, EventArgs e)
        {
            _list.Items.Add(new Rec(_track.Value, true));
        }
        private void _stop_Click(object sender, EventArgs e)
        {
            _list.Items.Add(new Rec(_track.Value, false));
        }

        // УДАЛЕНИЕ ЗАПИСЕЙ
        private void _del_Click(object sender, EventArgs e)
        {
            if (_list.SelectedIndex != -1)
            {
                _list.Items.RemoveAt(_list.SelectedIndex);
            }
        }
        private void _clear_Click(object sender, EventArgs e)
        {
            _list.Items.Clear();
        }

        // СОХРАНИТЬ ОТЧЕТ
        private void _save_Click(object sender, EventArgs e)
        {
            if (_outfile.Text != "")
            {
                list = new int[all_frames];
                int[] recs = new int[_list.Items.Count];
                for (int i = 0; i < _list.Items.Count; i++)
                {
                    list[((Rec)_list.Items[i]).frame] = ((Rec)_list.Items[i]).smoke ? 2 : 1;
                }
                int status = 1;
                for (int i = 0; i < all_frames; i++)
                {
                    if (list[i] > 0)
                    {
                        status = list[i];
                    }
                    list[i] = status - 1;
                }
                output = JsonConvert.SerializeObject(list);
                File.WriteAllText("JSON\\" + _outfile.Text, output);
                MessageBox.Show($"{_outfile.Text} saved.");
            }
            else
            {
                MessageBox.Show($"Nothing to save.");
            }
        }

        // ПЕРЕХОД НА МЕТРИКИ
        private void _metrics_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

    }
}
