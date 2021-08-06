using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServicePromoModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServicePromoModifyModel : AlipayObject
    {
        /// <summary>
        /// 服务场景素材具体内容列表
        /// </summary>
        [JsonPropertyName("promo_contents")]
        public List<PromoContentBizVO> PromoContents { get; set; }

        /// <summary>
        /// 服务场景素材记录ID
        /// </summary>
        [JsonPropertyName("promo_record_id")]
        public string PromoRecordId { get; set; }
    }
}
