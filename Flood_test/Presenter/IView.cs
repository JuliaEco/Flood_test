using System;

namespace Presenter
{
    public interface IView
    {
        event Action<FloodDataParameters> Compute;

        void Show();
        void ShowResult(string result);
    }
}
