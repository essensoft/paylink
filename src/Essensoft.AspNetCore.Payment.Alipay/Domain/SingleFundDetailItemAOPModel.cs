using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SingleFundDetailItemAOPModel Data Structure.
    /// </summary>
    [Serializable]
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
