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
            SuspendLayout();
            // 
            // lb_nameCar
            // 
            lb_nameCar.AutoSize = true;
            lb_nameCar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_nameCar.Location = new Point(22, 22);
            lb_nameCar.Name = "lb_nameCar";
            lb_nameCar.Size = new Size(121, 25);
            lb_nameCar.TabIndex = 0;
            lb_nameCar.Text = "KIA Morning";
            // 
            // lb_priceCar
            // 
            lb_priceCar.AutoSize = true;
            lb_priceCar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_priceCar.Location = new Point(22, 110);
            lb_priceCar.Name = "lb_priceCar";
            lb_priceCar.Size = new Size(120, 23);
            lb_priceCar.TabIndex = 1;
            lb_priceCar.Text = "1.000.000 VND";
            // 
            // lb_brand
            // 
            lb_brand.AutoSize = true;
            lb_brand.Location = new Point(51, 69);
            lb_brand.Name = "lb_brand";
            lb_brand.Size = new Size(47, 20);
            lb_brand.TabIndex = 2;
            lb_brand.Text = "Micro";
            // 
            // uControl_carItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb_brand);
            Controls.Add(lb_priceCar);
            Controls.Add(lb_nameCar);
            Name = "uControl_carItems";
            Size = new Size(164, 195);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_nameCar;
        private Label lb_priceCar;
        private Label lb_brand;
    }
}
