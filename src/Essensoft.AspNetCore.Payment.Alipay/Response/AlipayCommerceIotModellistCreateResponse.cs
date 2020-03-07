using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotModellistCreateResponse.
    /// </summary>
    public class AlipayCommerceIotModellistCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 重复的型号id列表，当所请求创建的型号已经存在时，则将已存在的型号id列表通过该字段返回
        /// </summary>
        [JsonPropertyName("duplicated_model_ids")]
        public List<string> DuplicatedModelIds { get; set; }
    }
}
