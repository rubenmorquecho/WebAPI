using Xunit;
using Xunit.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;


public class testclass 
{
 string Env_BaseAddress = "https://staging-api.ct.wolterskluwer.com/";
  string Ocp_Apim_Subscription_Key = "7039674eb15a4b7d93053c6dd23b7525";
   string STGToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhY3R2VXNlcklkIjoiMzIwMDAwMDQ2NDAiLCJhY3R2SWRudElkIjoiOTg5NiIsImFjdHZBY2N0SWQiOiIzMDAwMDAwMTQ2MyIsInJlYWxVc2VySWQiOiIzMjAwMDAwNDY0MCIsInJlYWxJZG50SWQiOiI5ODk2IiwicmVhbEFjY3RJZCI6IjMwMDAwMDAxNDYzIiwicmVhbFVzclR5cCI6IjMiLCJ1c2VySWQiOiIzMjAwMDAwNDY0MCIsImFjY291bnRJZCI6IjMwMDAwMDAxNDYzIiwicmVhbFVzclRDZCI6IjMiLCJBY2N0TmFtZSI6IktpbWNvIFJlYWx0eSBDb3Jwb3JhdGlvbiIsImN1c3RTZWciOiJDJkcgLSBDb3Jwb3JhdGlvbiIsInVzZXJOYW1lIjoiU3VzYW4gTWFzb25lIiwiZ3JhbnRfdHlwZSI6ImFjY2Vzc190b2tlbiIsImlzcyI6Imh0dHBzOi8vcHRycC11eC5oY3VlLmNvbSIsImF1ZCI6Imh0dHBzOi8vcHRycC11eC5oY3VlLmNvbSIsImV4cCI6MTY3Mjg0NjMwOSwibmJmIjoxNTQ2NjE2MTcyfQ.7C3VlhYbLdXV5HPnU945QQtxALp_eAFkyKP2wJbBxF0";
  
  ////////////////////   G E T  A L L    A P I _ A d d r e s s V 1   /////////////////////////////////////////
[Fact(DisplayName = "APIAddressV1")]
  public async Task APIAddressV1()
  {
    // Define Headers and Parmeters for API call
    var client = new HttpClient();
    client.BaseAddress = new Uri(Env_BaseAddress);
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    client.DefaultRequestHeaders.TryAddWithoutValidation("Ocp-Apim-Subscription-Key", "7039674eb15a4b7d93053c6dd23b7525");
    client.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", STGToken);

    // Call API and store the response
    HttpResponseMessage response = await client.GetAsync("hcue/addresses/v1/addresses?page=1&pageSize=10&parentType=Entity");
    
    // Deserialize response into the class Root
    RootAddresses allAddresv1 = await response.Content.ReadAsAsync<RootAddresses>();
    
    // Do Assertion to PASS/FAIL TestCase
    Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
   
  }

  ////////////////////   G E T  A L L    A P I _ A d d r e s s V 2   ///////////////////////////////////////////////
[Fact(DisplayName = "APIAddressV2")]
  public async Task APIAddressV2()
  {
    // Define Headers and Parmeters for API call
    var client = new HttpClient();
    client.BaseAddress = new Uri(Env_BaseAddress);
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    client.DefaultRequestHeaders.TryAddWithoutValidation("Ocp-Apim-Subscription-Key", "7039674eb15a4b7d93053c6dd23b7525");
    client.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", STGToken);

    // Call API and store the response
    HttpResponseMessage response = await client.GetAsync("hcue/addresses/V2/addresses?page=1&pageSize=10&parentType=Entity");
    
    // Deserialize response into the class Root
    RootAddresses allAddresv2 = await response.Content.ReadAsAsync<RootAddresses>();
    
    // Do Assertion to PASS/FAIL TestCase
    Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
   
  }

   ////////////////////   G E T  A L L    A P I _ E n t i t i e s  V 1   /////////////////////////////////////////
[Fact(DisplayName = "EntitiesV1")]
  public async Task EntitiesV1()
  {
    // Define Headers and Parmeters for API call
    var client = new HttpClient();
    client.BaseAddress = new Uri(Env_BaseAddress);
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    client.DefaultRequestHeaders.TryAddWithoutValidation("Ocp-Apim-Subscription-Key", "7039674eb15a4b7d93053c6dd23b7525");
    client.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", STGToken);

    // Call API and store the response
    HttpResponseMessage response = await client.GetAsync("hcue/entities/v1/entities/");
    
    // Deserialize response into the class Root
    RootEntitiesItem allEntitiesv1 = await response.Content.ReadAsAsync<RootEntitiesItem>();
    
    // Do Assertion to PASS/FAIL TestCase
    Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
   
  }


