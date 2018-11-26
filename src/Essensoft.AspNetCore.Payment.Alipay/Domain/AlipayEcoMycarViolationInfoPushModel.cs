using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarViolationInfoPushModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarViolationInfoPushModel : AlipayObject
    {
        /// <summary>
        /// 1:可在线处理, 2:不可在线处理, 3:需查询确定
        /// </summary>
        [JsonProperty("deal_type")]
        [XmlElement("deal_type")]
        public string DealType { get; set; }

        /// <summary>
        /// 暂无
        /// </summary>
        [JsonProperty("push_type")]
        [XmlElement("push_type")]
        public string PushType { get; set; }

        /// <summary>
        /// 违章地点
        /// </summary>
        [JsonProperty("vi_address")]
        [XmlElement("vi_address")]
        public string ViAddress { get; set; }

        /// <summary>
        /// 违章罚款金额
        /// </summary>
        [JsonProperty("vi_fine")]
        [XmlElement("vi_fine")]
        public string ViFine { get; set; }

        /// <summary>
        /// 是否已处理, 0:已处理，1:未处理
        /// </summary>
        [JsonProperty("vi_handled")]
        [XmlElement("vi_handled")]
        public string ViHandled { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("vi_number")]
        [XmlElement("vi_number")]
        public string ViNumber { get; set; }

        /// <summary>
        /// 违章扣分
        /// </summary>
        [JsonProperty("vi_point")]
        [XmlElement("vi_point")]
        public string ViPoint { get; set; }

        /// <summary>
        /// 违章时间(yyyyMMddhhmmss)
        /// </summary>
        [JsonProperty("vi_time")]
        [XmlElement("vi_time")]
        public string ViTime { get; set; }

        /// <summary>
        /// 违章行为
        /// </summary>
        [JsonProperty("vi_type")]
        [XmlElement("vi_type")]
        public string ViType { get; set; }
    }
}
