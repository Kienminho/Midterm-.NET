namespace QuanlyOto
{
    partial class ChartForm
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
            plotView_SalesByMonth = new OxyPlot.WindowsForms.PlotView();
            plotViewCarsSoldByType = new OxyPlot.WindowsForms.PlotView();
            SuspendLayout();
            // 
            // plotView_SalesByMonth
            // 
            plotView_SalesByMonth.BackColor = Color.White;
            plotView_SalesByMonth.Dock = DockStyle.Left;
            plotView_SalesByMonth.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            plotView_SalesByMonth.Location = new Point(0, 0);
            plotView_SalesByMonth.Name = "plotView_SalesByMonth";
            plotView_SalesByMonth.PanCursor = Cursors.Hand;
            plotView_SalesByMonth.Size = new Size(716, 575);
            plotView_SalesByMonth.TabIndex = 0;
            plotView_SalesByMonth.Text = "plotView1";
            plotView_SalesByMonth.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView_SalesByMonth.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView_SalesByMonth.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewCarsSoldByType
            // 
            plotViewCarsSoldByType.BackColor = SystemColors.ActiveCaption;
            plotViewCarsSoldByType.Dock = DockStyle.Right;
            plotViewCarsSoldByType.Location = new Point(722, 0);
            plotViewCarsSoldByType.Name = "plotViewCarsSoldByType";
            plotViewCarsSoldByType.PanCursor = Cursors.Hand;
            plotViewCarsSoldByType.Size = new Size(536, 575);
            plotViewCarsSoldByType.TabIndex = 1;
            plotViewCarsSoldByType.Text = "plotView2";
            plotViewCarsSoldByType.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewCarsSoldByType.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewCarsSoldByType.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1258, 575);
            Controls.Add(plotViewCarsSoldByType);
            Controls.Add(plotView_SalesByMonth);
            Name = "ChartForm";
            Text = "ChartForm";
            Load += ChartForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView_SalesByMonth;
        private OxyPlot.WindowsForms.PlotView plotViewCarsSoldByType;
    }
}