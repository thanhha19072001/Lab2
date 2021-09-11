﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_GiaoVien
{
    public class MonHoc
    {
        private string v;

        public MonHoc(string v)
        {
            this.v = v;
        }

        public int Id { get; set; }
        public string TenMH { get; set; }
        public int SoTC { get; set; }
        public MonHoc() { }

        public MonHoc(int id, string ten, int tc)
        {
            this.Id = id;
            this.TenMH = ten;
            this.SoTC = tc;
        }
        public override string ToString()
        {
            return TenMH;
        }
    }
}
