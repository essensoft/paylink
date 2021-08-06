using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServicePromoApplyModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServicePromoApplyModel : AlipayObject
    {
        /// <summary>
        /// 展台ID
        /// </summary>
        [JsonPropertyName("promo_booth_id")]
        public string PromoBoothId { get; set; }

        /// <summary>
        /// 具体内容列表
        /// </summary>
        [JsonPropertyName("promo_contents")]
        public List<PromoContentBizVO> PromoContents { get; set; }

        /// <summary>
        /// 实体的编码列表
        /// </summary>
        [JsonPropertyName("promo_entity_codes")]
        public string PromoEntityCodes { get; set; }

        /// <summary>
        /// 实体类型。枚举值如下： MINI_APP("MINI_APP", "小程序"), STD_SERVICE("STD_SERVICE", "标准化服务"), SERVICE_BACK_CATALOG("SERVICE_BACK_CATALOG", "服务类目")
        /// </summary>
        [JsonPropertyName("promo_entity_type")]
        public string PromoEntityType { get; set; }
    }
}
