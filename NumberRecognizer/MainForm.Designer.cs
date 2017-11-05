namespace NumberRecognizer
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbDigit = new System.Windows.Forms.PictureBox();
            this.lDigit = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bRecognize = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bLearning = new System.Windows.Forms.Button();
            this.bForget = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDigit)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pbDigit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lDigit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbDigit
            // 
            this.pbDigit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDigit.Location = new System.Drawing.Point(3, 3);
            this.pbDigit.Name = "pbDigit";
            this.pbDigit.Size = new System.Drawing.Size(455, 169);
            this.pbDigit.TabIndex = 0;
            this.pbDigit.TabStop = false;
            // 
            // lDigit
            // 
            this.lDigit.AutoSize = true;
            this.lDigit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDigit.Location = new System.Drawing.Point(3, 175);
            this.lDigit.Name = "lDigit";
            this.lDigit.Size = new System.Drawing.Size(455, 175);
            this.lDigit.TabIndex = 1;
            this.lDigit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.bForget, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.bRecognize, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bClear, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bLearning, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(464, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 344);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // bRecognize
            // 
            this.bRecognize.AutoSize = true;
            this.bRecognize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bRecognize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRecognize.Location = new System.Drawing.Point(3, 23);
            this.bRecognize.Name = "bRecognize";
            this.bRecognize.Size = new System.Drawing.Size(194, 23);
            this.bRecognize.TabIndex = 0;
            this.bRecognize.Text = "Recognize";
            this.bRecognize.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.AutoSize = true;
            this.bClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bClear.Location = new System.Drawing.Point(3, 52);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(194, 23);
            this.bClear.TabIndex = 1;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            // 
            // bLearning
            // 
            this.bLearning.AutoSize = true;
            this.bLearning.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bLearning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLearning.Location = new System.Drawing.Point(3, 101);
            this.bLearning.Name = "bLearning";
            this.bLearning.Size = new System.Drawing.Size(194, 23);
            this.bLearning.TabIndex = 2;
            this.bLearning.Text = "Learning";
            this.bLearning.UseVisualStyleBackColor = true;
            this.bLearning.Click += new System.EventHandler(this.BLearning_Click);
            // 
            // bForget
            // 
            this.bForget.AutoSize = true;
            this.bForget.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bForget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bForget.Location = new System.Drawing.Point(3, 130);
            this.bForget.Name = "bForget";
            this.bForget.Size = new System.Drawing.Size(194, 23);
            this.bForget.TabIndex = 3;
            this.bForget.Text = "Forget knowledges";
            this.bForget.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 350);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Number recognizer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDigit)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbDigit;
        private System.Windows.Forms.Label lDigit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bRecognize;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bForget;
        private System.Windows.Forms.Button bLearning;
    }
}

