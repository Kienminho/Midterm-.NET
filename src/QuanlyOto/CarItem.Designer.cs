namespace QuanlyOto
{
    partial class uControl_carItems
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
            lb_nameCar = new Label();
            lb_priceCar = new Label();
            lb_brand = new Label();
            panel1 = new Panel();
            panel_layout = new Panel();
            panel1.SuspendLayout();
            panel_layout.SuspendLayout();
            SuspendLayout();
            // 
            // lb_nameCar
            // 
            lb_nameCar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb_nameCar.AutoSize = true;
            lb_nameCar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_nameCar.Location = new Point(32, 10);
            lb_nameCar.Name = "lb_nameCar";
            lb_nameCar.Size = new Size(99, 20);
            lb_nameCar.TabIndex = 0;
            lb_nameCar.Text = "KIA Morning";
            lb_nameCar.TextAlign = ContentAlignment.TopCenter;
            // 
            // lb_priceCar
            // 
            lb_priceCar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb_priceCar.AutoSize = true;
            lb_priceCar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_priceCar.Location = new Point(32, 80);
            lb_priceCar.Name = "lb_priceCar";
            lb_priceCar.Size = new Size(103, 19);
            lb_priceCar.TabIndex = 1;
            lb_priceCar.Text = "1.000.000 VND";
            lb_priceCar.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lb_brand
            // 
            lb_brand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb_brand.AutoSize = true;
            lb_brand.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_brand.Location = new Point(42, 48);
            lb_brand.Name = "lb_brand";
            lb_brand.Size = new Size(47, 20);
            lb_brand.TabIndex = 2;
            lb_brand.Text = "Micro";
            lb_brand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(panel_layout);
            panel1.Location = new Point(3, 6);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 146);
            panel1.TabIndex = 3;
            // 
            // panel_layout
            // 
            panel_layout.BackColor = Color.White;
            panel_layout.Controls.Add(lb_nameCar);
            panel_layout.Controls.Add(lb_priceCar);
            panel_layout.Controls.Add(lb_brand);
            panel_layout.Location = new Point(3, 2);
            panel_layout.Margin = new Padding(3, 2, 3, 2);
            panel_layout.Name = "panel_layout";
            panel_layout.Size = new Size(138, 142);
            panel_layout.TabIndex = 0;
            panel_layout.Click += panel_layout_Click;
            // 
            // uControl_carItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "uControl_carItems";
            Size = new Size(151, 154);
            Load += Item_Load;
            panel1.ResumeLayout(false);
            panel_layout.ResumeLayout(false);
            panel_layout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lb_nameCar;
        private Label lb_priceCar;
        private Label lb_brand;
        private Panel panel1;
        private Panel panel_layout;
    }
}
