using System;
using System.Collections.Generic;
using System.Text;
   
   
    public class AddressesItem
{
    
    /// <summary>
    /// 
    /// </summary>
    public long addressId { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public long parentId { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string parentType { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string parentName { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string entityStatus { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string type { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string isDefault { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string country { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string line1 { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string line2 { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string line3 { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string city { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string state { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string zip { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string status { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string primaryPhoneType { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string primaryPhone { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string phone2Type { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string phone2 { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string phone3Type { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string phone3 { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string phone4Type { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string phone4 { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string keyPersonFirstName { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string keyPersonLastName { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string keyPersonTitle { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string keyPersonEmail { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string keyPersonPhone1Type { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string keyPersonPhone1 { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string keyPersonPhone2Type { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string keyPersonPhone2 { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string comments { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string createdBy { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string createdDate { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string lastModifiedBy { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string lastModifiedDate { get; set; }
}

public class RootAddresses
{
    
    /// <summary>
    /// 
    /// </summary>
    public int totalItems { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public int page { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public int pageSize { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public List <AddressesItem > addresses { get; set; }
}

