using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;


    public class program
    {
      
       /*  public HttpClient client = new HttpClient();
       

       //////////////////////////////////////  S H O W   U S E R   //////////////////
        public void ShowUser(UserDetails userdetails)
        {
            Console.WriteLine($"Name: {userdetails.name}\tEducation: " +
                $"{userdetails.jobTitle}\tLocation: {userdetails.isFired}");
        }

        public async Task<Uri> CreateUserAsync(UserDetails userdetails)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/user", userdetails);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        public async Task<UserDetails> GetUserAsync(string path)
        {
            UserDetails userdetails = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                userdetails = await response.Content.ReadAsAsync<UserDetails>();
            }
            return userdetails;
        }

        public async Task<UserDetails> UpdateUserAsync(UserDetails userdetails)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/user/{userdetails.id}", userdetails);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            userdetails = await response.Content.ReadAsAsync<UserDetails>();
            return userdetails;
        }

        public async Task<HttpStatusCode> DeleteUserAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/user/{id}");
            return response.StatusCode;
        } */
        static void Main()
        {
            // Main 
        }

    }
