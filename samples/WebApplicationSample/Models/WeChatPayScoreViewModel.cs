using System.ComponentModel.DataAnnotations;

namespace WebApplicationSample.Models
{
    public class WeChatPayScoreServiceOrderViewModel
    {
        [Required]
        [Display(Name = "out_order_no")]
        public string OutOrderNo { get; set; }

        [Required]
        [Display(Name = "service_introduction")]
        public string ServiceIntroduction { get; set; }

        [Required]
        [Display(Name = "start_time")]
        public string StartTime { get; set; }

        [Required]
        [Display(Name = "risk_fund_name")]
        public string RiskFundName { get; set; }

        [Required]
        [Display(Name = "risk_fund_amount")]
        public long RiskFundAmount { get; set; }

        [Required]
        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }

        [Display(Name = "openid")]
        public string OpenId { get; set; }
    }

    public class WeChatPayScoreServiceOrderQueryViewModel
    {
        [Display(Name = "out_order_no")]
        public string OutOrderNo { get; set; }

        [Display(Name = "query_id")]
        public string QueryId { get; set; }

    }

    public class WeChatPayScoreServiceOrderCancelViewModel
    {
        [Required]
        [Display(Name = "out_order_no")]
        public string OutOrderNo { get; set; }

        [Required]
        [Display(Name = "reason")]
        public string Reason { get; set; }
    }

    public class WeChatPayScoreServiceOrderModifyViewModel
    {
        [Required]
        [Display(Name = "out_order_no")]
        public string OutOrderNo { get; set; }

        [Required]
        [Display(Name = "post_payment_name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "post_payment_amount")]
        public long Amount { get; set; }

        [Required]
        [Display(Name = "total_amount")]
        public long TotalAmount { get; set; }

        [Required]
        [Display(Name = "reason")]
        public string Reason { get; set; }
    }

    public class WeChatPayScoreServiceOrderCompleteViewModel
    {
        [Required]
        [Display(Name = "out_order_no")]
        public string OutOrderNo { get; set; }

        [Required]
        [Display(Name = "post_payment_name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "post_payment_amount")]
        public long Amount { get; set; }

        [Required]
        [Display(Name = "total_amount")]
        public long TotalAmount { get; set; }
    }

    public class WeChatPayScoreServiceOrderPayViewModel
    {
        [Required]
        [Display(Name = "out_order_no")]
        public string OutOrderNo { get; set; }
    }

    public class WeChatPayScoreServiceOrderSyncViewModel
    {
        [Required]
        [Display(Name = "out_order_no")]
        public string OutOrderNo { get; set; }

        [Required]
        [Display(Name = "type")]
        public string Type { get; set; }
    }


    public class WeChatPayScoreServiceOrderDirectCompleteViewModel
    {
        [Required]
        [Display(Name = "out_order_no")]
        public string OutOrderNo { get; set; }

        [Required]
        [Display(Name = "service_introduction")]
        public string ServiceIntroduction { get; set; }

        [Required]
        [Display(Name = "post_payment_name")]
        public string PostPaymentName { get; set; }

        [Required]
        [Display(Name = "post_payment_amount")]
        public long PostPaymentAmount { get; set; }

        [Required]
        [Display(Name = "post_payment_description")]
        public string PostPaymentDescription { get; set; }


        [Required]
        [Display(Name = "start_time")]
        public string StartTime { get; set; }

        [Required]
        [Display(Name = "end_time")]
        public string EndTime { get; set; }

        [Required]
        [Display(Name = "total_amount")]
        public long TotalAmount { get; set; }
                
        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }

        [Display(Name = "openid")]
        public string OpenId { get; set; }
    }

    public class PermissionsViewModel
    {
        [Required]
        [Display(Name = "authorization_code")]
        public string AuthorizationCode { get; set; }

        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }
    }

    public class PermissionsQueryForAuthCodeViewModel
    {
        [Required]
        [Display(Name = "authorization_code")]
        public string AuthorizationCode { get; set; }
    }

    public class PermissionsTerminateForAuthCodeViewModel
    {
        [Required]
        [Display(Name = "authorization_code")]
        public string AuthorizationCode { get; set; }

        [Required]
        [Display(Name = "reason")]
        public string Reason { get; set; }
    }

    public class PermissionsQueryForOpenIdViewModel
    {
        [Required]
        [Display(Name = "openid")]
        public string OpenId { get; set; }
    }

    public class PermissionsTerminateForOpenIdViewModel
    {
        [Required]
        [Display(Name = "openid")]
        public string OpenID { get; set; }

        [Required]
        [Display(Name = "reason")]
        public string Reason { get; set; }
    }
}
