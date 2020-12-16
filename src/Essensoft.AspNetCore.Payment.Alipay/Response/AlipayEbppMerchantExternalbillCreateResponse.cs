using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppMerchantExternalbillCreateResponse.
    /// </summary>
    public class AlipayEbppMerchantExternalbillCreateResponse : AlipayResponse
    {
        /// <summary>
        /// yyyyMMdd+0(DB_FLAG)+0070(SYSTEM_FLAG)+018(SUB_BIZ_FLAG,新建)+0000(预留)+DB_SPLIT(BIZ_TYPE+SUB_BIZTYPE+MERCHANT_CODE, 2位)+TABLE_FLAG(MERCHANT_CODE, 2位)+8位全局唯一nextValue
        /// </summary>
        [JsonPropertyName("alipay_bill_id")]
        public string AlipayBillId { get; set; }
    }
}
