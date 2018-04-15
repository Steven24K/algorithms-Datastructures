using System;
using algorithms_Datastructures.Search;
using algorithms_Datastructures.Sort;
using algorithms_Datastructures.LinkedList;
using algorithms_Datastructures.DoublyLinkedList;
using algorithms_Datastructures.HashTable;
using algorithms_Datastructures.BinaryTree;

namespace algorithms_Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<Array> PrintArray = (a) => {
                string pretty_string = "[";
                foreach(var c in a){pretty_string += c.ToString() + ", ";}
                pretty_string += "]";
                System.Console.WriteLine(pretty_string);
                };

            //Test search algorithms
            int[] array1 = new int[]{1,2,3,4,5,6,7,8,9,11,12,13,14,15,16,17,18,19,20};
            System.Console.WriteLine(array1.SequentialSearch(10));
            System.Console.WriteLine(array1.BinarySearch(20));

            //Test sort algorithms
            //BubleSort
            int[] array2 = new int[]{45,3,5,77,4,2,9,1,7,53,75,14,56,45,453,63,83,12,11,45,90,78};
            array2.BubleSort();
            PrintArray(array2);
            //Insertion sort
            int[] array3 = new int[]{6,87,432,23,85,15,3,78,1,56,90,3,4,763,73,83,23,52};
            array3.InsertionSort();
            PrintArray(array3);
            //Merge sort
            int[] array4 = new int[]{56,89,2,45,90,983,23,12,323,15,48,73,98,101,76,54,63,74,7,17,4,3,5,83};
            array4.MergeSort(0, array4.Length-1);
            PrintArray(array4);

            //Test LinkedList (Stack)
            MyLinkedList<int> list1 = new MyLinkedList<int>();
            list1.Push(1); //Push one on top of the stack [1,]
            list1.Push(2); //Push two on top [2,1]
            list1.Push(3); //Push three on top [3,2,1,]
            System.Console.WriteLine(list1.ToString());

            //Test DoublyLinkedList (Que)
            MyDoublyLinkedList<int> list2 = new MyDoublyLinkedList<int>();
            list2.Enqueue(1); //Puts a one at the back of the que [1, ]
            list2.Enqueue(2); //Puts a two at the back of the que [1,2, ]
            list2.Enqueue(3); //Puts a three at the back of the que [1,2,3, ]
            System.Console.WriteLine(list2.ToString());

            //Test HashTable
            //Let the numbers by phonenumbers, SSN's, studentnumbers etc. 
            //Search for the key name to find the corresponding number
            MyHashTable<int> hashTable1 = new MyHashTable<int>();
            hashTable1.Insert("Steven", 13232);
            hashTable1.Insert("Bob", 56732);
            hashTable1.Insert("John", 83832);
            hashTable1.Insert("Frank", 37723);
            hashTable1.Insert("Allice", 43433);
            hashTable1.Insert("Donald", 32342);
            System.Console.WriteLine(hashTable1.ToString());
            //Searching doesn't work
            //System.Console.WriteLine("Found value: " + hashTable1.SearchValueByKey("Steven"));

            //Test BinaryTree (BinarySearchTree)
            MyTree tree1 = new MyTree();
            tree1.Insert(1);
            tree1.Insert(3);
            tree1.Insert(5);
            tree1.Insert(7);
            tree1.Insert(9);
            tree1.Insert(11);
            tree1.Insert(13);
            tree1.Insert(2);
            tree1.Insert(4);
            tree1.Insert(6);
            tree1.Insert(8);
            tree1.Insert(10);
            tree1.Insert(12);
            tree1.Insert(14);
            tree1.PretyPrint();
        }
    }
}
