using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccessProduceQrcode Data Structure.
    /// </summary>
    [Serializable]
    public class AccessProduceQrcode : AlipayObject
    {
        /// <summary>
        /// 口碑码批次号
        /// </summary>
        [JsonProperty("batch_id")]
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 码url
        /// </summary>
        [JsonProperty("core_url")]
        [XmlElement("core_url")]
        public string CoreUrl { get; set; }

        /// <summary>
        /// 生产单号
        /// </summary>
        [JsonProperty("produce_order_id")]
        [XmlElement("produce_order_id")]
        public string ProduceOrderId { get; set; }

        /// <summary>
        /// 二维码编码
        /// </summary>
        [JsonProperty("qrcode")]
        [XmlElement("qrcode")]
        public string Qrcode { get; set; }
    }
}
