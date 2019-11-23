using System;
using System.Collections.Generic;
using System.Text;

namespace Studyday01
{
    class Problem
    {
        private int _problemId { get; set; }
        private int _authorId { get; set; }
        private String _tittle { get; set; }
        private String _body { get; set; }
        private int reward;
        public int _reward {
            get {
                return reward;
            }
            set {
                if (reward <= 0) {
                    Console.WriteLine("悬赏点不能为负");
                }
            }
                }
        public void publish() {
            return ;
        }
    }
}
