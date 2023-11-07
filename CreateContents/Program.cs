using CreateContents.Controller;
using CreateContents.Model;
using CreateContents.View;

namespace CreateContents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyModel model = new MyModel(args);
            MyView view = new MyView();
            MyController controller = new MyController(model, view);
            controller.CreateMarkDownFile();
        }
    }
}
