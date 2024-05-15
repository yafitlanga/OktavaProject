using AutoMapper;
using OktavaProject.BL;
using OktavaProject.DL;
using OktavaProject.DL.Models;
using OktavaProjectEntities;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(MyMapper));
builder.Services.AddCors();// אפשור גישה לצד לקוח
builder.Services.AddControllers();

//builder.Services.AddControllers()
//    .AddJsonOptions(options =>
//    {
//        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
//        options.JsonSerializerOptions.WriteIndented = true;
//        options.JsonSerializerOptions.MaxDepth =64;
//    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure JSON serialization options
//builder.Services.AddMvc().AddJsonOptions(options =>
//{
//    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
//    options.JsonSerializerOptions.WriteIndented = true;
//});


builder.Services.AddScoped<IUserBL, UserBL>();
builder.Services.AddScoped<IUserDL, UserDL>();
builder.Services.AddScoped<IStudentBL, StudentBL>();
builder.Services.AddScoped<IStudentDL, StudentDL>();
builder.Services.AddScoped<IContactBL, ContactBL>();
builder.Services.AddScoped<IContactDL, ContactDL>();
builder.Services.AddScoped<IEventUpdateUserBL, EventUpdateUserBL>();
builder.Services.AddScoped<IEventUpdateUserDL, EventUpdateUserDL>();
builder.Services.AddScoped<IEventBL, EventBL>();
builder.Services.AddScoped<IEventDL, EventDL>();
builder.Services.AddScoped<ILookUpBL, LookUpBL>();
builder.Services.AddScoped<ILookUpDL, LookUpDL>();
builder.Services.AddScoped<ISkillUserBL, SkillUserBL>();
builder.Services.AddScoped<ISkillUserDL, SkillUserDL>();
builder.Services.AddScoped<IAcademicDegreeUserBL, AcademicDegreeUserBL>();
builder.Services.AddScoped<IAcademicDegreeUserDL, AcademicDegreeUserDL>();
builder.Services.AddScoped<ILessonBL, LessonBL>();
builder.Services.AddScoped<ILessonDL, LessonDL>();
builder.Services.AddScoped<IStudentLessonBL, StudentLessonBL>();
builder.Services.AddScoped<IStudentLessonDL, StudentLessonDL>();

var app = builder.Build();

app.UseCors(options =>
    options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
// Configure the HTTP request pipeline
//regards to Yafit
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();



