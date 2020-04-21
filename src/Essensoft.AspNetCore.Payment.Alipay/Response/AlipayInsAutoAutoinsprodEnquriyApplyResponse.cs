using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodEnquriyApplyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodEnquriyApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 车辆的品牌型号列表
        /// </summary>
        [JsonPropertyName("car_model")]
        public List<CarModel> CarModel { get; set; }

        /// <summary>
        /// 车险询价申请号
        /// </summary>
        [JsonPropertyName("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 外部询价申请业务单号（幂等字段）
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
