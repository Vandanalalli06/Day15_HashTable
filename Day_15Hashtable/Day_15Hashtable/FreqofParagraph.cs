using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable;

public class LinkedHashMap<K, V> where K : IComparable               //Created class name as LinkedHashMap and passing Key and Value,
                                                                     //IComparable means it Compare the value and give it in sorting manner.
{
    private readonly int NumBuckets;
    readonly List<LinkedList<K, V>> BucketList;

    public LinkedHashMap(int NumBuckets)                             // Creating Constructor,Creating Five Identical Position in Bucket list
    {
        //Linked list added to array locatation
        //NumBuckets is Array size
        this.NumBuckets = NumBuckets;
        BucketList = new List<LinkedList<K, V>>(NumBuckets);

        for (int i = 0; i < this.NumBuckets; i++)
            BucketList.Add(null);
    }

    public V Get(K key)                                             //  V is Return Type and passing the Key (Key="to)
    {
        //Check value of particular key(word)
        int index = GetBucketIndex(key);                            // Need to find the index for the Key
        //check  particular linked list at the array position
        LinkedList<K, V> myLinkedList = BucketList[index];          // In Bucket list stroing 3 as index value
        if (myLinkedList == null)                                   // Intialaly We dont have any link list here that is why it is null
            return default;                                         // Default value will be 1 5.9 since linklist is null
        //Check particular key mymapnode in the linked list at array position
        MyMapNode<K, V> myMapNode = myLinkedList.Search(key);
        return (myMapNode == null) ? default : myMapNode.value;
    }

    private int GetBucketIndex(K key)                         // finding the index for the Key in Bucket
    {
        //Return the absolute value because hashCode contain negative value sometime
        int hashCode = Math.Abs(key.GetHashCode());          // Return the "Abs" absolute value because hashCode contain negative value sometime
        //To get the hashcode within range
        int index = hashCode % NumBuckets;              
        return index;                                        // In This case index is 3
    }

    public void Add(K key, V value)                                 //For Adding the particular value and key at linked list 
    {
        //Adding the particular value and key at linked list 
        int index = this.GetBucketIndex(key);                       // Same index we are going to get from above method
        LinkedList<K, V> myLinkedList = BucketList[index];          // From that index we are intializing link list
        ///Check linked list is null or not
        if (myLinkedList == null)                                   // yes Linked list is null and it will get if statement
        {
            myLinkedList = new LinkedList<K, V>();                  // now it is going to intialize at a index in linked list class 
            BucketList[index] = myLinkedList;                       // Intailised linked list by Storing Bucketlist of 3 as Head and tail
                                                                   
        }
        //Check myMapNode is present or not if not then create new else add value in previous mymapnode
        MyMapNode<K, V> myMapNode = myLinkedList.Search(key);       //Searching for the key "Key = To" in Linked list class
        if (myMapNode == null)                                      // I dont have any node inside the link list since Head and tail is null
        {
            myMapNode = new MyMapNode<K, V>(key, value);           
            myLinkedList.Append(myMapNode);                         
        }                                                           
        else myMapNode.value = value;
    }
}
