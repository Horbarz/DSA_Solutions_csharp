using System;
using System.Collections.Generic;

namespace csharpFundamentals
{
    public class TictactoeChecker
    {
        public static string tictactoeChecker(string[] board)
        {
            bool isOngoing = false;
            List<string> boardAsList = new List<string>(board);
            var lentOfBoard = board[0].ToString().Length;
            var cols = new String[lentOfBoard];
            var diags = new String[2];

            var xwins = new String('X', lentOfBoard);
            var owins = new String('O', lentOfBoard);

            for (int i = 0; i < board.Length; i++)
            {
                var curRow = Convert.ToString(board[i]);
                Console.WriteLine(curRow);
                if (curRow == xwins) return "X WIN";
                if (curRow == owins) return "O WIN";
                if (curRow.Contains(".")) isOngoing = true;
                diags[0] += board[i][i].ToString();
                diags[1] += board[i][lentOfBoard - i - 1].ToString();

                for (int j = 0; j < lentOfBoard; j++)
                {
                    //add append to cols
                    cols[j] += Convert.ToString(curRow[j]);
                }
            }
            //check cols n diags
            for (int i = 0; i < cols.Length; i++)
            {
                Console.WriteLine("in row loop ::: {cols[i]}");

                if (Convert.ToString(cols[i]) == xwins) return "X WIN";
                if (Convert.ToString(cols[i]) == owins) return "O WIN";


            }
            Console.WriteLine(diags[0]);
            Console.WriteLine(diags[1]);


            if (Convert.ToString(diags[0]) == owins || Convert.ToString(diags[1]) == owins) return "O WIN";
            if (Convert.ToString(diags[0]) == xwins || Convert.ToString(diags[1]) == xwins) return "X WIN";

            if (isOngoing) return "ONGOING";
            return "TIE";
        }

    }
}