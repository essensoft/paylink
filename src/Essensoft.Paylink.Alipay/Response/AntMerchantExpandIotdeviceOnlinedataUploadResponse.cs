using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIotdeviceOnlinedataUploadResponse.
    /// </summary>
    public class AntMerchantExpandIotdeviceOnlinedataUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 商户合作设备在线时间回传结果
        /// </summary>
        [JsonPropertyName("onlinedata_upload_result")]
        public bool OnlinedataUploadResult { get; set; }
    }
}
