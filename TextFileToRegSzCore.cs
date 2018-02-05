using Microsoft.Win32;

namespace TextFileToRegSz
{
    internal class TextFileToRegSzCore : ICanTextDateienLesen, ICanRegistry
    {
        public string LeseTextDatei(string pfad)
        {
            return System.IO.File.ReadAllText(pfad);
        }

        public bool PrüfeObGültigerSchlüsselIst(string value)
        {
            RegistryKey key = null;
            if (value.Contains("HKEY_CLASSES_ROOT\\"))
            {
                value = value.Replace("HKEY_CLASSES_ROOT\\", "");
                key = Registry.ClassesRoot.OpenSubKey(value, true);
            }
            if (value.Contains("HKEY_CURRENT_USER\\"))
            {
                value = value.Replace("HKEY_CURRENT_USER\\", "");
                key = Registry.CurrentUser.OpenSubKey(value, true);
            }
            if (value.Contains("HKEY_LOCAL_MACHINE\\"))
            {
                value = value.Replace("HKEY_LOCAL_MACHINE\\", "");
                key = Registry.LocalMachine.OpenSubKey(value, true);
            }
            if (value.Contains("HKEY_USERS\\"))
            {
                value = value.Replace("HKEY_USERS\\", "");
                key = Registry.Users.OpenSubKey(value, true);
            }
            if (value.Contains("HKEY_CURRENT_CONFIG\\"))
            {
                value = value.Replace("HKEY_CURRENT_CONFIG\\", "");
                key = Registry.CurrentConfig.OpenSubKey(value, true);
            }

            return key != null;
        }

        public void Schreibe(string schlüssel, string name, string wert)
        {
            Registry.SetValue(schlüssel, name, wert);
        }
    }
}