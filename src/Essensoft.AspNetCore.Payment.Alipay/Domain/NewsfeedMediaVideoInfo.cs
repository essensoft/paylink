using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedMediaVideoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaVideoInfo : AlipayObject
    {
        /// <summary>
        /// 高度
        /// </summary>
        [JsonProperty("height")]
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 视频缩略图的ID（支持djangoId）
        /// </summary>
        [JsonProperty("img_id")]
        [XmlElement("img_id")]
        public string ImgId { get; set; }

        /// <summary>
        /// 视频的id（支持djangoId）
        /// </summary>
        [JsonProperty("video_id")]
        [XmlElement("video_id")]
        public string VideoId { get; set; }

        /// <summary>
        /// 宽度
        /// </summary>
        [JsonProperty("width")]
        [XmlElement("width")]
        public string Width { get; set; }
    }
}
