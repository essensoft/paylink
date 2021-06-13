using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoPaysignConfirmModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeZmgoPaysignConfirmModel : AlipayObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 模板关联的appid
        /// </summary>
        [JsonPropertyName("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 签约申请的时候返回的操作单号
        /// </summary>
        [JsonPropertyName("zmgo_opt_no")]
        public string ZmgoOptNo { get; set; }
    }
}
