using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Lab1
{
    public class Email : Document
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Title { get; set; }

        public void SetEmailText(string newText)
        {
            SetText(newText);
        }

        public override string ToString()
        {
            return $"Sender: {Sender}, Recipient: {Recipient}, Title: {Title}, Body: {Text}";
        }
    }


}
