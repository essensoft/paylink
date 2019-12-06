using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BatchFundItemAOPModel Data Structure.
    /// </summary>
    public class BatchFundItemAOPModel : AlipayObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public long BatchNo { get; set; }

        /// <summary>
        /// 退款到银行卡处理中的总金额
        /// </summary>
        [JsonPropertyName("dback_refundtobank_processing_batch_amount")]
        public string DbackRefundtobankProcessingBatchAmount { get; set; }

        /// <summary>
        /// 退款到银行卡成功的总金额
        /// </summary>
        [JsonPropertyName("dback_refundtobank_success_batch_amount")]
        public string DbackRefundtobankSuccessBatchAmount { get; set; }

        /// <summary>
        /// 资金明细列表
        /// </summary>
        [JsonPropertyName("fund_item_list")]
        public List<FundItemAOPModel> FundItemList { get; set; }

        /// <summary>
        /// 批次创建时间
        /// </summary>
        [JsonPropertyName("gmt_biz_create_date")]
        public string GmtBizCreateDate { get; set; }

        /// <summary>
        /// 资金单ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 包含服务费的总金额
        /// </summary>
        [JsonPropertyName("total_amount_with_service_fee")]
        public string TotalAmountWithServiceFee { get; set; }
    }
}
