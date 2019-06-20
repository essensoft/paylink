using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileBeaconDeviceDeleteResponse.
    /// </summary>
    public class AlipayMobileBeaconDeviceDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 操作返回码
        /// </summary>
        [JsonProperty("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 请求处理结果
        /// </summary>
        [JsonProperty("msg")]
        public override string Msg { get; set; }
    }
}
