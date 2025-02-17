using HitungAngsuranMobile.Components;
using HitungAngsuranMobile.Repositories.Contracts;
using HitungAngsuranMobile.Repositories.Logics;
using HitungAngsuranMobile.Services.Contracts;
using HitungAngsuranMobile.Services.Logics;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

//dependensi injection
builder.Services.AddScoped<ICrudTambahDataRepository, CrudTambahDataRepository>();
builder.Services.AddScoped<IJadwalAngsuranBayarTotalRepository, JadwalAngsuranBayarTotalRepository>();
builder.Services.AddScoped<IKeterlambatanDetailRepository, KeterlambatanDetailRepository>();
builder.Services.AddScoped<IJadwalAngsuranRepository, JadwalAngsuranRepository>();
builder.Services.AddScoped<IJsonDataUserRepository, JsonDataUserRepository>();
builder.Services.AddScoped<ICrudTambahDataService, CrudTambahDataService>();
builder.Services.AddScoped<IJadwalAngsuranBayarTotalService, JadwalAngsuranBayarTotalService>();
builder.Services.AddScoped<IJadwalAngsuranService, JadwalAngsuranService>();
builder.Services.AddScoped<IJsonDataUserService, JsonDataUserService>();
builder.Services.AddScoped<IKeterlambatanDetailService, KeterlambatanDetailService>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient("API", client =>
{
    client.BaseAddress = new Uri("http://localhost:5007/");
});

// Tambahkan CORS jika diperlukan
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

builder.Services.AddAntiforgery();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();

// Tambahkan CORS
app.UseCors("AllowAll");

app.MapControllers();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
