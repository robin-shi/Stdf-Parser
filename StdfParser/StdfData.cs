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
        public static Dictionary<string, string> MainInfo { get; set; }
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
        public static void UpdateMainInfo(StdfFile stdfFile)
        {
            MainInfo = new Dictionary<string, string> { };
            var results = stdfFile.GetRecords().OfExactType<Mir>();
            foreach (var result in results)
            {
                try
                {
                    MainInfo.Add("Setup time:", result.SetupTime.ToString());
                    MainInfo.Add("Start time:", result.StartTime.ToString());
                    MainInfo.Add("Tester station number:", result.StationNumber.ToString());
                    MainInfo.Add("Test mode code:", result.ModeCode.ToString());
                    MainInfo.Add("Lot retest code:", result.RetestCode.ToString());
                    //MainInfo.Add("Data protection code:", result.ProtectionCode.ToString());
                    //MainInfo.Add("Burn-in time:", result.BurnInTime.ToString());
                    //MainInfo.Add("Command mode code:", result.CommandModeCode.ToString());
                    //MainInfo.Add("Lot ID:", result.LotId.ToString());
                    //MainInfo.Add("Part type:", result.PartType.ToString());
                    //MainInfo.Add("Node name:", result.NodeName.ToString());
                    //MainInfo.Add("Tester type:", result.TesterType.ToString());
                    //MainInfo.Add("Program name:", result.JobName.ToString());
                    //MainInfo.Add("Program revision:", result.JobRevision.ToString());
                    //MainInfo.Add("Sublot ID:", result.SublotId.ToString());
                    //MainInfo.Add("Operator name:", result.OperatorName.ToString());
                    //MainInfo.Add("Tester software type:", result.ExecType.ToString());
                    //MainInfo.Add("Tester software version:", result.ExecVersion.ToString());
                    //MainInfo.Add("Test code:", result.TestCode.ToString());
                    //MainInfo.Add("Test temperature:", result.TestTemperature.ToString());
                    //MainInfo.Add("User text:", result.UserText.ToString());
                    //MainInfo.Add("Auxiliary file:", result.AuxiliaryFile.ToString());
                    //MainInfo.Add("Package type:", result.PackageType.ToString());
                    //MainInfo.Add("Product family ID:", result.FamilyId.ToString());
                    //MainInfo.Add("Date code:", result.DateCode.ToString());
                    //MainInfo.Add("Test facility ID:", result.FacilityId.ToString());
                    //MainInfo.Add("Test floor ID:", result.FloorId.ToString());
                    //MainInfo.Add("Fabrication process ID:", result.ProcessId.ToString());
                    //MainInfo.Add("Operation frequency:", result.OperationFrequency.ToString());
                    //MainInfo.Add("Test specification name:", result.SpecificationName.ToString());
                    //MainInfo.Add("Test specification version:", result.SpecificationVersion.ToString());
                    //MainInfo.Add("Test flow ID:", result.FlowId.ToString());
                    //MainInfo.Add("Test setup ID:", result.SetupId.ToString());
                    //MainInfo.Add("Device design revision:", result.DesignRevision.ToString());
                    //MainInfo.Add("Engineering lot ID:", result.EngineeringId.ToString());
                    //MainInfo.Add("ROM code ID:", result.RomCode.ToString());
                    //MainInfo.Add("Tester serial number:", result.SerialNumber.ToString());
                    //MainInfo.Add("Supervisor name:", result.SupervisorName.ToString());
                }
                catch (Exception ex)
                { 
                }
               
            }
        }
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