 ////////////////////   G E T  A L L    C U S T O M   F I E L D S  _ V 1    /////////////////////////////////////////
[Fact(DisplayName = "CustomFieldsV1")]
  public async Task CustomFieldsV1()
  {
    // Define Headers and Parmeters for API call
    var client = new HttpClient();
    client.BaseAddress = new Uri(Env_BaseAddress);
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    client.DefaultRequestHeaders.TryAddWithoutValidation("Ocp-Apim-Subscription-Key", "7039674eb15a4b7d93053c6dd23b7525");
    client.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", STGToken);

    // Call API and store the response
    HttpResponseMessage response = await client.GetAsync("hcue/customFields/v1/entities/customFieldsData?status=Active");
    
    // Deserialize response into the class Root
    RootCustomFields allCustomFields = await response.Content.ReadAsAsync<RootCustomFields>();
    
    // Do Assertion to PASS/FAIL TestCase
    Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
   
  }


//  ///////////////////////////////    P O S T   /////////////////////////////////////////
// [Fact(DisplayName = "APIPost")]
//   public async Task APIPost()
//     {
//         var client = new HttpClient();
//         client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
//         client.DefaultRequestHeaders.Accept.Clear();
//         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//          UserDetails userdetails = new UserDetails
//                 {
//                     id = "333",
//                     name = "Rubennnnnnnnnnnnnnnnnnnnnnnnn" + DateTime.Today.ToLongDateString(),
//                     jobTitle="MSCsd.",
//                     isFired = false
//                 };
//         HttpResponseMessage response = await client.PostAsJsonAsync("api/crue", userdetails);
//         userdetails = await response.Content.ReadAsAsync<UserDetails>();
//         Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);

//     }

//     ///////////////////////////////    G E T B Y   I D  /////////////////////////////////////////

// [Fact(DisplayName = "APIGet")]
// public async Task APIGetByID()
// {
//     var client = new HttpClient();
//     client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
//     client.DefaultRequestHeaders.Accept.Clear();
//     client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//     HttpResponseMessage response;
//     UserDetails userdetails = new UserDetails();
//     userdetails.id="333";
//     response = await client.GetAsync($"api/crue/{userdetails.id}");
    
//     userdetails = await response.Content.ReadAsAsync<UserDetails>();
//     Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
//   }




//      ///////////////////////////////    G E T  A L L  /////////////////////////////////////////
// [Fact(DisplayName = "APIGetALL")]
//   public async Task APIGetALL()
//   {
//     var client = new HttpClient();
//     client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
//     client.DefaultRequestHeaders.Accept.Clear();
//     client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//     HttpResponseMessage response;
//     UserDetails userdetails = new UserDetails();

//     response = await client.GetAsync("api/crue");
//     List<UserDetails> alluserdetails = await response.Content.ReadAsAsync<List<UserDetails>>();
//     Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
//     //    for (int i = 0; i < alluserdetails.Count; i++)
//     //    {
//     //        Console.WriteLine("{0}\t{1}\t{2}\t", alluserdetails[i].userid, alluserdetails[i].username, alluserdetails[i].education);
//     //    }
         
//   }
 



//       ///////////////////////////////    G E T  A L L 2 /////////////////////////////////////////
// [Fact(DisplayName = "APIGetALL2")]
//   public async Task APIGetALL2()
//   {
//     var client = new HttpClient();
//     client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
//     client.DefaultRequestHeaders.Accept.Clear();
//     client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//     HttpResponseMessage response;
//     UserDetails userdetails = new UserDetails();

//     response = await client.GetAsync("api/character?search=");
//     List<UserDetails> alluserdetails = await response.Content.ReadAsAsync<List<UserDetails>>();
//     Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
//     //    for (int i = 0; i < alluserdetails.Count; i++)
//     //    {
//     //        Console.WriteLine("{0}\t{1}\t{2}\t", alluserdetails[i].userid, alluserdetails[i].username, alluserdetails[i].education);
//     //    }
         
//   }

//     ///////////////////////////////    P U T    /////////////////////////////////////////

//  [Fact(DisplayName = "APIPUT")]
//   public async Task APIPut()
//   {

//     var client = new HttpClient();
//     client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
//     client.DefaultRequestHeaders.Accept.Clear();
//     client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//     UserDetails userdetailspost = new UserDetails
//     {
//       id = "1234",
//       name = "Rubennnnnnnnnnnnnnnnnnnnnnnnn" + DateTime.Today.ToLongDateString(),
//       jobTitle="MSCsd.",
//       isFired = false
//     };
//     HttpResponseMessage responsepost = await client.PostAsJsonAsync("api/crue", userdetailspost);


//     //var client = new HttpClient();
//     //client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
//     //client.DefaultRequestHeaders.Accept.Clear();
//     //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//     UserDetails userdetails = new UserDetails
//           {
//                    id = "1234",
//                    name = "Ruben" + DateTime.Today.ToLongDateString(),
//                    jobTitle="MSC.",
//                    isFired = true
//           };
//     HttpResponseMessage response = await client.PutAsJsonAsync($"api/crue/{userdetails.id}", userdetails);
//     //userdetails = await response.Content.ReadAsAsync<UserDetails>();
//     Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
//   }
//  ////////////////////////////  D E L E T E ////////////////////////////////////
//   [Fact(DisplayName = "APIDELETE")]
//   public async Task APIDelete()
//   {
//     var client = new HttpClient();
//     client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
//     client.DefaultRequestHeaders.Accept.Clear();
//     client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//     UserDetails userdetails = new UserDetails
//           {
//                    id = "333",
//                    //name = "Ruben" + DateTime.Today.ToLongDateString(),
//                    //jobTitle="MSC.",
//                    //isFired = false
//           };
//     HttpResponseMessage response = await client.DeleteAsync($"api/crue/{userdetails.id}");
//     Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
//   }

}
