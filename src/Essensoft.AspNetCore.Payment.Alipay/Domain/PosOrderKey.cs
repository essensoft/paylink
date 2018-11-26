using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosOrderKey Data Structure.
    /// </summary>
    [Serializable]
    public class PosOrderKey : AlipayObject
    {
        /// <summary>
        /// pos设备序列号
        /// </summary>
        [JsonProperty("dv_sn")]
        [XmlElement("dv_sn")]
        public string DvSn { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonProperty("merchant_id")]
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 订单版本号
        /// </summary>
        [JsonProperty("order_version")]
        [XmlElement("order_version")]
        public long OrderVersion { get; set; }

        /// <summary>
        /// pos本地的订单号,同一个商户下唯一标识一笔订单的编号。
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
