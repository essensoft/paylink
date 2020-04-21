using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCreditAutofinanceLoanApplyModel Data Structure.
    /// </summary>
    public class AlipayCreditAutofinanceLoanApplyModel : AlipayObject
    {
        /// <summary>
        /// 区域
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; set; }

        /// <summary>
        /// 征信结果回调地址
        /// </summary>
        [JsonPropertyName("backurl")]
        public string Backurl { get; set; }

        /// <summary>
        /// 扩展参数信息，json格式，针对不同的业务平台有不同的参数，目前大搜车业务支持的参数有：firstpayamt 首付租金，firstpayprop 首付比例，lastpayamt 回购尾款，loantenor 贷款期数，monthpayamt 每月还款额度
        /// </summary>
        [JsonPropertyName("extparam")]
        public string Extparam { get; set; }

        /// <summary>
        /// 外部平台宝贝ID
        /// </summary>
        [JsonPropertyName("itemid")]
        public string Itemid { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [JsonPropertyName("orgcode")]
        public string Orgcode { get; set; }

        /// <summary>
        /// 外部平台订单号,64个字符以内、只能包含字母、数字、下划线；需保证在外部平台端不重复
        /// </summary>
        [JsonPropertyName("outorderno")]
        public string Outorderno { get; set; }

        /// <summary>
        /// 支付宝账号数字ID
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 核身VID
        /// </summary>
        [JsonPropertyName("verifyid")]
        public string Verifyid { get; set; }

        /// <summary>
        /// 当前安装的支付宝钱包版本号
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
