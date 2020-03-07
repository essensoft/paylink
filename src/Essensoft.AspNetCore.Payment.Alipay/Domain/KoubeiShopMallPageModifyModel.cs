using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiShopMallPageModifyModel Data Structure.
    /// </summary>
    public class KoubeiShopMallPageModifyModel : AlipayObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonPropertyName("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 商圈访问地址
        /// </summary>
        [JsonPropertyName("mall_url")]
        public string MallUrl { get; set; }

        /// <summary>
        /// 废弃！，务传。
        /// </summary>
        [JsonPropertyName("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
