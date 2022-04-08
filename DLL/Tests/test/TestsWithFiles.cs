using System;
using System.IO;
using DLL;
using NUnit.Framework;

namespace Tests;


public class TestsWithFiles
{
    Extends<int> extend = new Extends<int>(); 
    private string WayToTestData = "/Users/akabynda/RiderProjects/DLL/Tests/test/TestData3.txt";
    
    [Test]
    public void GetDataTest()
    {
        string line;
        string data = null;
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "GetDataTest")
            {
                line = sr.ReadLine();
                data = line;
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        DoublyLinkedNode<string> testNode = new DoublyLinkedNode<string>(data);
        Assert.AreEqual(testNode.getData(), data);
    }
    
    [Test]
    public void GetNextTest()
    {
        string line;
        string data = null;
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "GetNextTest")
            {
                line = sr.ReadLine();
                data = line;
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        DoublyLinkedNode<string> testNode = new DoublyLinkedNode<string>(data);
        Assert.AreEqual(testNode.getNext(), null);
    }
    
    [Test]
    public void GetPrevTest()
    {
        string line;
        string data = null;
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "GetPrevTest")
            {
                line = sr.ReadLine();
                data = line;
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        DoublyLinkedNode<string> testNode = new DoublyLinkedNode<string>(data);
        Assert.AreEqual(testNode.getPrev(), null);
    }
    
    [Test]
    public void SetNextTest()
    {
        string line;
        string[] data = new string[2];
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "SetNextTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        DoublyLinkedNode<string> testNode1 = new DoublyLinkedNode<string>(data[0]);
        DoublyLinkedNode<string> testNode2 = new DoublyLinkedNode<string>(data[1]);
        testNode1.setNext(testNode2);
        Assert.AreEqual(testNode1.getNext(), testNode2);
    }
    
    [Test]
    public void SetPrevTest()
    {
        string line;
        string[] data = new string[2];
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "SetPrevTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        DoublyLinkedNode<string> testNode1 = new DoublyLinkedNode<string>(data[0]);
        DoublyLinkedNode<string> testNode2 = new DoublyLinkedNode<string>(data[1]);
        testNode1.setPrev(testNode2);
        Assert.AreEqual(testNode1.getPrev(), testNode2);
    }
    
    [Test]
    public void SetDataTest()
    {
        string line;
        string data = null;
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "SetDataTest")
            {
                line = sr.ReadLine();
                data = line;
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        DoublyLinkedNode<string> testNode = new DoublyLinkedNode<string>("5");
        testNode.setData(data);
        Assert.AreEqual(testNode.getData(), data);
    }

