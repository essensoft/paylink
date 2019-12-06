using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeReconconfQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppProdmodeReconconfQueryModel : AlipayObject
    {
        /// <summary>
        /// 缴费业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 销账机构编码
        /// </summary>
        [JsonPropertyName("chargeoff_code")]
        public string ChargeoffCode { get; set; }
    }
}
