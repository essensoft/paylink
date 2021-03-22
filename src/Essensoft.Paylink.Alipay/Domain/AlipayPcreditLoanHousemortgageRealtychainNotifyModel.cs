using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanHousemortgageRealtychainNotifyModel Data Structure.
    /// </summary>
    public class AlipayPcreditLoanHousemortgageRealtychainNotifyModel : AlipayObject
    {
        /// <summary>
        /// 合同签署人-用户签约事件必传
        /// </summary>
        [JsonPropertyName("contract_signatory")]
        public ContractSignatory ContractSignatory { get; set; }

        /// <summary>
        /// 失败场景的错误码：HQF_REALTY_NOT_EXISTS-查无此房, OTHER-其他
        /// </summary>
        [JsonPropertyName("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 授信受理单据号
        /// </summary>
        [JsonPropertyName("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 流程类型：房产查询-HQ，抵押-MG，解抵押-MGR
        /// </summary>
        [JsonPropertyName("rcp_flow")]
        public string RcpFlow { get; set; }

        /// <summary>
        /// 房产链单据号
        /// </summary>
        [JsonPropertyName("rcp_no")]
        public string RcpNo { get; set; }

        /// <summary>
        /// 通知场景 FINISH_REALTY_QUERY_PASS：房产查询成功 FINISH_REALTY_QUERY_REJECT：房产查询失败 CB_MG_SIGN_URL：抵押合同客户签署地址通知 CB_MG_SIGNED_PERSON：抵押合同单个客户完成签署通知 FINISH_MG_CT_BANK_SIGN_PASS：银行完成签署确认抵押 FINISH_MG_CT_BANK_SIGN_REJECT：银行终止抵押
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
