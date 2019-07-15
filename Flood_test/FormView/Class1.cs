using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flood_test
{
    [Serializable]
    public class floodDataParameters
    {
        public string DEMfile;
        public string rootdir;
        public string dirroot;
        public string sim_time;
        public string initial_tstep;
        public string massint;
        public string saveint;
        public string fpfric;
        public string bcifile;
        public string bdyfile;
        public string adaptoff;
        public string sgc_enable;
        public string drycheckon;
        public string elevoff;
        public string max_Froude;

    }
}
