using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ContractStartInfoOpenApiVO Data Structure.
    /// </summary>
    public class ContractStartInfoOpenApiVO : AlipayObject
    {
        /// <summary>
        /// 是否接受了差于与独立第三方公司的类似合作条款
        /// </summary>
        [JsonPropertyName("accept_diff_others")]
        public bool AcceptDiffOthers { get; set; }

        /// <summary>
        /// 是否接受了差于与独立第三方公司的类似合作条款说明
        /// </summary>
        [JsonPropertyName("accept_diff_others_explain")]
        public string AcceptDiffOthersExplain { get; set; }

        /// <summary>
        /// 金额类型
        /// </summary>
        [JsonPropertyName("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// 合约对手方
        /// </summary>
        [JsonPropertyName("anti_participants")]
        public List<ParticipantInfoVO> AntiParticipants { get; set; }

        /// <summary>
        /// 申请日期
        /// </summary>
        [JsonPropertyName("applicant_date")]
        public string ApplicantDate { get; set; }

        /// <summary>
        /// 倒签报备附件
        /// </summary>
        [JsonPropertyName("backdate_report_file")]
        public List<InterTradeFileInfoVO> BackdateReportFile { get; set; }

        /// <summary>
        /// 提交人
        /// </summary>
        [JsonPropertyName("committer")]
        public string Committer { get; set; }

        /// <summary>
        /// 合约金额 单位：分
        /// </summary>
        [JsonPropertyName("contract_amount_cent")]
        public string ContractAmountCent { get; set; }

        /// <summary>
        /// 合约金额 币种
        /// </summary>
        [JsonPropertyName("contract_amount_currency")]
        public string ContractAmountCurrency { get; set; }

        /// <summary>
        /// 合约金额描述
        /// </summary>
        [JsonPropertyName("contract_amount_extra")]
        public string ContractAmountExtra { get; set; }

        /// <summary>
        /// 合约金额折合人民币
        /// </summary>
        [JsonPropertyName("contract_amount_to_cny")]
        public string ContractAmountToCny { get; set; }

        /// <summary>
        /// 合同分类
        /// </summary>
        [JsonPropertyName("contract_category")]
        public string ContractCategory { get; set; }

        /// <summary>
        /// 合约名称
        /// </summary>
        [JsonPropertyName("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 合同状态
        /// </summary>
        [JsonPropertyName("contract_status")]
        public string ContractStatus { get; set; }

        /// <summary>
        /// 合同有效期类型
        /// </summary>
        [JsonPropertyName("contract_valid_type")]
        public string ContractValidType { get; set; }

        /// <summary>
        /// 提交人部门id
        /// </summary>
        [JsonPropertyName("dept_id")]
        public string DeptId { get; set; }

        /// <summary>
        /// 合同结束时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 合约文件列表
        /// </summary>
        [JsonPropertyName("files")]
        public List<InterTradeFileInfoVO> Files { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 是否为框架合同,默认False
        /// </summary>
        [JsonPropertyName("is_frame_contract")]
        public bool IsFrameContract { get; set; }

        /// <summary>
        /// 是否有限制我方业务范畴、业务地域的非竞争条款
        /// </summary>
        [JsonPropertyName("limit_business_area")]
        public bool LimitBusinessArea { get; set; }

        /// <summary>
        /// 是否有限制我方业务范畴、业务地域的非竞争条款说明
        /// </summary>
        [JsonPropertyName("limit_business_area_explain")]
        public string LimitBusinessAreaExplain { get; set; }

        /// <summary>
        /// 是否有限制我方与其他第三方合作的独家/排他条款
        /// </summary>
        [JsonPropertyName("limit_cooperate")]
        public bool LimitCooperate { get; set; }

        /// <summary>
        /// 是否有限制我方与其他第三方合作的独家/排他条款说明
        /// </summary>
        [JsonPropertyName("limit_cooperate_explain")]
        public string LimitCooperateExplain { get; set; }

        /// <summary>
        /// 合同约定失效方式
        /// </summary>
        [JsonPropertyName("lose_effect_method")]
        public string LoseEffectMethod { get; set; }

        /// <summary>
        /// 主合同编号
        /// </summary>
        [JsonPropertyName("main_contract_no")]
        public string MainContractNo { get; set; }

        /// <summary>
        /// 付款方
        /// </summary>
        [JsonPropertyName("payment_party")]
        public string PaymentParty { get; set; }

        /// <summary>
        /// 签约一年内的预估发生额 单位：分
        /// </summary>
        [JsonPropertyName("predict_amount_in_year_cent")]
        public string PredictAmountInYearCent { get; set; }

        /// <summary>
        /// 签约一年内的预估发生额 币种
        /// </summary>
        [JsonPropertyName("predict_amount_in_year_currency")]
        public string PredictAmountInYearCurrency { get; set; }

        /// <summary>
        /// 签约一年内的预估发生额描述
        /// </summary>
        [JsonPropertyName("predict_amount_in_year_extra")]
        public string PredictAmountInYearExtra { get; set; }

        /// <summary>
        /// 签约一年内的预估发生额折合人民币
        /// </summary>
        [JsonPropertyName("predict_amount_in_year_to_cny")]
        public string PredictAmountInYearToCny { get; set; }

        /// <summary>
        /// 定价策略
        /// </summary>
        [JsonPropertyName("price_type")]
        public string PriceType { get; set; }

        /// <summary>
        /// 定价政策说明
        /// </summary>
        [JsonPropertyName("price_type_explain")]
        public string PriceTypeExplain { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 合约本方
        /// </summary>
        [JsonPropertyName("self_participants")]
        public List<ParticipantInfoVO> SelfParticipants { get; set; }

        /// <summary>
        /// 合同开始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 合同约定生效方式
        /// </summary>
        [JsonPropertyName("take_effect_method")]
        public string TakeEffectMethod { get; set; }

        /// <summary>
        /// 是否模版协议
        /// </summary>
        [JsonPropertyName("template_protocol")]
        public bool TemplateProtocol { get; set; }

        /// <summary>
        /// 是否模版协议说明
        /// </summary>
        [JsonPropertyName("template_protocol_explain")]
        public string TemplateProtocolExplain { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 历史审批信息
        /// </summary>
        [JsonPropertyName("workflow_log_list")]
        public List<InterTradeApprovalWorkflowOperateLogVO> WorkflowLogList { get; set; }
    }
}
