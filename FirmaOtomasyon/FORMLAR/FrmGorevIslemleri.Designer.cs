namespace FirmaOtomasyon.FORMLAR
{
    partial class FrmGorevIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGorevIslemleri));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txtGorevID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGorevGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGorevSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGorevEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtGorevAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1353, 313);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtGorevID
            // 
            this.txtGorevID.Enabled = false;
            this.txtGorevID.Location = new System.Drawing.Point(680, 91);
            this.txtGorevID.Name = "txtGorevID";
            this.txtGorevID.Size = new System.Drawing.Size(257, 20);
            this.txtGorevID.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(603, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Görev ID:";
            // 
            // btnGorevGuncelle
            // 
            this.btnGorevGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGorevGuncelle.ImageOptions.SvgImage")));
            this.btnGorevGuncelle.Location = new System.Drawing.Point(830, 172);
            this.btnGorevGuncelle.Name = "btnGorevGuncelle";
            this.btnGorevGuncelle.Size = new System.Drawing.Size(107, 38);
            this.btnGorevGuncelle.TabIndex = 4;
            this.btnGorevGuncelle.Text = "GÜNCELLE";
            this.btnGorevGuncelle.Click += new System.EventHandler(this.btnGorevGuncelle_Click);
            // 
            // btnGorevSil
            // 
            this.btnGorevSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGorevSil.ImageOptions.SvgImage")));
            this.btnGorevSil.Location = new System.Drawing.Point(717, 172);
            this.btnGorevSil.Name = "btnGorevSil";
            this.btnGorevSil.Size = new System.Drawing.Size(107, 38);
            this.btnGorevSil.TabIndex = 3;
            this.btnGorevSil.Text = "SİL";
            this.btnGorevSil.Click += new System.EventHandler(this.btnGorevSil_Click);
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGorevEkle.ImageOptions.SvgImage")));
            this.btnGorevEkle.Location = new System.Drawing.Point(604, 172);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(107, 38);
            this.btnGorevEkle.TabIndex = 2;
            this.btnGorevEkle.Text = "EKLE";
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // txtGorevAd
            // 
            this.txtGorevAd.Location = new System.Drawing.Point(680, 119);
            this.txtGorevAd.Name = "txtGorevAd";
            this.txtGorevAd.Size = new System.Drawing.Size(257, 20);
            this.txtGorevAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(603, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Görev Adı:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Controls.Add(this.txtGorevID);
            this.panel1.Controls.Add(this.btnGorevSil);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtGorevAd);
            this.panel1.Controls.Add(this.btnGorevGuncelle);
            this.panel1.Controls.Add(this.btnGorevEkle);
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 285);
            this.panel1.TabIndex = 6;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(413, 83);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAcceleration = 2D;
            this.pictureEdit1.Properties.ZoomPercent = 25D;
            this.pictureEdit1.Size = new System.Drawing.Size(150, 127);
            this.pictureEdit1.TabIndex = 7;
            // 
            // FrmGorevIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmGorevIslemleri";
            this.Text = "Görev İşlemleri";
            this.Load += new System.EventHandler(this.FrmGorevIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.TextBox txtGorevID;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnGorevGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnGorevSil;
        private DevExpress.XtraEditors.SimpleButton btnGorevEkle;
        private System.Windows.Forms.TextBox txtGorevAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}