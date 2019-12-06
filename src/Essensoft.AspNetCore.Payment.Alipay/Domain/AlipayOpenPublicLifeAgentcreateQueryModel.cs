using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeAgentcreateQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLifeAgentcreateQueryModel : AlipayObject
    {
        /// <summary>
        /// 由开发者创建的外部入驻申请单据号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
