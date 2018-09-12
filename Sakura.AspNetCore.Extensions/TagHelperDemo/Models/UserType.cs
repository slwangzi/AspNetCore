using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelperDemo
{
    public enum UserType
    {
        [Display(Name = "来宾", Description = "来宾用户")]
        Guest,
        [Display(Name = "用户", Description = "普通用户")]
        User,
        [Display(Name = "管理员", Description = "系统管理员")]
        Admin,
    }

    public class User
    {
        public int UserId { get; set; }

        public UserType MemberType { get; set; } = UserType.Admin;

        public Features Features { get; set; } = Features.CanWrite;

        public void SetVV()
        {
        }
    }


    [Flags]
    public enum Features
    {
        None = 0x0,
        CanRead = 0x1,
        CanWrite = 0x2,
        CanSeek = 0x4
    }

}
