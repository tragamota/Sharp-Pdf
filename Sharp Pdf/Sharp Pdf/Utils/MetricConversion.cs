namespace Sharp_Pdf.Utils
{
    public enum Metrics
    {
        Mm,
        Cm,
        Dm,
        M
    }
    
    public class MetricConversion : ISizeConverter
    {
        public float ConvertToPoint()
        {
            return 0f;
        }
    }
}