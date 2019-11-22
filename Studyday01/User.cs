using System;
using System.Collections.Generic;
using System.Text;

namespace Studyday01
{
    //定义一个User类
    class User
    {
        public int _userId { get; set; }
        //定义属性_userName，当输入admin时修改为系统管理员
        private string _userName;
        public string UserName {
            get
            { 
                return _userName; 
            }
            set {
                
                if ( value == "admin")
                {
                    _userName = "系统管理员";
                }
                else 
                { 
                
                }

            }

        }
        //定义属性_password，在外部只能改不能被读
        public String _password { private get; set; }
        public int _invitedById { get; set; }

        //定义注册方法
        public void register()
        {
            Console.WriteLine("注册成功"+ _userName) ;
        }

        //登录方法
        public User login(User user)
        {
            Console.WriteLine("hello"+user._userName);
            return user;
        }
    }
}
