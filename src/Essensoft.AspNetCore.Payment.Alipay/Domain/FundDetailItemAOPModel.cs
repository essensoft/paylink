using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FundDetailItemAOPModel Data Structure.
    /// </summary>
    public class FundDetailItemAOPModel : AlipayObject
    {
        /// <summary>
        /// 主记录+对应资金明细信息模型列表
        /// </summary>
        [JsonPropertyName("single_fund_detail_item_aopmodel_list")]
        public List<SingleFundDetailItemAOPModel> SingleFundDetailItemAopmodelList { get; set; }
    }
}
