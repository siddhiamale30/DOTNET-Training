using System;
class bubble{
    public static void Main(string[] args){
        int[] arr={6,5,2,7,3};
        for(int i=0;i<arr.Length-1;i++){
            for(int j=0;j<arr.Length-i-1;j++){
                if(arr[j]>arr[j+1]){
                int temp=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
            }
            }
            
        }
        for(int i=0;i<=arr.Length-1;i++){
            Console.WriteLine(arr[i]);
        }
    }
}