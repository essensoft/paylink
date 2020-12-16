using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountClearingcenterPayoffQueryModel Data Structure.
    /// </summary>
    public class AlipayAccountClearingcenterPayoffQueryModel : AlipayObject
    {
        /// <summary>
        /// 币种 用于查询解付登记薄
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 合作伙伴GKA英文名称 用于查询登记薄信息
        /// </summary>
        [JsonPropertyName("instid")]
        public string Instid { get; set; }

        /// <summary>
        /// 禁用状态 查询被禁用的待解付登记薄 INIT("INIT", "初始"), PAYOFFING("PAYOFFING", "解付中"), PAYOFFED("PAYOFFED", "解付完成"), BACKING("BACKING", "退汇中"), BACKED("BACKED", "退汇完成"), DEPRECAT("DEPRECAT", "弃用")
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
