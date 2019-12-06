using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantCloseloopDataUploadResponse.
    /// </summary>
    public class ZhimaMerchantCloseloopDataUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 公用回传参数（非必填），这个字段由商户传入，系统透传给商户。
        /// </summary>
        [JsonPropertyName("biz_ext_params")]
        public string BizExtParams { get; set; }

        /// <summary>
        /// 每次上传都会生成一个任务号
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
