using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingIotBoothQueryResponse.
    /// </summary>
    public class AlipayMarketingIotBoothQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用于链路埋点，识别权益触发链路
        /// </summary>
        [JsonPropertyName("booth_token")]
        public string BoothToken { get; set; }

        /// <summary>
        /// 展位结果列表
        /// </summary>
        [JsonPropertyName("content_list")]
        public List<IotContentModuleInfo> ContentList { get; set; }

        /// <summary>
        /// 渲染引擎类型
        /// </summary>
        [JsonPropertyName("engine_type")]
        public string EngineType { get; set; }

        /// <summary>
        /// 展位可用性结果，描述当前入参是否存在可用展位
        /// </summary>
        [JsonPropertyName("usable")]
        public bool Usable { get; set; }
    }
}
