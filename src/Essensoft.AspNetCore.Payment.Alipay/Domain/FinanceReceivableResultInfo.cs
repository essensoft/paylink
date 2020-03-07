using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FinanceReceivableResultInfo Data Structure.
    /// </summary>
    public class FinanceReceivableResultInfo : AlipayObject
    {
        /// <summary>
        /// 供应商确认接收上链交易hash
        /// </summary>
        [JsonPropertyName("accept_tx_hash")]
        public string AcceptTxHash { get; set; }

        /// <summary>
        /// 资产发行提交时传入的内部资产id
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 保理付款账户信息
        /// </summary>
        [JsonPropertyName("factoring_account_info")]
        public FinanceBankAccountInfo FactoringAccountInfo { get; set; }

        /// <summary>
        /// 发行完成时间，UTC标准格式
        /// </summary>
        [JsonPropertyName("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 资产发行预申请时，核心企业定义的应收账款编号
        /// </summary>
        [JsonPropertyName("out_asset_id")]
        public string OutAssetId { get; set; }

        /// <summary>
        /// 保理机构登记审批上链交易hash
        /// </summary>
        [JsonPropertyName("review_tx_hash")]
        public string ReviewTxHash { get; set; }

        /// <summary>
        /// 核心企业提交上链交易hash
        /// </summary>
        [JsonPropertyName("submit_tx_hash")]
        public string SubmitTxHash { get; set; }
    }
}
