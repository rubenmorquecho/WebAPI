using Xunit;
//using Xunit.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

public class testclass
{
 // private readonly ITestOutputHelper output;

 /*    public MyTestClass(ITestOutputHelper output)
    {
        this.output = output;
    } */

    [Fact]
   public void PassingAddTest()
  {
      Assert.Equal(4,  Program.add(2,2));

   }

    [Fact]
   public void FailingTest()
  {
      Assert.NotEqual(5,  Program.add(2,2));

   }
    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
   public void MyFirstTheory(int mynumber)
  {
      Assert.True(Program.isOdd(mynumber));
   }
    ///////////////////////////////    G E T  /////////////////////////////////////////
   [Fact]
  public async Task APIGet()
  {
    var client = new HttpClient();
    client.BaseAddress = new Uri("https://corewebapitraining.azurewebsites.net/");
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    HttpResponseMessage response;
    UserDetails userdetails = new UserDetails();
    //Console.WriteLine("GET 1");
    //output.WriteLine("GET {0}", temp);
    //output.WriteLine("GET ");
    response = await client.GetAsync("api/user/1");
    //Assert.True (response.IsSuccessStatusCode);
    Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);

       
  }
    ///////////////////////////////    G E T  A L L  /////////////////////////////////////////
   [Fact]
  public async Task APIGetALL()
  {
    var client = new HttpClient();
    client.BaseAddress = new Uri("https://corewebapitraining.azurewebsites.net/");
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    HttpResponseMessage response;
    UserDetails userdetails = new UserDetails();

    response = await client.GetAsync("api/user");
    Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
    //response = await client.GetAsync("api/user");
    //if (response.IsSuccessStatusCode)
    //{
    //    List<UserDetails> alluserdetails = await response.Content.ReadAsAsync<List<UserDetails>>();
    //    for (int i = 0; i < alluserdetails.Count; i++)
    //    {
    //        Console.WriteLine("{0}\t{1}\t{2}\t", alluserdetails[i].userid, alluserdetails[i].username, alluserdetails[i].education);
    //    }
    //}
       
  }
   
}
