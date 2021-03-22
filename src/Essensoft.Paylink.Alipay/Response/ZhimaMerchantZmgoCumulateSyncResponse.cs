using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantZmgoCumulateSyncResponse.
    /// </summary>
    public class ZhimaMerchantZmgoCumulateSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻go协议号，唯一标识一个芝麻go协议。
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 数据回传失败原因描述
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 外部业务号，唯一标识一笔回传数据。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
