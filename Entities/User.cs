using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        [JsonIgnore]
        public List<RefreshToken> RefreshTokens { get; set; }
    }


    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        public int StoreId { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public int FeedbackTyoe { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string IssueDescribe { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string Contacts { get; set; }
        /// <summary>
        /// 图片一
        /// </summary>
        public string Screenshot1 { get; set; }
        /// <summary>
        /// 图片二
        /// </summary>
        public string Screenshot2 { get; set; }
        /// <summary>
        /// 图片三
        /// </summary>
        public string Screenshot3 { get; set; }
        /// <summary>
        /// 图片四
        /// </summary>
        public string Screenshot4 { get; set; }
        /// <summary>
        /// 图片五
        /// </summary>
        public string Screenshot5 { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreatedOnUtc { get; set; }
    }
}