internal class Stack 
{
    private const int MaxElements = 10;
    //We declare the internal variables we will use throughout the class
    private int[] StackArray = new int[MaxElements];
    private int TopPosition = -1;

    //CreateStack() method: receives integer 'size' and creates an array of that size
    //public void CreateStack(int size){
        //StackArray = new int[size];
        //MaxElements = size;
    //}
    
    //Push() method: receives integer 'number', increases variable 'TopPosition' by one and assigns number to that element in the array
    public void Push(int number){
        if (TopPosition == MaxElements-1){
            Console.WriteLine("Could not push, stack overflow");
            return;
        }
        TopPosition ++;
        StackArray[TopPosition] = number;
    }

    //Pop() method: eliminates the top value in the stack, reduces the 'TopPosition' by one and returns
    //the integer that was eliminated
    public int? Pop(){
        if (TopPosition == -1){
            Console.WriteLine("Could not pop, stack underflow");
            return null;
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
        Console.WriteLine("The number of elements in the stack is: " + TopPosition + 1);
        for(int i =0; i <= TopPosition; i++){
            Console.WriteLine("position " + i + ": " + StackArray[i]);
        }
    }
}