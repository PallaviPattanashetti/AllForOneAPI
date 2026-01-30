<!-->==1. Command used in terminal to create API-->

dotnet new webapi --use-controllers -o Api

<!--==2. Installed below packages by Nuget -->
<PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="9.0.9" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="9.0.0" />
    <PackageReference Include="Swashbuckle.AspNetCore.Swagger" Version="9.0.0" />
    <PackageReference Include="Swashbuckle.AspNetCore.SwaggerGen" Version="9.0.0" />
    <PackageReference Include="Swashbuckle.AspNetCore.SwaggerUI" Version="9.0.0" />

<!--I created Controllers in Controller folder-->

1.HelloworldController
2.AddTwoNumbersController
3.AlphaReverseController
4.AskQueController
5.GuessItController
6.MadLabController
7.MagicBallController
8.NumReverseController
9.OddOrEvenController
10.RestaurantPickerController

<!--I created Service folder and service files-->

1.HelloWorldServices
2.AddTwoNumbersServices
3.AlphaReverseServices
4.AskQueServices
5.GuessItServices
6.RestaurantPickerServices
7.MadLabServices
8.MagicBallServices
9.NumReverseServices
10.OddOrEvenServices

<!--I added these in programme.CS-->

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
app.UseSwagger();
app.UseSwaggerUI();

//Adding scope , need to inject our services in our controller ==>
builder.Services.AddScoped<AddTwoNumbersServices>();
builder.Services.AddScoped<AlphaReverseServices>();
builder.Services.AddScoped<AskQueServices>();
builder.Services.AddScoped<GuessItServices>();
builder.Services.AddScoped<HelloWorldServices>();
builder.Services.AddScoped<MadLabServices>();
builder.Services.AddScoped<MagicBallServices>();
builder.Services.AddScoped<NumReverseServices>();
builder.Services.AddScoped<OddOrEvenServices>();
builder.Services.AddScoped<RestaurantPickerServices>();

<!--I added these in .Json-->

"launchUrl": "swagger",
in "launchBrowser": true,i changed false to true

<!--In controller-->

Created Endpoints to handle [HttpGet ] [Route("GreetUser/{userName}")]

<!--worked in service file and added these-->

public string GetGreeting(string userName)
{
return $"Hello, {userName}!";
}

<!--I run these commands to check Swaggers-->
cd api
dotnet watch run 
I was able to excute in swagger

<!--Web App and static web App-->
