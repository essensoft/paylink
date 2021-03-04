using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectTiansuoBindModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIndirectTiansuoBindModel : AlipayObject
    {
        /// <summary>
        /// 间连天梭绑定isv列表
        /// </summary>
        [JsonPropertyName("tiansuo_isv_bind_list")]
        public List<TiansuoIsvBindVO> TiansuoIsvBindList { get; set; }
    }
}
