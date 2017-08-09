
using System;
					
public class Program
{
	public static void Main()
	{
		bool isAscending = IsAscOrder(new int[]{1,2,3,5,5});
		Console.WriteLine("Is 1 2 3 5 5 is ascending : " + isAscending);
		Console.WriteLine(" ****************************** ");
		
		int index = FindEvenIndex(new int[] {1,100,50,-51,1,1});
		Console.WriteLine("Index for 1,3,4,-51,4,1,3 is  : " + index);
		Console.WriteLine(" ****************************** ");
	}
	
	public static int CalculateYears(Double principal, Double interest, Double tax, Double desiredPrincipal)
	{
		try{
			if(principal > desiredPrincipal || principal == desiredPrincipal)
				return 0;
			int years = 0;
			Double amount = principal;
			
			while(amount < desiredPrincipal){
				Double new_interest = amount*interest;
				Double tax_On_interest = new_interest * tax;
				amount = amount + new_interest - tax_On_interest;
				years++;
			}
			
			return years;
		}catch(Exception){
			throw;
		}
		
	}
	
	public static int getRangeSum(int[] arr, int start, int end){
		int sum = 0;
		
		for(int i=start;i<= end;i++){
			sum+= arr[i];			
		}
		
		return sum;
	}
	
	public static int FindEvenIndex(int[] arr)
	{
		try{
			int index = -1;
			int arr_length = arr.Length;
			if(arr_length > 2){
				for(int i=1;i< (arr_length -1);i++){
					int part1_start = 0;
					
					int part1_end = i-1;
					
					int part2_start = i+1;
					
					int part2_end = arr.Length-1;
					
					int part1_sum = getRangeSum(arr, part1_start,part1_end);
					
					int part2_sum = getRangeSum(arr, part2_start,part2_end);
					
					if(part1_sum == part2_sum){
						index = i;
						break;
					}
						
				}
			}
			return index;
			
		}catch(Exception){
			return -1;
		}
		
	}
	
	public static bool IsAscOrder(int[] arr){
		
		try{
			bool isAscending = true;
			int arr_length = arr.Length;
			if(arr_length > 0){
				for(int i=0;i< (arr_length -1);i++){
					if(arr[i] > arr[i+1] && arr[i] != arr[i+1]){
						isAscending = false; 
						break;
					}			
				}
			}else
				isAscending = false; 
			return isAscending;	
		}catch(Exception ex){
			throw ex;		
		}
		
	}
	
	public static int GetSum(int a, int b)
	{
		/*

		1. Given two integers, a and b, find the inclusive sum of all the integers between them and
		return it. If a equals b, return either a or b. Note that a and b are not ordered and that
		integers can be either positive or negative.
		Example:
			GetSum(1, 0) == 1   // 1 + 0 = 1
			GetSum(1, 2) == 3   // 1 + 2 = 3
			GetSum(0, 1) == 1   // 0 + 1 = 1
			GetSum(1, 1) == 1   // 1 Since both are same
			GetSum(-1, 0) == -1 // -1 + 0 = -1
			GetSum(-1, 2) == 2  // -1 + 0 + 1 + 2 = 2
			public int GetSum(int a, int b)
			{
			//write your code here!
			}
		
		*/
		try{
			//write your code here!
			if(a == null || b ==null)
				throw new ArgumentNullException("Any of the parameters can't be null");
			int sum = 0;
			if(a == b) return a;
			int start = a < b ? a : b;
			//Console.WriteLine("Start : " + start);
			int end = start == a ? b : a;
			//Console.WriteLine("End x : " + end);
			
			for(int i=start;i<=end;i++){
				sum += i;
				
			}
			
			return sum;	
		}catch(Exception ex){
			throw ex;	
		}
	    
		
	}
	
	
}