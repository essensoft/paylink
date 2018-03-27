using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonProperty("batch_no")]
        public long BatchNo { get; set; }

        /// <summary>
        /// 退款到银行卡处理中的总金额
        /// </summary>
        [JsonProperty("dback_refundtobank_processing_batch_amount")]
        public string DbackRefundtobankProcessingBatchAmount { get; set; }

        /// <summary>
        /// 退款到银行卡成功的总金额
        /// </summary>
        [JsonProperty("dback_refundtobank_success_batch_amount")]
        public string DbackRefundtobankSuccessBatchAmount { get; set; }

        /// <summary>
        /// 资金明细列表
        /// </summary>
        [JsonProperty("fund_item_list")]
        public List<FundItemAOPModel> FundItemList { get; set; }

        /// <summary>
        /// 批次创建时间
        /// </summary>
        [JsonProperty("gmt_biz_create_date")]
        public string GmtBizCreateDate { get; set; }

        /// <summary>
        /// 资金单ID
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 包含服务费的总金额
        /// </summary>
        [JsonProperty("total_amount_with_service_fee")]
        public string TotalAmountWithServiceFee { get; set; }
    }
}
