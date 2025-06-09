
using System.Numerics;

string a = "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101";
string b = "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011";

//string test = "1101010";

Console.WriteLine(a.Length);
Console.WriteLine(b.Length);

BigInteger bigIntA = BigInteger.Parse(a);
BigInteger bigIntB = BigInteger.Parse(b);
//BigInteger bigTest = BigInteger.Parse("0" + test, System.Globalization.NumberStyles.AllowBinarySpecifier);
BigInteger bigRes = bigIntA + bigIntB;

string strRes = bigRes.ToString("B"); //bigIntBinary.ToString();
Console.WriteLine(strRes);