using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppApiSceneQueryResponse.
    /// </summary>
    public class AlipayOpenAppApiSceneQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 接口信息字段应用场景
        /// </summary>
        [JsonPropertyName("auth_field_scene")]
        public List<AuthFieldSceneDTO> AuthFieldScene { get; set; }
    }
}
