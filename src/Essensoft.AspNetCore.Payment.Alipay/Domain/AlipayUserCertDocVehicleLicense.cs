using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertDocVehicleLicense Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertDocVehicleLicense : AlipayObject
    {
        /// <summary>
        /// base64编码后的主页照片
        /// </summary>
        [JsonProperty("encoded_img_main")]
        public string EncodedImgMain { get; set; }

        /// <summary>
        /// base64编码后的副页照片
        /// </summary>
        [JsonProperty("encoded_img_vice")]
        public string EncodedImgVice { get; set; }

        /// <summary>
        /// 发动机号码
        /// </summary>
        [JsonProperty("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 发证日期
        /// </summary>
        [JsonProperty("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 品牌型号
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        /// <summary>
        /// 所有人
        /// </summary>
        [JsonProperty("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 号牌号码
        /// </summary>
        [JsonProperty("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 注册日期
        /// </summary>
        [JsonProperty("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 车辆识别代号
        /// </summary>
        [JsonProperty("vin")]
        public string Vin { get; set; }
    }
}
