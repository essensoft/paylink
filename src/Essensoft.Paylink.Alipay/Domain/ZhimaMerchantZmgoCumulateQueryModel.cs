using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantZmgoCumulateQueryModel Data Structure.
    /// </summary>
    public class ZhimaMerchantZmgoCumulateQueryModel : AlipayObject
    {
        /// <summary>
        /// 芝麻go协议号，唯一标识一个芝麻go协议。
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 是否需要回传明细
        /// </summary>
        [JsonPropertyName("need_detail")]
        public bool NeedDetail { get; set; }

        /// <summary>
        /// 分页参数，当need_detail=true时需要，代表当前页数，从1开始。
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数，当need_detail=true时需要，代表每页大小，不能大于20。
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 数据回传的商户主体PID。
        /// </summary>
        [JsonPropertyName("provider_pid")]
        public string ProviderPid { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
