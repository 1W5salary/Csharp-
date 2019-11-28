using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public abstract class Content
    {
        public int problemId { get; set; }
        public Studyday01.User author { get; set; }
        public string tittle { get; set; }
        public string body { get; set; }
        public string _kind;
        public int bangMoney { get; set; }
        private int _reword;
        public int reword {
            get {
               return _reword = reword;
            }
            
            set {
                if (reword < 0)
                {
                    Console.WriteLine("悬赏不能为负");
                }
                else {
                    _reword = reword;
                }
            
            }
        }

        private DateTime createTime;
        public DateTime publishTime{
            get{
                return createTime; 
            }
        }
 
        virtual public void kind() {

        }
        virtual public void publish()
        {
        }
    }
}
