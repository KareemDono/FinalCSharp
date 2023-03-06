using System;

namespace FinalCSharp
{

    class Program
    {
        static void Main(string[] args)
        {
            //Node<int> Tests:
            Node<int> node = new Node<int>(5);
            Node<int> node2 = new Node<int>(10);
            Node<int> node3 = new Node<int>(15);
            node.SetNext(node2);
            Node<int> node4 = new Node<int>(20);
            node3.SetNext(node4);
            Node<int> LinkedList = node;
            Console.WriteLine();

            //1
            Console.WriteLine($"the length of the list is : { ListLength(LinkedList)}");
            Console.WriteLine("--------------------------------------");
            //2
            Console.WriteLine("printing list");
            Print(LinkedList);
            Console.WriteLine("--------------------------------------");

            //3
            Console.WriteLine("Adding first value");
            LinkedList = AddFirst(LinkedList, 0);
            Console.WriteLine(LinkedList);
            Console.WriteLine("--------------------------------------");

            //4
            Console.WriteLine("Adding last value");
            AddLast(LinkedList, 25);
            Console.WriteLine(LinkedList);
            Console.WriteLine("--------------------------------------");

            //5
            Console.WriteLine("Adding in the middle.");
            AddAfter(LinkedList,10);
            Print(LinkedList);
            Console.WriteLine("--------------------------------------");

            //6
            Console.WriteLine("Deleting first value");
            LinkedList = DeleteFirst(LinkedList);
            Print(LinkedList);
            Console.WriteLine("--------------------------------------");

            //7
            Console.WriteLine("Deleting last value");
            DeleteLast(LinkedList);
            Print(LinkedList);
            Console.WriteLine("--------------------------------------");

            //8
            Console.WriteLine("Deleting the value in the middle");
            DeleteAfter(LinkedList);
            Print(LinkedList);
            Console.WriteLine("--------------------------------------");

            //9
            Console.WriteLine("First index value");
            Console.WriteLine(FirstValue(LinkedList));
            Print(LinkedList);
            Console.WriteLine("--------------------------------------");

            //10
            Console.WriteLine("last index value");
            Console.WriteLine(LastValue(LinkedList));
            Print(LinkedList);
            Console.WriteLine("--------------------------------------");

            //11
            Console.WriteLine($"Value at index 0: {ValueInIndex(0, LinkedList)}");
            Print(LinkedList);
            Console.WriteLine("--------------------------------------");

            //12
            Console.WriteLine("does this list contain this value? enter the value");
            int num = int.Parse(Console.ReadLine());
            if (Contains(LinkedList, num) == true)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
            Print(LinkedList);
            Console.WriteLine("--------------------------------------");

            //13
            Console.WriteLine("is the linked list circular?");
            Node<int> newCircular = new Node<int>(2);
            newCircular.SetNext(new Node<int>(3, new Node<int>(4, newCircular)));
            Console.WriteLine(isItCircular(newCircular));
            Console.WriteLine("--------------------------------------");

            //14
            AddLast(LinkedList, 10);
            Print(LinkedList);
            Console.WriteLine("Linked List without duplicates: ");
            Console.WriteLine(ListNoDuplicates(LinkedList));
            Console.WriteLine("--------------------------------------");

            //15
            Console.WriteLine("Copying the list");
            Print(LinkedList);
            Node<int> copyList = CopyList(LinkedList);
            Print(copyList);
            Console.WriteLine("--------------------------------------");

            //16
            AddLast(LinkedList, 5);
            Console.WriteLine("Before Reverse: ");
            Print(LinkedList);
            Console.WriteLine("Print Linked List but reversed");
            PrintListFromEndToStart(LinkedList);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");

            //17
            Node<int> list = new Node<int>(88, new Node<int>(55, new Node<int>(40, new Node<int>(89))));
            Console.WriteLine("Unsorted List: ");
            Print(list);
            Console.WriteLine("Sorted List: ");
            LowestToHighestSort(list);
            Console.WriteLine(list);
            Console.WriteLine("--------------------------------------");

            //18
            Console.WriteLine("Are these two lists Equal?");
            Node<int> firstList = new Node<int>(1, new Node<int>(2, new Node<int>(3, new Node<int>(4))));
            Node<int> secondList = new Node<int>(2, new Node<int>(4, new Node<int>(6, new Node<int>(8))));
            Print(firstList);
            Print(secondList);
            Console.WriteLine(IsEqual(firstList, secondList));
            Console.WriteLine("--------------------------------------");

            //19
            Console.WriteLine("Merge two lists:");
            Node<int> MergeTwoLists = MergeTwoListsFully(firstList, secondList);
            Print(MergeTwoLists);
            
            Console.WriteLine("--------------------------------------");

            //20
            Console.WriteLine("Merge the first and second list without duplicates:");
            Node<int> thirdList = new Node<int>(1, new Node<int>(2, new Node<int>(3, new Node<int>(4))));
            Node<int> fourthList = new Node<int>(2, new Node<int>(4, new Node<int>(6, new Node<int>(8))));
            Print(thirdList);
            Print(fourthList);
            Node<int> mergedList = MergeListsWithoutDuplicates(thirdList, fourthList);
            Print(mergedList);
            Console.WriteLine("--------------------------------------");

            //21
            Console.WriteLine("Internal merge only unique values from both lists");
            Node<int> internalMergeList = MergeCommonElements(thirdList, fourthList);
            Print(internalMergeList);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("***************************************************************************************************************");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("***************************************************************************************************************");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();


            //Node<Worker> Tests:
            Worker Worker1 = new Worker("Kareem", 6000);
            Worker Worker2 = new Worker("Tayeb",  7000);
            Worker Worker3 = new Worker("Abdallah", 5000);
            Node<Worker> Workers = new Node<Worker>();
            Workers = AddFirst(Workers, Worker3);
            Workers = AddFirst(Workers, Worker2);
            Workers = AddFirst(Workers, Worker1);

            //1.
            Console.WriteLine($"The worker list  Length is : {ListLength(Workers)} ");
            Console.WriteLine("--------------------------------------");


            //2. 
            Console.WriteLine("Print Workers list: ");
            Print(Workers);
            Console.WriteLine("--------------------------------------");


            //3.
            Console.WriteLine("Adding a new worker in the beginning: ");
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());
            Worker newWorkerFirst = new Worker(name, salary);
            Workers = AddFirst(Workers, newWorkerFirst);
            Print(Workers);
            Console.WriteLine("--------------------------------------");

