using Csharp;
using NUnit.Framework;

namespace CsharpTest
{
    public class DoubleLinkTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        //测试无参构造函数、空链新增第一个node、有参构造函数、
        [Test]
        public void addFirstNode()
        {
            //测试无参构造函数
            DoubleLink doubleLink01 = new DoubleLink();
            Assert.AreEqual(doubleLink01.length, 0);

            //测试新增第一个node
            Node node01 = new Node(1);
            doubleLink01.addFirstNode(node01);
            Assert.AreEqual(doubleLink01.length, 1);
            Assert.AreEqual(doubleLink01.linkhead, node01);
            Assert.AreEqual(doubleLink01.linktail, node01);

            //测试有参构造函数
            Node node02 = new Node(2);
            Node node03 = new Node(3);
            DoubleLink doubleLink02 = new DoubleLink(node01, node02, node03);
            Assert.AreEqual(doubleLink02.length, 3);
            Assert.AreEqual(doubleLink02.linkhead, node01);
            Assert.AreEqual(doubleLink02.linktail, node03);
            Assert.AreEqual(node01.next, node02);
        }
        //测试从后插如Node
        [Test]
        public void insertAfter()
        {
            Node node01 = new Node(1);
            Node node02 = new Node(2);
            Node node03 = new Node(3);
            DoubleLink doubleLink01 = new DoubleLink(node01);
            doubleLink01.insertAfter(node01, node03);
            doubleLink01.insertAfter(node01, node02);
            Assert.AreEqual(doubleLink01.length, 3);
            Assert.AreEqual(doubleLink01.linkhead, node01);
            Assert.AreEqual(doubleLink01.linktail, node03);
            Assert.AreEqual(node01.next, node02);
        }
        [Test]
        //测试从后插入Node
        public void insertBefor()
        {
            Node node01 = new Node(1);
            Node node02 = new Node(2);
            Node node03 = new Node(3);
            DoubleLink doubleLink01 = new DoubleLink(node03);
            doubleLink01.insertBefor(node03, node02);
            doubleLink01.insertBefor(node02, node01);
            Assert.AreEqual(doubleLink01.length, 3);
            Assert.AreEqual(doubleLink01.linkhead, node01);
            Assert.AreEqual(doubleLink01.linktail, node03);
            Assert.AreEqual(node01.next, node02);
        }

        //测试删除
        public void deletNode() 
        {
            Node node01 = new Node(1);
            Node node02 = new Node(2);
            Node node03 = new Node(3);
            DoubleLink doubleLink01 = new DoubleLink(node01, node02, node03);
            doubleLink01.deleteNode(1);
            Assert.AreEqual(doubleLink01.length, 2);
            Assert.AreEqual(doubleLink01.linkhead, node02);
            Assert.AreEqual(doubleLink01.linktail, node03);
            Assert.AreEqual(doubleLink01.linkhead.next, node03);
        }

        //测试更改
        public void updateNodelink() 
        {
            Node node01 = new Node(1);
            Node node02 = new Node(2);
            Node node03 = new Node(3);
            DoubleLink doubleLink01 = new DoubleLink(node01, node02, node03);
            doubleLink01.updateNodelink(1,0);
            Assert.AreEqual(node01.value, 0);
            Assert.AreEqual(doubleLink01.length, 3);
            Assert.AreEqual(doubleLink01.linkhead, node01);
            Assert.AreEqual(doubleLink01.linktail, node03);
            Assert.AreEqual(node01.next, node02);

        }

        //测试查找
        public void findNodeBy() {
            Node node01 = new Node(1);
            Node node02 = new Node(2);
            Node node03 = new Node(3);
            DoubleLink doubleLink01 = new DoubleLink(node01, node02, node03);
            Assert.AreEqual(doubleLink01.findNodeBy(1), node01);
        }
    }
}