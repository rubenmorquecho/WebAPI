using System;
using System.Collections.Generic;
using System.Text;
   
   public class CustomFieldsItem
{
    
    /// <summary>
    /// 
    /// </summary>
    public long definitionId { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string name { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string value { get; set; }
}

public class ResponseItem
{
    
    /// <summary>
    /// 
    /// </summary>
    public long entityId { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public List <CustomFieldsItem > customFields { get; set; }
}

public class RootCustomFields
{
    
    /// <summary>
    /// 
    /// </summary>
    public List <ResponseItem > response { get; set; }
}


