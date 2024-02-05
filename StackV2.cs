internal class StackV2
{
     //We declare the internal variables we will use throughout the class
    private int Size = 10;
    private int[] StackArray;
    private int TopPosition = -1;
    
    //StackV2 Constructor: If you DO NOT pass an input this constructor only generates the array for the predetermined 'Size'
    public StackV2()
    {
        StackArray = new int[Size];
    }

    //Stack V2() Constructor: If you DO pass an integer as an input, this constructor will generate an array with this 'newSize'
    public StackV2(int newSize)
    {
        Size = newSize;
        StackArray = new int[Size];
    }

    //Push() method: receives integer 'number', increases variable 'TopPosition' by one and assigns number to that element in the array
    public void Push(int number){
        if (TopPosition == Size-1){
            DoubleTheInternalArray();
        }
        TopPosition ++;
        StackArray[TopPosition] = number;
    }

    //Pop() method: eliminates the top value in the stack, reduces the 'TopPosition' by one and returns
    //the integer that was eliminated
    public int Pop(){
        if (TopPosition == -1){
            Console.WriteLine("Could not pop, stack underflow");
            return 0;
        }
        int numerito = StackArray[TopPosition];
        TopPosition = TopPosition - 1;
        return numerito;
    }

    //Peek() method: returns the top value of our stack
    public int? Peek(){
        if (TopPosition == -1){
            Console.WriteLine("Could not peek, empty stack");
            return null;
        }
        int numerito = StackArray[TopPosition];
        return numerito;
    }

    //PrintStack() method: prints the whole stack
    public void PrintStack(){
        Console.WriteLine("The number of elements in the stack is: " + (TopPosition + 1));
        for(int i =0; i <= TopPosition; i++){
            Console.WriteLine("position " + i + ": " + StackArray[i]);
        }
    }

    //DoubleTheInternalArray() method: This method doubles the size of the 'StackArray' so that we do not overflow the stack
    private void DoubleTheInternalArray(){
        int newSize = Size*2;
        int[] newStackArray = new int[newSize];

        for(int i=0; i<=TopPosition; i++){
            newStackArray[i] = StackArray[i];
        }
        StackArray = newStackArray;
        Size = newSize;
        Console.WriteLine("Resized the stack");
        Console.WriteLine("New size; " + newSize);
    }
}