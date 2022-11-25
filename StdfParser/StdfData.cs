using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToStdf;
using LinqToStdf.Records.V4;

namespace StdfParser
{
    public class StdfData
    {
        public StdfFile StdfFile { get; set; }
        public byte[] SiteNums {get;set;}
        public Dictionary<uint, string> TestItems { get; set; }
        public Dictionary<string, string> MirData { get; set; }

        public sbyte? Scaling { get; set; }
        public byte Site { get; set; }
        public uint TestNum { get; set; }
        public string TestName { get; set; }
        public string Unit { get; set; }
        public double LowLimt { get; set; }
        public double HighLimt { get; set; }
        public double[] DataX { get; set; }
        public double[] DataY { get; set; }
        public double Mean { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double StDev { get; set; }
        public double Cpk { get; set; }

        public readonly static Dictionary<sbyte?, String> PreFixSearch=new Dictionary<sbyte?, string>{{ 15,"f"},{ 12,"p"},
            { 9,"n"},{ 6,"u"},{ 3,"m"},{ 2,"%"},{ 0," "},{ -3,"K"},{ -6,"M"},{ -9,"G"},{ -12,"T"},};

        public StdfData(string stdfFilePath)
        {
            StdfFile = new StdfFile(stdfFilePath);
            UpdateSiteNumbers();
            UpdateMirData();
            UpdateTestItems();
        }

        void UpdateMirData()
        {
            MirData = new Dictionary<string, string> { };
            var results = StdfFile.GetRecords().OfExactType<Mir>();
            foreach (var result in results)
            {
                try
                {
                    if (result.SetupTime!=null)
                        MirData.Add("Setup time:", result.SetupTime.ToString());
                    if (result.StartTime != null)
                        MirData.Add("Start time:", result.StartTime.ToString());
           
                        MirData.Add("Tester station number:", result.StationNumber.ToString());//int always not null
                    if (result.ModeCode != null)
                        MirData.Add("Test mode code:", result.ModeCode.ToString());
                    if (result.RetestCode != null)
                        MirData.Add("Lot retest code:", result.RetestCode.ToString());
                    if (result.ProtectionCode != null)
                        MirData.Add("Data protection code:", result.ProtectionCode.ToString());
                    if (result.BurnInTime != null)
                        MirData.Add("Burn-in time:", result.BurnInTime.ToString());
                    if (result.CommandModeCode != null)
                        MirData.Add("Command mode code:", result.CommandModeCode.ToString());
                    if (result.LotId != null)
                        MirData.Add("Lot ID:", result.LotId.ToString());
                    if (result.PartType != null)
                        MirData.Add("Part type:", result.PartType.ToString());
                    if (result.NodeName != null)
                        MirData.Add("Node name:", result.NodeName.ToString());
                    if (result.TesterType != null)
                        MirData.Add("Tester type:", result.TesterType.ToString());
                    if (result.JobName != null)
                        MirData.Add("Program name:", result.JobName.ToString());
                    if (result.JobRevision != null)
                        MirData.Add("Program revision:", result.JobRevision.ToString());
                    if (result.SublotId != null)
                        MirData.Add("Sublot ID:", result.SublotId.ToString());
                    if (result.OperatorName != null)
                        MirData.Add("Operator name:", result.OperatorName.ToString());
                    if (result.ExecType != null)
                        MirData.Add("Tester software type:", result.ExecType.ToString());
                    if (result.ExecVersion != null)
                        MirData.Add("Tester software version:", result.ExecVersion.ToString());
                    if (result.TestCode != null)
                        MirData.Add("Test code:", result.TestCode.ToString());
                    if (result.TestTemperature != null)
                        MirData.Add("Test temperature:", result.TestTemperature.ToString());
                    if (result.UserText != null)
                        MirData.Add("User text:", result.UserText.ToString());
                    if (result.AuxiliaryFile != null)
                        MirData.Add("Auxiliary file:", result.AuxiliaryFile.ToString());
                    if (result.PackageType != null)
                        MirData.Add("Package type:", result.PackageType.ToString());
                    if (result.FamilyId != null)
                        MirData.Add("Product family ID:", result.FamilyId.ToString());
                    if (result.DateCode != null)
                        MirData.Add("Date code:", result.DateCode.ToString());
                    if (result.FacilityId != null)
                        MirData.Add("Test facility ID:", result.FacilityId.ToString());
                    if (result.FloorId != null)
                        MirData.Add("Test floor ID:", result.FloorId.ToString());
                    if (result.ProcessId != null)
                        MirData.Add("Fabrication process ID:", result.ProcessId.ToString());
                    if (result.OperationFrequency != null)
                        MirData.Add("Operation frequency:", result.OperationFrequency.ToString());
                    if (result.SpecificationName != null)
                        MirData.Add("Test specification name:", result.SpecificationName.ToString());
                    if (result.SpecificationVersion != null)
                        MirData.Add("Test specification version:", result.SpecificationVersion.ToString());
                    if (result.FlowId != null)
                        MirData.Add("Test flow ID:", result.FlowId.ToString());
                    if (result.SetupId != null)
                        MirData.Add("Test setup ID:", result.SetupId.ToString());
                    if (result.DesignRevision != null)
                        MirData.Add("Device design revision:", result.DesignRevision.ToString());
                    if (result.EngineeringId != null)
                        MirData.Add("Engineering lot ID:", result.EngineeringId.ToString());
                    if (result.RomCode != null)
                        MirData.Add("ROM code ID:", result.RomCode.ToString());
                    if (result.SerialNumber != null)
                        MirData.Add("Tester serial number:", result.SerialNumber.ToString());
                    if (result.SupervisorName != null)
                        MirData.Add("Supervisor name:", result.SupervisorName.ToString());
                }
                catch (Exception ex)
                { 
                }
               
            }
        }
        void UpdateSiteNumbers()
        {
            var results =StdfFile.GetRecords().OfExactType<Sdr>();
            foreach (var result in results)
            {
                SiteNums = result.SiteNumbers;
            }
        }

        void UpdateTestItems()
        {
            var results = StdfFile.GetRecords().OfExactType<Tsr>();
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
        public void UpdateResults(byte site,uint testNum)
        {
            var values = StdfFile.GetRecords().OfExactType<Ptr>().Where(p => p.TestNumber == testNum && p.SiteNumber == site);//.Select(p => p.Result);
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
