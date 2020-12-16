using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduPayItems Data Structure.
    /// </summary>
    public class EduPayItems : AlipayObject
    {
        /// <summary>
        /// 缴费项是否必选 如果缴费项是多选模式，此参数生效。 “Y”表示必填，“N”或空表示非必填。
        /// </summary>
        [JsonPropertyName("item_mandatory")]
        public string ItemMandatory { get; set; }

        /// <summary>
        /// 缴费项最大可选数 如果缴费项是多选模式，此参数生效，范围是1-9，如果为空，则最大项默认为9
        /// </summary>
        [JsonPropertyName("item_maximum")]
        public long ItemMaximum { get; set; }

        /// <summary>
        /// 缴费项名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 缴费项金额
        /// </summary>
        [JsonPropertyName("item_price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 缴费项序号，如果缴费项是多选模式，此项为必填，建议从1开始的连续数字， 用户支付成功后，通过passback_params参数带回已选择的缴费项。例如:orderNo=uoo234234&isvOrderNo=24werwe&items=1-2|2-1|3-5 1-2|2-1|3-5 表示：缴费项序列号-缴费项数|缴费项序列号-缴费项数
        /// </summary>
        [JsonPropertyName("item_serial_number")]
        public long ItemSerialNumber { get; set; }
    }
}
