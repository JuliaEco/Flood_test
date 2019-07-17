using System;

namespace Presenter
{
    [Serializable]
    public class FloodDataParameters
    {
        public string DEMfile { get; set; }
        public string resroot  { get; set; }
        public string ResultFolder { get; set; }
        public string sim_time { get; set; }
        public string initial_tstep { get; set; }
        public string massint { get; set; }
        public string saveint { get; set; }
        public string fpfric { get; set; }
        public string bcifile { get; set; }
        public string bdyfile { get; set; }
        public bool adaptoff { get; set; }
        public bool sgc_enable { get; set; }
        public bool drycheckon { get; set; }
        public bool elevoff { get; set; }
        public string max_Froude { get; set; }

        public string dirroot { get; set; } = "result_folder";

        public FloodDataParameters()
        {
        }

        public FloodDataParameters(string dEMfile, string rootdir, string dirroot, 
            string simTime, string initialTStep, string massInt, string saveInt, 
            string fpfric, string bciFileName, string bdyFileName, bool adaptOff, 
            bool sgcEnable, bool dryCheckOn, bool elevOff, string maxFroude)
        {
            DEMfile = dEMfile;
            resroot = rootdir;
            this.ResultFolder = dirroot;
            sim_time = simTime;
            initial_tstep = initialTStep;
            massint = massInt;
            saveint = saveInt;
            this.fpfric = fpfric;
            bcifile = bciFileName;
            bdyfile = bdyFileName;
            adaptoff = adaptOff;
            sgc_enable = sgcEnable;
            drycheckon = dryCheckOn;
            elevoff = elevOff;
            max_Froude = maxFroude;
        }
    }
}
