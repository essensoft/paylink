using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosSidedishbatchSaveResponse.
    /// </summary>
    public class KoubeiCateringPosSidedishbatchSaveResponse : AlipayResponse
    {
        /// <summary>
        /// 配料添加成功的菜品
        /// </summary>
        [JsonPropertyName("ids")]
        public List<string> Ids { get; set; }
    }
}
