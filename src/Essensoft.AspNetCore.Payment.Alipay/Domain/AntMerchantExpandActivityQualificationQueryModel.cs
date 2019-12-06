using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandActivityQualificationQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandActivityQualificationQueryModel : AlipayObject
    {
        /// <summary>
        /// 商家活动平台活动编码
        /// </summary>
        [JsonPropertyName("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [JsonPropertyName("biz_ext")]
        public string BizExt { get; set; }

        /// <summary>
        /// 外部业务时间
        /// </summary>
        [JsonPropertyName("out_biz_time")]
        public string OutBizTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
