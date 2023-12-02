using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OfficeOpenXml.ExcelErrorValue;

namespace QuanlyOto.Common
{
    public class Commons
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

        public static DialogResult ConfirmSuccess()
        {
            DialogResult res = MessageBox.Show("Hoàn tất lịch trình này?", "Xác nhận",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Information);
            return res;
        }

        public static DialogResult ConfirmAdditionalPayment(double additionalAmount)
        {
            string message = $"Bạn sẽ phải trả thêm số tiền {formatStringVietNammes(additionalAmount)}. Nhấp vào 'OK' để hoàn tất giao dịch.";

            DialogResult result = MessageBox.Show(message, "Xác nhận thanh toán",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Information);
            return result;
        }

        public static String formatStringVietNammes(double number)
        {
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            return String.Format(info, "{0:c}", number);
        }
    }
}
