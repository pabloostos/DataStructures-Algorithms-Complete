internal class CharStack
{
     //We declare the internal variables we will use throughout the class
    private int Size = 10;  //Default value for the 'CharStackArray'
    private char[] CharStackArray;
    private int TopPosition = -1;
    
    //StackV2 Constructor: If you DO NOT pass an input this constructor only generates the array for the predetermined 'Size'
    public CharStack()
    {
        CharStackArray = new char[Size];
    }

    //Stack V2() Constructor: If you DO pass an integer as an input, this constructor will generate an array with this 'newSize'
    public CharStack(int newSize)
    {
        Size = newSize;
        CharStackArray = new char[Size];
    }

    //Push() method: receives char 'character', increases variable 'TopPosition' by one and assigns 'character' to that element in the array
    public void Push(char character){
        if (TopPosition == Size-1){
            DoubleTheInternalArray();
        }
        TopPosition ++;
        CharStackArray[TopPosition] = character;
    }

    //Pop() method: eliminates the top character in the stack, reduces the 'TopPosition' by one and returns
    //the character that was eliminated
    public char Pop(){
        if (TopPosition == -1){
            Console.WriteLine("Could not pop, stack underflow");
            return '0';
        }
        char characterito = CharStackArray[TopPosition];
        TopPosition = TopPosition - 1;
        return characterito;
    }

    //Peek() method: returns the top character of our stack
    public char Peek(){
        if (TopPosition == -1){
            Console.WriteLine("Could not peek, empty stack");
            return '0';
        }
        char characterito = CharStackArray[TopPosition];
        return characterito;
    }

    //PrintStack() method: prints the whole stack
    public void PrintStack(){
        Console.WriteLine("The number of elements in the stack is: " + (TopPosition + 1));
        for(int i =0; i <= TopPosition; i++){
            Console.WriteLine("position " + i + ": " + CharStackArray[i]);
        }
    }

    //DoubleTheInternalArray() method: This method doubles the size of the 'CharStackArray' so that we do not overflow the stack
    private void DoubleTheInternalArray(){
        int newSize = Size*2;
        char[] newCharStackArray = new char[newSize];

        for(int i=0; i<=TopPosition; i++){
            newCharStackArray[i] = CharStackArray[i];
        }
        CharStackArray = newCharStackArray;
        Size = newSize;
        Console.WriteLine("Resized the array");
        Console.WriteLine("New size; " + newSize);
    }
}