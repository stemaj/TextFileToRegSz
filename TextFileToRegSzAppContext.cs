using System.Windows.Forms;

namespace TextFileToRegSz
{
    class TextFileToRegSzAppContext : ApplicationContext
    {
        public TextFileToRegSzAppContext()
        {
            var form = new Form1();
            var core = new TextFileToRegSzCore();
            new MainFormPresenter(form, core, core);
            form.ShowDialog();
        }
    }
}
