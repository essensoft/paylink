using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransAppMergeConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransAppMergeConfirmModel : AlipayObject
    {
        /// <summary>
        /// 业务场景。  DINGTALK_PERSONAL_PAY：钉钉个人付款  DINGTALK_MERCHANT_PAY：钉钉企业付款  DINGTALK_MERCHANT_COLLECTION：钉钉企业收款
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 合并转账的预下单id
        /// </summary>
        [JsonProperty("merge_order_id")]
        public string MergeOrderId { get; set; }

        /// <summary>
        /// 销售产品码。  STD_APP_TRANSFER：支付宝APP收银台转账
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }
    }
}
