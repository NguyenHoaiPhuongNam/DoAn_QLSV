﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Khoa_ET
    {
        private string maKhoa;
        private string tenKhoa;

        public Khoa_ET(string maKhoa, string tenKhoa)
        {
            this.MaKhoa = maKhoa;
            this.TenKhoa = tenKhoa;
        }

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
    }
}
