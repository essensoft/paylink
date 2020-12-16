using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundBatchUniTransferModel Data Structure.
    /// </summary>
    public class AlipayFundBatchUniTransferModel : AlipayObject
    {
        /// <summary>
        /// 业务场景。不同场景值不同，具体值联系支付宝确认。
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数。
        /// </summary>
        [JsonPropertyName("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 商户的批次号
        /// </summary>
        [JsonPropertyName("out_batch_no")]
        public string OutBatchNo { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [JsonPropertyName("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 业务产品码。不同产品值不同，具体值联系支付宝确认。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 批次备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 批次总笔数
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 批次总金额，单位为元，精确到小数点后两位，取值范围[0.01,9999999999999.99]
        /// </summary>
        [JsonPropertyName("total_trans_amount")]
        public string TotalTransAmount { get; set; }

        /// <summary>
        /// 收款信息列表
        /// </summary>
        [JsonPropertyName("trans_order_list")]
        public TransOrderDetail TransOrderList { get; set; }
    }
}
