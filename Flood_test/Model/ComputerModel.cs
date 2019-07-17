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
            var newFileName = Path.Combine(parameters.ResultFolder, UtilityName);
            if (!File.Exists(newFileName))
            {
                File.Copy($"../../../Computer/{UtilityName}", newFileName);
            }
            var result = RunComputer(parameters);
            return result;
        }

        private string RunComputer(FloodDataParameters parameters)
        {
            var resultFolder = Path.Combine(parameters.ResultFolder, parameters.resroot);
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                UseShellExecute = false,
                FileName = Path.Combine(parameters.ResultFolder, UtilityName),
                WindowStyle = ProcessWindowStyle.Hidden,
                Arguments = $"-v {resultFolder}"
            };

            try
            {
                using (var exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                    Directory.Move(parameters.dirroot, Path.Combine(parameters.ResultFolder, parameters.dirroot));
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
