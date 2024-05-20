using RISK_Task3.Classes;

namespace RISK_Task3.Managers
{
    public class ExcelManager : GenericsManager<Excel>
    {
        public ExcelManager() : base(
            new List<Excel>
            {
                new Excel{ TextOfReport = "This is an excel file"},
                new Excel{ TextOfReport = "This is also an excel file"}
            })
        {
        }
    }
}
