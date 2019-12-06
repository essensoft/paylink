using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpFreedepositOrderriskQueryModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpFreedepositOrderriskQueryModel : AlipayObject
    {
        /// <summary>
        /// 本次使用免押金额，分
        /// </summary>
        [JsonPropertyName("current_use_limit")]
        public long CurrentUseLimit { get; set; }

        /// <summary>
        /// 企业证件号
        /// </summary>
        [JsonPropertyName("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业证件类型
        /// </summary>
        [JsonPropertyName("ep_cert_type")]
        public string EpCertType { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonPropertyName("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 首笔租金金额，分
        /// </summary>
        [JsonPropertyName("first_rent_amount")]
        public long FirstRentAmount { get; set; }

        /// <summary>
        /// 租期期数
        /// </summary>
        [JsonPropertyName("lease_periods")]
        public long LeasePeriods { get; set; }

        /// <summary>
        /// 租赁设备信息列表
        /// </summary>
        [JsonPropertyName("machine_info_list")]
        public List<MachineInfo> MachineInfoList { get; set; }

        /// <summary>
        /// 订单风控业务流水号，商户生成，每次业务保证唯一
        /// </summary>
        [JsonPropertyName("merchant_lease_order_no")]
        public string MerchantLeaseOrderNo { get; set; }

        /// <summary>
        /// 超出免押额度部分的应交押金(人民币分)
        /// </summary>
        [JsonPropertyName("need_pay_deposit_amount")]
        public long NeedPayDepositAmount { get; set; }

        /// <summary>
        /// 芝麻企业免押额度申请业务流水号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 付款日
        /// </summary>
        [JsonPropertyName("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 每期租金金额，分
        /// </summary>
        [JsonPropertyName("period_lease_amount")]
        public long PeriodLeaseAmount { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [JsonPropertyName("rec_address")]
        public string RecAddress { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [JsonPropertyName("rec_mobile")]
        public string RecMobile { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [JsonPropertyName("rec_name")]
        public string RecName { get; set; }

        /// <summary>
        /// 剩余可用免押金额，分
        /// </summary>
        [JsonPropertyName("remain_limit")]
        public long RemainLimit { get; set; }

        /// <summary>
        /// 租赁总金额，分
        /// </summary>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }
    }
}
