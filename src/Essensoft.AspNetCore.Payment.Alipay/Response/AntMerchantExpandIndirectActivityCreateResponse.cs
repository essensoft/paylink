using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectActivityCreateResponse.
    /// </summary>
    public class AntMerchantExpandIndirectActivityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 是否存在已报名的同类型活动。（不包含报名中活动，如存在报名中活动，会以错误码告知）  FALSE:不存在  TRUE:存在
        /// </summary>
        [JsonPropertyName("has_apply")]
        public string HasApply { get; set; }

        /// <summary>
        /// 活动报名ID，若活动报名调用成功会返回。  若存在同类型的报名活动，会返回已存在的活动报名ID，同时出参has_apply为TRUE
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
