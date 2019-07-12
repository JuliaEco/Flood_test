
namespace Presenter
{
    public class BaseFloodComputePresenter : IPresenter
    {
        private readonly IView _view;
        private readonly IComputeModel _service;

        public BaseFloodComputePresenter(IView view, IComputeModel service)
        {
            _view = view;
            _service = service;

            _view.Compute += () => Compute();
        }
        public void Run()
        {
            _view.Show();
        }

        private void Compute()
        {
            var result = _service.Compute();
            _view.ShowResult(result);
        }
    }
}
