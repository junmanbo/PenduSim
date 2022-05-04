
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
            this.pendCeiling = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pendBall = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.pendBar = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBar = new System.Windows.Forms.TextBox();
            this.txtDeg = new System.Windows.Forms.TextBox();
            this.trkBar = new System.Windows.Forms.TrackBar();
            this.trkDeg = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.trkVC = new System.Windows.Forms.TrackBar();
            this.txtVC = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkDeg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVC)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.pendCeiling,
            this.pendBall,
            this.pendBar});
            this.shapeContainer1.Size = new System.Drawing.Size(584, 311);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // pendCeiling
            // 
            this.pendCeiling.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.ForwardDiagonal;
            this.pendCeiling.Location = new System.Drawing.Point(46, 33);
            this.pendCeiling.Name = "pendCeiling";
            this.pendCeiling.Size = new System.Drawing.Size(203, 11);
            // 
            // pendBall
            // 
            this.pendBall.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central;
            this.pendBall.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.pendBall.Location = new System.Drawing.Point(86, 162);
            this.pendBall.Name = "pendBall";
            this.pendBall.Size = new System.Drawing.Size(45, 45);
            // 
            // pendBar
            // 
            this.pendBar.BorderWidth = 3;
            this.pendBar.Name = "pendBar";
            this.pendBar.X1 = 177;
            this.pendBar.X2 = 224;
            this.pendBar.Y1 = 53;
            this.pendBar.Y2 = 189;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(480, 248);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 61);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBar
            // 
            this.txtBar.Location = new System.Drawing.Point(13, 9);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(75, 21);
            this.txtBar.TabIndex = 2;
            this.txtBar.Text = "200";
            this.txtBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeg
            // 
            this.txtDeg.Location = new System.Drawing.Point(13, 61);
            this.txtDeg.Name = "txtDeg";
            this.txtDeg.Size = new System.Drawing.Size(75, 21);
            this.txtDeg.TabIndex = 3;
            this.txtDeg.Text = "30";
            this.txtDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkBar
            // 
            this.trkBar.Location = new System.Drawing.Point(111, 3);
            this.trkBar.Maximum = 300;
            this.trkBar.Name = "trkBar";
            this.trkBar.Size = new System.Drawing.Size(104, 45);
            this.trkBar.TabIndex = 4;
            this.trkBar.Value = 200;
            this.trkBar.Scroll += new System.EventHandler(this.trkBar_Scroll);
            // 
            // trkDeg
            // 
            this.trkDeg.Location = new System.Drawing.Point(111, 54);
            this.trkDeg.Maximum = 60;
            this.trkDeg.Minimum = -60;
            this.trkDeg.Name = "trkDeg";
            this.trkDeg.Size = new System.Drawing.Size(104, 45);
            this.trkDeg.TabIndex = 5;
            this.trkDeg.Value = 30;
            this.trkDeg.Scroll += new System.EventHandler(this.trkDeg_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trkVC);
            this.panel1.Controls.Add(this.txtVC);
            this.panel1.Controls.Add(this.trkBar);
            this.panel1.Controls.Add(this.trkDeg);
            this.panel1.Controls.Add(this.txtBar);
            this.panel1.Controls.Add(this.txtDeg);
            this.panel1.Location = new System.Drawing.Point(340, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 163);
            this.panel1.TabIndex = 6;
            // 
            // trkVC
            // 
            this.trkVC.Location = new System.Drawing.Point(111, 105);
            this.trkVC.Maximum = 999;
            this.trkVC.Name = "trkVC";
            this.trkVC.Size = new System.Drawing.Size(104, 45);
            this.trkVC.TabIndex = 7;
            this.trkVC.Value = 30;
            this.trkVC.Scroll += new System.EventHandler(this.trkVC_Scroll);
            // 
            // txtVC
            // 
            this.txtVC.Location = new System.Drawing.Point(13, 115);
            this.txtVC.Name = "txtVC";
            this.txtVC.Size = new System.Drawing.Size(75, 21);
            this.txtVC.TabIndex = 6;
            this.txtVC.Text = "0";
            this.txtVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(480, 218);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 24);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "0";
            // 
            // frmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frmPendu";
            this.Text = "PenduSim V2.0";
            this.Load += new System.EventHandler(this.frmPendu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPendu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPendu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmPendu_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trkBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkDeg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape pendCeiling;
        private Microsoft.VisualBasic.PowerPacks.OvalShape pendBall;
        private Microsoft.VisualBasic.PowerPacks.LineShape pendBar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtBar;
        private System.Windows.Forms.TextBox txtDeg;
        private System.Windows.Forms.TrackBar trkBar;
        private System.Windows.Forms.TrackBar trkDeg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TrackBar trkVC;
        private System.Windows.Forms.TextBox txtVC;
        private System.Windows.Forms.Label label1;
    }
}

