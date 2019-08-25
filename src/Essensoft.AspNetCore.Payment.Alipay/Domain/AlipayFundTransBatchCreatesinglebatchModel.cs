using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransBatchCreatesinglebatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransBatchCreatesinglebatchModel : AlipayObject
    {
        /// <summary>
        /// 批次的创建说明，如收款理由等。注：字符长度不能超过24；字符串中不能含有特殊字符（比如emoji等）
        /// </summary>
        [JsonProperty("batch_memo")]
        public string BatchMemo { get; set; }

        /// <summary>
        /// 业务类型,目前支持下面三种业务类型， (AA收款 :aa, 江湖救急 :support , 活动收款:general)，
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 创建者id（该id为用户的支付宝id，需要调用方自己进行转换传入）
        /// </summary>
        [JsonProperty("create_user_id")]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 扩展参数,目前淘系会传商品类目过来key=categoryNo。注：长度不可超过100; 数据格式需要为map<String,String>的json串
        /// </summary>
        [JsonProperty("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 单笔金额，单位为元。注： AA收款为平均后的金额；活动收款为单笔金额； 江湖救急不填写
        /// </summary>
        [JsonProperty("pay_amount_single")]
        public string PayAmountSingle { get; set; }

        /// <summary>
        /// 总金额，单位为元。注：AA为收款总金额；活动收款为份数和单笔金额的积；江湖救急为目标金额
        /// </summary>
        [JsonProperty("pay_amount_total")]
        public string PayAmountTotal { get; set; }

        /// <summary>
        /// 实际要创建的笔数。注：AA包括自己这里为show_items_total-1；活动收款为填写的份数;江湖救急不填写
        /// </summary>
        [JsonProperty("real_items_total")]
        public string RealItemsTotal { get; set; }

        /// <summary>
        /// 显示的总笔数。注：AA收款为选择的人数；活动收款为填写的份数；江湖救急不填写
        /// </summary>
        [JsonProperty("show_items_total")]
        public string ShowItemsTotal { get; set; }
    }
}
