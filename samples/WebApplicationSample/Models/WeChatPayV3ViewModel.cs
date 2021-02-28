using System.ComponentModel.DataAnnotations;

namespace WebApplicationSample.Models
{
    public class WeChatPayAppPayV3ViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Required]
        [Display(Name = "description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "total")]
        public int Total { get; set; }

        [Required]
        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }
    }

    public class WeChatPayPubPayV3ViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Required]
        [Display(Name = "description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "total")]
        public int Total { get; set; }

        [Required]
        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }

        [Required]
        [Display(Name = "openid")]
        public string OpenId { get; set; }
    }

    public class WeChatPayQrCodePayV3ViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Required]
        [Display(Name = "description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "total")]
        public int Total { get; set; }

        [Required]
        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }
    }

    public class WeChatPayH5PayV3ViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Required]
        [Display(Name = "description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "total")]
        public int Total { get; set; }

        [Required]
        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }
    }

    public class WeChatPayQueryByTransactionIdViewModel
    {
        [Required]
        [Display(Name = "transaction_id")]
        public string TransactionId { get; set; }
    }

    public class WeChatPayQueryByOutTradeNoViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }
    }

    public class WeChatPayOutTradeNoCloseViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }
    }

    public class WeChatPayTradeBillViewModel
    {
        [Required]
        [Display(Name = "bill_date")]
        public string BillDate { get; set; }
    }

    public class WeChatPayFundflowBillViewModel
    {
        [Required]
        [Display(Name = "bill_date")]
        public string BillDate { get; set; }
    }

    public class WeChatPayBillDownloadViewModel
    {
        [Required]
        [Display(Name = "download_url")]
        public string DownloadUrl { get; set; }
    }

    #region 微信支付分

    public class WeChatPayScoreServiceOrderViewModel
    {
        [Required]
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

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
        [Display(Name = "end_time")]
        public string EndTime { get; set; }

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
        [Required]
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

        [Display(Name = "out_order_no")]
        public string OutOrderNo { get; set; }

        [Display(Name = "query_id")]
        public string QueryId { get; set; }

    }

    public class WeChatPayScoreServiceOrderCancelViewModel
    {
        [Required]
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

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
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

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
        [Display(Name = "post_payment_count")]
        public uint Count { get; set; }

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
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

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
        [Display(Name = "post_payment_count")]
        public uint Count { get; set; }

        [Required]
        [Display(Name = "total_amount")]
        public long TotalAmount { get; set; }
    }

    public class WeChatPayScoreServiceOrderPayViewModel
    {
        [Required]
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

        [Required]
        [Display(Name = "out_order_no")]
        public string OutOrderNo { get; set; }
    }

    public class WeChatPayScoreServiceOrderSyncViewModel
    {
        [Required]
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

        [Required]
        [Display(Name = "out_order_no")]
        public string OutOrderNo { get; set; }

        [Required]
        [Display(Name = "type")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "paid_time")]
        public string PaidTime { get; set; }
    }


    public class WeChatPayScoreServiceOrderDirectCompleteViewModel
    {
        [Required]
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

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
        [Display(Name = "post_payment_count")]
        public uint PostPaymentCount { get; set; }

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
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

        [Required]
        [Display(Name = "authorization_code")]
        public string AuthorizationCode { get; set; }

        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }
    }

    public class PermissionsQueryForAuthCodeViewModel
    {
        [Required]
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

        [Required]
        [Display(Name = "authorization_code")]
        public string AuthorizationCode { get; set; }
    }

    public class PermissionsTerminateForAuthCodeViewModel
    {
        [Required]
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

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
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

        [Required]
        [Display(Name = "openid")]
        public string OpenId { get; set; }
    }

    public class PermissionsTerminateForOpenIdViewModel
    {
        [Required]
        [Display(Name = "service_id")]
        public string ServiceId { get; set; }

        [Required]
        [Display(Name = "openid")]
        public string OpenId { get; set; }

        [Required]
        [Display(Name = "reason")]
        public string Reason { get; set; }
    }

    #endregion
}
