/* 
 * My title
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = IO.Swagger.Client.OpenAPIDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Defines WeekDays
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum WeekDays
    {
        
        /// <summary>
        /// Enum Sun for value: sun
        /// </summary>
        [EnumMember(Value = "sun")]
        Sun = 1,
        
        /// <summary>
        /// Enum Mon for value: mon
        /// </summary>
        [EnumMember(Value = "mon")]
        Mon = 2,
        
        /// <summary>
        /// Enum Tue for value: tue
        /// </summary>
        [EnumMember(Value = "tue")]
        Tue = 3,
        
        /// <summary>
        /// Enum Wed for value: wed
        /// </summary>
        [EnumMember(Value = "wed")]
        Wed = 4,
        
        /// <summary>
        /// Enum Thu for value: thu
        /// </summary>
        [EnumMember(Value = "thu")]
        Thu = 5,
        
        /// <summary>
        /// Enum Fri for value: fri
        /// </summary>
        [EnumMember(Value = "fri")]
        Fri = 6,
        
        /// <summary>
        /// Enum Sat for value: sat
        /// </summary>
        [EnumMember(Value = "sat")]
        Sat = 7
    }

}
