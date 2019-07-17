
using System;

namespace Presenter
{
    public class BaseFloodComputePresenter : IPresenter
    {
        private readonly IView _view;
        private readonly IComputeModel _service;
        private IProjectConfigurator _configurator;

        public BaseFloodComputePresenter(IView view, IComputeModel service)
        {
            _view = view;
            _service = service;

            _view.Compute += (FloodDataParameters parameters) => Compute(parameters);
        }
        public void Run(IProjectConfigurator configurator)
        {
            _configurator = configurator;
            _view.Show();
        }

        private void Compute(FloodDataParameters parameters)
        {
            try
            {
                _configurator.ProjectParameters = parameters;
                _configurator.CreateProject();
                var result = _service.Compute(parameters);
                _view.ShowResult(result);
            } catch(Exception ex)
            {
                _view.ShowResult(ex.Message);
            }
        }
    }
}
