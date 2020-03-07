using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInformationUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalInformationUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 报备成功时间
        /// </summary>
        [JsonPropertyName("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 根据各地人社局返回为准，与入参数request_content对应的业务响应数据。
        /// </summary>
        [JsonPropertyName("response_content")]
        public string ResponseContent { get; set; }
    }
}
