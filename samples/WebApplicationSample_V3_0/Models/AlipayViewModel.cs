using System.ComponentModel.DataAnnotations;

namespace WebApplicationSample_V3_0.Models
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
    
    public class AlipayTransferViewModel
    {
        [Required]
        [Display(Name = "out_biz_no")]
        public string OutBizNo { get; set; }

        [Required]
        [Display(Name = "payee_account")]
        public string PayeeAccount { get; set; }

        [Required]
        [Display(Name = "payee_type")]
        public string PayeeType { get; set; }

        [Required]
        [Display(Name = "amount")]
        public string Amount { get; set; }

        [Display(Name = "remark")]
        public string Remark { get; set; }
    }

    public class AlipayTransQueryViewModel
    {
        [Display(Name = "out_biz_no")]
        public string OutBizNo { get; set; }

        [Display(Name = "order_id")]
        public string OrderId { get; set; }
    }

    public class AlipayBillDownloadurlQueryViewModel
    {
        [Required]
        [Display(Name = "bill_type")]
        public string BillType { get; set; }

        [Required]
        [Display(Name = "bill_date")]
        public string BillDate { get; set; }
    }
}
