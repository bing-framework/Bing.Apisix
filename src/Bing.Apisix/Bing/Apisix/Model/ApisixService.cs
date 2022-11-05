using System.Collections.Generic;

namespace Bing.Apisix.Model;

/// <summary>
/// APISIX 服务编辑信息
/// </summary>
public class ApisixService
{
    /// <summary>
    /// 标识服务名称。可选
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 服务描述、使用场景等。可选
    /// </summary>
    public string Desc { get; set; }

    /// <summary>
    /// 标识附加属性的键值对。可选
    /// </summary>
    public Dictionary<string,string> Labels { get; set; }

}