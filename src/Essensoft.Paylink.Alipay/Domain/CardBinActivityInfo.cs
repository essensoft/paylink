using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CardBinActivityInfo Data Structure.
    /// </summary>
    public class CardBinActivityInfo : AlipayObject
    {
        /// <summary>
        /// 银行标准缩写 eg： 工行ICBC，农行ABC
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 规则的卡bin
        /// </summary>
        [JsonPropertyName("card_bin")]
        public string CardBin { get; set; }

        /// <summary>
        /// 卡bin规则对应的外部code
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 规则对应的商家pid
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }
    }
}
