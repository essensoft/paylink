using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainIdentityInfoCertifyResponse.
    /// </summary>
    public class AnttechBlockchainIdentityInfoCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 账户ID
        /// </summary>
        [JsonPropertyName("acc_id")]
        public string AccId { get; set; }

        /// <summary>
        /// 错误码code，0代表成功， 非0不成功
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 业务账户DID
        /// </summary>
        [JsonPropertyName("did")]
        public string Did { get; set; }

        /// <summary>
        /// 表示是否成功，paas=true 表示业务验证通过，需要和success 共同判断业务是否成功
        /// </summary>
        [JsonPropertyName("pass")]
        public bool Pass { get; set; }

        /// <summary>
        /// 业务系统ID
        /// </summary>
        [JsonPropertyName("req_msg_id")]
        public string ReqMsgId { get; set; }

        /// <summary>
        /// 代表业务成功
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }

        /// <summary>
        /// 代表业务成功，其他字段代表具体的错误
        /// </summary>
        [JsonPropertyName("sys_err_code")]
        public string SysErrCode { get; set; }

        /// <summary>
        /// 具体的错误美容描述
        /// </summary>
        [JsonPropertyName("sys_err_msg")]
        public string SysErrMsg { get; set; }
    }
}
