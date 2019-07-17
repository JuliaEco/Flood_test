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
            var newFileName = $"{parameters.ResultFolder}\\{UtilityName}";
            if (!File.Exists(newFileName))
            {
                File.Copy($"..\\..\\..\\Computer\\{UtilityName}", newFileName);
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
                FileName = Path.Combine(parameters.ResultFolder, UtilityName),
                WindowStyle = ProcessWindowStyle.Hidden,
                Arguments = $"-v {parameters.resroot}"
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
