using System;

namespace HelloWorld
{
    class Program
    {
        static bool checkPalindrome(string inputString) {
string first = inputString.Substring(0,inputString.Length/2);//ab
    char[] arr=inputString.ToCharArray();
    Array.Reverse(arr);//caba
    Console.WriteLine(arr);
    string temp = new string(arr);//caba
    string second = temp.Substring(0,temp.Length/2);//ca
    Console.WriteLine(first);
    Console.WriteLine(second);
    return first.Equals(second);

}
//  int adjacentElementsProduct(int[] inputArray) {
    

//  }

   int firstDuplicate(int[] a) {
    
    for (int i=0;i<a.length;i++){
        if (a[i]==a[i++]){
            
        }
    }

}




        static void Main(string[] args) {
            //Console.WriteLine("Goodbye World!");
           // checkPalindrome("abac");
             int [] mark =  {1,2,3,4};
             Console.WriteLine( mark);
           //adjacentElementsProduct(mark);

    }
 }
}
