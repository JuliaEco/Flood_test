using System;
using System.IO;

namespace Presenter
{
    public class ProjectConfigurator : IProjectConfigurator
    {
        public FloodDataParameters ProjectParameters { get; set; }

        public void CreateProject()
        {
            try
            {
                if(Directory.Exists(ProjectParameters.ResultFolder))
                    Directory.Delete(ProjectParameters.ResultFolder, true);
                Directory.CreateDirectory(ProjectParameters.ResultFolder);
                File.Copy(ProjectParameters.DEMfile, Path.Combine(ProjectParameters.ResultFolder, Path.GetFileName(ProjectParameters.DEMfile)));
                File.Copy(ProjectParameters.bcifile, Path.Combine(ProjectParameters.ResultFolder, Path.GetFileName(ProjectParameters.bcifile)));
                File.Copy(ProjectParameters.bdyfile, Path.Combine(ProjectParameters.ResultFolder, Path.GetFileName(ProjectParameters.bdyfile)));
                CreateParamsFile();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        private void CreateParamsFile()
        {
            var sb = FloodDataFormatter.Serialize(ProjectParameters);
            File.WriteAllText(Path.Combine(ProjectParameters.ResultFolder, ProjectParameters.resroot),
                sb.ToString());
        }

        public void SaveProject()
        {
            //throw new NotImplementedException();
        }
    }
}
