using Amax.InsurancePro.API.Extensions;
using Amax.InsurancePro.API.Middlewares;
using Amax.InsurancePro.Application;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Exceptions.Business;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Data;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
	.AddJsonOptions(x =>
	{
		x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
		x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
	})
	.ConfigureApiBehaviorOptions(options =>
	{
		options.InvalidModelStateResponseFactory = context =>
		{
			var errors = context.ModelState
				.Where(e => e.Value.Errors.Count > 0)
				.SelectMany(e => e.Value.Errors)
				.Select(e => e.ErrorMessage)
				.ToList();

			throw new InvalidModelStateException(string.Join(" ", errors));

		};
	});

builder.Services.AddAutoMapper(typeof(DomainProfiles));
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterServices(builder.Configuration);

var appSettings = new AppSettings();
builder.Configuration.GetSection("AppSettings").Bind(appSettings);
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddAuthentication(options =>
{
	options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
	options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o =>
{
	o.TokenValidationParameters = new TokenValidationParameters
	{
		ValidIssuer = appSettings.Jwt.Issuer,
		ValidAudience = appSettings.Jwt.Audience,
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appSettings.Jwt.Key)),
		ValidateIssuer = true,
		ValidateAudience = true,
		ValidateLifetime = false,
		ValidateIssuerSigningKey = true
	};
});
builder.Services.AddAuthorization(options =>
{
	options.AddPolicy("AdminOnly", policy =>
		policy.RequireRole("role", "admin"));
}); ;

builder.Services.AddCors(opt =>
{
	opt.AddPolicy(name: "AmaxPolicy",
		policy =>
		{
			policy.WithOrigins(appSettings.CORS.AllowedHosts)
				.SetIsOriginAllowedToAllowWildcardSubdomains()
				.AllowAnyMethod()
				.AllowAnyHeader();
		});
});

// Swagger configuration
builder.Services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1", new OpenApiInfo { Title = "Amax InsurancePro API", Version = "v1" });

	// Configure Swagger to use JWT Bearer authentication
	var securityScheme = new OpenApiSecurityScheme
	{
		Name = "JWT Bearer",
		Description = "Enter your JWT Bearer token",
		In = ParameterLocation.Header,
		Type = SecuritySchemeType.Http,
		Scheme = "bearer",
		BearerFormat = "JWT"
	};
	c.AddSecurityDefinition("Bearer", securityScheme);

	var securityRequirement = new OpenApiSecurityRequirement
			{
				{ securityScheme, new[] { "Bearer" } }
			};
	c.AddSecurityRequirement(securityRequirement);
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.RegisterMiddlewares();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
