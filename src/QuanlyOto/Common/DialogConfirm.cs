using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyOto.Common
{
    public class DialogConfirm
    {
        //delete
        public static DialogResult ConfirmDelete()
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xoá", "Xác nhận", 
                                                MessageBoxButtons.OKCancel, 
                                                MessageBoxIcon.Information);

            return res;
        }
        // add
        public static DialogResult ConfirmAdd()
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thêm", "Xác nhận",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Information);

            return res;
        }

        public static DialogResult ConfirmUpdate()
        {
            DialogResult res = MessageBox.Show("Lưu thông tin đã chỉnh sửa", "Xác nhận",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Information);

            return res;
        }
    }
}
