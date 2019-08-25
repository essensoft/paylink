using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectTiansuoBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectTiansuoBindModel : AlipayObject
    {
        /// <summary>
        /// 间连天梭绑定isv列表
        /// </summary>
        [JsonProperty("tiansuo_isv_bind_list")]
        public List<TiansuoIsvBindVO> TiansuoIsvBindList { get; set; }
    }
}
