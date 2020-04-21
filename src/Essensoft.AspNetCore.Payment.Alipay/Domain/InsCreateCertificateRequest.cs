using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsCreateCertificateRequest Data Structure.
    /// </summary>
    public class InsCreateCertificateRequest : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 保险凭证类型
        /// </summary>
        [JsonPropertyName("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonPropertyName("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 面值
        /// </summary>
        [JsonPropertyName("face_value")]
        public string FaceValue { get; set; }

        /// <summary>
        /// 电子保单号
        /// </summary>
        [JsonPropertyName("ins_policy_no")]
        public string InsPolicyNo { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [JsonPropertyName("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 拥有人uid
        /// </summary>
        [JsonPropertyName("owner_uid")]
        public string OwnerUid { get; set; }
    }
}
