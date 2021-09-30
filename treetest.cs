using System;
using System.Collections.Generic;

namespace csharpFundamentals
{
    public class treetest
    {
        // public int solution(Tree T) {
        // // write your code in C# 6.0 with .NET 4.5 (Mono)
        // if(T == null) return 0;
        // Dictionary<int,int> treeDataMap = new Dictionary<int,int>();
        // return recurseThroughPath(T,treeDataMap);

        // }
        // public int recurseThroughPath(Tree T, Dictionary<int,int> treeDataMap)
        // {
        //     if(T == null) return treeDataMap.Count;
        //     if(treeDataMap.ContainsKey(T.x)) treeDataMap[T.x] = treeDataMap[T.x] + 1;
        //     else treeDataMap.Add(T.x, 1);

        //     int longestUniquePath = Math.Max(recurseThroughPath(T.l, treeDataMap),
        //     recurseThroughPath(T.r, treeDataMap));

        //     if(treeDataMap.ContainsKey(T.x))
        //     {
        //     treeDataMap[T.x] = treeDataMap[T.x] - 1;
        //     }
        //     if (treeDataMap[T.x] == 0)
        //     treeDataMap.Remove(T.x);

        //     return longestUniquePath;
        // }

    }

}


