using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Control.Controls
{
    public class MS_Notify : Component
    {

        public class FrameControl : Control
        {
            private int _percent = 0;
            private LinearGradientBrush _gradient = null;

            public FrameControl()
            {
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.Enabled = false;
            }

            public int Percent
            {
                get
                {
                    return _percent;
                }
                set
                {
                    _percent = value;
                    this.Invalidate();
                }
            }

            private void CreateGradient()
            {
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                Color color1 = Color.FromArgb(255, 255, 255, 255);
                Color color2 = Color.Red;//.FromArgb(255, 255, 150, 70);
                _gradient = new LinearGradientBrush(rect, color1, color2, LinearGradientMode.Horizontal);
                Blend bnd = new Blend(3);
                bnd.Factors = new float[] { 0, 1, 0 };
                bnd.Positions = new float[] { 0, 0.5f, 1 };
                _gradient.Blend = bnd;
            }

            protected override void OnSizeChanged(EventArgs e)
            {
                base.OnSizeChanged(e);
                Region rgn = new Region(new Rectangle(0, 0, this.Width, this.Height));
                rgn.Exclude(new Rectangle(1, 2, this.Width - 2, this.Height - 4));
                this.Region = rgn;
                CreateGradient();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                if (_gradient == null)
                {
                    CreateGradient();
                }
                float factor = _gradient.Rectangle.Width / 100f;
                if (_percent == 0)
                {
                    _gradient.ResetTransform();
                }
                e.Graphics.FillRectangle(_gradient, -_gradient.Rectangle.Width + _percent * factor * 2, 0
                    , _gradient.Rectangle.Width, this.Height);
                _gradient.TranslateTransform(factor * 4, 0);
            }
        }

        private FrameControl frame = new FrameControl();
        private BackgroundWorker worker = new BackgroundWorker();

        public MS_Notify()
        {
            worker.WorkerReportsProgress = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        public void Show(Control ctl)
        {
            if (worker.IsBusy == false)
            {
                Bitmap bmp = new Bitmap(ctl.Width, ctl.Height + 2, PixelFormat.Format32bppArgb);
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                Color color1 = Color.FromArgb(255, 255, 255, 255);
                Color color2 = Color.FromArgb(255, 255, 150, 70);
                frame.Bounds = ctl.Bounds;
                ctl.Parent.Controls.Add(frame);
                frame.BringToFront();
                frame.Visible = true;
                worker.RunWorkerAsync();
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; i <= 100; i += 2)
                {
                    worker.ReportProgress(i);
                    Thread.Sleep(20);
                }
            }
            catch { }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            frame.Percent = e.ProgressPercentage;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frame.Visible = false;
        }
    }
}
