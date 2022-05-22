namespace PenduSim
{
    partial class frmPendu
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tboxBar = new System.Windows.Forms.TextBox();
            this.tboxDeg = new System.Windows.Forms.TextBox();
            this.lblDeg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTick = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lblEk = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEp = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.ovalShape1,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1021, 530);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
            this.rectangleShape1.Location = new System.Drawing.Point(77, 50);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(280, 19);
            // 
            // ovalShape1
            // 
            this.ovalShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central;
            this.ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape1.Location = new System.Drawing.Point(230, 276);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(45, 45);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 221;
            this.lineShape1.X2 = 250;
            this.lineShape1.Y1 = 69;
            this.lineShape1.Y2 = 291;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(746, 431);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(96, 66);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tboxBar
            // 
            this.tboxBar.Location = new System.Drawing.Point(759, 82);
            this.tboxBar.Margin = new System.Windows.Forms.Padding(2);
            this.tboxBar.Name = "tboxBar";
            this.tboxBar.Size = new System.Drawing.Size(60, 25);
            this.tboxBar.TabIndex = 2;
            this.tboxBar.Text = "2.0";
            this.tboxBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxBar.TextChanged += new System.EventHandler(this.tboxBar_TextChanged);
            // 
            // tboxDeg
            // 
            this.tboxDeg.Location = new System.Drawing.Point(758, 125);
            this.tboxDeg.Margin = new System.Windows.Forms.Padding(2);
            this.tboxDeg.Name = "tboxDeg";
            this.tboxDeg.Size = new System.Drawing.Size(61, 25);
            this.tboxDeg.TabIndex = 3;
            this.tboxDeg.Text = "45.0";
            this.tboxDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxDeg.TextChanged += new System.EventHandler(this.tboxDeg_TextChanged);
            // 
            // lblDeg
            // 
            this.lblDeg.AutoSize = true;
            this.lblDeg.Location = new System.Drawing.Point(792, 276);
            this.lblDeg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeg.Name = "lblDeg";
            this.lblDeg.Size = new System.Drawing.Size(15, 15);
            this.lblDeg.TabIndex = 5;
            this.lblDeg.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.Location = new System.Drawing.Point(792, 316);
            this.lblTick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(15, 15);
            this.lblTick.TabIndex = 7;
            this.lblTick.Text = "0";
            this.lblTick.Click += new System.EventHandler(this.lblTick_Click);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(792, 356);
            this.lblT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(15, 15);
            this.lblT.TabIndex = 8;
            this.lblT.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "줄의 길이(m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "초기각도";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "경과 시간";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 66);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "실시간 각도 변화";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(927, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 25);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "9.8";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(843, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "중력 가속도";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(927, 120);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 25);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "0.264";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(831, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "추의 질량(kg)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(927, 168);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 25);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "0.0323";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(862, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "공기저항";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(720, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "주기";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(873, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "속력";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Location = new System.Drawing.Point(937, 276);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(15, 15);
            this.lblV.TabIndex = 23;
            this.lblV.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(859, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "가속도";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(937, 308);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(15, 15);
            this.lbla.TabIndex = 25;
            this.lbla.Text = "0";
            // 
            // lblEk
            // 
            this.lblEk.AutoSize = true;
            this.lblEk.Location = new System.Drawing.Point(937, 356);
            this.lblEk.Name = "lblEk";
            this.lblEk.Size = new System.Drawing.Size(15, 15);
            this.lblEk.TabIndex = 26;
            this.lblEk.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(832, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "운동에너지";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(117, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(277, 42);
            this.label12.TabIndex = 28;
            this.label12.Text = "Pendlum Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Variable Setup";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(674, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 36);
            this.label14.TabIndex = 30;
            this.label14.Text = "Pendlum Information";
            // 
            // lblEp
            // 
            this.lblEp.AutoSize = true;
            this.lblEp.Location = new System.Drawing.Point(793, 401);
            this.lblEp.Name = "lblEp";
            this.lblEp.Size = new System.Drawing.Size(15, 15);
            this.lblEp.TabIndex = 31;
            this.lblEp.Text = "0";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(937, 401);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(15, 15);
            this.lblSum.TabIndex = 32;
            this.lblSum.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(679, 401);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "위치에너지";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(832, 401);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "전체에너지";
            // 
            // frmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 530);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblEp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblEk);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblTick);
            this.Controls.Add(this.lblDeg);
            this.Controls.Add(this.tboxDeg);
            this.Controls.Add(this.tboxBar);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPendu";
            this.Text = "Pendulum Simulator";
            this.Load += new System.EventHandler(this.frmPendu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPendu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPendu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmPendu_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox tboxBar;
        private System.Windows.Forms.TextBox tboxDeg;
        private System.Windows.Forms.Label lblDeg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTick;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblEk;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEp;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

