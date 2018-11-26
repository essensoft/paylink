using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertAdvSingleVoucherResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertAdvSingleVoucherResponse : AlipayObject
    {
        /// <summary>
        /// 广告内容模型
        /// </summary>
        [JsonProperty("adv_content_list")]
        [XmlArray("adv_content_list")]
        [XmlArrayItem("kb_advert_adv_content_response")]
        public List<KbAdvertAdvContentResponse> AdvContentList { get; set; }

        /// <summary>
        /// 广告内容（广告内容请使用新的属性adv_content_list，此属性仍会保留）
        /// </summary>
        [JsonProperty("content")]
        [XmlElement("content")]
        public KbAdvertAdvContent Content { get; set; }

        /// <summary>
        /// 券标的
        /// </summary>
        [JsonProperty("voucher")]
        [XmlElement("voucher")]
        public KbAdvertSubjectVoucherResponse Voucher { get; set; }
    }
}
