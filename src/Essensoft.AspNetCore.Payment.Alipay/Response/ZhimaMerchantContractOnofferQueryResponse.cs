using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantContractOnofferQueryResponse.
    /// </summary>
    public class ZhimaMerchantContractOnofferQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 取消的操作主体 用于区分是系统取消还是用户主动取消
        /// </summary>
        [JsonPropertyName("cancel_operator")]
        public string CancelOperator { get; set; }

        /// <summary>
        /// 是否支持取消
        /// </summary>
        [JsonPropertyName("cancel_supported")]
        public bool CancelSupported { get; set; }

        /// <summary>
        /// 约定内容描述
        /// </summary>
        [JsonPropertyName("contract_content")]
        public string ContractContent { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 合约主体描述，用于呈现支付端内约定详情中的主体描述
        /// </summary>
        [JsonPropertyName("contract_principal_desc")]
        public string ContractPrincipalDesc { get; set; }

        /// <summary>
        /// 合约主体图片链接
        /// </summary>
        [JsonPropertyName("contract_principal_logo")]
        public string ContractPrincipalLogo { get; set; }

        /// <summary>
        /// 合约状态 INIT:初始化,待应约状态 EFFECT:生效 COMPLETE:完结 CLOSE:关闭 INVALID:失效
        /// </summary>
        [JsonPropertyName("contract_status")]
        public string ContractStatus { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 去履约完成时点击的链接地址
        /// </summary>
        [JsonPropertyName("fufilment_callback_url")]
        public string FufilmentCallbackUrl { get; set; }

        /// <summary>
        /// 履约需要完成次数，如看直播一次，关注店铺一次
        /// </summary>
        [JsonPropertyName("fufilment_cnt")]
        public long FufilmentCnt { get; set; }

        /// <summary>
        /// 履约需要完成的事项描述
        /// </summary>
        [JsonPropertyName("fufilment_desc")]
        public string FufilmentDesc { get; set; }

        /// <summary>
        /// 合约周期结束时间 fufilment_period_type=default时必选
        /// </summary>
        [JsonPropertyName("fufilment_end_time")]
        public string FufilmentEndTime { get; set; }

        /// <summary>
        /// 履约周期类型(default:默认有限周期，需要填写开始结束时间)
        /// </summary>
        [JsonPropertyName("fufilment_period_type")]
        public string FufilmentPeriodType { get; set; }

        /// <summary>
        /// 合约周期开始时间 fufilment_period_type=default时必选
        /// </summary>
        [JsonPropertyName("fufilment_start_time")]
        public string FufilmentStartTime { get; set; }

        /// <summary>
        /// 应约时间
        /// </summary>
        [JsonPropertyName("gmt_accept")]
        public string GmtAccept { get; set; }

        /// <summary>
        /// 合约取消时间
        /// </summary>
        [JsonPropertyName("gmt_cancel")]
        public string GmtCancel { get; set; }

        /// <summary>
        /// 逾期时间
        /// </summary>
        [JsonPropertyName("gmt_due")]
        public string GmtDue { get; set; }

        /// <summary>
        /// 合约完结时间
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 事项结束时间
        /// </summary>
        [JsonPropertyName("item_end_time")]
        public string ItemEndTime { get; set; }

        /// <summary>
        /// 事项号
        /// </summary>
        [JsonPropertyName("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 事项开始时间
        /// </summary>
        [JsonPropertyName("item_start_time")]
        public string ItemStartTime { get; set; }

        /// <summary>
        /// 发约创建者主体id(商户pid/用户芝麻id/支付宝用户id/淘宝用户id)
        /// </summary>
        [JsonPropertyName("offer_creater_id")]
        public string OfferCreaterId { get; set; }

        /// <summary>
        /// 发约创建者名称,对应： 商户名称 芝麻用户名称 支付宝用户名称 淘宝用户名称
        /// </summary>
        [JsonPropertyName("offer_creater_name")]
        public string OfferCreaterName { get; set; }

        /// <summary>
        /// 发约创建者类型： MERCHANT:商户 ZHIMA_ROLE:芝麻用户 ALIPAY_ROLE:支付宝用户 TAOBAO_ROLE:淘宝用户
        /// </summary>
        [JsonPropertyName("offer_creater_type")]
        public string OfferCreaterType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部内容号，对应标的物id，如直播号，电影id，店铺id，节目id等
        /// </summary>
        [JsonPropertyName("out_content_no")]
        public string OutContentNo { get; set; }

        /// <summary>
        /// 应约主体id
        /// </summary>
        [JsonPropertyName("sign_principal_id")]
        public string SignPrincipalId { get; set; }

        /// <summary>
        /// 应约者类型:ZHIMA_ROLE:芝麻用户 ALIPAY_ROLE:支付宝用户 TAOBAO_ROLE:淘宝用户
        /// </summary>
        [JsonPropertyName("sign_principal_type")]
        public string SignPrincipalType { get; set; }

        /// <summary>
        /// 事项下标的信息
        /// </summary>
        [JsonPropertyName("subjects")]
        public string Subjects { get; set; }
    }
}
