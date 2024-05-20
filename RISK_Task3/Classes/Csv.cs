using RISK_Task3.Interfaces;

namespace RISK_Task3.Classes
{
    public class Csv : IReport
    {
        private static int nextId = 1;
        public Csv()
        {
            TypeOfReport = ".csv";
            Id = nextId++;
        }
        public int Id { get; set; }
        public string TextOfReport { get; set; }
        public string TypeOfReport { get; set; }
        
    }
}
