using System;
using FakeItEasy;
using FakeItEasy.Core;
using NUnit.Framework;

namespace TextFileToRegSz
{
    [TestFixture]
    class MainFormPresenterSpecs
    {
        private IMainFormView _view;
        private ICanRegistry _regi;
        private ICanTextDateienLesen _file;

        [OneTimeSetUp]
        public void Setup()
        {
            _view = A.Fake<IMainFormView>();
            _regi = A.Fake<ICanRegistry>();
            _file = A.Fake<ICanTextDateienLesen>();

            new MainFormPresenter(_view, _regi, _file);
        }


        [Test]
        public void Init_Wird_Aufgerufen()
        {
            A.CallTo(() => _view.Init()).MustHaveHappened();
        }

        [Test]
        public void Wenn_Texteingabe_Im_Schlüssel_Soll_Geprüft_Werden_Ob_Dieser_Existiert()
        {
            var sea = new StringEventArgs("irgendwas mit hkeycurrent");

            _view.ÄndereSchlüsselname += Raise.With(sea);

            A.CallTo(() => _regi.PrüfeObGültigerSchlüsselIst(sea.Text)).MustHaveHappened();
        }

        [Test]
        public void Wenn_Datei_Gewählt_Soll_Dessen_Text_Ausgelesen_Werden()
        {
            _view.LadeDatei += Raise.WithEmpty();

            A.CallTo(() => _view.WähleDatei(_file)).MustHaveHappened();

            //A.CallTo(() => _file.LeseTextDatei("")).WithAnyArguments().MustHaveHappened();
        }
    }
}
