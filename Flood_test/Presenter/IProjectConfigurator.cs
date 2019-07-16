
namespace Presenter
{
    public interface IProjectConfigurator
    {
        FloodDataParameters ProjectParameters { get; set; }
        void SaveProject();

        void CreateProject();
    }
}
