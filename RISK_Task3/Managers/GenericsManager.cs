using RISK_Task3.Interfaces;

namespace RISK_Task3.Managers
{
    public class GenericsManager<T> : IGenerics<T> where T : IReport, new()
    {
        protected readonly List<T> _report;

        public GenericsManager(List<T> values)
        {
            _report = values;
        }

        public void Add(T report)
        {
            Console.WriteLine($"Report id = {report.Id}, report text = {report.TextOfReport}, report type = {report.TypeOfReport} ");
            _report.Add(report);
            Console.WriteLine($"{report.Id} - {report.TextOfReport}{report.TypeOfReport} - report added. ");
        }

        public IEnumerable<T> GetAll()
        {
            return _report;
        }

        public void Delete(int id)
        {
            _report.RemoveAt(id-1);
            Console.WriteLine($"{id}. report deleted. ");
        }

        public void Update(int id, T report)
        {
            foreach (var updateReport in _report)
            {
                if (updateReport.Id == id)
                {
                    updateReport.TextOfReport = report.TextOfReport;
                    Console.WriteLine($"{id}. report has been updated ");
                    return;
                }

            }
            Console.WriteLine($"{id}. report not found ");

        }
    }
}
