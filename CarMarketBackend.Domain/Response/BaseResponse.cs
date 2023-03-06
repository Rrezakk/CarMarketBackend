using CarMarketBackend.Domain.Enums;

namespace CarMarketBackend.Domain.Response;

public class BaseResponse<T>:IBaseResponse<T>
{
    public string Description { get; set; }//        errors / warnings if was
    public StatusCode StatusCode { get; set; }
    public T Data { get; set; }
}
