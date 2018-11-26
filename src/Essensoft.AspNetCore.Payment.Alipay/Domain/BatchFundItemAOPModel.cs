using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BatchFundItemAOPModel Data Structure.
    /// </summary>
    [Serializable]
    public class BatchFundItemAOPModel : AlipayObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonProperty("batch_no")]
        [XmlElement("batch_no")]
        public long BatchNo { get; set; }

        /// <summary>
        /// 退款到银行卡处理中的总金额
        /// </summary>
        [JsonProperty("dback_refundtobank_processing_batch_amount")]
        [XmlElement("dback_refundtobank_processing_batch_amount")]
        public string DbackRefundtobankProcessingBatchAmount { get; set; }

        /// <summary>
        /// 退款到银行卡成功的总金额
        /// </summary>
        [JsonProperty("dback_refundtobank_success_batch_amount")]
        [XmlElement("dback_refundtobank_success_batch_amount")]
        public string DbackRefundtobankSuccessBatchAmount { get; set; }

        /// <summary>
        /// 资金明细列表
        /// </summary>
        [JsonProperty("fund_item_list")]
        [XmlArray("fund_item_list")]
        [XmlArrayItem("fund_item_a_o_p_model")]
        public List<FundItemAOPModel> FundItemList { get; set; }

        /// <summary>
        /// 批次创建时间
        /// </summary>
        [JsonProperty("gmt_biz_create_date")]
        [XmlElement("gmt_biz_create_date")]
        public string GmtBizCreateDate { get; set; }

        /// <summary>
        /// 资金单ID
        /// </summary>
        [JsonProperty("order_id")]
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [JsonProperty("total_amount")]
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 包含服务费的总金额
        /// </summary>
        [JsonProperty("total_amount_with_service_fee")]
        [XmlElement("total_amount_with_service_fee")]
        public string TotalAmountWithServiceFee { get; set; }
    }
}
