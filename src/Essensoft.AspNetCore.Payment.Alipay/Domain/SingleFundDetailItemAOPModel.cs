using System;
using System.Collections.Generic;
using System.Xml.Serialization;
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
        [XmlArray("batch_fund_item_model_list")]
        [XmlArrayItem("batch_fund_item_a_o_p_model")]
        public List<BatchFundItemAOPModel> BatchFundItemModelList { get; set; }

        /// <summary>
        /// 消费记录主记录
        /// </summary>
        [JsonProperty("consume_record")]
        [XmlElement("consume_record")]
        public ConsumeRecordAOPModel ConsumeRecord { get; set; }
    }
}
