using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandBenefitConfirmModel Data Structure.
    /// </summary>
    public class AntMerchantExpandBenefitConfirmModel : AlipayObject
    {
        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [JsonPropertyName("biz_ext")]
        public string BizExt { get; set; }

        /// <summary>
        /// 用户跳转到外部页面1688系统发起的·确认发奖的外部业务时间
        /// </summary>
        [JsonPropertyName("out_biz_time")]
        public string OutBizTime { get; set; }

        /// <summary>
        /// 用户跳转外部1688页面时URL 带的 发放记录·ID
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
