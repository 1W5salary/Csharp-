using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public class ContentService
    {
        static public void publish(Content content) {
            content.publish();
            Console.WriteLine("发布",content._kind);
            
        }
    }
}
