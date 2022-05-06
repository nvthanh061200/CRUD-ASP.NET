using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Lap2.Models
{
    public class people
    {
        [DisplayName("ID")]
        public int ID { get; set; }
        [DisplayName("Họ và Tên")]
        public string HoTen { get; set; }
        [DisplayName("Ngày sinh")]
        public string NgaySinh { get; set; }

        public people() { }

        public people(int ID, string HoTen, string NgaySinh)
        {
            this.ID = ID;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
        }
        public people( string HoTen, string NgaySinh)
        {
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
        }

    }
}