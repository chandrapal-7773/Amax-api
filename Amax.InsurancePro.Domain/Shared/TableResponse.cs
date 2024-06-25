namespace Amax.InsurancePro.Domain.Shared;

public class TableResponse<T> where T : class
{
    public TableResponse(List<T> data, int totalCount, int filtered, int start=0, int length=int.MaxValue)
    {
        Data = new List<T>(data);
        Start = start;
        Length = length;
        RecordsTotal = totalCount;
        RecordsFiltered = totalCount;
    }

    public List<T> Data { get; }

    public int RecordsTotal { get; set; }
    public int RecordsFiltered { get; set; }

    public int Start { get; set; }
    public int Length { get; set; }

}