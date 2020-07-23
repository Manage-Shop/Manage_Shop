namespace Manage_Shop
{
    partial class TrangChuUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hoaDonTableAdapter1 = new Manage_Shop.Database1DataSetTableAdapters.HoaDonTableAdapter();
            this.tableAdapterManager1 = new Manage_Shop.Database1DataSetTableAdapters.TableAdapterManager();
            this.hoaDonTableAdapter2 = new Manage_Shop.Database1DataSetTableAdapters.HoaDonTableAdapter();
            this.SuspendLayout();
            // 
            // hoaDonTableAdapter1
            // 
            this.hoaDonTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.HoaDonTableAdapter = this.hoaDonTableAdapter1;
            this.tableAdapterManager1.NhanVienTableAdapter = null;
            this.tableAdapterManager1.SanPhamTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Manage_Shop.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hoaDonTableAdapter2
            // 
            this.hoaDonTableAdapter2.ClearBeforeFill = true;
            // 
            // TrangChuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TrangChuUC";
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter1;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private Database1DataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter2;
    }
}
