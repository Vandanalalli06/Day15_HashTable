using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable;

class LinkedList<K, V> where K : IComparable
{
    //Linked list node created with key-value pair
    public MyMapNode<K, V> head;
    public MyMapNode<K, V> tail;

    public LinkedList()                             // Head and tail both are null since its starting
    {
        head = null;
        tail = null;
    }
    public MyMapNode<K, V> Search(K key)            // Searching for Key i.e.. "to"
    {
        //Head will assigen as temp
        MyMapNode<K, V> temp = head;                // Head will assigen as temp
        while (temp != null)                        // at first temp = null so it will go to return statement
        {
            if (temp.key.Equals(key))
                return temp;
            temp = temp.next;
        }
        return null;
    }
    public void Append(MyMapNode<K, V> node)
    {
        //Check node is present or not          
        if (head == null && tail == null)           // Check node is present or not, If null head and tail is node.
        {
            head = node;
            tail = node;
        }
        else
        {
            //If present then node added from the end
            tail.next = node;
            tail = node;
        }
    }
    public bool IsEmpty()
    {
        return head == null && tail == null;
    }

    public MyMapNode<K, V> Pop()
    {
        //Temp assign to the first node
        MyMapNode<K, V> temp = head;
        if (head != null)
        {
            //Moving head to next Node and remove first node
            head = head.next;
        }
        return temp;
    }

    public MyMapNode<K, V> PopLast()
    {
        MyMapNode<K, V> tailTemp = tail;
        if (!IsEmpty())
        {
            //Head is assign as temp
            MyMapNode<K, V> temp = head;
            while (temp.next != tail)
            {
                //Traversing till tail
                temp = temp.next;
            }

            temp.next = null;
            tail = temp;
        }
        return tailTemp;
    }

    public bool DeleteNode(MyMapNode<K, V> DeleteNode)
    {

        MyMapNode<K, V> temp = head;
        if (!IsEmpty())
        {
            //If removing node is first
            if (DeleteNode.key.Equals(head.key))
            {
                Pop();
                return true;
            }
            //If removing node is last
            if (DeleteNode.key.Equals(tail.key))
            {
                PopLast();
                return true;
            }
            while (temp != null)
            {
                //If removing node rather than first and last
                if (temp.next != null && temp.next.key.Equals(DeleteNode.key))
                {
                    temp.next = DeleteNode.next;
                    return true;
                }
                temp = temp.next;
            }
        }
        return false;
    }
}