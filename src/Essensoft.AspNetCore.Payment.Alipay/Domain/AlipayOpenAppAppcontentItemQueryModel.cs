using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppAppcontentItemQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝小程序ID
        /// </summary>
        [JsonPropertyName("alipay_app_id")]
        public string AlipayAppId { get; set; }

        /// <summary>
        /// 商品状态；可选值：VALID（上架）、INVALID（下架）
        /// </summary>
        [JsonPropertyName("item_status")]
        public string ItemStatus { get; set; }

        /// <summary>
        /// 商品名称（模糊查询）
        /// </summary>
        [JsonPropertyName("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 当前页码；大于0
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页查询数量；可选值：1到20
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
