namespace TransparentSpeed
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTransparentPaintTime = new System.Windows.Forms.Label();
            this.labelNotTransparentPaintTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPaintCount = new System.Windows.Forms.TextBox();
            this.timerPaint = new System.Windows.Forms.Timer(this.components);
            this.labelPaintCount = new System.Windows.Forms.Label();
            this.checkBoxEachInvalidate = new System.Windows.Forms.CheckBox();
            this.checkBoxDoubleBuffer = new System.Windows.Forms.CheckBox();
            this.buttonNotTransparent = new TransparentSpeed.ButtonEx();
            this.buttonTransparent = new TransparentSpeed.ButtonEx();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(337, 559);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "計測開始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "背景色：透過";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "背景色：非透過";
            // 
            // labelTransparentPaintTime
            // 
            this.labelTransparentPaintTime.AutoSize = true;
            this.labelTransparentPaintTime.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTransparentPaintTime.Location = new System.Drawing.Point(10, 541);
            this.labelTransparentPaintTime.Name = "labelTransparentPaintTime";
            this.labelTransparentPaintTime.Size = new System.Drawing.Size(149, 12);
            this.labelTransparentPaintTime.TabIndex = 2;
            this.labelTransparentPaintTime.Text = "透過の描画時間   0(msec)";
            // 
            // labelNotTransparentPaintTime
            // 
            this.labelNotTransparentPaintTime.AutoSize = true;
            this.labelNotTransparentPaintTime.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNotTransparentPaintTime.Location = new System.Drawing.Point(10, 564);
            this.labelNotTransparentPaintTime.Name = "labelNotTransparentPaintTime";
            this.labelNotTransparentPaintTime.Size = new System.Drawing.Size(149, 12);
            this.labelNotTransparentPaintTime.TabIndex = 2;
            this.labelNotTransparentPaintTime.Text = "非透過の描画時間 0(msec)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "描画回数";
            // 
            // textBoxPaintCount
            // 
            this.textBoxPaintCount.Location = new System.Drawing.Point(79, 487);
            this.textBoxPaintCount.Name = "textBoxPaintCount";
            this.textBoxPaintCount.Size = new System.Drawing.Size(88, 19);
            this.textBoxPaintCount.TabIndex = 3;
            this.textBoxPaintCount.Text = "100";
            // 
            // timerPaint
            // 
            this.timerPaint.Tick += new System.EventHandler(this.timerPaint_Tick);
            // 
            // labelPaintCount
            // 
            this.labelPaintCount.AutoSize = true;
            this.labelPaintCount.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPaintCount.Location = new System.Drawing.Point(10, 518);
            this.labelPaintCount.Name = "labelPaintCount";
            this.labelPaintCount.Size = new System.Drawing.Size(137, 12);
            this.labelPaintCount.TabIndex = 2;
            this.labelPaintCount.Text = "描画回数         0(回)";
            // 
            // checkBoxEachInvalidate
            // 
            this.checkBoxEachInvalidate.AutoSize = true;
            this.checkBoxEachInvalidate.Location = new System.Drawing.Point(187, 489);
            this.checkBoxEachInvalidate.Name = "checkBoxEachInvalidate";
            this.checkBoxEachInvalidate.Size = new System.Drawing.Size(112, 16);
            this.checkBoxEachInvalidate.TabIndex = 4;
            this.checkBoxEachInvalidate.Text = "個別に無効化する";
            this.checkBoxEachInvalidate.UseVisualStyleBackColor = true;
            // 
            // checkBoxDoubleBuffer
            // 
            this.checkBoxDoubleBuffer.AutoSize = true;
            this.checkBoxDoubleBuffer.Location = new System.Drawing.Point(324, 489);
            this.checkBoxDoubleBuffer.Name = "checkBoxDoubleBuffer";
            this.checkBoxDoubleBuffer.Size = new System.Drawing.Size(84, 16);
            this.checkBoxDoubleBuffer.TabIndex = 4;
            this.checkBoxDoubleBuffer.Text = "ダブルバッファ";
            this.checkBoxDoubleBuffer.UseVisualStyleBackColor = true;
            // 
            // buttonNotTransparent
            // 
            this.buttonNotTransparent.Location = new System.Drawing.Point(12, 256);
            this.buttonNotTransparent.Name = "buttonNotTransparent";
            this.buttonNotTransparent.PaintTime = System.TimeSpan.Parse("00:00:00.1900120");
            this.buttonNotTransparent.Size = new System.Drawing.Size(400, 200);
            this.buttonNotTransparent.TabIndex = 0;
            this.buttonNotTransparent.Text = "buttonNotTransparet";
            this.buttonNotTransparent.UseVisualStyleBackColor = true;
            // 
            // buttonTransparent
            // 
            this.buttonTransparent.BackColor = System.Drawing.Color.Transparent;
            this.buttonTransparent.Location = new System.Drawing.Point(12, 24);
            this.buttonTransparent.Name = "buttonTransparent";
            this.buttonTransparent.PaintTime = System.TimeSpan.Parse("00:00:00.2900152");
            this.buttonTransparent.Size = new System.Drawing.Size(400, 200);
            this.buttonTransparent.TabIndex = 0;
            this.buttonTransparent.Text = "buttonTransparent";
            this.buttonTransparent.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "画像ファイル";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(79, 463);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(329, 19);
            this.textBoxFile.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 603);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxDoubleBuffer);
            this.Controls.Add(this.checkBoxEachInvalidate);
            this.Controls.Add(this.textBoxPaintCount);
            this.Controls.Add(this.labelNotTransparentPaintTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPaintCount);
            this.Controls.Add(this.labelTransparentPaintTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonNotTransparent);
            this.Controls.Add(this.buttonTransparent);
            this.Name = "Form1";
            this.Text = "描画時間計測";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEx buttonTransparent;
        private System.Windows.Forms.Button buttonStart;
        private ButtonEx buttonNotTransparent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTransparentPaintTime;
        private System.Windows.Forms.Label labelNotTransparentPaintTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPaintCount;
        private System.Windows.Forms.Timer timerPaint;
        private System.Windows.Forms.Label labelPaintCount;
        private System.Windows.Forms.CheckBox checkBoxEachInvalidate;
        private System.Windows.Forms.CheckBox checkBoxDoubleBuffer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFile;
    }
}