            //4.
            Console.WriteLine("Adding a new worker in the end: ");
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            salary = double.Parse(Console.ReadLine());
            Worker newWorkerLast = new Worker(name, salary);
            AddLast(Workers, newWorkerLast);
            Print(Workers);
            Console.WriteLine("--------------------------------------");


            //5.
            Console.WriteLine("Adding a Worker after The sent Worker as parameter:  ");
            AddAfter(Workers, Worker1);
            Print(Workers);
            Console.WriteLine("--------------------------------------");

            //6.
            Console.WriteLine("Deleting The First Worker.");
            Workers = DeleteFirst(Workers);
            Print(Workers);
            Console.WriteLine("--------------------------------------");

            //7
            Console.WriteLine("Deleting The Last Worker.");
            DeleteLast(Workers);
            Print(Workers);
            Console.WriteLine("--------------------------------------");

            //8
            Console.WriteLine("Deleting The middle Worker.");
            DeleteAfter(Workers);
            Print(Workers);
            Console.WriteLine("--------------------------------------");

            //9
            Console.WriteLine("The First Worker is: ");
            Console.WriteLine(FirstValue(Workers));
            Console.WriteLine("--------------------------------------");



            //11
            Console.WriteLine("The Worker that is in the given index: ");
            Console.WriteLine("index input: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Value is {ValueInIndex(index, Workers)}");
            Console.WriteLine("--------------------------------------");

            //12
            Console.WriteLine("Does this worker contain in the workers list?");
            if ((Contains(Workers, Worker2) == true))
            {
                Console.WriteLine("Yes.");
            }
            else Console.WriteLine("No.");
            Console.WriteLine("--------------------------------------");


