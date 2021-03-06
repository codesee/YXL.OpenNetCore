﻿// =================================================================== 
// 项目说明
//====================================================================
// YXL @ CopyRight 2006-2010
// 文件： GrantTypeEntity.cs
// 项目名称：Asp.Net Core 2.0 mvc 开源权限系统Demo 
// 创建时间：2017-10-25
// 负责人：杨小乐
// ===================================================================
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PermissionSystem.Models;
namespace PermissionSystem.Mapping
{
	/// <summary>
	///GrantType数据实体
	/// </summary>
	internal class GrantTypeMapping
	{  
        
       public static void Mapping(EntityTypeBuilder<GrantType> table)
       {
            table.HasKey(a=>a.ID); 
            table.Property(a=>a.ID).IsRequired();
            table.Property(a=>a.Name).IsRequired();
            table.Property(a=>a.ValueData).IsRequired();
       
            table.HasMany(a => a.ClientGrantTypes_GrantTypeIDList).WithOne(a => a.GrantTypeID_Model);       
        
        
        
      
       }
	}
	
}