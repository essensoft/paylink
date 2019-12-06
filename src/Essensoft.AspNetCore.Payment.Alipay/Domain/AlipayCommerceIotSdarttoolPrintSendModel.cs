using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolPrintSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotSdarttoolPrintSendModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 唯一请求流水号
        /// </summary>
        [JsonPropertyName("outer_no")]
        public string OuterNo { get; set; }

        /// <summary>
        /// 打印内容
        /// </summary>
        [JsonPropertyName("print_content")]
        public string PrintContent { get; set; }

        /// <summary>
        /// 打印模板
        /// </summary>
        [JsonPropertyName("print_template")]
        public string PrintTemplate { get; set; }

        /// <summary>
        /// 打印的业务场景
        /// </summary>
        [JsonPropertyName("sence")]
        public string Sence { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商ID
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 走纸行数默为03
        /// </summary>
        [JsonPropertyName("walk_paper")]
        public string WalkPaper { get; set; }
    }
}
