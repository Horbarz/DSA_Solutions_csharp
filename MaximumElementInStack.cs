using System;
using System.Collections.Generic;
using static System.Console;


namespace csharpFundamentals
{
    public class MaximumElementInStack
    {
        
        //press 1 for pushing into the stack 
        //press 2 for deleting from the stack
        //press 3 to get the maximaum from the stack

        public static void getMaxElement(int N){
            Stack<int> mainStack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();
            maxStack.Push(0);
            for(int i=0; i<N;i++){
                Write("Enter operation: ");
                var input = ReadLine();
                int inp = Convert.ToInt32(input);
                switch(inp){
                    case 1:
                        Write("Enter value to push: ");
                        var c = ReadLine();
                        int item = Convert.ToInt32(c);
                        mainStack.Push(item);
                        int maxSofar = maxStack.Peek();
                        if(maxSofar<item){
                            maxStack.Push(item);
                        }else{
                            maxStack.Push(maxSofar);
                        }
                        
                       
                        break;
                    case 2:
                        mainStack.Pop();
                        maxStack.Pop();
                        break;
                    case 3:
                        WriteLine(maxStack.Peek());
                        break;
                    default:
                        WriteLine("Invalid input");
                        break;        

                }

            }


        }
    }
}