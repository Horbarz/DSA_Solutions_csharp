using System.Collections.Generic;
using static System.Console;

namespace csharpFundamentals
{
    public class EqualStack
    {
        
        public static int eq(int[]a, int[]b, int[]c){
            Stack<int> aStack = new Stack<int>();
            Stack<int> bStack = new Stack<int>();
            Stack<int> cStack = new Stack<int>();
            pushStack(a,aStack);
            //test stack
            
            pushStack(b,bStack);
            pushStack(c,cStack);
            int sA = 0, sB=0, sC=0;
            while(true){
                if(aStack.Count==0||bStack.Count==0||cStack.Count==0){
                    return 0;
                }
                sA = aStack.Peek();
                sB = bStack.Peek();
                sC = cStack.Peek();
            
                if(sA==sB&&sB==sC){
                    return sA;
                }
                if(sA>=sB && sA>=sC){
                    aStack.Pop();
                }
                else if(sB>=sA && sB>=sC){
                    bStack.Pop();
                }
                else if(sC>=sA && sC>=sB){
                    cStack.Pop();
                }
            }

        }
        public static void pushStack(int[]a, Stack<int> xStack){
            int n =a.Length;
            int totalHeight = 0;
            for (int i=n-1; i>=0;i--){
                totalHeight+=a[i];
                xStack.Push(totalHeight);
            }

        }
    }
}