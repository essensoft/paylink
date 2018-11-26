using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPointOrderAddResponse.
    /// </summary>
    public class AlipayPointOrderAddResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝集分宝发放流水号
        /// </summary>
        [JsonProperty("alipay_order_no")]
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 此参数已废弃。
        /// </summary>
        [JsonProperty("result_code")]
        [XmlElement("result_code")]
        public bool ResultCode { get; set; }
    }
}
