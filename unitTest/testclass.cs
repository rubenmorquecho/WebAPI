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


  private readonly ITestOutputHelper output;

    public testclass(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void MyTest()
    {
        var temp = "my class!";
        output.WriteLine("This is output from {0}", temp);
    }
 ///////////////////////////////    P O S T   /////////////////////////////////////////
[Fact(DisplayName = "APIPost")]
  public async Task Test_1APIPost()
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         UserDetails userdetails = new UserDetails
                {
                    id = "333",
                    name = "Rubennnnnnnnnnnnnnnnnnnnnnnnn" + DateTime.Today.ToLongDateString(),
                    jobTitle="MSCsd.",
                    isFired = false
                };
        HttpResponseMessage response = await client.PostAsJsonAsync("api/crue", userdetails);
        userdetails = await response.Content.ReadAsAsync<UserDetails>();
        Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);

    }

    ///////////////////////////////    G E T  /////////////////////////////////////////

[Fact(DisplayName = "APIGet")]
public async Task Test_2APIGet()
{
    var client = new HttpClient();
    client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    HttpResponseMessage response;
    UserDetails userdetails = new UserDetails();
    userdetails.id="333";
    response = await client.GetAsync($"api/crue/{userdetails.id}");
    
    userdetails = await response.Content.ReadAsAsync<UserDetails>();
    Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
  }
     ///////////////////////////////    G E T  A L L  /////////////////////////////////////////
[Fact(DisplayName = "APIGetALL")]
  public async Task Test_3APIGetALL()
  {
    var client = new HttpClient();
    client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    HttpResponseMessage response;
    UserDetails userdetails = new UserDetails();

    response = await client.GetAsync("api/crue");
    List<UserDetails> alluserdetails = await response.Content.ReadAsAsync<List<UserDetails>>();
    Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
    //    for (int i = 0; i < alluserdetails.Count; i++)
    //    {
    //        Console.WriteLine("{0}\t{1}\t{2}\t", alluserdetails[i].userid, alluserdetails[i].username, alluserdetails[i].education);
    //    }
         
  }
  [Fact(DisplayName = "APIGetALL2")]
  public async Task APIGetALL2()
  {
    var client = new HttpClient();
    client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    HttpResponseMessage response;
    UserDetails userdetails = new UserDetails();

    response = await client.GetAsync("api/character?search=");
    List<UserDetails> alluserdetails = await response.Content.ReadAsAsync<List<UserDetails>>();
    Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
    //    for (int i = 0; i < alluserdetails.Count; i++)
    //    {
    //        Console.WriteLine("{0}\t{1}\t{2}\t", alluserdetails[i].userid, alluserdetails[i].username, alluserdetails[i].education);
    //    }
         
  }

    ///////////////////////////////    P U T    /////////////////////////////////////////

 [Fact(DisplayName = "APIPUT")]
  public async Task Test_4APIPut()
  {

    var client = new HttpClient();
    client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    UserDetails userdetailspost = new UserDetails
    {
      id = "1234",
      name = "Rubennnnnnnnnnnnnnnnnnnnnnnnn" + DateTime.Today.ToLongDateString(),
      jobTitle="MSCsd.",
      isFired = false
    };
    HttpResponseMessage responsepost = await client.PostAsJsonAsync("api/crue", userdetailspost);


    //var client = new HttpClient();
    //client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
    //client.DefaultRequestHeaders.Accept.Clear();
    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    UserDetails userdetails = new UserDetails
          {
                   id = "1234",
                   name = "Ruben" + DateTime.Today.ToLongDateString(),
                   jobTitle="MSC.",
                   isFired = true
          };
    HttpResponseMessage response = await client.PutAsJsonAsync($"api/crue/{userdetails.id}", userdetails);
    //userdetails = await response.Content.ReadAsAsync<UserDetails>();
    Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
  }
 ////////////////////////////  D E L E T E ////////////////////////////////////
  [Fact(DisplayName = "APIDELETE")]
  public async Task Test_5APIDelete()
  {
    var client = new HttpClient();
    client.BaseAddress = new Uri("https://restool-sample-app.herokuapp.com/");
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    UserDetails userdetails = new UserDetails
          {
                   id = "333",
                   //name = "Ruben" + DateTime.Today.ToLongDateString(),
                   //jobTitle="MSC.",
                   //isFired = false
          };
    HttpResponseMessage response = await client.DeleteAsync($"api/crue/{userdetails.id}");
    Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
  }

}
