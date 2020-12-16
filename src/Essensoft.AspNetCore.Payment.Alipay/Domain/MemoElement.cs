using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MemoElement Data Structure.
    /// </summary>
    public class MemoElement : AlipayObject
    {
        /// <summary>
        /// 是否是常量，默认常量
        /// </summary>
        [JsonPropertyName("constant")]
        public bool Constant { get; set; }

        /// <summary>
        /// 字段替换的key，DEBIT_ACCOUNT_NO/CREDIT_ACCOUNT_NO/DEBIT_INST_ID/CREDIT_INST_ID/TRANS_TIME/BIZ_NO 付款账号/收款账号/付款账户机构id/收款账户机构id/交易时间/业务单号
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
