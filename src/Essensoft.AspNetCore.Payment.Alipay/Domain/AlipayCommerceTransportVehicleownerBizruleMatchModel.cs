using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerBizruleMatchModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerBizruleMatchModel : AlipayObject
    {
        /// <summary>
        /// 请求规则匹配的业务实体
        /// </summary>
        [JsonPropertyName("biz_entity")]
        public string BizEntity { get; set; }

        /// <summary>
        /// 车主业务类型，目前包括： PARKING - 停车 HIGHWAY - 高速 REFUELING - 加油
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }
    }
}
