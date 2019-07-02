using System;

namespace Presenter
{
    public interface IView
    {
        event Action Compute;

        void Show();
        void ShowResult(string result);
    }
}
