using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppMerchantExternalbillSyncModel Data Structure.
    /// </summary>
    public class AlipayEbppMerchantExternalbillSyncModel : AlipayObject
    {
        /// <summary>
        /// yyyyMMdd+0(DB_FLAG)+0070(SYSTEM_FLAG)+018(SUB_BIZ_FLAG,新建)+0000(预留)+DB_SPLIT(BIZ_TYPE+SUB_BIZTYPE+MERCHANT_CODE, 2位)+TABLE_FLAG(MERCHANT_CODE, 2位)+8位全局唯一nextValue
        /// </summary>
        [JsonPropertyName("alipay_bill_id")]
        public string AlipayBillId { get; set; }

        /// <summary>
        /// 账期金额,单位元
        /// </summary>
        [JsonPropertyName("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 账期描述
        /// </summary>
        [JsonPropertyName("bill_date_desc")]
        public string BillDateDesc { get; set; }

        /// <summary>
        /// 账期结束时间
        /// </summary>
        [JsonPropertyName("bill_date_end")]
        public string BillDateEnd { get; set; }

        /// <summary>
        /// 账期起始时间
        /// </summary>
        [JsonPropertyName("bill_date_start")]
        public string BillDateStart { get; set; }

        /// <summary>
        /// 账单过期时间, 可为空, 默认2099年
        /// </summary>
        [JsonPropertyName("expiry_date")]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// PROPERTY_MNG("PROPERTY_MNG", "物业费"), PROPERTY_WATER("PROPERTY_WATER", "代收水费"), PROPERTY_ELECTRIC("PROPERTY_ELECTRIC", "代收电费"), PROPERTY_SHARE("PROPERTY_SHARE", "公共维护金"), PROPERTY_PARK_MNG("PROPERTY_PARK_MNG", "车位管理费"), PROPERTY_PARK_LEASE("PROPERTY_PARK_LEASE", "车位租赁费"), PROPERTY_ROOM_LEASE("PROPERTY_ROOM_LEASE", "房屋租赁费"), PROPERTY_TEMP_PARK("PROPERTY_TEMP_PARK", "临时停车费"); PROPERTY_PUBLIC_ENERGY("PROPERTY_PUBLIC_ENERGY", "代收公共能耗费"), PROPERTY_GAS("PROPERTY_GAS", "代收燃气费"), PROPERTY_MAINTENANCE("PROPERTY_MAINTENANCE", "维修服务费"), PROPERTY_HOUSEKEEPING("PROPERTY_HOUSEKEEPING", "家政服务费"), PROPERTY_GREENING("PROPERTY_GREENING", "绿化服务费");
        /// </summary>
        [JsonPropertyName("fee_type")]
        public string FeeType { get; set; }

        /// <summary>
        /// 滞纳金, 单位元
        /// </summary>
        [JsonPropertyName("fine_amount")]
        public string FineAmount { get; set; }

        /// <summary>
        /// 滞纳金产生时间, 空代表不会出现滞纳金
        /// </summary>
        [JsonPropertyName("fine_date")]
        public string FineDate { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 账单生效时间
        /// </summary>
        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// 该账单是否用户可选 ，1 可选 0不可选，默认不可选
        /// </summary>
        [JsonPropertyName("select_optional")]
        public string SelectOptional { get; set; }

        /// <summary>
        /// 账单排列顺序，大于0时生效
        /// </summary>
        [JsonPropertyName("sequence")]
        public long Sequence { get; set; }

        /// <summary>
        /// 服务费, 单位元
        /// </summary>
        [JsonPropertyName("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 动账来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// FINISH_PAY/REFUND
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 账单总金额,单位 元
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
