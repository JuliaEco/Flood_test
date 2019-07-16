using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class ProjectConfigurator : IProjectConfigurator
    {
        public FloodDataParameters ProjectParameters { get; set; }

        public void CreateProject()
        {
            try
            {
                if (!Directory.Exists(ProjectParameters.Rootdir))
                    Directory.CreateDirectory(ProjectParameters.Rootdir);
                File.Copy(ProjectParameters.DEMfile, ProjectParameters.Rootdir);
                File.Copy(ProjectParameters.BciFileName, ProjectParameters.Rootdir);
                File.Copy(ProjectParameters.BdyFileName, ProjectParameters.Rootdir);
                CreateParamsFile();
            }
            catch
            {
                throw;
            }

        }

        private void CreateParamsFile()
        {
            var file = new StreamWriter(Path.Combine(ProjectParameters.Rootdir, ProjectParameters.ResultFileName));
            file.WriteLine(FloodDataFormatter.Serialize(ProjectParameters).ToString());
        }

        public void SaveProject()
        {
            //throw new NotImplementedException();
        }
    }
}
