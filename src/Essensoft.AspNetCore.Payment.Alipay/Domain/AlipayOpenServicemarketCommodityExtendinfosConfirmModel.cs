using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityExtendinfosConfirmModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketCommodityExtendinfosConfirmModel : AlipayObject
    {
        /// <summary>
        /// 公服BD审核扩展信息
        /// </summary>
        [JsonPropertyName("commodity_ext_infos")]
        public List<CommodityExtInfoConfirm> CommodityExtInfos { get; set; }

        /// <summary>
        /// 服务Id
        /// </summary>
        [JsonPropertyName("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// status 为驳回时 必须输入驳回原因
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 公服BD审核结果：成功还是失败:  status 【0：表示不通过 ， 1：表示通过】
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
