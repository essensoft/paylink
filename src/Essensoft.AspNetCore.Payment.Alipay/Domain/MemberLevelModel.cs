using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MemberLevelModel Data Structure.
    /// </summary>
    [Serializable]
    public class MemberLevelModel : AlipayObject
    {
        /// <summary>
        /// 模板会员下的等级编号
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 会员级别对应icon， 通过接口（alipay.offline.material.image.upload）上传图片
        /// </summary>
        [JsonProperty("icon_img")]
        public string IconImg { get; set; }

        /// <summary>
        /// 必须从0开始有序  会员模板下的等级，比如会员模板下有普通会员，中级会员，高级会员三种等级，则分别对应0，1，2
        /// </summary>
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// 会员模板下会员等级的展示名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 栏位信息
        /// </summary>
        [JsonProperty("view_column_infos")]
        public List<ViewColumnInfoModel> ViewColumnInfos { get; set; }

        /// <summary>
        /// 模板样式信息
        /// </summary>
        [JsonProperty("view_style_info")]
        public ViewStyleInfoModel ViewStyleInfo { get; set; }
    }
}
