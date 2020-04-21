using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenRequestBatchSendResponse.
    /// </summary>
    public class AlipayOpenRequestBatchSendResponse : AlipayResponse
    {
        /// <summary>
        /// 批量请求中子业务接口的响应拼接报文:  {  "alipay_trade_query_response":{"code":"10000","msg":"Success","out_trade_no":"2018232"}}#S#{  "alipay_trade_query_response":{"code":"10000","msg":"Success","out_trade_no":"2018232"}}
        /// </summary>
        [JsonPropertyName("response_body")]
        public string ResponseBody { get; set; }
    }
}
