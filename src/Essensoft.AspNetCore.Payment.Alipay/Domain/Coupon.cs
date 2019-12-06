using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Coupon Data Structure.
    /// </summary>
    public class Coupon : AlipayObject
    {
        /// <summary>
        /// 当前可用面额
        /// </summary>
        [JsonPropertyName("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 红包编号
        /// </summary>
        [JsonPropertyName("coupon_no")]
        public string CouponNo { get; set; }

        /// <summary>
        /// 可优惠面额
        /// </summary>
        [JsonPropertyName("deduct_amount")]
        public string DeductAmount { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [JsonPropertyName("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 有效期结束时间
        /// </summary>
        [JsonPropertyName("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 红包使用说明
        /// </summary>
        [JsonPropertyName("instructions")]
        public string Instructions { get; set; }

        /// <summary>
        /// 红包详情说明
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("merchant_uniq_id")]
        public string MerchantUniqId { get; set; }

        /// <summary>
        /// 是否可叠加
        /// </summary>
        [JsonPropertyName("multi_use_flag")]
        public string MultiUseFlag { get; set; }

        /// <summary>
        /// 红包名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否可退款标识
        /// </summary>
        [JsonPropertyName("refund_flag")]
        public string RefundFlag { get; set; }

        /// <summary>
        /// 红包状态信息
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 红包模板编号
        /// </summary>
        [JsonPropertyName("template_no")]
        public string TemplateNo { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
