using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopApplyorderCancelResponse.
    /// </summary>
    public class AlipayOfflineMarketShopApplyorderCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 申请撤销成功接口同步返回的支付宝申请流水号。
        /// </summary>
        [JsonProperty("apply_id")]
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
