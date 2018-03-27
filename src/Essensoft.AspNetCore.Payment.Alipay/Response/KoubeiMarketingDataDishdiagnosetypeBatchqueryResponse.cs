using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataDishdiagnosetypeBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingDataDishdiagnosetypeBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜品类型list
        /// </summary>
        [JsonProperty("item_diagnose_type_list")]
        public List<ItemDiagnoseType> ItemDiagnoseTypeList { get; set; }
    }
}
