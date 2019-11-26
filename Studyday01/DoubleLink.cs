using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    //双向链
    public class DoubleLink
    {
        //链头
        public Node linkhead { get; set; }

        //链尾
        public Node linktail { get; set; }
        //长度
        public int length { get; set; }

        //构造函数
        public DoubleLink()
        {
            linkhead = null;
            linktail = null;
            length = 0;
        }
        //有参构造函数
        public DoubleLink(params Node[] node)
        {


            addFirstNode(node[0]);
            for (int i = 1; i < node.Length; i++)
            {
                insertAfter(node[i - 1], node[i]);
            }

        }
        //新增第一个节点
        public void addFirstNode(Node node)
        {
            length++;
            linkhead = node;
            linktail = node;
        }
        //新增在节点后
        public void insertAfter(Node old, Node node)
        {

            if (old.next == null)
            {
                linktail = node;
                node.previous = old;
                old.next = node;
            }
            else
            {
                old.next.previous = node;
                node.next = old.next;
                node.previous = old;
                old.next = node;
            }
            length++;
        }
        //新增在节点前
        public void insertBefor(Node old, Node node)
        {
            if (old.previous == null)
            {
                linkhead = node;
                node.next = old;
                old.previous = node;
            }
            else
            {
                old.previous.next = node;
                node.previous = old.previous;
                node.next = old;
                old.previous = node;

            }
            length++;
        }
        //删除
        public void deleteNode(int value)
        {
            findNodeBy(value);
            if (findNodeBy(value) == null)
            {
                return;
            }
            else
            {
                findNodeBy(value).next.previous = findNodeBy(value).previous;
                findNodeBy(value).previous.next = findNodeBy(value).next;
                length--;
            }
        }
        //改
        public void updateNodelink(int oldvalue,int newvalue)
        {
            if (findNodeBy(oldvalue) == null)
            {
                return;
            }
            else 
            {
                findNodeBy(oldvalue).value = newvalue;
            }

        }
        //查
        public Node findNodeBy(int value)
        {
            if (linkhead == null)
            {
                Console.WriteLine("链表为空了");
                return null;
            }
            else
            {
                Node findedNode = new Node();
                findedNode = linkhead;
                for (int i = 0; i < length; i++)
                {
                    if (findedNode.value == value)
                    {
                        return findedNode;
                    }
                    else
                    {
                        findedNode = findedNode.next;

                    }
                }
                Console.WriteLine("链表中没有这个值");
                return null;
            }


        }
    }
}
