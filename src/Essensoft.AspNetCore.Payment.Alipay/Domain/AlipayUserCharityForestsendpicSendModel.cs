using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCharityForestsendpicSendModel Data Structure.
    /// </summary>
    public class AlipayUserCharityForestsendpicSendModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁森林林区ID
        /// </summary>
        [JsonPropertyName("forest_id")]
        public string ForestId { get; set; }

        /// <summary>
        /// 图片唯一编号，用于幂等控制
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 拍摄图片时的气象信息，包括温度（temperature °C）、湿度（humidity %）、气压（pressure hPa）和光照强度（illumination Lux）等，json格式
        /// </summary>
        [JsonPropertyName("pic_ext_info")]
        public string PicExtInfo { get; set; }

        /// <summary>
        /// 蚂蚁森林实时图像地址，必须是阿里云地址，包含"aliyun"信息
        /// </summary>
        [JsonPropertyName("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片拍摄时间，format: YYYY-MM-DDTHH:MM:SS
        /// </summary>
        [JsonPropertyName("shoot_time")]
        public string ShootTime { get; set; }
    }
}
