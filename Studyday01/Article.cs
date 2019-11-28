using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Article:Content
    {
        public override void publish()
        {
            author.helpMoney = author.helpMoney--;
        }
        public override void kind()
        {
            _kind = "文章";
        }
    }
}
