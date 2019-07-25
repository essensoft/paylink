using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodQuoteApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoinsprodQuoteApplyModel : AlipayObject
    {
        /// <summary>
        /// 商业险产品信息
        /// </summary>
        [JsonProperty("business_product")]
        public InsProduct BusinessProduct { get; set; }

        /// <summary>
        /// 用户录入验证码,当需要图片验证码时必传
        /// </summary>
        [JsonProperty("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 验证码对应id 当需要图片验证码时必传
        /// </summary>
        [JsonProperty("check_code_id")]
        public string CheckCodeId { get; set; }

        /// <summary>
        /// 验证类型 0-不需要、1-江苏验证码、2-中保信验证码
        /// </summary>
        [JsonProperty("check_type")]
        public string CheckType { get; set; }

        /// <summary>
        /// 机构编码 当微调报价时必传，当需要图片验证码时必传
        /// </summary>
        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 此次报价，机构id列表
        /// </summary>
        [JsonProperty("company_ids")]
        public List<string> CompanyIds { get; set; }

        /// <summary>
        /// 车险询价申请号
        /// </summary>
        [JsonProperty("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 交强险产品信息
        /// </summary>
        [JsonProperty("force_product")]
        public InsProduct ForceProduct { get; set; }

        /// <summary>
        /// 是否通融报价
        /// </summary>
        [JsonProperty("is_tong_rong")]
        public string IsTongRong { get; set; }

        /// <summary>
        /// 报价类型 1-微调，0-套餐
        /// </summary>
        [JsonProperty("quote_type")]
        public string QuoteType { get; set; }

        /// <summary>
        /// 税务机构编码
        /// </summary>
        [JsonProperty("tax_inst_code")]
        public string TaxInstCode { get; set; }

        /// <summary>
        /// 税务机构名称
        /// </summary>
        [JsonProperty("tax_inst_name")]
        public string TaxInstName { get; set; }

        /// <summary>
        /// 完税凭证编码
        /// </summary>
        [JsonProperty("tax_payment_code")]
        public string TaxPaymentCode { get; set; }

        /// <summary>
        /// 完税评审日期，格式：yyyymmdd
        /// </summary>
        [JsonProperty("tax_payment_date")]
        public string TaxPaymentDate { get; set; }

        /// <summary>
        /// 是否完税标识
        /// </summary>
        [JsonProperty("tax_type")]
        public string TaxType { get; set; }
    }
}
