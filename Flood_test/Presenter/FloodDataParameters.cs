using System;

namespace Presenter
{
    [Serializable]
    public class FloodDataParameters
    {
        public string DEMfile { get; set; }
        public string Rootdir { get; set; }
        public string ResultFileName { get; set; }
        public string SimTime { get; set; }
        public string InitialTStep { get; set; }
        public string MassInt { get; set; }
        public string SaveInt { get; set; }
        public string Fpfric { get; set; }
        public string BciFileName { get; set; }
        public string BdyFileName { get; set; }
        public bool AdaptOff { get; set; }
        public bool SgcEnable { get; set; }
        public bool DryCheckOn { get; set; }
        public bool ElevOff { get; set; }
        public string MaxFroude { get; set; }

        public FloodDataParameters()
        {
        }

        public FloodDataParameters(string dEMfile, string rootdir, string dirroot, 
            string simTime, string initialTStep, string massInt, string saveInt, 
            string fpfric, string bciFileName, string bdyFileName, bool adaptOff, 
            bool sgcEnable, bool dryCheckOn, bool elevOff, string maxFroude)
        {
            DEMfile = dEMfile;
            Rootdir = rootdir;
            ResultFileName = dirroot;
            SimTime = simTime;
            InitialTStep = initialTStep;
            MassInt = massInt;
            SaveInt = saveInt;
            Fpfric = fpfric;
            BciFileName = bciFileName;
            BdyFileName = bdyFileName;
            AdaptOff = adaptOff;
            SgcEnable = sgcEnable;
            DryCheckOn = dryCheckOn;
            ElevOff = elevOff;
            MaxFroude = maxFroude;
        }
    }
}
