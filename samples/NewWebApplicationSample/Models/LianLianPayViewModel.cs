using System.ComponentModel.DataAnnotations;

namespace NewWebApplicationSample.Models
{
    public class LianLianPayWebQuickPayViewModel
    {
        [Required]
        [Display(Name = "no_order")]
        public string NoOrder { get; set; }

        [Required]
        [Display(Name = "dt_order")]
        public string DtOrder { get; set; }

        [Required]
        [Display(Name = "money_order")]
        public string MoneyOrder { get; set; }

        [Required]
        [Display(Name = "name_goods")]
        public string NameGoods { get; set; }

        [Required]
        [Display(Name = "user_id")]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }

        [Display(Name = "url_return")]
        public string UrlReturn { get; set; }

        [Display(Name = "bank_code")]
        public string BankCode { get; set; }

        [Display(Name = "pay_type")]
        public string PayType { get; set; }

        [Display(Name = "no_agree")]
        public string NoAgree { get; set; }

        [Required]
        [Display(Name = "risk_item")]
        public string RiskItem { get; set; }

        [Display(Name = "id_type")]
        public string IdType { get; set; }

        [Display(Name = "id_no")]
        public string IdNo { get; set; }

        [Display(Name = "acct_name")]
        public string AcctName { get; set; }

        [Display(Name = "card_no")]
        public string CardNo { get; set; }
    }

    public class LianLianPayWapQuickPayViewModel
    {
        [Required]
        [Display(Name = "no_order")]
        public string NoOrder { get; set; }

        [Required]
        [Display(Name = "dt_order")]
        public string DtOrder { get; set; }

        [Required]
        [Display(Name = "money_order")]
        public string MoneyOrder { get; set; }

        [Required]
        [Display(Name = "name_goods")]
        public string NameGoods { get; set; }

        [Required]
        [Display(Name = "user_id")]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "app_request")]
        public string AppRequest { get; set; }

        [Required]
        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }

        [Display(Name = "url_return")]
        public string UrlReturn { get; set; }

        [Display(Name = "no_agree")]
        public string NoAgree { get; set; }

        [Required]
        [Display(Name = "risk_item")]
        public string RiskItem { get; set; }

        [Display(Name = "id_type")]
        public string IdType { get; set; }

        [Display(Name = "id_no")]
        public string IdNo { get; set; }

        [Display(Name = "acct_name")]
        public string AcctName { get; set; }

        [Display(Name = "card_no")]
        public string CardNo { get; set; }
    }

    public class LianLianPayOrderQueryViewModel
    {
        [Required]
        [Display(Name = "no_order")]
        public string NoOrder { get; set; }

        [Display(Name = "dt_order")]
        public string DtOrder { get; set; }

        [Display(Name = "oid_paybill")]
        public string OidPayBill { get; set; }
    }

    public class LianLianPayRefundViewModel
    {
        [Required]
        [Display(Name = "no_refund")]
        public string NoRefund { get; set; }

        [Required]
        [Display(Name = "dt_refund")]
        public string DtRefund { get; set; }

        [Required]
        [Display(Name = "money_refund")]
        public string MoneyRefund { get; set; }

        [Display(Name = "no_order")]
        public string NoOrder { get; set; }

        [Display(Name = "dt_order")]
        public string DtOrder { get; set; }

        [Display(Name = "oid_paybill")]
        public string OidPayBill { get; set; }

        [Required]
        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }
    }

    public class LianLianPayRefundQueryViewModel
    {
        [Display(Name = "no_refund")]
        public string NoRefund { get; set; }

        [Display(Name = "dt_refund")]
        public string DtRefund { get; set; }

        [Display(Name = "oid_refundno")]
        public string OidRefundNo { get; set; }
    }
}
