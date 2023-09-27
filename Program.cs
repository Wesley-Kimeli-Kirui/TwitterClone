using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TwitterClone;
using TwitterClone.Services.Comment;
using TwitterClone.Services.Post;
using TwitterClone.Services.User;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IUser, UserService>();
builder.Services.AddScoped<IPost, PostService>();
builder.Services.AddScoped<IComment, CommentService>();

await builder.Build().RunAsync();
