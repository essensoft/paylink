using System.ComponentModel.DataAnnotations;

namespace WebApplicationSample_V3_0.Models
{
    public class GatewayPayFrontConsumeFrontConsumeViewModel
    {
        [Required]
        [Display(Name = "orderId")]
        public string OrderId { get; set; }

        [Required]
        [Display(Name = "txnTime")]
        public string TxnTime { get; set; }

        [Required]
        [Display(Name = "txnAmt")]
        public string TxnAmt { get; set; }

        [Required]
        [Display(Name = "currencyCode")]
        public string CurrencyCode { get; set; }

        [Display(Name = "payTimeout")]
        public string PayTimeOut { get; set; }

        [Display(Name = "frontUrl")]
        public string FrontUrl { get; set; }

        [Required]
        [Display(Name = "backUrl")]
        public string BackUrl { get; set; }
    }
}
