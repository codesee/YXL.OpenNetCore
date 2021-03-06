﻿// =================================================================== 
// 项目说明
//====================================================================
// YXL @ CopyRight 2006-2010
// 文件： LogEntity.cs
// 项目名称：Asp.Net Core 2.0 mvc 开源权限系统Demo 
// 创建时间：2017-10-25
// 负责人：杨小乐
// ===================================================================
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PermissionSystem.Models;
namespace PermissionSystem.Mapping
{
	/// <summary>
	///Log数据实体
	/// </summary>
	internal class LogMapping
	{  
        
       public static void Mapping(EntityTypeBuilder<Log> table)
       {
            table.HasKey(a=>a.ID); 
            table.Property(a=>a.ID).IsRequired();
            table.Property(a=>a.KeyWord);
            table.Property(a=>a.ShortMessage);
            table.Property(a=>a.FullMessage).IsRequired();
            table.Property(a=>a.LogLeve).IsRequired();
            table.Property(a=>a.IpAddress).IsRequired();
            table.Property(a=>a.ServerIpAddress).IsRequired();
            table.Property(a=>a.PageUrl);
            table.Property(a=>a.ReferrerUrl);
            table.Property(a=>a.CreateDate).IsRequired();
       
        
        
        
      
       }
	}
	
}