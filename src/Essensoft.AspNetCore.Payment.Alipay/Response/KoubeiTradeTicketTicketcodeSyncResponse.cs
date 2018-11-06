using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeSyncResponse.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 该字段用于描述本次返回中的业务属性，现有：BIZ_ALREADY_SUCCESS（幂等业务码）
        /// </summary>
        [JsonProperty("biz_code")]
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 凭证码所属的订单id
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部请求号，支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [JsonProperty("request_id")]
        [XmlArray("request_id")]
        [XmlArrayItem("string")]
        public List<string> RequestId { get; set; }
    }
}
