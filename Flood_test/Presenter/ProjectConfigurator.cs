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
                Directory.CreateDirectory(ProjectParameters.dirroot);
                File.Copy(ProjectParameters.DEMfile, ProjectParameters.ResultFolder);
                File.Copy(ProjectParameters.bcifile, ProjectParameters.ResultFolder);
                File.Copy(ProjectParameters.bdyfile, ProjectParameters.ResultFolder);
                CreateParamsFile();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        private void CreateParamsFile()
        {
            var file = new StreamWriter(Path.Combine(ProjectParameters.ResultFolder, ProjectParameters.resroot));
            file.WriteLine(FloodDataFormatter.Serialize(ProjectParameters).ToString());
        }

        public void SaveProject()
        {
            //throw new NotImplementedException();
        }
    }
}
