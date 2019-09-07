using System.ComponentModel.DataAnnotations;

namespace WebApplicationSample_V3_0.Models
{
    public class QPayMicroPayViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Required]
        [Display(Name = "body")]
        public string Body { get; set; }

        [Required]
        [Display(Name = "fee_type")]
        public string FeeType { get; set; }

        [Required]
        [Display(Name = "total_fee")]
        public int TotalFee { get; set; }

        [Required]
        [Display(Name = "spbill_create_ip")]
        public string SpBillCreateIp { get; set; }

        [Required]
        [Display(Name = "device_info")]
        public string DeviceInfo { get; set; }

        [Required]
        [Display(Name = "auth_code")]
        public string AuthCode { get; set; }

        [Required]
        [Display(Name = "trade_type")]
        public string TradeType { get; set; }

        [Required]
        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }
    }

    public class QPayUnifiedOrderViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Required]
        [Display(Name = "body")]
        public string Body { get; set; }

        [Required]
        [Display(Name = "fee_type")]
        public string FeeType { get; set; }

        [Required]
        [Display(Name = "total_fee")]
        public int TotalFee { get; set; }

        [Required]
        [Display(Name = "spbill_create_ip")]
        public string SpBillCreateIp { get; set; }

        [Required]
        [Display(Name = "trade_type")]
        public string TradeType { get; set; }

        [Required]
        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }
    }

    public class QPayOrderQueryViewModel
    {
        [Display(Name = "transaction_id")]
        public string TransactionId { get; set; }

        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }
    }

    public class QPayReverseViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }
    }

    public class QPayCloseOrderViewModel
    {
        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }
    }

    public class QPayRefundViewModel
    {
        [Required]
        [Display(Name = "out_refund_no")]
        public string OutRefundNo { get; set; }

        [Display(Name = "transaction_id")]
        public string TransactionId { get; set; }

        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Required]
        [Display(Name = "refund_fee")]
        public int RefundFee { get; set; }

        [Required]
        [Display(Name = "op_user_id")]
        public string OpUserId { get; set; }

        [Required]
        [Display(Name = "op_user_passwd")]
        public string OpUserPasswd { get; set; }
    }

    public class QPayRefundQueryViewModel
    {
        [Display(Name = "refund_id")]
        public string RefundId { get; set; }

        [Display(Name = "out_refund_no")]
        public string OutRefundNo { get; set; }

        [Display(Name = "transaction_id")]
        public string TransactionId { get; set; }

        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }
    }

    public class QPayStatementDownViewModel
    {
        [Required]
        [Display(Name = "bill_date")]
        public string BillDate { get; set; }

        [Required]
        [Display(Name = "bill_type")]
        public string BillType { get; set; }

        [Display(Name = "tar_type")]
        public string TarType { get; set; }
    }

    public class QPayB2CPayViewModel
    {
        [Display(Name = "openid")]
        public string OpenId { get; set; }

        [Display(Name = "uin")]
        public string Uin { get; set; }

        [Required]
        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Display(Name = "total_fee")]
        [Required]
        public int TotalFee { get; set; }

        [Display(Name = "memo")]
        public string Memo { get; set; }

        [Display(Name = "check_real_name")]
        public string CheckRealName { get; set; }

        [Required]
        [Display(Name = "op_user_id")]
        public string OpUserId { get; set; }

        [Required]
        [Display(Name = "op_user_passwd")]
        public string OpUserPasswd { get; set; }

        [Required]
        [Display(Name = "spbill_create_ip")]
        public string SpBillCreateIp { get; set; }

        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }
    }
}
