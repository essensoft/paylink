using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncGfacceptanceBillAcceptModel Data Structure.
    /// </summary>
    public class AlipayBossFncGfacceptanceBillAcceptModel : AlipayObject
    {
        /// <summary>
        /// 业财账单受理模型
        /// </summary>
        [JsonPropertyName("bill_acceptance")]
        public GFAOpenAPIBillAcceptance BillAcceptance { get; set; }

        /// <summary>
        /// 16位。支付宝UID或者2088000000000XX0，倒数2、3位数字用来决策LDC ZoneUid和分库位
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }
    }
}
