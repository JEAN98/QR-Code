using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QRcode.Models
{
    public class QRmodel
    {
        public string URL { get; set;}
        public Byte[] codeQr{ get; set;}
    }
}