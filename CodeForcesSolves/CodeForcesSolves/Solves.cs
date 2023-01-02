using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeForcesSolves
{
    public class Solves
    {

        public void cf1030A()
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            int[] num = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                num[i] = Convert.ToInt32(nums[i]);
            }
            foreach (var i in num)
            {
                if (i == 1) count++;
            }

            if (count == 0)
            {
                Console.WriteLine("EASY");
            }
            else
            {
                Console.WriteLine("HARD");
            }
        }
        public void cf110A()
        {
            string n = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '4' || n[i] == '7')
                {
                    count++;
                }
            }
            if (count == 4 || count == 7)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        public void cf112A()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            if (str1 == str2)
            {

                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] < str2[i])
                    {
                        Console.WriteLine("-1");
                        break;
                    }
                    else if (str1[i] > str2[i])
                    {
                        Console.WriteLine("1");
                        break;
                    }
                }
            }
        }
        public void cf1141A()
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int m = int.Parse(nums[1]);
            int ans = 0;

            if (n == m)
            {
                Console.WriteLine(0);
            }

            else if (m % n != 0) Console.WriteLine(-1);
            else
            {
                int d = m / n;
                while (d % 2 == 0)
                {
                    d /= 2;
                    ans++;
                }
                while (d % 3 == 0)
                {
                    d /= 3;
                    ans++;
                }
                if (d != 1) ans = -1;
                Console.WriteLine(ans);
            }
        }
        public void cf1154A()
        {
            string[] nums = Console.ReadLine().Split();
            int[] num = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                num[i] = int.Parse(nums[i]);
            }

            Array.Sort(num);
            int c = num[3] - num[0];
            int a = num[1] - c;
            int b = num[2] - c;
            Console.WriteLine(a + " " + b + " " + c);
        }
        public void cf116A()
        {
            int n = int.Parse(Console.ReadLine());
            int temp = 0, a = 0, b = 0;
            int[] capacity = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] nums = Console.ReadLine().Split(' ');
                for (int j = 0; j < 2; j++)
                {
                    a = int.Parse(nums[0]);
                    b = int.Parse(nums[1]);
                }
                temp = temp + b - a;

                capacity[i] = temp;
            }
            Console.WriteLine(capacity.Max());
        }
        public void cf1183A()
        {
            int DigitSum(int n)
            {
                int sum = 0;
                while (n > 0)
                {
                    int rem = n % 10;
                    n /= 10;
                    sum += rem;
                }

                return sum;
            }

            int n = int.Parse(Console.ReadLine());
            int sum = DigitSum(n);
            while (sum % 4 != 0)
            {
                if (sum % 4 != 0)
                {
                    n++;
                    sum = DigitSum(n);
                }
            }
            Console.WriteLine(n);

        }
        public void cf118A()
        {
            string str = Console.ReadLine();
            string str2 = str.ToLower();
            string result = "";
            foreach (var i in str2)
            {
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u' || i == 'y')
                {
                    continue;
                }
                else
                {
                    result += ".";
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
        public void cf1200A()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int[] a = new int[10];
            int cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                {
                    cnt = 0;
                    for (int j = 0; j < 10; j++)
                    {
                        if (a[j] == 0)
                        {
                            cnt++;
                            a[j] = 1;
                        }
                        if (cnt == 1) break;
                    }
                }
                else if (s[i] == 'R')
                {
                    cnt = 0;
                    for (int j = 9; j >= 0; j--)
                    {
                        if (a[j] == 0)
                        {
                            cnt++;
                            a[j] = 1;
                        }
                        if (cnt == 1) break;
                    }
                }
                else a[s[i] - '0'] = 0;
            }
            foreach (var i in a)
            {
                Console.Write(i);
            }
        }
        public void cf1207A()
        {
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                string[] nums1 = Console.ReadLine().Split();
                int b = Convert.ToInt32(nums1[0]);
                int p = Convert.ToInt32(nums1[1]);
                int f = Convert.ToInt32(nums1[2]);
                string[] nums2 = Console.ReadLine().Split();
                int h = Convert.ToInt32(nums2[0]);
                int c = Convert.ToInt32(nums2[1]);
                int numOfBurger = b / 2;
                int cost = 0;
                if (c >= h)
                {
                    while (f > 0)
                    {
                        if (numOfBurger == 0) break;
                        cost += c;
                        f--;
                        numOfBurger--;
                    }
                    if (numOfBurger > 0)
                    {
                        while (p > 0)
                        {
                            if (numOfBurger == 0) break;
                            cost += h;
                            p--;
                            numOfBurger--;
                        }
                    }

                }
                else
                {
                    while (p > 0)
                    {
                        if (numOfBurger == 0) break;
                        cost += h;
                        p--;
                        numOfBurger--;
                    }
                    if (numOfBurger > 0)
                    {
                        while (f > 0)
                        {
                            if (numOfBurger == 0) break;
                            cost += c;
                            f--;
                            numOfBurger--;
                        }
                    }

                }

                Console.WriteLine(cost);
            }
        }
        public void cf1223A()
        {
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 2) Console.WriteLine(2);
                else if (n % 2 == 0 && n > 2) Console.WriteLine(0);
                else Console.WriteLine(1);
            }
        }
        public void cf122A()
        {
            int n = int.Parse(Console.ReadLine());
            if (((n % 4) == 0) || ((n % 7) == 0) || ((n % 44) == 0) || ((n % 47) == 0) | ((n % 74) == 0) || ((n % 444) == 0) || ((n % 447) == 0) || ((n % 474) == 0) || ((n % 477) == 0))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public void cf1230A()
        {
            string[] nums = Console.ReadLine().Split();
            int a = Convert.ToInt32(nums[0]);
            int b = Convert.ToInt32(nums[1]);
            int c = Convert.ToInt32(nums[2]);
            int d = Convert.ToInt32(nums[3]);
            int sum = a + b + c + d;
            if (sum % 2 != 0) Console.WriteLine("NO");
            else
            {
                int p = sum / 2;
                if (p - a == 0 || p - b == 0 || p - c == 0 || p - d == 0)
                    Console.WriteLine("YES");
                else if (p - a == b || p - a == c || p - a == d || p - b == c || p - b == d || p - c == d)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }

        }
        public void cf1296A()
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int even = 0;
                int odd = 0;
                int sum = 0;
                int n = int.Parse(Console.ReadLine());

                string[] nums = Console.ReadLine().Split();
                int[] num = new int[n];
                for (int j = 0; j < nums.Length; j++)
                    num[j] = Convert.ToInt32(nums[j]);

                foreach (var j in num)
                {
                    if (j % 2 != 0 || j == 1) odd++;
                    else even++;
                    sum += j;
                }
                if (sum % 2 != 0 || sum == 1) Console.WriteLine("YES");
                else
                {
                    if (even != 0 && odd != 0) Console.WriteLine("YES");
                    else Console.WriteLine("NO");
                }
            }
        }
        public void cf1303A()
        {
            int testcase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testcase; i++)
            {
                int count = 0, pos1 = 0, pos2 = 0;
                string s = Console.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '1')
                    {
                        pos1 = j;
                        break;
                    }
                }
                for (int j = s.Length - 1; j >= pos1; j--)
                {
                    if (s[j] == '1')
                    {
                        pos2 = j;
                        break;
                    }
                }
                for (int j = pos1; j < pos2; j++)
                {
                    if (s[j] == '0') count++;
                }
                Console.WriteLine(count);

            }
        }
        public void cf1304A()
        {
            int test = int.Parse(Console.ReadLine());
            for (int i = 0; i < test; i++)
            {
                string[] nums = Console.ReadLine().Split();

                long x = int.Parse(nums[0]);
                long y = int.Parse(nums[1]);
                long a = int.Parse(nums[2]);
                long b = int.Parse(nums[3]);


                long remainder = (y - x) % (a + b);

                if (remainder == 0)
                {
                    Console.WriteLine((y - x) / (a + b));
                }
                else
                {
                    Console.WriteLine(-1);
                }

            }
        }
        public void cf1312A()
        {
            int test = int.Parse(Console.ReadLine());
            for (int i = 0; i < test; i++)
            {
                string[] num = Console.ReadLine().Split();
                int n = Convert.ToInt32(num[0]);
                int m = Convert.ToInt32(num[1]);

                if (n % m == 0)
                {

                    Console.WriteLine("YES");

                }
                else Console.WriteLine("NO");
            }
        }
        public void cf1328A()
        {
            int test = int.Parse(Console.ReadLine());

            for (int i = 0; i < test; i++)
            {
                string[] nums = Console.ReadLine().Split();


                int a = int.Parse(nums[0]);
                int b = int.Parse(nums[1]);


                if (a % b == 0)
                {

                    Console.WriteLine(0);
                }
                else
                {

                    Console.WriteLine(b - (a % b));
                }

            }
        }


        public void cf1335A()
        {
            int test = int.Parse(Console.ReadLine());

            for (int i = 0; i < test; i++)
            {
                int t = int.Parse(Console.ReadLine());
                int a = t;
                int b = 0;
                int c = 0;
                if (t <= 2)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine((t - 1) / 2);
                }
            }
        }
        public void cf133A()
        {
            string str = Console.ReadLine();
            if (str.Contains('H') || str.Contains('Q') || str.Contains('9'))
                Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
        public void cf1352A()
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                List<int> lt = new List<int>();
                int n = int.Parse(Console.ReadLine());
                int count = 0;

                if (n % 10 != 0) lt.Add(n % 10);
                int ans = n % 10;
                n -= ans;

                if (n % 100 != 0) lt.Add(n % 100);
                ans = n % 100;
                n -= ans;

                if (n % 1000 != 0) lt.Add(n % 1000);
                ans = n % 1000;
                n -= ans;

                if (n % 10000 != 0) lt.Add(n % 10000);

                if (n >= 10000 && n % 10000 == 0) lt.Add(n);

                Console.WriteLine(lt.Count);
                for (int j = 0; j < lt.Count; j++)
                    Console.Write(lt[j] + " ");
                Console.WriteLine();
            }
        }
        public void cf1354A()
        {
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                string[] nums = Console.ReadLine().Split();
                int a = int.Parse(nums[0]);
                int b = int.Parse(nums[1]);
                int c = int.Parse(nums[2]);
                int d = int.Parse(nums[3]);

                if (b >= a)
                {
                    Console.WriteLine(b);
                    continue;
                }
                if (c <= d)
                {
                    Console.WriteLine(-1);
                    continue;
                }
                long sum = 0;
                if ((a - b) % (c - d) == 0)
                    sum = (a - b) / (c - d);
                else
                    sum = (a - b) / (c - d) + 1;

                sum = b + sum * c;
                Console.WriteLine(sum);
            }
        }
        public void cf1367A()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                int size = str.Length;
                string result = "";
                result += str[0];
                for (int j = 2; j < size - 1; j += 2)
                {
                    if (str[j] == str[j - 1])
                        result += str[j];
                    else continue;
                }
                result += str[size - 1];
                Console.WriteLine(result);
            }
        }
        public void cf1399A()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int s = int.Parse(Console.ReadLine());
                string[] nums = Console.ReadLine().Split(' ');
                int[] num = new int[s];
                for (int j = 0; j < s; j++) num[j] = int.Parse(nums[j]);
                Array.Sort(num);
                string verdict = "YES";
                for (int j = 1; j < s; j++)
                {
                    if (num[j] - num[j - 1] <= 1) continue;
                    else verdict = "NO";
                }
                Console.WriteLine(verdict);
            }
        }
        public void cf1409A()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] nums = Console.ReadLine().Split();
                int a = int.Parse(nums[0]);
                int b = int.Parse(nums[1]);
                if (a > b)
                {
                    int temp = b;
                    b = a;
                    a = temp;
                }
                long sum = 0, sub = 0, mod = 0, div = 0;
                sub = b - a;
                div = sub / 10;
                mod = sub % 10;
                sum = div;
                if (mod > 0) sum++;
                Console.WriteLine(sum);
            }
        }
        public void cf141A()
        {
            string a, b, c, s;
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            s = Console.ReadLine();
            s = a + b;

            static string SortString(string input)
            {
                char[] characters = input.ToArray();
                Array.Sort(characters);
                return new string(characters);
            }
            s = SortString(s);
            c = SortString(c);
            if (s == c) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
        public void cf144A()
        {
            int n = int.Parse(Console.ReadLine());

            string[] nums = Console.ReadLine().Split();
            int[] num = new int[n];
            for (int i = 0; i < n; i++) num[i] = int.Parse(nums[i]);
            int min, max, min_index, max_index;
            min = num[0];
            min_index = 0;
            max = num[0];
            max_index = 0;

            for (int i = 0; i < n; i++)
            {
                if (min >= num[i])
                {
                    min = num[i];
                    min_index = i;
                }
                if (max < num[i])
                {
                    max = num[i];
                    max_index = i;
                }
            }

            if (min_index < max_index)
            {
                min_index = (n - 1) - min_index;
                Console.WriteLine(min_index + max_index - 1);
            }
            else
            {
                min_index = (n - 1) - min_index;
                Console.WriteLine(min_index + max_index);
            }
        }
        public void cf148A()
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int count = d;
            if (k == 1 || l == 1 || m == 1 || n == 1) Console.WriteLine(d);
            else
            {
                for (int i = 1; i <= d; i++)
                    if ((i % k != 0) && (i % l != 0) && (i % m != 0) && (i % n != 0)) count--;
                Console.WriteLine(count);
            }
        }
        public void cf155A()
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            int[] num = new int[n];
            for (int i = 0; i < n; i++) num[i] = int.Parse(nums[i]);
            int max = num[0];
            int min = num[0];
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                    count++;
                }
                if (num[i] < min)
                {
                    min = num[i];
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public void cf158A()
        {
            string[] nums = new string[2];
            nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int k = int.Parse(nums[1]) - 1;
            int count = 0;
            int[] array = new int[n];
            string[] marks = Console.ReadLine().Split(' ');
            for (int j = 0; j < marks.Length; j++)
                array[j] = int.Parse(marks[j]);
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0 && array[i] >= array[k])
                    count++;
            Console.WriteLine(count);


        }
        public void cf1619A()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                int flag = 1;
                if (s.Length % 2 != 0) flag = 0;
                int len = s.Length / 2;
                for (int j = 0; j < len; j++)
                    if (s[j] != s[len + j])
                    {
                        flag = 0;
                        break;
                    }
                if (flag == 0) Console.WriteLine("NO");
                else Console.WriteLine("YES");
            }
        }
        public void cf1624A()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string[] nums = Console.ReadLine().Split();
                int[] num = new int[n];
                for (int j = 0; j < n; j++) num[j] = int.Parse(nums[j]);
                Array.Sort(num);
                int answer = num[n - 1] - num[0];
                Console.WriteLine(answer);
            }
        }
        public void cf1676A()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int sum1 = 0, sum2 = 0;
                string num = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                    sum1 += (Convert.ToInt32(num[j]) - 48);
                for (int k = 3; k < 6; k++) sum2 += (Convert.ToInt32(num[k]) - 48);
                if (sum1 == sum2) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
        public void cf1754A()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                int m = int.Parse(Console.ReadLine());
                string str = Console.ReadLine();
                foreach (var j in str)
                {
                    if (j == 'Q') count++;
                    else
                    {
                        if (j == 'A' && count != 0)
                            count--;
                    }
                }
                if (count != 0)
                    Console.WriteLine("No");
                else Console.WriteLine("Yes");
            }
        }
        public void cf1A()
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int m = int.Parse(nums[1]);
            int a = int.Parse(nums[2]);
            long x = n / a;
            long y = m / a;
            if (n % a != 0) x++;
            if (m % a != 0) y++;
            long sum = x * y;
            Console.WriteLine(sum);
        }
        public void cf228A()
        {
            string[] nums = Console.ReadLine().Split();
            int[] num = new int[4];
            for (int i = 0; i < 4; i++)
                num[i] = int.Parse(nums[i]);
            Array.Sort(num);
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (num[i] == num[i + 1]) count++;
                else continue;
            }
            Console.WriteLine(count);
        }
        public void cf231A()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string[] nums = Console.ReadLine().Split();
                int a = int.Parse(nums[0]);
                int b = int.Parse(nums[1]);
                int c = int.Parse(nums[2]);
                int sum = a + b + c;
                if (sum >= 2) count++;
            }
            Console.WriteLine(count);
        }
        public void cf236A()
        {
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string str2 = String.Join("", arr);
            int count = 1;
            for (int i = 0; i < str2.Length - 1; i++)
                if (str2[i] != str2[i + 1]) count++;
            if (count % 2 == 0) Console.WriteLine("CHAT WITH HER!");
            else Console.WriteLine("IGNORE HIM!");

        }
        public void cf25A()
        {
            int n = int.Parse(Console.ReadLine());
            string[] num = Console.ReadLine().Split();
            int[] nums = new int[n];
            for (int i = 0; i < n; i++) nums[i] = Convert.ToInt32(num[i]);
            int even = 0, lastEven = 0, lastOdd = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    even++;
                    lastEven = i + 1;
                }
                if (nums[i] % 2 != 0)
                {
                    even--;
                    lastOdd = i + 1;
                }
            }
            if (even > 0)
                Console.WriteLine(lastOdd);
            else
                Console.WriteLine(lastEven);
        }

        public void cf263A()
        {
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; ++i)
            {
                string[] nums = Console.ReadLine().Split();
                for (int j = 0; j < 5; ++j)
                    matrix[i, j] = int.Parse(nums[j]);
            }
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (matrix[i, j] == 1)
                        Console.WriteLine(Math.Abs(i - 2) + Math.Abs(j - 2));
        }
        public void cf266A()
        {
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            string s = Console.ReadLine();
            for (int i = 0; i < a - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    b++;
                }
            }
            Console.WriteLine(b);
        }
        public void cf271A()
        {
            bool isDistinct(int n)
            {
                bool[] visited = new bool[10];
                while (n > 0)
                {
                    int rem = n % 10;
                    n /= 10;
                    if (visited[rem] == false) visited[rem] = true;
                    else return false;
                }
                return true;
            }
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 9000; i++)
                if (isDistinct(n + i))
                {
                    Console.WriteLine(n + i);
                    break;
                }
        }
        public void cf281A()
        {
            string str = Console.ReadLine();
            Console.WriteLine(char.ToUpper(str[0]) + str.Substring(1));
        }
        public void cf339A()
        {
            string s = Console.ReadLine();
            string result = "";
            char[] charS = s.ToCharArray();
            Array.Sort(charS);
            for (int i = 0; i < charS.Length; i++)
            {
                if (charS[i] >= '1' && charS[i] <= '9')
                {
                    result += charS[i];
                    if (i != charS.Length - 1) result += "+";
                }
            }
            Console.WriteLine(result);
        }
        public void cf344A()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int[] nums = new int[n];
            for (int i = 0; i < n; i++) nums[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i] == nums[i + 1]) continue;
                else count++;
            }
            Console.WriteLine(count + 1);

        }
        public void cf405A()
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            int[] num = new int[n];
            for (int i = 0; i < nums.Length; i++) num[i] = Convert.ToInt32(nums[i]);
            Array.Sort(num);
            foreach (var i in num) Console.Write(i + " ");
        }
        public void cf41A()
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            string tRev = String.Empty;
            for (int i = t.Length - 1; i > -1; i--) tRev += t[i];
            if (s == tRev) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
        public void cf427A()
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
                num[i] = int.Parse(nums[i]);
            int cases = 0, police = 0;
            for (int i = 0; i < n; i++)
            {
                if (num[i] < 0)
                {
                    if (police > 0) police--;
                    else cases++;
                }
                else police += num[i];
            }
            Console.WriteLine(cases);
        }
        public void cf432A()
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int k = int.Parse(num[1]);
            int count = 0;
            string[] nums = Console.ReadLine().Split();
            int[] num2 = new int[n];
            for (int i = 0; i < n; i++) num2[i] = int.Parse(nums[i]);
            foreach (var i in num2)
                if (i + k <= 5) count++;
            Console.WriteLine(count / 3);
        }
        public void cf43A()
        {
            int n = int.Parse(Console.ReadLine());
            int goal = 0;
            string team1, team2 = "";
            for (int i = 0; i < n; i++)
            {
                if (goal != 0)
                {
                    team1 = Console.ReadLine();
                    if (team1 == team2) goal++;
                    else goal--;
                }
                else
                {
                    team2 = Console.ReadLine();
                    goal++;
                }
            }
            Console.WriteLine(team2);
        }
        public void cf443A()
        {
            string letters = Console.ReadLine();
            HashSet<char> a = new HashSet<char>();
            for (int i = 0; i < letters.Length; i++)
                if (letters[i] >= 'a' && letters[i] <= 'z')
                    a.Add(letters[i]);
            Console.WriteLine(a.Count);
        }
        public void cf467A()
        {
            int rooms = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < rooms; i++)
            {
                string[] nums = Console.ReadLine().Split();
                int accomodated = Convert.ToInt32(nums[0]);
                int accomodation = Convert.ToInt32(nums[1]);
                if (accomodated + 2 <= accomodation) count++;
            }
            Console.WriteLine(count);
        }
        public void cf472A()
        {
            int n = int.Parse(Console.ReadLine());

            bool isPrime(int n)
            {
                if (n <= 1) return false;
                for (int i = 2; i < n; i++)
                    if (n % i == 0)
                        return false;
                return true;
            }
            int result, i;
            for (i = 4; i < n; i++)
            {
                if (!isPrime(i))
                {
                    result = n - i;
                    if (!isPrime(result))
                    {
                        Console.WriteLine(i + " " + result);
                        break;
                    }
                }

            }
        }
        public void cf479A()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = 0;

            int sum1 = a + b * c;
            if (sum1 > max) max = sum1;
            int sum2 = a * (b + c);
            if (sum2 > max) max = sum2;
            int sum3 = a * b * c;
            if (sum3 > max) max = sum3;
            int sum4 = (a + b) * c;
            if (sum4 > max) max = sum4;
            int sum5 = a + b + c;
            if (sum5 > max) max = sum5;
            Console.WriteLine(max);

        }
        public void cf486A()
        {
            long n = Convert.ToInt64(Console.ReadLine());
            long result = 0;
            if (n % 2 == 0) result = n / 2;
            else result = ((n + 1) / 2) * (-1);

            Console.WriteLine(result);
        }
        public void cf496A()
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            string[] nums2 = Console.ReadLine().Split();
            List<int> list = new List<int>();
            for (int i = 1; i < nums.Length; i++)
                list.Add(int.Parse(nums[i]));
            for (int i = 1; i < nums2.Length; i++)
                list.Add(int.Parse(nums2[i]));

            list.Sort();
            list.Add(0);

            int count = 0;
            for (int i = 0; i < nums.Length + nums2.Length - 2; i++)
                if (list[i] != list[i + 1]) count++;

            if (count == n) Console.WriteLine("I become the guy.");
            else Console.WriteLine("Oh, my keyboard!");
        }
        public void cf4A()
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 2 && n % 2 == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
        public void cf50A()
        {
            string[] nums = Console.ReadLine().Split();
            int m = int.Parse(nums[0]);
            int n = int.Parse(nums[1]);
            if (m == 1 && n == 1) Console.WriteLine(0);
            else
                Console.WriteLine((m * n) / 2);
        }
        public void cf510A()
        {
            string[] nums = Console.ReadLine().Split();
            int row = int.Parse(nums[0]);
            int col = int.Parse(nums[1]);
            for (int i = 1; i <= row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i % 4 == 0)
                    {
                        if (j == 0)
                            Console.Write("#");
                        else
                            Console.Write(".");
                    }
                    else if (i % 4 == 2)
                    {
                        if (j == col - 1)
                            Console.Write("#");
                        else
                            Console.Write(".");
                    }
                    else Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        public void cf513A()
        {
            string[] nums = Console.ReadLine().Split();
            int n1 = Convert.ToInt32(nums[0]);
            int n2 = Convert.ToInt32(nums[1]);
            int k1 = Convert.ToInt32(nums[2]);
            int k2 = Convert.ToInt32(nums[3]);
            if (n1 > n2) Console.WriteLine("First");
            else Console.WriteLine("Second");

        }
        public void cf546A()
        {
            string[] nums = Console.ReadLine().Split();
            int k = int.Parse(nums[0]);
            int n = int.Parse(nums[1]);
            int w = int.Parse(nums[2]);
            int sum = (w * (w + 1)) / 2;
            int cost = sum * k;
            if (cost <= n) Console.WriteLine(0);
            else
                Console.WriteLine(cost - n);
        }


        public void cf579A()
        {
            int bacteria = int.Parse(Console.ReadLine());
            int count = 0;
            while (bacteria > 0)
            {
                if (bacteria % 2 == 0) bacteria /= 2;
                else
                {
                    bacteria -= 1;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public void cf581A()
        {
            string[] nums = Console.ReadLine().Split();
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);
            int count1 = 0, count2 = 0;
            while (a > 0 && b > 0)
            {
                count1++;
                a--;
                b--;
            }
            while (a > 1) { count2++; a -= 2; };
            while (b > 1) { count2++; b -= 2; };
            Console.WriteLine(count1 + " " + count2);
        }
        public void cf58A()
        {
            string s = Console.ReadLine();
            string s2 = "hello";
            int count = 0, j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == s2[j])
                {
                    count++;
                    j++;
                    if (count == 5) break;
                }
            }
            if (count == 5) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
        public void cf59A()
        {
            string s = Console.ReadLine();
            int up = 0, low = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 97 && s[i] <= 122) low++;
                else up++;
            }
            if (low >= up) Console.WriteLine(s.ToLower());
            else Console.WriteLine(s.ToUpper());
        }
        public void cf617A()
        {
            int coOrdinate = int.Parse(Console.ReadLine());
            int count = 0;
            while (coOrdinate > 0)
            {
                if (coOrdinate >= 5)
                {
                    coOrdinate -= 5;
                    count++;
                }
                else if (coOrdinate >= 4)
                {
                    coOrdinate -= 4;
                    count++;
                }
                else if (coOrdinate >= 3)
                {
                    coOrdinate -= 3;
                    count++;
                }
                else if (coOrdinate >= 2)
                {
                    coOrdinate -= 2;
                    count++;
                }
                else
                {
                    coOrdinate -= 1;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public void cf61A()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string result = "";
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] == '0' && b[i] == '0') || (a[i] == '1' && b[i] == '1')) result += '0';
                else result += '1';
            }
            Console.WriteLine(result);
        }
        public void cf703A()
        {
            int n = int.Parse(Console.ReadLine());
            int m = 0, c = 0;
            for (int i = 0; i < n; i++)
            {
                string[] nums = Console.ReadLine().Split();
                int a = int.Parse(nums[0]);
                int b = int.Parse(nums[1]);
                if (a > b) m++;
                else if (a < b) c++;
                else continue;
            }

            if (c > m) Console.WriteLine("Chris");
            else if (m > c) Console.WriteLine("Mishka");
            else Console.WriteLine("Friendship is magic!^^");
        }
        public void cf705A()
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0) result += " I hate";
                else result += " I love";

                if (i != n)
                    result += " that";
            }
            result += " it";
            Console.WriteLine(result);
        }
        public void cf71A()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                if (str.Length > 10)
                    Console.WriteLine(str[0] + "" + (str.Length - 2) + "" + str[str.Length - 1]);
                else
                    Console.WriteLine(str);
            }
        }
        public void cf723A()
        {
            string[] nums = Console.ReadLine().Split();
            int[] num = new int[3];
            for (int i = 0; i < 3; i++) num[i] = int.Parse(nums[i]);
            Array.Sort(num);
            int res = (num[1] - num[0]) + (num[2] - num[1]);
            Console.WriteLine(res);
        }
        public void cf732A()
        {
            string[] nums = Console.ReadLine().Split();
            int k = int.Parse(nums[0]);
            int r = int.Parse(nums[1]);

            int count = 0;
            bool b = true;
            while (b == true)
            {
                count++;
                int h = k * count;
                if (h % 10 == 0 || h % 10 == r)
                    b = false;
            }
            Console.WriteLine(count);
        }
        public void cf734A()
        {
            int numOfGames = int.Parse(Console.ReadLine());
            string matchResult = Console.ReadLine();
            int anton = 0, danik = 0;
            foreach (var i in matchResult)
            {
                if (i == 'A') anton++;
                else danik++;
            }
            if (anton == danik) Console.WriteLine("Friendship");
            else if (anton > danik) Console.WriteLine("Anton");
            else Console.WriteLine("Danik");
        }
        public void cf750A()
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int k = int.Parse(nums[1]);

            int totalTime = 240;
            int restTime = 240 - k;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (restTime >= i * 5)
                {
                    restTime -= i * 5;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public void cf758A()
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
                num[i] = int.Parse(nums[i]);
            int max = num.Max();
            int s = 0;
            foreach (var i in num)
            {
                s += (max - i);
            }
            Console.WriteLine(s);
        }
        public void cf785A()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (s == "Tetrahedron") count += 4;
                else if (s == "Cube") count += 6;
                else if (s == "Octahedron") count += 8;
                else if (s == "Dodecahedron") count += 12;
                else count += 20;
            }
            Console.WriteLine(count);
        }
        public void cf791A()
        {
            string[] nums = Console.ReadLine().Split();
            int limak = int.Parse(nums[0]);
            int bob = int.Parse(nums[1]);
            int count = 0;
            while (limak <= bob)
            {
                limak *= 3;
                bob *= 2;
                ++count;
            }
            Console.WriteLine(count);
        }
        public void cf96A()
        {
            string str = Console.ReadLine();
            int count = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    count++;
                    if (count == 7)
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                }
                else count = 1;
            }
            if (count < 7)
                Console.WriteLine("NO");
        }
        public void cf977A()
        {
            string[] nums = Console.ReadLine().Split();
            int n = Convert.ToInt32(nums[0]);
            int m = Convert.ToInt32(nums[1]);
            for (int i = 0; i < m; i++)
            {
                if (n % 10 == 0) n /= 10;
                else n -= 1;
            }
            Console.WriteLine(n);
        }
        public void cf996A()
        {
            int n = int.Parse(Console.ReadLine());
            int c = 0;

            while (n > 0)
            {
                if (n >= 100)
                {
                    n -= 100;
                    c++;
                }
                else if (n >= 20)
                {
                    n -= 20;
                    c++;
                }
                else if (n >= 10)
                {
                    n -= 10;
                    c++;
                }
                else if (n >= 5)
                {
                    n -= 5;
                    c++;
                }
                else
                {
                    n -= 1;
                    c++;
                }
            }
            Console.WriteLine(c);
        }







    }
}
