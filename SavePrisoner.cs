namespace csharpFundamentals
{
    public class SavePrisoner
    {
        public static int getPrisonerChair(int noOfCandies, int noOfPrisoners, int startChair){
            int remain = noOfCandies%noOfPrisoners;
            int algo = remain+startChair-1;
            if(algo%noOfPrisoners==0){
                return noOfPrisoners;
            }
            else
            {
                return algo%noOfPrisoners;
            }
        }
    }
}