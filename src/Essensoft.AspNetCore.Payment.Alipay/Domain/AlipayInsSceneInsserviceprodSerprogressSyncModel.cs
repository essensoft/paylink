using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerprogressSyncModel Data Structure.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerprogressSyncModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁服务合约编号
        /// </summary>
        [JsonPropertyName("ant_ser_contract_no")]
        public string AntSerContractNo { get; set; }

        /// <summary>
        /// 蚂蚁服务产品号
        /// </summary>
        [JsonPropertyName("ant_ser_prod_no")]
        public string AntSerProdNo { get; set; }

        /// <summary>
        /// 扩展信息，JSON字符串格式。该接口为通用接口，需要和增值服务中台的开发同学根据不同的业务约定不同的字段。
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 状态变更时间
        /// </summary>
        [JsonPropertyName("change_time")]
        public string ChangeTime { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 服务业务单号
        /// </summary>
        [JsonPropertyName("ser_biz_no")]
        public string SerBizNo { get; set; }

        /// <summary>
        /// 服务业务类型
        /// </summary>
        [JsonPropertyName("ser_biz_type")]
        public string SerBizType { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
