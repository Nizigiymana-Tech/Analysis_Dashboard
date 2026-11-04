namespace AnalysisDashboard.Services
{
    public class CsvDataService
    {
        public string CsvContent { get; private set; } = "";

        public void SetCsvContent(string content)
        {
            CsvContent = content;
        }
    }
}