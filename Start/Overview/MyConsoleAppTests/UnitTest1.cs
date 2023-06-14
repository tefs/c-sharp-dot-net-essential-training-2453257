using MyConsoleApp;
using System;
using System.Numerics;

namespace Solution
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SampleTests_TestInteger_DisablePascalCase()
        {
            //arranje
            int _test;
            string _resultExpected = string.Empty;
            string _result = string.Empty;
            // act
            _resultExpected = "1";
            _test = 1;
            _result = Kata.ToUnderscore(_test);
            // assert
            Assert.That(_resultExpected.Equals(_result));
        }
        [Test]
        [TestCase("test_controller", "TestController")]
        [TestCase("this_is_beautiful_day", "ThisIsBeautifulDay")]
        [TestCase("am7_days", "Am7Days")]
        [TestCase("my3_code_is4_times_better", "My3CodeIs4TimesBetter")]
        [TestCase("arbitrarily_sending_different_types_to_functions_makes_katas_cool", "ArbitrarilySendingDifferentTypesToFunctionsMakesKatasCool")]
        public void SampleTests_TestString_DisablePascalCase(string test, string result)
        {
            Assert.AreEqual(test, Kata.ToUnderscore(result));
        }
    }
    [TestFixture, Description("Fixed tests")]
    public class FixedTests
    {
        private void Test(Dictionary<string, int> expected, Dictionary<string, int> actual)
        {
            var expectedStr = "{ " +
                              string.Join(", ", expected.Select(kv => $"{kv.Key}: {kv.Value}"))
                              + " }";
            var actualStr = "{ " +
                            string.Join(", ", actual.Select(kv => $"{kv.Key}: {kv.Value}"))
                            + " }";

            Assert.AreEqual(expected, actual, $"Expected: {expectedStr}, Actual: {actualStr}");
        }

        [Test, Description("Should work for some example programs")]
        public void ExamplePrograms()
        {
            // Test(new Dictionary<string, int> {{"a", 1}}, SimpleAssembler.Interpret(new[] {"mov a 5", "inc a", "dec a", "dec a", "jnz a -1", "inc a"}));
            Test(new Dictionary<string, int> { { "a", 0 }, { "b", -20 } },
                SimpleAssembler.Interpret(new[] { "mov a -10", "mov b a", "inc a", "dec b", "jnz a -2" }));
        }
    }

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void TestToRoman_001()
        {
            int input = 1;
            string expected = "I";

            string actual = RomanNumerals.ToRoman(input);

            Assert.AreEqual(expected, actual);

            //todo | kafka | redis | grpc | 
            //http://localhost:3000/weatherforecast
            //http://20.31.91.62/WeatherForecast
        }

        [Test]
        public void TestToRoman_002()
        {
            int input = 2;
            string expected = "II";

            string actual = RomanNumerals.ToRoman(input);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestToRoman_003()
        {
            int input = 2008;
            string expected = "MMVIII";

            string actual = RomanNumerals.ToRoman(input);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestFromRoman_001()
        {
            string input = "I";
            int expected = 1;

            int actual = RomanNumerals.FromRoman(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestFromRoman_002()
        {
            string input = "II";
            int expected = 2;

            int actual = RomanNumerals.FromRoman(input);

            Assert.AreEqual(expected, actual);
        }
    }
}

namespace
MyConsoleAppTests
{

    [TestFixture]
    public static class LongestConsecutivesTests
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2, "abigailtheta")]
        [TestCase(new String[] { }, 3, "")]
        [TestCase(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2, "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck")]
        [TestCase(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2, "wlwsasphmxxowiaxujylentrklctozmymu")]
        [TestCase(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2, "")]
        // [TestCase(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3, "ixoyx3452zzzzzzzzzzzz")]
        [TestCase(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15, "")]
        [TestCase(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0, "")]
        public static void test1(string[] array, int k, string expected)
        {
            Console.WriteLine("Basic Tests");
            testing(LongestConsecutives.LongestConsec(array, k), expected);
        }
    }
    [TestFixture]
    public class JadenCaseTest
    {
        [Test]
        public void JapenCase_TurnOn_CamelCase_JadenCaseFormattedString()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
                            "How can mirrors be real if our eyes aren't real".ToJadenCase(),
                            "Strings didn't match.");
            // quantidade prestaçõis restantes
            //valor prestação
        }
    }
    [TestFixture]
    public class BinarySearchTest
    {
        [Test]
        [TestCase("?", "1")]
        public void ScanChar_Return(string expectedResult, string input)
        {
            Assert.Equals(expectedResult
            , Answer.ScanChar(input));
        }
        [Test]
        [TestCase(2, new int[] { 0, 1, 2, 3, 4 }, 0, 5, 2)]
        public void BinarySearchTest_SearchForMiddleElement_ReturnElementIndex(int expectedResult, int[] array, int minPostionArray, int maxPostitionArray, int middleElement)
        {
            Assert.AreEqual(expectedResult
            , BinarySearch.BinarySearchOnArray(array, minPostionArray, maxPostitionArray, middleElement));
        }
    }
    [TestFixture]
    public class SolutionTest
    {
        private readonly IList<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        private PagnationHelper<int> helper;

        [SetUp]
        public void SetUp()
        {
            helper = new PagnationHelper<int>(collection, 10);
        }

        [Test]
        [TestCase(-1, ExpectedResult = -1)]
        [TestCase(1, ExpectedResult = 10)]
        [TestCase(3, ExpectedResult = -1)]
        public int PageItemCountTest(int pageIndex)
        {
            return helper.PageItemCount(pageIndex);
        }

        [Test]
        [TestCase(-1, ExpectedResult = -1)]
        [TestCase(12, ExpectedResult = 1)]
        [TestCase(24, ExpectedResult = -1)]
        public int PageIndexTest(int itemIndex)
        {
            return helper.PageIndex(itemIndex);
        }

        [Test]
        public void ItemCountTest()
        {
            Assert.AreEqual(24, helper.ItemCount);
        }

        [Test]
        public void PageCountTest()
        {
            Assert.AreEqual(3, helper.PageCount);
        }
    }
    [TestFixture]
    public class IsPangramTest
    {
        [Test]
        public void IsPangram_VerifyIfItsPangram_ReturnTrue()
        {
            Assert.AreEqual(true, Kata.IsPangram("The quick brown fox jumps over the lazy dog."));
        }
        [Test]
        public void IsPangram_VerifyLongString1IsPangram_ReturnTrue()
        {
            // arrange
            // act
            // assert
            Assert.AreEqual(true, Kata.IsPangram("Raw Danger! (Zettai Zetsumei Toshi 2) for the PlayStation 2 is a bit queer, but an alright game I guess, uh... CJ kicks and vexes Tenpenny precariously? This should be a pangram now, probably."));
        }
        [Test]
        [TestCase(true, "Pack my box with five dozen liquor jugs.")]
        [TestCase(true, "ABCD45EFGH,IJK,LMNOPQR56STUVW3XYZ")]
        [TestCase(true, "AbCdEfGhIjKlM zYxWvUtSrQpOn")]
        [TestCase(true, "aaaaaaaaaaaaaaaaaaaaaaaaaa")]
        [TestCase(true, "Detect Pangram")]
        [TestCase(true, "A pangram is a sentence that contains every single letter of the alphabet at least once.")]

        public void IsPangram_VerifyLongString2IsPangram_ReturnTrue(bool expected, string input) =>
            Assert.AreEqual(expected, Kata.IsPangram(input));
        [Test]
        public void IsPangram_VerifyLongString3IsPangram_ReturnTrue() =>
            Assert.AreEqual(true, Kata.IsPangram("ABCD45EFGH,IJK,LMNOPQR56STUVW3XYZ"));
        [Test]
        public void IsPangram_VerifyLongString4IsPangram_ReturnTrue() =>
            Assert.AreEqual(true, Kata.IsPangram("AbCdEfGhIjKlM zYxWvUtSrQpOn"));
        [Test]
        public void IsPangram_VerifyLongString5IsPangram_ReturnTrue() =>
            Assert.AreEqual(true, Kata.IsPangram("aaaaaaaaaaaaaaaaaaaaaaaaaa"));
        [Test]
        public void IsPangram_VerifyLongString6IsPangram_ReturnTrue() =>
            Assert.AreEqual(true, Kata.IsPangram("Detect Pangram"));
        [Test]
        public void IsPangram_VerifyLongString7IsPangram_ReturnTrue() =>
            Assert.AreEqual(true, Kata.IsPangram("A pangram is a sentence that contains every single letter of the alphabet at least once."));
        // A pangram is a sentence that contains every single letter of the alphabet at least once.
    }
    [TestFixture]
    public class StringEndsWith
    {
        private static object[] sampleTestCases = new object[]
        {
      new object[] {"samurai", "ai", true},
      new object[] {"sumo", "omo", false},
      new object[] {"ninja", "ja", true},
      new object[] {"sensei", "i", true},
      new object[] {"samurai", "ra", false},
      new object[] {"abc", "abcd", false},
      new object[] {"abc", "abc", true},
      new object[] {"abcabc", "bc", true},
      new object[] {"ails", "fails", false},
      new object[] {"fails", "ails", true},
      new object[] {"this", "fails", false},
      new object[] {"abc", "", true},
      new object[] {":-)", ":-(", false},
      new object[] {"!@#$%^&*() :-)", ":-)", true},
      new object[] {"abc\n", "abc", false},
        };

        [Test, TestCaseSource("sampleTestCases")]
        public void Test_ValidateIfEnds_ReturnBool(string str, string ending, bool expected)
        {
            Assert.AreEqual(expected, Kata.StringEndsWith(str, ending));
        }
    }
    [TestFixture]
    public class ConverterTests
    {
        [Test]
        public void SumTwoSmallestNumbers_Calculate_ReturnCalculatedValue()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.AreEqual(13, Kata.SumTwoSmallestNumbers(numbers));
        }
        [Test]
        public void SumTwoSmallestNumbers_Calculate_ReturnCalculatedValue2()
        {
            int[] numbers = { 19, 5, 42, 2, 77 };
            Assert.AreEqual(7, Kata.SumTwoSmallestNumbers(numbers));
        }
        [Test]
        public void SumTwoSmallestNumbers_Calculate_ReturnCalculatedValue3()
        {
            int[] numbers = { 10, 343445353, 3453445, 2147483647 };
            Assert.AreEqual(3453455, Kata.SumTwoSmallestNumbers(numbers));
        }
    }

    [TestFixture]
    public static class AccumulTests
    {

        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase("ZpglnRxqenU", "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu")]
        [TestCase("NyffsGeyylB", "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb")]
        [TestCase("MjtkuBovqrU", "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu")]
        [TestCase("EvidjUnokmM", "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm")]
        [TestCase("HbideVbxncC", "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc")]
        public static void test1(string input, string expected)
        {
            testing(Kata.Accum(input), expected);
        }
    }
    [TestFixture]
    public class GetIntegersFromListClassTests
    {
        [Test]
        public void GetIntegersFromList_MixedValues_ShouldPass_1()
        {
            var list = new List<object>() { 1, 2, "a", "b" };
            var expected = new List<int>() { 1, 2 };
            var actual = Kata.GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [Test]
        public void GetIntegersFromList_MixedValues_ShouldPass_2()
        {
            var list = new List<object>() { 1, "a", "b", 0, 15 };
            var expected = new List<int>() { 1, 0, 15 };
            var actual = Kata.GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [Test]
        public void GetIntegersFromList_MixedValues_ShouldPass_3()
        {
            var list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
            var expected = new List<int>() { 1, 2, 123 };
            var actual = Kata.GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
    [TestFixture]
    public class AreYouPlayingBanjo
    {
        [Test]
        public static void TechnicalExam_TestDome_Sum_Test()
        {
            Func<int> expensiveFunction = () => Enumerable.Range(0, 200000000).Count();
            Func<int> cheapFunction = () => Enumerable.Range(0, 10000000).Count();
            Action<int> onSumChanged = sum => Console.WriteLine("Current result: " + sum);

            // Computationally expensive functions need more time than cheaper functions.
            // Because of this, computationally cheaper functions, when run in parallel, 
            // should be summed up before more expensive functions.
            // Expected output:
            // Current result: 10000000
            // Current result: 210000000
            // Final result: 210000000
            int result = TechnicalExam_GameCompany_Adder.Sum(new Func<int>[] { expensiveFunction, cheapFunction }, onSumChanged);
            Console.WriteLine("Current result: " + result);
            Console.WriteLine("Current result: " + result);
            Console.WriteLine("Current result: " + result);
            Console.WriteLine("Current result: " + result);

            Console.WriteLine("Final result: " + result);
        }
        [Test]
        public static void Martin()
        {
            Assert.AreEqual("Martin does not play banjo", Kata.AreYouPlayingBanjo("Martin"));
        }

        [Test]
        public static void Rikke()
        {
            Assert.AreEqual("Rikke plays banjo", Kata.AreYouPlayingBanjo("Rikke"));
        }

        [Test]
        public static void bravo()
        {
            Assert.AreEqual("bravo does not play banjo", Kata.AreYouPlayingBanjo("bravo"));
        }

        [Test]
        public static void rolf()
        {
            Assert.AreEqual("rolf plays banjo", Kata.AreYouPlayingBanjo("rolf"));
        }
    }
    [TestFixture]
    public class TotalPointsTest
    {

        [Test]
        public void Test1() =>
            Test(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }, 30);

        [Test]
        public void Test2() =>
            Test(new[] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" }, 10);

        [Test]
        public void Test3() =>
            Test(new[] { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4" }, 0);

        [Test]
        public void Test4() =>
            Test(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4" }, 15);

        [Test]
        public void Test5() =>
            Test(new[] { "1:0", "2:0", "3:0", "4:4", "2:2", "3:3", "1:4", "2:3", "2:4", "3:4" }, 12);

        private void Test(string[] input, int expectedOutput) =>
            Assert.AreEqual(expectedOutput, Kata.TotalPoints(input));

    }
    [TestFixture]
    public class LitresClassTests
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(1, Kata.Litres(2));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(0, Kata.Litres(1.4));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(6, Kata.Litres(12.3));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual(0, Kata.Litres(0.82));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual(5, Kata.Litres(11.8));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual(893, Kata.Litres(1787));
        }
        [Test]
        public static void Test7()
        {
            Assert.AreEqual(0, Kata.Litres(0));
        }

    }
    [TestFixture]
    public class Sample_Tests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("man i need a taxi up to ubud").Returns("taxi");
                yield return new TestCaseData("what time are we climbing up to the volcano").Returns("volcano");
                yield return new TestCaseData("take me to semynak").Returns("semynak");
                yield return new TestCaseData("aa b").Returns("aa");
                yield return new TestCaseData("b aa").Returns("b");
                yield return new TestCaseData("bb d").Returns("bb");
                yield return new TestCaseData("d bb").Returns("d");
                yield return new TestCaseData("aaa b").Returns("aaa");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string s) => Kata.High(s);
    }
    [TestFixture]
    public class CountToDictionaryTests
    {
        [Test]
        public static void FixedTest_aaaa()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 4);
            Assert.AreEqual(d, Kata.CountToDictionary("aaaa"));
        }

        [Test]
        public static void FixedTest_aabb()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 2);
            Assert.AreEqual(d, Kata.CountToDictionary("aabb"));
        }
    }
    [TestFixture]
    public class HighAndLowTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("3 1", Kata.HighAndLow("1 2 3"));
        }
    }
    [TestFixture]
    public class IsIsogramTests
    {

        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("Dermatoglyphics").Returns(true);
                yield return new TestCaseData("isogram").Returns(true);
                yield return new TestCaseData("moose").Returns(false);
                yield return new TestCaseData("isIsogram").Returns(false);
                yield return new TestCaseData("aba").Returns(false);
                yield return new TestCaseData("moOse").Returns(false);
                yield return new TestCaseData("thumbscrewjapingly").Returns(true);
                yield return new TestCaseData("").Returns(true);
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(string str) => Kata.IsIsogram(str);
    }
    [TestFixture]
    public class DisemvowelTest
    {
        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", Kata.Disemvowel("This website is for losers LOL!"));
        }

        [Test]
        public void MultilineString()
        {
            Assert.AreEqual("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd", Kata.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
        }

        [Test]
        public void OneMoreForGoodMeasure()
        {
            Assert.AreEqual("Wht r y,  cmmnst?", Kata.Disemvowel("What are you, a communist?"));
        }
    }
    [TestFixture]
    public class RpsTests
    {
        [Test]
        public void Player1Win()
        {
            Assert.AreEqual("Player 1 won!", Kata.Rps("rock", "scissors"));
            Assert.AreEqual("Player 1 won!", Kata.Rps("scissors", "paper"));
            Assert.AreEqual("Player 1 won!", Kata.Rps("paper", "rock"));
        }
        [Test]
        public void Player2Win()
        {
            Assert.AreEqual("Player 2 won!", Kata.Rps("scissors", "rock"));
            Assert.AreEqual("Player 2 won!", Kata.Rps("paper", "scissors"));
            Assert.AreEqual("Player 2 won!", Kata.Rps("rock", "paper"));
        }
        [Test]
        public void Draw()
        {
            Assert.AreEqual("Draw!", Kata.Rps("rock", "rock"));
            Assert.AreEqual("Draw!", Kata.Rps("scissors", "scissors"));
            Assert.AreEqual("Draw!", Kata.Rps("paper", "paper"));
        }
    }
    [TestFixture]
    public static class ArgeTests
    {

        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Testing NbYear");
            testing(Kata.NbYear(1500, 5, 100, 5000), 15);
            testing(Kata.NbYear(1500000, 2.5, 10000, 2000000), 10);
            testing(Kata.NbYear(1500000, 0.25, 1000, 2000000), 94);
        }
    }
    [TestFixture]
    public class ValidatePinTests
    {
        [Test, Description("ValidatePin should return false for pins with length other than 4 or 6")]
        public void LengthTest()
        {
            Assert.AreEqual(false, Kata.ValidatePin("1"), "Wrong output for \"1\"");
            Assert.AreEqual(false, Kata.ValidatePin("12"), "Wrong output for \"12\"");
            Assert.AreEqual(false, Kata.ValidatePin("123"), "Wrong output for \"123\"");
            Assert.AreEqual(false, Kata.ValidatePin("12345"), "Wrong output for \"12345\"");
            Assert.AreEqual(false, Kata.ValidatePin("1234567"), "Wrong output for \"1234567\"");
            Assert.AreEqual(false, Kata.ValidatePin("-1234"), "Wrong output for \"-1234\"");
            Assert.AreEqual(false, Kata.ValidatePin("1.234"), "Wrong output for \"1.234\"");
            Assert.AreEqual(false, Kata.ValidatePin("-1.234"), "Wrong output for \"-1.234\"");
            Assert.AreEqual(false, Kata.ValidatePin("00000000"), "Wrong output for \"00000000\"");
        }

        [Test, Description("ValidatePin should return false for pins which contain characters other than digits")]
        public void NonDigitTest()
        {
            Assert.AreEqual(false, Kata.ValidatePin("a234"), "Wrong output for \"a234\"");
            Assert.AreEqual(false, Kata.ValidatePin(".234"), "Wrong output for \".234\"");
        }

        [Test, Description("ValidatePin should return true for valid pins")]
        public void ValidTest()
        {
            Assert.AreEqual(true, Kata.ValidatePin("1234"), "Wrong output for \"1234\"");
            Assert.AreEqual(true, Kata.ValidatePin("0000"), "Wrong output for \"0000\"");
            Assert.AreEqual(true, Kata.ValidatePin("1111"), "Wrong output for \"1111\"");
            Assert.AreEqual(true, Kata.ValidatePin("123456"), "Wrong output for \"123456\"");
            Assert.AreEqual(true, Kata.ValidatePin("098765"), "Wrong output for \"098765\"");
            Assert.AreEqual(true, Kata.ValidatePin("000000"), "Wrong output for \"000000\"");
            Assert.AreEqual(true, Kata.ValidatePin("090909"), "Wrong output for \"090909\"");
        }
    }
    [TestFixture]
    public class SortNumbersTests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 10, 5 }, new int[] { 1, 2, 3, 5, 10 })]
        [TestCase(null, new int[] { })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 20, 2, 10 }, new int[] { 2, 10, 20 })]
        [TestCase(new int[] { 2, 20, 10 }, new int[] { 2, 10, 20 })]
        [TestCase(new int[] { 2, 10, 20 }, new int[] { 2, 10, 20 })]
        public void BasicTests(int[] input, int[] expected)
        {
            checkNums(input, expected);
        }

        private void checkNums(int[] nums, int[] expected)
        {
            var actual = Kata.SortNumbers(nums);
            Assert.AreEqual(expected, actual, nums != null ? "{" + string.Join(",", nums) + "}" : "null");
        }
    }
    [TestFixture]
    public class SquareSumTests
    {
        private static IEnumerable<TestCaseData> sampleTestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 2 }).Returns(9);
                yield return new TestCaseData(new int[] { 1, 2 }).Returns(5);
                yield return new TestCaseData(new int[] { 5, 3, 4 }).Returns(50);
                yield return new TestCaseData(new int[] { }).Returns(0);
            }
        }

        [Test, TestCaseSource("sampleTestCases"), Description("Sample Tests")]
        public int SampleTest(int[] n) => Kata.SquareSum(n);
    }
    [TestFixture]
    public class OddOrEvenTests
    {
        [Test, Description("Edge tests")]
        public void EdgeTests()
        {
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 1 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { }));
        }

        [Test, Description("Even tests")]
        public void EvenTests()
        {
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0, 1, 5 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0, 1, 3 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 1023, 1, 2 }));
        }

        [Test, Description("Negative Even tests")]
        public void NegativeEvenTests()
        {
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0, -1, -5 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0, -1, -3 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { -1023, 1, -2 }));
        }

        [Test, Description("Odd tests")]
        public void OddTests()
        {
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 0, 1, 2 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 0, 1, 4 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 1023, 1, 3 }));
        }

        [Test, Description("Negative Odd tests")]
        public void NegativeOddTests()
        {
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 0, -1, 2 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 0, 1, -4 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { -1023, -1, 3 }));
        }
    }

    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void FactorialOf0ShouldBe1()
        {
            Assert.AreEqual(1, Kata.FactorialV2(0));
        }

        [Test]
        public void FactorialOf1ShouldBe1()
        {
            Assert.AreEqual(1, Kata.FactorialV2(1));
        }

        [Test]
        public void FactorialOf2ShouldBe2()
        {
            Assert.AreEqual(2, Kata.FactorialV2(2));
        }

        [Test]
        public void FactorialOf3ShouldBe6()
        {
            Assert.AreEqual(6, Kata.FactorialV2(3));
        }
    }

    [TestFixture]
    public static class NoBoringTests
    {
        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests NoBoringZeros");
            testing(Kata.NoBoringZeros(1450), 145);
            testing(Kata.NoBoringZeros(960000), 96);
            testing(Kata.NoBoringZeros(1050), 105);
            testing(Kata.NoBoringZeros(-1050), -105);
        }
    }
    [TestFixture]
    public class FindDifferenceTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new[] { new int[] { 3, 2, 5 }, new int[] { 1, 4, 4 } }).Returns(14);
                yield return new TestCaseData(new[] { new int[] { 9, 7, 2 }, new int[] { 5, 2, 2 } }).Returns(106);
                yield return new TestCaseData(new[] { new int[] { 11, 2, 5 }, new int[] { 1, 10, 8 } }).Returns(30);
                yield return new TestCaseData(new[] { new int[] { 4, 4, 7 }, new int[] { 3, 9, 3 } }).Returns(31);
                yield return new TestCaseData(new[] { new int[] { 15, 20, 25 }, new int[] { 10, 30, 25 } }).Returns(0);
            }
        }
        [Test, TestCaseSource("testCases")]
        public int Test(int[] a, int[] b) => Kata.FindDifference(a, b);
    }
    [TestFixture]
    public class ShortcutTest
    {
        [Test]
        public void Test1()
        {
            ShortcutTest.Assert("hello", "hll");
            ShortcutTest.Assert("how are you today?", "hw r y tdy?");
            ShortcutTest.Assert("complain", "cmpln");
            ShortcutTest.Assert("never", "nvr");
        }

        private static void Assert(string input, string expected)
        {
            var result = Kata.Shortcut(input);
            NUnit.Framework.Assert.AreEqual(expected, result, String.Format("Expected \"{0}\" but got \"{1}\"", expected, result));
        }
    }
    [TestFixture]
    public class CouponCodeTest
    {
        [Test]
        public static void ValidCoupon()
        {
            Assert.AreEqual(true, Kata.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));
        }

        [Test]
        public static void InvalidCoupon()
        {
            Assert.AreEqual(false, Kata.CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"));
        }
    }
    [TestFixture]
    public class XorTests
    {
        [Test]
        public void BasicTests()
        {
            testing(Kata.Xor(false, false), false);
            testing(Kata.Xor(true, false), true);
            testing(Kata.Xor(false, true), true);
            testing(Kata.Xor(true, true), false);
        }

        [Test]
        public void NestedTests()
        {
            testing(Kata.Xor(false, Kata.Xor(false, false)), false);
            testing(Kata.Xor(Kata.Xor(true, false), false), true);
            testing(Kata.Xor(Kata.Xor(true, true), false), false);
            testing(Kata.Xor(true, Kata.Xor(true, true)), true);
            testing(Kata.Xor(Kata.Xor(false, false), Kata.Xor(false, false)), false);
            testing(Kata.Xor(Kata.Xor(false, false), Kata.Xor(false, true)), true);
            testing(Kata.Xor(Kata.Xor(true, false), Kata.Xor(false, false)), true);
            testing(Kata.Xor(Kata.Xor(true, false), Kata.Xor(true, false)), false);
            testing(Kata.Xor(Kata.Xor(true, true), Kata.Xor(true, false)), true);
            testing(Kata.Xor(Kata.Xor(true, Kata.Xor(true, true)), Kata.Xor(Kata.Xor(true, true), false)), true);
        }

        private static void testing(bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
    [TestFixture]
    public class CountPositivesSumNegativesTests
    {
        [Test]
        public void CountPositivesSumNegatives_BasicTest()
        {
            int[] expectedResult = new int[] { 10, -65 };
            Assert.AreEqual(expectedResult, Kata.CountPositivesSumNegatives(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 }));
        }
        [Test]
        public void CountPositivesSumNegatives_InputWithZeroes()
        {
            int[] expectedResult = new int[] { 8, -50 };
            Assert.AreEqual(expectedResult, Kata.CountPositivesSumNegatives(new[] { 0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14 }));
        }
        [Test]
        public void CountPositivesSumNegatives_InputNull()
        {
            int[] expectedResult = new int[] { };
            Assert.AreEqual(expectedResult, Kata.CountPositivesSumNegatives(null));
        }
        [Test]
        public void CountPositivesSumNegatives_InputEmpty()
        {
            int[] expectedResult = new int[] { };
            Assert.AreEqual(expectedResult, Kata.CountPositivesSumNegatives(new int[] { }));
        }
    }
    [TestFixture]
    public class BreakCamelCaseTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("camelCasing").Returns("camel Casing");
                yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string str) => Kata.BreakCamelCase(str);
    }
    [TestFixture]
    public class SquareAreaTests
    {
        private static double[][] testCases = new double[][]
        {
      new double[] {2, 1.62},
      new double[] {0, 0},
      new double[] {14.05, 80},
        };

        [Test, TestCaseSource("testCases")]
        public void SampleTest(double A, double expected)
        {
            Assert.AreEqual(expected, Kata.SquareArea(A));
        }
    }
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void TowerBuilderTests()
        {
            Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", Kata.TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", Kata.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", Kata.TowerBuilder(3)));
        }
        [Test]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 5)]
        [TestCase(3, ExpectedResult = 5)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(7, ExpectedResult = 10)]
        [TestCase(39, ExpectedResult = 40)]
        public static int FixedTest(int n)
        {
            return Kata.RoundToNext5(n);
        }
        [Test]
        public void ArithmeticTests()
        {
            Assert.AreEqual(3, Kata.Arithmetic(1, 2, "add"));
            Assert.AreEqual(6, Kata.Arithmetic(8, 2, "subtract"));
            Assert.AreEqual(10, Kata.Arithmetic(5, 2, "multiply"));
            Assert.AreEqual(4, Kata.Arithmetic(8, 2, "divide"));
        }
        [Test]
        public static void NoBoringZerosV2Test()
        {
            Console.WriteLine("Basic Tests NoBoringZeros");
            Assert.AreEqual(145, Kata.NoBoringZerosV2(1450));
            Assert.AreEqual(96, Kata.NoBoringZerosV2(960000));
            Assert.AreEqual(105, Kata.NoBoringZerosV2(1050));
            Assert.AreEqual(-105, Kata.NoBoringZerosV2(-1050));
        }
        [Test]
        public void ValidateBattlefieldTest()
        {
            int[,] field = new int[10, 10]
                           {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            Assert.IsTrue(BattleshipField.ValidateBattlefield(field));
        }
        [TestCase(1, "6.75 Chinese Yuan")]
        [TestCase(3, "20.25 Chinese Yuan")]
        public void UsdcnyTest(int input, string expected)
        {
            Assert.AreEqual(expected, Kata.Usdcny(input));
        }
        [TestCase("hello world", false)]
        [TestCase("egnlish", false)]
        [TestCase("", false)]
        [TestCase("english", true)]
        [TestCase("1234english ;k", true)]
        [TestCase("I speak English", true)]
        [TestCase("ABC123DOREME", false)]
        [TestCase("eNgliSh", true)]
        [TestCase("1234#$%%eNglish ;k9", true)]
        [TestCase("spanish, english, french", true)]
        [TestCase("englishENGLISHEnGlISHENglisH", true)]
        [TestCase("HeLlO tHeR3 enGLiSh MuffIN", true)]
        public void SpeakEnglishTests(string str, bool expected)
        {
            var actual = Kata.SpeakEnglish(str);
            Assert.AreEqual(expected, actual, $"Input: \"{str}\"");
        }
        [Test]
        public void SortArrayTests()
        {
            Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
            Assert.AreEqual(new int[] { }, Kata.SortArray(new int[] { }));
        }
        [Test]
        public void StringCleanTest()
        {
            Assert.AreEqual("", Kata.StringClean(""));
            Assert.AreEqual("! !", Kata.StringClean("! !"));
            Assert.AreEqual("", Kata.StringClean("1234567890"));
            Assert.AreEqual("Dsa cdsc csa!!! I Am cool!", Kata.StringClean("Dsa32 cdsc34232 csa!!! 1I 4Am cool!"));
            Assert.AreEqual("A A! AAA   JKL@!!!", Kata.StringClean("A1 A1! AAA   3J4K5L@!!!"));
            Assert.AreEqual("Adgre Asad! AAA fvfdvJKL@", Kata.StringClean("Adgre2321 A1sad! A2A3A4 fv3fdv3J544K5L@"));
            Assert.AreEqual("Addsadds A  $$sad! AAAe fKL@ ", Kata.StringClean("Ad2dsad3ds21 A  1$$s122ad! A2A3Ae24 f44K5L@222222 "));
            Assert.AreEqual("Addsadds A  $$sa!d! A!A!Ae$ f## ", Kata.StringClean("33333Ad2dsad3ds21 A3333  1$$s122a!d! A2!A!3Ae$24 f2##222 "));
            Assert.AreEqual("My \"messy\" data issues! Will they ever, ever be solved?", Kata.StringClean("My \"me3ssy\" d8ata issues2! Will1 th4ey ever, e3ver be3 so0lved?"));
            Assert.AreEqual("Why can't we buy the good software? #cheapskates", Kata.StringClean("Wh7y can't we3 bu1y the goo0d software3? #cheapskates3"));
        }
        [Test]
        public void GetDrinkByProfessionTest()
        {
            Assert.AreEqual("Patron Tequila", Kata.GetDrinkByProfession("jabrOni"), "'Jabroni' should map to 'Patron Tequila'");
            Assert.AreEqual("Anything with Alcohol", Kata.GetDrinkByProfession("scHOOl counselor"), "'School Counselor' should map to 'Anything with alcohol'");
            Assert.AreEqual("Hipster Craft Beer", Kata.GetDrinkByProfession("prOgramMer"), "'Programmer' should map to 'Hipster Craft Beer'");
            Assert.AreEqual("Moonshine", Kata.GetDrinkByProfession("bike ganG member"), "'Bike Gang Member' should map to 'Moonshine'");
            Assert.AreEqual("Your tax dollars", Kata.GetDrinkByProfession("poLiTiCian"), "'Politician' should map to 'Your tax dollars'");
            Assert.AreEqual("Cristal", Kata.GetDrinkByProfession("rapper"), "'Rapper' should map to 'Cristal'");
            Assert.AreEqual("Beer", Kata.GetDrinkByProfession("pundit"), "'Pundit' should map to 'Beer'");
            Assert.AreEqual("Beer", Kata.GetDrinkByProfession("Pug"), "'Pug' should map to 'Beer'");
        }
        [Test]
        [TestCase("Position of alphabet: 1", 'a')]
        [TestCase("Position of alphabet: 26", 'z')]
        [TestCase("Position of alphabet: 5", 'e')]
        public void PositionTests(string expected, char input)
        {
            Assert.AreEqual(expected, Kata.Position(input));
            // Assert.AreEqual("Position of alphabet: 1", Kata.Position('a'));
            // Assert.AreEqual("Position of alphabet: 26", Kata.Position('z'));
            // Assert.AreEqual("Position of alphabet: 5", Kata.Position('e'));
        }
        [TestCase("", "")]
        [TestCase("A", "65")]
        [TestCase("Ab", "65b")]
        [TestCase("Abc", "65cb")]
        [TestCase("Abcd", "65dcb")]
        [TestCase("A wise old owl lived in an oak", "65 119esi 111dl 111lw 108dvei 105n 97n 111ka")]
        [TestCase("The more he saw the less he spoke", "84eh 109ero 104e 115wa 116eh 108sse 104e 115eokp")]
        [TestCase("The less he spoke the more he heard", "84eh 108sse 104e 115eokp 116eh 109ero 104e 104dare")]
        [TestCase("Why can we not all be like that wise old bird", "87yh 99na 119e 110to 97ll 98e 108eki 116tah 119esi 111dl 98dri")]
        [TestCase("Thank you Piotr for all your help", "84kanh 121uo 80roti 102ro 97ll 121ruo 104ple")]
        public void EncryptThisTests(string input, string expected)
        {
            Assert.AreEqual(expected, Kata.EncryptThis(input));
        }
        [Test]
        public void SwitchItUpTests()
        {
            Assert.AreEqual("One", Kata.SwitchItUp(1));
            Assert.AreEqual("Three", Kata.SwitchItUp(3));
            Assert.AreEqual("Five", Kata.SwitchItUp(5));
        }
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, 5, "Array does not match")]
        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 2, 5, "Array does not match")]
        public static void CountByTest(int[] expected, int x, int n, string inputString)
        {
            Assert.AreEqual(expected, Kata.CountBy(x, n), inputString);
        }
        [Test, Description("Your solution should handle arguments and math as defined in specifications")]
        public void RemainderTest()
        {
            Assert.AreEqual(2, Kata.Remainder(17, 5), "Returned value should be the value left over after dividing as much as possible.");
            Assert.AreEqual(Kata.Remainder(72, 13), Kata.Remainder(13, 72), "The order the arguments are passed should not matter.");
            Assert.Throws<DivideByZeroException>(() => Kata.Remainder(0, 1));
            Assert.Throws<DivideByZeroException>(() => Kata.Remainder(0, 0));
        }
        [TestCase(12, 2, 6, 2)]
        [TestCase(15, 1, 5, 1)]
        [TestCase(5, 1, 5, 3)]
        [TestCase(45, 0, 15, 3)]
        [TestCase(0, 16, 15, 3)]
        [TestCase(26, 2, 24, 22)]
        [TestCase(2, 2, 2, 2)]
        [TestCase(2, 2, 2, 1)]
        [TestCase(35, 1, 15, 3)]
        [TestCase(0, 15, 1, 3)]
        public void SequenceSumTest(int expected, int start, int end, int step)
        {
            Assert.AreEqual(expected, Kata.SequenceSum(start, end, step));
        }
        [Test]
        [TestCase(new int[] { 2, 3 }, 5, ExpectedResult = true)]
        [TestCase(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75, ExpectedResult = true)]
        [TestCase(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69, ExpectedResult = true)]
        public static bool BetterThanAverageTest(int[] arr, int num)
        {
            return Kata.BetterThanAverage(arr, num);
        }
        [Test]
        [TestCase("World Hello", "Hello World")]
        [TestCase("There. Hi", "Hi There.")]
        [TestCase("this at expert an am I", "I am an expert at this")]
        public void ReverseTests(string expected, string input)
        {
            Assert.AreEqual(expected, Kata.Reverse(input));
        }
        [Test]
        public void СenturyFromYearTest()
        {
            Assert.AreEqual(18, Kata.СenturyFromYear(1705));
            Assert.AreEqual(19, Kata.СenturyFromYear(1900));
            Assert.AreEqual(17, Kata.СenturyFromYear(1601));
            Assert.AreEqual(20, Kata.СenturyFromYear(2000));
        }
        [Test]
        public void SeriesSumTest1()
        {
            Assert.AreEqual("0.00", Kata.SeriesSum(0));
            Assert.AreEqual("1.77", Kata.SeriesSum(9));
        }
        [Test]
        [TestCase(5, new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 })]
        [TestCase(7, new[] { 7 })]
        [TestCase(0, new[] { 0 })]
        [TestCase(2, new[] { 1, 1, 2 })]
        [TestCase(0, new[] { 0, 1, 0, 1, 0 })]
        [TestCase(4, new[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 })]
        public void Tests(int expected, int[] input) => Assert.AreEqual(expected, Kata.find_it(input));
        [Test]
        public static void RemoveExclamationMarksTest()
        {
            Assert.AreEqual("", Kata.RemoveExclamationMarks(""), "Input: Empty string");
            Assert.AreEqual("", Kata.RemoveExclamationMarks("!"), "Input: " + "!");
            Assert.AreEqual("", Kata.RemoveExclamationMarks("!!"), "Input: " + "!!");
            Assert.AreEqual("Hi", Kata.RemoveExclamationMarks("Hi!"), "Input: " + "Hi!");
            Assert.AreEqual("?", Kata.RemoveExclamationMarks("!?!"), "Input: " + "!?!");
        }
        [Test]
        [TestCase("c", ExpectedResult = false)]
        [TestCase("C", ExpectedResult = true)]
        [TestCase("hello I AM DONALD", ExpectedResult = false)]
        [TestCase("HELLO I AM DONALD", ExpectedResult = true)]
        [TestCase("ACSKLDFJSgSKLDFJSKLDFJ", ExpectedResult = false)]
        [TestCase("ACSKLDFJSGSKLDFJSKLDFJ", ExpectedResult = true)]
        public static bool IsUpperCaseTest(string text) => text.IsUpperCase();

        [Test]
        public void GooseFilterTest()
        {
            Assert.AreEqual(new string[] { "Mallard", "Hook Bill", "Crested", "Blue Swedish" },
                Kata.GooseFilter(new string[] { "Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish" }));

            Assert.AreEqual(new string[] { "Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested" },
                Kata.GooseFilter(new string[] { "Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested" }));

            Assert.AreEqual(new string[] { },
                Kata.GooseFilter(new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" }));
        }
        [Test]
        public void CapitalizeTest()
        {
            Assert.AreEqual(new string[2] { "AbCdEf", "aBcDeF" }, Kata.Capitalize("abcdef"));
            Assert.AreEqual(new string[2] { "CoDeWaRs", "cOdEwArS" }, Kata.Capitalize("codewars"));
            Assert.AreEqual(new string[2] { "AbRaCaDaBrA", "aBrAcAdAbRa" }, Kata.Capitalize("abracadabra"));
            Assert.AreEqual(new string[2] { "CoDeWaRrIoRs", "cOdEwArRiOrS" }, Kata.Capitalize("codewarriors"));
        }
        [Test]
        public void GreetTest()
        {
            Assert.AreEqual("Welcome", Kata.Greet("english"));
            Assert.AreEqual("Welkom", Kata.Greet("dutch"));
            Assert.AreEqual("Welcome", Kata.Greet("IP_ADDRESS_INVALID"));
            Assert.AreEqual("Welcome", Kata.Greet(""));
            Assert.AreEqual("Welcome", Kata.Greet("2"));
        }
        [Test]
        public void AddLengthTest()
        {
            Assert.AreEqual(new string[] { "apple 5", "ban 3" }, Kata.AddLength("apple ban"));
            Assert.AreEqual(new string[] { "you 3", "will 4", "win 3" }, Kata.AddLength("you will win"));
        }
        [Test]
        public void SaleHotDogsTest()
        {
            Assert.AreEqual(100, Kata.SaleHotDogs(1));
            Assert.AreEqual(400, Kata.SaleHotDogs(4));
            Assert.AreEqual(475, Kata.SaleHotDogs(5));
            Assert.AreEqual(855, Kata.SaleHotDogs(9));
            Assert.AreEqual(900, Kata.SaleHotDogs(10));
            Assert.AreEqual(9000, Kata.SaleHotDogs(100));
        }
        [TestCase(22, ExpectedResult = "drink whisky")]
        [TestCase(20, ExpectedResult = "drink beer")]
        [TestCase(16, ExpectedResult = "drink coke")]
        [TestCase(13, ExpectedResult = "drink toddy")]
        public static string PeopleWithAgeDrinkTest(int old) => Kata.PeopleWithAgeDrink(old);
        [TestCase("code", "code")]
        [TestCase("CODe", "CODE")]
        [TestCase("COde", "code")]
        [TestCase("Code", "code")]
        public void SolveTests(string s, string expected)
        {
            Assert.That(Kata.Solve(s), Is.EqualTo(expected));
        }
        [TestCase(-55, 55)]
        [TestCase(-10, 10)]
        [TestCase(-2, 2)]
        [TestCase(0, 0)]
        [TestCase(1, -1)]
        public void OppositeTest(int expected, int input)
        {
            Assert.AreEqual(expected, Kata.Opposite(input));
        }
        [Test]
        [TestCase(55, 0, 10)]
        [TestCase(55, 1, 10)]
        [TestCase(54, 2, 10)]
        [TestCase(1, 0, 1)]
        [TestCase(-1, 0, -1)]
        public void GetSumTest(int expected, int input1, int input2)
        {
            // Assert.AreEqual(45, Kata.GetSum(0, 10));
            Assert.AreEqual(expected, Kata.GetSum(input1, input2));
            // Assert.AreEqual(-1, Kata.GetSum(0, -1));
        }
        [Test, Description("Basic Tests")]
        public void ReplaceTest()
        {
            Assert.AreEqual("H!!", Kata.Replace("Hi!"));
            Assert.AreEqual("!H!! H!!", Kata.Replace("!Hi! Hi!"));
            Assert.AreEqual("!!!!!", Kata.Replace("aeiou"));
            Assert.AreEqual("!BCD!", Kata.Replace("ABCDE"));
        }
        [TestCase("I love you", 7)]
        [TestCase("I love you", 14)]
        [TestCase("a lot", 3)]
        [TestCase("not at all", 6)]
        public void HowMuchILoveYouTests(string expected, int input)
        {
            Assert.AreEqual(expected, Kata.HowMuchILoveYou(input));
        }
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, 3, 5, 0)]
        public static void CheckForFactorTest(int[] nums, int key, int min, int max)
        {
            //assign 
            int _min = nums[0], _max = nums[nums.Length - 1];
            //act
            //assert
            Assert.AreEqual(true, TechnicaExam_MultiVision.TechnicalExam_MultiVision_Class.TechnicalExam_MultiVision_Exists(nums, key, _min, _max));
        }
        [Test]
        public void CorrectTest()
        {
            Assert.AreEqual("LONDON", Kata.Correct("L0ND0N"));
            Assert.AreEqual("DUBLIN", Kata.Correct("DUBL1N"));
            Assert.AreEqual("SINGAPORE", Kata.Correct("51NGAP0RE"));
            Assert.AreEqual("BUDAPEST", Kata.Correct("BUDAPE5T"));
            Assert.AreEqual("PARIS", Kata.Correct("PAR15"));
        }
        [Test]
        [TestCase(10, 2, true)]
        [TestCase(63, 7, true)]
        [TestCase(2450, 5, true)]
        [TestCase(24612, 3, true)]
        [TestCase(9, 2, false)]
        [TestCase(653, 7, false)]
        [TestCase(2453, 5, false)]
        [TestCase(24617, 3, false)]
        public static void CheckForFactorTest(int num, int factor, bool isFactor)
        {
            Assert.AreEqual(isFactor, Kata.CheckForFactor(num, factor));
        }
        [Test]
        public void CountSmileysTest()
        {
            Assert.AreEqual(4, Kata.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }));
            Assert.AreEqual(2, Kata.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }));
            Assert.AreEqual(1, Kata.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }));
            Assert.AreEqual(0, Kata.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }));
        }
        [Test]
        public void TwoSortTest()
        {
            Assert.AreEqual("b***i***t***c***o***i***n", Kata.TwoSort(new[] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps" }));
            Assert.AreEqual("a***r***e", Kata.TwoSort(new[] { "turns", "out", "random", "test", "cases", "are", "easier", "than", "writing", "out", "basic", "ones" }));
        }
        [Test, Description("Sample Tests")]
        [TestCase("McClane john", "john McClane")]
        [TestCase("jeggins Mary", "Mary jeggins")]
        [TestCase("jerry tom", "tom jerry")]
        public void NameShufflerTest(string expected, string input)
        {
            Assert.AreEqual(expected, Kata.NameShuffler(input));
        }
        [Test]
        [TestCase(9, new int[] { 1, 2, 3, 4 }, 2)]
        [TestCase(1000000, new int[] { 1, 3, 10, 100 }, 3)]
        [TestCase(-1, new int[] { 1, 3, 10, 100 }, 4)]
        public void IndexTest(int expected, int[] input, int N)
        {
            Assert.AreEqual(expected, Kata.Index(input, N));
        }
        [TestCase("AAAA", "TTTT")]
        [TestCase("ATTGC", "TAACG")]
        [TestCase("GTAT", "CATA")]
        [TestCase("AAGG", "TTCC")]
        [TestCase("CGCG", "GCGC")]
        [TestCase("ATTGC", "TAACG")]
        [TestCase("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA", "CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCTTATGTCTATCTGTCTAAT")]
        public void MakeComplementTests(string dna, string expected)
        {
            Assert.AreEqual(expected, Kata.MakeComplement(dna));
        }
        [Test]
        [TestCase("found the needle at position 3", new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false })]
        [TestCase("found the needle at position 5", new object[] { "283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle", "something somebody lost a while ago" })]
        [TestCase("found the needle at position 30", new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 7, 5, 4, 3, 4, 5, 6, 67, 5, 5, 3, 3, 4, 2, 34, 234, 23, 4, 234, 324, 324, "needle", 1, 2, 3, 4, 5, 5, 6, 5, 4, 32, 3, 45, 54 })]
        public void FindNeedleTests(string expected, object[] input)
        {
            Assert.AreEqual(expected, Kata.FindNeedle(input));
        }
        [Test]
        public void Rot13_EncriptMessageInput_Encryptionsuccessfull()
        {
            Assert.AreEqual("ROT13 example.", Kata.Rot13("EBG13 rknzcyr."));
            Assert.AreEqual("Grfg", Kata.Rot13("Test"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Kata.Rot13("Test")));
        }
        [TestCase(new string[] { "a", "a", "b", "b" }, new string[] { "a", "c", "b", "d" }, 6)]
        [TestCase(new string[] { "a", "a", "b", "c" }, new string[] { "a", "a", "b", "c" }, 16)]
        [TestCase(new string[] { "b", "c", "b", "a" }, new string[] { "", "a", "a", "c" }, 0)]
        public void CheckExamTest(string[] arr1, string[] arr2, int score)
        {
            Assert.AreEqual(score, Kata.CheckExam(arr1, arr2));
        }
        [Test]
        public void RemoveEveryOtherTest()
        {
            Assert.AreEqual(new object[] { "Hello", "Hello Again" }, Kata.RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" }));
        }
        [Test]
        public void GimmeTests()
        {
            Assert.AreEqual(0, Kata.Gimme(new double[] { 2, 3, 1 }));
            Assert.AreEqual(1, Kata.Gimme(new double[] { 5, 10, 14 }));
        }
        [Test, Description("It should work for basic tests")]
        [TestCase("Hi", "Hi!")]
        [TestCase("Hi!!", "Hi!!!")]
        [TestCase("!Hi", "!Hi")]
        [TestCase("!Hi", "!Hi!")]
        [TestCase("Hi! Hi", "Hi! Hi")]
        [TestCase("Hi", "Hi")]
        public void RemoveTest(string expected, string input)
        {
            Assert.AreEqual(expected, Kata.Remove(input));
        }
        [Test]
        public void SortByLengthTests()
        {
            Assert.AreEqual(new string[] { "I", "To", "Beg", "Life" }, Kata.SortByLength(new string[] { "Beg", "Life", "I", "To" }));
            Assert.AreEqual(new string[] { "", "Pizza", "Brains", "Moderately" }, Kata.SortByLength(new string[] { "", "Moderately", "Brains", "Pizza" }));
            Assert.AreEqual(new string[] { "Short", "Longer", "Longest" }, Kata.SortByLength(new string[] { "Longer", "Longest", "Short" }));
        }
        [Test]
        public void FriendOrFoeTest()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names));
        }
        [Test]
        public void One()
        {
            Assert.AreEqual(new int[] { 1, 15, 15 }, Kata.humanYearsCatYearsDogYears(1));
            Assert.AreEqual(new int[] { 2, 24, 24 }, Kata.humanYearsCatYearsDogYears(2));
            Assert.AreEqual(new int[] { 10, 56, 64 }, Kata.humanYearsCatYearsDogYears(10));
        }
        [Test]
        public void CodEWaRs()
        {
            Assert.AreEqual(Kata.Capitals("CodEWaRs"), new int[] { 0, 3, 4, 6 });
        }
        [Test]
        public void InvertValuesTests()
        {
            Assert.AreEqual(new int[] { -1, -2, -3, -4, -5 }, Kata.InvertValues(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new int[] { -1, 2, -3, 4, -5 }, Kata.InvertValues(new int[] { 1, -2, 3, -4, 5 }));
            Assert.AreEqual(new int[] { }, Kata.InvertValues(new int[] { }));
            Assert.AreEqual(new int[] { 0 }, Kata.InvertValues(new int[] { 0 }));
        }
        [Test, Description("Example Tests")]
        public void CountSheepTests()
        {
            Assert.That(Kata.CountSheep(0), Is.EqualTo(""));
            Assert.That(Kata.CountSheep(1), Is.EqualTo("1 sheep..."));
            Assert.That(Kata.CountSheep(2), Is.EqualTo("1 sheep...2 sheep..."));
            Assert.That(Kata.CountSheep(3), Is.EqualTo("1 sheep...2 sheep...3 sheep..."));
        }
        [Test]
        [TestCase("Error", "hello")]
        [TestCase("56", "1")]
        [TestCase("256", "5")]
        [TestCase("6", "0")]
        [TestCase("66", "1.2")]
        public void ProblemTest(string expected, string input)
        {
            Assert.AreEqual(expected, Kata.Problem(input));
        }
        [Test]
        [TestCase(true, "xo")]
        [TestCase(false, "xxOo")]
        [TestCase(false, "xxxm")]
        [TestCase(false, "Oo")]
        [TestCase(false, "ooom")]
        public void XOTests(Boolean expected, string input)
        {
            Assert.AreEqual(expected, Kata.XO(input));
        }
        [Test, Description("Sample Tests")]
        public void RemoveUrlAnchorTests()
        {
            Assert.AreEqual("www.codewars.com", Kata.RemoveUrlAnchor("www.codewars.com#about"));
            Assert.AreEqual("www.codewars.com/katas/?page=1", Kata.RemoveUrlAnchor("www.codewars.com/katas/?page=1#about"));
            Assert.AreEqual("www.codewars.com/katas/", Kata.RemoveUrlAnchor("www.codewars.com/katas/"));
        }
        [Test]
        public void GetRealFloorTest()
        {
            Assert.AreEqual(0, Kata.GetRealFloor(1));
            Assert.AreEqual(4, Kata.GetRealFloor(5));
            Assert.AreEqual(13, Kata.GetRealFloor(15));
        }
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(new long[] { 1, 3, 2, 5, 3 }, Kata.Digitize(35231));
            Assert.AreEqual(new long[] { 0 }, Kata.Digitize(0));
        }
        [Test]
        [TestCase("foefet", "toffee", ExpectedResult = true)]
        [TestCase("Buckethead", "DeathCubeK", ExpectedResult = true)]
        [TestCase("Twoo", "Woot", ExpectedResult = true)]
        [TestCase("apple", "pale", ExpectedResult = false)]
        public static bool IsAnagramTest(string test, string original)
        {
            return Kata.IsAnagram(test, original);
        }
        [Test]
        public void SumPositives()
        {
            Assert.AreEqual(16, Kata.SumPositivesv1(new[] { 6, 2, 1, 8, 10 }));
        }
        [Test]
        public static void SummationTests()
        {
            Assert.AreEqual(1, Kata.Summation(1));
            Assert.AreEqual(36, Kata.Summation(8));
            Assert.AreEqual(253, Kata.Summation(22));
            Assert.AreEqual(5050, Kata.Summation(100));
            Assert.AreEqual(22791, Kata.Summation(213));
        }
        [Test]
        public void CountSheepsTest()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.AreEqual(2, Kata.CountSheeps(sheeps));
        }
        [Test]
        public void DivisorsTest()
        {
            Assert.AreEqual(1, Kata.Divisors(1));
            Assert.AreEqual(4, Kata.Divisors(10));
            Assert.AreEqual(2, Kata.Divisors(11));
            Assert.AreEqual(8, Kata.Divisors(54));
        }
        [Test]
        public void ExtractTests()
        {
            Assert.AreEqual("1,2", Kata.Extract(new[] { 1, 2 }));
        }
        [Test]
        public void ExtractTests1()
        {
            Assert.AreEqual(
                "-6,-3-1,3-5,7-11,14,15,17-20",
                Kata.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 })
            );
        }
        [Test]
        public void ExtractTests2()
        {
            Assert.AreEqual("1-3", Kata.Extract(new[] { 1, 2, 3 }));
        }
        [Test]
        public void ExtractTests3()
        {
            Assert.AreEqual(
                "-3--1,2,10,15,16,18-20",
                Kata.Extract(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 })
            );
        }
        [Test]
        public void MoveTest()
        {
            Assert.That(Kata.Move(0, 4), Is.EqualTo(8));
        }
        [TestCase("Hello", "o", 1)]
        [TestCase("Hello", "l", 2)]
        [TestCase("", "z", 0)]
        public void StrCountTest(string a, string b, int expected)
        {
            Assert.That(Kata.StrCount(a, b), Is.EqualTo(expected));
        }
        [Test]
        public void SumMixTest()
        {
            Assert.AreEqual(22, Kata.SumMix(new object[] { 9, 3, "7", "3" }));
            Assert.AreEqual(42, Kata.SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
            Assert.AreEqual(41, Kata.SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
        }
        [Test]
        public void CheckTests_FindX_ReturnTrueOrFalse()
        {
            Assert.AreEqual(true, Kata.Check(new object[] { 66, 101 }, 66));
            Assert.AreEqual(true, Kata.Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45));
            Assert.AreEqual(true, Kata.Check(new object[] { 't', 'e', 's', 't' }, 'e'));
            Assert.AreEqual(false, Kata.Check(new object[] { "what", "a", "great", "kata" }, "kat"));
        }
        [Test]
        public void MinAndMaxTest_ComputeMaxAndMin_ReturnMax()
        {
            Assert.AreEqual(-110, Kata.Min(new[] { -52, 56, 30, 29, -54, 0, -110 }));
            Assert.AreEqual(0, Kata.Min(new[] { 42, 54, 65, 87, 0 }));
            Assert.AreEqual(566, Kata.Max(new[] { 4, 6, 2, 1, 9, 63, -134, 566 }));
            Assert.AreEqual(5, Kata.Max(new[] { 5 }));
        }
        [Test]
        public void RemoveChar_ManipulateString_ReturnManipulatedString()
        {
            StringAssert.AreEqualIgnoringCase("loquen", Kata.Remove_char("eloquent"));
            StringAssert.AreEqualIgnoringCase("ountr", Kata.Remove_char("country"));
            StringAssert.AreEqualIgnoringCase("erso", Kata.Remove_char("person"));
            StringAssert.AreEqualIgnoringCase("lac", Kata.Remove_char("place"));
            StringAssert.AreEqualIgnoringCase("", Kata.Remove_char("ok"));
        }
        [Test]
        [TestCase(0, 1000, 0.05, 0.18, 1000)]
        [TestCase(14, 1000, 0.01625, 0.18, 1200)]
        public void CalculateYears_CalculateNumberOfYears_ReturnNumberOfYears(double expected, double principal, double interestRate, double taxRate, double desiredSum)
        {
            Assert.AreEqual(expected, Kata.CalculateYears(principal, interestRate, taxRate, desiredSum));
        }
        [Test]
        public void FindShort_Tests_ReturnShortestLength()
        {
            Assert.AreEqual(3, Kata.FindShort("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, Kata.FindShort("turns out random test cases are easier than writing out basic ones"));
            Assert.AreEqual(2, Kata.FindShort("Let's travel abroad shall we"));
        }
        [Test]
        public void basicOp_tests()
        {
            Assert.AreEqual(11, Kata.basicOp('+', 4, 7));
            Assert.AreEqual(-3, Kata.basicOp('-', 15, 18));
            Assert.AreEqual(25, Kata.basicOp('*', 5, 5));
            Assert.AreEqual(7, Kata.basicOp('/', 49, 7));
        }
        [Test]
        public void ToAlternatingCase_Tests()
        {
            Assert.AreEqual("HELLO WORLD", "hello world".ToAlternatingCase());
            Assert.AreEqual("hello world", "HELLO WORLD".ToAlternatingCase());
            Assert.AreEqual("HELLO world", "hello WORLD".ToAlternatingCase());
            Assert.AreEqual("hEllO wOrld", "HeLLo WoRLD".ToAlternatingCase());
            Assert.AreEqual("12345", "12345".ToAlternatingCase());
            Assert.AreEqual("1A2B3C4D5E", "1a2b3c4d5e".ToAlternatingCase());
            Assert.AreEqual("sTRING.tOaLTERNATINGcASE", "String.ToAlternatingCase".ToAlternatingCase());
            Assert.AreEqual("Hello World", "Hello World".ToAlternatingCase().ToAlternatingCase(), "Hello World => hELLO wORLD => Hello World");
        }
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
            Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, Kata.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
            Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, Kata.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));
        }
        [Test]
        public void StrayTests()
        {
            Assert.AreEqual(2, Kata.Stray(new int[] { 1, 1, 2 }));
        }
        [Test]
        public void Test()
        {
            Assert.AreEqual(61000, Kata.Past(0, 1, 1));
        }
        [TestCase("green", "yellow")]
        [TestCase("yellow", "red")]
        [TestCase("red", "green")]
        public void BasicTests(string s, string expected)
        {
            Assert.That(Kata.UpdateLight(s), Is.EqualTo(expected));
        }
        [Test]
        [TestCase("abcd", ExpectedResult = "aabbccdd")]
        [TestCase("Adidas", ExpectedResult = "AAddiiddaass")]
        [TestCase("1337", ExpectedResult = "11333377")]
        [TestCase("illuminati", ExpectedResult = "iilllluummiinnaattii")]
        [TestCase("123456", ExpectedResult = "112233445566")]
        [TestCase("%^&*(", ExpectedResult = "%%^^&&**((")]
        public static string FixedTest(string s)
        {
            return Kata.DoubleChar(s);
        }
        [Test]
        [TestCase(95, 90, 93, ExpectedResult = 'A')]
        [TestCase(70, 70, 100, ExpectedResult = 'B')]
        [TestCase(70, 71, 72, ExpectedResult = 'C')]
        [TestCase(65, 66, 60, ExpectedResult = 'D')]
        [TestCase(32, 15, 21, ExpectedResult = 'F')]
        public static char FixedTests(int n1, int n2, int n3)
        {
            return Kata.GetGrade(n1, n2, n3);
        }
        [Test]
        [TestCase(3, 39)]
        [TestCase(0, 4)]
        [TestCase(2, 25)]
        [TestCase(4, 999)]
        public void PersistenceTests(int expected, long input)
        {
            Assert.AreEqual(expected, Kata.Persistence(input));
        }
        [Test(Description = "Fixed Tests")]
        public void FixedTests()
        {
            Assert.AreEqual("***", Kata.RepeatStr(3, "*"));
            Assert.AreEqual("#####", Kata.RepeatStr(5, "#"));
            Assert.AreEqual("ha ha ", Kata.RepeatStr(2, "ha "));
        }
        [Test]
        public void SumPositives_CalculateSum_ReturnSum()
        {
            Assert.AreEqual(16, Kata.SumPositivesv2(new[] { 6, 2, 1, 8, 10 }));
        }
        [Test]
        public void SplitStrings_SplitString_ReturnArray()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, Kata.SplitStrings("abc"));
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, Kata.SplitStrings("abcdef"));
        }
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15)]
        [TestCase(new int[] { 1, -2, 3, 4, 5 }, ExpectedResult = 13)]
        [TestCase(new int[] { -1, 2, 3, 4, -5 }, ExpectedResult = 9)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, ExpectedResult = 0)]
        public static int PositiveSum_Return(int[] arr)
        {
            return Kata.PositiveSum(arr);
        }
        [Test]
        [TestCase("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", "The sunset sets at twelve o' clock.")]
        [TestCase("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", "The narwhal bacons at midnight.")]
        public void AlphabetPosition1Test_ConstructnewStringWithPositionLetters_ReturnString(string expected, string input)
        {
            Assert.AreEqual(expected, Kata.AlphabetPosition1(input));
        }
        [Test]
        public void DigitalRoot_Calculate_ReturnSum()
        {
            Assert.AreEqual(7, Kata.DigitalRoot(16));
            Assert.AreEqual(6, Kata.DigitalRoot(456));
        }
        [Test]
        public void DuplicateEncode_EncodeWord_ReturnEncoded()
        {
            Assert.AreEqual("(((", Kata.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Kata.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Kata.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", Kata.DuplicateEncode("(( @"));
        }
        [Test]
        public static void ToWeirdCase_Scramble_ReturnWordScrambled()
        {
            Assert.AreEqual("ThIs", Kata.ToWeirdCase("This"));
            Assert.AreEqual("Is", Kata.ToWeirdCase("is"));
            Assert.AreEqual("ThIs Is A TeSt", Kata.ToWeirdCase("This is a test"));
        }
        [Test]
        [TestCase(0, "")]
        [TestCase(0, "abcde")]
        [TestCase(2, "aabbcde")]
        [TestCase(1, "Indivisibility")]
        public void DuplicateCount_CountDuplicates_ReturnTotalDuplicates(int expected, string input)
        => Assert.AreEqual(expected, Kata.DuplicateCount(input));
        [Test]
        public void DuplicateCount_CountDuplicatesAndIgnoreCase_ReturnTotalDuplicates()
        => Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
        [Test]
        public void DuplicateCount_CountDuplicatesAndNoCharactersAdjacent_ReturnTotalDuplicates()
        => Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        [Test]
        [TestCase("sihT si na !elpmaxe", "This is an example!")]
        [TestCase("sihT si na tset", "This is an test")]
        public void ReverseWords_ReturnString(string expected, string input) => Assert.AreEqual(expected, Kata.ReverseWords(input));
        [Test]
        [TestCase(new string[] { "ab", "c_" }, "abc")]
        [TestCase(new string[] { "ab", "cd", "ef" }, "abcdef")]
        public void SplitString(string[] expected, string input) => Assert.AreEqual(expected, Kata.SplitString(input));
        [Test]
        [TestCase(new int[] { 2 }, new int[] { 1, 2 }, new int[] { 1 })]//passed
        [TestCase(new int[] { 2, 2 }, new int[] { 1, 2, 2 }, new int[] { 1 })] //not passed
        [TestCase(new int[] { 1 }, new int[] { 1, 2, 2 }, new int[] { 2 })]//passed
        [TestCase(new int[] { 1, 2, 2 }, new int[] { 1, 2, 2 }, new int[] { })]//not passed
        [TestCase(new int[] { }, new int[] { }, new int[] { 1, 2 })]//passed
        [TestCase(new int[] { 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 2 })]//passed
        public void ArrayDiff_ReturnArrayDiff(int[] expected, int[] input1, int[] input2)
        {
            Assert.AreEqual(expected, Kata.ArrayDiff(input1, input2));
        }
        [Test]
        public void BigNumbersAdd_SumTwoBigIntegers_ReturnSumValue()
        {
            Assert.AreEqual("110", Kata.BigNumbersAdd("91", "19"));
            Assert.AreEqual("1111111111", Kata.BigNumbersAdd("123456789", "987654322"));
            Assert.AreEqual("1000000000", Kata.BigNumbersAdd("999999999", "1"));
        }
        [Test]
        public static void IsPerfectSquare_VerifyIfItsPerfectSquare_ReturnTrueIfItsPerfectSquareOotherwiseFalse()
        {
            Assert.AreEqual(false, Kata.IsPerfectSquare(-1), "negative numbers aren't square numbers");
            Assert.AreEqual(false, Kata.IsPerfectSquare(3), "3 isn't a square number");
            Assert.AreEqual(true, Kata.IsPerfectSquare(4), "4 is a square number");
            Assert.AreEqual(true, Kata.IsPerfectSquare(25), "25 is a square number");
            Assert.AreEqual(false, Kata.IsPerfectSquare(26), "26 isn't a square number");
        }
        [Test, Description("Sample Tests")]
        public void OrderWords_OrderWordsinString_ReturnNewOrderedString()
        {
            Assert.AreEqual("Thi1s is2 3a T4est", Kata.OrderWords("is2 Thi1s T4est 3a"));
            Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", Kata.OrderWords("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.AreEqual("", Kata.OrderWords(""));
        }
        [Test]
        [TestCase("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", "The sunset sets at twelve o' clock.")]
        [TestCase("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", "The narwhal bacons at midnight.")]
        public void AlphabetPosition_ReplaceCharacterByNumberPosition_ReturnString(string expected, string input)
        {
            Assert.AreEqual(expected, Kata.AlphabetPosition(input));
        }
        [Test]
        // [TestCase(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0},new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1})]
        public void MoveZeroes_MovexerostoTheEndArray_ResturnArray(
            // int[] expectedResult, int[] result
            )
        {
            //   Assert.AreEqual(expectedResult, Kata.MoveZeroes(result));
            Assert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }
        [Test]
        [TestCase("1", 1)]
        [TestCase("120", 5)]
        [TestCase("362880", 9)]
        [TestCase("1307674368000", 15)]
        public void Factorial_CalculateFactorial_ReturnStringWithFactoialSum(string expected, int n)
        {
            Assert.AreEqual(expected, Kata.Factorial(n));
        }
    }
    [TestFixture]
    public static class ScrambliesTests
    {
        private static void testing(bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase("rkqodlw", "world", true)]
        [TestCase("cedewaraaossoqqyt", "codewars", true)]
        [TestCase("katas", "steak", false)]
        [TestCase("scriptjavx", "javascript", false)]
        [TestCase("scriptingjava", "javascript", true)]
        [TestCase("scriptsjava", "javascripts", true)]
        [TestCase("javscripts", "javascript", false)]
        [TestCase("aabbcamaomsccdd", "commas", true)]
        [TestCase("commas", "commas", true)]
        [TestCase("sammoc", "commas", true)]
        public static void Scramble_ValidateAllTestCases_PassAllTests(string str1, string str2, bool expectedResult)
        {
            testing(Scramblies.Scramble(str1, str2), expectedResult);
        }
    }
    [TestFixture]
    public class StripCommentsTest
    {
        //multivision | area telecomunicações | possio software de avarias na rede 
        [Test]
        public void StripComments()
        {
            Assert.AreEqual(
                    "apples, pears",
                    StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new char[] { '#', '!' }));

            Assert.AreEqual("a", StripCommentsSolution.StripComments("a #b\nc\nd $e f g", new char[] { '#', '$' }));

        }
    }
    public class SnailTest
    {
        [Test]
        public void SnailTest_4x4Matrix()
        {
            int[][] array =
           {
           new []{1, 2, 3,10},
           new []{4, 5, 6,11},
           new []{7, 8, 9,12},
           new []{13, 14, 15,16}
       };
            var r = new[] { 1, 2, 3, 10, 11, 12, 16, 15, 14, 13, 7, 4, 5, 6, 9, 8 };
            Test(array, r);
        }
        [Test]
        public void BubbleSortRecursive_SortArray_Success()
        {
            //arrange
            var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            var _auxArray = new[] { 1, 2, 3, 10, 11, 12, 16, 15, 14, 13, 7, 4, 5, 6, 9, 8 };
            //act
            int[] _auxSortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] _auxSortedArray1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            int[] _auxReturnBubleSortMethod = SnailSolution.BublerSortRecursive(r, r.Length);
            int[] _auxReturnBubleSortMethod2 = SnailSolution.BublerSortRecursive(_auxArray, _auxArray.Length);

            //assert
            Assert.AreEqual(_auxSortedArray, _auxReturnBubleSortMethod);
            Assert.AreEqual(_auxSortedArray1, _auxReturnBubleSortMethod2);
        }
        [Test]
        public void SnailTest_3x3Matrix()
        {
            int[][] array =
            {
           new []{1, 2, 3},
           new []{4, 5, 6},
           new []{7, 8, 9}
       };
            var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            Test(array, r);
        }
        public string Int2dToString(int[][] a)
        {
            return $"[{string.Join("\n", a.Select(row => $"[{string.Join(",", row)}]"))}]";
        }
        public void Test(int[][] array, int[] result)
        {
            var text = $"{Int2dToString(array)}\nshould be sorted to\n[{string.Join(",", result)}]\n";
            Console.WriteLine(text);
            Assert.AreEqual(result, SnailSolution.Snail(array));
        }
    }
    public class CountIPAddressesTest
    {
        [Test]
        [TestCase(50, "10.0.0.0", "10.0.0.50")]
        [TestCase(246, "20.0.0.10", "20.0.1.0")]
        // [TestCase((1L << 32) - 1L,"0.0.0.0", "255.255.255.255")]
        public void SmapleTest(int expected, string input1, string input2)
        {
            Assert.AreEqual(expected, CountIPAddresses.IpsBetween(input1, input2));
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}