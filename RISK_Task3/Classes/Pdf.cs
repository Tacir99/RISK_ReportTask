using RISK_Task3.Interfaces;

namespace RISK_Task3.Classes
{
    public class Pdf : IReport
    {
        private static int nextId = 1;
        public Pdf()
        {
            TypeOfReport = ".pdf";
            Id = nextId++;
        }
        public int Id { get; set; }
        public string TextOfReport { get; set; }
        public string TypeOfReport { get; set; }
    }
}
