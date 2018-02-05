using System;

namespace TextFileToRegSz
{
    public interface IMainFormView
    {
        void Init();
        event EventHandler<StringEventArgs> ÄndereSchlüsselname;
        event EventHandler<StringEventArgs> ÄndereZeichenfolge;
        event EventHandler LadeDatei;
        event EventHandler Vollzug;
        void WähleDatei(ICanTextDateienLesen textDateiKönner);
        void MöglichkeitZumVollzug();
        string Schlüssel { get; set; }
        string ZeichenfolgeName { get; set; }
        string ZeichenfolgeWert { get; }
    }
}
