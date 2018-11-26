using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorDepositQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorDepositQueryModel : AlipayObject
    {
        /// <summary>
        /// 交通卡号
        /// </summary>
        [JsonProperty("card_no")]
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 和渠道定义的卡类型，一个城市支持一种卡类型
        /// </summary>
        [JsonProperty("card_type")]
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// transfer：待圈存 success：圈存成功 fail：圈存失败
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
