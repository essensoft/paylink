using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantEvisaStatusSyncResponse.
    /// </summary>
    public class ZhimaMerchantEvisaStatusSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 商户生成唯一的外部接口调用事务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
