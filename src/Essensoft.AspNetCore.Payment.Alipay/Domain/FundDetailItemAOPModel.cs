using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FundDetailItemAOPModel Data Structure.
    /// </summary>
    [Serializable]
    public class FundDetailItemAOPModel : AlipayObject
    {
        /// <summary>
        /// 主记录+对应资金明细信息模型列表
        /// </summary>
        [JsonProperty("single_fund_detail_item_aopmodel_list")]
        [XmlArray("single_fund_detail_item_aopmodel_list")]
        [XmlArrayItem("single_fund_detail_item_a_o_p_model")]
        public List<SingleFundDetailItemAOPModel> SingleFundDetailItemAopmodelList { get; set; }
    }
}
