using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateProfitDTO Data Structure.
    /// </summary>
    public class TemplateProfitDTO : AlipayObject
    {
        /// <summary>
        /// 利益前缀，如“立减10元”，利益前缀为：立减。随机立减券、减至券不填会使用默认值，其它类型可空。支持自定义动态参数传值，但动态参数需定义为：$_r_profit_pre_desc$。
        /// </summary>
        [JsonPropertyName("profit_pre_desc")]
        public string ProfitPreDesc { get; set; }

        /// <summary>
        /// 利益单位，如“立减10元”，利益单位为：元。除商品券、兑换券可空之外，其它类型不填均有默认值。支持自定义动态参数传值，但动态参数需定义为：$_r_profit_unit$。
        /// </summary>
        [JsonPropertyName("profit_unit")]
        public string ProfitUnit { get; set; }

        /// <summary>
        /// 利益值，如“立减10元”，利益值为：10。与卡券的子类型联动使用。除商品券、随机立减券、兑换券可自定义文案之外，其它类型利益值均限制为数字。支持自定义动态参数传值，但动态参数需定义为：$_r_profit_value$。
        /// </summary>
        [JsonPropertyName("profit_value")]
        public string ProfitValue { get; set; }
    }
}
