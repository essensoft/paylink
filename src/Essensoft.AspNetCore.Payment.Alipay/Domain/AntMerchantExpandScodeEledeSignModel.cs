using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandScodeEledeSignModel Data Structure.
    /// </summary>
    public class AntMerchantExpandScodeEledeSignModel : AlipayObject
    {
        /// <summary>
        /// 打标请求参数
        /// </summary>
        [JsonPropertyName("add_tag_request")]
        public List<AddTagRequest> AddTagRequest { get; set; }
    }
}
