using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeBillBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayEcoCplifeBillBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 查询过滤条件之一：  根据账期查询
        /// </summary>
        [JsonPropertyName("acct_period")]
        public string AcctPeriod { get; set; }

        /// <summary>
        /// 查询过滤条件之一：  根据开发者上传物业费账单时需要的批次号查询指定批次下上传成功的账单。
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 查询过滤条件之一：根据账单状态查询，不传该字段则返回所有状态的账单。    状态值：  FINISH_PAYMENT - 用户完成支付和销账  UNDER_PAYMENT - 账单锁定待用户完成支付  WAIT_PAYMENT - 待缴且未过缴费截止日期  OUT_OF_DATE - 未支付且已过缴费截止日期
        /// </summary>
        [JsonPropertyName("bill_status")]
        public string BillStatus { get; set; }

        /// <summary>
        /// 支付宝社区小区统一编号，必须在授权物业账号名下存在。
        /// </summary>
        [JsonPropertyName("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 查询过滤条件之一：  根据费用类型查询，只支持精确查询。
        /// </summary>
        [JsonPropertyName("cost_type")]
        public string CostType { get; set; }

        /// <summary>
        /// 查询过滤条件之一：  根据物业系统端房屋编号查询
        /// </summary>
        [JsonPropertyName("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 分页查询的当前页码数，分页从1开始计数。  该参数不传入的时候，默认为1。
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询的每页最大数据条数，取值范围1-500。  不传该参数默认为200。
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询过滤条件之一：  根据出账日期查询，格式为YYYYMMDD，只支持精确查询。
        /// </summary>
        [JsonPropertyName("release_day")]
        public string ReleaseDay { get; set; }
    }
}
