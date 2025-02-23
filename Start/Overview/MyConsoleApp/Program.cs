﻿// using System;
using System.Net;
using System.Text.RegularExpressions;
// using System.Globalization;
using System.Net.Sockets;
using System.Linq;
using System.Text;
using System.Numerics;
// This program shows how to use the IPAddress class to obtain a server
// IP addressess and related information.
// using System;
// using System.Net;

namespace TechnicaExam_MultiVision
{

    class Calculator
    {
        /// Sums an array of​​​​​​‌​​‌​​‌‌‌​​‌‌​‌​​​​‌‌‌​‌​ numbers.
        /// <returns>the exact sum of the numbers</returns>
        public static string Sum(params string[] numbers)
        {
            // double total = 0;

            // foreach (string number in numbers)
            // {
            //     total = total + double.Parse(number);
            // }

            // return total.ToString();
            var _aux = numbers.Sum(z => double.Parse(z));
            return Math.Round((double)_aux, 2, MidpointRounding.ToEven).ToString();
        }
    }
    public class Answer
    {
        /// Executes the service with the given​​​​​​‌​​‌​​‌‌‌​​‌‌​‌​​​​‌‌‌​‌​ connection.
        public void Run(Service s, Connection c)
        {
            s.SetConnection(c);
            try
            {
                s.Execute();
                c.Commit();
            }
            catch (Exception e)
            {
                c.Rollback();
            }
            finally
            {
                c.Close();
            }
        }
    }

    /// Definition of a service
    public interface Service
    {
        void Execute();
        void SetConnection(Connection c);
    }

    /// Definition of a connection
    public interface Connection
    {
        void Commit();
        void Rollback();
        void Close();
    }
    public class TechnicalExam_MultiVision_Class
    {
        public static bool TechnicalExam_MultiVision_Exists(int[] ints, int k, int min, int max)
        {
            // return ints.Contains(k);
            //      if (maxPostitionArray >= minPostionArray)
            // {
            //     int _middle = minPostionArray + (maxPostitionArray - middleElement) / 2;
            //     if (array[_middle] == middleElement) return _middle;
            //     if (array[_middle] > middleElement)
            //         return BinarySearchOnArray(array, minPostionArray, _middle - 1, middleElement);
            //     return BinarySearchOnArray(array, _middle + 1, maxPostitionArray, middleElement);
            // }
            // return -1;

            // if (ints.Length == 0) return false;
            try
            {

            }
            catch
            {

            }
            finally
            {

            }
            if (max >= min)
            {
                int _middle = min + (max - k) / 2;//does not preditc with odd length
                if (ints[_middle] == k) return true;
                if (ints[_middle] > k) return TechnicalExam_MultiVision_Exists(ints, k, min, _middle - 1);
                else return TechnicalExam_MultiVision_Exists(ints, k, _middle + 1, max);
            }
            return false;
        }
    }
}
namespace Mssc.Services.ConnectionManagement
{
    class TestIPAddress
    {

