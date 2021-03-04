using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringConfigModifyResponse.
    /// </summary>
    public class KoubeiCateringConfigModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 每一个店铺修改的结果
        /// </summary>
        [JsonPropertyName("config_result_list")]
        public List<ShopOrderModifyResult> ConfigResultList { get; set; }
    }
}
