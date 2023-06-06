namespace ProjectCalculator
{
    partial class formHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHistory));
            this.cmDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lvHistory = new System.Windows.Forms.ListView();
            this.chCalc = new System.Windows.Forms.ColumnHeader();
            this.chResult = new System.Windows.Forms.ColumnHeader();
            this.cmDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmDelete
            // 
            this.cmDelete.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuDelete});
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.Size = new System.Drawing.Size(138, 36);
            // 
            // tsmenuDelete
            // 
            this.tsmenuDelete.Name = "tsmenuDelete";
            this.tsmenuDelete.Size = new System.Drawing.Size(137, 32);
            this.tsmenuDelete.Text = "Delete";
            this.tsmenuDelete.Click += new System.EventHandler(this.tsmenuDelete_Click);
            // 
            // lvHistory
            // 
            this.lvHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCalc,
            this.chResult});
            this.lvHistory.ContextMenuStrip = this.cmDelete;
            this.lvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHistory.FullRowSelect = true;
            this.lvHistory.GridLines = true;
            this.lvHistory.Location = new System.Drawing.Point(0, 0);
            this.lvHistory.Name = "lvHistory";
            this.lvHistory.Size = new System.Drawing.Size(800, 450);
            this.lvHistory.TabIndex = 1;
            this.lvHistory.UseCompatibleStateImageBehavior = false;
            this.lvHistory.View = System.Windows.Forms.View.Details;
            this.lvHistory.DoubleClick += new System.EventHandler(this.lvHistory_DoubleClick);
            // 
            // chCalc
            // 
            this.chCalc.Text = "수식";
            this.chCalc.Width = 600;
            // 
            // chResult
            // 
            this.chResult.Text = "결과";
            this.chResult.Width = 200;
            // 
            // formHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History";
            this.Load += new System.EventHandler(this.formHistory_Load);
            this.cmDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip cmDelete;
        private ToolStripMenuItem tsmenuDelete;
        private ListView lvHistory;
        private ColumnHeader chCalc;
        private ColumnHeader chResult;
    }
}