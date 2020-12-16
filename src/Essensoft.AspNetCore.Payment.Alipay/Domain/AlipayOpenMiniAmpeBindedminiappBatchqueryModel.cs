using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeBindedminiappBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAmpeBindedminiappBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 移动应用ID，必填
        /// </summary>
        [JsonPropertyName("mobile_app_id")]
        public string MobileAppId { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 单页查询数量，最大不超过100
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
