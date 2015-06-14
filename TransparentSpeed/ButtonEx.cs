using System;
using System.Windows.Forms;

namespace TransparentSpeed
{
    /// <summary>
    /// 描画時間計測用ボタン
    /// </summary>
    class ButtonEx : Button
    {
        /// <summary>
        /// 描画時間
        /// </summary>
        public TimeSpan PaintTime { get; set; }

        /// <summary>
        /// 描画時間をクリアする
        /// </summary>
        public void ClearPaintTime()
        {
            this.PaintTime = this.PaintTime.Subtract(this.PaintTime);
        }

        /// <summary>
        /// 描画
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            DateTime start = DateTime.Now;
            base.OnPaint(pevent);
            PaintTime += DateTime.Now - start;
        }

        /// <summary>
        /// 背景描画
        /// </summary>
        /// <param name="e"></param>
        protected override void OnParentBackColorChanged(EventArgs e)
        {
            DateTime start = DateTime.Now;
            base.OnParentBackColorChanged(e);
            PaintTime += DateTime.Now - start;
        }
    }
}
