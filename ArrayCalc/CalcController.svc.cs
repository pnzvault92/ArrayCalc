using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Diagnostics;

namespace ArrayCalc
{
    public class CalcController : ICalcController
    {
        delegate double Mull(string x1, string x2);
        public Result Mean(string array)
        {
            Result r = new Result();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            double mean1 = array.Split(',').Average(item => int.Parse(item));
            sw.Stop();

            r.Res = mean1;
            r.Time = sw.ElapsedTicks;
            return r;
        }

        public Result Sum(string array)
        {
            Result r = new Result();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            double sum = array.Split(',').Sum(x => int.Parse(x));
            sw.Stop();

            r.Res = sum;
            r.Time = sw.ElapsedTicks;
            return r;
        }

        public Result Mul(string array)
        {
            Result r = new Result();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            //string[] numbers = array.Split(',');
            //double mul = 1;
            //foreach (string num in numbers)
            //    mul *= int.TryParse(num, out int k) ? k : 0;

            double mul = Array.ConvertAll(array.Split(','), Double.Parse).Aggregate((x, y) => x * y);


            sw.Stop();

            r.Res = mul;
            r.Time = sw.ElapsedTicks;
            return r;
        }
    }
}
