using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieEditorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieEditorQueryModel : AlipayObject
    {
        /// <summary>
        /// 凤蝶H5应用唯一id，通过alipay.marketing.tool.fengdie.activity.create接口时自动生成
        /// </summary>
        [JsonProperty("activity_id")]
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 在凤蝶编辑器中点击“发布”按钮后，如果发布成功则跳转到该地址
        /// </summary>
        [JsonProperty("redirect_url")]
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
