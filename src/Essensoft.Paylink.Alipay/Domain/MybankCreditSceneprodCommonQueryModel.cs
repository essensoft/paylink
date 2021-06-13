using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodCommonQueryModel Data Structure.
    /// </summary>
    public class MybankCreditSceneprodCommonQueryModel : AlipayObject
    {
        /// <summary>
        /// 网商申请号
        /// </summary>
        [JsonPropertyName("app_seq_no")]
        public string AppSeqNo { get; set; }

        /// <summary>
        /// 代偿数据查询，不同查询场景示例数据不同，可同时包含多个场景查询。
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 代偿数据查询场景
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 机构编码，机构接入场景金融平台时分配，固定值
        /// </summary>
        [JsonPropertyName("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 产品编码，场景金融平台给机构提供的产品编码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 本次请求流水号，全局唯一
        /// </summary>
        [JsonPropertyName("seq_no")]
        public string SeqNo { get; set; }
    }
}
