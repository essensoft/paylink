using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardBinVO Data Structure.
    /// </summary>
    [Serializable]
    public class CardBinVO : AlipayObject
    {
        /// <summary>
        /// 卡的别名
        /// </summary>
        [JsonProperty("card_alias")]
        [XmlElement("card_alias")]
        public string CardAlias { get; set; }

        /// <summary>
        /// 卡bin值，通常为卡号的前6位
        /// </summary>
        [JsonProperty("card_bin_value")]
        [XmlElement("card_bin_value")]
        public string CardBinValue { get; set; }

        /// <summary>
        /// 卡类型对象定义
        /// </summary>
        [JsonProperty("card_type_vo")]
        [XmlElement("card_type_vo")]
        public CardTypeVO CardTypeVo { get; set; }

        /// <summary>
        /// 卡域模型定义
        /// </summary>
        [JsonProperty("domain_vo")]
        [XmlElement("domain_vo")]
        public CardDomainVO DomainVo { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [JsonProperty("inst_id")]
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 卡号长度
        /// </summary>
        [JsonProperty("inst_len")]
        [XmlElement("inst_len")]
        public string InstLen { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonProperty("operator")]
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 卡版本信息
        /// </summary>
        [JsonProperty("version")]
        [XmlElement("version")]
        public string Version { get; set; }
    }
}
