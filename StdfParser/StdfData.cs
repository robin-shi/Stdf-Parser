using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using LinqToStdf;
using LinqToStdf.Records.V4;

namespace StdfParser
{
    public class StdfData
    {
        public StdfFile StdfFile { get; set; }
        public byte[] HeadNums { get; set; }
        public byte[] SiteNums { get;set;}
        public Dictionary<uint, string> TestItems { get; set; }
        public Dictionary<string, string> Summary { get; set; }
        public uint TotalCount { get; set; } = 0;
        public uint PassedCount { get; set; } = 0;
        public double TotalYield { get; set; } = 0;
        public Dictionary<byte?,Dictionary<byte?, uint>> PartCountPerSitePerHead { get; set; }

        public sbyte? Scaling { get; set; }
        public byte Head { get; set; }
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
            UpdateHeadAndSiteNums();
            UpdateTestItems();
            UpdatePartCount();
            UpdateSummary();
        }

        void UpdateSummary()
        {
            Summary = new Dictionary<string, string> { };
            Summary.Add("Total count：",$"{TotalCount}");
            Summary.Add("Passed count：", $"{PassedCount}");
            Summary.Add("Yield：", $"{TotalYield*100:f2}%");
            var result = StdfFile.GetMir();
            try
            {
                if (result.SetupTime!=null)
                    Summary.Add("Setup time:", result.SetupTime.ToString());
                if (result.StartTime != null)
                    Summary.Add("Start time:", result.StartTime.ToString());
           
                    Summary.Add("Tester station number:", result.StationNumber.ToString());//int always not null
                if (result.ModeCode != null)
                    Summary.Add("Test mode code:", result.ModeCode.ToString());
                if (result.RetestCode != null)
                    Summary.Add("Lot retest code:", result.RetestCode.ToString());
                if (result.ProtectionCode != null)
                    Summary.Add("Data protection code:", result.ProtectionCode.ToString());
                if (result.BurnInTime != null)
                    Summary.Add("Burn-in time:", result.BurnInTime.ToString());
                if (result.CommandModeCode != null)
                    Summary.Add("Command mode code:", result.CommandModeCode.ToString());
                if (result.LotId != null)
                    Summary.Add("Lot ID:", result.LotId.ToString());
                if (result.PartType != null)
                    Summary.Add("Part type:", result.PartType.ToString());
                if (result.NodeName != null)
                    Summary.Add("Node name:", result.NodeName.ToString());
                if (result.TesterType != null)
                    Summary.Add("Tester type:", result.TesterType.ToString());
                if (result.JobName != null)
                    Summary.Add("Program name:", result.JobName.ToString());
                if (result.JobRevision != null)
                    Summary.Add("Program revision:", result.JobRevision.ToString());
                if (result.SublotId != null)
                    Summary.Add("Sublot ID:", result.SublotId.ToString());
                if (result.OperatorName != null)
                    Summary.Add("Operator name:", result.OperatorName.ToString());
                if (result.ExecType != null)
                    Summary.Add("Tester software type:", result.ExecType.ToString());
                if (result.ExecVersion != null)
                    Summary.Add("Tester software version:", result.ExecVersion.ToString());
                if (result.TestCode != null)
                    Summary.Add("Test code:", result.TestCode.ToString());
                if (result.TestTemperature != null)
                    Summary.Add("Test temperature:", result.TestTemperature.ToString());
                if (result.UserText != null)
                    Summary.Add("User text:", result.UserText.ToString());
                if (result.AuxiliaryFile != null)
                    Summary.Add("Auxiliary file:", result.AuxiliaryFile.ToString());
                if (result.PackageType != null)
                    Summary.Add("Package type:", result.PackageType.ToString());
                if (result.FamilyId != null)
                    Summary.Add("Product family ID:", result.FamilyId.ToString());
                if (result.DateCode != null)
                    Summary.Add("Date code:", result.DateCode.ToString());
                if (result.FacilityId != null)
                    Summary.Add("Test facility ID:", result.FacilityId.ToString());
                if (result.FloorId != null)
                    Summary.Add("Test floor ID:", result.FloorId.ToString());
                if (result.ProcessId != null)
                    Summary.Add("Fabrication process ID:", result.ProcessId.ToString());
                if (result.OperationFrequency != null)
                    Summary.Add("Operation frequency:", result.OperationFrequency.ToString());
                if (result.SpecificationName != null)
                    Summary.Add("Test specification name:", result.SpecificationName.ToString());
                if (result.SpecificationVersion != null)
                    Summary.Add("Test specification version:", result.SpecificationVersion.ToString());
                if (result.FlowId != null)
                    Summary.Add("Test flow ID:", result.FlowId.ToString());
                if (result.SetupId != null)
                    Summary.Add("Test setup ID:", result.SetupId.ToString());
                if (result.DesignRevision != null)
                    Summary.Add("Device design revision:", result.DesignRevision.ToString());
                if (result.EngineeringId != null)
                    Summary.Add("Engineering lot ID:", result.EngineeringId.ToString());
                if (result.RomCode != null)
                    Summary.Add("ROM code ID:", result.RomCode.ToString());
                if (result.SerialNumber != null)
                    Summary.Add("Tester serial number:", result.SerialNumber.ToString());
                if (result.SupervisorName != null)
                    Summary.Add("Supervisor name:", result.SupervisorName.ToString());
            }
            catch (Exception ex)
            { 
            }
        }
        void UpdateHeadAndSiteNums()
        {
            try
            {
                List<byte> headNums = new List<byte>();
                var results = StdfFile.GetRecords().OfExactType<Sdr>();
                foreach (var result in results)
                {
                    if (!headNums.Contains((byte)result.HeadNumber))
                    {
                        headNums.Add((byte)result.HeadNumber);
                    }
                    SiteNums = result.SiteNumbers;
                }
                HeadNums = headNums.ToArray();
            }
            catch { } 
        }

