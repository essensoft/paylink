using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryRecord Data Structure.
    /// </summary>
    public class QueryRecord : AlipayObject
    {
        /// <summary>
        /// 区块在账本中的数据地址
        /// </summary>
        [JsonPropertyName("block_addr")]
        public string BlockAddr { get; set; }

        /// <summary>
        /// 上链内容所在区块高度
        /// </summary>
        [JsonPropertyName("block_height")]
        public string BlockHeight { get; set; }

        /// <summary>
        /// 企业编号
        /// </summary>
        [JsonPropertyName("corp_code")]
        public string CorpCode { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonPropertyName("corp_name")]
        public string CorpName { get; set; }

        /// <summary>
        /// 上链状态  SYNCHING：上链中；SYNCHED：上链完成
        /// </summary>
        [JsonPropertyName("notary_status")]
        public string NotaryStatus { get; set; }

        /// <summary>
        /// 操作人(经办人/实际签约人)姓名
        /// </summary>
        [JsonPropertyName("opr_cert_name")]
        public string OprCertName { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [JsonPropertyName("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 签约顺序(0:  初始发起签约;   1：第1方签约;  2：第2方签约)
        /// </summary>
        [JsonPropertyName("sign_order")]
        public long SignOrder { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [JsonPropertyName("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 操作类型英文code(INIT: 发起签约;  CANCEL: 撤销签约;  APPROVE: 确认签约)
        /// </summary>
        [JsonPropertyName("sign_type_code")]
        public string SignTypeCode { get; set; }

        /// <summary>
        /// 上链时间
        /// </summary>
        [JsonPropertyName("syn_time")]
        public string SynTime { get; set; }

        /// <summary>
        /// 签约步骤上链哈希值
        /// </summary>
        [JsonPropertyName("tx_hash_code")]
        public string TxHashCode { get; set; }
    }
}
