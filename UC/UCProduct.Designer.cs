namespace GiaoDien.UC
{
    partial class UCProduct
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.itemsView1 = new DevExpress.XtraGrid.Views.Items.ItemsView();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.itemsView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(604, 483);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.itemsView1,
            this.tileView1,
            this.cardView1,
            this.winExplorerView1,
            this.gridView1});
            // 
            // itemsView1
            // 
            this.itemsView1.GridControl = this.gridControl1;
            this.itemsView1.Name = "itemsView1";
            // 
            // tileView1
            // 
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // winExplorerView1
            // 
            this.winExplorerView1.GridControl = this.gridControl1;
            this.winExplorerView1.Name = "winExplorerView1";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(604, 483);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Items.ItemsView itemsView1;
    }
}
