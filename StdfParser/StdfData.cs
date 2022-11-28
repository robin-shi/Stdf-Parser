using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
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
        //public Dictionary<string, string> Summary { get; set; }
        public uint TotalCount { get; set; } = 0;
        public uint PassedCount { get; set; } = 0;
        public double TotalYield { get; set; } = 0;
        public Dictionary<byte,Dictionary<byte, uint>> PartCountPerSitePerHead { get; set; }
        public Dictionary<ushort, string> SoftBins { get; set; }
        public Dictionary<ushort, string> HardBins { get; set; }
        public StringBuilder Summary = new StringBuilder();

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
            UpdateMirInfo();
            UpdateHBinInfo();
            UpdateSBinInfo();
        }

        void UpdateMirInfo()
        {
            var result = StdfFile.GetMir();
            //      $"{"XXXXXXX:",30}"
            try
            {
                Summary.AppendLine("------------------------------------------------------------------------------------------------------------------------------");
                Summary.AppendLine("MIR information:");
                if (result.SetupTime!=null)
                    Summary.AppendLine($"{"Setup time:",-30}"+result.SetupTime.ToString());
                if (result.StartTime != null)
                    Summary.AppendLine($"{"Start time:",-30}" + result.StartTime.ToString());
           
                    Summary.AppendLine($"{"Tester station number:",-30}" + result.StationNumber.ToString());//int always not null
                if (result.ModeCode != null)
                    Summary.AppendLine($"{"Test mode code:",-30}" + result.ModeCode.ToString());
                if (result.RetestCode != null)
                    Summary.AppendLine($"{"Lot retest code:",-30}" + result.RetestCode.ToString());
                if (result.ProtectionCode != null)
                    Summary.AppendLine($"{"Data protection code:",-30}" + result.ProtectionCode.ToString());
                if (result.BurnInTime != null)
                    Summary.AppendLine($"{"Burn-in time:",-30}" + result.BurnInTime.ToString());
                if (result.CommandModeCode != null)
                    Summary.AppendLine($"{"Command mode code:",-30}" + result.CommandModeCode.ToString());
                if (result.LotId != null)
                    Summary.AppendLine($"{"Lot ID:",-30}" + result.LotId.ToString());
                if (result.PartType != null)
                    Summary.AppendLine($"{"Part type:",-30}" + result.PartType.ToString());
                if (result.NodeName != null)
                    Summary.AppendLine($"{"Node name:",-30}" + result.NodeName.ToString());
                if (result.TesterType != null)
                    Summary.AppendLine($"{"Tester type:",-30}" + result.TesterType.ToString());
                if (result.JobName != null)
                    Summary.AppendLine($"{"Program name:",-30}" + result.JobName.ToString());
                if (result.JobRevision != null)
                    Summary.AppendLine($"{"Program revision:",-30}" + result.JobRevision.ToString());
                if (result.SublotId != null)
                    Summary.AppendLine($"{"Sublot ID:",-30}" + result.SublotId.ToString());
                if (result.OperatorName != null)
                    Summary.AppendLine($"{"Operator name:",-30}" + result.OperatorName.ToString());
                if (result.ExecType != null)
                    Summary.AppendLine($"{"Tester software type:",-30}" + result.ExecType.ToString());
                if (result.ExecVersion != null)
                    Summary.AppendLine($"{"Tester software version:",-30}" + result.ExecVersion.ToString());
                if (result.TestCode != null)
                    Summary.AppendLine($"{"Test code:",-30}" + result.TestCode.ToString());
                if (result.TestTemperature != null)
                    Summary.AppendLine($"{"Test temperature:",-30}" + result.TestTemperature.ToString());
                if (result.UserText != null)
                    Summary.AppendLine($"{"User text:",-30}" + result.UserText.ToString());
                if (result.AuxiliaryFile != null)
                    Summary.AppendLine($"{"Auxiliary file:",-30}" + result.AuxiliaryFile.ToString());
                if (result.PackageType != null)
                    Summary.AppendLine($"{"Package type:",-30}" + result.PackageType.ToString());
                if (result.FamilyId != null)
                    Summary.AppendLine($"{"Product family ID:",-30}" + result.FamilyId.ToString());
                if (result.DateCode != null)
                    Summary.AppendLine($"{"Date code:",-30}" + result.DateCode.ToString());
                if (result.FacilityId != null)
                    Summary.AppendLine($"{"Test facility ID:",-30}" + result.FacilityId.ToString());
                if (result.FloorId != null)
                    Summary.AppendLine($"{"Test floor ID:",-30}" + result.FloorId.ToString());
                if (result.ProcessId != null)
                    Summary.AppendLine($"{"Fabrication process ID:",-30}" + result.ProcessId.ToString());
                if (result.OperationFrequency != null)
                    Summary.AppendLine($"{"Operation frequency:",-30}" + result.OperationFrequency.ToString());
                if (result.SpecificationName != null)
                    Summary.AppendLine($"{"Test specification name:",-30}" + result.SpecificationName.ToString());
                if (result.SpecificationVersion != null)
                    Summary.AppendLine($"{"Test specification version:",-30}" + result.SpecificationVersion.ToString());
                if (result.FlowId != null)
                    Summary.AppendLine($"{"Test flow ID:",-30}" + result.FlowId.ToString());
                if (result.SetupId != null)
                    Summary.AppendLine($"{"Test setup ID:",-30}" + result.SetupId.ToString());
                if (result.DesignRevision != null)
                    Summary.AppendLine($"{"Device design revision:",-30}" + result.DesignRevision.ToString());
                if (result.EngineeringId != null)
                    Summary.AppendLine($"{"Engineering lot ID:",-30}" + result.EngineeringId.ToString());
                if (result.RomCode != null)
                    Summary.AppendLine($"{"ROM code ID:",-30}" + result.RomCode.ToString());
                if (result.SerialNumber != null)
                    Summary.AppendLine($"{"Tester serial number:",-30}" + result.SerialNumber.ToString());
                if (result.SupervisorName != null)
                    Summary.AppendLine($"{"Supervisor name:",-30}" + result.SupervisorName.ToString());
            }
            catch (Exception ex)
            { 
            }
        }

        void UpdateHBinInfo()
        {
            foreach (var head in HeadNums)
            {
                Summary.AppendLine("------------------------------------------------------------------------------------------------------------------------------");
                Summary.AppendLine($"Head{head} Hard Bin Statistics:");
                HardBins = new Dictionary<ushort, string>();
                uint totalCount = 0;
                var results = StdfFile.GetRecords().OfExactType<Hbr>().Where(p => p.BinCount != 0);
                foreach (var result in results)
                {
                    try
                    {
                        HardBins.Add(result.BinNumber, result.BinName);
                    }
                    catch { }
                }
                Summary.Append($"{"Bin Num",-10}{"Bin Name",-30}     Sites:All");
                foreach (var site in SiteNums)
                {
                    Summary.Append($"         Site:{site}   ");
                    totalCount += PartCountPerSitePerHead[head][site];
                }
                Summary.AppendLine();
                foreach (var hardBin in HardBins)
                {
                    Summary.Append($"{hardBin.Key,-10}{hardBin.Value,-30}");
                    var result = StdfFile.GetRecords().OfExactType<Hbr>().Where(p => p.HeadNumber == 255 && p.BinNumber == hardBin.Key).FirstOrDefault();
                    Summary.Append($"{result.BinCount,10}|{result.BinCount * 100.0 / totalCount,5:f2}%");
                    foreach (var site in SiteNums)
                    {
                        result = StdfFile.GetRecords().OfExactType<Hbr>().Where(p => p.HeadNumber != 255 && p.SiteNumber == site && p.BinNumber == hardBin.Key).FirstOrDefault();
                        Summary.Append($"{result.BinCount,10}|{result.BinCount * 100.0 / PartCountPerSitePerHead[head][site],6:f2}%");
                    }
                    Summary.AppendLine();
                }
            }
            
        }
        void UpdateSBinInfo()
        {
            foreach (var head in HeadNums)
            {
                Summary.AppendLine("------------------------------------------------------------------------------------------------------------------------------");
                Summary.AppendLine($"Head{head} Soft Bin Statistics:");
                SoftBins = new Dictionary<ushort, string>();
                uint totalCount = 0;
                var results = StdfFile.GetRecords().OfExactType<Sbr>().Where(p => p.BinCount != 0);
                foreach (var result in results)
                {
                    try
                    {
                        SoftBins.Add(result.BinNumber, result.BinName);
                    }
                    catch { }
                }
                Summary.Append($"{"Bin Num",-10}{"Bin Name",-30}     Sites:All");
                foreach (var site in SiteNums)
                {
                    Summary.Append($"         Site:{site}   ");
                    totalCount += PartCountPerSitePerHead[head][site];
                }
                Summary.AppendLine();
                foreach (var softBin in SoftBins)
                {
                    Summary.Append($"{softBin.Key,-10}{softBin.Value,-30}");
                    var result = StdfFile.GetRecords().OfExactType<Sbr>().Where(p => p.HeadNumber == 255 && p.BinNumber == softBin.Key).FirstOrDefault();
                    Summary.Append($"{result.BinCount,10}|{result.BinCount * 100.0 / totalCount,5:f2}%");
                    foreach (var site in SiteNums)
                    {
                        result = StdfFile.GetRecords().OfExactType<Sbr>().Where(p => p.HeadNumber != 255 && p.SiteNumber == site && p.BinNumber == softBin.Key).FirstOrDefault();
                        Summary.Append($"{result.BinCount,10}|{result.BinCount * 100.0 / PartCountPerSitePerHead[head][site],6:f2}%");
                    }
                    Summary.AppendLine();
                }
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
                PartCountPerSitePerHead = new Dictionary<byte, Dictionary<byte, uint>>();
                foreach (var head in HeadNums)
                {
                    Dictionary<byte, uint> partCountPerSite = new Dictionary<byte, uint>();
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
