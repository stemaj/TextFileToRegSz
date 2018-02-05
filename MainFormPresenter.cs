namespace TextFileToRegSz
{
    internal class MainFormPresenter
    {
        public MainFormPresenter(IMainFormView view, ICanRegistry registryKönner, ICanTextDateienLesen textDateiKönner)
        {
            view.ÄndereSchlüsselname += (sender, args) =>
            {
                view.Schlüssel = registryKönner.PrüfeObGültigerSchlüsselIst(args.Text) ? args.Text : string.Empty;
                view.MöglichkeitZumVollzug();
            };

            view.ÄndereZeichenfolge += (sender, args) =>
            {
                view.ZeichenfolgeName = args.Text;
                view.MöglichkeitZumVollzug();
            };

            view.LadeDatei += (sender, args) =>
            {
                view.WähleDatei(textDateiKönner);
                view.MöglichkeitZumVollzug();
            };

            view.Vollzug += (sender, args) =>
            {
                registryKönner.Schreibe(view.Schlüssel, view.ZeichenfolgeName, view.ZeichenfolgeWert);
            };

            view.Init();
        }
    }
}