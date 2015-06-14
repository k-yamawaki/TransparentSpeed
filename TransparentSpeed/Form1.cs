using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TransparentSpeed
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 背景画像
        /// </summary>
        private static readonly string imgPath = @"transparent.png";

        /// <summary>
        /// 描画回数
        /// </summary>
        private int paintCount;

        /// <summary>
        /// 最大描画回数
        /// </summary>
        private int paintCountMax;

        /// <summary>
        /// 計測開始中フラグ
        /// </summary>
        private bool IsMeasure;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ロード処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.textBoxFile.Text) == false)
            {
                Bitmap bkImg = new Bitmap(this.textBoxFile.Text);
                this.buttonTransparent.BackgroundImage = bkImg;
                this.buttonNotTransparent.BackgroundImage = bkImg;
                this.buttonTransparent.Text = "";
                this.buttonNotTransparent.Text = "";
            }
        }

        /// <summary>
        /// 描画タイマーイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPaint_Tick(object sender, EventArgs e)
        {
            this.MeasurePaintTime();
        }

        /// <summary>
        /// 描画時間計測
        /// </summary>
        private void MeasurePaintTime()
        {
            if (this.paintCount == this.paintCountMax)
            {
                this.StopMeasurePaint();
            }
            else
            {
                this.paintCount++;
                if (this.checkBoxEachInvalidate.Checked)
                {
                    this.buttonTransparent.Invalidate();
                    this.buttonTransparent.Update();
                    this.buttonNotTransparent.Invalidate();
                    this.buttonNotTransparent.Update();
                }
                else
                {
                    this.Invalidate();
                    this.Update();
                }
                this.UpdatePaintTime();
            }
        }

        /// <summary>
        /// 描画時間更新
        /// </summary>
        private void UpdatePaintTime()
        {
            this.labelPaintCount.Text = string.Format("描画回数         {0}(回)", this.paintCount);
            this.labelTransparentPaintTime.Text = string.Format("透過の描画時間   {0}(msec)", this.buttonTransparent.PaintTime.TotalMilliseconds);
            this.labelNotTransparentPaintTime.Text = string.Format("非透過の描画時間 {0}(msec)", this.buttonNotTransparent.PaintTime.TotalMilliseconds);
        }

        /// <summary>
        /// 計測開始ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (this.IsMeasure)
            {
                this.StopMeasurePaint();
            }
            else
            {
                this.StartMeasurePaint();
            }
        }

        /// <summary>
        /// 計測を開始する
        /// </summary>
        private void StartMeasurePaint()
        {
            if (string.IsNullOrEmpty(this.textBoxPaintCount.Text))
            {
                MessageBox.Show("Please input paint count.");
                return;
            }

            this.IsMeasure = true;
            this.buttonStart.Text = "中止";
            this.paintCountMax = Convert.ToInt32(this.textBoxPaintCount.Text);
            this.paintCount = 0;
            this.buttonTransparent.ClearPaintTime();
            this.buttonNotTransparent.ClearPaintTime();
            this.DoubleBuffered = this.checkBoxDoubleBuffer.Checked;
            this.timerPaint.Start();
        }

        /// <summary>
        /// 計測を中止する
        /// </summary>
        private void StopMeasurePaint()
        {
            this.IsMeasure = false;
            this.buttonStart.Text = "計測開始";
            this.timerPaint.Stop();
        }
    }
}
