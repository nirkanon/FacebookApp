using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B15_Ex03_Nir_304855521_Hen_304841851.Utils
{
    public class Status
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public Status(string i_Id, string i_Text)
        {
            Id = i_Id;
            Text = i_Text;
        }

        public Status()
        {
        }
    }
}
