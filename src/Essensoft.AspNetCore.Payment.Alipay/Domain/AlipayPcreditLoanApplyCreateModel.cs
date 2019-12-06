using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanApplyCreateModel Data Structure.
    /// </summary>
    public class AlipayPcreditLoanApplyCreateModel : AlipayObject
    {
        /// <summary>
        /// 申贷金额，单位为元
        /// </summary>
        [JsonPropertyName("apply_amt")]
        public string ApplyAmt { get; set; }

        /// <summary>
        /// 用户身份证后4位
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户贴息率，0~1的小数
        /// </summary>
        [JsonPropertyName("ratio")]
        public long Ratio { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
