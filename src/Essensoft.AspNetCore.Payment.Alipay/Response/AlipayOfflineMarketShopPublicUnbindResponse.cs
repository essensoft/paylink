using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopPublicUnbindResponse.
    /// </summary>
    public class AlipayOfflineMarketShopPublicUnbindResponse : AlipayResponse
    {
        /// <summary>
        /// 绑定失败的店铺ID列表,绑定失败原因可能是：a)检测到shop_id不存在;b)检测到shop_id不属于当前商户；c）该门店ID已经绑定服务窗
        /// </summary>
        [JsonProperty("error_un_binding_shop_ids")]
        [XmlArray("error_un_binding_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ErrorUnBindingShopIds { get; set; }

        /// <summary>
        /// 总的基础绑定错误数
        /// </summary>
        [JsonProperty("total_error")]
        [XmlElement("total_error")]
        public long TotalError { get; set; }

        /// <summary>
        /// 总的解除绑定成功数
        /// </summary>
        [JsonProperty("total_success")]
        [XmlElement("total_success")]
        public long TotalSuccess { get; set; }
    }
}
