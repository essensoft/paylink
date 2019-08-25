using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseLeaseOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseLeaseOrderSyncModel : AlipayObject
    {
        /// <summary>
        /// 预览合同二进制流 预览合同html的Base64字符串
        /// </summary>
        [JsonProperty("attach_file")]
        public string AttachFile { get; set; }

        /// <summary>
        /// 租约开始时间格式 YYYY-MM-dd
        /// </summary>
        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 定金信息
        /// </summary>
        [JsonProperty("book_info")]
        public AlipayEcoRenthouseBookInfo BookInfo { get; set; }

        /// <summary>
        /// 证件编号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 证件类型 不传默认是0  0-身份证；   1-护照； 暂时只支持身份证  2-军人身份证；   3-港澳居民来往内地通行证；   4-台湾同胞来往内地通行证；   5-临时身份证；   6-户口簿；   7-警官证；   8-外国人永久居住证
        /// </summary>
        [JsonProperty("card_type")]
        public long CardType { get; set; }

        /// <summary>
        /// 租约结束时间格式 YYYY-MM-dd
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 房源类型  1:分散式  2:集中式
        /// </summary>
        [JsonProperty("flats_tag")]
        public long FlatsTag { get; set; }

        /// <summary>
        /// 押金金额
        /// </summary>
        [JsonProperty("foregift_amount")]
        public string ForegiftAmount { get; set; }

        /// <summary>
        /// 0:不免押金 1:免押金 默认 0（不免押金）
        /// </summary>
        [JsonProperty("free_deposit")]
        public long FreeDeposit { get; set; }

        /// <summary>
        /// 家具清单  1-床  2-床垫  3-床头柜  4-衣柜  5-桌子  6-椅子  7-窗帘  8-台灯  9-电视  10-电视柜  11-遥控器  12-空调  13-抽油烟机  14-燃气灶  15-冰箱  16-微波炉  17-餐桌  18-餐椅  19-洗衣机  20-烘干机  21-沙发  22-热水器
        /// </summary>
        [JsonProperty("furniture_items")]
        public string FurnitureItems { get; set; }

        /// <summary>
        /// 通过"文件上传"接口返回的租约相关图片url路径。租约照片可录入0~10张,目前仅支持jpg、png、jpeg格式
        /// </summary>
        [JsonProperty("images")]
        public string Images { get; set; }

        /// <summary>
        /// KA租约业务号
        /// </summary>
        [JsonProperty("lease_code")]
        public string LeaseCode { get; set; }

        /// <summary>
        /// 租约创建时间,格式yyyy-MM-dd HH:mm:ss  不传时默认系统时间
        /// </summary>
        [JsonProperty("lease_create_time")]
        public string LeaseCreateTime { get; set; }

        /// <summary>
        /// 租约状态  0-未确认  1-已确认  2-已退房  3-已撤销
        /// </summary>
        [JsonProperty("lease_status")]
        public long LeaseStatus { get; set; }

        /// <summary>
        /// 1-电子合约(默认)  2-纸质合约
        /// </summary>
        [JsonProperty("lease_type")]
        public long LeaseType { get; set; }

        /// <summary>
        /// 续租原KA租约业务号（也就是第一期的lease_code）
        /// </summary>
        [JsonProperty("original_lease_code")]
        public string OriginalLeaseCode { get; set; }

        /// <summary>
        /// 其他费用描述
        /// </summary>
        [JsonProperty("other_fee_desc")]
        public string OtherFeeDesc { get; set; }

        /// <summary>
        /// 租金付款方式  1-付一；  2-付二；  3-付三；  4-付四；  5-付五；  6-付六；  7-付七；  8-付八；  9-付九；  10-付十；  11-付十一；  12-付十二；
        /// </summary>
        [JsonProperty("pay_type")]
        public long PayType { get; set; }

        /// <summary>
        /// 信用减免金额
        /// </summary>
        [JsonProperty("rebate_amount")]
        public string RebateAmount { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 0-不是续租(默认值)  1-是续租
        /// </summary>
        [JsonProperty("renew_lease")]
        public long RenewLease { get; set; }

        /// <summary>
        /// 第几期续租
        /// </summary>
        [JsonProperty("renew_num")]
        public long RenewNum { get; set; }

        /// <summary>
        /// 收租日描述
        /// </summary>
        [JsonProperty("rent_day_desc")]
        public string RentDayDesc { get; set; }

        /// <summary>
        /// "租金包含相关费用 1-水费；  2-电费；  3-煤气费；  4-有线电视费；  5-网络宽带费；  6-物业管理费；  7-室内设施维修费（人为使用不当除外）；  8-保洁费；  9-暖气费；"
        /// </summary>
        [JsonProperty("rent_include_fee_desc")]
        public List<string> RentIncludeFeeDesc { get; set; }

        /// <summary>
        /// 1-男   2-女
        /// </summary>
        [JsonProperty("renter_gender")]
        public string RenterGender { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonProperty("renter_name")]
        public string RenterName { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [JsonProperty("renter_phone")]
        public string RenterPhone { get; set; }

        /// <summary>
        /// 房源编号  flatsTag为1,则代表单编号 2,代表房型编号
        /// </summary>
        [JsonProperty("room_code")]
        public string RoomCode { get; set; }

        /// <summary>
        /// 房间号   集中式的时候必填
        /// </summary>
        [JsonProperty("room_num")]
        public string RoomNum { get; set; }

        /// <summary>
        /// 租金金额 比如 2500 2500.5 3000.05等
        /// </summary>
        [JsonProperty("sale_amount")]
        public string SaleAmount { get; set; }
    }
}
