using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniModelQueryResponse.
    /// </summary>
    public class AlipayOpenMiniModelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁域小程序核心模型查询接口返回对象，model_type：查询模型类型，records：记录列表
        /// </summary>
        [JsonPropertyName("model_infos")]
        public List<MiniAppModelQueryResponse> ModelInfos { get; set; }
    }
}
