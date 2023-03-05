using RegisterMultipleInterfacesInDIContainer.Interfaces;

namespace RegisterMultipleInterfacesInDIContainer.Core
{
    public class ReportManager : IReportGenerator
    {
        private readonly IExcelReportGenerator _excelReportGenerator;
        private readonly IPdfReportGenerator _pdfReportGenerator;

        public ReportManager(IExcelReportGenerator excelReportGenerator,
                             IPdfReportGenerator pdfReportGenerator)
        {
            _excelReportGenerator = excelReportGenerator;
            _pdfReportGenerator = pdfReportGenerator;
        }
        public void GenerateReport()
        {
            _excelReportGenerator.GenerateReport();
            _pdfReportGenerator.GenerateReport();
        }
    }
}
