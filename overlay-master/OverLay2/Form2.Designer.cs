namespace OverLay2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingbutton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.cpulbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cpunamelbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cpupercircle = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cputempcircle = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cputemplbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.rampercircle = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.totalramlbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ramlbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ram1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ram2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ramuselbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ramfreelbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingbutton2)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bunifuCards2);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Controls.Add(this.settingbutton2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 255);
            this.panel1.TabIndex = 0;
            // 
            // settingbutton2
            // 
            this.settingbutton2.Image = ((System.Drawing.Image)(resources.GetObject("settingbutton2.Image")));
            this.settingbutton2.ImageActive = null;
            this.settingbutton2.Location = new System.Drawing.Point(164, 1);
            this.settingbutton2.Name = "settingbutton2";
            this.settingbutton2.Size = new System.Drawing.Size(27, 23);
            this.settingbutton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.settingbutton2.TabIndex = 0;
            this.settingbutton2.TabStop = false;
            this.settingbutton2.Zoom = 10;
            this.settingbutton2.Click += new System.EventHandler(this.settingbutton2_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Red;
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.Controls.Add(this.cputemplbl);
            this.bunifuCards1.Controls.Add(this.cputempcircle);
            this.bunifuCards1.Controls.Add(this.cpupercircle);
            this.bunifuCards1.Controls.Add(this.cpunamelbl);
            this.bunifuCards1.Controls.Add(this.cpulbl);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(3, 26);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(186, 112);
            this.bunifuCards1.TabIndex = 1;
            // 
            // cpulbl
            // 
            this.cpulbl.AutoSize = true;
            this.cpulbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cpulbl.ForeColor = System.Drawing.Color.White;
            this.cpulbl.Location = new System.Drawing.Point(3, 12);
            this.cpulbl.Name = "cpulbl";
            this.cpulbl.Size = new System.Drawing.Size(38, 12);
            this.cpulbl.TabIndex = 1;
            this.cpulbl.Text = "CPU:";
            // 
            // cpunamelbl
            // 
            this.cpunamelbl.AutoSize = true;
            this.cpunamelbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cpunamelbl.ForeColor = System.Drawing.Color.White;
            this.cpunamelbl.Location = new System.Drawing.Point(43, 12);
            this.cpunamelbl.Name = "cpunamelbl";
            this.cpunamelbl.Size = new System.Drawing.Size(33, 12);
            this.cpunamelbl.TabIndex = 1;
            this.cpunamelbl.Text = "Intel";
            // 
            // cpupercircle
            // 
            this.cpupercircle.animated = false;
            this.cpupercircle.animationIterval = 5;
            this.cpupercircle.animationSpeed = 300;
            this.cpupercircle.BackColor = System.Drawing.Color.Transparent;
            this.cpupercircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpupercircle.BackgroundImage")));
            this.cpupercircle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpupercircle.ForeColor = System.Drawing.Color.White;
            this.cpupercircle.LabelVisible = true;
            this.cpupercircle.LineProgressThickness = 5;
            this.cpupercircle.LineThickness = 5;
            this.cpupercircle.Location = new System.Drawing.Point(9, 22);
            this.cpupercircle.Margin = new System.Windows.Forms.Padding(0);
            this.cpupercircle.MaxValue = 100;
            this.cpupercircle.Name = "cpupercircle";
            this.cpupercircle.ProgressBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cpupercircle.ProgressColor = System.Drawing.Color.Red;
            this.cpupercircle.Size = new System.Drawing.Size(85, 85);
            this.cpupercircle.TabIndex = 2;
            this.cpupercircle.Value = 50;
            // 
            // cputempcircle
            // 
            this.cputempcircle.animated = false;
            this.cputempcircle.animationIterval = 5;
            this.cputempcircle.animationSpeed = 300;
            this.cputempcircle.BackColor = System.Drawing.Color.Transparent;
            this.cputempcircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cputempcircle.BackgroundImage")));
            this.cputempcircle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cputempcircle.ForeColor = System.Drawing.Color.White;
            this.cputempcircle.LabelVisible = false;
            this.cputempcircle.LineProgressThickness = 5;
            this.cputempcircle.LineThickness = 5;
            this.cputempcircle.Location = new System.Drawing.Point(96, 22);
            this.cputempcircle.Margin = new System.Windows.Forms.Padding(0);
            this.cputempcircle.MaxValue = 100;
            this.cputempcircle.Name = "cputempcircle";
            this.cputempcircle.ProgressBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cputempcircle.ProgressColor = System.Drawing.Color.Red;
            this.cputempcircle.Size = new System.Drawing.Size(85, 85);
            this.cputempcircle.TabIndex = 2;
            this.cputempcircle.Value = 50;
            // 
            // cputemplbl
            // 
            this.cputemplbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cputemplbl.ForeColor = System.Drawing.Color.White;
            this.cputemplbl.Location = new System.Drawing.Point(123, 61);
            this.cputemplbl.Name = "cputemplbl";
            this.cputemplbl.Size = new System.Drawing.Size(20, 12);
            this.cputemplbl.TabIndex = 1;
            this.cputemplbl.Text = "99";
            this.cputemplbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(142, 61);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(16, 12);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "℃";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Red;
            this.bunifuCards2.Controls.Add(this.rampercircle);
            this.bunifuCards2.Controls.Add(this.totalramlbl);
            this.bunifuCards2.Controls.Add(this.ram2);
            this.bunifuCards2.Controls.Add(this.ramfreelbl);
            this.bunifuCards2.Controls.Add(this.ramuselbl);
            this.bunifuCards2.Controls.Add(this.ram1);
            this.bunifuCards2.Controls.Add(this.ramlbl);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(6, 140);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(186, 112);
            this.bunifuCards2.TabIndex = 1;
            // 
            // rampercircle
            // 
            this.rampercircle.animated = false;
            this.rampercircle.animationIterval = 5;
            this.rampercircle.animationSpeed = 300;
            this.rampercircle.BackColor = System.Drawing.Color.Transparent;
            this.rampercircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rampercircle.BackgroundImage")));
            this.rampercircle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rampercircle.ForeColor = System.Drawing.Color.White;
            this.rampercircle.LabelVisible = true;
            this.rampercircle.LineProgressThickness = 5;
            this.rampercircle.LineThickness = 5;
            this.rampercircle.Location = new System.Drawing.Point(9, 22);
            this.rampercircle.Margin = new System.Windows.Forms.Padding(0);
            this.rampercircle.MaxValue = 100;
            this.rampercircle.Name = "rampercircle";
            this.rampercircle.ProgressBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rampercircle.ProgressColor = System.Drawing.Color.Red;
            this.rampercircle.Size = new System.Drawing.Size(85, 85);
            this.rampercircle.TabIndex = 2;
            this.rampercircle.Value = 50;
            // 
            // totalramlbl
            // 
            this.totalramlbl.AutoSize = true;
            this.totalramlbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalramlbl.ForeColor = System.Drawing.Color.White;
            this.totalramlbl.Location = new System.Drawing.Point(43, 12);
            this.totalramlbl.Name = "totalramlbl";
            this.totalramlbl.Size = new System.Drawing.Size(38, 12);
            this.totalramlbl.TabIndex = 1;
            this.totalramlbl.Text = "10GB";
            // 
            // ramlbl
            // 
            this.ramlbl.AutoSize = true;
            this.ramlbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ramlbl.ForeColor = System.Drawing.Color.White;
            this.ramlbl.Location = new System.Drawing.Point(3, 12);
            this.ramlbl.Name = "ramlbl";
            this.ramlbl.Size = new System.Drawing.Size(40, 12);
            this.ramlbl.TabIndex = 1;
            this.ramlbl.Text = "RAM:";
            // 
            // ram1
            // 
            this.ram1.AutoSize = true;
            this.ram1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ram1.ForeColor = System.Drawing.Color.White;
            this.ram1.Location = new System.Drawing.Point(97, 49);
            this.ram1.Name = "ram1";
            this.ram1.Size = new System.Drawing.Size(34, 12);
            this.ram1.TabIndex = 1;
            this.ram1.Text = "use:";
            // 
            // ram2
            // 
            this.ram2.AutoSize = true;
            this.ram2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ram2.ForeColor = System.Drawing.Color.White;
            this.ram2.Location = new System.Drawing.Point(97, 71);
            this.ram2.Name = "ram2";
            this.ram2.Size = new System.Drawing.Size(35, 12);
            this.ram2.TabIndex = 1;
            this.ram2.Text = "free:";
            // 
            // ramuselbl
            // 
            this.ramuselbl.AutoSize = true;
            this.ramuselbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ramuselbl.ForeColor = System.Drawing.Color.White;
            this.ramuselbl.Location = new System.Drawing.Point(132, 49);
            this.ramuselbl.Name = "ramuselbl";
            this.ramuselbl.Size = new System.Drawing.Size(31, 12);
            this.ramuselbl.TabIndex = 1;
            this.ramuselbl.Text = "4GB";
            // 
            // ramfreelbl
            // 
            this.ramfreelbl.AutoSize = true;
            this.ramfreelbl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ramfreelbl.ForeColor = System.Drawing.Color.White;
            this.ramfreelbl.Location = new System.Drawing.Point(132, 71);
            this.ramfreelbl.Name = "ramfreelbl";
            this.ramfreelbl.Size = new System.Drawing.Size(31, 12);
            this.ramfreelbl.TabIndex = 1;
            this.ramfreelbl.Text = "4GB";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 24);
            this.panel2.TabIndex = 1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(194, 257);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingbutton2)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton settingbutton2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel cpulbl;
        private Bunifu.Framework.UI.BunifuCustomLabel cpunamelbl;
        private Bunifu.Framework.UI.BunifuCustomLabel cputemplbl;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cputempcircle;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpupercircle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar rampercircle;
        private Bunifu.Framework.UI.BunifuCustomLabel totalramlbl;
        private Bunifu.Framework.UI.BunifuCustomLabel ram2;
        private Bunifu.Framework.UI.BunifuCustomLabel ramfreelbl;
        private Bunifu.Framework.UI.BunifuCustomLabel ramuselbl;
        private Bunifu.Framework.UI.BunifuCustomLabel ram1;
        private Bunifu.Framework.UI.BunifuCustomLabel ramlbl;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}