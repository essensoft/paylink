using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditamountQueryprocessorQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditamountQueryprocessorQueryModel : AlipayObject
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [JsonPropertyName("params")]
        public TbapiQueryAmountBizContent Params { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
