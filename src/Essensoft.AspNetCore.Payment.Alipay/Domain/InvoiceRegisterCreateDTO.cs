using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceRegisterCreateDTO Data Structure.
    /// </summary>
    public class InvoiceRegisterCreateDTO : AlipayObject
    {
        /// <summary>
        /// 企业税务信息
        /// </summary>
        [JsonPropertyName("invoice_company_dto")]
        public InvoiceCompanyDTO InvoiceCompanyDto { get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [JsonPropertyName("invoice_contact_dto")]
        public InvoiceContactDTO InvoiceContactDto { get; set; }

        /// <summary>
        /// 服务市场订单信息
        /// </summary>
        [JsonPropertyName("invoice_order_dto_list")]
        public List<InvoiceOrderDTO> InvoiceOrderDtoList { get; set; }

        /// <summary>
        /// 外部业务幂等ID，由业务平台自己生成
        /// </summary>
        [JsonPropertyName("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 业务平台code, 由发票中台分配
        /// </summary>
        [JsonPropertyName("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 业务平台商户ID/用户ID
        /// </summary>
        [JsonPropertyName("platform_user_id")]
        public string PlatformUserId { get; set; }

        /// <summary>
        /// 税控产品，产品码由中台定义
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 入驻类型，可选值：new：新订购，服务市场订购入驻场景，proxy：代理入驻模式，适用于代记账平台场景，online：已有税控初始化/绑定已有税控产品
        /// </summary>
        [JsonPropertyName("register_type")]
        public string RegisterType { get; set; }
    }
}
