using System.ComponentModel.DataAnnotations;

namespace WebApplicationSample.Models
{
    public class AlipayTradePreCreateViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Required]
        [Display(Name = "subject")]
        public string Subject { get; set; }

        [Display(Name = "body")]
        public string Body { get; set; }

        [Required]
        [Display(Name = "total_amount")]
        public string TotalAmount { get; set; }

        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }
    }

    public class AlipayTradePayViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Required]
        [Display(Name = "subject")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "scene")]
        public string Scene { get; set; }

        [Required]
        [Display(Name = "auth_code")]
        public string AuthCode { get; set; }

        [Display(Name = "body")]
        public string Body { get; set; }

        [Required]
        [Display(Name = "total_amount")]
        public string TotalAmount { get; set; }
    }

    public class AlipayTradeAppPayViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Required]
        [Display(Name = "subject")]
        public string Subject { get; set; }

        [Display(Name = "product_code")]
        public string ProductCode { get; set; }

        [Display(Name = "body")]
        public string Body { get; set; }

        [Required]
        [Display(Name = "total_amount")]
        public string TotalAmount { get; set; }

        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }
    }

    public class AlipayTradePagePayViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Required]
        [Display(Name = "subject")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "product_code")]
        public string ProductCode { get; set; }

        [Display(Name = "body")]
        public string Body { get; set; }

        [Required]
        [Display(Name = "total_amount")]
        public string TotalAmount { get; set; }

        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }

        [Display(Name = "return_url")]
        public string ReturnUrl { get; set; }
    }

    public class AlipayTradeWapPayViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Required]
        [Display(Name = "subject")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "product_code")]
        public string ProductCode { get; set; }

        [Display(Name = "body")]
        public string Body { get; set; }

        [Required]
        [Display(Name = "total_amount")]
        public string TotalAmount { get; set; }

        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }

        [Display(Name = "return_url")]
        public string ReturnUrl { get; set; }
    }

    public class AlipayTradeQueryViewModel
    {
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Display(Name = "trade_no")]
        public string TradeNo { get; set; }
    }

    public class AlipayTradeRefundViewModel
    {
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Display(Name = "trade_no")]
        public string TradeNo { get; set; }

        [Display(Name = "refund_amount")]
        public string RefundAmount { get; set; }

        [Display(Name = "out_request_no")]
        public string OutRequestNo { get; set; }

        [Display(Name = "refund_reason")]
        public string RefundReason { get; set; }
    }

    public class AlipayTradeRefundQueryViewModel
    {
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Display(Name = "trade_no")]
        public string TradeNo { get; set; }

        [Display(Name = "out_request_no")]
        public string OutRequestNo { get; set; }
    }

    public class AlipayTradeCloseViewModel
    {
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Display(Name = "trade_no")]
        public string TradeNo { get; set; }

        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }
    }

    public class AlipayTransferViewModel
    {
        [Required]
        [Display(Name = "out_biz_no")]
        public string OutBizNo { get; set; }

        [Required]
        [Display(Name = "trans_amount")]
        public string TransAmount { get; set; }

        [Required]
        [Display(Name = "product_code")]
        public string ProductCode { get; set; }

        [Required]
        [Display(Name = "biz_scene")]
        public string BizScene { get; set; }

        [Required]
        [Display(Name = "payee_info_identity")]
        public string PayeeIdentity { get; set; }

        [Required]
        [Display(Name = "payee_info_identity_type")]
        public string PayeeIdentityType { get; set; }

        [Required]
        [Display(Name = "payee_info_name")]
        public string PayeeName { get; set; }

        [Display(Name = "remark")]
        public string Remark { get; set; }
    }

    public class AlipayTransQueryViewModel
    {
        [Display(Name = "product_code")]
        public string ProductCode { get; set; }

        [Display(Name = "biz_scene")]
        public string BizScene { get; set; }

        [Display(Name = "out_biz_no")]
        public string OutBizNo { get; set; }

        [Display(Name = "order_id")]
        public string OrderId { get; set; }

        [Display(Name = "pay_fund_order_id")]
        public string PayFundOrderId { get; set; }
    }

    public class AlipayAccountQueryViewModel
    {
        [Required]
        [Display(Name = "alipay_user_id")]
        public string AlipayUserId { get; set; }

        [Required]
        [Display(Name = "account_type")]
        public string AccountType { get; set; }
    }
}
