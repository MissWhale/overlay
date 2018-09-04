namespace OverLay2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Panel();
            this.settingbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ramperlbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cpuperlbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ramlbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cpulbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl5 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl6 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl7 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.header.Controls.Add(this.settingbutton);
            this.header.Controls.Add(this.bunifuCustomLabel2);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Controls.Add(this.ramperlbl);
            this.header.Controls.Add(this.cpuperlbl);
            this.header.Controls.Add(this.ramlbl);
            this.header.Controls.Add(this.cpulbl);
            this.header.Location = new System.Drawing.Point(1, 1);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(192, 24);
            this.header.TabIndex = 1;
            // 
            // settingbutton
            // 
            this.settingbutton.Image = ((System.Drawing.Image)(resources.GetObject("settingbutton.Image")));
            this.settingbutton.ImageActive = null;
            this.settingbutton.Location = new System.Drawing.Point(164, 1);
            this.settingbutton.Name = "settingbutton";
            this.settingbutton.Size = new System.Drawing.Size(27, 23);
            this.settingbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.settingbutton.TabIndex = 1;
            this.settingbutton.TabStop = false;
            this.settingbutton.Zoom = 10;
            this.settingbutton.Click += new System.EventHandler(this.settingbutton_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(68, 7);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(16, 12);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "%";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(148, 7);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(16, 12);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "%";
            // 
            // ramperlbl
            // 
            this.ramperlbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ramperlbl.ForeColor = System.Drawing.Color.White;
            this.ramperlbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ramperlbl.Location = new System.Drawing.Point(125, 7);
            this.ramperlbl.Name = "ramperlbl";
            this.ramperlbl.Size = new System.Drawing.Size(26, 12);
            this.ramperlbl.TabIndex = 0;
            this.ramperlbl.Text = "100";
            this.ramperlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuperlbl
            // 
            this.cpuperlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuperlbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cpuperlbl.ForeColor = System.Drawing.Color.White;
            this.cpuperlbl.Location = new System.Drawing.Point(43, 7);
            this.cpuperlbl.Name = "cpuperlbl";
            this.cpuperlbl.Size = new System.Drawing.Size(28, 10);
            this.cpuperlbl.TabIndex = 100;
            this.cpuperlbl.Text = "100";
            this.cpuperlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ramlbl
            // 
            this.ramlbl.AutoSize = true;
            this.ramlbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ramlbl.ForeColor = System.Drawing.Color.White;
            this.ramlbl.Location = new System.Drawing.Point(84, 7);
            this.ramlbl.Name = "ramlbl";
            this.ramlbl.Size = new System.Drawing.Size(40, 12);
            this.ramlbl.TabIndex = 0;
            this.ramlbl.Text = "RAM:";
            // 
            // cpulbl
            // 
            this.cpulbl.AutoSize = true;
            this.cpulbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cpulbl.ForeColor = System.Drawing.Color.White;
            this.cpulbl.Location = new System.Drawing.Point(5, 7);
            this.cpulbl.Name = "cpulbl";
            this.cpulbl.Size = new System.Drawing.Size(38, 12);
            this.cpulbl.TabIndex = 0;
            this.cpulbl.Text = "CPU:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.cpulbl;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.cpuperlbl;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = this.ramlbl;
            this.bunifuDragControl4.Vertical = true;
            // 
            // bunifuDragControl5
            // 
            this.bunifuDragControl5.Fixed = true;
            this.bunifuDragControl5.Horizontal = true;
            this.bunifuDragControl5.TargetControl = this.ramperlbl;
            this.bunifuDragControl5.Vertical = true;
            // 
            // bunifuDragControl6
            // 
            this.bunifuDragControl6.Fixed = true;
            this.bunifuDragControl6.Horizontal = true;
            this.bunifuDragControl6.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl6.Vertical = true;
            // 
            // bunifuDragControl7
            // 
            this.bunifuDragControl7.Fixed = true;
            this.bunifuDragControl7.Horizontal = true;
            this.bunifuDragControl7.TargetControl = this.bunifuCustomLabel2;
            this.bunifuDragControl7.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(194, 26);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingbutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel ramperlbl;
        private Bunifu.Framework.UI.BunifuCustomLabel cpuperlbl;
        private Bunifu.Framework.UI.BunifuCustomLabel ramlbl;
        private Bunifu.Framework.UI.BunifuCustomLabel cpulbl;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl6;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl7;
        private Bunifu.Framework.UI.BunifuImageButton settingbutton;
    }
}

