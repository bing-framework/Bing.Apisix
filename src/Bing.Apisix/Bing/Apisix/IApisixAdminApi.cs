using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace Bing.Apisix;

/// <summary>
/// Apisix 的后台管理接口
/// </summary>
[Timeout(1000)]
public interface IApisixAdminApi : IHttpApi
{

}