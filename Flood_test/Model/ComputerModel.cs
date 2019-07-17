using Presenter;
using System;
using System.Diagnostics;
using System.IO;

namespace Model
{
    public class ComputerModel : IComputeModel
    {
        private const string SuccessMessage = "Successfully computed";
        private const string UtilityName = "lisfloodRelease_double.exe";
        public string Compute(FloodDataParameters parameters)
        {
           
            if(!File.Exists($"{parameters.Rootdir}\\{UtilityName}"))
            {
                File.Copy($"..\\..\\..\\Computer\\{UtilityName}", $"{parameters.Rootdir}\\{UtilityName}");
            }
            var result = RunComputer(parameters);
            return result;
        }

        private string RunComputer(FloodDataParameters parameters)
        {
            
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                UseShellExecute = false,
                FileName = Path.Combine(parameters.Rootdir, UtilityName),
                WindowStyle = ProcessWindowStyle.Hidden,
                Arguments = $"-v {parameters.ResultFileName}"
            };

            try
            {
                using (var exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                    return SuccessMessage;
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
