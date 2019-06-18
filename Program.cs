using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Linear_Data_Structures
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T value) //Constructor
        {
            Data = value;
        }
    }

    public class SinglyLinkedList<T> : System.Collections.Generic.ICollection<T>
    {
        #region Initialize LinkedList
        public class Node
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }
            public Node<T> Previous { get; set; }

            public Node(T value) //Constructor
            {
                Data = value;
            }
        }
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }

        public bool IsReadOnly => throw new NotImplementedException();
        #endregion

        #region Add
        public void AddFirst(T value) //Add specified value to the start of the linked list
        {
            AddFirst(new Node<T>(value)); //1- Create new node
        }
        public void AddFirst(Node<T> node) //Add specified node to the start of the linked list
        {
            Node<T> temp = Head; //2- Point temp to head
            Head = node; //3- Point head to new node
            Head.Next = temp; //4-Point head.next to temp
            Count++;
            
            if (Count == 1)
            {
                Tail = Head; //5- If list is empty then tail and head are the same
            }
            else
            {
                temp.Previous = Head; //5- point temp.previous to head
            }
        }
        public void AddLast(T value) //Add specific value to the end of the linked list
        {
            AddLast(new Node<T>(value)); //1- Create new node
        }
        public void AddLast(Node<T> node) //Add specific node to the end of the linked list
        {
            Node<T> temp = Tail; //2- point temp to tail
            Tail = node; //3- Point tail to new node
            Tail.Previous = temp; //4- Point tail.previous to temp
            Count++; 

            if (Count == 1)
            {
                Head = Tail; //5- If list is empty then head and tail are the same
            }
            else
            {
                temp.Next = Tail; //5- Point temp.next to tail
            }
        }
        #endregion

        #region Print
        public void PrintLinkedList()
        {
            Node<T> temp = Head;

            while(temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
        }
        #endregion

        #region Pending Methods
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion
    }

    class Program
    {
        public static void StringClass()
        {
            //******************[DEFINITION]****************//
            //Strings are reference types but behave like value types. String are immutable. 
            //Checking for equality performs a string comparison. It compares the value of the string charachter by character. 

            //******************[DECLARATION]**************//
            string myString = "This is a string";
            string str = ", Yes!";

            //********[COMMON METHODS AND PROPERTIES]******//
            int lenght = myString.Length;                    //Lenght:-----------> Returns number of charachters in the string object 
            string newString = string.Concat(myString, str); //Concat:-----------> Concatenates two strings.
            bool contains = str.Contains('e');               //Contains:---------> Returns bool indicating whether char exist
            int index = str.IndexOf('!');                    //IndexOf:----------> Returns index of char
            //Insert, Remove, Replace, ToCharArray(), Trim()...

            Console.WriteLine(newString);
            Console.ReadLine();
        }
        public static void ArrayClass()
        {
            //******************[DEFINITION]****************//
            //... 

            //******************[DECLARATION]**************//
            int[] myArray = new int[10];

            //********[COMMON METHODS AND PROPERTIES]******//
            Console.WriteLine("Unsorted: ");
            for (int i = 0; i < myArray.Length - 4; i++) 
            {
                myArray[i] = i * 5;
                Console.WriteLine("[" + i + "]: " + myArray[i]);
            }

            Array.Reverse(myArray); //Reverse array
            Console.WriteLine("Reversed: ");
            for (int i = 0; i < myArray.Length; i++) //Print reversed array
            {
                Console.WriteLine("[" + i + "]: " + myArray[i]);
            }

            Array.Sort(myArray); //Sort array
            Console.WriteLine("Sorted: ");
            for (int i = 0; i < myArray.Length; i++) //Print reversed array
            {
                Console.WriteLine("[" + i + "]: " + myArray[i]);
            }

            Console.WriteLine("Array Lenght: " + myArray.Length); //Returns array lenght
            Console.WriteLine("Array Type: " + myArray.GetType()); //Returns array type
            Console.WriteLine("Contains 40? " + myArray.Contains(40)); //Returns true or false if array contains item
            Console.ReadLine();
        }
        public static void ListClass()
        {
            //******************[DEFINITION]****************//
            //A list is a dinamic array. It can have any amout of objects. It was designed to simplify the process of adding new elements. 
            //A List is an array whose size is doubled every time it runs out of space. 
            //List is the generic version of ArrayList. It behaves the same way, but within a specific type.
            //Similar to vectors in C++

            //******************[DECLARATION]**************//
            List<double> doubleList1 = new List<double>(); 
            IList<double> doubleList2 = new List<double>(); //Using the interface 

            //********[COMMON METHODS AND PROPERTIES]******//
            doubleList1.Add(7.4);                      //Add:-----------> Add an element at the end 
            doubleList1.Add(8.9);
            doubleList1.Add(3.4);
            doubleList2.Add(4.7);
            doubleList2.Add(6.5);

            doubleList1.AddRange(doubleList2);         //AddRange:------> Add range of elements
            doubleList2.Clear();                       //Clear:---------> Removes all elements from list
            int index = doubleList1.BinarySearch(3.4); //BinarySearch:--> Search for element and return index
            bool exist = doubleList1.Contains(8.99);   //Contains:------> Check wheather specific element exist
            doubleList1.Remove(6.5);                   //Remove:--------> Remove first occurence of specified element
            doubleList1.RemoveAt(3);                   //RemoveAt:------> Remove element at specified index
            doubleList1.Insert(2, 0.4);                //Insert:--------> Insert element at specific index
            doubleList1.Sort();                        //Sort:----------> Sort all elements

            //***************[TESTING METHODS]**************//
            Console.WriteLine("Sorted: ");
            foreach (var a in doubleList1)
                Console.WriteLine(a);
            
            Console.WriteLine("Index of 3.4: " + index);
            Console.WriteLine("Does 8.99 exist?: " + exist);
            Console.ReadLine();
        }
        public static void ArrayListClass()
        {
            //******************[DEFINITION]****************//
            //Similar to List, but can have any type of objects. Is possible always use List instead of ArrayList

            //******************[DECLARATION]**************//
            ArrayList myArrayList = new ArrayList();

            //********[COMMON METHODS AND PROPERTIES]******//
            //Most methods from List can be use
            myArrayList.Add(7.4);                      //Add:-----------> Add an element of any type at the end 
            myArrayList.Add("String");
            myArrayList.Add(5);
            myArrayList.Add(new FormatException());

            //Retrived values must be cast into original type:
            int intValue = (int)myArrayList[2];
            string stringValue = (string)myArrayList[1];
        }
        public static void BuiltInLinkedListClass()
        {
            //******************[DEFINITION]****************//
            //A LinkedList is a series of objects that stay together by linking to eachother.
            //A LinkedList node has basically three values: The object value, a reference to the next node and a reference to the previous node. 
            //Adding values to the middle is much faster than any other array type data structure. They are done in constant time.
            //It keeps memory cost down to a minimun. List on the other hand use extra space to make futher insertion as fast as possible. 
            //The tradeoff is that accessing elements is no longer a constant time operation. LinkedList must be traversed until the desire node is found. 

            //******************[DECLARATION]**************//
            LinkedList<int> list = new LinkedList<int>();

            //********[COMMON METHODS AND PROPERTIES]******//
            list.AddLast(5);                     //AddLast:---------------> Add new node with specified value at the end of the LinkedList
            list.AddFirst(3);                    //AddFirst:--------------> Add new node with specified value at the start
            list.AddAfter(list.Find(5), 6);      //AddAfter:--------------> Add new node after specified node
            list.AddBefore(list.Find(5), 4);     //AddBefore:-------------> Add new node before specified node
            Console.WriteLine(list.Count);       //Count------------------> Get number of node in the LinkedList
            Console.WriteLine(list.Max());       //Max--------------------> Return the max value
            Console.WriteLine(list.First.Value); //First.Value:-----------> Get first or last node
            list.Remove(5);                      //Remove:----------------> Remove first occurrance of value
            list.RemoveFirst();                  //RemoveFirst:-----------> Remove first node of the LinkedList

            foreach (int a in list)
                Console.Write(a + " ");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //*****[DATA STRUCTURES]*****//
            //StringClass();
            //ArrayClass();
            //ListClass();
            //ArrayListClass();
            //BuiltInLinkedListClass();

            SinglyLinkedList<int> myList = new SinglyLinkedList<int>();
            myList.AddFirst(5);
            myList.AddFirst(4);
            myList.AddFirst(3);
            myList.AddLast(6);
            myList.AddLast(7);
            myList.AddLast(8);

            myList.PrintLinkedList();
            Console.ReadLine();
        }
    }
}
