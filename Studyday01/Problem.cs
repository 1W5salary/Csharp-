using System;
using System.Collections.Generic;
using System.Text;

namespace Studyday01
{
    class Problem: Csharp.Content
    {
        public override void publish() {
            author.helpMoney =author.helpMoney--;
        }
        public override void kind()
        {
            _kind= "问题";
        }
    }
}
