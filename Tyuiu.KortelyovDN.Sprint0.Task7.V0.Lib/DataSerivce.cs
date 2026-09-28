namespace Tyuiu.KortelyovDN.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numsOne, int[] numsTwo)
        {
            int[] resultArray = new int[5];

            for (var i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = numsOne[i] + numsTwo[i];
            }
            return resultArray;
        }
    }
}