            //13
            Console.WriteLine("is it circular?");
            Node<Worker> worker = new Node<Worker>();
            worker.SetNext(new Node<Worker>(Worker2, new Node<Worker>(Worker1, worker)));
            Console.WriteLine(isItCircular(worker));
            Console.WriteLine("--------------------------------------");


            //14
            Console.WriteLine("Original list: ");
            Worker Worker4 = new Worker("Abdallah", 5000);
            AddLast(Workers, Worker4);
            Print(Workers);
            Console.WriteLine("No duplicates Workers list: ");
            Print(ListNoDuplicates(Workers));
            Console.WriteLine("--------------------------------------");

            //15
            Console.WriteLine("Original list: ");
            Print(Workers);
            Console.WriteLine("Copy list: ");
            Node<Worker> copyWorker = CopyList(Workers);
            Print(copyWorker);
            Console.WriteLine("--------------------------------------");


            //16
            Console.WriteLine("Reversed Workers List");
            PrintListFromEndToStart(Workers);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");


            //17
            Console.WriteLine("Sorting the list: ");
            Worker w1 = new Worker("John", 2000);
            Worker w2 = new Worker("Jane", 1500);
            Worker w3 = new Worker("Jack", 1800);
            Worker w4 = new Worker("Jim", 2200);
            Node<Worker> head = new Node<Worker>(w1);
            head.SetNext(new Node<Worker>(w2));
            head.GetNext().SetNext(new Node<Worker>(w3));
            head.GetNext().GetNext().SetNext(new Node<Worker>(w4));
            Console.WriteLine("Unsorted Linked List:");
            Console.WriteLine(head);
            LowestToHighestSort(head);
            Console.WriteLine("Sorted Linked List:");
            Console.WriteLine(head);
            Console.WriteLine("--------------------------------------");

            //18
            Console.WriteLine("are these two lists the same?");
            Console.WriteLine("first list:");
            Print(Workers);
            Console.WriteLine("second list:");
            Print(CopyList(Workers));
            Console.WriteLine(IsEqual(Workers, CopyList(Workers)));
            Console.WriteLine("--------------------------------------");

            //19
            Console.WriteLine("Workers List Merge: ");
            Node<Worker> list1 = new Node<Worker>(new Worker("John", 50000));
            list1.SetNext(new Node<Worker>(new Worker("Mary", 60000)));
            list1.GetNext().SetNext(new Node<Worker>(new Worker("Bob", 40000)));
            Node<Worker> list2 = new Node<Worker>(new Worker("Alice", 55000));
            list2.SetNext(new Node<Worker>(new Worker("David", 45000)));
            list2.GetNext().SetNext(new Node<Worker>(new Worker("Karen", 65000)));
            Node<Worker> workerMerge = MergeTwoListsFully(list1, list2);
            Print(workerMerge);
            Console.WriteLine("--------------------------------------");

            //20
            Console.WriteLine("List Without Duplicates:");
            Node<Worker> list3 = new Node<Worker>(new Worker("John", 1000.0));
            AddLast(list3, new Worker("Jane", 2000.0));
            AddLast(list3, new Worker("Bob", 1500.0));
            Node<Worker> list4 = new Node<Worker>(new Worker("Bob", 1500.0));
            AddLast(list4, new Worker("Mary", 3000.0));
            AddLast(list4, new Worker("Jane", 2000.0));
            Node<Worker> mergedListWithoutDuplicates = MergeListsWithoutDuplicates(list3, list4);
            Print(mergedListWithoutDuplicates);
            Console.WriteLine("--------------------------------------");

            //21
            Console.WriteLine("Print the Duplicates: ");
            Node<Worker> duplicates = MergeCommonElements(list3, list4);
            Print(duplicates);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("***************************************************************************************************************");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("***************************************************************************************************************");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            //23,24,25
            //23
            Course Course1 = new Course(1,80);
            Course Course2 = new Course(2,87);
            Course Course3 = new Course(3,80);
            Course Course4 = new Course(4, 88);

            Node<Course> CoursesList1 = new Node<Course>();
            CoursesList1 = AddFirst(CoursesList1, Course1);
            CoursesList1 = AddFirst(CoursesList1, Course2);

