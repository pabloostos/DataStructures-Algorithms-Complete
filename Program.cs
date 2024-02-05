internal class Program{
 private static int[] MagicMethod(int[] input) {



       if(input.Length <= 1) {

           return input;

       }



       int[] result = new int[input.Length];



       for(int i=input.Length-1;i>=0;i--) {

           result[input.Length-i-1] = input[i];

       }



       return result;

   }

    private static void Main(string[] args)
    {
        int[] array = new int[]{5,7,12,3,2,4,9,2,1};

        int[] magically = MagicMethod(array);

        for (int i= 0; i < magically.Length; i++){
            Console.WriteLine(magically[i]);
        }
    }
       
}