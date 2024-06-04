
namespace test_video_smoke
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._picturebox = new System.Windows.Forms.PictureBox();
            this._progress = new System.Windows.Forms.ProgressBar();
            this._load = new System.Windows.Forms.Button();
            this._path = new System.Windows.Forms.TextBox();
            this._open = new System.Windows.Forms.OpenFileDialog();
            this._track = new System.Windows.Forms.TrackBar();
            this._list = new System.Windows.Forms.ListBox();
            this._start = new System.Windows.Forms.Button();
            this._stop = new System.Windows.Forms.Button();
            this._del = new System.Windows.Forms.Button();
            this._save = new System.Windows.Forms.Button();
            this._outfile = new System.Windows.Forms.TextBox();
            this._clear = new System.Windows.Forms.Button();
            this._metrics = new System.Windows.Forms.Button();
            this._frame = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._frame)).BeginInit();
            this.SuspendLayout();
            // 
            // _picturebox
            // 
            this._picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picturebox.Location = new System.Drawing.Point(10, 10);
            this._picturebox.Margin = new System.Windows.Forms.Padding(5);
            this._picturebox.Name = "_picturebox";
            this._picturebox.Size = new System.Drawing.Size(320, 180);
            this._picturebox.TabIndex = 0;
            this._picturebox.TabStop = false;
            // 
            // _progress
            // 
            this._progress.Location = new System.Drawing.Point(340, 80);
            this._progress.Margin = new System.Windows.Forms.Padding(5);
            this._progress.Name = "_progress";
            this._progress.Size = new System.Drawing.Size(250, 10);
            this._progress.Step = 1;
            this._progress.TabIndex = 1;
            // 
            // _load
            // 
            this._load.Location = new System.Drawing.Point(340, 10);
            this._load.Margin = new System.Windows.Forms.Padding(5);
            this._load.MaximumSize = new System.Drawing.Size(120, 30);
            this._load.MinimumSize = new System.Drawing.Size(120, 30);
            this._load.Name = "_load";
            this._load.Size = new System.Drawing.Size(120, 30);
            this._load.TabIndex = 2;
            this._load.Text = "Load video";
            this._load.UseVisualStyleBackColor = true;
            this._load.Click += new System.EventHandler(this._load_Click);
            // 
            // _path
            // 
            this._path.Location = new System.Drawing.Point(340, 50);
            this._path.Margin = new System.Windows.Forms.Padding(5);
            this._path.Multiline = true;
            this._path.Name = "_path";
            this._path.ReadOnly = true;
            this._path.Size = new System.Drawing.Size(120, 20);
            this._path.TabIndex = 3;
            this._path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _open
            // 
            this._open.FileName = "openFileDialog1";
            // 
            // _track
            // 
            this._track.LargeChange = 1;
            this._track.Location = new System.Drawing.Point(10, 200);
            this._track.Margin = new System.Windows.Forms.Padding(5);
            this._track.Maximum = 0;
            this._track.MaximumSize = new System.Drawing.Size(320, 30);
            this._track.MinimumSize = new System.Drawing.Size(320, 30);
            this._track.Name = "_track";
            this._track.Size = new System.Drawing.Size(320, 45);
            this._track.TabIndex = 4;
            this._track.TickStyle = System.Windows.Forms.TickStyle.None;
            this._track.Scroll += new System.EventHandler(this._track_Scroll);
            // 
            // _list
            // 
            this._list.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._list.FormattingEnabled = true;
            this._list.ItemHeight = 12;
            this._list.Location = new System.Drawing.Point(340, 100);
            this._list.Margin = new System.Windows.Forms.Padding(5);
            this._list.Name = "_list";
            this._list.Size = new System.Drawing.Size(120, 172);
            this._list.TabIndex = 6;
            // 
            // _start
            // 
            this._start.Location = new System.Drawing.Point(10, 243);
            this._start.Margin = new System.Windows.Forms.Padding(5);
            this._start.MaximumSize = new System.Drawing.Size(120, 30);
            this._start.MinimumSize = new System.Drawing.Size(120, 30);
            this._start.Name = "_start";
            this._start.Size = new System.Drawing.Size(120, 30);
            this._start.TabIndex = 7;
            this._start.Text = "Object appears";
            this._start.UseVisualStyleBackColor = true;
            this._start.Click += new System.EventHandler(this._start_Click);
            // 
            // _stop
            // 
            this._stop.Location = new System.Drawing.Point(210, 243);
            this._stop.Margin = new System.Windows.Forms.Padding(5);
            this._stop.MaximumSize = new System.Drawing.Size(120, 30);
            this._stop.MinimumSize = new System.Drawing.Size(120, 30);
            this._stop.Name = "_stop";
            this._stop.Size = new System.Drawing.Size(120, 30);
            this._stop.TabIndex = 8;
            this._stop.Text = "Object disappears";
            this._stop.UseVisualStyleBackColor = true;
            this._stop.Click += new System.EventHandler(this._stop_Click);
            // 
            // _del
            // 
            this._del.Location = new System.Drawing.Point(470, 100);
            this._del.Margin = new System.Windows.Forms.Padding(5);
            this._del.MaximumSize = new System.Drawing.Size(120, 30);
            this._del.MinimumSize = new System.Drawing.Size(120, 30);
            this._del.Name = "_del";
            this._del.Size = new System.Drawing.Size(120, 30);
            this._del.TabIndex = 9;
            this._del.Text = "Delete note";
            this._del.UseVisualStyleBackColor = true;
            this._del.Click += new System.EventHandler(this._del_Click);
            // 
            // _save
            // 
            this._save.Location = new System.Drawing.Point(470, 10);
            this._save.Margin = new System.Windows.Forms.Padding(5);
            this._save.MaximumSize = new System.Drawing.Size(120, 30);
            this._save.MinimumSize = new System.Drawing.Size(120, 30);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(120, 30);
            this._save.TabIndex = 11;
            this._save.Text = "Save report";
            this._save.UseVisualStyleBackColor = true;
            this._save.Click += new System.EventHandler(this._save_Click);
            // 
            // _outfile
            // 
            this._outfile.Location = new System.Drawing.Point(470, 50);
            this._outfile.Margin = new System.Windows.Forms.Padding(5);
            this._outfile.Multiline = true;
            this._outfile.Name = "_outfile";
            this._outfile.ReadOnly = true;
            this._outfile.Size = new System.Drawing.Size(120, 20);
            this._outfile.TabIndex = 13;
            this._outfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _clear
            // 
            this._clear.Location = new System.Drawing.Point(470, 140);
            this._clear.Margin = new System.Windows.Forms.Padding(5);
            this._clear.MaximumSize = new System.Drawing.Size(120, 30);
            this._clear.MinimumSize = new System.Drawing.Size(120, 30);
            this._clear.Name = "_clear";
            this._clear.Size = new System.Drawing.Size(120, 30);
            this._clear.TabIndex = 14;
            this._clear.Text = "Clear list";
            this._clear.UseVisualStyleBackColor = true;
            this._clear.Click += new System.EventHandler(this._clear_Click);
            // 
            // _metrics
            // 
            this._metrics.Location = new System.Drawing.Point(470, 243);
            this._metrics.Margin = new System.Windows.Forms.Padding(5);
            this._metrics.MaximumSize = new System.Drawing.Size(120, 30);
            this._metrics.MinimumSize = new System.Drawing.Size(120, 30);
            this._metrics.Name = "_metrics";
            this._metrics.Size = new System.Drawing.Size(120, 30);
            this._metrics.TabIndex = 15;
            this._metrics.Text = "Metrics...";
            this._metrics.UseVisualStyleBackColor = true;
            this._metrics.Click += new System.EventHandler(this._metrics_Click);
            // 
            // _frame
            // 
            this._frame.Location = new System.Drawing.Point(140, 247);
            this._frame.Margin = new System.Windows.Forms.Padding(5);
            this._frame.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this._frame.MaximumSize = new System.Drawing.Size(60, 0);
            this._frame.MinimumSize = new System.Drawing.Size(60, 0);
            this._frame.Name = "_frame";
            this._frame.Size = new System.Drawing.Size(60, 20);
            this._frame.TabIndex = 16;
            this._frame.ValueChanged += new System.EventHandler(this._frame_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 281);
            this.Controls.Add(this._frame);
            this.Controls.Add(this._metrics);
            this.Controls.Add(this._clear);
            this.Controls.Add(this._outfile);
            this.Controls.Add(this._save);
            this.Controls.Add(this._del);
            this.Controls.Add(this._stop);
            this.Controls.Add(this._start);
            this.Controls.Add(this._list);
            this.Controls.Add(this._track);
            this.Controls.Add(this._path);
            this.Controls.Add(this._load);
            this.Controls.Add(this._progress);
            this.Controls.Add(this._picturebox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(615, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(615, 320);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Markup";
            ((System.ComponentModel.ISupportInitialize)(this._picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _picturebox;
        private System.Windows.Forms.ProgressBar _progress;
        private System.Windows.Forms.Button _load;
        private System.Windows.Forms.TextBox _path;
        private System.Windows.Forms.OpenFileDialog _open;
        private System.Windows.Forms.TrackBar _track;
        private System.Windows.Forms.ListBox _list;
        private System.Windows.Forms.Button _start;
        private System.Windows.Forms.Button _stop;
        private System.Windows.Forms.Button _del;
        private System.Windows.Forms.Button _save;
        private System.Windows.Forms.TextBox _outfile;
        private System.Windows.Forms.Button _clear;
        private System.Windows.Forms.Button _metrics;
        private System.Windows.Forms.NumericUpDown _frame;
    }
}

