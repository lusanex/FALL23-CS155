using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Lab1
{
    public class Document
    {
        protected string? Text;

        public void SetText(string newText)
        {
            Text = newText;
        }

        public override string ToString()
        {
            return Text;
        }
    }

}
