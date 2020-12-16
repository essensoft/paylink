using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandSavingPassQueryResponse.
    /// </summary>
    public class AntMerchantExpandSavingPassQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 省卡咨询结果可购买的商品信息
        /// </summary>
        [JsonPropertyName("card_list")]
        public List<SCardQueryVO> CardList { get; set; }

        /// <summary>
        /// 是否可以购买省卡
        /// </summary>
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }
    }
}
