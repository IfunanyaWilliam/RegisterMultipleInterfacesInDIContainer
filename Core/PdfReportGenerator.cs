using RegisterMultipleInterfacesInDIContainer.Interfaces;

namespace RegisterMultipleInterfacesInDIContainer.Core
{
    public class PdfReportGenerator : IPdfReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating pdf ...");
        }
    }
}
