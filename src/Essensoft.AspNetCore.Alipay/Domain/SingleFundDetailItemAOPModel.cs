using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// SingleFundDetailItemAOPModel Data Structure.
    /// </summary>
    public class SingleFundDetailItemAOPModel : AlipayObject
    {
        /// <summary>
        /// 批次资金明细模型列表
        /// </summary>
        [JsonProperty("batch_fund_item_model_list")]
        public List<BatchFundItemAOPModel> BatchFundItemModelList { get; set; }

        /// <summary>
        /// 消费记录主记录
        /// </summary>
        [JsonProperty("consume_record")]
        public ConsumeRecordAOPModel ConsumeRecord { get; set; }
    }
}
