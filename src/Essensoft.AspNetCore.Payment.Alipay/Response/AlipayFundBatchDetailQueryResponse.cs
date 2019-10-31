using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundBatchDetailQueryResponse.
    /// </summary>
    public class AlipayFundBatchDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1）当批次状态为INIT状态时，明细信息还未落地，返回明细信息为空 2）如果以上都没有问题，返回明细为空，请检查是否以下情况导致： 1. 校验商户只能查询自己上传的批次信息，批次号不存在或者不是该商户上传的批次。 2. 查询条件没有查询到结果，包括总共5页，商户要求查询第6页的内容。 3. 查询的状态不存在。
        /// </summary>
        [JsonProperty("acc_detail_list")]
        public List<AccDetailModel> AccDetailList { get; set; }

        /// <summary>
        /// 商户请求的批次流水号，同请求中的"batch_no"。（注：只有境外代发使用，其他场景返回out_batch_no）
        /// </summary>
        [JsonProperty("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 境外场景批次状态： INIT 批次已接收 WAIT_APPLY 批次资金准备中 DEALING 批次处理中 FINISH 批次处理完成 FAIL 全部处理失败 UNKNOWN 未知状态  其他场景批次状态： INIT 批次已接收 WAIT_PAY 等待支付 DEALING 批次处理中 SUCCESS 批次处理全部成功 PART_SUCCESS 批次处理部分成功 FAIL 全部处理失败 DISUSE 批次单据废弃 INVALID 批次单据中明细全部无效
        /// </summary>
        [JsonProperty("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 支付宝系统内部批次请求id。
        /// </summary>
        [JsonProperty("batch_trans_id")]
        public string BatchTransId { get; set; }

        /// <summary>
        /// 批量代发业务标识。  批量代发到支付宝账户：BATCH_TRANS_ACC 批量代发到银行账户：BATCH_TRANS_BC （注：只有境外代发使用，其他场景返回product_code）
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 批量代发业务场景。 如： GLOBAL：全球代发，多币种代发（包括除人民币以外的同币种代发），需要支付宝做货币兑换。 LOCAL：纯人民币代发，不需要支付宝做货币兑换。 MESSAGE_BATCH_PAY：接口报文代发。
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 批次失败错误码.   大部分情况是没有的. 只有余额不足超时关闭或者付款方账户状态不正常
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 批次失败错误原因
        /// </summary>
        [JsonProperty("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 商户的批次号
        /// </summary>
        [JsonProperty("out_batch_no")]
        public string OutBatchNo { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 当前记录数（默认500，达不到500按实际记录返回）。
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 付款方需要支付的金额，受理成功（status为APPLIED）之后才会有值，受理成功之前是0。
        /// </summary>
        [JsonProperty("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 支付币种, 与代发请求的payment_currency相同.
        /// </summary>
        [JsonProperty("payment_currency")]
        public string PaymentCurrency { get; set; }

        /// <summary>
        /// 业务产品码。不同产品值不同，具体值联系支付宝确认。
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 签约了批量代发产品的支付宝账号。（注：境外代发场景加会返回）
        /// </summary>
        [JsonProperty("sign_principal")]
        public string SignPrincipal { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total_item_count")]
        public long TotalItemCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("total_page_count")]
        public long TotalPageCount { get; set; }
    }
}
