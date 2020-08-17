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
        /// ���
        /// </summary>
        public int FeedbackTyoe { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string IssueDescribe { get; set; }
        /// <summary>
        /// ��ϵ��ʽ
        /// </summary>
        public string Contacts { get; set; }
        /// <summary>
        /// ͼƬһ
        /// </summary>
        public string Screenshot1 { get; set; }
        /// <summary>
        /// ͼƬ��
        /// </summary>
        public string Screenshot2 { get; set; }
        /// <summary>
        /// ͼƬ��
        /// </summary>
        public string Screenshot3 { get; set; }
        /// <summary>
        /// ͼƬ��
        /// </summary>
        public string Screenshot4 { get; set; }
        /// <summary>
        /// ͼƬ��
        /// </summary>
        public string Screenshot5 { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? CreatedOnUtc { get; set; }
    }
}