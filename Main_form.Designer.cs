namespace DynamicTimeWarping
{
    partial class Main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.Show_Graph1 = new System.Windows.Forms.Panel();
            this.Show_Graph2 = new System.Windows.Forms.Panel();
            this.Generate = new System.Windows.Forms.Button();
            this.Process = new System.Windows.Forms.Button();
            this.Result_Graph = new System.Windows.Forms.Panel();
            this.Statement_line = new System.Windows.Forms.TextBox();
            this.Resultbox = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.Size_1 = new System.Windows.Forms.TextBox();
            this.size1 = new System.Windows.Forms.Label();
            this.limit1 = new System.Windows.Forms.Label();
            this.Limit_1 = new System.Windows.Forms.TextBox();
            this.Size2 = new System.Windows.Forms.Label();
            this.Size_2 = new System.Windows.Forms.TextBox();
            this.Limit2 = new System.Windows.Forms.Label();
            this.Limit_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Show_Graph1
            // 
            this.Show_Graph1.BackColor = System.Drawing.Color.White;
            this.Show_Graph1.Location = new System.Drawing.Point(12, 519);
            this.Show_Graph1.Name = "Show_Graph1";
            this.Show_Graph1.Size = new System.Drawing.Size(450, 101);
            this.Show_Graph1.TabIndex = 0;
            // 
            // Show_Graph2
            // 
            this.Show_Graph2.BackColor = System.Drawing.Color.White;
            this.Show_Graph2.Location = new System.Drawing.Point(468, 63);
            this.Show_Graph2.Name = "Show_Graph2";
            this.Show_Graph2.Size = new System.Drawing.Size(101, 450);
            this.Show_Graph2.TabIndex = 1;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(472, 12);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(94, 21);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(472, 39);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(94, 21);
            this.Process.TabIndex = 2;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // Result_Graph
            // 
            this.Result_Graph.BackColor = System.Drawing.Color.White;
            this.Result_Graph.Location = new System.Drawing.Point(12, 63);
            this.Result_Graph.Name = "Result_Graph";
            this.Result_Graph.Size = new System.Drawing.Size(450, 450);
            this.Result_Graph.TabIndex = 2;
            // 
            // Statement_line
            // 
            this.Statement_line.BackColor = System.Drawing.Color.White;
            this.Statement_line.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Statement_line.Enabled = false;
            this.Statement_line.ForeColor = System.Drawing.Color.Black;
            this.Statement_line.Location = new System.Drawing.Point(12, 12);
            this.Statement_line.Name = "Statement_line";
            this.Statement_line.Size = new System.Drawing.Size(450, 21);
            this.Statement_line.TabIndex = 3;
            this.Statement_line.Text = "Input each graph information";
            this.Statement_line.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Resultbox
            // 
            this.Resultbox.BackColor = System.Drawing.Color.White;
            this.Resultbox.Enabled = false;
            this.Resultbox.Font = new System.Drawing.Font("굴림", 25F);
            this.Resultbox.ForeColor = System.Drawing.Color.Black;
            this.Resultbox.Location = new System.Drawing.Point(468, 573);
            this.Resultbox.Name = "Resultbox";
            this.Resultbox.Size = new System.Drawing.Size(98, 46);
            this.Resultbox.TabIndex = 4;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result.Location = new System.Drawing.Point(481, 533);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(73, 24);
            this.Result.TabIndex = 5;
            this.Result.Text = "Result";
            // 
            // Size_1
            // 
            this.Size_1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Size_1.Location = new System.Drawing.Point(59, 39);
            this.Size_1.MaxLength = 2;
            this.Size_1.Name = "Size_1";
            this.Size_1.Size = new System.Drawing.Size(60, 21);
            this.Size_1.TabIndex = 6;
            this.Size_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Size_1_KeyPress);
            // 
            // size1
            // 
            this.size1.AutoSize = true;
            this.size1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.size1.Location = new System.Drawing.Point(12, 44);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(41, 13);
            this.size1.TabIndex = 8;
            this.size1.Text = "Size1";
            // 
            // limit1
            // 
            this.limit1.AutoSize = true;
            this.limit1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.limit1.Location = new System.Drawing.Point(125, 44);
            this.limit1.Name = "limit1";
            this.limit1.Size = new System.Drawing.Size(41, 13);
            this.limit1.TabIndex = 10;
            this.limit1.Text = "Limit1";
            // 
            // Limit_1
            // 
            this.Limit_1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Limit_1.Location = new System.Drawing.Point(172, 39);
            this.Limit_1.MaxLength = 3;
            this.Limit_1.Name = "Limit_1";
            this.Limit_1.Size = new System.Drawing.Size(60, 21);
            this.Limit_1.TabIndex = 9;
            this.Limit_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Limit_1_KeyPress);
            // 
            // Size2
            // 
            this.Size2.AutoSize = true;
            this.Size2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Size2.Location = new System.Drawing.Point(238, 44);
            this.Size2.Name = "Size2";
            this.Size2.Size = new System.Drawing.Size(41, 13);
            this.Size2.TabIndex = 12;
            this.Size2.Text = "Size2";
            // 
            // Size_2
            // 
            this.Size_2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Size_2.Location = new System.Drawing.Point(285, 39);
            this.Size_2.MaxLength = 2;
            this.Size_2.Name = "Size_2";
            this.Size_2.Size = new System.Drawing.Size(60, 21);
            this.Size_2.TabIndex = 11;
            this.Size_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Size_2_KeyPress);
            // 
            // Limit2
            // 
            this.Limit2.AutoSize = true;
            this.Limit2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Limit2.Location = new System.Drawing.Point(355, 44);
            this.Limit2.Name = "Limit2";
            this.Limit2.Size = new System.Drawing.Size(41, 13);
            this.Limit2.TabIndex = 14;
            this.Limit2.Text = "Limit2";
            // 
            // Limit_2
            // 
            this.Limit_2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Limit_2.Location = new System.Drawing.Point(402, 39);
            this.Limit_2.MaxLength = 3;
            this.Limit_2.Name = "Limit_2";
            this.Limit_2.Size = new System.Drawing.Size(60, 21);
            this.Limit_2.TabIndex = 13;
            this.Limit_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Limit_2_KeyPress);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 637);
            this.Controls.Add(this.Limit2);
            this.Controls.Add(this.Limit_2);
            this.Controls.Add(this.Size2);
            this.Controls.Add(this.Size_2);
            this.Controls.Add(this.limit1);
            this.Controls.Add(this.Limit_1);
            this.Controls.Add(this.size1);
            this.Controls.Add(this.Size_1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Resultbox);
            this.Controls.Add(this.Statement_line);
            this.Controls.Add(this.Result_Graph);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Show_Graph2);
            this.Controls.Add(this.Show_Graph1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_form";
            this.Text = "Dynamic Time Wraping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Show_Graph1;
        private System.Windows.Forms.Panel Show_Graph2;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Panel Result_Graph;
        private System.Windows.Forms.TextBox Statement_line;
        private System.Windows.Forms.TextBox Resultbox;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox Size_1;
        private System.Windows.Forms.Label size1;
        private System.Windows.Forms.Label limit1;
        private System.Windows.Forms.TextBox Limit_1;
        private System.Windows.Forms.Label Size2;
        private System.Windows.Forms.TextBox Size_2;
        private System.Windows.Forms.Label Limit2;
        private System.Windows.Forms.TextBox Limit_2;
    }
}

