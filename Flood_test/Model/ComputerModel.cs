using Presenter;
using System;
using System.Diagnostics;

namespace Model
{
    public class ComputerModel : IComputeModel
    {
        private string SuccessMessage = "Successfully computed";
        public string Compute()
        {
            var result = RunComputer();
            return result;
            //throw new NotImplementedException();
        }

        private string RunComputer()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                UseShellExecute = false,
                FileName = "..\\..\\..\\Computer\\11lisfloodRelease_double.exe",
                WindowStyle = ProcessWindowStyle.Hidden
            };
            //startInfo.Arguments = "-f j -o \"" + ex1 + "\" -z 1.0 -s y " + ex2;

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
