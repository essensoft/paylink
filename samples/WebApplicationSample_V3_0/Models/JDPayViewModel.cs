using System.ComponentModel.DataAnnotations;

namespace WebApplicationSample_V3_0.Models
{
    public class JDPaySaveOrderViewModel
    {
        [Required]
        [Display(Name = "tradeNum")]
        public string TradeNum { get; set; }

        [Required]
        [Display(Name = "tradeName")]
        public string TradeName { get; set; }

        [Required]
        [Display(Name = "tradeTime")]
        public string TradeTime { get; set; }

        [Required]
        [Display(Name = "amount")]
        public string Amount { get; set; }

        [Required]
        [Display(Name = "orderType")]
        public string OrderType { get; set; }

        [Required]
        [Display(Name = "currency")]
        public string Currency { get; set; }

        [Required]
        [Display(Name = "callbackUrl")]
        public string CallbackUrl { get; set; }

        [Required]
        [Display(Name = "notifyUrl")]
        public string NotifyUrl { get; set; }

        [Display(Name = "userId")]
        public string UserId { get; set; }
    }

    public class JDPayUnifiedOrderViewModel
    {
        [Required]
        [Display(Name = "tradeNum")]
        public string TradeNum { get; set; }

        [Required]
        [Display(Name = "tradeName")]
        public string TradeName { get; set; }

        [Required]
        [Display(Name = "tradeTime")]
        public string TradeTime { get; set; }

        [Required]
        [Display(Name = "amount")]
        public string Amount { get; set; }

        [Required]
        [Display(Name = "orderType")]
        public string OrderType { get; set; }

        [Required]
        [Display(Name = "currency")]
        public string Currency { get; set; }

        [Required]
        [Display(Name = "notifyUrl")]
        public string NotifyUrl { get; set; }

        [Required]
        [Display(Name = "tradeType")]
        public string TradeType { get; set; }
    }

    public class JDPayQueryViewModel
    {
        [Required]
        [Display(Name = "tradeNum")]
        public string TradeNum { get; set; }

        [Display(Name = "oTradeNum")]
        public string OTradeNum { get; set; }

        [Required]
        [Display(Name = "tradeType")]
        public string TradeType { get; set; }
    }

    public class JDPayRefundViewModel
    {
        [Required]
        [Display(Name = "tradeNum")]
        public string TradeNum { get; set; }

        [Required]
        [Display(Name = "oTradeNum")]
        public string OTradeNum { get; set; }

        [Required]
        [Display(Name = "amount")]
        public string Amount { get; set; }

        [Required]
        [Display(Name = "currency")]
        public string Currency { get; set; }

        [Required]
        [Display(Name = "notifyUrl")]
        public string NotifyUrl { get; set; }
    }

    public class JDPayQueryRefundViewModel
    {
        [Required]
        [Display(Name = "tradeNum")]
        public string TradeNum { get; set; }

        [Display(Name = "oTradeNum")]
        public string OTradeNum { get; set; }

        [Required]
        [Display(Name = "tradeType")]
        public string TradeType { get; set; }
    }

    public class JDPayDefrayPayViewModel
    {
        [Required]
        [Display(Name = "request_datetime")]
        public string RequestDatetime { get; set; }

        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Display(Name = "biz_trade_no")]
        public string BizTradeNo { get; set; }

        [Display(Name = "out_trade_date")]
        public string OutTradeDate { get; set; }

        [Required]
        [Display(Name = "trade_amount")]
        public string TradeAmount { get; set; }

        [Required]
        [Display(Name = "trade_currency")]
        public string TradeCurrency { get; set; }

        [Display(Name = "seller_info")]
        public string SellerInfo { get; set; }

        [Required]
        [Display(Name = "trade_subject")]
        public string TradeSubject { get; set; }

        [Display(Name = "category_code")]
        public string CategoryCode { get; set; }

        [Required]
        [Display(Name = "pay_tool")]
        public string PayTool { get; set; }

        [Display(Name = "trade_source")]
        public string TradeSource { get; set; }

        [Display(Name = "payee_bank_code")]
        public string PayeeBankCode { get; set; }

        [Display(Name = "payee_bank_associated_code")]
        public string PayeeBankAssociatedCode { get; set; }

        [Display(Name = "payee_bank_fullname")]
        public string PayeeBankFullname { get; set; }

        [Display(Name = "payee_bank_country_code")]
        public string PayeeBankCountryCode { get; set; }

        [Display(Name = "payee_bank_province_code")]
        public string PayeeBankProvinceCode { get; set; }

        [Display(Name = "payee_bank_city_code")]
        public string PayeeBankCityCode { get; set; }

        [Display(Name = "payee_card_type")]
        public string PayeeCardType { get; set; }

        [Display(Name = "payee_account_type")]
        public string PayeeAccountType { get; set; }

        [Display(Name = "payee_account_no")]
        public string PayeeAccountNo { get; set; }

        [Display(Name = "payee_account_name")]
        public string PayeeAccountName { get; set; }

        [Display(Name = "payee_id_type")]
        public string PayeeIdType { get; set; }

        [Display(Name = "payee_id_no")]
        public string PayeeIdNo { get; set; }

        [Display(Name = "payee_mobile")]
        public string PayeeMobile { get; set; }

        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }

        [Display(Name = "return_params")]
        public string ReturnParams { get; set; }

        [Display(Name = "extend_params")]
        public string ExtendParams { get; set; }

        [Display(Name = "bank_card_info_type")]
        public string BankCardInfoType { get; set; }

        [Display(Name = "bank_card_id")]
        public string BankCardId { get; set; }
    }

    public class JDPayTradeQueryViewModel
    {
        [Required]
        [Display(Name = "request_datetime")]
        public string RequestDatetime { get; set; }

        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Display(Name = "trade_no")]
        public string TradeNo { get; set; }

        [Required]
        [Display(Name = "trade_type")]
        public string TradeType { get; set; }
    }
}
