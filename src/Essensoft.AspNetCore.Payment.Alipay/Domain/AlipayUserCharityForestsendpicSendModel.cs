using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCharityForestsendpicSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCharityForestsendpicSendModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁森林林区ID
        /// </summary>
        [JsonProperty("forest_id")]
        [XmlElement("forest_id")]
        public string ForestId { get; set; }

        /// <summary>
        /// 图片唯一编号，用于幂等控制
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 拍摄图片时的气象信息，包括温度（temperature °C）、湿度（humidity %）、气压（pressure hPa）和光照强度（illumination Lux）等，json格式
        /// </summary>
        [JsonProperty("pic_ext_info")]
        [XmlElement("pic_ext_info")]
        public string PicExtInfo { get; set; }

        /// <summary>
        /// 蚂蚁森林实时图像地址，必须是阿里云地址，包含"aliyun"信息
        /// </summary>
        [JsonProperty("pic_url")]
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片拍摄时间，format: YYYY-MM-DDTHH:MM:SS
        /// </summary>
        [JsonProperty("shoot_time")]
        [XmlElement("shoot_time")]
        public string ShootTime { get; set; }
    }
}
