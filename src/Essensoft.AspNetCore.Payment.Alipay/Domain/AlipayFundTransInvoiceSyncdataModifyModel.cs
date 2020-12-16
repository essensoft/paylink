using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransInvoiceSyncdataModifyModel Data Structure.
    /// </summary>
    public class AlipayFundTransInvoiceSyncdataModifyModel : AlipayObject
    {
        /// <summary>
        /// 票据总金额（元）
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 所属地区，用于区分不同地区票据应用
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; set; }

        /// <summary>
        /// 票据文件格式(PDF,JPG等) 目前只支持PDF
        /// </summary>
        [JsonPropertyName("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 票据代码
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 票据名称
        /// </summary>
        [JsonPropertyName("invoice_name")]
        public string InvoiceName { get; set; }

        /// <summary>
        /// 票据号码
        /// </summary>
        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// 发票类型(person：个人，enterprise：企业)
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 1 是区块链 0 非区块链
        /// </summary>
        [JsonPropertyName("is_block")]
        public string IsBlock { get; set; }

        /// <summary>
        /// 默认0，是否是历史数据同步。历史数据不发蚂蚁森林能量  0 非历史数据 1 是历史数据
        /// </summary>
        [JsonPropertyName("is_old_data_sync")]
        public string IsOldDataSync { get; set; }

        /// <summary>
        /// 支付宝开票流水号，可空。核对使用
        /// </summary>
        [JsonPropertyName("open_biz_no")]
        public string OpenBizNo { get; set; }

        /// <summary>
        /// 票据开具单位代码
        /// </summary>
        [JsonPropertyName("party_code")]
        public string PartyCode { get; set; }

        /// <summary>
        /// 票据开具单位名称
        /// </summary>
        [JsonPropertyName("party_name")]
        public string PartyName { get; set; }

        /// <summary>
        /// 付款人统一信用代码
        /// </summary>
        [JsonPropertyName("payer_id")]
        public string PayerId { get; set; }

        /// <summary>
        /// 当user_id不传值时payer_id_type必须传值，含义为用户身份标识类型 1 身份证
        /// </summary>
        [JsonPropertyName("payer_id_type")]
        public string PayerIdType { get; set; }

        /// <summary>
        /// 当user_id为空时，payer_id_value必须传值，内容为与payer_id_type对应的标识值，如身份证号130xxx
        /// </summary>
        [JsonPropertyName("payer_id_value")]
        public string PayerIdValue { get; set; }

        /// <summary>
        /// 付款人姓名
        /// </summary>
        [JsonPropertyName("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 票据状态: 1正常，2作废，3已报销，4已换开 5红冲
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 开票时间(UTC时间戳精确到秒)
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// 票据状态: 1医疗，2捐赠，3教育，4罚没，5其他
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// PDF票据URL(目前不支持传图片URL)
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 支付宝用户id,若为空，则payer_id_type,payer_id_valuey用户身份标识内容必填
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [JsonPropertyName("verify")]
        public string Verify { get; set; }
    }
}
