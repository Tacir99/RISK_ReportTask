namespace RISK_Task3.Interfaces
{
    public interface IReport
    {
        public int Id { get; set; }
        public string TextOfReport { get; set; }
        public string TypeOfReport { get; set; }
    }
}
