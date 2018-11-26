using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseIdpdrivenSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseIdpdrivenSendModel : AlipayObject
    {
        /// <summary>
        /// 参数名：asset_id 是否唯一：不唯一 应用场景：用于对应IDP中相关的资产id 如何获取：由开发小二配置后分配
        /// </summary>
        [JsonProperty("asset_id")]
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 参数名：data 是否唯一：不唯一 应用场景：用于数据触发的参数信息，具体参数内容与开发小二约定 如何获取：商户的触发事件业务信息，通过文档约定字段
        /// </summary>
        [JsonProperty("data")]
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 参数名：data_time 是否唯一：不唯一 应用场景：用于判断用户触发事件真实时间 如何获取：外部商户系统中用户触发事件的系统时间
        /// </summary>
        [JsonProperty("data_time")]
        [XmlElement("data_time")]
        public long DataTime { get; set; }
    }
}
