using AutoMapper;
using OktavaProject.BL;
using OktavaProject.DL;
using OktavaProject.DL.Models;
using OktavaProjectEntities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(MyMapper));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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

// Configure the HTTP request pipeline
//regards to Yafit
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
