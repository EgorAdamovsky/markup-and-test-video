
namespace test_video_smoke
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._path1 = new System.Windows.Forms.TextBox();
            this._load1 = new System.Windows.Forms.Button();
            this._path2 = new System.Windows.Forms.TextBox();
            this._load2 = new System.Windows.Forms.Button();
            this._open = new System.Windows.Forms.OpenFileDialog();
            this._calc = new System.Windows.Forms.Button();
            this._tp = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this._fn = new System.Windows.Forms.TextBox();
            this._tn = new System.Windows.Forms.TextBox();
            this._fp = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._acc = new System.Windows.Forms.TextBox();
            this._fpr = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this._fnr = new System.Windows.Forms.TextBox();
            this.gdghdhfg = new System.Windows.Forms.TextBox();
            this._prec = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this._recall = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this._f1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _path1
            // 
            this._path1.Location = new System.Drawing.Point(14, 54);
            this._path1.Margin = new System.Windows.Forms.Padding(5);
            this._path1.Multiline = true;
            this._path1.Name = "_path1";
            this._path1.ReadOnly = true;
            this._path1.Size = new System.Drawing.Size(130, 20);
            this._path1.TabIndex = 5;
            this._path1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _load1
            // 
            this._load1.Location = new System.Drawing.Point(14, 14);
            this._load1.Margin = new System.Windows.Forms.Padding(5);
            this._load1.Name = "_load1";
            this._load1.Size = new System.Drawing.Size(130, 30);
            this._load1.TabIndex = 4;
            this._load1.Text = "Load base file";
            this._load1.UseVisualStyleBackColor = true;
            this._load1.Click += new System.EventHandler(this._load1_Click);
            // 
            // _path2
            // 
            this._path2.Location = new System.Drawing.Point(154, 54);
            this._path2.Margin = new System.Windows.Forms.Padding(5);
            this._path2.Multiline = true;
            this._path2.Name = "_path2";
            this._path2.ReadOnly = true;
            this._path2.Size = new System.Drawing.Size(130, 20);
            this._path2.TabIndex = 7;
            this._path2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _load2
            // 
            this._load2.Location = new System.Drawing.Point(154, 14);
            this._load2.Margin = new System.Windows.Forms.Padding(5);
            this._load2.Name = "_load2";
            this._load2.Size = new System.Drawing.Size(130, 30);
            this._load2.TabIndex = 6;
            this._load2.Text = "Load measurements";
            this._load2.UseVisualStyleBackColor = true;
            this._load2.Click += new System.EventHandler(this._load2_Click);
            // 
            // _open
            // 
            this._open.FileName = "openFileDialog1";
            // 
            // _calc
            // 
            this._calc.Location = new System.Drawing.Point(14, 84);
            this._calc.Margin = new System.Windows.Forms.Padding(5);
            this._calc.Name = "_calc";
            this._calc.Size = new System.Drawing.Size(270, 30);
            this._calc.TabIndex = 8;
            this._calc.Text = "Calculate algorithm quality metrics";
            this._calc.UseVisualStyleBackColor = true;
            this._calc.Click += new System.EventHandler(this._calc_Click);
            // 
            // _tp
            // 
            this._tp.Location = new System.Drawing.Point(84, 124);
            this._tp.Margin = new System.Windows.Forms.Padding(5);
            this._tp.Multiline = true;
            this._tp.Name = "_tp";
            this._tp.ReadOnly = true;
            this._tp.Size = new System.Drawing.Size(60, 20);
            this._tp.TabIndex = 9;
            this._tp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGreen;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(14, 124);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(60, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "TP";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightCoral;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(14, 154);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(60, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "FN";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _fn
            // 
            this._fn.Location = new System.Drawing.Point(84, 154);
            this._fn.Margin = new System.Windows.Forms.Padding(5);
            this._fn.Multiline = true;
            this._fn.Name = "_fn";
            this._fn.ReadOnly = true;
            this._fn.Size = new System.Drawing.Size(60, 20);
            this._fn.TabIndex = 11;
            this._fn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _tn
            // 
            this._tn.Location = new System.Drawing.Point(154, 154);
            this._tn.Margin = new System.Windows.Forms.Padding(5);
            this._tn.Multiline = true;
            this._tn.Name = "_tn";
            this._tn.ReadOnly = true;
            this._tn.Size = new System.Drawing.Size(60, 20);
            this._tn.TabIndex = 14;
            this._tn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _fp
            // 
            this._fp.Location = new System.Drawing.Point(154, 124);
            this._fp.Margin = new System.Windows.Forms.Padding(5);
            this._fp.Multiline = true;
            this._fp.Name = "_fp";
            this._fp.ReadOnly = true;
            this._fp.Size = new System.Drawing.Size(60, 20);
            this._fp.TabIndex = 13;
            this._fp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.LightGreen;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(224, 154);
            this.textBox7.Margin = new System.Windows.Forms.Padding(5);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(60, 20);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "TN";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.LightCoral;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(224, 124);
            this.textBox8.Margin = new System.Windows.Forms.Padding(5);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(60, 20);
            this.textBox8.TabIndex = 15;
            this.textBox8.Text = "FP";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 184);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "ACCURACY";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _acc
            // 
            this._acc.Location = new System.Drawing.Point(154, 184);
            this._acc.Margin = new System.Windows.Forms.Padding(5);
            this._acc.Multiline = true;
            this._acc.Name = "_acc";
            this._acc.ReadOnly = true;
            this._acc.Size = new System.Drawing.Size(60, 20);
            this._acc.TabIndex = 18;
            this._acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _fpr
            // 
            this._fpr.Location = new System.Drawing.Point(154, 214);
            this._fpr.Margin = new System.Windows.Forms.Padding(5);
            this._fpr.Multiline = true;
            this._fpr.Name = "_fpr";
            this._fpr.ReadOnly = true;
            this._fpr.Size = new System.Drawing.Size(60, 20);
            this._fpr.TabIndex = 20;
            this._fpr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(14, 214);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "FP RATE";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _fnr
            // 
            this._fnr.Location = new System.Drawing.Point(154, 244);
            this._fnr.Margin = new System.Windows.Forms.Padding(5);
            this._fnr.Multiline = true;
            this._fnr.Name = "_fnr";
            this._fnr.ReadOnly = true;
            this._fnr.Size = new System.Drawing.Size(60, 20);
            this._fnr.TabIndex = 22;
            this._fnr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gdghdhfg
            // 
            this.gdghdhfg.Location = new System.Drawing.Point(14, 244);
            this.gdghdhfg.Margin = new System.Windows.Forms.Padding(5);
            this.gdghdhfg.Multiline = true;
            this.gdghdhfg.Name = "gdghdhfg";
            this.gdghdhfg.ReadOnly = true;
            this.gdghdhfg.Size = new System.Drawing.Size(130, 20);
            this.gdghdhfg.TabIndex = 21;
            this.gdghdhfg.Text = "FN RATE";
            this.gdghdhfg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _prec
            // 
            this._prec.Location = new System.Drawing.Point(154, 274);
            this._prec.Margin = new System.Windows.Forms.Padding(5);
            this._prec.Multiline = true;
            this._prec.Name = "_prec";
            this._prec.ReadOnly = true;
            this._prec.Size = new System.Drawing.Size(60, 20);
            this._prec.TabIndex = 24;
            this._prec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(14, 274);
            this.textBox9.Margin = new System.Windows.Forms.Padding(5);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(130, 20);
            this.textBox9.TabIndex = 23;
            this.textBox9.Text = "PRECISION";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _recall
            // 
            this._recall.Location = new System.Drawing.Point(154, 304);
            this._recall.Margin = new System.Windows.Forms.Padding(5);
            this._recall.Multiline = true;
            this._recall.Name = "_recall";
            this._recall.ReadOnly = true;
            this._recall.Size = new System.Drawing.Size(60, 20);
            this._recall.TabIndex = 26;
            this._recall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(14, 304);
            this.textBox10.Margin = new System.Windows.Forms.Padding(5);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(130, 20);
            this.textBox10.TabIndex = 25;
            this.textBox10.Text = "RECALL";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _f1
            // 
            this._f1.Location = new System.Drawing.Point(154, 334);
            this._f1.Margin = new System.Windows.Forms.Padding(5);
            this._f1.Multiline = true;
            this._f1.Name = "_f1";
            this._f1.ReadOnly = true;
            this._f1.Size = new System.Drawing.Size(60, 20);
            this._f1.TabIndex = 28;
            this._f1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(14, 334);
            this.textBox6.Margin = new System.Windows.Forms.Padding(5);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(130, 20);
            this.textBox6.TabIndex = 27;
            this.textBox6.Text = "F-SCORE";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 366);
            this.Controls.Add(this._f1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this._recall);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this._prec);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this._fnr);
            this.Controls.Add(this.gdghdhfg);
            this.Controls.Add(this._fpr);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this._acc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this._tn);
            this.Controls.Add(this._fp);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this._fn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this._tp);
            this.Controls.Add(this._calc);
            this.Controls.Add(this._path2);
            this.Controls.Add(this._load2);
            this.Controls.Add(this._path1);
            this.Controls.Add(this._load1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(315, 405);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(315, 405);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metrics calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _path1;
        private System.Windows.Forms.Button _load1;
        private System.Windows.Forms.TextBox _path2;
        private System.Windows.Forms.Button _load2;
        private System.Windows.Forms.OpenFileDialog _open;
        private System.Windows.Forms.Button _calc;
        private System.Windows.Forms.TextBox _tp;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox _fn;
        private System.Windows.Forms.TextBox _tn;
        private System.Windows.Forms.TextBox _fp;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox _acc;
        private System.Windows.Forms.TextBox _fpr;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox _fnr;
        private System.Windows.Forms.TextBox gdghdhfg;
        private System.Windows.Forms.TextBox _prec;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox _recall;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox _f1;
        private System.Windows.Forms.TextBox textBox6;
    }
}