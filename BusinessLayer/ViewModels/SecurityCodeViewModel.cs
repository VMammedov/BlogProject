using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class SecurityCodeViewModel
    {
        public byte Number1 { get; set; }
        public byte Number2 { get; set; }
        public byte Number3 { get; set; }
        public byte Number4 { get; set; }
        public byte Number5 { get; set; }
        public byte Number6 { get; set; }
        public int Number { get; set; } //Random
        public string Email { get; set; } //Email
    }
}
