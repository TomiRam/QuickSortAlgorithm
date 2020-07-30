using System;
using static.System.Console;

namespace quickSort
{ 
	class Program 
	{
		static void Main(string[] args)
		{
			void DoSort(int[] items, int fst, int lst){
				if(fst>=lst){
					return;
				int i=fst;
				int j=lst;
				int x= items[(fst+lst)/2];	
				}
				while(i<j){
					while(items[i]<x) i++;
					while(items[j]<x) j--;
					if(i<=j){
						int tmp = items[i];
						items[i]= items[j];
						items[j]= tmp;
						i++;
						j--;

					}

				}
				DoSort(items, fst, j);
				DoSort(items, i, lst);
			
			}
			int[] Sort(int[] arr){
				var items = new int[arr.Length];
				arr.CopyTo(items, 0);
				DoSort(items, 0,items.Length - 1);
				return items;
			}
			var items = new[] {4,1,5,3,2};

			var sortItems = Sort(items);
			//sortItems is {1,2,3,4,5}

			items=(new int[200]).Select((v,i)=>i).ToArray();
			var tmp= items[5];
			items[5]=items[6];
			items[6] = tmp;
			var count= 10000;
			var start = DateTime.Now;

			for(int i= 0; i<count; i++)
			Sort(items);

			var delta = DateTime.Now - start;
			var milliseconds = delta.TotalMilliseconds;

			Writeline(milliseconds);
			//about 140 millisencods

		}
	}
}
