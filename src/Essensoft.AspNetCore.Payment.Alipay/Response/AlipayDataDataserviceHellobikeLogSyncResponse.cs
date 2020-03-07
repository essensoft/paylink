using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceHellobikeLogSyncResponse.
    /// </summary>
    public class AlipayDataDataserviceHellobikeLogSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 业务数据同步是否成功。Y表示接收到hellobike业务反馈，并打印日志成功，N表示失败。由于本接口为数据同步接口，接受到调用请求后，服务端处理逻辑为打印日志，无直接业务影响，因此单笔请求失败不影响业务，不需要特殊处理。
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }
    }
}
