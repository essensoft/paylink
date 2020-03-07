using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosParamQueryResponse.
    /// </summary>
    public class KoubeiCateringPosParamQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 门店参数model
        /// </summary>
        [JsonPropertyName("param_model")]
        public ParamModel ParamModel { get; set; }
    }
}