            Node<Course> CoursesList2 = new Node<Course>();
            CoursesList2 = AddFirst(CoursesList2, Course3);
            CoursesList2 = AddFirst(CoursesList2, Course4);

            Student Student1 = new Student("kareem", "jumaa", CoursesList1);
            Student Student2 = new Student("tayeb", "haj yahya", CoursesList2);
            Student Student3 = new Student("elyahu", "elyahu", CoursesList1);

            Node<Student> Students = new Node<Student>();
            Students = AddFirst(Students, Student3);
            Students = AddFirst(Students, Student2);
            Students = AddFirst(Students, Student1);

            StudentsAverage(Students);
            Console.WriteLine("--------------------------------------");

            //24
            Student Student5 = new Student("amir", "qasem", CoursesList2);
            Student Student6 = new Student("fadi", "haj yahya", CoursesList1);
            Student Student7 = new Student("anita", "anita", CoursesList1);

            Students = AddFirst(Students, Student5);
            Students = AddFirst(Students, Student6);
            Students = AddFirst(Students, Student7);

            Node<Student[]> Classroom = new Node<Student[]>();
            Student[] classroom1 = new Student[] { Student1, Student2, Student3 };
            Student[] classroom2 = new Student[] { Student6, Student5, Student7 };
            Student[] classroom3 = new Student[] { Student2, Student1, Student3 };

            Classroom = AddFirst(Classroom, classroom1);
            Classroom = AddFirst(Classroom, classroom2);
            Classroom = AddFirst(Classroom, classroom3);

            Console.WriteLine("the highest student average is : ");
            Node<Student> highest = HighestStudentAVG(Classroom);
            Print(highest);
            Console.WriteLine("--------------------------------------");

            //25
            Console.WriteLine("The lowest student average is: ");
            Node<Student> lowest = LowestStudent(Classroom);
            Console.WriteLine(lowest);


        }

        //1. List Length
        public static int ListLength<T>(Node<T> linkedList)
        {
            int length = 0;
            while (linkedList != null)
            {
                length++;
                linkedList = linkedList.GetNext();
            }
        return length;
        }

        //2. Printing the list
        public static void Print<T>(Node<T> linkedList)
        {
            Console.WriteLine(linkedList);
        }

        //3.Add value in the beginning
        public static Node<T> AddFirst<T>(Node<T> linkedList, T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.SetNext(linkedList);
            linkedList = newNode;
            return linkedList;
        }

        //4.Add value at the end
        public static void AddLast<T>(Node<T> head, T value)
        {
            Node<T> newNode = new Node<T>(value);
            while (head.HasNext())
            {
                head = head.GetNext();
            }
            head.SetNext(newNode);
        }

        //5.Add a value in the middle
        public static void AddAfter<T>(Node<T> prev, T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.SetNext(prev.GetNext());
            prev.SetNext(newNode);
        }

        //6.Delete value in the beginnning.
        public static Node<T> DeleteFirst<T>(Node<T> list)
        {
            Node<T> temp = list;
            list = list.GetNext();
            temp.SetNext(null);
            return list;
        }

        //7.Delete value at the end
        public static void DeleteLast<T>(Node<T> head)
        {
            Node<T> prev = null;
            Node<T> temp = head;
            while (temp.HasNext())
            {
                prev = temp;
                temp = temp.GetNext();
            }
            prev.SetNext(null);
        }

        //8.Delete the middle value
        public static void DeleteAfter<T>(Node<T> prev)
        {
            if (prev != null && prev.HasNext())
            {
                Node<T> temp = prev.GetNext();
                prev.SetNext(temp.GetNext());
                temp.SetNext(null);
            }
        }

        //9.Return the first value
        public static T FirstValue<T>(Node<T> linkedList)
        {
            return linkedList.GetValue();
        }

        //10.Return the last value
        public static T LastValue<T>(Node<T> linkedList)
        {
            Node<T> current = linkedList;
            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }

