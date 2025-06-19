using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaintenance.Model
{
    public class PrintDocumentEventArgs : EventArgs
    {
        public PrintDocument PrintDocument { get; }

        public PrintDocumentEventArgs(PrintDocument printDocument)
        {
            PrintDocument = printDocument;
        }
    }
}
