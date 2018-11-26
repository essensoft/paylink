using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherTemplateLiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherTemplateLiteInfo : AlipayObject
    {
        /// <summary>
        /// 模板激活时间。草稿状态的模板该项为空
        /// </summary>
        [JsonProperty("activate_time")]
        [XmlElement("activate_time")]
        public string ActivateTime { get; set; }

        /// <summary>
        /// 模板创建时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("create_time")]
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 发放结束时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("publish_end_time")]
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券模板发放开始时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("publish_start_time")]
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 模板状态，可枚举。分别为‘草稿’(I)、‘生效’(S)和‘过期’(E)
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonProperty("template_id")]
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonProperty("voucher_name")]
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }
    }
}
