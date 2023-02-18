using System;

namespace NandaFest
{
    internal class DllImportAttribute : Attribute
    {
        public string EntryPoint;

        public DllImportAttribute(string v, string EntryPoint)
        {
        }
    }
}