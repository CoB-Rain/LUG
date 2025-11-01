using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace BE
{
    public class BATALLA_NAVAL : BARCO
    {
        public BATALLA_NAVAL()
        {
            _imagen = @"IMG\BATALLA NAVAL.jpg";
        }
    }
}