using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayZdatafrontDatatransferedFileuploadResponse.
    /// </summary>
    public class AlipayZdatafrontDatatransferedFileuploadResponse : AlipayResponse
    {
        /// <summary>
        /// 返回用户数据推送产生的结果数据，如picPath为文件上传后返回文件内部存储的位置信息
        /// </summary>
        [JsonPropertyName("result_data")]
        public string ResultData { get; set; }

        /// <summary>
        /// 数据上传结果，true/false
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
