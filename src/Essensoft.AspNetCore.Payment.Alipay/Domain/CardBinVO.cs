using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardBinVO Data Structure.
    /// </summary>
    public class CardBinVO : AlipayObject
    {
        /// <summary>
        /// 卡的别名
        /// </summary>
        [JsonPropertyName("card_alias")]
        public string CardAlias { get; set; }

        /// <summary>
        /// 卡bin值，通常为卡号的前6位
        /// </summary>
        [JsonPropertyName("card_bin_value")]
        public string CardBinValue { get; set; }

        /// <summary>
        /// 卡类型对象定义
        /// </summary>
        [JsonPropertyName("card_type_vo")]
        public CardTypeVO CardTypeVo { get; set; }

        /// <summary>
        /// 卡域模型定义
        /// </summary>
        [JsonPropertyName("domain_vo")]
        public CardDomainVO DomainVo { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 卡号长度
        /// </summary>
        [JsonPropertyName("inst_len")]
        public string InstLen { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 卡版本信息
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
