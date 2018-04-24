using System.ComponentModel.DataAnnotations;

namespace NewWebApplicationSample.Models
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
}
