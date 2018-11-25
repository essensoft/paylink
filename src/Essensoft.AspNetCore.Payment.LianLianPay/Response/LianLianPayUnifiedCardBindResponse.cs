using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Response
{
    /// <summary>
    /// 统一签约创单
    /// </summary>
    public class LianLianPayUnifiedCardBindResponse : LianLianPayResponse
    {
        /// <summary>
        /// 请求结果代码 
        /// </summary>
        [JsonProperty("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 请求结果描述
        /// </summary>
        [JsonProperty("ret_msg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 授权令牌。 
        /// 有效期为30分钟。
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// 原请求中商户订单号。
        /// </summary>
        [JsonProperty("no_order")]
        public string NoOrder { get; set; }
        
        /// <summary>
        /// 连连网关地址。
        /// </summary>
        [JsonProperty("gateway_url")]
        public string GatewayUrl { get; set; }
    }
}
