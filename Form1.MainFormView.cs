using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextFileToRegSz
{
    public partial class Form1 : IMainFormView
    {
        public void Init()
        {
            btnOk.Text = OkText(false);
            btnOk.BackColor = Farbe(false);
            btnDatei.Text = @"Bitte Textdatei wählen...";
        }

        public event EventHandler<StringEventArgs> ÄndereSchlüsselname;
        public event EventHandler<StringEventArgs> ÄndereZeichenfolge;
        public event EventHandler LadeDatei;
        public event EventHandler Vollzug;

        public void WähleDatei(ICanTextDateienLesen textDateiKönner)
        {
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
                return;

            ZeichenfolgeWert = textDateiKönner.LeseTextDatei(openFileDialog1.FileName);

            btnDatei.Text = string.IsNullOrEmpty(ZeichenfolgeWert) ? @"Datei nicht gelesen, bitte neu wählen" : openFileDialog1.FileName;
        }

        private bool AlleEingabenGültig()
        {
            if (string.IsNullOrEmpty(Schlüssel))
                return false;
            if (string.IsNullOrEmpty(ZeichenfolgeName))
                return false;
            if (string.IsNullOrEmpty(ZeichenfolgeWert))
                return false;

            return true;
        }

        public void MöglichkeitZumVollzug()
        {
            bool schalter = AlleEingabenGültig();

            btnOk.Enabled = schalter;
            btnOk.Text = OkText(schalter);
            btnOk.BackColor = Farbe(schalter);
        }

        public string Schlüssel { get; set; }
        public string ZeichenfolgeName { get; set; }
        public string ZeichenfolgeWert { get; private set; }

        private Color Farbe(bool schalter)
        {
            return schalter ? Color.LightGreen : Color.LightCoral;
        }

        private string OkText(bool schalter)
        {
            if (schalter)
                return @"Wert Speichern...";
            if (string.IsNullOrEmpty(Schlüssel))
                return @"Der Schlüssel ist ungültig.";
            if (string.IsNullOrEmpty(ZeichenfolgeName))
                return @"Der Name der Zeichenfolge ist ungültig.";
            if (string.IsNullOrEmpty(ZeichenfolgeWert))
                return @"Keine Datei gewählt.";

            return @"warte auf Eingaben...";
        }

        private void textBoxSchlüsselname_TextChanged(object sender, EventArgs e)
        {
            ÄndereSchlüsselname?.Invoke(sender, new StringEventArgs((sender as TextBox)?.Text));
        }

        private void textBoxZeichenfolge_TextChanged(object sender, EventArgs e)
        {
            ÄndereZeichenfolge?.Invoke(sender, new StringEventArgs((sender as TextBox)?.Text));
        }

        private void btnDatei_Click(object sender, EventArgs e)
        {
            LadeDatei?.Invoke(sender, e);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Vollzug?.Invoke(sender, e);
        }
    }
}
