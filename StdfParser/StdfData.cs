using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToStdf;
using LinqToStdf.Records.V4;

namespace StdfData
{
    static class Results
    {
        public static Dictionary<uint, string> TestItems { get; set; }

        public static sbyte? Scaling { get; set; }
        public static byte Site { get; set; }
        public static uint TestNum { get; set; }
        public static string TestName { get; set; }
        public static string Unit { get; set; }
        public static double LowLimt { get; set; }
        public static double HighLimt { get; set; }
        public static double[] DataX { get; set; }
        public static double[] DataY { get; set; }
        public static double Mean { get; set; }
        public static double Min { get; set; }
        public static double Max { get; set; }
        public static double StDev { get; set; }
        public static double Cpk { get; set; }
        public readonly static Dictionary<sbyte?, String> PreFixSearch=new Dictionary<sbyte?, string>{{ 15,"f"},{ 12,"p"},
            { 9,"n"},{ 6,"u"},{ 3,"m"},{ 2,"%"},{ 0," "},{ -3,"K"},{ -6,"M"},{ -9,"G"},{ -12,"T"},};
        public static void UpdateTestItems(StdfFile stdfFile)
        {
            var results = stdfFile.GetRecords().OfExactType<Tsr>();
            TestItems = new Dictionary<uint, string>();
            //toolStripProgressBarFileOpen.Maximum = results.Count();
            foreach (var result in results)
            {
                try
                {
                    //toolStripProgressBarFileOpen.Value++;
                    TestItems.Add(result.TestNumber, result.TestName);
                }
                catch { }
            }
        }
        public static void UpdateResults(StdfFile stdfFile, byte site,uint testNum)
        {
            var values = stdfFile.GetRecords().OfExactType<Ptr>().Where(p => p.TestNumber == testNum && p.SiteNumber == site);//.Select(p => p.Result);
            DataY = new double[values.Count()];
            DataX = new double[values.Count()];
            int i = 0;
            double scaling = 0;
            foreach (var value in values)
            {
                if (i == 0)
                {
                    Scaling = value.ResultScalingExponent;
                    scaling = Math.Pow(10, (double)Scaling);
                    Unit = value.Units;
                    LowLimt = (double)value.LowLimit * scaling;
                    HighLimt = (double)value.HighLimit * scaling;
                }
                DataY[i] = (double)value.Result* scaling;
                DataX[i] = i;
                i++;
            }
            Unit = PreFixSearch[Scaling]+Unit;
            var stats = new ScottPlot.Statistics.BasicStats(DataY);
            TestNum = testNum;
            Site = site;
            TestName = TestItems[testNum];
            Mean = stats.Mean;
            Min = stats.Min;
            Max = stats.Max;
            StDev = stats.StDev;
            Cpk = Math.Min(HighLimt-Mean,Mean-LowLimt)/(3*StDev);


        }

    }
}
