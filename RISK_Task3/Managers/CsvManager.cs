using RISK_Task3.Classes;

namespace RISK_Task3.Managers
{
    public class CsvManager : GenericsManager<Csv>
    {
        public CsvManager() : base(
            new List<Csv>
            {
                new Csv{ TextOfReport = "This is an csv file" },
                new Csv{ TextOfReport = "This is also an csv file"}
            }
            )
        {
            
        }
    }
}
