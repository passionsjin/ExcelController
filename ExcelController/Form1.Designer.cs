
namespace ExcelController
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exCloseBtn = new System.Windows.Forms.Button();
            this.exOpenBtn = new System.Windows.Forms.Button();
            this.exWriteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(30, 188);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(34, 12);
            this.time_label.TabIndex = 5;
            this.time_label.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exCloseBtn
            // 
            this.exCloseBtn.Location = new System.Drawing.Point(372, 341);
            this.exCloseBtn.Name = "exCloseBtn";
            this.exCloseBtn.Size = new System.Drawing.Size(75, 23);
            this.exCloseBtn.TabIndex = 6;
            this.exCloseBtn.Text = "close";
            this.exCloseBtn.UseVisualStyleBackColor = true;
            this.exCloseBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // exOpenBtn
            // 
            this.exOpenBtn.Location = new System.Drawing.Point(372, 310);
            this.exOpenBtn.Name = "exOpenBtn";
            this.exOpenBtn.Size = new System.Drawing.Size(75, 23);
            this.exOpenBtn.TabIndex = 7;
            this.exOpenBtn.Text = "open";
            this.exOpenBtn.UseVisualStyleBackColor = true;
            this.exOpenBtn.Click += new System.EventHandler(this.exOpenBtn_Click);
            // 
            // exWriteBtn
            // 
            this.exWriteBtn.Location = new System.Drawing.Point(474, 310);
            this.exWriteBtn.Name = "exWriteBtn";
            this.exWriteBtn.Size = new System.Drawing.Size(75, 23);
            this.exWriteBtn.TabIndex = 8;
            this.exWriteBtn.Text = "Write";
            this.exWriteBtn.UseVisualStyleBackColor = true;
            this.exWriteBtn.Click += new System.EventHandler(this.exWriteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exWriteBtn);
            this.Controls.Add(this.exOpenBtn);
            this.Controls.Add(this.exCloseBtn);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exCloseBtn;
        private System.Windows.Forms.Button exOpenBtn;
        private System.Windows.Forms.Button exWriteBtn;
    }
}

