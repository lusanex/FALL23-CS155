using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Lab1
{
    public class File : Document
    {
        public string Pathname { get; set; }

        public void SetFileText(string newText)
        {
            SetText(newText);
        }

        public override string ToString()
        {
            return $"Pathname: {Pathname}, Content: {Text}";
        }
    }


}
