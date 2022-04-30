
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pendCeiling = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pendBall = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.pendBar = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBar = new System.Windows.Forms.TextBox();
            this.txtDeg = new System.Windows.Forms.TextBox();
            this.trkBar = new System.Windows.Forms.TrackBar();
            this.trkDeg = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trkBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkDeg)).BeginInit();
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
            this.shapeContainer1.Size = new System.Drawing.Size(577, 362);
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
            this.pendBall.Location = new System.Drawing.Point(201, 167);
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
            this.btnStart.Location = new System.Drawing.Point(353, 154);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBar
            // 
            this.txtBar.Location = new System.Drawing.Point(353, 59);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(75, 21);
            this.txtBar.TabIndex = 2;
            this.txtBar.Text = "200";
            this.txtBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeg
            // 
            this.txtDeg.Location = new System.Drawing.Point(353, 97);
            this.txtDeg.Name = "txtDeg";
            this.txtDeg.Size = new System.Drawing.Size(75, 21);
            this.txtDeg.TabIndex = 3;
            this.txtDeg.Text = "30";
            this.txtDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkBar
            // 
            this.trkBar.Location = new System.Drawing.Point(451, 53);
            this.trkBar.Maximum = 300;
            this.trkBar.Name = "trkBar";
            this.trkBar.Size = new System.Drawing.Size(104, 45);
            this.trkBar.TabIndex = 4;
            this.trkBar.Value = 200;
            this.trkBar.Scroll += new System.EventHandler(this.trkBar_Scroll);
            // 
            // trkDeg
            // 
            this.trkDeg.Location = new System.Drawing.Point(451, 97);
            this.trkDeg.Maximum = 60;
            this.trkDeg.Minimum = -60;
            this.trkDeg.Name = "trkDeg";
            this.trkDeg.Size = new System.Drawing.Size(104, 45);
            this.trkDeg.TabIndex = 5;
            this.trkDeg.Value = 30;
            this.trkDeg.Scroll += new System.EventHandler(this.trkDeg_Scroll);
            // 
            // frmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 362);
            this.Controls.Add(this.trkDeg);
            this.Controls.Add(this.trkBar);
            this.Controls.Add(this.txtDeg);
            this.Controls.Add(this.txtBar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frmPendu";
            this.Text = "PenduSim V1.0";
            this.Load += new System.EventHandler(this.frmPendu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPendu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPendu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmPendu_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trkBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkDeg)).EndInit();
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
    }
}

