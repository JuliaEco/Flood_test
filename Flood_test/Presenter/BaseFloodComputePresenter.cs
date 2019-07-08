
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

            _view.Compute += () => _service.Compute();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
