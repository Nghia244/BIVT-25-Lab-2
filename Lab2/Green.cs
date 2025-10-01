using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            for (int i = 2; i <= n; i+=2)
            {
                answer += i / (i + 1.0);
            }

            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i = 0; i <= n; i++)
            {
                answer += 1 / Math.Pow(x, i);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fact = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i > 0) fact *= i;
                answer += fact;
            }

            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            for (n = 1; Math.Abs(Math.Sin(n*Math.Pow(x, n))) <= Math.Pow(10, -4); n++) 
            {
                answer += Math.Sin(n*Math.Pow(x,n));
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double a=x,b=1;
            while (true)
            {
                if (Math.Abs(1 / b - 1 / a) <= E)
                {
                    answer = n;
                    break;
                }

                a *= x;
                b *= x;
                n++;
            }

            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }

            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            while (L > Da)
            {
                answer++;
                L /= 2;
            }

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            int i = 0;
            double a1, a2,ans,sum=0;
            for (double x = a; x <= b+1e-15; x += h)
            {
                a2 = x;
                a1 = 1;
                i = 0;
                while (true)
                {
                    ans = a1 * a2 / (2 * i + 1);
                    if (Math.Abs(ans) < E) break;
                    sum += ans;
                    a1 *= -1;
                    a2 *= x * x;
                    i++;

                }

                SS += sum;
                SS -= 1e-5;
                SY += Math.Atan(x);
                sum = 0;
            }

            // end

            return (SS, SY);
        }
    }

}

