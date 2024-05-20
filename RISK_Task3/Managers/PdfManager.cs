using RISK_Task3.Classes;

namespace RISK_Task3.Managers
{
    public class PdfManager : GenericsManager<Pdf>
    {
        public PdfManager() : base(
           new List<Pdf>
           {
                new Pdf{ TextOfReport = "This is an pdf file"},
                new Pdf{ TextOfReport = "This is also an pdf file"}
           })
        {
        }
    }
}
