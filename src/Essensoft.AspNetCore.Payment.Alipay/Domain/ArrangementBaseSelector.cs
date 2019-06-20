using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArrangementBaseSelector Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementBaseSelector : AlipayObject
    {
        /// <summary>
        /// 合约状态列表.01 待生效，02 生效，03失效，04 取消
        /// </summary>
        [JsonProperty("ar_statuses")]
        public List<string> ArStatuses { get; set; }

        /// <summary>
        /// 产品外标类型:01：机构产品 02：借款人信息 03：主站产品 04： 标准机构产品  05：内部业务平台标准产品
        /// </summary>
        [JsonProperty("mark_type")]
        public string MarkType { get; set; }

        /// <summary>
        /// 产品编码列表
        /// </summary>
        [JsonProperty("pd_codes")]
        public List<string> PdCodes { get; set; }

        /// <summary>
        /// 产品外标列表
        /// </summary>
        [JsonProperty("pd_marks")]
        public List<string> PdMarks { get; set; }

        /// <summary>
        /// 是否查询出产品外标
        /// </summary>
        [JsonProperty("select_pd_mark")]
        public bool SelectPdMark { get; set; }

        /// <summary>
        /// 是否查询出产品名称
        /// </summary>
        [JsonProperty("select_pd_name")]
        public bool SelectPdName { get; set; }
    }
}
