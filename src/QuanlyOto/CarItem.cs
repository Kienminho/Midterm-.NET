using QuanlyOto.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyOto
{
    public partial class uControl_carItems : UserControl
    {
        public uControl_carItems()
        {
            InitializeComponent();
        }



        #region Properties
        private Guid _id;
        private String _nameCar;
        private String _brandCar;
        private double _price;
        private void Item_Load(object sender, EventArgs e)
        {
            panel_layout.Click += new System.EventHandler((object sender, EventArgs e) => this.OnClick(e));
        }

        private void panel_layout_Click(object sender, EventArgs e)
        {

        }

        public Guid id
        {
            get { return _id; }
            set { _id = value; }
        }
        public String nameCar
        {
            get { return _nameCar; }
            set { _nameCar = value; lb_nameCar.Text = value; }
        }
        public String brandCar
        {
            get { return _brandCar; }
            set { _brandCar = value; lb_brand.Text = value; }
        }
        public double price
        {
            get { return _price; }
            set { _price = value; lb_priceCar.Text = Commons.formatStringVietNammes(value); }
        }
        #endregion
    }
}
