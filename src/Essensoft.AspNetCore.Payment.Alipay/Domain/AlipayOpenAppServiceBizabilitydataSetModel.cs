using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceBizabilitydataSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceBizabilitydataSetModel : AlipayObject
    {
        /// <summary>
        /// 操作类型.PUT:新增或覆盖,REMOVE:删除
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// 批次的唯一编号,对应本批次上传的多条意图数据，开发者自定义
        /// </summary>
        [JsonProperty("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 用于标识数据所属的服务类目
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 推送到服务库的数据列表
        /// </summary>
        [JsonProperty("data_list")]
        public List<BizAbilityData> DataList { get; set; }

        /// <summary>
        /// 服务业务能力数据类型，支持：ITEM_SUMMARY(商品摘要)、USER_INTENSION(用户意图数据)、FUNCTION(服务功能)
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
