internal class Queue
{
     //We declare the internal variables we will use throughout the class
    private int Size;
    private int[] QueueArray;
    private int TopPosition = -1;
    private int BottomPosition = -1;

     //Queue Constructor: If you DO NOT pass an input this constructor only generates the array for the predetermined 'Size'
    public Queue(){
        Size = 10;
        QueueArray = new int[Size];
    }

    //Queue Constructor: If you DO pass an integer as an input, this constructor will generate an array with this 'newSize'
    public Queue(int newSize){
        Size = newSize;
        QueueArray = new int[Size];
    }
    
    //Enqueue() method: receives integer 'number', increases variable 'TopPosition' by one and assigns number to that element in the array
    public void Enqueue(int number){
        if (TopPosition == Size-1){
            Console.WriteLine("Cannot Enqueue, the queue is full");
            return;
        }
        else{
            if ((BottomPosition==-1)&&(TopPosition==-1)){
                BottomPosition++;
                TopPosition++;
            }
            else{
                TopPosition++;
            }
            QueueArray[TopPosition] = number;
        } 
    }

    //Dequeue() method: eliminates the bottom value in the stack, increases the 'BottomPosition' by one and returns
    //the integer that was eliminated
    public int Dequeue(){
        if (BottomPosition < 0 || BottomPosition > TopPosition){
            Console.WriteLine("Cannot Dequeue, the queue is empty");
            return 0;
        }
        else{
            int numerito = QueueArray[BottomPosition];
            if (BottomPosition==TopPosition){
                BottomPosition = -1;
                TopPosition = -1;
            }
            else{
                BottomPosition++;
            }
            return numerito;
        }
    }

    //Peek() method: returns the Bottom value of our stack
    public int Peek(){
        if ((BottomPosition < 0) || (BottomPosition > TopPosition)){
            Console.WriteLine("Cannot Dequeue, the queue is empty");
            return 0;
        }
        else{
            int numerito = QueueArray[BottomPosition];
            return numerito;
        }
    }

    //PrintStack() method: prints the whole stack
    public void PrintQueue(){
        Console.WriteLine("The number of elements in the stack is: " + (TopPosition + 1));
        Console.WriteLine("The TopPosition of the Queue is in the index " + TopPosition + " of the array.");
        Console.WriteLine("The BottomPosition of the Queue is in the index " + BottomPosition + " of the array.");
        if (BottomPosition >= 0){
            for(int i =BottomPosition; i <= TopPosition; i++){
                Console.WriteLine("position " + (i-BottomPosition) + ": " + QueueArray[i]);
            }
        }
    }

    //ReorganiseQueue() method: I don't think I use it, but it rearranges the array so that all values are at the beginning of the array
    private void ReorganiseQueue(){
        int j = 0;
        for(int i = BottomPosition; i<=TopPosition; i++){
            QueueArray[j] = QueueArray[i]; 
        }
        Console.WriteLine("The queue was reorganised correctly");
    }

    //DoubleTheInternalArray() method: This method doubles the size of the 'StackArray' so that we do not overflow the stack
    private void DoubleTheInternalArray(){
        int newSize = Size*2;
        int[] newQueueArray = new int[newSize];

        for(int i=0; i<=TopPosition; i++){
            newQueueArray[i] = QueueArray[i];
        }
        QueueArray = newQueueArray;
        Size = newSize;
        Console.WriteLine("Resized the queue");
        Console.WriteLine("New size; " + newSize);
    }
}