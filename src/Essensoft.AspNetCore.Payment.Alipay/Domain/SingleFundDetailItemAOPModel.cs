using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SingleFundDetailItemAOPModel Data Structure.
    /// </summary>
    public class SingleFundDetailItemAOPModel : AlipayObject
    {
        /// <summary>
        /// 批次资金明细模型列表
        /// </summary>
        [JsonPropertyName("batch_fund_item_model_list")]
        public List<BatchFundItemAOPModel> BatchFundItemModelList { get; set; }

        /// <summary>
        /// 消费记录主记录
        /// </summary>
        [JsonPropertyName("consume_record")]
        public ConsumeRecordAOPModel ConsumeRecord { get; set; }
    }
}
