using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class Kutya
    {
        private int id;
        private int fajtaid;
        private int nevid;
        private int eletkor;
        private string vizsgalat;

        public Kutya(int i, int f, int n, int e, string v)
        {
            id = i;
            fajtaid = f;
            nevid = n;
            eletkor = e;
            vizsgalat = v;
        }
    }
}
