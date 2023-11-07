using CreateContents.Model;
using CreateContents.View;

namespace CreateContents.Controller
{
    internal class MyController
    {
        private readonly MyModel _model;
        private readonly MyView _view;
        public MyController(MyModel model, MyView view)
        {
            _model = model;
            _view = view;
        }
        public void CreateMarkDownFile()
        {
            _model.CreateLines();
            _view.CreateMarkDownFile(_model.DirPath, _model.Lines);
        }
    }
}
