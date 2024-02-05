public class LinkedIntList{

    public IntNode? Head;       // We create the first node of the Linked List, so it is going to be the "head" of our "snake"
    private int Size;            // Variable 'Size' will store the size of the LinkedList at every point in time

    //LinkedIntList() constructor: With this constructor we generate the LL and set Head to null and size 0
    public LinkedIntList(){
        Head = null; 
        Size = 0;
    }

    // LinkedIntList(IntNode node) constructor: With this constructor we generate the LL from one initial node
    // public LinkedIntList(IntNode node){
    //     Head = node; 
    //     Size = 1;
    // }

    // Add() method: appends (adds at the end of the LL) a node to the end of the Linked List
    public void Add(int value){
        IntNode NewNode = new IntNode();                    // NewNode we are going to append
        NewNode.Value = value;

        if (Head == null){
            Head = NewNode;
        }
        else {
            IntNode? node = Head;                           // Initialising node to iterate through the LL
            while (node.Next != null){                      // We position node on the last node of the LL
                node = node.Next;
            }
            node.Next = NewNode;                            // Point the last node to our NewNode, appending it.
        } 

        Size ++;                                            // Increasing size of LL 
    }

    // AddAtPosition() method: inserts a node at certain position in the LL (WARNING! position starts @ 0)
    public void AddAtPosition(int value, int position){

        if ((position > Size)||(position<0)){               // Checking if it is feasible to insert in the position specified.
            if (Head == null){
                Console.WriteLine("WARNING! The position specified exceeds the size of the LinkedList");
                Console.WriteLine("WARNING: The LinkedList is empty!");
            }
            else{
                Console.WriteLine(@"WARNING! The position specified exceeds the limits of the LinkedList");
                Console.WriteLine("The current size of the LinkedList is: " + Size);
                Console.WriteLine("The last index of the LinkedList (starting from 0) is: " + (Size-1));
            }
        }
        else if (position == Size){                         // If the position you want to insert the node is equal to the size, that meand it is like appending so we call the Add() method
            Add(value);                                     // Inserting at the end of the LL (appending)
            Console.WriteLine("Value (" + value + ") inserted at position: " + position);
        }
        else{                                               // If it is possible to insert
            IntNode NewNode = new IntNode();                // NewNode we are going to insert
            NewNode.Value = value;

            if ((position == 0) && (Head != null)){
                NewNode.Next = Head;
                Head = NewNode;
                Console.WriteLine("Value (" + value + ") inserted at position: " + position);
                Size ++; 
            }
            else {
                int CurrentPosition = 0;
                IntNode? node = Head;                       // Initialising node to iterate through the LL
                while (node != null){                       // Iterating through the list 
                    if (CurrentPosition == position - 1){   // Finding the position we want to insert the NewNode
                        NewNode.Next = node.Next;           // First, point NewNode.Next to node.Next so that we do not lose the rest of the LL
                        node.Next = NewNode;                // Then, we can point the previous node to the NewNode

                        Console.WriteLine("Value (" + value + ") inserted at position: " + position);
                        Size ++;                            // Increasing size of LL
                        break;                              // Breaking out of the while loop
                    }
                    node = node.Next;                       
                    CurrentPosition++;
                }
            }
        }
    }

    // RemoveEnd() method: this method removes the last node from the LL 
    public void RemoveEnd(){
        if (Head == null){                                  // Checking if the LL is empty
            Console.WriteLine("WARNING: Could not remove from the end, the LinkedList is empty!");
        }
        else if (Head.Next == null){                        // Checking if the LL only has one node
            Head = null; 
            Size = 0;
            Console.WriteLine("WARNING: Last element was removed, but there was only one element in the LinkedList!");
            Console.WriteLine("Now the LL is empty!");
        }
        else {                                              // If it is not empty nor Size=1 
            IntNode node = Head;                            // Initialising node to iterate through the LL
            IntNode PreviousNode = new IntNode();           // Initialising witness node that follows the iterating node
            while (node.Next != null){                      // Iterating through the list 
                PreviousNode = node;                    
                node = node.Next; 
            }
            PreviousNode.Next = null;                       // Once we find the last node with the iterating node we point the "witness node" (PreviousNode) to NULL, freeing (or removing) the last node 
            Size --;                                        // Decreasing size of LL
        }
    }

    // RemoveBeginning() method: this method removes the first node from the LL 
    public void RemoveBeginning(){
        if (Head == null){                                  // Checking if the LL is empty
            Console.WriteLine("WARNING: Could not remove from the end, the LinkedList is empty!");
        }
        else if (Head.Next == null){                        // Checking if the LL only has one node
            Head = null; 
            Size = 0;
            Console.WriteLine("WARNING: Last element was removed, but there was only one element in the LinkedList!");
            Console.WriteLine("Now the LL is empty!");
        }
        else {                                              // If it is not empty nor Size=1 
            Head = Head.Next;
            Size --;                                        // Decreasing size of LL
        }
    }

    // RemoveValue() method: removes ALL nodes that have a certain value that is passed as an input
    public void RemoveValue(int value){
        if (Head == null){                                  // Checking if the LL is empty
            Console.WriteLine("WARNING: Could not remove value (" + value + "), the LinkedList is empty!");
        }
        else{
            IntNode? node = Head;                           // Initialising node to iterate through the LL       
            IntNode? PreviousNode = new IntNode();          // Initialising witness node that follows the iterating node   
            PreviousNode = node;
            while ((node != null) && (Head != null)){       // Iterating through the full LL
                if(Head.Value == value){                    // If the value we want to remove is in the first node
                    Head = node.Next;                       // Point the head to the next node or null
                    Console.WriteLine("Removed value: " + value);
                    Size --;                                // Decreasing size of LL
                    return;
                }
                else if ((node.Value == value) && (PreviousNode != null)){
                    PreviousNode.Next = node.Next;          // Pointing 'PreviousNode' to next node (this way we remove that value)
                    node = node.Next;                       // WARNING! In this case I do not set 'PreviousNode = node'
                    Console.WriteLine("Removed value: " + value); 
                    Size --;                                // Decreasing size of LL
                    return;
                }
                else{
                    PreviousNode = node; 
                    node = node.Next;
                }
            }
            Console.WriteLine("The LinkedList does not contain the value: " + value);
        }
    }

    // Clear() method: sets the head to null so that you lose all the LinkedList links
    public void Clear(){
        Head = null;                                        // Pointing the head to NULL we lose the rest of the LL
        Size = 0;                                           // We don't have a LL anymore so size = 0
        Console.WriteLine("LinkedList cleared!");
    }

    // Contains() method: Goes through the LinkedList and checks if a value is contained in the LinkedList
    public bool Contains(int value){
        IntNode? node = Head;                               // Initialising node to iterate through the LL
        while (node != null){                               // Iterating through the full LL
            if (node.Value == value){                       // If we find the value we are looking for we return True
                Console.WriteLine("The LinkedList contains the value: " + value);
                return true;
            }
            node = node.Next;
        }
        Console.WriteLine("The LinkedList does not contain the value: " + value);
        return false;                                       // If we exit the while loop it means we haven't found the value and we return False
    }

    // GetSize() method: returns the size of the LL
    public int GetSize(){
        return Size; 
    }

    // PrintLinkedList() method: prints all the values in the LinkedList
    public void WriteInformation(){
        if (Size == 0){
            Console.WriteLine("The LinkedList is empty. Its size is: " + Size);
            Console.WriteLine();
        }
        else{
            Console.WriteLine("The size of the LinkedList is: " + Size);
            Console.WriteLine("The last position (starting at 0) in the LinkedList is: " + (Size-1));
            Console.WriteLine();
            Console.WriteLine("The elements in the LinkedList are: ");

            int i = 0;
            IntNode? node = Head;                           // Initialising node to iterate through the LL
            while (node != null){                           // Iterating though the full list
                Console.WriteLine("Position " + i + ": " + node.Value);
                node = node.Next;
                i ++;
            }
            Console.WriteLine("------------------------------------");
        }
    }

    // GetIntArray() method: this method creates an array of the specific size of the LL 
    // and inserts each value in its corresponding spot in the array
    public int[] GetIntArray(){
        int[] MyArray = new int[Size];                      // Creating the array of specific size

        int i = 0; 
        IntNode? node = Head;                               // Initialising the node to iterate through the LL
        while (node != null){                               // Iterating through the full list
            MyArray[i] = node.Value;                        // Inserting each value to the corresponding element of the array
            node = node.Next;       
            i ++;
        }
        return MyArray;                                     // Returns the array we want
    }

}
