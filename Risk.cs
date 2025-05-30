
namespace RiskManagementAPI.Models
{
    public class Risk
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Likelihood { get; set; }
        public string Impact { get; set; }
        public string ControlMeasures { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
