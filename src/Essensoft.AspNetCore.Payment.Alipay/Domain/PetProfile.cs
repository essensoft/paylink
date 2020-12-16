using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PetProfile Data Structure.
    /// </summary>
    public class PetProfile : AlipayObject
    {
        /// <summary>
        /// 宠物资料是否齐全 0 不齐全 1 齐全
        /// </summary>
        [JsonPropertyName("doc_complete")]
        public long DocComplete { get; set; }

        /// <summary>
        /// 档案状态，0 档案创建 1 档案暂存
        /// </summary>
        [JsonPropertyName("doc_status")]
        public long DocStatus { get; set; }

        /// <summary>
        /// 身份证号码,全局唯一
        /// </summary>
        [JsonPropertyName("identify_id")]
        public string IdentifyId { get; set; }

        /// <summary>
        /// 鼻纹ID
        /// </summary>
        [JsonPropertyName("nose_print_id")]
        public string NosePrintId { get; set; }

        /// <summary>
        /// 鼻纹最后上传时间
        /// </summary>
        [JsonPropertyName("nose_print_last_upload_time")]
        public string NosePrintLastUploadTime { get; set; }

        /// <summary>
        /// 宠物生日
        /// </summary>
        [JsonPropertyName("pet_birthday")]
        public string PetBirthday { get; set; }

        /// <summary>
        /// 宠物是否可编辑
        /// </summary>
        [JsonPropertyName("pet_edit")]
        public bool PetEdit { get; set; }

        /// <summary>
        /// 宠物性别
        /// </summary>
        [JsonPropertyName("pet_gender")]
        public string PetGender { get; set; }

        /// <summary>
        /// 宠物ID
        /// </summary>
        [JsonPropertyName("pet_id")]
        public string PetId { get; set; }

        /// <summary>
        /// 宠物昵称
        /// </summary>
        [JsonPropertyName("pet_nick")]
        public string PetNick { get; set; }

        /// <summary>
        /// 是否绝育，0否，1是
        /// </summary>
        [JsonPropertyName("pet_no_baby")]
        public string PetNoBaby { get; set; }

        /// <summary>
        /// 宠物照片列表
        /// </summary>
        [JsonPropertyName("pet_pic_param_list")]
        public List<PetPicData> PetPicParamList { get; set; }

        /// <summary>
        /// 宠物种类
        /// </summary>
        [JsonPropertyName("pet_species")]
        public string PetSpecies { get; set; }

        /// <summary>
        /// 宠物种类编码
        /// </summary>
        [JsonPropertyName("pet_species_code")]
        public string PetSpeciesCode { get; set; }

        /// <summary>
        /// '宠物类别:code编码, 猫、狗等'
        /// </summary>
        [JsonPropertyName("pet_type")]
        public string PetType { get; set; }

        /// <summary>
        /// 宠物投保的保单状态
        /// </summary>
        [JsonPropertyName("policy_status")]
        public long PolicyStatus { get; set; }
    }
}
