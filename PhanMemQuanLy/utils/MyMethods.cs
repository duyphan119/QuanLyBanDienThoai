namespace PhanMemQuanLy.utils
{
    public class MyMethods
    {
        public string addZeros(int length, int value)
        {
            string result = "";
            for(int i = value.ToString().Length; i < length; i++)
            {
                result += "0";
            }
            return result + value;
        }
    }
}
