using System;
using System.Collections.Generic;
using System.Text;
   
   
   public class EntitiesItem
{
    
    /// <summary>
    /// 
    /// </summary>
    public long entityId { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string name { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string type { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string domesticJurisdiction { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string country { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string formationDate { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string status { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string businessStructureType { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string registeredAgent { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string acquiredDate { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string acronym { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string businessGroup { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string businessPurpose { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string federalTaxId { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string charterId { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string comments { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string publicOrPrivate { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string webLink { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string fileDate { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string reinstatementDate { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string durationType { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string fileShare { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string treatAsPassthroughEntity { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string treatAsCorporation { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string treatAsPartnership { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string managementMethod { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string isLLCSoleManaged { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string additionalInfo { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string primaryResponsibleUser { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string secondaryResponsibleUser { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string terminationDate { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string terminationReason { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string managementStructureRules { get; set; }    
    /// <summary>
    /// 
    /// </summary>
    public string isEvidenceReceived { get; set; }    
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

public class RootEntitiesItem
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
    public List <EntitiesItem > entities { get; set; }
}

