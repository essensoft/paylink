using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillMinimctSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceLogisticsWaybillMinimctSyncModel : AlipayObject
    {
        /// <summary>
        /// 物流公司编码，具体详见接口开发文档
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 运单参数扩展列表
        /// </summary>
        [JsonPropertyName("merchant_ext_info")]
        public List<ParamExtInfo> MerchantExtInfo { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [JsonPropertyName("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