        void UpdateTestItems()
        {
            var results = StdfFile.GetRecords().OfExactType<Tsr>();
            TestItems = new Dictionary<uint, string>();
            foreach (var result in results)
            {
                try
                {
                    TestItems.Add(result.TestNumber, result.TestName);
                }
                catch { }
            }
        }

        void UpdatePartCount()
        {
            try
            {
                PartCountPerSitePerHead = new Dictionary<byte?, Dictionary<byte?, uint>>();
                foreach (var head in HeadNums)
                {
                    Dictionary<byte?, uint> partCountPerSite = new Dictionary<byte?, uint>();
                    foreach (var site in SiteNums)
                    {
                        uint partCount=0;
                        var result = StdfFile.GetRecords().OfExactType<Pcr>().Where(p=>p.HeadNumber==head&&p.SiteNumber==site).FirstOrDefault();
                    
                            partCount = result.PartCount;
                            TotalCount += result.PartCount;
                            PassedCount+= (uint)result.GoodCount;
                    
                        partCountPerSite.Add(site, partCount);
                    }
                    PartCountPerSitePerHead.Add(head, partCountPerSite);
                }
                TotalYield = (double)PassedCount / TotalCount;
                }
            catch { }
        }
        public void UpdateResults(byte head,byte site,uint testNum)
        {
            var values = StdfFile.GetRecords().OfExactType<Ptr>().Where(p => p.TestNumber == testNum && p.HeadNumber == head && p.SiteNumber == site);
            DataY = new double[PartCountPerSitePerHead[head][site]];
            DataX = new double[PartCountPerSitePerHead[head][site]];
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
                DataY[i] = (double)value.Result * scaling;
                DataX[i] = i;
                i++;
            }
            Unit = PreFixSearch[Scaling]+Unit;
            var stats = new ScottPlot.Statistics.BasicStats(DataY);
            TestNum = testNum;
            Head = head;
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
