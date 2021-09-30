using System;
using System.Collections.Generic;
using System.Linq;
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
            // string[] nx = trial.appendToWidth(5).Split(",");
            // foreach (var i in nx)
            // {
            //     WriteLine(i);
            // }
            WriteLine(trial.remoteControl(7, "RW"));

            int[] buys = {692261,48553,549680,661623,274985,142762,235623,
            43717,568519,285863,64114,529201,429801,426630,261332,744012,165142,60667,585075,437392,172545,
            145521,426548,860002,44348,403475,129090,678438,471882,357431,597870,980287,400657,991847,787760,686306,959534,
            816910,315660,554005,215651,970172,29456,607498,833260,259798,45242,391762,247919,288669,437366,207872,894609,80217,
             17796,502235,821413,167777,876792,408894,310399,665738,802203,416528,178599,973866,195567,136668,629609,143047,412752,849676,50793,570593,307894,
             820743 ,639060 ,318873 ,609303 ,146660 ,591954 ,949437 ,634025 ,136265 ,350808 ,81329 ,819397 ,14821 ,429050 ,453627 ,457191 ,194502 ,421917 ,258922 ,282770 ,978967, 603178 ,701412 ,481105 ,313722};

            // Array.Sort(buys);
            // int[] buy = { 1, 3, 5, 7, 9 };
            //WriteLine(sample.getMinimumCost(2, buy));

            List<int> newArr = new List<int>();

            string[] board = { "OXXO.XOX..OOOX.OX..OOXXOXO..XO",
                            "OOOXOO.XXOXXXX.XX.XXO.OXOOOOOO",
                            ".OOOO.OXO...XO.XOOO.X.O.XOOOXO",
                            ".O.OXOOO.X.O.OOOOOOXOO.OOOOOXX",
                            ".X.XOOO...X..OOXX.X.XXX..O.O..",
                            "OXXOXXXXX..XX.O.OOOXO...OXOXXX",
                            "XX.XOXO.XXXOOX.XOXX.OOXOOXXX..",
                            "..OX..XOOX.XOOXX.OXO.XOOO.XO..",
                            "......O.O.OOX..OX.XO.OO.O.XXOO",
                            "O.OO.O.OXOX.XXOXXO.OOOXOO.X.OX",
                            "O.X.OOOO...XX.XX.XXOO..OO.XOOO",
                            "O...XOOO.OXOOO..XXOXOO.OXO.OOO",
                            "X.O...OX..OOOOOOOO....X..X..OX",
                            "XXX.OXO..OO.XXOOOOXX.O.OOXOXOO",
                            ".OO.O.XO...OO.OO.X.O.OOX.OO..O",
                            "XOOOOOXOOX..O.OX.OXO.O.XXOXX.X",
                            ".OOO...OXOXOXOXXOO.XXOO..X.O..",
                            "O..XX.XOXOOOOX.XO.X.XXXX.OXX.O",
                            "X.XOO.OOOOOOO.XX..O.X.OOOXO..X",
                            "X.XXOXOXO.OOOOXOOOOOO.X.X.X..X",
                            "OO.X.X..XOO.XXO.OOOOXXO..XX..O",
                            "OX.OOOXXO.OOXO.XX.X.OOXXXOXOOX",
                            "O...OX.OOXXXO..OXOO.XXX.O..XO.",
                            ".....XOOXXO..XOOXOX.X..X.XXO.O",
                            ".XO.XOX....OXXOOXX..X.OOO..X.X",
                            "..XXO.XOO.XOXXX.OO.OX...OX.X.O",
                            "X.OOOO..OXXXXOO.O..X...XXO....",
                            "X.OO..OO.OXOOOXOO..OX.OXX.XOXX",
                            "OOXX.XOOO.OX.XOXXOX..XXX.O...O",
                            "O...OX.XXO.XX.OOO.XXOOX.O..X.X" };
            //WriteLine(TictactoeChecker.tictactoeChecker(board));

            // int[][] arr = [[ -9 , -9 ,-9 ,1, 1, 1 ],[0, -9 ,0 ,4 ,3 ,2], {-9 ,-9 ,-9 ,1 ,2 ,3},
            //     {0 ,0 ,8  ,6 ,6 ,0}, {0  ,0, 0, -2, 0 ,0}, {0 ,0 ,1 ,2 ,4 ,0}
            // ];

            //WriteLine(TwoDimArray.hourglassSum(arr));
            // for (int i = 1; i < 5; i++)
            // {
            //     newArr.Add(arr[i]);
            // }
            // int count = 0;
            // int total = 0;
            // int len = 3;
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     //WriteLine(arr[i]);
            //     total += arr[i];

            //     count++;
            //     if (count == 3 && len != 0)
            //     {
            //         newArr.Add(total);
            //         len = len - 1;
            //         i = i - 2;
            //         count = 0;
            //         total = 0;
            //     }

            // }
            // newArr.Add(total);
            //WriteLine(newArr.Count);
            // foreach (int i in newArr)
            // {
            //     WriteLine(i);
            // }


            string ax = "fcrxzwscanmligyxyvym";
            string bx = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";
            // string ax = "cde";
            // string bx = "cdf";
            //WriteLine(MakingAnagrams.makeAnagram(bx, ax));

            // Create binary tree shown in above figure 

            // GFG.Node root = GFG.newNode(1);
            // root.left = GFG.newNode(2);
            // root.right = GFG.newNode(3);
            // root.left.left = GFG.newNode(4);
            // root.left.right = GFG.newNode(5);
            // root.right.left = GFG.newNode(6);
            // root.right.right = GFG.newNode(7);
            // root.right.left.right = GFG.newNode(8);
            // root.right.right.right = GFG.newNode(9);

            // Console.WriteLine(GFG.largestUinquePath(root));

            // string ip = "64.00.161.131";
            // int N = 4;
            // int[] A = { 1, 5, 2, 4, 4, 3 };
            // int[] B = { 2, 10, 3, 1, 3, 1 };
            // var check = graph.sol(N, A, B);
            // if (check)
            // {
            //     WriteLine("Confirm");
            // }
            // else
            // {
            //     WriteLine("Noo");
            // }

            int[] num = { -1, -3 };

            // arrayPack.arrayPacking(num);

            //WriteLine(smallestInt.smallInt(num));

            //WriteLine(modifyAlpha.solution("Hello"));



            //IsUnique
            // string plum = "abdeegh";
            // var check = IsUnique.isStringUnique(plum);
            // if (check)
            // {
            //     WriteLine("Confirm");
            // }
            // else
            // {
            //     WriteLine("Noo");
            // }

            /////////////////////Longest String
            // string test_str = "tmmzuxt";
            // WriteLine(LongestSubstring.LengthOfLongestSubstring(test_str));

            // string url = "https://casino-r12.site";
            // checkUrlOnline.checkUrl(url);

            //Marks and Toys
            //int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            // int[] prices = { 1, 2, 3, 4 };
            // int k = 7;

            // WriteLine(MarksAndToys.maximumToys(prices, k));
            // string s = "mom";

            //WriteLine(SherlockAnagram.sherAna(s));
            // for (int j = 0; j < s.Length; j++)
            // {
            //     for (int i = s.Length - j; i > 0; i--)
            //     {
            //         WriteLine(s.Substring(j, i));
            //     }

            // }

            //BUBBLE SORT
            // int[] ch = { 1, 2, 3 };
            // BubbleSort.countSwaps(ch);

            //Test HashTable
            //HashTables.HashTest();

            //TwoString
            // string a = "hi";
            // string b = "world";
            // TwoString.twoStrings(a, b);


            //Ransome Note
            string[] mag = { "two", "times", "three", "is", "not", "four" };
            string[] note = { "two", "times", "two", "is", "four" };
            //RansomeNote.checkMagazine(mag, note);
            //RansomeNote2.checkMag(mag, note);



            //ArrayManipulation 
            int n = 10;
            int[,] quer = { { 1, 5, 3 }, { 4, 8, 7 }, { 6, 9, 1 } };
            //WriteLine(ArrayManipulation.SmartArray(n, quer));
            //WriteLine(quer.GetLength(0));

            //Prefix Sum
            // int[] x = { 0, 3, 0, 0, 7, 0, -2, 0, 0, 0, -1 };
            // for (int i = 1; i < x.Length; i++)
            // {
            //     x[i] = x[i] + x[i - 1];
            //     WriteLine(x[i]);
            // }



            //Linq Test
            string text = @"Historically, the world of data and the world of objects" +
          @" have not been well integrated. Programmers work in C# or Visual Basic" +
          @" and also in SQL or XQuery. On the one side are concepts such as classes," +
          @" objects, fields, inheritance, and .NET APIs. On the other side" +
          @" are tables, columns, rows, nodes, and separate languages for dealing with" +
          @" them. Data types often require translation between the two worlds; there are" +
          @" different standard functions. Because the object world has no notion of query, a" +
          @" query can only be represented as a string without compile-time type checking or" +
          @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
          @" objects in memory is often tedious and error-prone.";

            string searchText = "and";
            string[] wordsToMatch = { "Programmers", "C#", "SQL" };

            //LinqTutoriaL.findWord(text, searchText);
            //LinqTutoriaL.findSentences(text, wordsToMatch);


            //Linq fundamentals test

            //SIMPLE SELECT USAGE LINQ
            // int[] numse = new int[]{0,1,2,8,3,5,9,10};
            // var res = from p in numse select p; 
            // foreach(var i in res){
            //     WriteLine(i.ToString());
            // }

            //MULTIPLE SELECT USAGE LINQ
            // int[] numbersA = new []{0, 2, 4, 5, 6, 8, 9};
            // int[] numbersB = new int[]{1, 3, 5, 7, 8};
            // var pairs = from a in numbersA from b in numbersB where a<b select new {a,b};
            // WriteLine("Pairs where a < b: ");
            // foreach(var each_pair in pairs){
            //     WriteLine("{0} is less than {1}",each_pair.a,each_pair.b);
            // }

            // ORDER BY USAGE
            // string[] words = new string[]{"apple","mango","cherry","pawpaw"};
            // var quer = from w in words orderby w select w;
            // foreach(var z in quer){
            //     WriteLine(z);
            // }

            //USING COUNT FUNCTION
            // int[] factorsOf300 = {2,2,3,5,5};
            // int uniqueFactors = factorsOf300.Distinct().Count();
            // WriteLine("There are {0} unique factors of 300.",uniqueFactors);

            // int[] num = {2,3,5,7,13,6,8,9};
            // int oddNums = num.Count(n=> n%2 == 1);
            // WriteLine("There are {0} oddNumbers in the List",oddNums);

            // int[] q = new[]{2,5,1,3,4};
            // NewYearChaos.minimumBribes(q);

            // long n = 1000000000000;
            // string x = "a";
            // WriteLine(RepeatedString.repeatedStr(x,n));

            // int x = 9;
            // int[] A = new int[]{10,20,20,10,10,30,50,10,20};
            // WriteLine(sockMerchant.sockMer(x,A));

            // int[] A_1 = new int[]{2,3,1,1,4,3};
            // int[] B_2 = new int[]{5,3,1};
            // int[] C_3 = new int[]{4,5,6,2,2,1};

            // WriteLine(HackerRank.getTripleSum(A_1,B_2,C_3));

            // var x = "bolanle";
            // char []c = x.ToCharArray();
            // int a = 1;


            // char [] n = stringReversal.rev(c,a);
            // foreach(var i in n){
            //     WriteLine(i);
            // }

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

            //WriteLine(HackerRank.newPalindromIndex("bbabbbb"));
            // var x = "abbebebs";
            // var newx = Regex.Replace(x,"b",String.Empty);
            // var newx = x.ToCharArray();
            // var temp = x.Remove(2);
            // var s = HackerRank.replaceCharAt(x,2,' ');
            // string ns = Regex.Replace( s, @"s", "" );
            // WriteLine(ns);

            // var test = "1234";
            var pana = "The quick brown fox jumps over the lazy dog";
            //jumps over the lazy dog
            //var newTest = test.Substring(0,1);
            //WriteLine(newTest);
            //WriteLine(HackerRank.isBeautifulNo(test));
            //WriteLine(HackerRank.checkPanagram(pana));
            // var x = new int[]{1,2,2,4,5};

            // WriteLine(HackerRank.totalEven(x));

            //WriteLine(JumpingOnTheCloud.adjustDate());

            // string[] dateFormat = new string[2];
            // int count = 0;
            //JumpingOnTheCloud.adjustDate();

            //WriteLine(HackerRank.isPalindrome("Ada"));
            //WriteLine(HackerRank.isP)

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
            var iop = new int[] { 1, 2, 3, 4, 5 };
            // var p = "ecdigf";
            // char []c = p.ToCharArray();
            // int n = p.Length;
            // Array.Sort(c,3,n-3);
            // WriteLine(new string(c));
            // WriteLine(BiggerIsGreater.bIG(p));
            //var inp = new string('x',12);
            //WriteLine(RunLengthEncoding.Encode(inp));
            //WriteLine(RunLengthEncoding.Decode(test));

            //////////////ICE CREAM PARLOR////////////////
            // int[] ans = IceCreamParlor.TwoSum(4, iop);
            // foreach (int i in ans)
            // {
            //     WriteLine(i);
            // }
            ///////////////////////////////////////    

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

            var x = new int[] { 1, 2, 2, 2, 2, 2, 1, 2, 3 };
            int[] aux = new int[101];
            // for (int i = 0; i < x.Length; i++)
            // {
            //     int index = x[i];
            //     aux[index] = aux[index] + 1;
            //     WriteLine(index);
            // }
            //WriteLine(EqualizeArray.aim(x));



            //WriteLine(Kangaroos.getToSameLocation(0,3,4,2));

            //WriteLine(FIndDigits.isDivisor(1111));

            //WriteLine(SavePrisoner.getPrisonerChair(19, 7, 2));


        }

        public static void adjustDate()
        {

            Console.Write("Enter the date in the format Month/Day/Year. ");
            var inputValue = Console.ReadLine();
            Console.WriteLine(DateTime.Parse(inputValue).ToString("yyyy/MM/dd"));
        }



        public void dateFnxs()
        {
            //Date time test
            var dateTime = new DateTime(2013, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            WriteLine(now.ToLongDateString());
            WriteLine(now.ToShortDateString());
            WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //timeSpan
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = TimeSpan.FromHours(1);


            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            WriteLine("Duration: " + duration);

            //timeSpan Properties
            WriteLine(timeSpan.Minutes);
            WriteLine(timeSpan.TotalMinutes);

            //Add time to exiting timespan
            WriteLine(timeSpan.Add(TimeSpan.FromMinutes(4))); //Adds 4 minuite to the exisiting time span
        }

        public void strFnxs()
        {
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
