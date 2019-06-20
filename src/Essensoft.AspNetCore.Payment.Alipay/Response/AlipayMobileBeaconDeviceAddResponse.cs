using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileBeaconDeviceAddResponse.
    /// </summary>
    public class AlipayMobileBeaconDeviceAddResponse : AlipayResponse
    {
        /// <summary>
        /// 请求操作成功与否，200为成功
        /// </summary>
        [JsonProperty("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 请求的处理结果
        /// </summary>
        [JsonProperty("msg")]
        public override string Msg { get; set; }
    }
}