    [Test]
    public void ArrayToDllTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "ArrayToDllTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
        DoublyLinkedNode<string> current = testList.getFirst();
        Assert.Multiple(() =>
        {
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(current.getData(), data[i]);
                current = current.getNext();
            }
        });
    }

    [Test]
    public void GetNodeTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "GetNodeTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
        Assert.Multiple(() =>
        {
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(testList.getNode(i).getData(), data[i]);
            }
        });
    }

    [Test]
    public void AddLastByDataTest()
    {
        string line;
        string data = null;
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "AddLastByDataTest")
            {
                line = sr.ReadLine();
                data = line;
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        string[] arr = new[] {"1", "2", "3"};
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
        testList.AddLast(data);
        Assert.AreEqual(data, testList.getLast().getData());
    }

    [Test]
    public void AddFirstByDataTest()
    {
        string line;
        string data = null;
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "AddFirstByDataTest")
            {
                line = sr.ReadLine();
                data = line;
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        string[] arr = new[] {"1", "2", "3"};
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
        testList.AddFirst(data);
        Assert.AreEqual(data, testList.getFirst().getData());
    }
    
    [Test]
    public void AddLastByNodeTest()
    {
        string line;
        string data = null;
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "AddLastByDataTest")
            {
                line = sr.ReadLine();
                data = line;
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        string[] arr = new[] {"1", "2", "3"};
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
        testList.AddLast(new DoublyLinkedNode<string>(data));
        Assert.AreEqual(data, testList.getLast().getData());
    }

    [Test]
    public void AddFirstByNodeTest()
    {
        string line;
        string data = null;
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "AddFirstByDataTest")
            {
                line = sr.ReadLine();
                data = line;
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        string[] arr = new[] {"1", "2", "3"};
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
        testList.AddFirst(new DoublyLinkedNode<string>(data));
        Assert.AreEqual(data, testList.getFirst().getData());
    }

    [Test]
    public void AddAfterByDataTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "AddAfterByDataTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        string[] arr = new[] {"1", "2", "3"};
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
        testList.AddAfter(testList.getNode(Convert.ToInt32(data[0])), data[1]);
        Assert.AreEqual(data[1], testList.getNode(Convert.ToInt32(data[0])).getNext().getData());
    }

    [Test]
    public void AddBeforeByDataTest()
    {
        string line;
        string[] data = new string[2];
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "AddBeforeByDataTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        string[] arr = new[] {"1", "2", "3"};
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
        testList.AddBefore(testList.getNode(Convert.ToInt32(data[0])), data[1]);
        Assert.AreEqual(data[1], testList.getNode(Convert.ToInt32(data[0])).getData());
    }
    
    [Test]
    public void AddAfterByNodeTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "AddAfterByDataTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        string[] arr = new[] {"1", "2", "3"};
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
        testList.AddAfter(testList.getNode(Convert.ToInt32(data[0])), new DoublyLinkedNode<string>(data[1]));
        Assert.AreEqual(data[1], testList.getNode(Convert.ToInt32(data[0])).getNext().getData());
    }

    [Test]
    public void AddBeforeByNodeTest()
    {
        string line;
        string[] data = new string[2];
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "AddBeforeByDataTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        string[] arr = new[] {"1", "2", "3"};
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
        testList.AddBefore(testList.getNode(Convert.ToInt32(data[0])), new DoublyLinkedNode<string>(data[1]));
        Assert.AreEqual(data[1], testList.getNode(Convert.ToInt32(data[0])).getData());
    }

    [Test]
    public void ClearTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "ClearTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
        testList.Clear();
        Assert.Multiple(() =>
        {
            Assert.AreEqual(testList.getFirst(), null);
            Assert.AreEqual(testList.getLast(), null);
        });
    }
    
    [Test]
    public void ContainsTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "ContainsTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
        Assert.Multiple(() =>
        {
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(testList.Containts(testList.getNode(i).getData()), true);
            }
            Assert.AreEqual(testList.Containts("ThisIsTestPhraseThatYouNeverEnterIThinkSoItShouldBeFalseAndTestWillBeCompleted"), false);
        });
    }
    
    [Test]
    public void FindTest()
    {
        string line;
        string[] input = new string[2];
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "FindTest")
            {
                line = sr.ReadLine();
                input = line.Split(' ');
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        //input[1] - position; input[0] - element;
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
        Assert.AreEqual(testList.Find(input[0]), testList.getNode(Convert.ToInt32(input[1])));
        }
    
    [Test]
    public void FindLastTest()
    {
        string line;
        string[] input = new string[2];
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "FindLastTest")
            {
                line = sr.ReadLine();
                input = line.Split(' ');
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        //input[1] - position; input[0] - element;
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
        Assert.AreEqual(testList.FindLast(input[0]), testList.getNode(Convert.ToInt32(input[1])));
    }
    
    [Test]
    public void EqualsTest()
    {
        string line;
        bool boolean = false;
        string[] data1 = new string[] { };
        string[] data2 = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "EqualsTest")
            {
                line = sr.ReadLine();
                boolean = Convert.ToBoolean(line);
                line = sr.ReadLine();
                data1 = line.Split(' ');
                line = sr.ReadLine();
                data2 = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }
        sr.Close();
        DoublyLinkedList<string> testList1 = new DoublyLinkedList<string>(data1);
        DoublyLinkedList<string> testList2 = new DoublyLinkedList<string>(data2);
        Assert.Multiple(() =>
        {
            Assert.AreEqual(testList1.Equals(testList1), true);
            Assert.AreEqual(testList2.Equals(testList2), true);
            Assert.AreEqual(testList1.Equals(testList2), boolean);
            Assert.AreEqual(testList2.Equals(testList1), boolean);
        });
    }

    [Test]
    public void RemoveNodeByDataTest()
    {
        string line;
        string input = null;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "RemoveNodeByDataTest")
            {
                line = sr.ReadLine();
                input = line;
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
        DoublyLinkedList<string> copyList = new DoublyLinkedList<string>(data);
        testList.RemoveNode(input);
        Assert.AreEqual(testList.Equals(copyList), false);
    }
    
    [Test]
    public void RemoveNodeByNodeTest()
    {
        string line;
        string input = null;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "RemoveNodeByDataTest")
            {
                line = sr.ReadLine();
                input = line;
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
        DoublyLinkedList<string> copyList = new DoublyLinkedList<string>(data);
        testList.RemoveNode(testList.Find(input));
        Assert.AreEqual(testList.Equals(copyList), false);
    }
    
    
    [Test]
    public void RemoveFirstTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "RemoveFirstTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
        DoublyLinkedList<string> copyList = new DoublyLinkedList<string>(data);
        testList.RemoveFirst();
        Assert.AreEqual(testList.getFirst().getData(), copyList.getNode(1).getData());
    }
    
    [Test]
    public void RemoveLastTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "RemoveLastTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
        DoublyLinkedList<string> copyList = new DoublyLinkedList<string>(data);
        testList.RemoveLast();
        Assert.AreEqual(testList.getLast().getData(), copyList.getNode(data.Length - 2).getData());
    }
    
    [Test]
    public void RemoveFirstTestForOneElement()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "RemoveFirstTestForOneElement")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
        testList.RemoveFirst();
        Assert.AreEqual(testList.getFirst(), null);
    }
    
    [Test]
    public void RemoveLastTestForOneElement()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "RemoveLastTestForOneElement")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
        testList.RemoveLast();
        Assert.AreEqual(testList.getLast(), null);
    }
    
    [Test]
    public void AnyTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "AnyTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        Assert.AreEqual(extend.Any(data), true);
    }

    [Test]
    public void AnyFuncTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "AnyFuncTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        Assert.AreEqual(extend.Any(data, i => i.Length >= 0), true);
    }
    
    [Test]
    public void CountTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "CountTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        Assert.AreEqual(extend.Count(data), data.Length);
    }
    
    [Test]
    public void ElementAtTest()
    {
        string line;
        string[] data = new string[] { };
        string input = null;
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "ElementAtTest")
            {
                line = sr.ReadLine();
                input = line;
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        Assert.AreEqual(extend.ElementAt(data, Convert.ToInt32(input)), data[Convert.ToInt32(input)]);
    }
    
    [Test]
    public void ElementAtOrDefaultTest()
    {
        string line;
        string[] data = new string[] { };
        string input = null;
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "ElementAtOrDefaultTest")
            {
                line = sr.ReadLine();
                input = line;
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        Assert.Multiple(() =>
        {
            Assert.AreEqual(extend.ElementAtOrDefault(data, 1000000), null);
            Assert.AreEqual(extend.ElementAt(data, Convert.ToInt32(input)), data[Convert.ToInt32(input)]);
        });
    }
    
    [Test]
    public void FirstTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "FirstTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        Assert.AreEqual(extend.First(data), data[0]);
    }

    [Test]
    public void LastTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "LastTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        Assert.AreEqual(extend.Last(data), data[data.Length - 1]);
    }

    [Test]
    public void FirstOrDefaultTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "FirstOrDefaultTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        int[] arr2 = new int[] { };
        Assert.Multiple(() =>
        {
            Assert.AreEqual(extend.FirstOrDefault(arr2), 0);
            Assert.AreEqual(extend.FirstOrDefault(data), data[0]);
        });
    }
    
    [Test]
    public void LastOrDefaultTest()
    {
        string line;
        string[] data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "LastOrDefaultTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        int[] arr2 = new int[] { };
        Assert.Multiple(() =>
        {
            Assert.AreEqual(extend.LastOrDefault(arr2), 0);
            Assert.AreEqual(extend.LastOrDefault(data), data[data.Length - 1]);
        });
    }

    [Test]
    public void MaxTest()
    {
        string line;
        string[] data = new string[] { };
        string max = null;
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "MaxTest")
            {
                line = sr.ReadLine();
                max = line;
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        Assert.AreEqual(extend.Max(data, (i1, i2) => i1.Length < i2.Length), max);
    }
    
    [Test]
    public void MinTest()
    {
        string line;
        string[] data = new string[] { };
        string min = null;
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "MinTest")
            {
                line = sr.ReadLine();
                min = line;
                line = sr.ReadLine();
                data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        Assert.AreEqual(extend.Min(data, (i1, i2) => i1.Length < i2.Length), min);
    }
    
    [Test]
    public void ReverseTest()
    {
        string line;
        string[] data = new string[] { };
        string[] rev_data = new string[] { };
        StreamReader sr = new StreamReader(WayToTestData);
        line = sr.ReadLine();
        while (line != null)
        {
            if (line == "ReverseTest")
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                line = sr.ReadLine();
                rev_data = line.Split(' ');
                line = null;
            }
            else
            {
                line = sr.ReadLine();
            }
        }

        sr.Close();
        string[] rev_arr = extend.Reverse(data);
        Assert.AreEqual(rev_arr, rev_data);
    }
}