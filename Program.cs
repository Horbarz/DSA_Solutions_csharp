using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using static System.Console;

namespace csharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[] A_1 = new int[]{2,3,1,1,4,3};
            // int[] B_2 = new int[]{5,3,1};
            // int[] C_3 = new int[]{4,5,6,2,2,1};

            // WriteLine(HackerRank.getTripleSum(A_1,B_2,C_3));

            var x = "bolanle";
            char []c = x.ToCharArray();
            int a = 1;
            

            char [] n = newStringReversal.rev(c);
            foreach(var i in n){
                WriteLine(i);
            }

            // int [] x = new int[]{2,1,3,3,2,1,4};
            // WriteLine(singleNumber.single(x));
            // Array.Sort(x);

            // foreach(var i in x){
            //     WriteLine(i);
            // }

            
 
            // Array.Sort(test);
            // var check =  HackerRank.getNumberLessDanKey(test,2);
            // WriteLine(check);
            // var x = new int[]{0,0,1,0,0,0,0,1,0,0};
        
            // var result = JumpingOnTheCloud.JOTC(x);
            // WriteLine(result);

            // WriteLine(HackerRank.palindIndex("bbabbbb"));
            // var x = "abbebebs";
            // var newx = Regex.Replace(x,"b",String.Empty);
            // var newx = x.ToCharArray();
            // var temp = x.Remove(2);
            // var s = HackerRank.replaceCharAt(x,2,' ');
            // string ns = Regex.Replace( s, @"s", "" );
            // WriteLine(ns);

            // var test = "1234";
            // var pana = "The quick brown fox jumps over the lazy dog";
            //jumps over the lazy dog
            //var newTest = test.Substring(0,1);
            //WriteLine(newTest);
            //WriteLine(HackerRank.isBeautifulNo(test));
            // WriteLine(HackerRank.checkPanagram(pana));
            // var x = new int[]{1,2,2,4,5};

            // WriteLine(HackerRank.totalEven(x));

            //WriteLine(JumpingOnTheCloud.adjustDate());

            // string[] dateFormat = new string[2];
            // int count = 0;
            //JumpingOnTheCloud.adjustDate();

            //WriteLine(HackerRank.isPalindrome("Ada"));

            // userInput ux = new userInput();
            // ux.addInput('1');
            // ux.addInput('a');
            // ux.addInput('7');

            // WriteLine(ux.getInput());


            // var x = new int[]{2,3,4,5,6,7,1};
            // var y = new int[]{3,4,5,6,4,7};
            // JumpingOnTheCloud.arrayDecreasing(x);
            // foreach(var i in x){
            //     WriteLine(i);
            // }

            //WriteLine(JumpingOnTheCloud.checkIfConsecutive(y));
            // RunLengthEncoding run = new RunLengthEncoding();
            // var inp = "WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWB";
            // var test = "2A4B10C";
            // var x = new int[]{1,2,3,4,5};
            // var p = "ecdigf";
            // char []c = p.ToCharArray();
            // int n = p.Length;
            // Array.Sort(c,3,n-3);
            // WriteLine(new string(c));
            // WriteLine(BiggerIsGreater.bIG(p));
            //var inp = new string('x',12);
            //WriteLine(RunLengthEncoding.Encode(inp));
            //WriteLine(RunLengthEncoding.Decode(test));
            //var b = IceCreamParlor.TwoSum(4,x);
            // var b = ArrayLeftRotation.alr(x,2);
            // var scores = new int[]{100,100,50,40,40,20,10};
            // var alice = new int[]{5,12,50,120};

            // var d = ClimbingTheLeader.ctlb(scores,alice);

            // var a = new int[]{3,2,1,1,1};
            // var b = new int[]{4,3,2};
            // var c = new int[]{1,1,4,1};

            //WriteLine(prime.isPrime(17));

            //WriteLine(prothNumber.isProthPrime(7));

            // Stack<int> aStack = new Stack<int>();
            // EqualStack.pushStack(a,aStack);

            // var ans = EqualStack.eq(a,b,c);
            // WriteLine(ans);
            // WriteLine(aStack.Peek());
            // BigInteger p = 1010010;
            // var x = ACM_ICPC.getBitCount(p);
            // WriteLine(x);

            // int count = 0;
            // var str = p.ToString();
            // foreach(var i in str){
            //     //  WriteLine(i);
            //     if(i.Equals('1')){
            //         count++;
            //     }else{
            //         //WriteLine("none");
            //     }
            // } 
            // WriteLine(count);   
            

            // var x = new string[]{"10101","11100","11010","00101"};
            // var d = ACM_ICPC.acmTeam(x);
            
            // foreach(var i in d){
            //     WriteLine(i);
            // }

            //WriteLine(2|1);
            // int x = Convert.ToInt32("110011100011110000",2);
            // WriteLine(x);

            //MaximumElementInStack.getMaxElement(5);
            //WriteLine(maxConsecutiveOnes.maxNoOfConsecutive1s(x));

            //var x = new int[]{1,2,2,2,2,2,1,2,3};
            //WriteLine(EqualizeArray.aim(x));

            //WriteLine(Kangaroos.getToSameLocation(0,3,4,2));

            //WriteLine(FIndDigits.isDivisor(1111));

            //WriteLine(SavePrisoner.getPrisonerChair(19,7,2));
            
            
        }

         public static void adjustDate(){

            Console.Write("Enter the date in the format Month/Day/Year. ");
            var inputValue = Console.ReadLine();
            Console.WriteLine(DateTime.Parse(inputValue).ToString("yyyy/MM/dd"));
        }

         

        public void dateFnxs(){
            //Date time test
            var dateTime =new DateTime(2013,1,1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            WriteLine(now.ToLongDateString());
            WriteLine(now.ToShortDateString());
            WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //timeSpan
            var timeSpan = new TimeSpan(1,2,3);
            var timeSpan1 = TimeSpan.FromHours(1);


            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            WriteLine("Duration: "+duration);

            //timeSpan Properties
            WriteLine(timeSpan.Minutes);
            WriteLine(timeSpan.TotalMinutes);

            //Add time to exiting timespan
            WriteLine(timeSpan.Add(TimeSpan.FromMinutes(4))); //Adds 4 minuite to the exisiting time span
        }

        public void strFnxs(){
            //Formatting strings
            //ToLower(), ToUpper(), Trim()
            //Searching.. IndexOf('q'), LastIndexOf("Hello");
            //suubstring.. Substring(startIndex), Substring(startIndex,length)
            //replacing.. Replace('a','!'), Replace('mosh',"moshef")
            //NullChecking.. String.IsNullOrEmpty(str),String.IsNullOrWhteSpace(str);
            //splitting.. str.Split(' ');
            //converting str to int.. int.Parse(str), Convert.ToInt32(str)


            //String Builder
            // var builder = new StringBuilder();
            // builder.Append('-',10);
            // builder.AppendLine();
            // builder.Append("Header");
            // builder.Replace('-','+');       
            // builder.Remove(0,10);
            // builder.Insert(0, new string('-',10)); 

            // var builder = new StringBuilder();
            // builder.Append('-',10)
            // .AppendLine()
            // .Append("Header")
            // .Replace('-','+')       
            // .Remove(0,10)
            // .Insert(0, new string('-',10));    

            //List 
            // var num = new List<int> (); 
            // num.Add(1);
            // num.Add(2);
            // num.Add(3);

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