            return current.GetValue();
        }

        //11.Return value via sent index.
        public static T ValueInIndex<T>(int index, Node<T> linkedList)
        {
            Node<T> current = new Node<T>();
            Node<T> list = linkedList;
            while (index > ListLength(linkedList))
            {
                Console.WriteLine("invalid index.");
                Console.WriteLine("Enter an index to find its value: ");
                index = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ListLength(linkedList); i++)
            {
                if (i == index)
                {

                    return list.GetValue();
                }
                list = list.GetNext();
            }
            return current.GetValue();
        }

        //12.Checking if sent value is in the linked list
        public static bool Contains<T>(Node<T> linkedList, T value)
        {
            if (linkedList == null)
                return false;
            while (linkedList != null)
            {
                if (linkedList.GetValue().Equals(value))
                {
                    return true;
                }

                linkedList = linkedList.GetNext();
            }
            return false;
        }

        //13.Checking if list is circular.
        public static bool isItCircular<T>(Node<T> head)
        {
            if (head == null) 
            {
                return true;
            }
            Node<T> node = head.GetNext();
            while (node != null && node != head)
            {
                node = node.GetNext();
            }
            return (node == head);
        }

        //14.List Without Duplicates
        public static Node<T> ListNoDuplicates<T>(Node<T> list)
        {
            if (list == null) 
            {
                return null;
            }
            Node<T> newList = new Node<T>(list.GetValue());
            Node<T> temp = newList;
            list = list.GetNext();
            while (list != null)
            {
                if (!Contains(newList, list.GetValue()))
                {
                    Node<T> newNode = new Node<T>(list.GetValue());
                    temp.SetNext(newNode);
                    temp = temp.GetNext();
                }
                list = list.GetNext();
            }
            return newList;
        }

        //15. Copy list
        public static Node<T> CopyList<T>(Node<T> linkedList)
        {
            return new Node<T>(linkedList);
        }

        //16. Print List from end to start.
        public static void PrintListFromEndToStart<T>(Node<T> list)
        {
            if (list == null)
            {
                return;
            }
            PrintListFromEndToStart(list.GetNext());
            Console.Write(list.GetValue() + " ");
        }

        //17.Sort from lowest to highest
        public static void LowestToHighestSort<T>(Node<T> head) where T : IComparable<T>
        {
            Node<T> curr = head;
            while (curr != null)
            {
                Node<T> min = curr;
                Node<T> temp = curr.GetNext();
                while (temp != null)
                {
                    if (temp.GetValue().CompareTo(min.GetValue()) < 0)
                    {
                        min = temp;
                    }
                    temp = temp.GetNext();
                }
                T value = curr.GetValue();
                curr.SetValue(min.GetValue());
                min.SetValue(value);
                curr = curr.GetNext();
            }
        }
        //18.are two lists equal
        public static bool IsEqual<T>(Node<T> firstList, Node<T> secoundList)
        {
            if (ListLength(firstList) != ListLength(secoundList))
            {
                return false;
            }
            Node<T> First = new Node<T>(firstList.GetValue());
            Node<T> Second = new Node<T>(secoundList.GetValue());

            while (First != null && Second != null)
            {
                if (!First.GetValue().Equals(Second.GetValue()))
                {
                    return false;
                }

                First = First.GetNext();
                Second = Second.GetNext();
            }
            return true;
        }

        //19.Complete Merge
        public static Node<T> MergeTwoListsFully<T>(Node<T> list1, Node<T> list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;
            Node<T> MergedList = new Node<T>(list1);
            Node<T> second = new Node<T>(list2);
            for (int i = 0; i <= ListLength(second); i++)
            {

                AddLast(MergedList, second.GetValue());
                second = second.GetNext();
            }
            return MergedList;
        }


        //20.Merge without duplicates
        public static Node<T> MergeListsWithoutDuplicates<T>(Node<T> list1, Node<T> list2)
        {
            Node<T> mergedList = null, current = null;
            for (Node<T> node1 = list1; node1 != null; node1 = node1.GetNext())
            {
                bool foundInMergedList = false;
                for (Node<T> node2 = mergedList; node2 != null; node2 = node2.GetNext())
                {
                    if (node1.GetValue().Equals(node2.GetValue()))
                    {
                        foundInMergedList = true;
                        break;
                    }
                }
                if (!foundInMergedList)
                {
                    Node<T> newNode = new Node<T>(node1.GetValue());

                    if (mergedList == null)
                    {
                        mergedList = newNode;
                        current = newNode;
                    }
                    else
                    {
                        current.SetNext(newNode);
                        current = newNode;
                    }
                }
            }
            for (Node<T> node2 = list2; node2 != null; node2 = node2.GetNext())
            {
                bool foundInMergedList = false;
                for (Node<T> node1 = mergedList; node1 != null; node1 = node1.GetNext())
                {
                    if (node2.GetValue().Equals(node1.GetValue()))
                    {
                        foundInMergedList = true;
                        break;
                    }
                }
                if (!foundInMergedList)
                {
                    Node<T> newNode = new Node<T>(node2.GetValue());

                    if (mergedList == null)
                    {
                        mergedList = newNode;
                        current = newNode;
                    }
                    else
                    {
                        current.SetNext(newNode);
                        current = newNode;
                    }
                }
            }

            return mergedList;
        }

        //21.new list with only the values that are in both lists
        public static Node<T> MergeCommonElements<T>(Node<T> list1, Node<T> list2)
        {
            Node<T> mergedList = null, current = null;
            for (Node<T> node1 = list1; node1 != null; node1 = node1.GetNext())
            {
                bool foundInList2 = false;
                for (Node<T> node2 = list2; node2 != null; node2 = node2.GetNext())
                {
                    if (node1.GetValue().Equals(node2.GetValue()))
                    {
                        foundInList2 = true;
                        break;
                    }
                }
                if (foundInList2)
                {
                    bool foundInMergedList = false;
                    for (Node<T> node3 = mergedList; node3 != null; node3 = node3.GetNext())
                    {
                        if (node1.GetValue().Equals(node3.GetValue()))
                        {
                            foundInMergedList = true;
                            break;
                        }
                    }
                    if (!foundInMergedList)
                    {
                        Node<T> newNode = new Node<T>(node1.GetValue());

                        if (mergedList == null)
                        {
                            mergedList = newNode;
                            current = newNode;
                        }
                        else
                        {
                            current.SetNext(newNode);
                            current = newNode;
                        }
                    }
                }
            }
            return mergedList;
        }


        //23.Print students average
        public static void StudentsAverage(Node<Student> students)
        {
            if (students == null)
            {
                return;
            }

            Node<Student> currentStudent = new Node<Student>(students);
            for (int i = 0; i < ListLength(students); i++)
            {
                if (currentStudent == null || currentStudent.GetValue() == null)
                {
                    return;
                }
                Console.WriteLine($"Student Name : {currentStudent.GetValue().GetFirstName()} His Average is : {currentStudent.GetValue().Average()}");
                currentStudent = currentStudent.GetNext();
            }
        }


        //24. Print Best students
        public static Node<Student> HighestStudentAVG(Node<Student[]> classroom)
        {
            Node<Student[]> studentsArr = new Node<Student[]>(classroom.GetValue());
            Node<Student> highestStudents = new Node<Student>();

            while (studentsArr != null)
            {
                int index = 0;
                for (int i = 1; i < studentsArr.GetValue().Length; i++)
                {
                    if (studentsArr.GetValue()[i].Average() > studentsArr.GetValue()[i - 1].Average())
                        index = i;
                    else
                        index = i - 1;
                }
                highestStudents = AddFirst(highestStudents, studentsArr.GetValue()[index]);
                studentsArr = studentsArr.GetNext();
            }

            return highestStudents;
        }

        //25. Print Worst Students
        public static Node<Student> LowestStudent(Node<Student[]> classroom)
        {
            Node<Student[]> studentsArr = new Node<Student[]>(classroom.GetValue());
            Node<Student> lowestStudents = new Node<Student>();
            while (studentsArr != null)
            {
                int index = 0;
                for (int i = 1; i < studentsArr.GetValue().Length; i++)
                {
                    if (studentsArr.GetValue()[i].Average() < studentsArr.GetValue()[i - 1].Average())
                        index = i;
                    else
                        index = i - 1;
                }
                lowestStudents = AddFirst(lowestStudents, studentsArr.GetValue()[index]);

                studentsArr = studentsArr.GetNext();
            }
            return lowestStudents;
        }
    }


}