        /**
          * The IPAddresses method obtains the selected server IP address information.
          * It then displays the type of address family supported by the server and its
          * IP address in standard and byte format.
          **/
        private static void IPAddresses(string server)
        {
            try
            {
                System.Text.ASCIIEncoding ASCII = new System.Text.ASCIIEncoding();

                // Get server related information.
                IPHostEntry heserver = Dns.GetHostEntry(server);

                // Loop on the AddressList
                foreach (IPAddress curAdd in heserver.AddressList)
                {
                    // Display the type of address family supported by the server. If the
                    // server is IPv6-enabled this value is: InterNetworkV6. If the server
                    // is also IPv4-enabled there will be an additional value of InterNetwork.
                    Console.WriteLine("AddressFamily: " + curAdd.AddressFamily.ToString());

                    // Display the ScopeId property in case of IPV6 addresses.
                    if (curAdd.AddressFamily.ToString() == ProtocolFamily.InterNetworkV6.ToString())
                        Console.WriteLine("Scope Id: " + curAdd.ScopeId.ToString());

                    // Display the server IP address in the standard format. In
                    // IPv4 the format will be dotted-quad notation, in IPv6 it will be
                    // in in colon-hexadecimal notation.
                    Console.WriteLine("Address: " + curAdd.ToString());

                    // Display the server IP address in byte format.
                    Console.Write("AddressBytes: ");

                    Byte[] bytes = curAdd.GetAddressBytes();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        Console.Write(bytes[i]);
                    }

                    Console.WriteLine("\r\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("[DoResolve] Exception: " + e.ToString());
            }
        }

        // This IPAddressAdditionalInfo displays additional server address information.
        private static void IPAddressAdditionalInfo()
        {
            try
            {
                // Display the flags that show if the server supports IPv4 or IPv6
                // address schemas.
                Console.WriteLine("\r\nSupportsIPv4: " + Socket.OSSupportsIPv4);
                Console.WriteLine("SupportsIPv6: " + Socket.OSSupportsIPv6);

                if (Socket.OSSupportsIPv6)
                {
                    // Display the server Any address. This IP address indicates that the server
                    // should listen for client activity on all network interfaces.
                    Console.WriteLine("\r\nIPv6Any: " + IPAddress.IPv6Any.ToString());

                    // Display the server loopback address.
                    Console.WriteLine("IPv6Loopback: " + IPAddress.IPv6Loopback.ToString());

                    // Used during autoconfiguration first phase.
                    Console.WriteLine("IPv6None: " + IPAddress.IPv6None.ToString());

                    Console.WriteLine("IsLoopback(IPv6Loopback): " + IPAddress.IsLoopback(IPAddress.IPv6Loopback));
                }
                Console.WriteLine("IsLoopback(Loopback): " + IPAddress.IsLoopback(IPAddress.Loopback));
            }
            catch (Exception e)
            {
                Console.WriteLine("[IPAddresses] Exception: " + e.ToString());
            }
        }
        public static long IpsBetween(string start, string end)
        {
            long _returnTotalCount = -1;
            string server;

            IPAddress _IPStart;
            IPAddress _IPEnd;
            // Define a regular expression to parse user's input.
            // This is a security check. It allows only
            // alphanumeric input string between 2 to 40 character long.
            Regex regex = new Regex(@"^[a-zA-Z]\w{1,39}$");

            //   if (args.Length < 1)
            //   {
            // If no server name is passed as an argument to this program, use the current
            // server name as default.
            server = Dns.GetHostName();
            // Console.WriteLine("Using current host: " + server);
            //   }
            //   else
            //   {
            server = start;
            if (!(regex.Match(server)).Success
            )
            {
                Console.WriteLine("Input string format not allowed.");
                return _returnTotalCount;
            }
            if (regex.Match(end).Success)
                Console.WriteLine("last IPaddress format allowed.");
            //   }
            // Get the list of the addresses associated with the requested server.
            IPAddresses(server);

            // Get additional address information.
            IPAddressAdditionalInfo();


            if (IPAddress.TryParse(start, out _IPStart) && IPAddress.TryParse(end, out _IPEnd))
            {
                var _enumerableEnd = (from z in _IPEnd.ToString()
                                      orderby z descending
                                      select z).ToString().Split('.');
                var _enumerableStart =
                   (from z in _IPEnd.ToString()
                    orderby z descending
                    select z).ToString()
                                   .Split('.')
                                   ;

                int _auxEnd = 0;
                Int32.TryParse(string.Join("", _enumerableEnd), out _auxEnd);
                int _auxStart = 0;
                Int32.TryParse(string.Join("", _enumerableStart), out _auxStart);
                _returnTotalCount = _auxEnd - _auxStart;
            }
            return _returnTotalCount;
        }

        public static void Main(string[] args)
        {
            string server;
            // Define a regular expression to parse user's input.
            // This is a security check. It allows only
            // alphanumeric input string between 2 to 40 character long.
            Regex rex = new Regex(@"^[a-zA-Z]\w{1,39}$");

            if (args.Length < 1)
            {
                // If no server name is passed as an argument to this program, use the current
                // server name as default.
                server = Dns.GetHostName();
                Console.WriteLine("Using current host: " + server);
            }
            else
            {
                server = args[0];
                if (!(rex.Match(server)).Success)
                {
                    Console.WriteLine("Input string format not allowed.");
                    return;
                }
            }

            // Get the list of the addresses associated with the requested server.
            IPAddresses(server);

            // Get additional address information.
            IPAddressAdditionalInfo();
        }
    }
}
namespace MyConsoleApp
{
    public static class JadenCase
    {
        ///Best patrice
        public static string ToJadenCase(this string phrase)
        {
            //return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
            return string.Join(" ", phrase.Split().Select(z => Char.ToUpper(z[0]) + z.Substring(1)));
        }
        /*
        public static string ToJadenCase(this string phrase)
        {
            string[] _str = phrase.Split(' ');
            string _formatted = string.Empty;
            for (int i = 0; i < _str.Length; i++)
            {
                _formatted += string.Join("", _str[i].First().ToString().ToUpper());
                _formatted += string.Join("", _str[i].Skip(1).ToArray());
                if (i != _str.Length - 1)
                {
                    _formatted += " ";
                }
                Console.WriteLine("_formatted {0}", _formatted);
            }
            return _formatted;
        }
        */
    }
    public class SnailSolution
    {
        static void WentLeft(int[][] array, List<int> _returnList, int _next, bool _wentLeft, bool _wentUp, int i)
        {
            int _auxX = array.Length - 1;
            int _auxY = array[i].Length - 1;
            for (int q = _next; q >= 0; q--)
            {
                _returnList.Add(array[array.Length - 1][q]);
                _next = q;
            }
            _wentLeft = false;
            _wentUp = true;
            _next = _next + 1;
        }
        static void WentDown(int _next, int[][] array, List<int> _returnList, bool _wentDown, bool _wentLeft, int j)
        {
            for (int k = _next; k < array.Length; k++)
            {
                _returnList.Add(array[k][j]);
                _next = j;
            }
            _wentDown = false;
            _wentLeft = true;
            _next = _next - 1;
        }
        static void WentUp(int[][] array, decimal _auxMiddle, List<int> _returnList, bool _wentUp, bool _wentRight, int _auxMiddle2)
        {
            int _auxRowLengthMinusOne = array.Length - 1;
            if (_auxRowLengthMinusOne % 2 == 0)
            {
                _auxMiddle = _auxRowLengthMinusOne / 2;
                _auxRowLengthMinusOne = _auxRowLengthMinusOne - 1;
            }
            else
            {
                _auxMiddle = Math.Round(Convert.ToDecimal(_auxRowLengthMinusOne / 2), 0, MidpointRounding.ToEven);
                _auxMiddle = _auxMiddle + 1;
            }
            for (int q = _auxRowLengthMinusOne; q >= _auxMiddle; q--)
            {
                _returnList.Add(array[q][0]);
            }
            _wentUp = false;
            _wentRight = true;
            _auxMiddle2 = _auxRowLengthMinusOne;
        }
        static void WentRight(int[][] array, decimal _auxMiddle, int _auxMiddle2, List<int> _returnList, bool _wentRight, bool _isGoalAchivied, int i)
        {
            int _auxColumnLength = array[i].Length - 1;
            if (_auxColumnLength % 2 == 0)
            {
                _auxMiddle = _auxColumnLength / 2;
            }
            else
            {
                _auxMiddle = Math.Round(Convert.ToDecimal(_auxColumnLength / 2), 0, MidpointRounding.ToEven);
                _auxMiddle = _auxMiddle + 1;
            }
            decimal _auxDec = (_auxColumnLength) / 2;//to consider the 0 position
            _auxDec = _auxDec / 2;
            decimal _auxq = Math.Round(Convert.ToDecimal(_auxDec), MidpointRounding.ToEven);
            // int _auxMiddle = int.Parse(_auxq.ToString());
            int _aux1;
            if (int.TryParse(_auxMiddle2.ToString(), out _aux1))
            {
                for (int q = _auxMiddle2; q <= _auxMiddle; q++)
                {
                    _returnList.Add(array[_auxMiddle2][q]);
                }
                _wentRight = false;
                _isGoalAchivied = true;
            }
            else throw new Exception("Convertion error on middle value");
        }
        public static int[] BublerSortRecursive(int[] array, int length)
        {
            if (length == 1)
            {
                return array;
            }
            int _count = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int _temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = _temp;
                    _count++;
                }
            }
            if (_count == 0)
            {
                return array;
            }
            return BublerSortRecursive(array, length - 1);
        }
        ///Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.
        ///todo | 1 determine the row length and column length| 2- execute the snail path 
        public static int[] Snail(int[][] array)
        {
            int[] _return = new int[] { };
            List<int> _returnList = new List<int>();
            int _rowLength = array.Length - 1;
            int _next = 0;
            int _columnLength = 0;
            bool _wentDown = false;
            bool _wentLeft = false;
            bool _wentUp = false;
            bool _wentRight = false;
            bool _isToAdd = true;
            bool _isGoalAchivied = false;
            decimal _auxMiddle = 0;
            int _auxMiddle2 = 0;
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        if (!_isGoalAchivied)
                        {
                            _columnLength = array[i].Length - 1;
                            if (_isToAdd) _returnList.Add(array[i][j]);
                            if (_columnLength.Equals(j))
                            {
                                _wentDown = true;
                                _isToAdd = false;
                                _next = i + 1;
                            }
                            if (_wentDown)
                            {
                                WentDown(_next, array, _returnList, _wentDown, _wentLeft, j);
                            }
                            if (_wentLeft)
                            {
                                WentLeft(array, _returnList, _next, _wentLeft, _wentUp, i);
                            }
                            if (_wentUp)
                            {
                                WentUp(array, _auxMiddle, _returnList, _wentUp, _wentRight, _auxMiddle2);
                            }
                            if (_wentRight)
                            {
                                WentRight(array, _auxMiddle, _auxMiddle2, _returnList, _wentRight, _isGoalAchivied, i);
                            }
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine($" {Environment.NewLine}Stack{e.ToString()}");
            }
            return _returnList.ToArray();
        }
    }

    public class StripCommentsSolution
    {
        ///Complete the solution so that it strips all text that follows any of a set of comment markers passed in. Any whitespace at the end of the line should also be stripped out.
        public static string StripComments(string text, string[] commentSymbols)
        {//todo 1- get substring from 0 to NewLine |2 - apply regex into previous substring| 3-apply to return value
            string _return = string.Empty;
            string[] _auxText = text.Split(Environment.NewLine, int.MaxValue, StringSplitOptions.RemoveEmptyEntries);
            int _count = 0;
            Dictionary<string, List<string>> _auxDic = new Dictionary<string, List<string>>();
            string _auxString = string.Empty;
            for (int j = 0; j < _auxText.Length; j++)
            {
                for (int i = 0; i < commentSymbols.Length; i++)
                {
                    List<string> _auxList = new List<string>();
                    if (!_auxDic.TryGetValue(_auxText[j], out _auxList))
                    {
                        if (_auxList.Count() == 0) _auxList = new List<string>();
                        if (_auxList.Contains(commentSymbols[i]))
                        {
                            _auxList.Add(commentSymbols[i]);
                            _auxDic.Add(_auxText[j], _auxList);
                            string regex = string.Format(@"^(?:(?!\s{0})(?!\sdef).)*", commentSymbols[i]);
                            var _match = Regex.Match(_auxText[j], regex);
                            // if (_match.Success)
                            // {
                            string _auxValue = _match.Value;
                            _return += _auxValue;
                            if (_count < _auxText.Length - 1)
                            {
                                _return += Environment.NewLine;
                                _count++;
                            }
                            // }
                            // else
                            // _return+=_auxText[j];
                        }
                    }
                    // else{
                    //     _return+=_auxText[j];
                    // }
                }
            }
            return _return;
        }
    }


    public class PagnationHelper<T>
    {
        // TODO: Complete this class
        private List<T> collection;
        private int itemCount;
        public List<T> Collection { get => collection; }
        private int itemsPerPage;
        public int ItemsPerPage
        {
            //todo | research | get=>return >= itemsPerPage;
            get { return itemsPerPage; }
            set => itemsPerPage = value;
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get => itemCount;

        }
        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                return 0;
            }
        }
        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            // collection
        }
        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            return this.PageIndex(pageIndex);
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            return 0;
        }
    }
    public class JosephusSurvivor
    {/*
    In this kata you have to correctly return who is the "survivor", ie: the last element of a Josephus permutation.

Basically you have to assume that n people are put into a circle and that they are eliminated in steps of k elements, like this:
josephus_survivor(7,3) => means 7 people in a circle;
one every 3 is eliminated until one remains
[1,2,3,4,5,6,7] - initial sequence
[1,2,4,5,6,7] => 3 is counted out
[1,2,4,5,7] => 6 is counted out
[1,4,5,7] => 2 is counted out
[1,4,5] => 7 is counted out
[1,4] => 5 is counted out
[4] => 1 counted out, 4 is the last element - the survivor!
*/
        public static int JosSurvivor(int n, int k)
        {//todo 1- iterate in a contructed list array wich elements begin in 1  en end in n | 2- remove element array considering offset | 3- when offset > array.Length survivor = next element
            int _lastIndex = 0;
            int _originalOffset = k - 1;
            int _originalOffset_Increased = k;
            List<int> _listintegers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                _listintegers.Add(i);
            }
            int _aux = _originalOffset;//compatible to zero index methods
            while (_aux < _listintegers.Count())
            {
                _listintegers.RemoveAt(_aux);

                if ((_aux + _originalOffset_Increased) <= _listintegers.Count() - 1)
                {
                    _aux += _originalOffset;
                }
                else
                    _aux = _originalOffset;
                _lastIndex = _aux;
            }
            int _survivor = 0;
            if (_lastIndex <= _listintegers.Count() - 1)
                _survivor = _listintegers.ElementAt(_lastIndex++);
            else _survivor = _listintegers.Last();
            return _survivor;
        }
    }
    public class Scramblies
    {
        ///description: Best practise | clever
        public static bool Scramble(string str1, string str2)
        {
            return str2.All(x => str1.Count(y => y == x) >= str2.Count(y => y == x));
        }
        ///Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.
        // public static bool Scramble(string str1, string str2)
        // {
        //     bool _return = true;
        //     int _indexOf = 0;
        //     //todo 1- iterate in each character of str1 and str2, to find a equal character , and if yes, remove character from str1;
        //     for (int i = 0; i < str2.Length; i++)
        //     {
        //         _indexOf = str1.IndexOf(str2[i]);
        //         if (_indexOf > -1)
        //         {
        //             str1 = str1.Remove(_indexOf, 1);
        //         }
        //         else
        //         {
        //             _return = false;
        //             return _return ;
        //         }
        //     }
        //     return _return;
        // }

    }

    public class Answer
    {
        /// multisition technical Exame
        /*
        <returns>the character of which s is the​​​​​​‌​​‌​​‌​‌​‌​‌‌​‌‌‌​​‌​‌‌‌ representation</returns>
        */
        public static char ScanChar(string s)
        {
            if (!s.Equals(string.Empty))
                return char.Parse(Regex.Replace(s, "[a-zA-Z]"
              , new MatchEvaluator(z => ((z.Value[0] + (Char.IsLetter(z.Value, 0) ? z.Value : "?"))))));
            return char.Parse(string.Empty);
        }
    }
    public class BinarySearch
    {
        public static bool Exists(int[] ints, int k)
        {
            if (ints.Length == 0)
                return false;
            int _min = ints[0];
            int _max = ints[ints.Length - 1];
            if (BinarySearchOnArray(ints, _min, _max, k).Equals(-1))
                return false;
            return true;
        }
        public static int BinarySearchOnArray(int[] array, int minPostionArray, int maxPostitionArray, int middleElement)
        {
            if (maxPostitionArray >= minPostionArray)
            {
                int _middle = minPostionArray + (maxPostitionArray - middleElement) / 2;
                if (array[_middle] == middleElement) return _middle;
                if (array[_middle] > middleElement)
                    return BinarySearchOnArray(array, minPostionArray, _middle - 1, middleElement);
                return BinarySearchOnArray(array, _middle + 1, maxPostitionArray, middleElement);
            }
            return -1;
        }
    }
    public class LongestConsecutives
    {
        public static string LongestConsec(string[] strarr, int k)
        {//todo 1- in k cicles 2- calculate the sum of two strings 3- if _highestLength it's not higher then _currentLength, then _highestLength=_currentLength
            int _highestLength = 0;
            string _currentString = string.Empty;
            string _highestString = string.Empty;
            if (strarr.Length < k)
            {
                return string.Empty;
            }
            for (int i = 0; i < k; i++)
            {
                _currentString = strarr[i] + strarr[i + 1];
                if (_highestLength < _currentString.Length)
                {
                    _highestLength = _currentString.Length;
                    _highestString = _currentString;
                }
            }
            return _highestString;
        }
    }
    public static class TechnicalExam_GameCompany_Adder
    {
        struct DoubleStruct
        {
            public DoubleStruct(double input)
            {
                log = input;
            }

            public double log { get; }
            public static int Log10(double inputDouble)
            {
                double _auxDouble = Math.Log10(inputDouble);
                int.TryParse(_auxDouble.ToString(), out var _auxInteger);
                return _auxInteger;
            }

            public override string ToString() => $"({log})";
        }
        public static int Sum(Func<int>[] functions, Action<int> onSumChanged)
        {
            int sum = 0;
            foreach (Func<int> function in functions)
            {
                sum += function();
                onSumChanged(sum);
            }
            return sum;
        }

        public static void Main(string[] args)
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
            Console.WriteLine("Final result: " + result);
        }
    }
    public class TechnicalExam_GameCompany_UniqueProduct
    {
        public static string FirstUniqueProduct(string[] products)
        {
            // str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
            return products.GroupBy(z => z).Where(z => z.Count() == 1).FirstOrDefault().Key;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqueProduct(new string[] { "Apple", "Computer", "Apple", "Bag" }));
        }
    }
    public static class Kata
    {
        public static string HowMuchILoveYou(int nb_petals)
        {
            return new string[] 
            { "I love you", "a little", "a lot", "passionately", "madly", "not at all" }[(nb_petals - 1) % 6];
            // string[] _aux = { "I love you", "a little", "a lot", "passionately", "madly", "not at all" };
            // int _auxPetals = nb_petals - 1;
            // if (_auxPetals > 5)
            // {
            //     while (_auxPetals > 5)
            //     {
            //         _auxPetals -= 6;
            //     }
            // }
            // return _aux[_auxPetals];
        }
        public static string Correct(string text) => text.Replace('0', 'O').Replace('5', 'S').Replace('1', 'I');
        public static bool CheckForFactor(int num, int factor) => num % factor == 0;
        public static int CountSmileys(string[] smileys)
        {
            return smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));

            // List<string> _auxSmileFacesFirstCharacter = new List<string>(new string[] { ":", ";" });
            // List<string> _auxSmileFacesSecondCharacter = new List<string>(new string[] { "-", "~" });
            // List<string> _auxSmileFacesThirdCharacter = new List<string>(new string[] { ")", "D" });
            // int _auxCount = 0;
            // return smileys.Count(z =>
            // (
            //     (z.Length >= 2 && z.Length <= 3)
            //     && _auxSmileFacesFirstCharacter.Contains(z.ElementAt(0).ToString())
            //     && (z.Length == 3
            //     ? (_auxSmileFacesSecondCharacter.Contains(z.ElementAt(1).ToString())
            //     && _auxSmileFacesThirdCharacter.Contains(z.ElementAt(2).ToString()))
            //     : _auxSmileFacesThirdCharacter.Contains(z.ElementAt(1).ToString())
            //     )
            // )
            // );
        }
        public static string TwoSort(string[] s)
        {
            return string.Join("***", s.OrderBy(z => z, StringComparer.Ordinal).First().ToArray());
        }
        public static int FactorialV2(int n)
        {
            if (n < 0 && n > 12) throw new ArgumentOutOfRangeException();
            if (n == 0) return 1;
            int _aux = 1;
            // for(int i=1;i<=n;i++) _aux*=i;
            return Enumerable.Range(1, n).Aggregate(1, (x, y) => x * y);
            // return _aux;
        }
        public static string OddOrEven(int[] array)
        {
            return array.Sum() % 2 == 0 ? "even" : "odd";
        }
        public static string NameShuffler(string str)
        {
            return string.Join(" ", str.Split(' ').Reverse());
        }
        public static double Index(int[] array, int n)
        {
            if (n > array.Length - 1) return -1;
            return Math.Pow(array[n], 2);
        }
        public static string MakeComplement(string dna)
        {
            // return dna.Replace('T', '?').Replace('A', 'T').Replace('?', 'A').Replace('G', '?').Replace('C', 'G').Replace('?', 'C');
            return String.Join("", dna.Select(z => "AGCT"["TCGA".IndexOf(z)]));
        }
        public static string FindNeedle(object[] haystack)
        {
            //this case its beter to converto into list and use "indexof" method
            return $"found the needle at position {haystack.ToList().IndexOf("needle")}";
        }
        public static int CheckExam(string[] arr1, string[] arr2)
        {
            int _auxReturn = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i]) _auxReturn += 4;
                if (arr1[i] != arr2[i]) _auxReturn -= 1;
                if (arr2[i] != string.Empty) _auxReturn += 0;
            }
            return _auxReturn < 0 ? 0 : _auxReturn;
        }
        public static int SquareSum(int[] numbers) => (int)numbers.Sum(z => Math.Pow(z, 2));
        public static object[] RemoveEveryOther(object[] arr)
        {
            if (arr.Length < 3) return arr;
            return new object[] { (arr.Where((_string, index) => (int)index % 2 == 0).ToArray()) };
        }
        public static int Gimme(double[] inputArray) => inputArray.ToList().IndexOf(inputArray.OrderBy(z => z).ElementAt(1));
        public static string Remove(string s) => s.EndsWith('!') ? new string(s.Take(s.Length - 1).ToArray()) : s;
        public static string[] SortByLength(string[] array)
        {
            return array.OrderBy(z => z.Length).ToArray();
        }
        public static IEnumerable<string> FriendOrFoe(string[] names) => names.Where(z => z.Length == 4);
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            int catYear = 15 + (humanYears >= 2 ? 9 + 4 * (humanYears - 2) : 0);
            int dogYear = 15 + (humanYears >= 2 ? 9 + 5 * (humanYears - 2) : 0);
            return new int[] { humanYears, catYear, dogYear };
        }
        public static int[] Capitals(string word) => word.Where(char.IsUpper).Select(z => word.IndexOf(z)).ToArray();
        public static int[] InvertValues(int[] input)
        {
            return input.Select(z => z < 0 ? Math.Abs(z) : z * -1).ToArray();
        }
        public static int[] TechnicalExam_GameCompany_CountPositivesSumNegatives(int[] input)
        {
            if (input == null) return new int[] { };
            if (input.Length == 0) return new int[] { 0, 0 };
            var _auxNegatives = input.Where(z => z < 0);
            return new int[] { input.Count(z => z > 0), _auxNegatives.Sum() };
        }
        public static int[] TechnicalExam_GameCompany_Between(int a, int b) => Enumerable.Range(a, b - a).ToArray();
        public static string SumStrings(string a, string b)
        {
            double.TryParse(a, out double _auxA);
            double.TryParse(b, out double _auxB);
            return (Math.Round(_auxA + _auxB)).ToString();
        }
        public static int[] SortNumbers(int[] nums) => nums == null ? new int[0] : nums.OrderBy(z => z).ToArray();
        public static string CountSheep(int n) => string.Concat(Enumerable.Range(1, n).Select(i => $"{i} sheep..."));
        public static bool ValidatePin(string pin)
        {
            string _regexPattern = "(^[0-9]{1}[0-9]{3})$|(^[0-9]{1}[0-9]{5})$";
            return Regex.IsMatch(pin, _regexPattern, RegexOptions.None);
        }
        public static string Problem(String a) => double.TryParse(a, out var _auxResult) ? (_auxResult * 50 + 6).ToString() : "Error";
        public static bool XO(string input) => input.ToLowerInvariant().Count(z => z.Equals('x')) == input.ToLowerInvariant().Count(z => z.Equals('o'));
        public static string RemoveUrlAnchor(string url) => url.Substring(0, url.IndexOf("#") < 0 ? url.Length : url.IndexOf("#"));
        public static int GetRealFloor(int n) => n <= 0 ? n : (n < 13 ? n - 1 : n - 2);
        public static long[] Digitize(long n) => n.ToString().Reverse().Select(z => long.Parse(z.ToString())).ToArray();
        public static bool IsAnagram(string test, string original)
        {
            return string.Concat(original.ToLower().OrderBy(z => z)) == string.Concat(test.ToLower().OrderBy(z => z));
            // return test.All(z => original.Contains(z));
        }
        public static int SumPositivesv2(int[] numbers)
        {
            if (numbers.Length < 3 || numbers.Equals(null) || numbers is null || numbers == null) return 0;
            int _aux = numbers.Sum();
            _aux -= (numbers.Min() + numbers.Max());
            return _aux;
        }
        public static int Summation(int num) => Enumerable.Range(1, num).Sum();
        public static string Extract(int[] args)
        {
            string _auxReturn = string.Empty;
            int _nextPosition = 0;
            int _auxi = 0;
            bool _getOut = false;
            _auxReturn += $"{args[0]}";
            for (int i = 0; i < args.Length; i++)
            {
                while (!_getOut || _auxi < args.Length)
                {
                    if (args[i + 1].Equals(args[i] + 1))
                    {
                        _auxReturn += $",{args[i + 1]}";
                        _getOut = true;
                    }
                }
            }
            return _auxReturn;
        }
        public static string Rps(string p1, string p2)
        {
            if (p1.Equals(p2)) return "Draw!";
            if (
                (p1.Equals("scissors") && p2.Equals("paper"))
                || (p1.Equals("paper") && p2.Equals("rock"))
                || (p1.Equals("rock") && p2.Equals("scissors"))
            )
                return "Player 1 won!";
            else
                return "Player 2 won!";
        }
        public static int Move(int position, int roll)
        {
            return (roll * 2) + position;
        }
        public static int StrCount(string str, string letter) => str.Count(z => char.Parse(letter) == z);
        public static int SumMix(object[] x) => x.Sum(z => Convert.ToInt32(z));
        public static bool Check(object[] a, object x) => a.Any(z => z.Equals(x));
        public static int Min(int[] list) => list.Min();
        public static int Max(int[] list) => list.Max();
        public static string HighAndLow(string numbers)
        {
            var _query = numbers.Split(' ').Select(z => int.Parse(z));
            return new string(_query.Max() + " " + _query.Min());
        }
        public static bool IsIsogram(string str) => new string(str.ToLower().Distinct().ToArray()).Equals(str.ToLower()) ? true : false;
        public static string Disemvowel(string str) => string.Concat(str.Where(z => !"aeiouAEIOU".Contains(z)));
        public static string Remove_char(string s)
        {
            return s.Substring(1, (s.Length - 2));

            // return s.Remove(s.Length - 1, 1).Remove(0, 1);

            // if (s.Length < 2) return s;
            // s = s.Remove(0, 1);
            // return s.Remove(s.Length - 1, 1);
        }
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            var years = 0;
            while (principal < desiredPrincipal)
            {
                principal += principal * interest * (1 - tax);
                years++;
            }
            return years;

            // if (principal == desiredPrincipal) return 0;
            // int _years = 0;
            // double _interest = 0;
            // double _desiredPrincipal = principal ;
            // double _tax = 0;
            // while (_desiredPrincipal < desiredPrincipal)
            // {
            //     _interest=_desiredPrincipal*interest;
            //     _tax=_interest-(tax*_interest);
            //     _desiredPrincipal=_desiredPrincipal+_tax;
            //     _years++;
            // }
            // return _years;
        }
        public static int FindShort(string s)
        {
            return s.Split(' ').Min(x => x.Length);
            // return s.Split(' ').Select(z=>z.Length).Min();
        }
        public static double basicOp(char operation, double value1, double value2)
        {
            return operation.Equals('+') ? value1 + value2 : operation.Equals('-') ? value1 - value2 : operation.Equals('*') ? value1 * value2 : value1 / value2;
        }
        public static string ToAlternatingCase(this string s)
        {
            return string.Join("", s.Select(z => char.IsUpper(z) ? char.ToLower(z) : char.ToUpper(z)));
        }
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            return data.Select(z => z[0] > 54 && z[1] > 7 ? "Senior" : "Open");
            // List<string> _status = new List<string>();
            // for (int i = 0; i < data.Length; i++)
            // {
            //         if (data[i][0] > 54 && data[i][1] > 7)
            //         {
            //             _status.Add("Senior");
            //         }
            //         else
            //             _status.Add("Open");
            // }
            // return _status;
        }
        public static int Stray(int[] numbers)
        {
            return numbers.First(x => numbers.Count(i => i == x) == 1);
            //  var result = numbers.GroupBy(z => z).Select(itemGroup => new { Item = itemGroup.Key, Count = itemGroup.Count() })
            //             .OrderByDescending(Item => Item.Count).ThenBy(Item => Item);
            //             Console.WriteLine("{0} {1}\r\n{2} {3}", result.First().Item, result.First().Count, result.Last().Item, result.Last().Count);
            //             return result.Last().Item;
        }
        public static int Past(int h, int m, int s)
        {
            //if(h!=0&&m!=0)
            // return (h != 0 ? h * 60 : 1) * 
            DateTime _d = new DateTime(1, 1, 1, h, m, s);
            int _millisecondPerSecond = 1000;
            int _auxSecond = _d.Second * _millisecondPerSecond;
            int _auxMinute = _d.Minute * _millisecondPerSecond * 60;
            int _auxHour = _auxMinute * 60;
            return _auxHour + _auxMinute + _auxSecond;
            //    return (m != 0 ? m * 60 : 1) * ((s != 0 ? s * 1000 : 1));
        }
        public static Dictionary<char, int> CountToDictionary(string str) => str.GroupBy(z => z).ToDictionary(z => z.Key, z => z.Count());
        public static string UpdateLight(string current) => current.Equals("green") ? "yellow" : current.Equals("yellow") ? "red" : "green";//current.Equals("red") ? "green" : "";
        public static string DoubleChar(string s) => string.Join("", s.Select(z => $"{z}{z}"));//.Aggregate((_c, _index) => _c)
        public static char GetGrade(int s1, int s2, int s3)
        {
            var m = (s1 + s2 + s3) / 3.0;
            return m >= 90 ? 'A' : m >= 80 ? 'B' : m >= 70 ? 'C' : m >= 60 ? 'D' : 'F';
        }
        public static int Persistence(long n)
        {
            long nF = n.ToString().Aggregate(1, (a, b) => a * (b - '0'));
            return n < 9 ? 0 : 1 + Persistence(nF);
            // return n < 10 ? 0 : 1 + Persistence($"{n}".Aggregate(1, (a, b) => a * (b - 48)));
            // if (n.ToString().Length.Equals(1))
            // {
            //     return 0;
            // }
            // string _auxStringN = n.ToString();
            // int _auxN = 1;
            // int _persistence = 0;
            // while (_auxStringN.Length != 1)
            // {
            //     // _auxN =_auxStringN.OrderBy(z=>z).Select((_number,_index)=>_number).SingleOrDefault();
            //     for (int i = 0; i < _auxStringN.Length; i++)
            //     {
            //         _auxN *= int.Parse(_auxStringN[i].ToString());
            //     }
            //     _auxStringN = _auxN.ToString();
            //     _persistence++;
            //     _auxN=1;
            // }
            // return _persistence;
        }
        public static int Litres(double time)
        {
            return Convert.ToInt32((Math.Round((time * 0.5), 0, MidpointRounding.ToZero)));
        }
        public static string High(string s)
        {
            return s.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();

            // =>  s.Split(' ').OrderBy(w => w.Sum(c => c - 'a' + 1)).Last();

            // int _auxSum = 0;
            // int _auxMax = 0;
            // string _auxWord = string.Empty;
            // foreach (var item in s.Split(' '))
            // {
            //     _auxSum = item.Sum(z => "abcdefghijklmnopqrstuvwxyz".IndexOf(z) + 1);
            //     if (_auxMax < _auxSum)
            //     {
            //         _auxMax = _auxSum;
            //         _auxWord = item;
            //     }
            // }
            // return _auxWord;
        }
        public static string RepeatStr(int n, string s)
        {
            return string.Join("", Enumerable.Repeat(s, n));

            // Console.WriteLine($"n {n}\ns {s}");
            // if (n==0)return string.Empty;
            // string _auxS = s;
            // for (int i = 0; i < n-1; i++)
            //         _auxS+=s;
            // return _auxS;
        }
        public static int GetVowelCount(string str)
        {
            // return str.Count(i => "aeiou".Contains(i));
            return str.Count(z => z.Equals('a') || z.Equals('e') || z.Equals('i') || z.Equals('o') || z.Equals('u'));
        }
        public static String Accum(string s)
        {
            return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));

            // string _auxString = string.Empty;
            //         var _array = s.Split('-', StringSplitOptions.TrimEntries);
            //         int _auxCount = 1;
            //         for (int i = 0; i < s.Length; i++)
            //         {
            //             for (int j = 0; j < _auxCount; j++)
            //             {
            //                 _auxString += j == 0 ? s[i].ToString().ToUpperInvariant() : s[i].ToString().ToLowerInvariant();
            //             }
            //             _auxCount++;
            //             _auxString += i == s.Length - 1 ? "" : "-";
            //         }
            //         return _auxString;
        }
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            listOfItems.ForEach(z => Console.WriteLine(z));
            IEnumerable<int> _aux = listOfItems.OfType<int>().Select(z => z);
            // foreach (var item in _aux)
            // {
            //     Console.WriteLine($"-{item}");
            // }
            _aux.ToList().ForEach(z => Console.WriteLine(z));

            return _aux;
        }
        public static string AreYouPlayingBanjo(string name)
        {
            return name.ToLower()[0] == 'r' ? name + " plays banjo" : name + " does not play banjo";
            /*
                        if (name.First().Equals('r') || name.First().Equals('R'))
                            return $"{name} plays banjo";
                        return $"{name} does not play banjo";
            */
        }
        public static int TotalPoints(string[] games)
        {
            return games.Sum(s => s[0] < s[2] ? 0 : s[0] == s[2] ? 1 : 3);
            /*
             int total = 0;
    foreach (string game in games) {
      if (game[0] > game[2])
        total += 3;
      else if (game[0] == game[2])
        total += 1;            
    }
    return total;
    */
            /*
                        int _auxTotal = 0;
                        int _win = 3;
                        int _draw = 1;

                        for (int i = 0; i < games.Length; i++)
                        {
                            int.TryParse(games[i].Split(':').First(), out var _auxTeam1TotalGoals);
                            int.TryParse(games[i].Split(':').ElementAt(1), out var _auxTeam2TotalGoals);
                            if (_auxTeam1TotalGoals > _auxTeam2TotalGoals) _auxTotal += _win;
                            if (_auxTeam1TotalGoals.Equals(_auxTeam2TotalGoals)) _auxTotal += _draw;
                        }
                        return _auxTotal;
                        */
        }
        public static int SumPositivesv1(int[] numbers)
        {
            if (numbers.Length.Equals(0) || numbers.Length.Equals(1) || numbers.Equals(null)) return -1;
            List<int> _auxList = numbers.ToList();
            _auxList.Remove(_auxList.Min());
            _auxList.Remove(_auxList.Max());
            return _auxList.Sum();
        }
        public static string[] SplitStrings(string str)
        {
            if (str.Length % 2 != 0) str += "_";
            return Enumerable.Range(0, str.Length).Where(x => x % 2 == 0).Select(x => str.Substring(x, 2)).ToArray();
        }
        public static int PositiveSum(int[] arr)
        {
            return arr.Sum(c => (c < 0 ? 0 : c));
            //return arr.Where(z=>z>0).Sum();
        }
        public static int SumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(i => i).Take(2).Sum();

            /*      
                  var _list=numbers.ToList();
                  int _n1 =_list.Min();
                  _list.Remove(_n1);
                  return _n1+_list.Min();
          */
        }
        public static int DigitalRoot(long n)
        {
            while (n > 9)
            {
                n = n.ToString().Select(c => Convert.ToInt32(c.ToString())).Sum();
            }
            return (int)n;
        }
        public static string DuplicateEncode(string word)
        {
            return string.Join("", word.ToLower().Select(z => word.Count(x => z == x) > 1 ? ")" : "("));
        }
        public static string ToWeirdCase(string s)
        {
            return string.Join(" ", s.Split(' ').Select(w => string.Concat(w.Select((ch, i) => i % 2 == 0 ? char.ToUpper(ch) : char.ToLower(ch)
     ))));
            /*
                        Console.WriteLine($"s {s}");
                        if (s.Equals(string.Empty)) return new string(' ', s.Length);
                        string[] _aux = s.Split(' ');
                        string _auxString = "";
                        foreach (var item in _aux)
                        {
                            bool _isDivisibleBy2 = item.Length % 2 == 0;
                            int _auxLength = item.Length;
                            for (int i = 0; i < _auxLength; i++)
                            {
                                Console.WriteLine($"item[i]: {item[i]}");
                                if (char.IsWhiteSpace(item[i])) _auxString += " ";
                                else
                                {
                                    bool _auxInt = i % 2 == 0;
                                    if (_auxInt)
                                        _auxString += $"{char.ToUpper(item[i])}";
                                    else
                                        _auxString += $"{char.ToLower(item[i])}";
                                }
                            }
                            _auxString += " ";
                        }
                        return _auxString.TrimEnd(' ');
                        */
        }
        ///Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
        public static int DuplicateCount(string str)
        =>

            str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);

        // str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();

        //  (from z in str.ToUpperInvariant()
        //                 group z by z
        //                 into x
        //                 where x.Count()>1
        //                 select x.Key)
        //             .Count();
        public static string ReverseWords(string str)
        {
            return string.Join(' ', str.Split(' ').Select(z => new string(z.Reverse().ToArray())));
            /*
            var _aux1 = str.Split(' ');
            string _return = string.Empty;
            for (int i = 0; i < _aux1.Length; i++){

                var _q = _aux1[i].AsEnumerable().Reverse();
                _return+=$"{string.Join(' ',new string(_q.ToArray()))}";
                if(!i.Equals(_aux1.Length-1)) _return+=' ';
            }
            return _return;
            */
        }
        public static bool StringEndsWith(string str, string ending)
        {
            //best practices
            return str.EndsWith(ending);
            /*
                        // TODO: complete
                        int _endingLength = ending.Length;
                        int _diffLength = str.Length - _endingLength;
                        var _q = new string(str.Skip(_diffLength).ToArray());
                        if (!ending.Equals(_q)) return false;
                            Console.WriteLine($"_endingLength: {_endingLength}");
                            Console.WriteLine($"str.Length- _endingLength: {str.Length- _endingLength}\n_q {_q}\nending {ending}");
                        return true;
                        */
        }
        public static string[] SplitString(string str)
        {
            // return Regex.Matches(str + "_", @"\w{2}").Select(x => x.Value).ToArray();

            if (str.Length % 2 != 0)
                str += "_";
            return Enumerable.Range(0, str.Length)
              .Where(x => x % 2 == 0)
              .Select(x => str.Substring(x, 2))
              .ToArray();

            /*
                        if (str.Length % 2 == 1)
                            str += "_";

                        List<string> list = new List<string>();
                        for (int i = 0; i < str.Length; i += 2)
                        {
                            list.Add(str[i].ToString() + str[i + 1]);
                        }

                        return list.ToArray();
                        */

            /*
                        bool _auxBool = str.Length % 2 == 0;
                        string _auxString = string.Empty;
                        List<string> _auxList = new List<string>();
                        int _auxCounter = 0;
                        int _byPass = 2;
                        if (_auxBool)
                        {
                            Console.WriteLine("->1");
                            for (int i = 0; i < str.Length; i = i + _byPass)
                            {
                                _auxList.Add(str.Substring(_auxCounter, _byPass));
                                _auxCounter += _byPass;
                            }
                        }
                        else
                        {
                            Console.WriteLine("->2");
                            for (int i = 0; i < str.Length; i = i + _byPass)
                            {
                                if (_auxCounter < str.Length - 1)
                                {
                                    Console.WriteLine("->3");
                                    _auxList.Add(str.Substring(_auxCounter, _byPass));
                                }
                                else
                                {
                                    Console.WriteLine("->4");
                                    Console.WriteLine($"_auxCounter {_auxCounter}");
                                    _auxList.Add($"{str.Substring(_auxCounter)}_");
                                }
                                _auxCounter += _byPass;
                            }
                        }
                        return _auxList.ToArray();
                        */
        }
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            double _auxCount = p0;
            int _auxCountInteger = 0;
            double _auxPercentage = percent * 0.01;
            while (_auxCount < p)
            {
                _auxCount = Math.Round(_auxCount + _auxCount * _auxPercentage + aug, 0);
                _auxCountInteger++;
            }
            return _auxCountInteger;
        }
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Where(z => z.Equals(true)).Count();

            int _count = 0;
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i].Equals(true))
                    _count++;
            }
            return _count;
        }
        public static int Divisors(int n)
        {
            return Enumerable.Range(1, n).Where(t => n % t == 0).Count();

            // if (n == 1) return 1;
            // int _count = 0;
            // for (int i = 1; i <= n; i++)
            // {
            //     if (n % i == 0)
            //         _count++;
            // }
            // return _count;
        }
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            Console.WriteLine("test");
            var _auxA = a.OrderBy(z => z);
            var _auxB = b.OrderBy(x => x);
            List<int> _auxList = new List<int>();
            if (_auxA.Count() >= _auxB.Count())
            {
                for (int i = 0; i < _auxA.Count(); i++)
                {
                    if (!_auxB.Contains(_auxA.ElementAt(i)))
                        _auxList.Add(_auxA.ElementAt(i));
                }
            }
            else
            {
                for (int i = 0; i < _auxA.Count(); i++)
                {
                    if (!_auxA.Contains(_auxB.ElementAt(i)))
                        _auxList.Add(_auxA.ElementAt(i));
                }
            }
            return _auxList.ToArray();
        }
        public static string BigNumbersAdd(string a, string b)
        {
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString(); // Fix this!

            //     if(BigInteger.TryParse(a,out BigInteger _a) && BigInteger.TryParse(b,out BigInteger _b))
            //     return ( _a + _b).ToString(); // Fix this!
            // else return "error";
        }
        public static string AlphabetPosition1(string text)
        {
            return string.Join(" ", text.ToLowerInvariant()
                                                  .Where(char.IsLetter)
                                                  .Select(z => "abcdefghijklmnopqrstuvwxyz".IndexOf(z) + 1)
                                                  .ToArray());

            //return string.Join(" ",text.ToLowerInvariant().Where(char.IsLetter).Select(z => z-'a'+1 ));
            // z-'a'  return integer that is the subtraction result of letter position with a letter position
            //+1 (it's a zero based index)
        }
        public static bool IsPerfectSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }
        public static string OrderWords(string words)
        {//todo 1 - split string  2 - Find number in string  3 - create new ordered string
         //   if (string.IsNullOrEmpty(words)) return words;
         // return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));

            return string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsDigit)));

            /*
            if (words.Equals(string.Empty))
            {
                return string.Empty;
            }
            string[] _auxWordsArray = words.Split(' ');
            Dictionary<string, int> _dic = new Dictionary<string, int>();
            foreach (var item in _auxWordsArray)
            {
                Console.WriteLine(item);
                _dic.Add(item, item.Where(z => char.IsDigit(z)).Select(z => z).Single());
            }
            string _auxReturnString = string.Empty;
            var _auxDic = (from z in _dic orderby z.Value ascending select z).ToDictionary(z=>z.Key,z=>z.Value);
            _auxReturnString = string.Join(' ', _auxDic.Keys);
            Console.WriteLine(_auxReturnString);
            return _auxReturnString;
            */
        }
        public static string AlphabetPosition(string text)
        {//best practice
            return string.Join(" ", text.ToLower()
                                        .Where(l => char.IsLetter(l))
                                        .Select(l => (int)(l - 'a' + 1)));
            /*
                         return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
                            return string.Join(" ", text.Where(char.IsLetter).Select(c => c & 31));

                            my solution
                                    Dictionary<char, int> _dic = new Dictionary<char, int>();
                                    _dic.Add('a', 1);
                                    _dic.Add('b', 2);
                                    _dic.Add('c', 3);
                                    _dic.Add('d', 4);
                                    _dic.Add('e', 5);
                                    _dic.Add('f', 6);
                                    _dic.Add('g', 7);
                                    _dic.Add('h', 8);
                                    _dic.Add('i', 9);
                                    _dic.Add('j', 10);
                                    _dic.Add('k', 11);
                                    _dic.Add('l', 12);
                                    _dic.Add('m', 13);
                                    _dic.Add('n', 14);
                                    _dic.Add('o', 15);
                                    _dic.Add('p', 16);
                                    _dic.Add('q', 17);
                                    _dic.Add('r', 18);
                                    _dic.Add('s', 19);
                                    _dic.Add('t', 20);
                                    _dic.Add('u', 21);
                                    _dic.Add('v', 22);
                                    _dic.Add('w', 23);
                                    _dic.Add('x', 24);
                                    _dic.Add('y', 25);
                                    _dic.Add('z', 26);
                                    return string.Join(" ", text.Where(z => char.IsLetter(z)).Select(z => _dic[char.Parse(z.ToString().ToLower())].ToString()).ToArray());
                                */
        }
        public static bool IsPangram(string str)
        {
            // return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
            // return "abcdefghijklmnopqrstuvwxyz".All(x => str.ToLower().Contains(char.ToLower(x)));
            return str.ToUpper().Where(char.IsLetter).Distinct().Count() == 26;

        }
        /*
                public static bool IsPangram(string str)
                {
                    string _alphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z 0 1 2 3 4 5 6 7 8 9";
                    var _auxArray = _alphabet.Split(' ');
                    Dictionary<char,bool> _dic=new Dictionary<char, bool>();
                    foreach (var item in _auxArray)
                    {
                        _dic.Add(char.Parse(item),false);
                    }
                    Regex _regex = new Regex("[^a-zA-Z0-9]");
                    string _str = _regex.Replace(str, "");
                    _str = _str.ToLower();
                    StringBuilder _sb = new StringBuilder();
                    foreach (var item in _str)
                    {
                        if (!Char.IsPunctuation(item)||Char.IsWhiteSpace(item))
                        {
                            _sb.Append(item);
                        }
                    }
                    string _aq = new string(_str.Where(z => Char.IsPunctuation(z)).ToArray());
                    // return _auxArray.Any(_str.Contains);

                    foreach (var item in _sb.ToString().ToArray())
                    {
                        Console.WriteLine(item);
                        if (_auxArray.Any(z => item.ToString().Contains(z)))
                        {
                            _dic[item]= true;
                        }
                    }
                    return _dic.ContainsValue(false);
                }
                */
        /*
        Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

        if(numbers.Length==0)
        return -1;
    int _max=0;
       for (int i=0;i<numbers.Length;i++){
       if(_max<numbers[i])
       _max=numbers[i];
       }
       return _max;
        */
        public static int[] MoveZeroes(int[] arr)
        {

            if (arr.Length == 0) return arr;
            int[] _array = new int[] { };

            List<int> _listIntegers = new List<int>();
            _listIntegers = arr.ToList();
            for (int i = 0; i < arr.Length; i++)
            {
                if (_listIntegers.ElementAt(i).Equals(0))
                {
                    _listIntegers.RemoveAt(i);
                    _listIntegers.Add(0);
                }
                //questions  review  : 6,8,9
            }
            Console.WriteLine(_listIntegers.Max(z => z.ToString()));
            return _listIntegers.ToArray();
        }

        /*In mathematics, the factorial of integer n is written as n!. It is equal to the product of n and every integer preceding it. For example: 5! = 1 x 2 x 3 x 4 x 5 = 120

    Your mission is simple: write a function that takes an integer n and returns the value of n!.

    You are guaranteed an integer argument. For any values outside the non-negative range, return null, nil or None (return an empty string "" in C and C++). For non-negative numbers a full length number is expected for example, return 25! =  "15511210043330985984000000"  as a string.

    For more on factorials, see http://en.wikipedia.org/wiki/Factorial

    NOTES:

    The use of BigInteger or BigNumber functions has been disabled, this requires a complex solution

    I have removed the use of require in the javascript language.

    */
        public static string Factorial(int n)
        {
            int factorial = n;
            if (n == 0) return 1.ToString();
            if (n < 0) return string.Empty;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial.ToString();
        }
        /*
        How can you tell an extrovert from an introvert at NSA? Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.

    I found this joke on USENET, but the punchline is scrambled. Maybe you can decipher it? According to Wikipedia, ROT13 (http://en.wikipedia.org/wiki/ROT13) is frequently used to obfuscate jokes on USENET.

    Hint: For this task you're only supposed to substitue characters. Not spaces, punctuation, numbers etc.
    */

        ///best practice2
        //   public static string Rot13(string input)
        //   {
        //      var s1 = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
        //      var s2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        //      return string.Join("", input.Select(x => char.IsLetter(x)?s1[s2.IndexOf(x)]:x));
        //   }

        ///best practice1
        public static string Rot13(string input)
        {
            return string.Concat("", input.Select(z => char.IsLetter(z) ? (char)(z + (char.ToLower(z) > 'm' ? -13 : 13)) : z));
            //   return  Regex.Replace(input, "[a-zA-Z]", new MatchEvaluator(z => ((char)(z.Value[0] + (Char.ToLower(z.Value[0]) >= 'n' ? -13 : 13))).ToString()));
        }
        ///Complete the function/method so that it takes a PascalCase string and returns the string in snake_case notation. Lowercase characters can be numbers. If the method gets a number as input, it should return a string.
        public static string ToUnderscore(int str) => str.ToString();
        // public static string ToUnderscore(int str)
        // {
        //      string _return = string.Empty;
        //      string _auxStr=str.ToString();
        //     try
        //     {
        //         string _auxReturn = string.Empty;
        //         for (int i = 0; i < _auxStr.Length; i++)
        //         {
        //             if (Char.IsLetterOrDigit(_auxStr[i]))
        //             {
        //                 if (Char.IsUpper(_auxStr[i]))
        //                 {
        //                     if (i == 0)
        //                     {
        //                         _auxReturn += _auxStr[i].ToString().ToLower();
        //                     }
        //                     else
        //                     {
        //                         _auxReturn += '_'+_auxStr[i].ToString().ToLower() ;
        //                     }
        //                 }
        //                 else{_auxReturn+=_auxStr[i];}
        //             }
        //         }
        //         _return = _auxReturn;    
        //     }
        //     catch (NotImplementedException e)
        //     {
        //         Console.WriteLine($"Error: {e.ToString()}");
        //     }
        //     catch (System.Exception e)
        //     {
        //         Console.WriteLine($"Error: {e.ToString()}");
        //     }
        //     return _return;
        // }

        ///Complete the function/method so that it takes a PascalCase string and returns the string in snake_case notation. Lowercase characters can be numbers. If the method gets a number as input, it should return a string.
        public static string ToUnderscore(string str) => string.Join("_", Regex.Split(str, "(?=[A-Z])").Skip(1)).ToLower();
        // public static string ToUnderscore(string str)
        // {
        //     string _return = string.Empty;
        //     try
        //     {
        //         string _auxReturn = string.Empty;
        //         for (int i = 0; i < str.Length; i++)
        //         {
        //             if (Char.IsLetterOrDigit(str[i]))
        //             {
        //                 if (Char.IsUpper(str[i]))
        //                 {
        //                     if (i == 0)
        //                     {
        //                         _auxReturn += str[i].ToString().ToLower();
        //                     }
        //                     else
        //                     {
        //                         _auxReturn += '_'+str[i].ToString().ToLower() ;
        //                     }
        //                 }
        //                 else{_auxReturn+=str[i];}
        //             }
        //         }
        //         _return = _auxReturn;    
        //     }
        //     catch (NotImplementedException e)
        //     {
        //         Console.WriteLine($"Error: {e.ToString()}");
        //     }
        //     catch (System.Exception e)
        //     {
        //         Console.WriteLine($"Error: {e.ToString()}");
        //     }
        //     return _return;
        // }
    }
    public static class SimpleAssembler
    {
        public static Dictionary<string, int> DictionaryAdd(Dictionary<string, int> returnDic, string variable, int value, bool isToAdd)
        {
            if (isToAdd)
            {
                returnDic.Add(variable, value);
            }
            else
            {
                returnDic[variable] = value;
            }
            return returnDic;
        }
        /// todo 1- get operation and value | 2- execute operation in varible | 3-add var and value to dict
        public static Dictionary<string, int> Interpret(string[] program)
        {
            int _auxValue = 1;
            int _minOperationPostion = 0;
            int _lengthOperationPostion = 3;
            char _auxVar;
            string _auxOperation = string.Empty;
            string _aux = string.Empty;
            string[] _operations = new string[] { "mov", "inc", "dec", "jnz" };
            const int _varPosition = 4;
            const int _valuePosition = 6;
            Dictionary<string, int> _returnDic = new Dictionary<string, int>();
            foreach (var item in program)
            {
                _auxOperation = item.Substring(_minOperationPostion, _lengthOperationPostion);
                _auxVar = item[_varPosition];
                if (!_auxOperation.Equals(_operations[1]) && !_auxOperation.Equals(_operations[2]))
                {
                    _aux = item[_valuePosition].ToString();
                    if (_returnDic.ContainsKey(_aux))
                        _auxValue = _returnDic[_aux];
                    else
                        _auxValue = int.Parse(item.Substring(_valuePosition, item.Length - _valuePosition));
                }
                if (_auxOperation.Equals(_operations[0]))
                {
                    _returnDic.Add(_auxVar.ToString(), _auxValue);
                }
                if (_auxOperation.Equals(_operations[1]))
                {
                    _auxValue++;
                }
                if (_auxOperation.Equals(_operations[2]))
                {
                    _auxValue--;
                }
                if (_auxOperation.Equals(_operations[3]))
                {
                    if (!_returnDic[_auxVar.ToString()].Equals(0))
                        _returnDic[_auxVar.ToString()] = _auxValue;
                }

                try
                {
                    if (!_returnDic.ContainsKey(_auxVar.ToString()))
                    {
                        _returnDic.Add(_auxVar.ToString(), _auxValue);
                    }
                    else
                    {
                        _returnDic[_auxVar.ToString()] = _auxValue;
                    }
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("Exception: " + e.ToString());
                }
            }
            return _returnDic;
        }
    }
    public class CountIPAddresses
    {
        public static long IpsBetween(string start, string end)
        {
            int _returnTotalCount = -1;
            IPAddress _IPStart;
            IPAddress _IPEnd;
            if (IPAddress.TryParse(start, out _IPStart) && IPAddress.TryParse(end, out _IPEnd))
            {
                var _auxIntIpEnd = BitConverter.ToInt32(_IPEnd.GetAddressBytes().Reverse().ToArray(), 0);
                var _auxIntIpStart = BitConverter.ToInt32(_IPStart.GetAddressBytes().Reverse().ToArray(), 0);
                if (_auxIntIpEnd < _auxIntIpStart)
                    _returnTotalCount = _auxIntIpStart - _auxIntIpEnd;
                else
                    _returnTotalCount = _auxIntIpEnd - _auxIntIpStart;
            }
            return _returnTotalCount;
        }
        ///auxiliar method
        //logic  is to know the difference( subtract) the class D IP from 2 IP's
        public static long IpsBetween(string start, string end, bool token)
        {
            long _returnTotalCount = -1;

            IPAddress _IPStart;
            IPAddress _IPEnd;

            //TODO | 1- get last digits(class D of IP) | 2 - validate IPstart it's bigger than IPend
            if (IPAddress.TryParse(start, out _IPStart) && IPAddress.TryParse(end, out _IPEnd))
            {
                var _enumerableEnd = _IPEnd.ToString().Split('.');
                var _enumerableStart = _IPStart.ToString().Split('.');
                int _auxEnd = 0;
                int _auxStart = 0;
                try
                {
                    if (Int32.TryParse(_enumerableEnd[3], out _auxEnd) && Int32.TryParse(_enumerableStart[3], out _auxStart))//it's in the position 3 where is located the Class D IP
                    {
                        if (_auxStart > _auxEnd)
                        {
                            _returnTotalCount = _auxStart - _auxEnd;
                        }
                        else
                            _returnTotalCount = _auxEnd - _auxStart;
                    }
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("Convertion error of Class D IP: " + e.ToString());
                }
            }
            return _returnTotalCount;
        }
    }
    public class RomanNumerals
    {
        ///todo | 1- get total digits length | 2 - 
        public static string ToRoman(int n)
        {
            int _auxLength = n.ToString().Length;
            int _digit = 0;
            int _auxItem = 0;
            string _auxConvert = string.Empty;
            string _return = string.Empty;

            foreach (var item in n.ToString())
            {
                Console.WriteLine($"item: {item}");

                _auxItem = int.Parse(item.ToString());
                _digit = n.ToString()[0];
                if (_auxLength == 4)
                {
                    while (_auxItem != 0)
                    {
                        _return += 'M';
                        _auxItem--;
                    }
                    Console.WriteLine($"M: {_return}");
                }
                if (_auxLength == 3)
                {
                    while (_auxItem != 0)
                    {
                        _return += 'C';
                        _auxItem--;
                    }
                    Console.WriteLine($"C: {_return}");
                }
                if (_auxLength == 2)
                {
                    _auxConvert = ConvertBasicRoman(int.Parse(item.ToString()));
                    _return += _auxConvert;
                }
                if (_auxLength == 1)
                {
                    _auxConvert = ConvertBasicRoman(int.Parse(item.ToString()));
                    _return += _auxConvert;
                    Console.WriteLine($"basic : {_return}");
                }
                _auxLength--;
            }
            Console.WriteLine($"_return: {_return}");
            return _return;
        }
        static string ConvertBasicRoman(int n)
        {
            string _return = "";
            if (n.Equals(1)) _return = "I";
            if (n.Equals(2)) _return = "II";
            if (n.Equals(3)) _return = "III";
            if (n.Equals(4)) _return = "IV";
            if (n.Equals(5)) _return = "V";
            if (n.Equals(6)) _return = "VI";
            if (n.Equals(7)) _return = "VII";
            if (n.Equals(8)) _return = "VIII";
            if (n.Equals(9)) _return = "IX";
            if (n.Equals(10)) _return = "X";
            return _return;
        }
        static int ConvertBasicRoman(string romanNumeral)
        {
            int _return = -1;
            if (romanNumeral.Equals("I")) _return = 1;
            if (romanNumeral.Equals("II")) _return = 2;
            if (romanNumeral.Equals("III")) _return = 3;
            if (romanNumeral.Equals("IV")) _return = 4;
            if (romanNumeral.Equals("V")) _return = 5;
            if (romanNumeral.Equals("VI")) _return = 6;
            if (romanNumeral.Equals("VII")) _return = 7;
            if (romanNumeral.Equals("VIII")) _return = 8;
            if (romanNumeral.Equals("IX")) _return = 9;
            if (romanNumeral.Equals("X")) _return = 10;
            return _return;
        }
        public static int FromRoman(string romanNumeral)
        {
            string? _auxString = null;
            string _auxToUpper = romanNumeral.ToUpperInvariant();
            int _return = 0;
            int _auxConvertBasicRoman = ConvertBasicRoman(romanNumeral);
            if (_auxConvertBasicRoman != -1) return _auxConvertBasicRoman;

            foreach (var item in romanNumeral)
            {
                switch (item)
                {
                    case 'L':
                        _auxString += 50;
                        break;

                    case 'C':
                        _auxString += 100;
                        break;

                    case 'D':
                        _auxString += 500;
                        break;

                    case 'M':
                        _auxString += 1000;
                        break;

                    default:

                        ;
                        break;
                }
            }
            var _q = (from z in romanNumeral select z);
            return _return;
        }
    }
    public class PyramidSlideDown
    {
        //Todo | 1- search the elementary iterate in every tree node | 2- per level edentify , the max and min | 3 - sum teh max level to a total var 
        public static int LongestSlideDown(int[][] pyramid)
        {
            int _totalReturn = 0;
            int _max = 0;
            List<int> _auxList;
            for (int i = 0; i < pyramid.GetLength(0); i++)//iterate in rows 
            {
                Console.WriteLine($"pyramid.GetLength(0):  {pyramid.GetLength(0)}");
                _auxList = pyramid[i].ToList();
                Console.WriteLine($"pyramid.GetLength(0):  {pyramid.GetLength(1)}");
                foreach (var item in _auxList)
                {
                    if (_max < item)
                    {
                        _max = item;
                    }
                    Console.WriteLine($"max:  {_max}");
                }
                _totalReturn += _max;
            }
            Console.WriteLine($"mas:  {_totalReturn}");
            return _totalReturn;
        }
    }

    class Program
    {
        public static int Add(int pOne, int pTwo) => (pOne + pTwo);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OperatingSystem _os = Environment.OSVersion;
            Console.WriteLine(_os.Platform + Environment.NewLine + _os.ServicePack + Environment.NewLine + _os.Version);
            // /home/telmosantos/.dotnet/
        }
    }
}
