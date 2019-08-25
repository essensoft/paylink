using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringKdsInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringKdsInfoModifyModel : AlipayObject
    {
        /// <summary>
        /// kds配置详情
        /// </summary>
        [JsonProperty("kds_info_model_list")]
        public List<KdsInfoModel> KdsInfoModelList { get; set; }
    }
}
