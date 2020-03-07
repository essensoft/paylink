using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandScodeEledeUnsignResponse.
    /// </summary>
    public class AntMerchantExpandScodeEledeUnsignResponse : AlipayResponse
    {
        /// <summary>
        /// 去标返回结果
        /// </summary>
        [JsonPropertyName("remove_tag_response")]
        public RemoveTagResponse RemoveTagResponse { get; set; }
    }
}
