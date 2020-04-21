using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserFinanceinfoShareResponse.
    /// </summary>
    public class AlipayUserFinanceinfoShareResponse : AlipayResponse
    {
        /// <summary>
        /// 查询出的信用卡列表，包含0到多张卡，每张卡对应一组信息，包含卡号（已脱敏）和开户行代码
        /// </summary>
        [JsonPropertyName("credit_card_list")]
        public List<AlipayUserCreditCard> CreditCardList { get; set; }
    }
}
