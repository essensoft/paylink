using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertDocVehicleLicense Data Structure.
    /// </summary>
    public class AlipayUserCertDocVehicleLicense : AlipayObject
    {
        /// <summary>
        /// base64编码后的主页照片
        /// </summary>
        [JsonPropertyName("encoded_img_main")]
        public string EncodedImgMain { get; set; }

        /// <summary>
        /// base64编码后的副页照片
        /// </summary>
        [JsonPropertyName("encoded_img_vice")]
        public string EncodedImgVice { get; set; }

        /// <summary>
        /// 发动机号码
        /// </summary>
        [JsonPropertyName("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 发证日期
        /// </summary>
        [JsonPropertyName("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 品牌型号
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }

        /// <summary>
        /// 所有人
        /// </summary>
        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 号牌号码
        /// </summary>
        [JsonPropertyName("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 注册日期
        /// </summary>
        [JsonPropertyName("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 车辆识别代号
        /// </summary>
        [JsonPropertyName("vin")]
        public string Vin { get; set; }
    }
}
